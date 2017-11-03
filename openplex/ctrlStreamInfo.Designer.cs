namespace OpenPlex
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
            this.infoFileHost = new System.Windows.Forms.Label();
            this.infoFileName = new System.Windows.Forms.Label();
            this.panelFileInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDownload = new CButtonLib.CButton();
            this.btnPlay = new CButtonLib.CButton();
            this.contextFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFileInfo.SuspendLayout();
            this.contextFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoFileHost
            // 
            this.infoFileHost.AutoEllipsis = true;
            this.infoFileHost.AutoSize = true;
            this.infoFileHost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoFileHost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileHost.Location = new System.Drawing.Point(2, 3);
            this.infoFileHost.Margin = new System.Windows.Forms.Padding(0);
            this.infoFileHost.Name = "infoFileHost";
            this.infoFileHost.Size = new System.Drawing.Size(74, 17);
            this.infoFileHost.TabIndex = 0;
            this.infoFileHost.Text = "Host Name";
            // 
            // infoFileName
            // 
            this.infoFileName.AutoEllipsis = true;
            this.infoFileName.AutoSize = true;
            this.infoFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileName.Location = new System.Drawing.Point(76, 3);
            this.infoFileName.Margin = new System.Windows.Forms.Padding(0);
            this.infoFileName.Name = "infoFileName";
            this.infoFileName.Size = new System.Drawing.Size(66, 17);
            this.infoFileName.TabIndex = 1;
            this.infoFileName.Text = "File Name";
            // 
            // panelFileInfo
            // 
            this.panelFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFileInfo.Controls.Add(this.infoFileHost);
            this.panelFileInfo.Controls.Add(this.infoFileName);
            this.panelFileInfo.Location = new System.Drawing.Point(0, 0);
            this.panelFileInfo.Name = "panelFileInfo";
            this.panelFileInfo.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.panelFileInfo.Size = new System.Drawing.Size(336, 25);
            this.panelFileInfo.TabIndex = 3;
            this.panelFileInfo.WrapContents = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnDownload.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnDownload.Corners.All = 1;
            this.btnDownload.Corners.LowerLeft = 1;
            this.btnDownload.Corners.LowerRight = 1;
            this.btnDownload.Corners.UpperLeft = 1;
            this.btnDownload.Corners.UpperRight = 1;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.DesignerSelected = false;
            this.btnDownload.DimFactorClick = 0;
            this.btnDownload.DimFactorHover = 0;
            this.btnDownload.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnDownload.ImageIndex = 0;
            this.btnDownload.Location = new System.Drawing.Point(395, 1);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnDownload.Size = new System.Drawing.Size(80, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextShadowShow = false;
            this.btnDownload.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnDownload_ClickButtonArea);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnPlay.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnPlay.Corners.All = 1;
            this.btnPlay.Corners.LowerLeft = 1;
            this.btnPlay.Corners.LowerRight = 1;
            this.btnPlay.Corners.UpperLeft = 1;
            this.btnPlay.Corners.UpperRight = 1;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DesignerSelected = false;
            this.btnPlay.DimFactorClick = 0;
            this.btnPlay.DimFactorHover = 0;
            this.btnPlay.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnPlay.ImageIndex = 0;
            this.btnPlay.Location = new System.Drawing.Point(342, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnPlay.Size = new System.Drawing.Size(47, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextShadowShow = false;
            this.btnPlay.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnPlay_ClickButtonArea);
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
            this.WMPToolStripMenuItem,
            this.VLCToolStripMenuItem});
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
            // ctrlStreamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.panelFileInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStreamInfo";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(476, 25);
            this.Load += new System.EventHandler(this.ctrlStreamInfo_Load);
            this.panelFileInfo.ResumeLayout(false);
            this.panelFileInfo.PerformLayout();
            this.contextFileName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label infoFileHost;
        public System.Windows.Forms.Label infoFileName;
        private System.Windows.Forms.FlowLayoutPanel panelFileInfo;
        private CButtonLib.CButton btnDownload;
        private CButtonLib.CButton btnPlay;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
        private System.Windows.Forms.ToolStripMenuItem OpenWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
    }
}
