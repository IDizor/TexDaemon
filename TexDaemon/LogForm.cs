using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TexDaemon
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        public void Log(string strMessage)
        {
            LogBox.AppendText(DateTime.Now + ": " + strMessage + "\r\n");
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void LogBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                LogBox.SelectAll();
            }
        }
    }
}
