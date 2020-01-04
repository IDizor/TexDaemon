namespace TexDaemon
{
    partial class ExecSQLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbDbServers = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSQL = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbDbServers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel1.Size = new System.Drawing.Size(763, 39);
            this.panel1.TabIndex = 0;
            // 
            // chbDbServers
            // 
            this.chbDbServers.FormattingEnabled = true;
            this.chbDbServers.Location = new System.Drawing.Point(8, 10);
            this.chbDbServers.Name = "chbDbServers";
            this.chbDbServers.Size = new System.Drawing.Size(121, 21);
            this.chbDbServers.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(599, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 23);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(81, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(0, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSQL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.panel3.Size = new System.Drawing.Size(763, 335);
            this.panel3.TabIndex = 1;
            // 
            // txtSQL
            // 
            this.txtSQL.AutoScrollMinSize = new System.Drawing.Size(211, 60);
            this.txtSQL.BackBrush = null;
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSQL.CharHeight = 15;
            this.txtSQL.CharWidth = 8;
            this.txtSQL.CommentPrefix = "--";
            this.txtSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtSQL.IsReplaceMode = false;
            this.txtSQL.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtSQL.LeftBracket = '(';
            this.txtSQL.Location = new System.Drawing.Point(8, 8);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Paddings = new System.Windows.Forms.Padding(0);
            this.txtSQL.RightBracket = ')';
            this.txtSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSQL.Size = new System.Drawing.Size(747, 327);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.Text = "select FieldID\r\nfrom SomeTable\r\nwhere Name like \'door%\'\r\n  and Level = \'public\'";
            this.txtSQL.Zoom = 100;
            // 
            // ExecSQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 374);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ExecSQLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL Query";
            this.Load += new System.EventHandler(this.ExecSQLForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel3;
        public FastColoredTextBoxNS.FastColoredTextBox txtSQL;
        public System.Windows.Forms.ComboBox chbDbServers;
    }
}