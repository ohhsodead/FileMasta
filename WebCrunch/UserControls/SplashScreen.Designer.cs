namespace UserControls
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
            resources.ApplyResources(this.lblLoadingText, "lblLoadingText");
            this.lblLoadingText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingText.Name = "lblLoadingText";
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::WebCrunch.Properties.Resources.new_logo;
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // lblLoadingStuckRestart
            // 
            resources.ApplyResources(this.lblLoadingStuckRestart, "lblLoadingStuckRestart");
            this.lblLoadingStuckRestart.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingStuckRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoadingStuckRestart.Name = "lblLoadingStuckRestart";
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblLoadingStuckRestart);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblLoadingText);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SplashScreen";
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
