using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TexDaemon
{
    public static class Program
    {
        public static List<string[]> Args;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool showSuperForm = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            
            if (args.Length > 0)
            {
                Args = args.Select(a => new String[2] { Regex.Replace(a, @"\W+(\w+).*", @"$1").ToLower(), (a.IndexOf("=") > 0 ? Regex.Replace(a, @".+?=(.*)", @"$1") : String.Empty) }).ToList();
                foreach (string[] a in Args)
                {
                    if (a[0] == "h" || a[0] == "hidden")
                    {
                        showSuperForm = false;
                        break;
                    }
                }
            }
            
            Application.Run(new DaemonForm(showSuperForm));
        }
    }
}
