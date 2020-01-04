namespace TexDaemon
{
    partial class GridRowEditForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRegEx = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRegExSub = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblCondition);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 84);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtCondition);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 24);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel7.Size = new System.Drawing.Size(668, 20);
            this.panel7.TabIndex = 5;
            // 
            // txtCondition
            // 
            this.txtCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCondition.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(8, 0);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(652, 18);
            this.txtCondition.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblRegEx);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(668, 20);
            this.panel6.TabIndex = 4;
            // 
            // lblRegEx
            // 
            this.lblRegEx.AutoSize = true;
            this.lblRegEx.Location = new System.Drawing.Point(8, 4);
            this.lblRegEx.Name = "lblRegEx";
            this.lblRegEx.Size = new System.Drawing.Size(101, 13);
            this.lblRegEx.TabIndex = 1;
            this.lblRegEx.Text = "Regular Expression:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(8, 8);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(89, 13);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "Condition RegEx:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtRegEx);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel3.Size = new System.Drawing.Size(668, 20);
            this.panel3.TabIndex = 2;
            // 
            // txtRegEx
            // 
            this.txtRegEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegEx.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEx.Location = new System.Drawing.Point(8, 0);
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(652, 18);
            this.txtRegEx.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 381);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.panel4.Size = new System.Drawing.Size(668, 35);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnOK);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(502, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 23);
            this.panel5.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(83, 0);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRegExSub);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.panel2.Size = new System.Drawing.Size(668, 297);
            this.panel2.TabIndex = 3;
            // 
            // txtRegExSub
            // 
            this.txtRegExSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegExSub.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegExSub.Location = new System.Drawing.Point(8, 8);
            this.txtRegExSub.Multiline = true;
            this.txtRegExSub.Name = "txtRegExSub";
            this.txtRegExSub.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRegExSub.Size = new System.Drawing.Size(652, 285);
            this.txtRegExSub.TabIndex = 0;
            this.txtRegExSub.WordWrap = false;
            this.txtRegExSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegExSub_KeyDown);
            // 
            // GridRowEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "GridRowEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operation Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtRegEx;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtRegExSub;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRegEx;
        private System.Windows.Forms.Label lblCondition;
    }
}