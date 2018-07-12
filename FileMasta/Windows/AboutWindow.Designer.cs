namespace FileMasta.Windows
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LinkProjectURL = new System.Windows.Forms.LinkLabel();
            this.LabelCopyrightCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDescription
            // 
            this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.BackColor = System.Drawing.Color.Transparent;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(12, 13);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(368, 96);
            this.LabelDescription.TabIndex = 1;
            this.LabelDescription.Text = resources.GetString("LabelDescription.Text");
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(12, 120);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(81, 15);
            this.LabelVersion.TabIndex = 17;
            this.LabelVersion.Text = "Version 0.0.0.0";
            // 
            // LinkProjectURL
            // 
            this.LinkProjectURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LinkProjectURL.AutoSize = true;
            this.LinkProjectURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkProjectURL.Location = new System.Drawing.Point(12, 174);
            this.LinkProjectURL.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.LinkProjectURL.Name = "LinkProjectURL";
            this.LinkProjectURL.Size = new System.Drawing.Size(206, 15);
            this.LinkProjectURL.TabIndex = 19;
            this.LinkProjectURL.TabStop = true;
            this.LinkProjectURL.Text = "https://github.com/herbl27/filemasta";
            this.LinkProjectURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkProjectURL_LinkClicked);
            // 
            // LabelCopyrightCredit
            // 
            this.LabelCopyrightCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelCopyrightCredit.AutoSize = true;
            this.LabelCopyrightCredit.BackColor = System.Drawing.Color.Transparent;
            this.LabelCopyrightCredit.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelCopyrightCredit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCopyrightCredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCopyrightCredit.Location = new System.Drawing.Point(12, 147);
            this.LabelCopyrightCredit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.LabelCopyrightCredit.Name = "LabelCopyrightCredit";
            this.LabelCopyrightCredit.Size = new System.Drawing.Size(219, 15);
            this.LabelCopyrightCredit.TabIndex = 21;
            this.LabelCopyrightCredit.Text = "Copyright © 2018 Ashley Davies (HerbL)";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.LabelCopyrightCredit);
            this.Controls.Add(this.LinkProjectURL);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelDescription);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.LinkLabel LinkProjectURL;
        private System.Windows.Forms.Label LabelCopyrightCredit;
    }
}