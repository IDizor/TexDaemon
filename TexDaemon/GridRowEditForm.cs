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
    public partial class GridRowEditForm : Form
    {
        public GridRowEditForm()
        {
            InitializeComponent();
        }

        private void txtRegExSub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtRegExSub.SelectAll();
            }
        }
    }
}
