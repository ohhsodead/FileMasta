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
            this.infoFileName = new System.Windows.Forms.Label();
            this.infoStatus = new System.Windows.Forms.Label();
            this.splitter = new CButtonLib.CButton();
            this.infoSpeed = new System.Windows.Forms.Label();
            this.infoDownloadedOutOfSize = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.imgStatus = new System.Windows.Forms.PictureBox();
            this.splitter0 = new System.Windows.Forms.Label();
            this.infoPercentage = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Label();
            this.infoEstimatedTime = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Label();
            this.timerEstimatedTimer = new System.Windows.Forms.Timer(this.components);
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new ProgressBarEx.ProgressBarEx();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // infoFileName
            // 
            this.infoFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoFileName.AutoEllipsis = true;
            this.infoFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.infoFileName.ForeColor = System.Drawing.Color.White;
            this.infoFileName.Location = new System.Drawing.Point(13, 13);
            this.infoFileName.Name = "infoFileName";
            this.infoFileName.Size = new System.Drawing.Size(396, 22);
            this.infoFileName.TabIndex = 0;
            this.infoFileName.Text = "File Name";
            this.infoFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // infoStatus
            // 
            this.infoStatus.AutoEllipsis = true;
            this.infoStatus.AutoSize = true;
            this.infoStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.infoStatus.Location = new System.Drawing.Point(20, 0);
            this.infoStatus.Margin = new System.Windows.Forms.Padding(0);
            this.infoStatus.Name = "infoStatus";
            this.infoStatus.Size = new System.Drawing.Size(77, 17);
            this.infoStatus.TabIndex = 2;
            this.infoStatus.Text = "Connecting";
            this.infoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.splitter.Location = new System.Drawing.Point(0, 105);
            this.splitter.Name = "splitter";
            this.splitter.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitter.Size = new System.Drawing.Size(450, 1);
            this.splitter.TabIndex = 4;
            this.splitter.Text = "cButton1";
            // 
            // infoSpeed
            // 
            this.infoSpeed.AutoSize = true;
            this.infoSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.infoSpeed.Location = new System.Drawing.Point(45, 24);
            this.infoSpeed.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.infoSpeed.Name = "infoSpeed";
            this.infoSpeed.Size = new System.Drawing.Size(28, 17);
            this.infoSpeed.TabIndex = 8;
            this.infoSpeed.Text = "n/a";
            this.infoSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoDownloadedOutOfSize
            // 
            this.infoDownloadedOutOfSize.AutoSize = true;
            this.infoDownloadedOutOfSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.infoDownloadedOutOfSize.Location = new System.Drawing.Point(0, 24);
            this.infoDownloadedOutOfSize.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.infoDownloadedOutOfSize.Name = "infoDownloadedOutOfSize";
            this.infoDownloadedOutOfSize.Size = new System.Drawing.Size(28, 17);
            this.infoDownloadedOutOfSize.TabIndex = 9;
            this.infoDownloadedOutOfSize.Text = "n/a";
            this.infoDownloadedOutOfSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelDetails
            // 
            this.panelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetails.Controls.Add(this.imgStatus);
            this.panelDetails.Controls.Add(this.infoStatus);
            this.panelDetails.Controls.Add(this.splitter0);
            this.panelDetails.Controls.Add(this.infoPercentage);
            this.panelDetails.Controls.Add(this.splitter1);
            this.panelDetails.Controls.Add(this.infoEstimatedTime);
            this.panelDetails.Controls.Add(this.infoDownloadedOutOfSize);
            this.panelDetails.Controls.Add(this.splitter3);
            this.panelDetails.Controls.Add(this.infoSpeed);
            this.panelDetails.Location = new System.Drawing.Point(13, 52);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(424, 44);
            this.panelDetails.TabIndex = 16;
            // 
            // imgStatus
            // 
            this.imgStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStatus.Image = global::OpenTheatre.Properties.Resources.check;
            this.imgStatus.Location = new System.Drawing.Point(0, 0);
            this.imgStatus.Margin = new System.Windows.Forms.Padding(0);
            this.imgStatus.Name = "imgStatus";
            this.imgStatus.Size = new System.Drawing.Size(20, 20);
            this.imgStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStatus.TabIndex = 22;
            this.imgStatus.TabStop = false;
            this.imgStatus.Visible = false;
            this.imgStatus.Click += new System.EventHandler(this.imgStatus_Click);
            // 
            // splitter0
            // 
            this.splitter0.AutoSize = true;
            this.splitter0.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.splitter0.Location = new System.Drawing.Point(100, 2);
            this.splitter0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.splitter0.Name = "splitter0";
            this.splitter0.Size = new System.Drawing.Size(11, 13);
            this.splitter0.TabIndex = 18;
            this.splitter0.Text = "•";
            this.splitter0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoPercentage
            // 
            this.infoPercentage.AutoEllipsis = true;
            this.infoPercentage.AutoSize = true;
            this.infoPercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.infoPercentage.Location = new System.Drawing.Point(114, 0);
            this.infoPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.infoPercentage.Name = "infoPercentage";
            this.infoPercentage.Size = new System.Drawing.Size(26, 17);
            this.infoPercentage.TabIndex = 17;
            this.infoPercentage.Text = "0%";
            this.infoPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.AutoSize = true;
            this.splitter1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.splitter1.Location = new System.Drawing.Point(143, 2);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(11, 13);
            this.splitter1.TabIndex = 19;
            this.splitter1.Text = "•";
            this.splitter1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoEstimatedTime
            // 
            this.infoEstimatedTime.AutoEllipsis = true;
            this.infoEstimatedTime.AutoSize = true;
            this.panelDetails.SetFlowBreak(this.infoEstimatedTime, true);
            this.infoEstimatedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.infoEstimatedTime.Location = new System.Drawing.Point(157, 0);
            this.infoEstimatedTime.Margin = new System.Windows.Forms.Padding(0);
            this.infoEstimatedTime.Name = "infoEstimatedTime";
            this.infoEstimatedTime.Size = new System.Drawing.Size(68, 17);
            this.infoEstimatedTime.TabIndex = 17;
            this.infoEstimatedTime.Text = "0 minutes";
            this.infoEstimatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter3
            // 
            this.splitter3.AutoSize = true;
            this.splitter3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.splitter3.Location = new System.Drawing.Point(31, 26);
            this.splitter3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(11, 13);
            this.splitter3.TabIndex = 21;
            this.splitter3.Text = "•";
            this.splitter3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Image = global::OpenTheatre.Properties.Resources.close_small;
            this.imgClose.Location = new System.Drawing.Point(415, 14);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(20, 20);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 15;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BackgroundColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(135)))), ((int)(((byte)(189)))));
            this.progressBar1.GradiantColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(135)))), ((int)(((byte)(189)))));
            this.progressBar1.GradiantPosition = ProgressBarEx.ProgressBarEx.GradiantArea.None;
            this.progressBar1.Image = null;
            this.progressBar1.Location = new System.Drawing.Point(16, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(135)))), ((int)(((byte)(189)))));
            this.progressBar1.RoundedCorners = false;
            this.progressBar1.Size = new System.Drawing.Size(419, 9);
            // 
            // ctrlDownloadItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.infoFileName);
            this.Controls.Add(this.panelDetails);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlDownloadItem";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(450, 106);
            this.Load += new System.EventHandler(this.ctrlDownloadItem_Load);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoFileName;
        public System.Windows.Forms.Label infoStatus;
        private CButtonLib.CButton splitter;
        private System.Windows.Forms.Label infoSpeed;
        private System.Windows.Forms.Label infoDownloadedOutOfSize;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.FlowLayoutPanel panelDetails;
        private System.Windows.Forms.Label splitter1;
        private System.Windows.Forms.Label infoPercentage;
        private System.Windows.Forms.Label splitter0;
        private System.Windows.Forms.Timer timerEstimatedTimer;
        private System.Windows.Forms.Label infoEstimatedTime;
        private System.Windows.Forms.Label splitter3;
        public ProgressBarEx.ProgressBarEx progressBar1;
        private System.Windows.Forms.PictureBox imgStatus;
    }
}
