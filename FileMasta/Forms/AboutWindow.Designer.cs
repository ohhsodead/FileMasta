namespace FileMasta.Forms
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
            this.LabelCopyrightCredit = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.LinkProjectURL = new System.Windows.Forms.LinkLabel();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDescription
            // 
            this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.BackColor = System.Drawing.Color.Transparent;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(12, 12);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(375, 123);
            this.LabelDescription.TabIndex = 1;
            this.LabelDescription.Text = resources.GetString("LabelDescription.Text");
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(12, 144);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(93, 13);
            this.LabelVersion.TabIndex = 17;
            this.LabelVersion.Text = "Version 0.0.0.0";
            // 
            // LabelCopyrightCredit
            // 
            this.LabelCopyrightCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCopyrightCredit.AutoSize = true;
            this.LabelCopyrightCredit.BackColor = System.Drawing.Color.Transparent;
            this.LabelCopyrightCredit.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelCopyrightCredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCopyrightCredit.Location = new System.Drawing.Point(12, 167);
            this.LabelCopyrightCredit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LabelCopyrightCredit.Name = "LabelCopyrightCredit";
            this.LabelCopyrightCredit.Size = new System.Drawing.Size(242, 13);
            this.LabelCopyrightCredit.TabIndex = 21;
            this.LabelCopyrightCredit.Text = "Copyright © 2018 Ashley Davies (HerbL)";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(332, 9);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(56, 24);
            this.ButtonOk.TabIndex = 0;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelButtons.Controls.Add(this.ButtonOk);
            this.PanelButtons.Location = new System.Drawing.Point(0, 219);
            this.PanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(399, 42);
            this.PanelButtons.TabIndex = 26;
            // 
            // LinkProjectURL
            // 
            this.LinkProjectURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkProjectURL.AutoSize = true;
            this.LinkProjectURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkProjectURL.Location = new System.Drawing.Point(12, 190);
            this.LinkProjectURL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LinkProjectURL.Name = "LinkProjectURL";
            this.LinkProjectURL.Size = new System.Drawing.Size(218, 13);
            this.LinkProjectURL.TabIndex = 2;
            this.LinkProjectURL.TabStop = true;
            this.LinkProjectURL.Text = "https://github.com/mostlyash/filemasta";
            this.LinkProjectURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkProjectURL_LinkClicked);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.LabelCopyrightCredit);
            this.Controls.Add(this.LinkProjectURL);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelDescription);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelCopyrightCredit;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.LinkLabel LinkProjectURL;
    }
}