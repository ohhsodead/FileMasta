namespace UnhandledExceptions
{
    partial class ExceptionWindow
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
            this.BugTitleTxt = new System.Windows.Forms.Label();
            this.BugTitleBox = new System.Windows.Forms.TextBox();
            this.BugDetailTxt = new System.Windows.Forms.Label();
            this.BugDetailBox = new System.Windows.Forms.RichTextBox();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.GithubIssuesLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BugTitleTxt
            // 
            this.BugTitleTxt.AutoSize = true;
            this.BugTitleTxt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.BugTitleTxt.Location = new System.Drawing.Point(12, 19);
            this.BugTitleTxt.Name = "BugTitleTxt";
            this.BugTitleTxt.Size = new System.Drawing.Size(46, 23);
            this.BugTitleTxt.TabIndex = 0;
            this.BugTitleTxt.Text = "Title";
            // 
            // BugTitleBox
            // 
            this.BugTitleBox.BackColor = System.Drawing.Color.Gainsboro;
            this.BugTitleBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.BugTitleBox.Location = new System.Drawing.Point(16, 45);
            this.BugTitleBox.Name = "BugTitleBox";
            this.BugTitleBox.Size = new System.Drawing.Size(296, 24);
            this.BugTitleBox.TabIndex = 1;
            // 
            // BugDetailTxt
            // 
            this.BugDetailTxt.AutoSize = true;
            this.BugDetailTxt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.BugDetailTxt.Location = new System.Drawing.Point(12, 72);
            this.BugDetailTxt.Name = "BugDetailTxt";
            this.BugDetailTxt.Size = new System.Drawing.Size(66, 23);
            this.BugDetailTxt.TabIndex = 0;
            this.BugDetailTxt.Text = "Details";
            // 
            // BugDetailBox
            // 
            this.BugDetailBox.BackColor = System.Drawing.Color.Gainsboro;
            this.BugDetailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BugDetailBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.BugDetailBox.Location = new System.Drawing.Point(16, 98);
            this.BugDetailBox.Name = "BugDetailBox";
            this.BugDetailBox.Size = new System.Drawing.Size(296, 232);
            this.BugDetailBox.TabIndex = 2;
            this.BugDetailBox.Text = "";
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.ReportBtn.Location = new System.Drawing.Point(237, 336);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(75, 23);
            this.ReportBtn.TabIndex = 3;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.UseVisualStyleBackColor = false;
            // 
            // GithubIssuesLink
            // 
            this.GithubIssuesLink.AutoSize = true;
            this.GithubIssuesLink.Location = new System.Drawing.Point(13, 341);
            this.GithubIssuesLink.Name = "GithubIssuesLink";
            this.GithubIssuesLink.Size = new System.Drawing.Size(180, 13);
            this.GithubIssuesLink.TabIndex = 4;
            this.GithubIssuesLink.TabStop = true;
            this.GithubIssuesLink.Text = "All Bugs Reported are in Github Issues";
            // 
            // ExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 366);
            this.Controls.Add(this.GithubIssuesLink);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.BugDetailBox);
            this.Controls.Add(this.BugTitleBox);
            this.Controls.Add(this.BugDetailTxt);
            this.Controls.Add(this.BugTitleTxt);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExceptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Bugs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BugTitleTxt;
        private System.Windows.Forms.Label BugDetailTxt;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.LinkLabel GithubIssuesLink;
        public System.Windows.Forms.TextBox BugTitleBox;
        public System.Windows.Forms.RichTextBox BugDetailBox;
    }
}