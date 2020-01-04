using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace TexDaemon
{
    public partial class ExecSQLForm : Form
    {
        public Dictionary<string, string> DbServers = new Dictionary<string, string> { { "10.190.10.130", "DB-DEV" }, { "10.190.10.175", "DB-QA" }, { "10.190.10.135", "DB-STAGE" }, { "10.190.10.30", "DB-PROD" } };

        public ExecSQLForm()
        {
            InitializeComponent();
        }

        private void SetupHighlighter(Language Lng)
        {
            txtSQL.ClearStylesBuffer();
            txtSQL.Range.ClearStyle(StyleIndex.All);
            txtSQL.Language = Lng;
            txtSQL.OnSyntaxHighlight(new TextChangedEventArgs(txtSQL.Range));
        }

        private void ExecSQLForm_Load(object sender, EventArgs e)
        {
            if (chbDbServers.Text == String.Empty)
            {
                chbDbServers.DataSource = new BindingSource(DbServers, null);
                chbDbServers.ValueMember = "Key";
                chbDbServers.DisplayMember = "Value";
            }
            SetupHighlighter(Language.SQL);
        }
    }
}
