namespace OpenTheatre
{
    partial class frmShareFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShareFile));
            this.titleShareFile = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.imgGooglePlus = new System.Windows.Forms.PictureBox();
            this.imgEmail = new System.Windows.Forms.PictureBox();
            this.imgReddit = new System.Windows.Forms.PictureBox();
            this.imgTwitter = new System.Windows.Forms.PictureBox();
            this.imgFacebook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGooglePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReddit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // titleShareFile
            // 
            resources.ApplyResources(this.titleShareFile, "titleShareFile");
            this.titleShareFile.AutoSize = true;
            this.titleShareFile.BackColor = System.Drawing.Color.Transparent;
            this.titleShareFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.titleShareFile.Location = new System.Drawing.Point(4, 8);
            this.titleShareFile.Name = "titleShareFile";
            this.titleShareFile.Size = new System.Drawing.Size(70, 19);
            this.titleShareFile.TabIndex = 0;
            // 
            // imgClose
            // 
            this.imgClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Image = global::OpenTheatre.Properties.Resources.close_small;
            this.imgClose.Location = new System.Drawing.Point(160, 9);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(20, 20);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 7;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // imgGooglePlus
            // 
            this.imgGooglePlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgGooglePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGooglePlus.Image = global::OpenTheatre.Properties.Resources.google_plus;
            this.imgGooglePlus.Location = new System.Drawing.Point(80, 36);
            this.imgGooglePlus.Name = "imgGooglePlus";
            this.imgGooglePlus.Size = new System.Drawing.Size(30, 30);
            this.imgGooglePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGooglePlus.TabIndex = 6;
            this.imgGooglePlus.TabStop = false;
            this.imgGooglePlus.Click += new System.EventHandler(this.imgGooglePlus_Click);
            // 
            // imgEmail
            // 
            this.imgEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEmail.Image = global::OpenTheatre.Properties.Resources.email;
            this.imgEmail.Location = new System.Drawing.Point(152, 37);
            this.imgEmail.Name = "imgEmail";
            this.imgEmail.Size = new System.Drawing.Size(28, 28);
            this.imgEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEmail.TabIndex = 5;
            this.imgEmail.TabStop = false;
            this.imgEmail.Click += new System.EventHandler(this.imgEmail_Click);
            // 
            // imgReddit
            // 
            this.imgReddit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgReddit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReddit.Image = global::OpenTheatre.Properties.Resources.reddit;
            this.imgReddit.Location = new System.Drawing.Point(116, 36);
            this.imgReddit.Name = "imgReddit";
            this.imgReddit.Size = new System.Drawing.Size(30, 30);
            this.imgReddit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReddit.TabIndex = 4;
            this.imgReddit.TabStop = false;
            this.imgReddit.Click += new System.EventHandler(this.imgReddit_Click);
            // 
            // imgTwitter
            // 
            this.imgTwitter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTwitter.Image = global::OpenTheatre.Properties.Resources.twitter;
            this.imgTwitter.Location = new System.Drawing.Point(44, 36);
            this.imgTwitter.Name = "imgTwitter";
            this.imgTwitter.Size = new System.Drawing.Size(30, 30);
            this.imgTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTwitter.TabIndex = 2;
            this.imgTwitter.TabStop = false;
            this.imgTwitter.Click += new System.EventHandler(this.imgTwitter_Click);
            // 
            // imgFacebook
            // 
            this.imgFacebook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFacebook.Image = global::OpenTheatre.Properties.Resources.facebook;
            this.imgFacebook.Location = new System.Drawing.Point(8, 36);
            this.imgFacebook.Name = "imgFacebook";
            this.imgFacebook.Size = new System.Drawing.Size(30, 30);
            this.imgFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFacebook.TabIndex = 1;
            this.imgFacebook.TabStop = false;
            this.imgFacebook.Click += new System.EventHandler(this.imgFacebook_Click);
            // 
            // frmShareFile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(190, 74);
            this.ControlBox = false;
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.titleShareFile);
            this.Controls.Add(this.imgGooglePlus);
            this.Controls.Add(this.imgEmail);
            this.Controls.Add(this.imgReddit);
            this.Controls.Add(this.imgTwitter);
            this.Controls.Add(this.imgFacebook);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShareFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGooglePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReddit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFacebook;
        private System.Windows.Forms.PictureBox imgTwitter;
        private System.Windows.Forms.PictureBox imgReddit;
        private System.Windows.Forms.PictureBox imgEmail;
        private System.Windows.Forms.PictureBox imgGooglePlus;
        private System.Windows.Forms.Label titleShareFile;
        private System.Windows.Forms.PictureBox imgClose;
    }
}