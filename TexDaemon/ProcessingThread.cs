using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.XPath;
using Jint;

namespace TexDaemon
{
    public class ProcessingThread
    {
        private Thread ProcThread;

        private Engine JsEngine;

        public DaemonForm BaseForm;

        public string[] Files;

        public bool Finished = false;

        public ProcessingThread(DaemonForm SprForm)
        {
            BaseForm = SprForm;
            JsEngine = new Engine();
            ProcThread = new Thread(DoTheJob);
        }

        public void StartProcessing()
        {
            if (!ProcThread.IsAlive)
            {
                Finished = false;
                ProcThread.Start();
            }
        }

        public void AbortProcessing()
        {
            if (ProcThread.IsAlive)
            {
                ProcThread.Abort();
            }
        }

        public bool IsAlive()
        {
            return ProcThread.IsAlive;
        }

        public string ReplaceDoubleSpaces(string strInput)
        {
            return Regex.Replace(strInput, @"[\s\t\r\n]{2,}", @"[\s\t\r\n]*");
        }

        private void DoTheJob()
        {
            StringBuilder textContent;
            string initialContent;
            string operationRegEx;
            string operationRegExSub;            
            string operationRegExCondition;
            bool inverseCondition;
            bool isMatchedCondition;
            Encoding fileEncoding;
            
            foreach (string filePath in Files)
            {
                if (!string.IsNullOrWhiteSpace(filePath))
                {
                    try
                    {
                        fileEncoding = GetEncoding(filePath);
                        textContent = new StringBuilder(File.ReadAllText(filePath, fileEncoding));
                        initialContent = textContent.ToString();

                        foreach (DataGridViewRow row in BaseForm.dgrProcRegExps.Rows)
                        {
                            operationRegExCondition = row.Cells[0].Value == null ? string.Empty : row.Cells[0].Value.ToString();
                            operationRegEx = row.Cells[1].Value == null ? string.Empty : row.Cells[1].Value.ToString();
                            operationRegExSub = row.Cells[2].Value == null ? string.Empty : row.Cells[2].Value.ToString();

                            if (!string.IsNullOrEmpty(operationRegEx))
                            {
                                isMatchedCondition = true;

                                if (!string.IsNullOrEmpty(operationRegExCondition))
                                {
                                    string[] conditions = Regex.Split(operationRegExCondition, @"\|\|\|");

                                    foreach (string s in conditions)
                                    {
                                        if (!string.IsNullOrEmpty(s))
                                        {
                                            inverseCondition = s[0] == '!';
                                            operationRegExCondition = inverseCondition ? s.Substring(1) : s;

                                            if (Regex.IsMatch(initialContent, operationRegExCondition) == inverseCondition)
                                            {
                                                isMatchedCondition = false;
                                                BaseForm.Invoke(new Action(() => BaseForm.WriteLog(filePath + " : failed condition: " + s)));
                                            }
                                        }
                                    }
                                }

                                if (isMatchedCondition)
                                {
                                    operationRegEx = ReplaceDoubleSpaces(operationRegEx);
                                    ProcessText(ref textContent, operationRegEx, operationRegExSub);
                                }
                            }
                        }

                        var updatedContent = textContent.ToString();

                        if (initialContent != updatedContent)
                        {
                            // make backup
                            if (BaseForm.BackupCheckBox.Checked)
                            {
                                File.Copy(
                                    filePath,
                                    filePath + string.Format("_{0}.bak", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")),
                                    false);
                            }

                            // save result
                            File.WriteAllText(filePath, updatedContent, fileEncoding);
                        }
                    }
                    catch (Exception ex)
                    {
                        BaseForm.Invoke(new Action(() => BaseForm.WriteErrorLog(ex.Message)));
                    }
                }
                BaseForm.Invoke(new Action(() =>
                {
                    BaseForm.QtyProcessed += 1;
                    BaseForm.UpdateProgress();
                }));

                if (BaseForm.IsProcessingAborted)
                {
                    Finished = true;
                    BaseForm.Invoke(new Action(() => BaseForm.WaitThreadsCompleted()));
                    break;
                }
            }
            Files = null;
            Finished = true;
        }

        private void ProcessText(ref StringBuilder textContent, string operationRegEx, string operationRegExSub)
        {
            var stringContent = textContent.ToString();
            var isJS = operationRegExSub.StartsWith("js:");
            var shift = 0;

            if (isJS)
            {
                operationRegExSub = operationRegExSub.Substring(3);
                var matches = Regex.Matches(stringContent, operationRegEx, RegexOptions.IgnoreCase);

                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        var js = match.Result(operationRegExSub);

                        // check if all placeholders populated
                        if (!Regex.IsMatch(js, @"\$\d+"))
                        {
                            var jsResult = JsEngine.Execute(js).GetCompletionValue().ToString();
                            textContent.Remove(match.Index + shift, match.Length);
                            textContent.Insert(match.Index + shift, jsResult);
                            shift = shift + jsResult.Length - match.Length;
                        }
                    }
                }
            }
            else
            {
                textContent = new StringBuilder(Regex.Replace(stringContent, operationRegEx, operationRegExSub));
            }
        }

        /// <summary>
        /// Determines a text file's encoding by analyzing its byte order mark (BOM).
        /// Defaults to ASCII when detection of the text file's endianness fails.
        /// </summary>
        /// <param name="fileName">The text file to analyze.</param>
        /// <returns>The detected encoding.</returns>
        private static Encoding GetEncoding(string fileName)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;

            return Encoding.GetEncoding(1252); // russian
        }
    }
}
