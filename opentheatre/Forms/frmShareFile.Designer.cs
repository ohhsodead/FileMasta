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
            this.titleShareFile.BackColor = System.Drawing.Color.Transparent;
            this.titleShareFile.Name = "titleShareFile";
            // 
            // imgClose
            // 
            resources.ApplyResources(this.imgClose, "imgClose");
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Image = global::OpenTheatre.Properties.Resources.close_small;
            this.imgClose.Name = "imgClose";
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // imgGooglePlus
            // 
            resources.ApplyResources(this.imgGooglePlus, "imgGooglePlus");
            this.imgGooglePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGooglePlus.Image = global::OpenTheatre.Properties.Resources.google_plus;
            this.imgGooglePlus.Name = "imgGooglePlus";
            this.imgGooglePlus.TabStop = false;
            this.imgGooglePlus.Click += new System.EventHandler(this.imgGooglePlus_Click);
            // 
            // imgEmail
            // 
            resources.ApplyResources(this.imgEmail, "imgEmail");
            this.imgEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEmail.Image = global::OpenTheatre.Properties.Resources.email;
            this.imgEmail.Name = "imgEmail";
            this.imgEmail.TabStop = false;
            this.imgEmail.Click += new System.EventHandler(this.imgEmail_Click);
            // 
            // imgReddit
            // 
            resources.ApplyResources(this.imgReddit, "imgReddit");
            this.imgReddit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReddit.Image = global::OpenTheatre.Properties.Resources.reddit;
            this.imgReddit.Name = "imgReddit";
            this.imgReddit.TabStop = false;
            this.imgReddit.Click += new System.EventHandler(this.imgReddit_Click);
            // 
            // imgTwitter
            // 
            resources.ApplyResources(this.imgTwitter, "imgTwitter");
            this.imgTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTwitter.Image = global::OpenTheatre.Properties.Resources.twitter;
            this.imgTwitter.Name = "imgTwitter";
            this.imgTwitter.TabStop = false;
            this.imgTwitter.Click += new System.EventHandler(this.imgTwitter_Click);
            // 
            // imgFacebook
            // 
            resources.ApplyResources(this.imgFacebook, "imgFacebook");
            this.imgFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFacebook.Image = global::OpenTheatre.Properties.Resources.facebook;
            this.imgFacebook.Name = "imgFacebook";
            this.imgFacebook.TabStop = false;
            this.imgFacebook.Click += new System.EventHandler(this.imgFacebook_Click);
            // 
            // frmShareFile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShareFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmShareFile_Load);
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