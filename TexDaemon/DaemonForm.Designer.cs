namespace TexDaemon
{
    partial class DaemonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaemonForm));
            this.loadFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearchResultsPopup = new System.Windows.Forms.Button();
            this.txtSearchResults = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtRegExSubPR = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRegExPR = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRegExSubPR = new System.Windows.Forms.Label();
            this.lblRegExPR = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProcessResults = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDeepSearch = new System.Windows.Forms.CheckBox();
            this.cbxSearchTarget = new System.Windows.Forms.ComboBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.txtSearchCriteria = new System.Windows.Forms.TextBox();
            this.lblStartDir = new System.Windows.Forms.Label();
            this.txtStartDir = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dgrProcRegExps = new System.Windows.Forms.DataGridView();
            this.ConditionRegEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Substitution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblCurrentSettingsFile = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.ProcessingBar = new System.Windows.Forms.ProgressBar();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BackupCheckBox = new System.Windows.Forms.CheckBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblProcessingStatus = new System.Windows.Forms.Label();
            this.btnProcessFiles = new System.Windows.Forms.Button();
            this.ctmSearchResultsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniCustomOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDeleteRealFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniSearchResultsSQLFill = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFilterResultsByContent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmGridRowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableDisableRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javascriptSubstitutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProcRegExps)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.ctmSearchResultsMenu.SuspendLayout();
            this.ctmGridRowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileDialogLoad
            // 
            this.loadFileDialogLoad.Filter = "JSON File (*.json)|*.json|Any file|*.*";
            // 
            // saveFileDialogSave
            // 
            this.saveFileDialogSave.Filter = "JSON File (*.json)|*.json|Any file|*.*";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 24;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel16);
            this.splitContainer1.Panel2.Controls.Add(this.panel15);
            this.splitContainer1.Panel2.Controls.Add(this.panel10);
            this.splitContainer1.Panel2MinSize = 24;
            this.splitContainer1.Size = new System.Drawing.Size(914, 681);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 338);
            this.panel1.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSearchResultsPopup);
            this.panel9.Controls.Add(this.txtSearchResults);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 72);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(12, 4, 12, 0);
            this.panel9.Size = new System.Drawing.Size(912, 205);
            this.panel9.TabIndex = 2;
            // 
            // btnSearchResultsPopup
            // 
            this.btnSearchResultsPopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchResultsPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchResultsPopup.Location = new System.Drawing.Point(38, 27);
            this.btnSearchResultsPopup.Name = "btnSearchResultsPopup";
            this.btnSearchResultsPopup.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnSearchResultsPopup.Size = new System.Drawing.Size(16, 16);
            this.btnSearchResultsPopup.TabIndex = 8;
            this.btnSearchResultsPopup.Text = "^";
            this.btnSearchResultsPopup.UseVisualStyleBackColor = true;
            this.btnSearchResultsPopup.Click += new System.EventHandler(this.btnSearchResultsPopup_Click);
            // 
            // txtSearchResults
            // 
            this.txtSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchResults.Location = new System.Drawing.Point(12, 4);
            this.txtSearchResults.MaxLength = 0;
            this.txtSearchResults.Multiline = true;
            this.txtSearchResults.Name = "txtSearchResults";
            this.txtSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchResults.Size = new System.Drawing.Size(888, 201);
            this.txtSearchResults.TabIndex = 7;
            this.txtSearchResults.WordWrap = false;
            this.txtSearchResults.TextChanged += new System.EventHandler(this.txtSearchResults_TextChanged);
            this.txtSearchResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchResults_KeyDown);
            this.txtSearchResults.Resize += new System.EventHandler(this.txtSearchResults_Resize);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 61);
            this.panel4.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtRegExSubPR);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(80, 31);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel8.Size = new System.Drawing.Size(700, 30);
            this.panel8.TabIndex = 3;
            // 
            // txtRegExSubPR
            // 
            this.txtRegExSubPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRegExSubPR.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegExSubPR.Location = new System.Drawing.Point(0, 4);
            this.txtRegExSubPR.Name = "txtRegExSubPR";
            this.txtRegExSubPR.Size = new System.Drawing.Size(700, 18);
            this.txtRegExSubPR.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtRegExPR);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(80, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel7.Size = new System.Drawing.Size(700, 31);
            this.panel7.TabIndex = 2;
            // 
            // txtRegExPR
            // 
            this.txtRegExPR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRegExPR.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegExPR.Location = new System.Drawing.Point(0, 9);
            this.txtRegExPR.Name = "txtRegExPR";
            this.txtRegExPR.Size = new System.Drawing.Size(700, 18);
            this.txtRegExPR.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblRegExSubPR);
            this.panel6.Controls.Add(this.lblRegExPR);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 61);
            this.panel6.TabIndex = 1;
            // 
            // lblRegExSubPR
            // 
            this.lblRegExSubPR.AutoSize = true;
            this.lblRegExSubPR.Location = new System.Drawing.Point(12, 38);
            this.lblRegExSubPR.Name = "lblRegExSubPR";
            this.lblRegExSubPR.Size = new System.Drawing.Size(65, 13);
            this.lblRegExSubPR.TabIndex = 15;
            this.lblRegExSubPR.Text = "Substitution:";
            // 
            // lblRegExPR
            // 
            this.lblRegExPR.AutoSize = true;
            this.lblRegExPR.Location = new System.Drawing.Point(12, 10);
            this.lblRegExPR.Name = "lblRegExPR";
            this.lblRegExPR.Size = new System.Drawing.Size(42, 13);
            this.lblRegExPR.TabIndex = 14;
            this.lblRegExPR.Text = "RegEx:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnProcessResults);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(780, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 61);
            this.panel5.TabIndex = 0;
            // 
            // btnProcessResults
            // 
            this.btnProcessResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessResults.Location = new System.Drawing.Point(6, 7);
            this.btnProcessResults.Name = "btnProcessResults";
            this.btnProcessResults.Size = new System.Drawing.Size(116, 48);
            this.btnProcessResults.TabIndex = 10;
            this.btnProcessResults.Text = "Apply RegEx for each line";
            this.btnProcessResults.UseVisualStyleBackColor = true;
            this.btnProcessResults.Click += new System.EventHandler(this.btnProcessResults_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkDeepSearch);
            this.panel2.Controls.Add(this.cbxSearchTarget);
            this.panel2.Controls.Add(this.lblSearchResults);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblSearchCriteria);
            this.panel2.Controls.Add(this.txtSearchCriteria);
            this.panel2.Controls.Add(this.lblStartDir);
            this.panel2.Controls.Add(this.txtStartDir);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 72);
            this.panel2.TabIndex = 0;
            // 
            // chkDeepSearch
            // 
            this.chkDeepSearch.AutoSize = true;
            this.chkDeepSearch.Location = new System.Drawing.Point(457, 49);
            this.chkDeepSearch.Name = "chkDeepSearch";
            this.chkDeepSearch.Size = new System.Drawing.Size(126, 18);
            this.chkDeepSearch.TabIndex = 30;
            this.chkDeepSearch.Text = "Search in subfolders";
            this.chkDeepSearch.UseCompatibleTextRendering = true;
            this.chkDeepSearch.UseVisualStyleBackColor = true;
            // 
            // cbxSearchTarget
            // 
            this.cbxSearchTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchTarget.FormattingEnabled = true;
            this.cbxSearchTarget.Items.AddRange(new object[] {
            "Files Only",
            "Folders Only",
            "Files and Folders"});
            this.cbxSearchTarget.Location = new System.Drawing.Point(457, 24);
            this.cbxSearchTarget.Name = "cbxSearchTarget";
            this.cbxSearchTarget.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchTarget.TabIndex = 29;
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(12, 57);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(77, 13);
            this.lblSearchResults.TabIndex = 28;
            this.lblSearchResults.Text = "Search results:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowLog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(824, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 72);
            this.panel3.TabIndex = 27;
            // 
            // btnShowLog
            // 
            this.btnShowLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLog.Location = new System.Drawing.Point(3, 22);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(75, 23);
            this.btnShowLog.TabIndex = 27;
            this.btnShowLog.Text = "Show Log";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Location = new System.Drawing.Point(241, 9);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(127, 13);
            this.lblSearchCriteria.TabIndex = 25;
            this.lblSearchCriteria.Text = "Subfolder Search Criteria:";
            // 
            // txtSearchCriteria
            // 
            this.txtSearchCriteria.Location = new System.Drawing.Point(241, 25);
            this.txtSearchCriteria.Name = "txtSearchCriteria";
            this.txtSearchCriteria.Size = new System.Drawing.Size(135, 20);
            this.txtSearchCriteria.TabIndex = 24;
            this.txtSearchCriteria.Text = "*-data";
            // 
            // lblStartDir
            // 
            this.lblStartDir.AutoSize = true;
            this.lblStartDir.Location = new System.Drawing.Point(12, 9);
            this.lblStartDir.Name = "lblStartDir";
            this.lblStartDir.Size = new System.Drawing.Size(114, 13);
            this.lblStartDir.TabIndex = 23;
            this.lblStartDir.Text = "Search Start Directory:";
            // 
            // txtStartDir
            // 
            this.txtStartDir.Location = new System.Drawing.Point(12, 25);
            this.txtStartDir.Name = "txtStartDir";
            this.txtStartDir.Size = new System.Drawing.Size(223, 20);
            this.txtStartDir.TabIndex = 22;
            this.txtStartDir.Text = "C:\\";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(382, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search for";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dgrProcRegExps);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 25);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(12, 0, 12, 6);
            this.panel16.Size = new System.Drawing.Size(912, 276);
            this.panel16.TabIndex = 27;
            // 
            // dgrProcRegExps
            // 
            this.dgrProcRegExps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProcRegExps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConditionRegEx,
            this.RegEx,
            this.Substitution});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrProcRegExps.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgrProcRegExps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrProcRegExps.Location = new System.Drawing.Point(12, 0);
            this.dgrProcRegExps.Name = "dgrProcRegExps";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrProcRegExps.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrProcRegExps.Size = new System.Drawing.Size(888, 270);
            this.dgrProcRegExps.TabIndex = 13;
            this.dgrProcRegExps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProcRegExps_CellClick);
            this.dgrProcRegExps.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProcRegExps_CellValueChanged);
            this.dgrProcRegExps.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgrProcRegExps_RowHeaderMouseClick);
            this.dgrProcRegExps.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgrProcRegExps_RowHeaderMouseDoubleClick);
            // 
            // ConditionRegEx
            // 
            this.ConditionRegEx.HeaderText = "Condition RegEx";
            this.ConditionRegEx.Name = "ConditionRegEx";
            this.ConditionRegEx.Width = 120;
            // 
            // RegEx
            // 
            this.RegEx.HeaderText = "RegEx";
            this.RegEx.Name = "RegEx";
            this.RegEx.Width = 350;
            // 
            // Substitution
            // 
            this.Substitution.HeaderText = "Substitution";
            this.Substitution.Name = "Substitution";
            this.Substitution.Width = 350;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnSave);
            this.panel15.Controls.Add(this.lblGridTitle);
            this.panel15.Controls.Add(this.lblCurrentSettingsFile);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.panel15.Size = new System.Drawing.Size(912, 25);
            this.panel15.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(855, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 19);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGridTitle.Location = new System.Drawing.Point(11, 3);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(164, 15);
            this.lblGridTitle.TabIndex = 14;
            this.lblGridTitle.Text = "Regular Expressions for each file:";
            // 
            // lblCurrentSettingsFile
            // 
            this.lblCurrentSettingsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentSettingsFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCurrentSettingsFile.Location = new System.Drawing.Point(11, 3);
            this.lblCurrentSettingsFile.Name = "lblCurrentSettingsFile";
            this.lblCurrentSettingsFile.Padding = new System.Windows.Forms.Padding(0, 2, 48, 0);
            this.lblCurrentSettingsFile.Size = new System.Drawing.Size(890, 19);
            this.lblCurrentSettingsFile.TabIndex = 17;
            this.lblCurrentSettingsFile.Text = "current-opened-file.json";
            this.lblCurrentSettingsFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCurrentSettingsFile.UseCompatibleTextRendering = true;
            this.lblCurrentSettingsFile.TextChanged += new System.EventHandler(this.LblCurrentSettingsFile_TextChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 301);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(912, 34);
            this.panel10.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.ProcessingBar);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(235, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel13.Size = new System.Drawing.Size(502, 26);
            this.panel13.TabIndex = 27;
            // 
            // ProcessingBar
            // 
            this.ProcessingBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessingBar.Location = new System.Drawing.Point(0, 3);
            this.ProcessingBar.Name = "ProcessingBar";
            this.ProcessingBar.Size = new System.Drawing.Size(502, 23);
            this.ProcessingBar.Step = 1;
            this.ProcessingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProcessingBar.TabIndex = 25;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnLoad);
            this.panel12.Controls.Add(this.btnSaveAs);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(737, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(175, 34);
            this.panel12.TabIndex = 26;
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(88, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.Location = new System.Drawing.Point(7, 3);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 23;
            this.btnSaveAs.Text = "Save as...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.BackupCheckBox);
            this.panel11.Controls.Add(this.btnAbort);
            this.panel11.Controls.Add(this.lblProcessingStatus);
            this.panel11.Controls.Add(this.btnProcessFiles);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(235, 34);
            this.panel11.TabIndex = 25;
            // 
            // BackupCheckBox
            // 
            this.BackupCheckBox.AutoSize = true;
            this.BackupCheckBox.Location = new System.Drawing.Point(127, 7);
            this.BackupCheckBox.Name = "BackupCheckBox";
            this.BackupCheckBox.Size = new System.Drawing.Size(98, 17);
            this.BackupCheckBox.TabIndex = 27;
            this.BackupCheckBox.Text = "Make Backups";
            this.BackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.Location = new System.Drawing.Point(12, 21);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(109, 23);
            this.btnAbort.TabIndex = 26;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblProcessingStatus
            // 
            this.lblProcessingStatus.AutoSize = true;
            this.lblProcessingStatus.Location = new System.Drawing.Point(127, 8);
            this.lblProcessingStatus.Name = "lblProcessingStatus";
            this.lblProcessingStatus.Size = new System.Drawing.Size(37, 13);
            this.lblProcessingStatus.TabIndex = 25;
            this.lblProcessingStatus.Text = "Status";
            // 
            // btnProcessFiles
            // 
            this.btnProcessFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessFiles.Location = new System.Drawing.Point(12, 3);
            this.btnProcessFiles.Name = "btnProcessFiles";
            this.btnProcessFiles.Size = new System.Drawing.Size(109, 23);
            this.btnProcessFiles.TabIndex = 24;
            this.btnProcessFiles.Text = "Process files";
            this.btnProcessFiles.UseVisualStyleBackColor = true;
            this.btnProcessFiles.Click += new System.EventHandler(this.btnProcessFiles_Click);
            // 
            // ctmSearchResultsMenu
            // 
            this.ctmSearchResultsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCustomOperation,
            this.mniDeleteRealFiles,
            this.toolStripSeparator1,
            this.mniSearchResultsSQLFill,
            this.mniFilterResultsByContent,
            this.toolStripSeparator2});
            this.ctmSearchResultsMenu.Name = "ctmSearchResultsMenu";
            this.ctmSearchResultsMenu.Size = new System.Drawing.Size(173, 104);
            this.ctmSearchResultsMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.ctmSearchResultsMenu_Closed);
            this.ctmSearchResultsMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ctmSearchResultsMenu_PreviewKeyDown);
            // 
            // mniCustomOperation
            // 
            this.mniCustomOperation.Name = "mniCustomOperation";
            this.mniCustomOperation.Size = new System.Drawing.Size(172, 22);
            this.mniCustomOperation.Text = "Custom Operation";
            this.mniCustomOperation.Click += new System.EventHandler(this.mniCustomOperation_Click);
            // 
            // mniDeleteRealFiles
            // 
            this.mniDeleteRealFiles.Name = "mniDeleteRealFiles";
            this.mniDeleteRealFiles.Size = new System.Drawing.Size(172, 22);
            this.mniDeleteRealFiles.Text = "Delete real files";
            this.mniDeleteRealFiles.Click += new System.EventHandler(this.mniDeleteRealFiles_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // mniSearchResultsSQLFill
            // 
            this.mniSearchResultsSQLFill.Name = "mniSearchResultsSQLFill";
            this.mniSearchResultsSQLFill.Size = new System.Drawing.Size(172, 22);
            this.mniSearchResultsSQLFill.Text = "Fill using SQL";
            this.mniSearchResultsSQLFill.Click += new System.EventHandler(this.mniSearchResultsSQLFill_Click);
            // 
            // mniFilterResultsByContent
            // 
            this.mniFilterResultsByContent.Name = "mniFilterResultsByContent";
            this.mniFilterResultsByContent.Size = new System.Drawing.Size(172, 22);
            this.mniFilterResultsByContent.Text = "Filter by content";
            this.mniFilterResultsByContent.Click += new System.EventHandler(this.mniFilterResultsByContent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // ctmGridRowMenu
            // 
            this.ctmGridRowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDisableRowToolStripMenuItem,
            this.javascriptSubstitutionToolStripMenuItem});
            this.ctmGridRowMenu.Name = "ctmGridRowMenu";
            this.ctmGridRowMenu.Size = new System.Drawing.Size(193, 70);
            // 
            // enableDisableRowToolStripMenuItem
            // 
            this.enableDisableRowToolStripMenuItem.Name = "enableDisableRowToolStripMenuItem";
            this.enableDisableRowToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.enableDisableRowToolStripMenuItem.Text = "Enable/Disable Row";
            this.enableDisableRowToolStripMenuItem.Click += new System.EventHandler(this.EnableDisableRowToolStripMenuItem_Click);
            // 
            // javascriptSubstitutionToolStripMenuItem
            // 
            this.javascriptSubstitutionToolStripMenuItem.Name = "javascriptSubstitutionToolStripMenuItem";
            this.javascriptSubstitutionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.javascriptSubstitutionToolStripMenuItem.Text = "Javascript Substitution";
            this.javascriptSubstitutionToolStripMenuItem.Click += new System.EventHandler(this.JavascriptSubstitutionToolStripMenuItem_Click);
            // 
            // DaemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DaemonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TexDaemon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuperForm_FormClosing);
            this.Load += new System.EventHandler(this.SuperForm_Load);
            this.Shown += new System.EventHandler(this.SuperForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProcRegExps)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ctmSearchResultsMenu.ResumeLayout(false);
            this.ctmGridRowMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog loadFileDialogLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox txtSearchResults;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtRegExSubPR;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtRegExPR;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRegExSubPR;
        private System.Windows.Forms.Label lblRegExPR;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnProcessResults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.TextBox txtSearchCriteria;
        private System.Windows.Forms.Label lblStartDir;
        private System.Windows.Forms.TextBox txtStartDir;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.ProgressBar ProcessingBar;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnAbort;
        public System.Windows.Forms.Label lblProcessingStatus;
        private System.Windows.Forms.Button btnProcessFiles;
        private System.Windows.Forms.Panel panel16;
        public System.Windows.Forms.DataGridView dgrProcRegExps;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionRegEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Substitution;
        private System.Windows.Forms.ComboBox cbxSearchTarget;
        private System.Windows.Forms.CheckBox chkDeepSearch;
        private System.Windows.Forms.Button btnSearchResultsPopup;
        private System.Windows.Forms.ContextMenuStrip ctmSearchResultsMenu;
        private System.Windows.Forms.Label lblCurrentSettingsFile;
        private System.Windows.Forms.ToolStripMenuItem mniSearchResultsSQLFill;
        private System.Windows.Forms.ToolStripMenuItem mniDeleteRealFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniFilterResultsByContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.CheckBox BackupCheckBox;
        private System.Windows.Forms.ToolStripMenuItem mniCustomOperation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip ctmGridRowMenu;
        private System.Windows.Forms.ToolStripMenuItem enableDisableRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javascriptSubstitutionToolStripMenuItem;
    }
}

