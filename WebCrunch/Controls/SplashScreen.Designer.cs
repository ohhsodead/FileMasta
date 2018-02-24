namespace WebCrunch.Controls
{
    partial class SplashScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLoadingStuckRestart = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadingText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingText.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.lblLoadingText.Location = new System.Drawing.Point(3, 362);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(694, 34);
            this.lblLoadingText.TabIndex = 0;
            this.lblLoadingText.Text = "Initializing WebCrunch, Please Wait...";
            this.lblLoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(238, 105);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(225, 225);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // lblLoadingStuckRestart
            // 
            this.lblLoadingStuckRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadingStuckRestart.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingStuckRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoadingStuckRestart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Italic);
            this.lblLoadingStuckRestart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoadingStuckRestart.Location = new System.Drawing.Point(3, 441);
            this.lblLoadingStuckRestart.Name = "lblLoadingStuckRestart";
            this.lblLoadingStuckRestart.Size = new System.Drawing.Size(694, 25);
            this.lblLoadingStuckRestart.TabIndex = 2;
            this.lblLoadingStuckRestart.Text = "Loading stuck? Click here!";
            this.lblLoadingStuckRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoadingStuckRestart.Visible = false;
            this.lblLoadingStuckRestart.Click += new System.EventHandler(this.lblLoadingStuckRestart_Click);
            // 
            // timerCount
            // 
            this.timerCount.Enabled = true;
            this.timerCount.Interval = 30000;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblLoadingStuckRestart);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblLoadingText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SplashScreen";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.PictureBox imgLogo;
        public System.Windows.Forms.Label lblLoadingStuckRestart;
        private System.Windows.Forms.Timer timerCount;
    }
}
