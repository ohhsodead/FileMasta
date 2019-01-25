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
            this.LabelLoading = new System.Windows.Forms.Label();
            this.ImageLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLoading
            // 
            this.LabelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoading.Font = new System.Drawing.Font("Verdana", 10F);
            this.LabelLoading.Location = new System.Drawing.Point(4, 341);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.Size = new System.Drawing.Size(810, 29);
            this.LabelLoading.TabIndex = 0;
            this.LabelLoading.Text = "Initializing FileMasta, Please Wait...";
            this.LabelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageLogo
            // 
            this.ImageLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageLogo.Image = global::FileMasta.Properties.Resources.app_logo;
            this.ImageLogo.Location = new System.Drawing.Point(314, 130);
            this.ImageLogo.Name = "ImageLogo";
            this.ImageLogo.Size = new System.Drawing.Size(190, 190);
            this.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageLogo.TabIndex = 3;
            this.ImageLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ImageLogo);
            this.Controls.Add(this.LabelLoading);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SplashScreen";
            this.Size = new System.Drawing.Size(818, 500);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LabelLoading;
        private System.Windows.Forms.PictureBox ImageLogo;
    }
}
