using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TexDaemon
{
    public class FilteringThread
    {
        private Thread PThread;

        public DaemonForm BaseForm;

        public string[] Files;

        public bool Finished = false;

        public FilteringThread(DaemonForm SprForm)
        {
            BaseForm = SprForm;
            PThread = new Thread(DoTheJob);
        }

        public void StartProcessing()
        {
            if (!PThread.IsAlive)
            {
                Finished = false;
                PThread.Start();
            }
        }

        public void AbortProcessing()
        {
            if (PThread.IsAlive)
            {
                PThread.Abort();
            }
        }

        public bool IsAlive()
        {
            return PThread.IsAlive;
        }

        public string ReplaceDoubleSpaces(string strInput)
        {
            return Regex.Replace(strInput, @"[\s\t\r\n]{2,}", @"[\s\t\r\n]*");
        }

        private void DoTheJob()
        {
            string textContent;
            string filterRegEx = BaseForm.SearchResultsFilterForm.txtFilterRegEx.Text;
            bool keepMatchedFiles = BaseForm.SearchResultsFilterForm.rbtKeepFiles.Checked;
            bool removeWhenError = BaseForm.SearchResultsFilterForm.chbRemoveWhenError.Checked;
            
            foreach (string filepath in Files)
            {
                try
                {
                    textContent = string.Join("\n", File.ReadAllLines(filepath));

                    if (Regex.IsMatch(textContent, filterRegEx) == keepMatchedFiles)
                    {
                        BaseForm.Invoke(new Action(() => BaseForm.FilterResults.Add(filepath)));
                    }
                }
                catch (Exception ex)
                {
                    if (!removeWhenError)
                    {
                        BaseForm.Invoke(new Action(() => BaseForm.FilterResults.Add(filepath)));
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
                    BaseForm.Invoke(new Action(() => BaseForm.WaitFiltersCompleted()));
                    break;
                }
            }
            Files = null;
            Finished = true;
        }
    }
}
