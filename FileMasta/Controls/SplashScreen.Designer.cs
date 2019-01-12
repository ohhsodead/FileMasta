namespace FileMasta.Controls
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
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.imageLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelLoading.Location = new System.Drawing.Point(4, 336);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(810, 29);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Initializing FileMasta, Please Wait...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRestart
            // 
            this.labelRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRestart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRestart.Location = new System.Drawing.Point(4, 441);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(810, 25);
            this.labelRestart.TabIndex = 2;
            this.labelRestart.Text = "Loading stuck? Click here!";
            this.labelRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRestart.Visible = false;
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            // 
            // timerCount
            // 
            this.timerCount.Enabled = true;
            this.timerCount.Interval = 60000;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // imageLogo
            // 
            this.imageLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageLogo.Image = global::FileMasta.Properties.Resources.filemasta_logo_v4;
            this.imageLogo.Location = new System.Drawing.Point(314, 135);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(190, 190);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLogo.TabIndex = 3;
            this.imageLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.imageLogo);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelLoading);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SplashScreen";
            this.Size = new System.Drawing.Size(818, 500);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelLoading;
        public System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.PictureBox imageLogo;
    }
}
