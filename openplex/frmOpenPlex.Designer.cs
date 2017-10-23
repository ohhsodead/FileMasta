namespace OpenPlex
{
    partial class frmOpenPlex
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenPlex));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.txtSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btnTag5 = new CButtonLib.CButton();
            this.btnTag4 = new CButtonLib.CButton();
            this.btnTag3 = new CButtonLib.CButton();
            this.btnTag2 = new CButtonLib.CButton();
            this.btnTag1 = new CButtonLib.CButton();
            this.lblAddTags = new System.Windows.Forms.Label();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.imgOpenPlex = new System.Windows.Forms.PictureBox();
            this.btnSearch = new CButtonLib.CButton();
            this.bgSearchBox = new CButtonLib.CButton();
            this.tabSearchResults = new System.Windows.Forms.TabPage();
            this.panelSearchHeaders = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeaderResults = new System.Windows.Forms.Label();
            this.lblHeaderResultsText = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgCloseSearchResults = new System.Windows.Forms.PictureBox();
            this.tabFileDetails = new System.Windows.Forms.TabPage();
            this.imgCloseFileDetails = new System.Windows.Forms.PictureBox();
            this.imgFileInfoPoster = new System.Windows.Forms.PictureBox();
            this.panelFileItems = new System.Windows.Forms.FlowLayoutPanel();
            this.fileInfoTitle = new System.Windows.Forms.Label();
            this.panelFileSubItems = new System.Windows.Forms.FlowLayoutPanel();
            this.fileInfoGenre = new System.Windows.Forms.Label();
            this.movieInfoSplitter1 = new System.Windows.Forms.Label();
            this.fileInfoIMDbRating = new System.Windows.Forms.Label();
            this.movieInfoSplitter2 = new System.Windows.Forms.Label();
            this.fileInfoRuntime = new System.Windows.Forms.Label();
            this.movieInfoSplitter3 = new System.Windows.Forms.Label();
            this.fileInfoReleaseDate = new System.Windows.Forms.Label();
            this.fileInfoDescription = new System.Windows.Forms.Label();
            this.btnFilePlay = new CButtonLib.CButton();
            this.btnFileDownload = new CButtonLib.CButton();
            this.btnFileTrailer = new CButtonLib.CButton();
            this.fileInfoIMDbId = new System.Windows.Forms.Label();
            this.fileInfoSeriesId = new System.Windows.Forms.Label();
            this.fileInfoPopcornFanartURL = new System.Windows.Forms.Label();
            this.fileInfoPopcornTrailerURL = new System.Windows.Forms.Label();
            this.fileInfoURL = new System.Windows.Forms.Label();
            this.imgMoviePosterBackground = new System.Windows.Forms.PictureBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.btnAboutReportIssue = new System.Windows.Forms.Label();
            this.lblAboutSubText = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.imgCloseAbout = new System.Windows.Forms.PictureBox();
            this.imgHeaderAbout = new System.Windows.Forms.PictureBox();
            this.btnFileReportBroken = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenPlex)).BeginInit();
            this.tabSearchResults.SuspendLayout();
            this.panelSearchHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseSearchResults)).BeginInit();
            this.tabFileDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseFileDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFileInfoPoster)).BeginInit();
            this.panelFileItems.SuspendLayout();
            this.panelFileSubItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePosterBackground)).BeginInit();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabHome);
            this.tab.Controls.Add(this.tabSearchResults);
            this.tab.Controls.Add(this.tabFileDetails);
            this.tab.Controls.Add(this.tabAbout);
            this.tab.Location = new System.Drawing.Point(-4, -22);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(959, 544);
            this.tab.TabIndex = 0;
            this.tab.TabStop = false;
            // 
            // tabHome
            // 
            this.tabHome.AllowDrop = true;
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHome.Controls.Add(this.txtSearchBox);
            this.tabHome.Controls.Add(this.btnTag5);
            this.tabHome.Controls.Add(this.btnTag4);
            this.tabHome.Controls.Add(this.btnTag3);
            this.tabHome.Controls.Add(this.btnTag2);
            this.tabHome.Controls.Add(this.btnTag1);
            this.tabHome.Controls.Add(this.lblAddTags);
            this.tabHome.Controls.Add(this.imgAbout);
            this.tabHome.Controls.Add(this.imgOpenPlex);
            this.tabHome.Controls.Add(this.btnSearch);
            this.tabHome.Controls.Add(this.bgSearchBox);
            this.tabHome.ForeColor = System.Drawing.Color.White;
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(951, 518);
            this.tabHome.TabIndex = 0;
            this.tabHome.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabHome_DragDrop);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtSearchBox.Location = new System.Drawing.Point(100, 220);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(700, 25);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.WaterMark = "Search movies, add some tags, insert a link or drag and drop a file...";
            this.txtSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.txtSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchBox.WaterMarkForeColor = System.Drawing.Color.Silver;
            // 
            // btnTag5
            // 
            this.btnTag5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag5.BackColor = System.Drawing.Color.Transparent;
            this.btnTag5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag5.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag5.Corners.All = 2;
            this.btnTag5.Corners.LowerLeft = 2;
            this.btnTag5.Corners.LowerRight = 2;
            this.btnTag5.Corners.UpperLeft = 2;
            this.btnTag5.Corners.UpperRight = 2;
            this.btnTag5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag5.DesignerSelected = false;
            this.btnTag5.DimFactorClick = 0;
            this.btnTag5.DimFactorHover = 0;
            this.btnTag5.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag5.ImageIndex = 0;
            this.btnTag5.Location = new System.Drawing.Point(431, 279);
            this.btnTag5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag5.Name = "btnTag5";
            this.btnTag5.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag5.Size = new System.Drawing.Size(56, 31);
            this.btnTag5.TabIndex = 6;
            this.btnTag5.TabStop = false;
            this.btnTag5.Text = "720p";
            this.btnTag5.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag5.TextShadowShow = false;
            this.btnTag5.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag4
            // 
            this.btnTag4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag4.BackColor = System.Drawing.Color.Transparent;
            this.btnTag4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag4.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag4.Corners.All = 2;
            this.btnTag4.Corners.LowerLeft = 2;
            this.btnTag4.Corners.LowerRight = 2;
            this.btnTag4.Corners.UpperLeft = 2;
            this.btnTag4.Corners.UpperRight = 2;
            this.btnTag4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag4.DesignerSelected = false;
            this.btnTag4.DimFactorClick = 0;
            this.btnTag4.DimFactorHover = 0;
            this.btnTag4.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag4.ImageIndex = 0;
            this.btnTag4.Location = new System.Drawing.Point(365, 279);
            this.btnTag4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag4.Name = "btnTag4";
            this.btnTag4.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag4.Size = new System.Drawing.Size(56, 31);
            this.btnTag4.TabIndex = 5;
            this.btnTag4.TabStop = false;
            this.btnTag4.Text = "2013";
            this.btnTag4.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag4.TextShadowShow = false;
            this.btnTag4.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag3
            // 
            this.btnTag3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag3.BackColor = System.Drawing.Color.Transparent;
            this.btnTag3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag3.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag3.Corners.All = 2;
            this.btnTag3.Corners.LowerLeft = 2;
            this.btnTag3.Corners.LowerRight = 2;
            this.btnTag3.Corners.UpperLeft = 2;
            this.btnTag3.Corners.UpperRight = 2;
            this.btnTag3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag3.DesignerSelected = false;
            this.btnTag3.DimFactorClick = 0;
            this.btnTag3.DimFactorHover = 0;
            this.btnTag3.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag3.ImageIndex = 0;
            this.btnTag3.Location = new System.Drawing.Point(312, 279);
            this.btnTag3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag3.Name = "btnTag3";
            this.btnTag3.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag3.Size = new System.Drawing.Size(43, 31);
            this.btnTag3.TabIndex = 4;
            this.btnTag3.TabStop = false;
            this.btnTag3.Text = "HD";
            this.btnTag3.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag3.TextShadowShow = false;
            this.btnTag3.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag2
            // 
            this.btnTag2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag2.BackColor = System.Drawing.Color.Transparent;
            this.btnTag2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag2.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag2.Corners.All = 2;
            this.btnTag2.Corners.LowerLeft = 2;
            this.btnTag2.Corners.LowerRight = 2;
            this.btnTag2.Corners.UpperLeft = 2;
            this.btnTag2.Corners.UpperRight = 2;
            this.btnTag2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag2.DesignerSelected = false;
            this.btnTag2.DimFactorClick = 0;
            this.btnTag2.DimFactorHover = 0;
            this.btnTag2.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag2.ImageIndex = 0;
            this.btnTag2.Location = new System.Drawing.Point(238, 279);
            this.btnTag2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag2.Name = "btnTag2";
            this.btnTag2.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag2.Size = new System.Drawing.Size(64, 31);
            this.btnTag2.TabIndex = 3;
            this.btnTag2.TabStop = false;
            this.btnTag2.Text = "1080p";
            this.btnTag2.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag2.TextShadowShow = false;
            this.btnTag2.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag1
            // 
            this.btnTag1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag1.BackColor = System.Drawing.Color.Transparent;
            this.btnTag1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag1.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag1.Corners.All = 2;
            this.btnTag1.Corners.LowerLeft = 2;
            this.btnTag1.Corners.LowerRight = 2;
            this.btnTag1.Corners.UpperLeft = 2;
            this.btnTag1.Corners.UpperRight = 2;
            this.btnTag1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag1.DesignerSelected = false;
            this.btnTag1.DimFactorClick = 0;
            this.btnTag1.DimFactorHover = 0;
            this.btnTag1.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag1.ImageIndex = 0;
            this.btnTag1.Location = new System.Drawing.Point(172, 279);
            this.btnTag1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag1.Name = "btnTag1";
            this.btnTag1.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag1.Size = new System.Drawing.Size(56, 31);
            this.btnTag1.TabIndex = 2;
            this.btnTag1.TabStop = false;
            this.btnTag1.Text = "2017";
            this.btnTag1.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag1.TextShadowShow = false;
            this.btnTag1.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // lblAddTags
            // 
            this.lblAddTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddTags.AutoSize = true;
            this.lblAddTags.BackColor = System.Drawing.Color.Transparent;
            this.lblAddTags.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.lblAddTags.ForeColor = System.Drawing.Color.Silver;
            this.lblAddTags.Location = new System.Drawing.Point(88, 285);
            this.lblAddTags.Name = "lblAddTags";
            this.lblAddTags.Size = new System.Drawing.Size(70, 17);
            this.lblAddTags.TabIndex = 1;
            this.lblAddTags.Text = "ADD TAGS";
            // 
            // imgAbout
            // 
            this.imgAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAbout.Image = global::OpenPlex.Properties.Resources.iconAbout;
            this.imgAbout.Location = new System.Drawing.Point(900, 25);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(24, 24);
            this.imgAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAbout.TabIndex = 4;
            this.imgAbout.TabStop = false;
            this.imgAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // imgOpenPlex
            // 
            this.imgOpenPlex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgOpenPlex.BackColor = System.Drawing.Color.Transparent;
            this.imgOpenPlex.Image = global::OpenPlex.Properties.Resources.openplex_text;
            this.imgOpenPlex.Location = new System.Drawing.Point(373, 21);
            this.imgOpenPlex.Name = "imgOpenPlex";
            this.imgOpenPlex.Size = new System.Drawing.Size(204, 30);
            this.imgOpenPlex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpenPlex.TabIndex = 1;
            this.imgOpenPlex.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ColorFillSolid = System.Drawing.Color.SteelBlue;
            this.btnSearch.Corners.LowerRight = 2;
            this.btnSearch.Corners.UpperRight = 2;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DesignerSelected = false;
            this.btnSearch.DimFactorClick = 0;
            this.btnSearch.DimFactorHover = 0;
            this.btnSearch.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearch.FocalPoints.CenterPtX = 0F;
            this.btnSearch.FocalPoints.CenterPtY = 0F;
            this.btnSearch.Image = global::OpenPlex.Properties.Resources.SearchIconH;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageSize = new System.Drawing.Size(21, 21);
            this.btnSearch.Location = new System.Drawing.Point(811, 209);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearch.Size = new System.Drawing.Size(48, 48);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "";
            this.btnSearch.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearch_ClickButtonArea);
            // 
            // bgSearchBox
            // 
            this.bgSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bgSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bgSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bgSearchBox.Corners.All = 2;
            this.bgSearchBox.Corners.LowerLeft = 2;
            this.bgSearchBox.Corners.LowerRight = 2;
            this.bgSearchBox.Corners.UpperLeft = 2;
            this.bgSearchBox.Corners.UpperRight = 2;
            this.bgSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSearchBox.DesignerSelected = false;
            this.bgSearchBox.DimFactorClick = 0;
            this.bgSearchBox.DimFactorHover = 0;
            this.bgSearchBox.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSearchBox.ImageIndex = 0;
            this.bgSearchBox.Location = new System.Drawing.Point(91, 209);
            this.bgSearchBox.Name = "bgSearchBox";
            this.bgSearchBox.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSearchBox.Size = new System.Drawing.Size(768, 48);
            this.bgSearchBox.TabIndex = 0;
            this.bgSearchBox.TabStop = false;
            this.bgSearchBox.Text = "";
            // 
            // tabSearchResults
            // 
            this.tabSearchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabSearchResults.Controls.Add(this.panelSearchHeaders);
            this.tabSearchResults.Controls.Add(this.dataGrid);
            this.tabSearchResults.Controls.Add(this.imgCloseSearchResults);
            this.tabSearchResults.ForeColor = System.Drawing.Color.White;
            this.tabSearchResults.Location = new System.Drawing.Point(4, 22);
            this.tabSearchResults.Name = "tabSearchResults";
            this.tabSearchResults.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabSearchResults.Size = new System.Drawing.Size(951, 518);
            this.tabSearchResults.TabIndex = 1;
            // 
            // panelSearchHeaders
            // 
            this.panelSearchHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchHeaders.Controls.Add(this.lblHeaderResults);
            this.panelSearchHeaders.Controls.Add(this.lblHeaderResultsText);
            this.panelSearchHeaders.Location = new System.Drawing.Point(0, 0);
            this.panelSearchHeaders.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelSearchHeaders.Name = "panelSearchHeaders";
            this.panelSearchHeaders.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.panelSearchHeaders.Size = new System.Drawing.Size(908, 39);
            this.panelSearchHeaders.TabIndex = 4;
            // 
            // lblHeaderResults
            // 
            this.lblHeaderResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderResults.AutoSize = true;
            this.lblHeaderResults.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderResults.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lblHeaderResults.Location = new System.Drawing.Point(5, 3);
            this.lblHeaderResults.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblHeaderResults.Name = "lblHeaderResults";
            this.lblHeaderResults.Size = new System.Drawing.Size(189, 28);
            this.lblHeaderResults.TabIndex = 3;
            this.lblHeaderResults.Text = "Showing results for";
            // 
            // lblHeaderResultsText
            // 
            this.lblHeaderResultsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderResultsText.AutoSize = true;
            this.lblHeaderResultsText.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderResultsText.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lblHeaderResultsText.ForeColor = System.Drawing.Color.LightGray;
            this.lblHeaderResultsText.Location = new System.Drawing.Point(194, 3);
            this.lblHeaderResultsText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblHeaderResultsText.Name = "lblHeaderResultsText";
            this.lblHeaderResultsText.Size = new System.Drawing.Size(49, 28);
            this.lblHeaderResultsText.TabIndex = 4;
            this.lblHeaderResultsText.Text = "Text";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnHost,
            this.columnFileName,
            this.columnURL});
            this.dataGrid.ContextMenuStrip = this.contextFileName;
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 39);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.Size = new System.Drawing.Size(951, 479);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGrid_RowPrePaint);
            // 
            // columnHost
            // 
            this.columnHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnHost.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnHost.HeaderText = "Host";
            this.columnHost.Name = "columnHost";
            this.columnHost.ReadOnly = true;
            this.columnHost.Width = 60;
            // 
            // columnFileName
            // 
            this.columnFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFileName.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnFileName.HeaderText = "File Name";
            this.columnFileName.Name = "columnFileName";
            this.columnFileName.ReadOnly = true;
            // 
            // columnURL
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnURL.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnURL.HeaderText = "URL";
            this.columnURL.Name = "columnURL";
            this.columnURL.ReadOnly = true;
            this.columnURL.Visible = false;
            this.columnURL.Width = 851;
            // 
            // contextFileName
            // 
            this.contextFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWithToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem});
            this.contextFileName.Name = "contextMenuStrip1";
            this.contextFileName.ShowImageMargin = false;
            this.contextFileName.ShowItemToolTips = false;
            this.contextFileName.Size = new System.Drawing.Size(147, 48);
            // 
            // OpenWithToolStripMenuItem
            // 
            this.OpenWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WMPToolStripMenuItem,
            this.VLCToolStripMenuItem});
            this.OpenWithToolStripMenuItem.Name = "OpenWithToolStripMenuItem";
            this.OpenWithToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.OpenWithToolStripMenuItem.Text = "Open with...";
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.WMPToolStripMenuItem.Text = "WMP";
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.wMPToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.VLCToolStripMenuItem.Text = "VLC";
            this.VLCToolStripMenuItem.Click += new System.EventHandler(this.VLCToolStripMenuItem1_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // imgCloseSearchResults
            // 
            this.imgCloseSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.imgCloseSearchResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseSearchResults.Image = global::OpenPlex.Properties.Resources.iconCLoseL;
            this.imgCloseSearchResults.Location = new System.Drawing.Point(915, 10);
            this.imgCloseSearchResults.Name = "imgCloseSearchResults";
            this.imgCloseSearchResults.Size = new System.Drawing.Size(24, 24);
            this.imgCloseSearchResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCloseSearchResults.TabIndex = 5;
            this.imgCloseSearchResults.TabStop = false;
            this.imgCloseSearchResults.Click += new System.EventHandler(this.imgCloseSearchResults_Click);
            // 
            // tabFileDetails
            // 
            this.tabFileDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabFileDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabFileDetails.Controls.Add(this.btnFileReportBroken);
            this.tabFileDetails.Controls.Add(this.imgCloseFileDetails);
            this.tabFileDetails.Controls.Add(this.imgFileInfoPoster);
            this.tabFileDetails.Controls.Add(this.panelFileItems);
            this.tabFileDetails.Controls.Add(this.imgMoviePosterBackground);
            this.tabFileDetails.ForeColor = System.Drawing.Color.White;
            this.tabFileDetails.Location = new System.Drawing.Point(4, 22);
            this.tabFileDetails.Name = "tabFileDetails";
            this.tabFileDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabFileDetails.Size = new System.Drawing.Size(951, 518);
            this.tabFileDetails.TabIndex = 3;
            // 
            // imgCloseFileDetails
            // 
            this.imgCloseFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseFileDetails.BackColor = System.Drawing.Color.Transparent;
            this.imgCloseFileDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseFileDetails.Image = global::OpenPlex.Properties.Resources.iconCLoseL;
            this.imgCloseFileDetails.Location = new System.Drawing.Point(900, 25);
            this.imgCloseFileDetails.Name = "imgCloseFileDetails";
            this.imgCloseFileDetails.Size = new System.Drawing.Size(24, 24);
            this.imgCloseFileDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCloseFileDetails.TabIndex = 7;
            this.imgCloseFileDetails.TabStop = false;
            this.imgCloseFileDetails.Click += new System.EventHandler(this.imgCloseFileDetails_Click);
            // 
            // imgFileInfoPoster
            // 
            this.imgFileInfoPoster.BackColor = System.Drawing.Color.Transparent;
            this.imgFileInfoPoster.Location = new System.Drawing.Point(31, 26);
            this.imgFileInfoPoster.Name = "imgFileInfoPoster";
            this.imgFileInfoPoster.Size = new System.Drawing.Size(162, 246);
            this.imgFileInfoPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFileInfoPoster.TabIndex = 0;
            this.imgFileInfoPoster.TabStop = false;
            // 
            // panelFileItems
            // 
            this.panelFileItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFileItems.BackColor = System.Drawing.Color.Transparent;
            this.panelFileItems.Controls.Add(this.fileInfoTitle);
            this.panelFileItems.Controls.Add(this.panelFileSubItems);
            this.panelFileItems.Controls.Add(this.fileInfoDescription);
            this.panelFileItems.Controls.Add(this.btnFilePlay);
            this.panelFileItems.Controls.Add(this.btnFileDownload);
            this.panelFileItems.Controls.Add(this.btnFileTrailer);
            this.panelFileItems.Controls.Add(this.fileInfoIMDbId);
            this.panelFileItems.Controls.Add(this.fileInfoSeriesId);
            this.panelFileItems.Controls.Add(this.fileInfoPopcornFanartURL);
            this.panelFileItems.Controls.Add(this.fileInfoPopcornTrailerURL);
            this.panelFileItems.Controls.Add(this.fileInfoURL);
            this.panelFileItems.Location = new System.Drawing.Point(214, 26);
            this.panelFileItems.Name = "panelFileItems";
            this.panelFileItems.Size = new System.Drawing.Size(668, 465);
            this.panelFileItems.TabIndex = 6;
            // 
            // fileInfoTitle
            // 
            this.fileInfoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoTitle.AutoEllipsis = true;
            this.fileInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.fileInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.fileInfoTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 8);
            this.fileInfoTitle.Name = "fileInfoTitle";
            this.fileInfoTitle.Size = new System.Drawing.Size(668, 41);
            this.fileInfoTitle.TabIndex = 1;
            this.fileInfoTitle.Text = "Title";
            // 
            // panelFileSubItems
            // 
            this.panelFileSubItems.AutoSize = true;
            this.panelFileSubItems.BackColor = System.Drawing.Color.Transparent;
            this.panelFileSubItems.Controls.Add(this.fileInfoGenre);
            this.panelFileSubItems.Controls.Add(this.movieInfoSplitter1);
            this.panelFileSubItems.Controls.Add(this.fileInfoIMDbRating);
            this.panelFileSubItems.Controls.Add(this.movieInfoSplitter2);
            this.panelFileSubItems.Controls.Add(this.fileInfoRuntime);
            this.panelFileSubItems.Controls.Add(this.movieInfoSplitter3);
            this.panelFileSubItems.Controls.Add(this.fileInfoReleaseDate);
            this.panelFileItems.SetFlowBreak(this.panelFileSubItems, true);
            this.panelFileSubItems.Location = new System.Drawing.Point(5, 49);
            this.panelFileSubItems.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.panelFileSubItems.Name = "panelFileSubItems";
            this.panelFileSubItems.Size = new System.Drawing.Size(285, 20);
            this.panelFileSubItems.TabIndex = 2;
            this.panelFileSubItems.WrapContents = false;
            // 
            // fileInfoGenre
            // 
            this.fileInfoGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoGenre.AutoSize = true;
            this.fileInfoGenre.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoGenre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileInfoGenre.Location = new System.Drawing.Point(0, 0);
            this.fileInfoGenre.Margin = new System.Windows.Forms.Padding(0);
            this.fileInfoGenre.Name = "fileInfoGenre";
            this.fileInfoGenre.Size = new System.Drawing.Size(48, 20);
            this.fileInfoGenre.TabIndex = 3;
            this.fileInfoGenre.Text = "Genre";
            // 
            // movieInfoSplitter1
            // 
            this.movieInfoSplitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoSplitter1.AutoSize = true;
            this.movieInfoSplitter1.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoSplitter1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoSplitter1.Location = new System.Drawing.Point(48, 0);
            this.movieInfoSplitter1.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoSplitter1.Name = "movieInfoSplitter1";
            this.movieInfoSplitter1.Size = new System.Drawing.Size(15, 20);
            this.movieInfoSplitter1.TabIndex = 4;
            this.movieInfoSplitter1.Text = "•";
            // 
            // fileInfoIMDbRating
            // 
            this.fileInfoIMDbRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoIMDbRating.AutoSize = true;
            this.fileInfoIMDbRating.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoIMDbRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileInfoIMDbRating.Location = new System.Drawing.Point(63, 0);
            this.fileInfoIMDbRating.Margin = new System.Windows.Forms.Padding(0);
            this.fileInfoIMDbRating.Name = "fileInfoIMDbRating";
            this.fileInfoIMDbRating.Size = new System.Drawing.Size(50, 20);
            this.fileInfoIMDbRating.TabIndex = 5;
            this.fileInfoIMDbRating.Text = "0.0/10";
            // 
            // movieInfoSplitter2
            // 
            this.movieInfoSplitter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoSplitter2.AutoSize = true;
            this.movieInfoSplitter2.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoSplitter2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoSplitter2.Location = new System.Drawing.Point(113, 0);
            this.movieInfoSplitter2.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoSplitter2.Name = "movieInfoSplitter2";
            this.movieInfoSplitter2.Size = new System.Drawing.Size(15, 20);
            this.movieInfoSplitter2.TabIndex = 10;
            this.movieInfoSplitter2.Text = "•";
            // 
            // fileInfoRuntime
            // 
            this.fileInfoRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoRuntime.AutoSize = true;
            this.fileInfoRuntime.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoRuntime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileInfoRuntime.Location = new System.Drawing.Point(128, 0);
            this.fileInfoRuntime.Margin = new System.Windows.Forms.Padding(0);
            this.fileInfoRuntime.Name = "fileInfoRuntime";
            this.fileInfoRuntime.Size = new System.Drawing.Size(46, 20);
            this.fileInfoRuntime.TabIndex = 11;
            this.fileInfoRuntime.Text = "0 min";
            // 
            // movieInfoSplitter3
            // 
            this.movieInfoSplitter3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoSplitter3.AutoSize = true;
            this.movieInfoSplitter3.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoSplitter3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoSplitter3.Location = new System.Drawing.Point(174, 0);
            this.movieInfoSplitter3.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoSplitter3.Name = "movieInfoSplitter3";
            this.movieInfoSplitter3.Size = new System.Drawing.Size(15, 20);
            this.movieInfoSplitter3.TabIndex = 12;
            this.movieInfoSplitter3.Text = "•";
            // 
            // fileInfoReleaseDate
            // 
            this.fileInfoReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoReleaseDate.AutoSize = true;
            this.fileInfoReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoReleaseDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileInfoReleaseDate.Location = new System.Drawing.Point(189, 0);
            this.fileInfoReleaseDate.Margin = new System.Windows.Forms.Padding(0);
            this.fileInfoReleaseDate.Name = "fileInfoReleaseDate";
            this.fileInfoReleaseDate.Size = new System.Drawing.Size(96, 20);
            this.fileInfoReleaseDate.TabIndex = 13;
            this.fileInfoReleaseDate.Text = "Release Date";
            // 
            // fileInfoDescription
            // 
            this.fileInfoDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoDescription.AutoSize = true;
            this.fileInfoDescription.BackColor = System.Drawing.Color.Transparent;
            this.panelFileItems.SetFlowBreak(this.fileInfoDescription, true);
            this.fileInfoDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileInfoDescription.Location = new System.Drawing.Point(5, 88);
            this.fileInfoDescription.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.fileInfoDescription.Name = "fileInfoDescription";
            this.fileInfoDescription.Size = new System.Drawing.Size(33, 19);
            this.fileInfoDescription.TabIndex = 3;
            this.fileInfoDescription.Text = "Plot";
            // 
            // btnFilePlay
            // 
            this.btnFilePlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnFilePlay.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnFilePlay.ContextMenuStrip = this.contextFileName;
            this.btnFilePlay.Corners.All = 2;
            this.btnFilePlay.Corners.LowerLeft = 2;
            this.btnFilePlay.Corners.LowerRight = 2;
            this.btnFilePlay.Corners.UpperLeft = 2;
            this.btnFilePlay.Corners.UpperRight = 2;
            this.btnFilePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilePlay.DesignerSelected = false;
            this.btnFilePlay.DimFactorClick = 0;
            this.btnFilePlay.DimFactorHover = 0;
            this.btnFilePlay.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnFilePlay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnFilePlay.ImageIndex = 0;
            this.btnFilePlay.Location = new System.Drawing.Point(9, 127);
            this.btnFilePlay.Margin = new System.Windows.Forms.Padding(9, 0, 3, 3);
            this.btnFilePlay.Name = "btnFilePlay";
            this.btnFilePlay.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFilePlay.Size = new System.Drawing.Size(44, 25);
            this.btnFilePlay.TabIndex = 4;
            this.btnFilePlay.Text = "Play";
            this.btnFilePlay.TextShadowShow = false;
            this.btnFilePlay.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFilePlay_ClickButtonArea);
            // 
            // btnFileDownload
            // 
            this.btnFileDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnFileDownload.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnFileDownload.Corners.All = 2;
            this.btnFileDownload.Corners.LowerLeft = 2;
            this.btnFileDownload.Corners.LowerRight = 2;
            this.btnFileDownload.Corners.UpperLeft = 2;
            this.btnFileDownload.Corners.UpperRight = 2;
            this.btnFileDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileDownload.DesignerSelected = false;
            this.btnFileDownload.DimFactorClick = 0;
            this.btnFileDownload.DimFactorHover = 0;
            this.btnFileDownload.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnFileDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnFileDownload.ImageIndex = 0;
            this.btnFileDownload.Location = new System.Drawing.Point(59, 127);
            this.btnFileDownload.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnFileDownload.Name = "btnFileDownload";
            this.btnFileDownload.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFileDownload.Size = new System.Drawing.Size(80, 25);
            this.btnFileDownload.TabIndex = 5;
            this.btnFileDownload.Text = "Download";
            this.btnFileDownload.TextShadowShow = false;
            this.btnFileDownload.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFileDownload_ClickButtonArea);
            // 
            // btnFileTrailer
            // 
            this.btnFileTrailer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnFileTrailer.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnFileTrailer.Corners.All = 2;
            this.btnFileTrailer.Corners.LowerLeft = 2;
            this.btnFileTrailer.Corners.LowerRight = 2;
            this.btnFileTrailer.Corners.UpperLeft = 2;
            this.btnFileTrailer.Corners.UpperRight = 2;
            this.btnFileTrailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileTrailer.DesignerSelected = false;
            this.btnFileTrailer.DimFactorClick = 0;
            this.btnFileTrailer.DimFactorHover = 0;
            this.btnFileTrailer.FillType = CButtonLib.CButton.eFillType.Solid;
            this.panelFileItems.SetFlowBreak(this.btnFileTrailer, true);
            this.btnFileTrailer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnFileTrailer.ImageIndex = 0;
            this.btnFileTrailer.Location = new System.Drawing.Point(145, 127);
            this.btnFileTrailer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnFileTrailer.Name = "btnFileTrailer";
            this.btnFileTrailer.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFileTrailer.Size = new System.Drawing.Size(58, 25);
            this.btnFileTrailer.TabIndex = 9;
            this.btnFileTrailer.Text = "Trailer";
            this.btnFileTrailer.TextShadowShow = false;
            this.btnFileTrailer.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFileTrailer_ClickButtonArea);
            // 
            // fileInfoIMDbId
            // 
            this.fileInfoIMDbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoIMDbId.AutoSize = true;
            this.fileInfoIMDbId.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoIMDbId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileInfoIMDbId.Location = new System.Drawing.Point(5, 155);
            this.fileInfoIMDbId.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.fileInfoIMDbId.Name = "fileInfoIMDbId";
            this.fileInfoIMDbId.Size = new System.Drawing.Size(65, 20);
            this.fileInfoIMDbId.TabIndex = 6;
            this.fileInfoIMDbId.Text = "IMDb ID";
            this.fileInfoIMDbId.Visible = false;
            // 
            // fileInfoSeriesId
            // 
            this.fileInfoSeriesId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoSeriesId.AutoSize = true;
            this.fileInfoSeriesId.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoSeriesId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileInfoSeriesId.Location = new System.Drawing.Point(75, 155);
            this.fileInfoSeriesId.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.fileInfoSeriesId.Name = "fileInfoSeriesId";
            this.fileInfoSeriesId.Size = new System.Drawing.Size(67, 20);
            this.fileInfoSeriesId.TabIndex = 10;
            this.fileInfoSeriesId.Text = "Series ID";
            this.fileInfoSeriesId.Visible = false;
            // 
            // fileInfoPopcornFanartURL
            // 
            this.fileInfoPopcornFanartURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoPopcornFanartURL.AutoSize = true;
            this.fileInfoPopcornFanartURL.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoPopcornFanartURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileInfoPopcornFanartURL.Location = new System.Drawing.Point(147, 155);
            this.fileInfoPopcornFanartURL.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.fileInfoPopcornFanartURL.Name = "fileInfoPopcornFanartURL";
            this.fileInfoPopcornFanartURL.Size = new System.Drawing.Size(77, 19);
            this.fileInfoPopcornFanartURL.TabIndex = 8;
            this.fileInfoPopcornFanartURL.Text = "Fanart URL";
            this.fileInfoPopcornFanartURL.Visible = false;
            // 
            // fileInfoPopcornTrailerURL
            // 
            this.fileInfoPopcornTrailerURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoPopcornTrailerURL.AutoSize = true;
            this.fileInfoPopcornTrailerURL.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoPopcornTrailerURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileInfoPopcornTrailerURL.Location = new System.Drawing.Point(229, 155);
            this.fileInfoPopcornTrailerURL.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.fileInfoPopcornTrailerURL.Name = "fileInfoPopcornTrailerURL";
            this.fileInfoPopcornTrailerURL.Size = new System.Drawing.Size(74, 19);
            this.fileInfoPopcornTrailerURL.TabIndex = 7;
            this.fileInfoPopcornTrailerURL.Text = "Trailer URL";
            this.fileInfoPopcornTrailerURL.Visible = false;
            // 
            // fileInfoURL
            // 
            this.fileInfoURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoURL.AutoSize = true;
            this.fileInfoURL.BackColor = System.Drawing.Color.Transparent;
            this.fileInfoURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileInfoURL.Location = new System.Drawing.Point(308, 155);
            this.fileInfoURL.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.fileInfoURL.Name = "fileInfoURL";
            this.fileInfoURL.Size = new System.Drawing.Size(58, 19);
            this.fileInfoURL.TabIndex = 6;
            this.fileInfoURL.Text = "File URL";
            this.fileInfoURL.Visible = false;
            // 
            // imgMoviePosterBackground
            // 
            this.imgMoviePosterBackground.BackColor = System.Drawing.Color.Transparent;
            this.imgMoviePosterBackground.Image = global::OpenPlex.Properties.Resources.PosterGlow;
            this.imgMoviePosterBackground.Location = new System.Drawing.Point(20, 13);
            this.imgMoviePosterBackground.Name = "imgMoviePosterBackground";
            this.imgMoviePosterBackground.Size = new System.Drawing.Size(185, 269);
            this.imgMoviePosterBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMoviePosterBackground.TabIndex = 8;
            this.imgMoviePosterBackground.TabStop = false;
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAbout.Controls.Add(this.lblAboutVersion);
            this.tabAbout.Controls.Add(this.btnAboutReportIssue);
            this.tabAbout.Controls.Add(this.lblAboutSubText);
            this.tabAbout.Controls.Add(this.lblAboutText);
            this.tabAbout.Controls.Add(this.imgCloseAbout);
            this.tabAbout.Controls.Add(this.imgHeaderAbout);
            this.tabAbout.ForeColor = System.Drawing.Color.White;
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(951, 518);
            this.tabAbout.TabIndex = 2;
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAboutVersion.Location = new System.Drawing.Point(871, 496);
            this.lblAboutVersion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(74, 15);
            this.lblAboutVersion.TabIndex = 12;
            this.lblAboutVersion.Text = "version";
            this.lblAboutVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAboutReportIssue
            // 
            this.btnAboutReportIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutReportIssue.AutoSize = true;
            this.btnAboutReportIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutReportIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutReportIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAboutReportIssue.Location = new System.Drawing.Point(6, 496);
            this.btnAboutReportIssue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.btnAboutReportIssue.Name = "btnAboutReportIssue";
            this.btnAboutReportIssue.Size = new System.Drawing.Size(87, 15);
            this.btnAboutReportIssue.TabIndex = 11;
            this.btnAboutReportIssue.Text = "Report an issue";
            this.btnAboutReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAboutReportIssue.Click += new System.EventHandler(this.lblAboutReportIssue_Click);
            // 
            // lblAboutSubText
            // 
            this.lblAboutSubText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAboutSubText.AutoSize = true;
            this.lblAboutSubText.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutSubText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAboutSubText.Location = new System.Drawing.Point(358, 484);
            this.lblAboutSubText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblAboutSubText.Name = "lblAboutSubText";
            this.lblAboutSubText.Size = new System.Drawing.Size(234, 20);
            this.lblAboutSubText.TabIndex = 10;
            this.lblAboutSubText.Text = "Made with ❤ by a bunch of geeks";
            this.lblAboutSubText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAboutText
            // 
            this.lblAboutText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutText.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAboutText.Location = new System.Drawing.Point(104, 178);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(743, 201);
            this.lblAboutText.TabIndex = 0;
            this.lblAboutText.Text = resources.GetString("lblAboutText.Text");
            this.lblAboutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgCloseAbout
            // 
            this.imgCloseAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgCloseAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseAbout.Image = global::OpenPlex.Properties.Resources.iconCLoseL;
            this.imgCloseAbout.Location = new System.Drawing.Point(900, 25);
            this.imgCloseAbout.Name = "imgCloseAbout";
            this.imgCloseAbout.Size = new System.Drawing.Size(24, 24);
            this.imgCloseAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCloseAbout.TabIndex = 6;
            this.imgCloseAbout.TabStop = false;
            this.imgCloseAbout.Click += new System.EventHandler(this.imgCloseAbout_Click);
            // 
            // imgHeaderAbout
            // 
            this.imgHeaderAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgHeaderAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgHeaderAbout.Image = global::OpenPlex.Properties.Resources.openplex_text;
            this.imgHeaderAbout.Location = new System.Drawing.Point(373, 21);
            this.imgHeaderAbout.Name = "imgHeaderAbout";
            this.imgHeaderAbout.Size = new System.Drawing.Size(204, 30);
            this.imgHeaderAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeaderAbout.TabIndex = 5;
            this.imgHeaderAbout.TabStop = false;
            // 
            // btnFileReportBroken
            // 
            this.btnFileReportBroken.AutoSize = true;
            this.btnFileReportBroken.BackColor = System.Drawing.Color.Transparent;
            this.btnFileReportBroken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileReportBroken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFileReportBroken.Location = new System.Drawing.Point(28, 281);
            this.btnFileReportBroken.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.btnFileReportBroken.Name = "btnFileReportBroken";
            this.btnFileReportBroken.Size = new System.Drawing.Size(82, 15);
            this.btnFileReportBroken.TabIndex = 12;
            this.btnFileReportBroken.Text = "Report broken";
            this.btnFileReportBroken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFileReportBroken.Click += new System.EventHandler(this.btnFileReportBroken_Click);
            // 
            // frmOpenPlex
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(951, 518);
            this.Controls.Add(this.tab);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOpenPlex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPlex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpenPlex_FormClosing);
            this.Load += new System.EventHandler(this.frmOpenPlex_Load);
            this.SizeChanged += new System.EventHandler(this.frmOpenPlex_SizeChanged);
            this.tab.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenPlex)).EndInit();
            this.tabSearchResults.ResumeLayout(false);
            this.panelSearchHeaders.ResumeLayout(false);
            this.panelSearchHeaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextFileName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseSearchResults)).EndInit();
            this.tabFileDetails.ResumeLayout(false);
            this.tabFileDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseFileDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFileInfoPoster)).EndInit();
            this.panelFileItems.ResumeLayout(false);
            this.panelFileItems.PerformLayout();
            this.panelFileSubItems.ResumeLayout(false);
            this.panelFileSubItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePosterBackground)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabSearchResults;
        private CButtonLib.CButton btnSearch;
        private CButtonLib.CButton bgSearchBox;
        private System.Windows.Forms.PictureBox imgOpenPlex;
        private System.Windows.Forms.PictureBox imgAbout;
        private CButtonLib.CButton btnTag1;
        private System.Windows.Forms.Label lblAddTags;
        private CButtonLib.CButton btnTag4;
        private CButtonLib.CButton btnTag3;
        private CButtonLib.CButton btnTag2;
        private CButtonLib.CButton btnTag5;
        private System.Windows.Forms.ToolStripMenuItem OpenWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private ChreneLib.Controls.TextBoxes.CTextBox txtSearchBox;
        public System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.PictureBox imgCloseAbout;
        private System.Windows.Forms.PictureBox imgHeaderAbout;
        private System.Windows.Forms.Label lblAboutText;
        private System.Windows.Forms.Label lblAboutSubText;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.Label btnAboutReportIssue;
        private System.Windows.Forms.TabPage tabFileDetails;
        private System.Windows.Forms.FlowLayoutPanel panelFileSubItems;
        private System.Windows.Forms.Label fileInfoGenre;
        private System.Windows.Forms.Label movieInfoSplitter1;
        private System.Windows.Forms.Label fileInfoIMDbRating;
        private System.Windows.Forms.Label fileInfoTitle;
        private System.Windows.Forms.PictureBox imgFileInfoPoster;
        private System.Windows.Forms.FlowLayoutPanel panelFileItems;
        private System.Windows.Forms.Label fileInfoDescription;
        private CButtonLib.CButton btnFilePlay;
        private CButtonLib.CButton btnFileDownload;
        private System.Windows.Forms.PictureBox imgCloseFileDetails;
        private System.Windows.Forms.Label fileInfoIMDbId;
        private System.Windows.Forms.PictureBox imgMoviePosterBackground;
        private System.Windows.Forms.Label fileInfoURL;
        private System.Windows.Forms.FlowLayoutPanel panelSearchHeaders;
        private System.Windows.Forms.Label lblHeaderResults;
        private System.Windows.Forms.Label lblHeaderResultsText;
        private System.Windows.Forms.Label fileInfoPopcornTrailerURL;
        private System.Windows.Forms.Label fileInfoPopcornFanartURL;
        private CButtonLib.CButton btnFileTrailer;
        private System.Windows.Forms.Label movieInfoSplitter2;
        private System.Windows.Forms.Label fileInfoRuntime;
        private System.Windows.Forms.Label movieInfoSplitter3;
        private System.Windows.Forms.Label fileInfoReleaseDate;
        private System.Windows.Forms.PictureBox imgCloseSearchResults;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
        private System.Windows.Forms.Label fileInfoSeriesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnURL;
        private System.Windows.Forms.Label btnFileReportBroken;
    }
}

