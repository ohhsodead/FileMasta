namespace OpenTheatre
{
    partial class ctrlStreamInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlStreamInfo));
            this.infoFileHost = new System.Windows.Forms.Label();
            this.infoFileName = new System.Windows.Forms.Label();
            this.contextFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgShare = new System.Windows.Forms.PictureBox();
            this.imgCopyURL = new System.Windows.Forms.PictureBox();
            this.imgReportBroken = new System.Windows.Forms.PictureBox();
            this.imgWatch = new System.Windows.Forms.PictureBox();
            this.imgDownload = new System.Windows.Forms.PictureBox();
            this.imgAddToBookmarks = new System.Windows.Forms.PictureBox();
            this.infoFileSize = new System.Windows.Forms.Label();
            this.infoFileAge = new System.Windows.Forms.Label();
            this.timerUpdateInfo = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.VLC2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopyURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReportBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoFileHost
            // 
            this.infoFileHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.infoFileHost.AutoEllipsis = true;
            this.infoFileHost.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoFileHost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileHost.Location = new System.Drawing.Point(27, 3);
            this.infoFileHost.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.infoFileHost.Name = "infoFileHost";
            this.infoFileHost.Size = new System.Drawing.Size(130, 17);
            this.infoFileHost.TabIndex = 0;
            this.infoFileHost.Text = "Host Name";
            // 
            // infoFileName
            // 
            this.infoFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.infoFileName.AutoEllipsis = true;
            this.infoFileName.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileName.Location = new System.Drawing.Point(160, 3);
            this.infoFileName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.infoFileName.Name = "infoFileName";
            this.infoFileName.Size = new System.Drawing.Size(189, 17);
            this.infoFileName.TabIndex = 1;
            this.infoFileName.Text = "File Name";
            // 
            // contextFileName
            // 
            this.contextFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VLC2ToolStripMenuItem,
            this.WMPToolStripMenuItem,
            this.VLCToolStripMenuItem,
            this.MPCToolStripMenuItem});
            this.contextFileName.Name = "contextMenuStrip1";
            this.contextFileName.ShowItemToolTips = false;
            this.contextFileName.Size = new System.Drawing.Size(146, 92);
            // 
            // imgShare
            // 
            this.imgShare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgShare.BackColor = System.Drawing.Color.Transparent;
            this.imgShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgShare.Image = global::OpenTheatre.Properties.Resources.share_variant;
            this.imgShare.Location = new System.Drawing.Point(116, 0);
            this.imgShare.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.imgShare.Name = "imgShare";
            this.imgShare.Size = new System.Drawing.Size(23, 23);
            this.imgShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShare.TabIndex = 19;
            this.imgShare.TabStop = false;
            this.toolTip1.SetToolTip(this.imgShare, "Share File");
            this.imgShare.Click += new System.EventHandler(this.imgShare_Click);
            // 
            // imgCopyURL
            // 
            this.imgCopyURL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgCopyURL.BackColor = System.Drawing.Color.Transparent;
            this.imgCopyURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCopyURL.Image = global::OpenTheatre.Properties.Resources.clipboard_arrow_left;
            this.imgCopyURL.Location = new System.Drawing.Point(90, 0);
            this.imgCopyURL.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.imgCopyURL.Name = "imgCopyURL";
            this.imgCopyURL.Size = new System.Drawing.Size(23, 23);
            this.imgCopyURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCopyURL.TabIndex = 18;
            this.imgCopyURL.TabStop = false;
            this.toolTip1.SetToolTip(this.imgCopyURL, "Copy URL");
            this.imgCopyURL.Click += new System.EventHandler(this.imgCopyURL_Click);
            // 
            // imgReportBroken
            // 
            this.imgReportBroken.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgReportBroken.BackColor = System.Drawing.Color.Transparent;
            this.imgReportBroken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReportBroken.Image = global::OpenTheatre.Properties.Resources.report;
            this.imgReportBroken.Location = new System.Drawing.Point(61, 0);
            this.imgReportBroken.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.imgReportBroken.Name = "imgReportBroken";
            this.imgReportBroken.Size = new System.Drawing.Size(23, 23);
            this.imgReportBroken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReportBroken.TabIndex = 17;
            this.imgReportBroken.TabStop = false;
            this.toolTip1.SetToolTip(this.imgReportBroken, "Report Broken");
            this.imgReportBroken.Click += new System.EventHandler(this.imgReportBroken_Click);
            // 
            // imgWatch
            // 
            this.imgWatch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgWatch.BackColor = System.Drawing.Color.Transparent;
            this.imgWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgWatch.Image = global::OpenTheatre.Properties.Resources.play_circle;
            this.imgWatch.Location = new System.Drawing.Point(32, 0);
            this.imgWatch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.imgWatch.Name = "imgWatch";
            this.imgWatch.Size = new System.Drawing.Size(23, 23);
            this.imgWatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgWatch.TabIndex = 16;
            this.imgWatch.TabStop = false;
            this.toolTip1.SetToolTip(this.imgWatch, "Watch Now");
            this.imgWatch.Click += new System.EventHandler(this.imgWatch_Click);
            // 
            // imgDownload
            // 
            this.imgDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgDownload.BackColor = System.Drawing.Color.Transparent;
            this.imgDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDownload.Image = global::OpenTheatre.Properties.Resources.cloud_download;
            this.imgDownload.Location = new System.Drawing.Point(3, 0);
            this.imgDownload.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.imgDownload.Name = "imgDownload";
            this.imgDownload.Size = new System.Drawing.Size(23, 23);
            this.imgDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDownload.TabIndex = 15;
            this.imgDownload.TabStop = false;
            this.toolTip1.SetToolTip(this.imgDownload, "Download Now");
            this.imgDownload.Click += new System.EventHandler(this.imgDownload_Click);
            // 
            // imgAddToBookmarks
            // 
            this.imgAddToBookmarks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgAddToBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.imgAddToBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAddToBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("imgAddToBookmarks.Image")));
            this.imgAddToBookmarks.Location = new System.Drawing.Point(1, 1);
            this.imgAddToBookmarks.Name = "imgAddToBookmarks";
            this.imgAddToBookmarks.Size = new System.Drawing.Size(23, 23);
            this.imgAddToBookmarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddToBookmarks.TabIndex = 14;
            this.imgAddToBookmarks.TabStop = false;
            this.toolTip1.SetToolTip(this.imgAddToBookmarks, "Add to Bookmarks");
            this.imgAddToBookmarks.Click += new System.EventHandler(this.imgAddToBookmarks_Click);
            // 
            // infoFileSize
            // 
            this.infoFileSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.infoFileSize.AutoEllipsis = true;
            this.infoFileSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoFileSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileSize.Location = new System.Drawing.Point(352, 3);
            this.infoFileSize.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.infoFileSize.Name = "infoFileSize";
            this.infoFileSize.Size = new System.Drawing.Size(70, 17);
            this.infoFileSize.TabIndex = 2;
            this.infoFileSize.Text = "Size";
            // 
            // infoFileAge
            // 
            this.infoFileAge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.infoFileAge.AutoEllipsis = true;
            this.infoFileAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoFileAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileAge.Location = new System.Drawing.Point(422, 3);
            this.infoFileAge.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.infoFileAge.Name = "infoFileAge";
            this.infoFileAge.Size = new System.Drawing.Size(86, 17);
            this.infoFileAge.TabIndex = 3;
            this.infoFileAge.Text = "Age";
            // 
            // timerUpdateInfo
            // 
            this.timerUpdateInfo.Enabled = true;
            this.timerUpdateInfo.Interval = 10000;
            this.timerUpdateInfo.Tick += new System.EventHandler(this.timerUpdateInfo_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.imgShare);
            this.flowLayoutPanel1.Controls.Add(this.imgCopyURL);
            this.flowLayoutPanel1.Controls.Add(this.imgReportBroken);
            this.flowLayoutPanel1.Controls.Add(this.imgWatch);
            this.flowLayoutPanel1.Controls.Add(this.imgDownload);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(511, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(142, 23);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // VLC2ToolStripMenuItem
            // 
            this.VLC2ToolStripMenuItem.Image = global::OpenTheatre.Properties.Resources.vlc;
            this.VLC2ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.VLC2ToolStripMenuItem.Name = "VLC2ToolStripMenuItem";
            this.VLC2ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.VLC2ToolStripMenuItem.Text = "VLC (Built-in)";
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Image = global::OpenTheatre.Properties.Resources.windows;
            this.WMPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.WMPToolStripMenuItem.Text = "WMP";
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Image = global::OpenTheatre.Properties.Resources.vlc;
            this.VLCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.VLCToolStripMenuItem.Text = "VLC";
            // 
            // MPCToolStripMenuItem
            // 
            this.MPCToolStripMenuItem.Image = global::OpenTheatre.Properties.Resources.dots_horizontal;
            this.MPCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MPCToolStripMenuItem.Name = "MPCToolStripMenuItem";
            this.MPCToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.MPCToolStripMenuItem.Text = "MPC";
            // 
            // ctrlStreamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.infoFileName);
            this.Controls.Add(this.infoFileHost);
            this.Controls.Add(this.infoFileAge);
            this.Controls.Add(this.infoFileSize);
            this.Controls.Add(this.imgAddToBookmarks);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStreamInfo";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(653, 25);
            this.Load += new System.EventHandler(this.ctrlStreamInfo_Load);
            this.contextFileName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopyURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReportBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label infoFileHost;
        public System.Windows.Forms.Label infoFileName;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
        private System.Windows.Forms.PictureBox imgAddToBookmarks;
        private System.Windows.Forms.PictureBox imgDownload;
        private System.Windows.Forms.PictureBox imgWatch;
        private System.Windows.Forms.PictureBox imgReportBroken;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label infoFileSize;
        public System.Windows.Forms.Label infoFileAge;
        private System.Windows.Forms.PictureBox imgCopyURL;
        private System.Windows.Forms.Timer timerUpdateInfo;
        private System.Windows.Forms.PictureBox imgShare;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem VLC2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPCToolStripMenuItem;
    }
}
