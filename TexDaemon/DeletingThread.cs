using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace TexDaemon
{
    public class DeletingThread
    {
        private Thread PThread;

        public DaemonForm BaseForm;

        public string[] Masks;

        public bool Finished = false;

        public DeletingThread(DaemonForm SprForm)
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

        private void DoTheJob()
        {
            string searchDir;
            string searchMask;
            string[] searchResults;
            
            foreach (string mask in Masks)
            {
                try
                {
                    searchDir = Regex.Replace(mask, @"(.+)\\.*", "$1");
                    searchMask = Regex.Replace(mask, @".+\\", String.Empty);
                    searchResults = Directory.GetFiles(searchDir, searchMask, SearchOption.TopDirectoryOnly);

                    foreach (string s in searchResults)
                    {
                        try
                        {
                            File.Delete(s);
                        }
                        catch (Exception deleteEx)
                        {
                            BaseForm.Invoke(new Action(() => BaseForm.WriteErrorLog(deleteEx.Message)));
                        }
                    }
                }
                catch (Exception ex)
                {
                    BaseForm.Invoke(new Action(() => BaseForm.WriteErrorLog(ex.Message)));
                }
                BaseForm.Invoke(new Action(() =>
                {
                    BaseForm.QtyProcessed += 1;
                    BaseForm.UpdateProgress();
                }));

                if (BaseForm.IsProcessingAborted)
                {
                    Finished = true;
                    BaseForm.Invoke(new Action(() => BaseForm.WaitDeletesCompleted()));
                    break;
                }
            }
            Masks = null;
            Finished = true;
        }
    }
}
