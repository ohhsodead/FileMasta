namespace UserControls
{
    partial class MovieDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetails));
            CButtonLib.cBlendItems cBlendItems1 = new CButtonLib.cBlendItems();
            this.infoYear = new System.Windows.Forms.Label();
            this.infoGenre = new System.Windows.Forms.Label();
            this.lblSubDirector = new System.Windows.Forms.Label();
            this.infoDirector = new System.Windows.Forms.Label();
            this.lblSubCast = new System.Windows.Forms.Label();
            this.infoRuntime = new System.Windows.Forms.Label();
            this.infoRated = new System.Windows.Forms.Label();
            this.infoTitle = new System.Windows.Forms.Label();
            this.infoSynopsis = new System.Windows.Forms.Label();
            this.infoCast = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.infoSplitter0 = new System.Windows.Forms.Label();
            this.infoSplitter1 = new System.Windows.Forms.Label();
            this.infoSplitter2 = new System.Windows.Forms.Label();
            this.infoSplitter3 = new System.Windows.Forms.Label();
            this.imgIMDb = new System.Windows.Forms.PictureBox();
            this.infoSplitter4 = new System.Windows.Forms.Label();
            this.infoRatingIMDb = new System.Windows.Forms.Label();
            this.panelTitleFiles = new System.Windows.Forms.Panel();
            this.imgSearchForMore = new System.Windows.Forms.PictureBox();
            this.lblSearchForMore = new System.Windows.Forms.Label();
            this.lblHeaderDirectFiles = new System.Windows.Forms.Label();
            this.lineSplitter = new CButtonLib.CButton();
            this.panelStreams = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWatchTrailer = new CButtonLib.CButton();
            this.imgPoster = new System.Windows.Forms.PictureBox();
            this.appClose = new System.Windows.Forms.PictureBox();
            this.imgPosterBG = new System.Windows.Forms.PictureBox();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIMDb)).BeginInit();
            this.panelTitleFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchForMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPosterBG)).BeginInit();
            this.SuspendLayout();
            // 
            // infoYear
            // 
            resources.ApplyResources(this.infoYear, "infoYear");
            this.infoYear.Name = "infoYear";
            // 
            // infoGenre
            // 
            resources.ApplyResources(this.infoGenre, "infoGenre");
            this.infoGenre.Name = "infoGenre";
            // 
            // lblSubDirector
            // 
            resources.ApplyResources(this.lblSubDirector, "lblSubDirector");
            this.lblSubDirector.Name = "lblSubDirector";
            // 
            // infoDirector
            // 
            resources.ApplyResources(this.infoDirector, "infoDirector");
            this.panelDetails.SetFlowBreak(this.infoDirector, true);
            this.infoDirector.Name = "infoDirector";
            // 
            // lblSubCast
            // 
            resources.ApplyResources(this.lblSubCast, "lblSubCast");
            this.lblSubCast.Name = "lblSubCast";
            // 
            // infoRuntime
            // 
            resources.ApplyResources(this.infoRuntime, "infoRuntime");
            this.infoRuntime.Name = "infoRuntime";
            // 
            // infoRated
            // 
            resources.ApplyResources(this.infoRated, "infoRated");
            this.infoRated.Name = "infoRated";
            // 
            // infoTitle
            // 
            resources.ApplyResources(this.infoTitle, "infoTitle");
            this.infoTitle.AutoEllipsis = true;
            this.infoTitle.BackColor = System.Drawing.Color.Transparent;
            this.infoTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoTitle.Name = "infoTitle";
            // 
            // infoSynopsis
            // 
            resources.ApplyResources(this.infoSynopsis, "infoSynopsis");
            this.panelDetails.SetFlowBreak(this.infoSynopsis, true);
            this.infoSynopsis.Name = "infoSynopsis";
            // 
            // infoCast
            // 
            resources.ApplyResources(this.infoCast, "infoCast");
            this.panelDetails.SetFlowBreak(this.infoCast, true);
            this.infoCast.Name = "infoCast";
            // 
            // panelDetails
            // 
            resources.ApplyResources(this.panelDetails, "panelDetails");
            this.panelDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelDetails.Controls.Add(this.infoYear);
            this.panelDetails.Controls.Add(this.infoSplitter0);
            this.panelDetails.Controls.Add(this.infoGenre);
            this.panelDetails.Controls.Add(this.infoSplitter1);
            this.panelDetails.Controls.Add(this.infoRated);
            this.panelDetails.Controls.Add(this.infoSplitter2);
            this.panelDetails.Controls.Add(this.infoRuntime);
            this.panelDetails.Controls.Add(this.infoSplitter3);
            this.panelDetails.Controls.Add(this.imgIMDb);
            this.panelDetails.Controls.Add(this.infoSplitter4);
            this.panelDetails.Controls.Add(this.infoRatingIMDb);
            this.panelDetails.Controls.Add(this.infoSynopsis);
            this.panelDetails.Controls.Add(this.lblSubDirector);
            this.panelDetails.Controls.Add(this.infoDirector);
            this.panelDetails.Controls.Add(this.lblSubCast);
            this.panelDetails.Controls.Add(this.infoCast);
            this.panelDetails.Controls.Add(this.panelTitleFiles);
            this.panelDetails.Controls.Add(this.panelStreams);
            this.panelDetails.Name = "panelDetails";
            // 
            // infoSplitter0
            // 
            resources.ApplyResources(this.infoSplitter0, "infoSplitter0");
            this.infoSplitter0.Name = "infoSplitter0";
            // 
            // infoSplitter1
            // 
            resources.ApplyResources(this.infoSplitter1, "infoSplitter1");
            this.infoSplitter1.Name = "infoSplitter1";
            // 
            // infoSplitter2
            // 
            resources.ApplyResources(this.infoSplitter2, "infoSplitter2");
            this.infoSplitter2.Name = "infoSplitter2";
            // 
            // infoSplitter3
            // 
            resources.ApplyResources(this.infoSplitter3, "infoSplitter3");
            this.infoSplitter3.Name = "infoSplitter3";
            // 
            // imgIMDb
            // 
            this.imgIMDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgIMDb.Image = global::WebCrunch.Properties.Resources.imdb;
            resources.ApplyResources(this.imgIMDb, "imgIMDb");
            this.imgIMDb.Name = "imgIMDb";
            this.imgIMDb.TabStop = false;
            this.imgIMDb.Click += new System.EventHandler(this.imgIMDb_Click);
            // 
            // infoSplitter4
            // 
            resources.ApplyResources(this.infoSplitter4, "infoSplitter4");
            this.infoSplitter4.Name = "infoSplitter4";
            // 
            // infoRatingIMDb
            // 
            resources.ApplyResources(this.infoRatingIMDb, "infoRatingIMDb");
            this.panelDetails.SetFlowBreak(this.infoRatingIMDb, true);
            this.infoRatingIMDb.Name = "infoRatingIMDb";
            // 
            // panelTitleFiles
            // 
            resources.ApplyResources(this.panelTitleFiles, "panelTitleFiles");
            this.panelTitleFiles.BackColor = System.Drawing.Color.Transparent;
            this.panelTitleFiles.Controls.Add(this.imgSearchForMore);
            this.panelTitleFiles.Controls.Add(this.lblSearchForMore);
            this.panelTitleFiles.Controls.Add(this.lblHeaderDirectFiles);
            this.panelTitleFiles.Controls.Add(this.lineSplitter);
            this.panelDetails.SetFlowBreak(this.panelTitleFiles, true);
            this.panelTitleFiles.Name = "panelTitleFiles";
            // 
            // imgSearchForMore
            // 
            resources.ApplyResources(this.imgSearchForMore, "imgSearchForMore");
            this.imgSearchForMore.BackColor = System.Drawing.Color.Transparent;
            this.imgSearchForMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSearchForMore.Image = global::WebCrunch.Properties.Resources.magnify;
            this.imgSearchForMore.Name = "imgSearchForMore";
            this.imgSearchForMore.TabStop = false;
            this.imgSearchForMore.Click += new System.EventHandler(this.imgSearchForMore_Click);
            // 
            // lblSearchForMore
            // 
            resources.ApplyResources(this.lblSearchForMore, "lblSearchForMore");
            this.lblSearchForMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchForMore.Name = "lblSearchForMore";
            this.lblSearchForMore.Click += new System.EventHandler(this.imgSearchForMore_Click);
            // 
            // lblHeaderDirectFiles
            // 
            resources.ApplyResources(this.lblHeaderDirectFiles, "lblHeaderDirectFiles");
            this.lblHeaderDirectFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderDirectFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeaderDirectFiles.ForeColor = System.Drawing.Color.White;
            this.lblHeaderDirectFiles.Name = "lblHeaderDirectFiles";
            // 
            // lineSplitter
            // 
            resources.ApplyResources(this.lineSplitter, "lineSplitter");
            this.lineSplitter.BackColor = System.Drawing.Color.Transparent;
            this.lineSplitter.BorderColor = System.Drawing.Color.DarkGray;
            this.lineSplitter.ColorFillSolid = System.Drawing.Color.DarkGray;
            this.lineSplitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineSplitter.DesignerSelected = false;
            this.lineSplitter.DimFactorClick = 0;
            this.lineSplitter.DimFactorHover = 0;
            this.lineSplitter.FillType = CButtonLib.CButton.eFillType.Solid;
            this.lineSplitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.lineSplitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lineSplitter.ImageIndex = 0;
            this.lineSplitter.ImageSize = new System.Drawing.Size(25, 36);
            this.lineSplitter.Name = "lineSplitter";
            this.lineSplitter.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.lineSplitter.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lineSplitter.SideImageSize = new System.Drawing.Size(36, 36);
            this.lineSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lineSplitter.TextShadowShow = false;
            // 
            // panelStreams
            // 
            resources.ApplyResources(this.panelStreams, "panelStreams");
            this.panelStreams.BackColor = System.Drawing.Color.Transparent;
            this.panelDetails.SetFlowBreak(this.panelStreams, true);
            this.panelStreams.Name = "panelStreams";
            // 
            // btnWatchTrailer
            // 
            this.btnWatchTrailer.BackColor = System.Drawing.Color.Transparent;
            this.btnWatchTrailer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems1.iPoint = new float[] {
        0F,
        1F};
            this.btnWatchTrailer.ColorFillBlend = cBlendItems1;
            this.btnWatchTrailer.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btnWatchTrailer.Corners.All = 2;
            this.btnWatchTrailer.Corners.LowerLeft = 2;
            this.btnWatchTrailer.Corners.LowerRight = 2;
            this.btnWatchTrailer.Corners.UpperLeft = 2;
            this.btnWatchTrailer.Corners.UpperRight = 2;
            this.btnWatchTrailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchTrailer.DesignerSelected = true;
            this.btnWatchTrailer.DimFactorClick = 0;
            this.btnWatchTrailer.DimFactorHover = 0;
            this.btnWatchTrailer.FillType = CButtonLib.CButton.eFillType.Solid;
            resources.ApplyResources(this.btnWatchTrailer, "btnWatchTrailer");
            this.btnWatchTrailer.ImageIndex = 0;
            this.btnWatchTrailer.Name = "btnWatchTrailer";
            this.btnWatchTrailer.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnWatchTrailer.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWatchTrailer.SideImageSize = new System.Drawing.Size(0, 0);
            this.btnWatchTrailer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWatchTrailer.TextShadow = System.Drawing.Color.Empty;
            this.btnWatchTrailer.TextShadowShow = false;
            this.btnWatchTrailer.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnWatchTrailer_ClickButtonArea);
            // 
            // imgPoster
            // 
            this.imgPoster.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.imgPoster, "imgPoster");
            this.imgPoster.Name = "imgPoster";
            this.imgPoster.TabStop = false;
            // 
            // appClose
            // 
            resources.ApplyResources(this.appClose, "appClose");
            this.appClose.BackColor = System.Drawing.Color.Transparent;
            this.appClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appClose.Image = global::WebCrunch.Properties.Resources.close;
            this.appClose.Name = "appClose";
            this.appClose.TabStop = false;
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // imgPosterBG
            // 
            this.imgPosterBG.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.imgPosterBG, "imgPosterBG");
            this.imgPosterBG.Name = "imgPosterBG";
            this.imgPosterBG.TabStop = false;
            // 
            // MovieDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnWatchTrailer);
            this.Controls.Add(this.infoTitle);
            this.Controls.Add(this.imgPoster);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.appClose);
            this.Controls.Add(this.imgPosterBG);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MovieDetails";
            this.Load += new System.EventHandler(this.ctrlMovieDetails_Load);
            this.SizeChanged += new System.EventHandler(this.ctrlDetails_SizeChanged);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIMDb)).EndInit();
            this.panelTitleFiles.ResumeLayout(false);
            this.panelTitleFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchForMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPosterBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label infoYear;
        internal System.Windows.Forms.FlowLayoutPanel panelDetails;
        internal System.Windows.Forms.Label infoTitle;
        internal System.Windows.Forms.Label infoGenre;
        internal System.Windows.Forms.Label infoSynopsis;
        internal System.Windows.Forms.Label lblSubDirector;
        internal System.Windows.Forms.Label infoDirector;
        internal System.Windows.Forms.Label lblSubCast;
        internal System.Windows.Forms.Label infoCast;
        internal System.Windows.Forms.PictureBox imgPoster;
        internal System.Windows.Forms.Label infoRated;
        internal System.Windows.Forms.Label infoRuntime;
        internal System.Windows.Forms.PictureBox appClose;
        internal System.Windows.Forms.Label infoSplitter0;
        internal System.Windows.Forms.PictureBox imgPosterBG;
        internal System.Windows.Forms.Label infoSplitter1;
        internal System.Windows.Forms.Label infoSplitter2;
        internal System.Windows.Forms.Label infoSplitter3;
        internal System.Windows.Forms.Label infoRatingIMDb;
        internal System.Windows.Forms.Label infoSplitter4;
        internal System.Windows.Forms.PictureBox imgIMDb;
        internal System.Windows.Forms.Panel panelTitleFiles;
        internal System.Windows.Forms.Label lblHeaderDirectFiles;
        public CButtonLib.CButton lineSplitter;
        public System.Windows.Forms.FlowLayoutPanel panelStreams;
        public CButtonLib.CButton btnWatchTrailer;
        private System.Windows.Forms.PictureBox imgSearchForMore;
        internal System.Windows.Forms.Label lblSearchForMore;
    }
}
