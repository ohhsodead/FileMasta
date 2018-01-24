namespace WebPlex.CControls
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
            this.infoHost = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.contextFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VLC2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgCopyURL = new System.Windows.Forms.PictureBox();
            this.imgReportBroken = new System.Windows.Forms.PictureBox();
            this.imgWatch = new System.Windows.Forms.PictureBox();
            this.imgMagnet = new System.Windows.Forms.PictureBox();
            this.imgDownload = new System.Windows.Forms.PictureBox();
            this.imgAddToBookmarks = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.contextFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopyURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReportBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMagnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoHost
            // 
            resources.ApplyResources(this.infoHost, "infoHost");
            this.infoHost.AutoEllipsis = true;
            this.infoHost.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoHost.Name = "infoHost";
            // 
            // infoName
            // 
            resources.ApplyResources(this.infoName, "infoName");
            this.infoName.AutoEllipsis = true;
            this.infoName.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoName.Name = "infoName";
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
            resources.ApplyResources(this.contextFileName, "contextFileName");
            // 
            // VLC2ToolStripMenuItem
            // 
            this.VLC2ToolStripMenuItem.Image = global::WebPlex.Properties.Resources.vlc;
            resources.ApplyResources(this.VLC2ToolStripMenuItem, "VLC2ToolStripMenuItem");
            this.VLC2ToolStripMenuItem.Name = "VLC2ToolStripMenuItem";
            this.VLC2ToolStripMenuItem.Click += new System.EventHandler(this.VLC2ToolStripMenuItem_Click);
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Image = global::WebPlex.Properties.Resources.windows;
            resources.ApplyResources(this.WMPToolStripMenuItem, "WMPToolStripMenuItem");
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.WMPToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Image = global::WebPlex.Properties.Resources.vlc;
            resources.ApplyResources(this.VLCToolStripMenuItem, "VLCToolStripMenuItem");
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Click += new System.EventHandler(this.VLCToolStripMenuItem_Click);
            // 
            // MPCToolStripMenuItem
            // 
            this.MPCToolStripMenuItem.Image = global::WebPlex.Properties.Resources.dots_horizontal;
            resources.ApplyResources(this.MPCToolStripMenuItem, "MPCToolStripMenuItem");
            this.MPCToolStripMenuItem.Name = "MPCToolStripMenuItem";
            this.MPCToolStripMenuItem.Click += new System.EventHandler(this.MPCToolStripMenuItem_Click);
            // 
            // imgCopyURL
            // 
            resources.ApplyResources(this.imgCopyURL, "imgCopyURL");
            this.imgCopyURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCopyURL.Image = global::WebPlex.Properties.Resources.clipboard_arrow_left;
            this.imgCopyURL.Name = "imgCopyURL";
            this.imgCopyURL.TabStop = false;
            this.toolTip1.SetToolTip(this.imgCopyURL, resources.GetString("imgCopyURL.ToolTip"));
            this.imgCopyURL.Click += new System.EventHandler(this.imgCopyURL_Click);
            // 
            // imgReportBroken
            // 
            resources.ApplyResources(this.imgReportBroken, "imgReportBroken");
            this.imgReportBroken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReportBroken.Name = "imgReportBroken";
            this.imgReportBroken.TabStop = false;
            this.toolTip1.SetToolTip(this.imgReportBroken, resources.GetString("imgReportBroken.ToolTip"));
            this.imgReportBroken.Click += new System.EventHandler(this.imgReportBroken_Click);
            // 
            // imgWatch
            // 
            resources.ApplyResources(this.imgWatch, "imgWatch");
            this.imgWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgWatch.Image = global::WebPlex.Properties.Resources.play_circle;
            this.imgWatch.Name = "imgWatch";
            this.imgWatch.TabStop = false;
            this.toolTip1.SetToolTip(this.imgWatch, resources.GetString("imgWatch.ToolTip"));
            this.imgWatch.Click += new System.EventHandler(this.imgWatch_Click);
            // 
            // imgMagnet
            // 
            resources.ApplyResources(this.imgMagnet, "imgMagnet");
            this.imgMagnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMagnet.Image = global::WebPlex.Properties.Resources.magnet;
            this.imgMagnet.Name = "imgMagnet";
            this.imgMagnet.TabStop = false;
            this.toolTip1.SetToolTip(this.imgMagnet, resources.GetString("imgMagnet.ToolTip"));
            this.imgMagnet.Click += new System.EventHandler(this.imgMagnet_Click);
            // 
            // imgDownload
            // 
            resources.ApplyResources(this.imgDownload, "imgDownload");
            this.imgDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDownload.Image = global::WebPlex.Properties.Resources.cloud_download;
            this.imgDownload.Name = "imgDownload";
            this.imgDownload.TabStop = false;
            this.toolTip1.SetToolTip(this.imgDownload, resources.GetString("imgDownload.ToolTip"));
            this.imgDownload.Click += new System.EventHandler(this.imgDownload_Click);
            // 
            // imgAddToBookmarks
            // 
            resources.ApplyResources(this.imgAddToBookmarks, "imgAddToBookmarks");
            this.imgAddToBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAddToBookmarks.Image = global::WebPlex.Properties.Resources.bookmark_plus;
            this.imgAddToBookmarks.Name = "imgAddToBookmarks";
            this.imgAddToBookmarks.TabStop = false;
            this.toolTip1.SetToolTip(this.imgAddToBookmarks, resources.GetString("imgAddToBookmarks.ToolTip"));
            this.imgAddToBookmarks.Click += new System.EventHandler(this.imgAddToBookmarks_Click);
            // 
            // panelControls
            // 
            resources.ApplyResources(this.panelControls, "panelControls");
            this.panelControls.Controls.Add(this.imgReportBroken);
            this.panelControls.Controls.Add(this.imgCopyURL);
            this.panelControls.Controls.Add(this.imgWatch);
            this.panelControls.Controls.Add(this.imgDownload);
            this.panelControls.Controls.Add(this.imgMagnet);
            this.panelControls.Name = "panelControls";
            // 
            // ctrlStreamInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.infoName);
            this.Controls.Add(this.infoHost);
            this.Controls.Add(this.imgAddToBookmarks);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStreamInfo";
            this.Load += new System.EventHandler(this.ctrlStreamInfo_Load);
            this.contextFileName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCopyURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReportBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMagnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label infoHost;
        public System.Windows.Forms.Label infoName;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
        private System.Windows.Forms.PictureBox imgAddToBookmarks;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel panelControls;
        private System.Windows.Forms.ToolStripMenuItem VLC2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPCToolStripMenuItem;
        public System.Windows.Forms.PictureBox imgDownload;
        public System.Windows.Forms.PictureBox imgWatch;
        public System.Windows.Forms.PictureBox imgReportBroken;
        public System.Windows.Forms.PictureBox imgCopyURL;
        public System.Windows.Forms.PictureBox imgMagnet;
    }
}
