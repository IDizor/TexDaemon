namespace TexDaemon
{
    partial class FilterByContentForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtRemoveFiles = new System.Windows.Forms.RadioButton();
            this.rbtKeepFiles = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFilterRegEx = new System.Windows.Forms.Label();
            this.txtFilterRegEx = new System.Windows.Forms.TextBox();
            this.chbRemoveWhenError = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbRemoveWhenError);
            this.panel2.Controls.Add(this.rbtRemoveFiles);
            this.panel2.Controls.Add(this.rbtKeepFiles);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 35);
            this.panel2.TabIndex = 1;
            // 
            // rbtRemoveFiles
            // 
            this.rbtRemoveFiles.AutoSize = true;
            this.rbtRemoveFiles.Location = new System.Drawing.Point(144, 10);
            this.rbtRemoveFiles.Name = "rbtRemoveFiles";
            this.rbtRemoveFiles.Size = new System.Drawing.Size(130, 17);
            this.rbtRemoveFiles.TabIndex = 5;
            this.rbtRemoveFiles.TabStop = true;
            this.rbtRemoveFiles.Text = "Remove matched files";
            this.rbtRemoveFiles.UseVisualStyleBackColor = true;
            // 
            // rbtKeepFiles
            // 
            this.rbtKeepFiles.AutoSize = true;
            this.rbtKeepFiles.Checked = true;
            this.rbtKeepFiles.Location = new System.Drawing.Point(13, 10);
            this.rbtKeepFiles.Name = "rbtKeepFiles";
            this.rbtKeepFiles.Size = new System.Drawing.Size(115, 17);
            this.rbtKeepFiles.TabIndex = 4;
            this.rbtKeepFiles.TabStop = true;
            this.rbtKeepFiles.Text = "Keep matched files";
            this.rbtKeepFiles.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(430, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 35);
            this.panel3.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(87, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFilter.Location = new System.Drawing.Point(4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFilterRegEx);
            this.panel4.Controls.Add(this.txtFilterRegEx);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8, 0, 8, 4);
            this.panel4.Size = new System.Drawing.Size(600, 46);
            this.panel4.TabIndex = 2;
            // 
            // lblFilterRegEx
            // 
            this.lblFilterRegEx.AutoSize = true;
            this.lblFilterRegEx.Location = new System.Drawing.Point(8, 8);
            this.lblFilterRegEx.Name = "lblFilterRegEx";
            this.lblFilterRegEx.Size = new System.Drawing.Size(67, 13);
            this.lblFilterRegEx.TabIndex = 1;
            this.lblFilterRegEx.Text = "Filter RegEx:";
            // 
            // txtFilterRegEx
            // 
            this.txtFilterRegEx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFilterRegEx.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterRegEx.Location = new System.Drawing.Point(8, 24);
            this.txtFilterRegEx.Name = "txtFilterRegEx";
            this.txtFilterRegEx.Size = new System.Drawing.Size(584, 18);
            this.txtFilterRegEx.TabIndex = 0;
            // 
            // chbRemoveWhenError
            // 
            this.chbRemoveWhenError.AutoSize = true;
            this.chbRemoveWhenError.Location = new System.Drawing.Point(280, 10);
            this.chbRemoveWhenError.Name = "chbRemoveWhenError";
            this.chbRemoveWhenError.Size = new System.Drawing.Size(119, 17);
            this.chbRemoveWhenError.TabIndex = 6;
            this.chbRemoveWhenError.Text = "Remove when error";
            this.chbRemoveWhenError.UseVisualStyleBackColor = true;
            // 
            // FilterByContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 80);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterByContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter files by content";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFilter;
        public System.Windows.Forms.RadioButton rbtRemoveFiles;
        public System.Windows.Forms.RadioButton rbtKeepFiles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFilterRegEx;
        public System.Windows.Forms.TextBox txtFilterRegEx;
        public System.Windows.Forms.CheckBox chbRemoveWhenError;
    }
}