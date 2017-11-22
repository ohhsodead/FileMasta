namespace OpenTheatre
{
    partial class ctrlDownloadItem
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.splitter = new CButtonLib.CButton();
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.progressBar1 = new ProgressBarEx.ProgressBarEx();
            this.imgDropDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(9, 6);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(408, 18);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage.AutoEllipsis = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Location = new System.Drawing.Point(54, 57);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(298, 17);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "Connecting...";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(356, 57);
            this.lblSize.Margin = new System.Windows.Forms.Padding(3);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(85, 17);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size: n/a";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splitter
            // 
            this.splitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitter.BorderColor = System.Drawing.Color.Silver;
            this.splitter.ColorFillSolid = System.Drawing.Color.Silver;
            this.splitter.DesignerSelected = false;
            this.splitter.DimFactorClick = 0;
            this.splitter.DimFactorHover = 0;
            this.splitter.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitter.ImageIndex = 0;
            this.splitter.Location = new System.Drawing.Point(0, 81);
            this.splitter.Name = "splitter";
            this.splitter.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitter.Size = new System.Drawing.Size(450, 1);
            this.splitter.TabIndex = 4;
            this.splitter.Text = "cButton1";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoEllipsis = true;
            this.lblCancel.AutoSize = true;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCancel.Location = new System.Drawing.Point(9, 57);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(43, 15);
            this.lblCancel.TabIndex = 5;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(9, 40);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(3);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(432, 17);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed: n/a";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSpeed.Visible = false;
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownloaded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloaded.ForeColor = System.Drawing.Color.White;
            this.lblDownloaded.Location = new System.Drawing.Point(9, 59);
            this.lblDownloaded.Margin = new System.Windows.Forms.Padding(3);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(432, 17);
            this.lblDownloaded.TabIndex = 9;
            this.lblDownloaded.Text = "Downloaded: n/a";
            this.lblDownloaded.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDownloaded.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderColor = System.Drawing.Color.Gray;
            this.progressBar1.GradiantPosition = ProgressBarEx.ProgressBarEx.GradiantArea.None;
            this.progressBar1.Image = null;
            this.progressBar1.Location = new System.Drawing.Point(9, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.SteelBlue;
            this.progressBar1.RoundedCorners = false;
            this.progressBar1.ShowText = true;
            this.progressBar1.Size = new System.Drawing.Size(432, 16);
            // 
            // imgDropDown
            // 
            this.imgDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDropDown.Image = global::OpenTheatre.Properties.Resources.chevron_down_white;
            this.imgDropDown.Location = new System.Drawing.Point(419, 4);
            this.imgDropDown.Name = "imgDropDown";
            this.imgDropDown.Size = new System.Drawing.Size(22, 22);
            this.imgDropDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDropDown.TabIndex = 7;
            this.imgDropDown.TabStop = false;
            this.imgDropDown.Click += new System.EventHandler(this.imgDropDown_Click);
            // 
            // ctrlDownloadItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblDownloaded);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.imgDropDown);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblFileName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlDownloadItem";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(450, 82);
            this.Load += new System.EventHandler(this.ctrlDownloadItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDropDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSize;
        public System.Windows.Forms.Label lblPercentage;
        private CButtonLib.CButton splitter;
        private ProgressBarEx.ProgressBarEx progressBar1;
        public System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox imgDropDown;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblDownloaded;
    }
}
