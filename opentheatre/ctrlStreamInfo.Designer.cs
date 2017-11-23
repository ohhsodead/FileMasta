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
            this.OpenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgReportBroken = new System.Windows.Forms.PictureBox();
            this.imgWatch = new System.Windows.Forms.PictureBox();
            this.imgDownload = new System.Windows.Forms.PictureBox();
            this.imgAddToBookmarks = new System.Windows.Forms.PictureBox();
            this.infoFileSize = new System.Windows.Forms.Label();
            this.infoFileDateAdded = new System.Windows.Forms.Label();
            this.VLC2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgReportBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).BeginInit();
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
            this.infoFileName.Size = new System.Drawing.Size(237, 17);
            this.infoFileName.TabIndex = 1;
            this.infoFileName.Text = "File Name";
            // 
            // contextFileName
            // 
            this.contextFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWithToolStripMenuItem});
            this.contextFileName.Name = "contextMenuStrip1";
            this.contextFileName.ShowImageMargin = false;
            this.contextFileName.ShowItemToolTips = false;
            this.contextFileName.Size = new System.Drawing.Size(114, 26);
            // 
            // OpenWithToolStripMenuItem
            // 
            this.OpenWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VLC2ToolStripMenuItem,
            this.WMPToolStripMenuItem,
            this.VLCToolStripMenuItem,
            this.MPCToolStripMenuItem});
            this.OpenWithToolStripMenuItem.Name = "OpenWithToolStripMenuItem";
            this.OpenWithToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.OpenWithToolStripMenuItem.Text = "Open with...";
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.WMPToolStripMenuItem.Text = "WMP";
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.WMPToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.VLCToolStripMenuItem.Text = "VLC";
            this.VLCToolStripMenuItem.Click += new System.EventHandler(this.VLCToolStripMenuItem_Click);
            // 
            // MPCToolStripMenuItem
            // 
            this.MPCToolStripMenuItem.Name = "MPCToolStripMenuItem";
            this.MPCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MPCToolStripMenuItem.Text = "MPC";
            // 
            // imgReportBroken
            // 
            this.imgReportBroken.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgReportBroken.BackColor = System.Drawing.Color.Transparent;
            this.imgReportBroken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReportBroken.Image = global::OpenTheatre.Properties.Resources.alert_octagon;
            this.imgReportBroken.Location = new System.Drawing.Point(629, 1);
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
            this.imgWatch.Location = new System.Drawing.Point(600, 1);
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
            this.imgDownload.Location = new System.Drawing.Point(569, 1);
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
            this.infoFileSize.Location = new System.Drawing.Point(400, 3);
            this.infoFileSize.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.infoFileSize.Name = "infoFileSize";
            this.infoFileSize.Size = new System.Drawing.Size(70, 17);
            this.infoFileSize.TabIndex = 2;
            this.infoFileSize.Text = "Size";
            // 
            // infoFileDateAdded
            // 
            this.infoFileDateAdded.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.infoFileDateAdded.AutoEllipsis = true;
            this.infoFileDateAdded.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoFileDateAdded.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileDateAdded.Location = new System.Drawing.Point(470, 3);
            this.infoFileDateAdded.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.infoFileDateAdded.Name = "infoFileDateAdded";
            this.infoFileDateAdded.Size = new System.Drawing.Size(86, 17);
            this.infoFileDateAdded.TabIndex = 3;
            this.infoFileDateAdded.Text = "Time ago";
            // 
            // VLC2ToolStripMenuItem
            // 
            this.VLC2ToolStripMenuItem.Name = "VLC2ToolStripMenuItem";
            this.VLC2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.VLC2ToolStripMenuItem.Text = "VLC (Built-in)";
            this.VLC2ToolStripMenuItem.Click += new System.EventHandler(this.VLC2ToolStripMenuItem_Click);
            // 
            // ctrlStreamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.infoFileName);
            this.Controls.Add(this.infoFileHost);
            this.Controls.Add(this.imgReportBroken);
            this.Controls.Add(this.infoFileDateAdded);
            this.Controls.Add(this.infoFileSize);
            this.Controls.Add(this.imgWatch);
            this.Controls.Add(this.imgDownload);
            this.Controls.Add(this.imgAddToBookmarks);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStreamInfo";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(653, 25);
            this.Load += new System.EventHandler(this.ctrlStreamInfo_Load);
            this.contextFileName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgReportBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label infoFileHost;
        public System.Windows.Forms.Label infoFileName;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
        private System.Windows.Forms.ToolStripMenuItem OpenWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPCToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgAddToBookmarks;
        private System.Windows.Forms.PictureBox imgDownload;
        private System.Windows.Forms.PictureBox imgWatch;
        private System.Windows.Forms.PictureBox imgReportBroken;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label infoFileSize;
        public System.Windows.Forms.Label infoFileDateAdded;
        private System.Windows.Forms.ToolStripMenuItem VLC2ToolStripMenuItem;
    }
}
