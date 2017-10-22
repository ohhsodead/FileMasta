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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.bgSearchBox = new CButtonLib.CButton();
            this.tabSearchResults = new System.Windows.Forms.TabPage();
            this.panelSearchHeaders = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeaderResults = new System.Windows.Forms.Label();
            this.lblHeaderResultsText = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMovieDetails = new System.Windows.Forms.TabPage();
            this.panelMovieItems = new System.Windows.Forms.FlowLayoutPanel();
            this.movieInfoTitle = new System.Windows.Forms.Label();
            this.panelMovieSubItems = new System.Windows.Forms.FlowLayoutPanel();
            this.movieInfoGenre = new System.Windows.Forms.Label();
            this.movieInfoSplitter1 = new System.Windows.Forms.Label();
            this.movieInfoIMDbRating = new System.Windows.Forms.Label();
            this.movieInfoSplitter2 = new System.Windows.Forms.Label();
            this.movieInfoRuntime = new System.Windows.Forms.Label();
            this.movieInfoSplitter3 = new System.Windows.Forms.Label();
            this.movieInfoReleaseDate = new System.Windows.Forms.Label();
            this.movieInfoDescription = new System.Windows.Forms.Label();
            this.btnMoviePlay = new CButtonLib.CButton();
            this.btnMovieDownload = new CButtonLib.CButton();
            this.btnMovieTrailer = new CButtonLib.CButton();
            this.movieInfoPopcornFanartURL = new System.Windows.Forms.Label();
            this.movieInfoPopcornTrailerURL = new System.Windows.Forms.Label();
            this.movieInfoIMDbId = new System.Windows.Forms.Label();
            this.movieInfoFileURL = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.lblAboutReportIssue = new System.Windows.Forms.Label();
            this.lblAboutSubText = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.imgOpenPlex = new System.Windows.Forms.PictureBox();
            this.btnSearch = new CButtonLib.CButton();
            this.imgCloseSearchResults = new System.Windows.Forms.PictureBox();
            this.imgCloseMovieDetails = new System.Windows.Forms.PictureBox();
            this.imgMovieInfoPoster = new System.Windows.Forms.PictureBox();
            this.imgMoviePosterBackground = new System.Windows.Forms.PictureBox();
            this.imgCloseAbout = new System.Windows.Forms.PictureBox();
            this.imgHeaderAbout = new System.Windows.Forms.PictureBox();
            this.tab.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabSearchResults.SuspendLayout();
            this.panelSearchHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextFileName.SuspendLayout();
            this.tabMovieDetails.SuspendLayout();
            this.panelMovieItems.SuspendLayout();
            this.panelMovieSubItems.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenPlex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseMovieDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovieInfoPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePosterBackground)).BeginInit();
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
            this.tab.Controls.Add(this.tabMovieDetails);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFileName});
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.Size = new System.Drawing.Size(951, 479);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // columnFileName
            // 
            this.columnFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFileName.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnFileName.HeaderText = "File Name";
            this.columnFileName.Name = "columnFileName";
            this.columnFileName.ReadOnly = true;
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
            // tabMovieDetails
            // 
            this.tabMovieDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabMovieDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMovieDetails.Controls.Add(this.imgCloseMovieDetails);
            this.tabMovieDetails.Controls.Add(this.imgMovieInfoPoster);
            this.tabMovieDetails.Controls.Add(this.panelMovieItems);
            this.tabMovieDetails.Controls.Add(this.imgMoviePosterBackground);
            this.tabMovieDetails.ForeColor = System.Drawing.Color.White;
            this.tabMovieDetails.Location = new System.Drawing.Point(4, 22);
            this.tabMovieDetails.Name = "tabMovieDetails";
            this.tabMovieDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMovieDetails.Size = new System.Drawing.Size(951, 518);
            this.tabMovieDetails.TabIndex = 3;
            // 
            // panelMovieItems
            // 
            this.panelMovieItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMovieItems.BackColor = System.Drawing.Color.Transparent;
            this.panelMovieItems.Controls.Add(this.movieInfoTitle);
            this.panelMovieItems.Controls.Add(this.panelMovieSubItems);
            this.panelMovieItems.Controls.Add(this.movieInfoDescription);
            this.panelMovieItems.Controls.Add(this.btnMoviePlay);
            this.panelMovieItems.Controls.Add(this.btnMovieDownload);
            this.panelMovieItems.Controls.Add(this.btnMovieTrailer);
            this.panelMovieItems.Controls.Add(this.movieInfoPopcornFanartURL);
            this.panelMovieItems.Controls.Add(this.movieInfoPopcornTrailerURL);
            this.panelMovieItems.Controls.Add(this.movieInfoIMDbId);
            this.panelMovieItems.Controls.Add(this.movieInfoFileURL);
            this.panelMovieItems.Location = new System.Drawing.Point(214, 26);
            this.panelMovieItems.Name = "panelMovieItems";
            this.panelMovieItems.Size = new System.Drawing.Size(668, 465);
            this.panelMovieItems.TabIndex = 6;
            // 
            // movieInfoTitle
            // 
            this.movieInfoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoTitle.AutoEllipsis = true;
            this.movieInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.movieInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.movieInfoTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 8);
            this.movieInfoTitle.Name = "movieInfoTitle";
            this.movieInfoTitle.Size = new System.Drawing.Size(668, 41);
            this.movieInfoTitle.TabIndex = 1;
            this.movieInfoTitle.Text = "Title";
            // 
            // panelMovieSubItems
            // 
            this.panelMovieSubItems.AutoSize = true;
            this.panelMovieSubItems.BackColor = System.Drawing.Color.Transparent;
            this.panelMovieSubItems.Controls.Add(this.movieInfoGenre);
            this.panelMovieSubItems.Controls.Add(this.movieInfoSplitter1);
            this.panelMovieSubItems.Controls.Add(this.movieInfoIMDbRating);
            this.panelMovieSubItems.Controls.Add(this.movieInfoSplitter2);
            this.panelMovieSubItems.Controls.Add(this.movieInfoRuntime);
            this.panelMovieSubItems.Controls.Add(this.movieInfoSplitter3);
            this.panelMovieSubItems.Controls.Add(this.movieInfoReleaseDate);
            this.panelMovieItems.SetFlowBreak(this.panelMovieSubItems, true);
            this.panelMovieSubItems.Location = new System.Drawing.Point(5, 49);
            this.panelMovieSubItems.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.panelMovieSubItems.Name = "panelMovieSubItems";
            this.panelMovieSubItems.Size = new System.Drawing.Size(285, 20);
            this.panelMovieSubItems.TabIndex = 2;
            this.panelMovieSubItems.WrapContents = false;
            // 
            // movieInfoGenre
            // 
            this.movieInfoGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoGenre.AutoSize = true;
            this.movieInfoGenre.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoGenre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoGenre.Location = new System.Drawing.Point(0, 0);
            this.movieInfoGenre.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoGenre.Name = "movieInfoGenre";
            this.movieInfoGenre.Size = new System.Drawing.Size(48, 20);
            this.movieInfoGenre.TabIndex = 3;
            this.movieInfoGenre.Text = "Genre";
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
            // movieInfoIMDbRating
            // 
            this.movieInfoIMDbRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoIMDbRating.AutoSize = true;
            this.movieInfoIMDbRating.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoIMDbRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoIMDbRating.Location = new System.Drawing.Point(63, 0);
            this.movieInfoIMDbRating.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoIMDbRating.Name = "movieInfoIMDbRating";
            this.movieInfoIMDbRating.Size = new System.Drawing.Size(50, 20);
            this.movieInfoIMDbRating.TabIndex = 5;
            this.movieInfoIMDbRating.Text = "0.0/10";
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
            // movieInfoRuntime
            // 
            this.movieInfoRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoRuntime.AutoSize = true;
            this.movieInfoRuntime.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoRuntime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoRuntime.Location = new System.Drawing.Point(128, 0);
            this.movieInfoRuntime.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoRuntime.Name = "movieInfoRuntime";
            this.movieInfoRuntime.Size = new System.Drawing.Size(46, 20);
            this.movieInfoRuntime.TabIndex = 11;
            this.movieInfoRuntime.Text = "0 min";
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
            // movieInfoReleaseDate
            // 
            this.movieInfoReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoReleaseDate.AutoSize = true;
            this.movieInfoReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoReleaseDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoReleaseDate.Location = new System.Drawing.Point(189, 0);
            this.movieInfoReleaseDate.Margin = new System.Windows.Forms.Padding(0);
            this.movieInfoReleaseDate.Name = "movieInfoReleaseDate";
            this.movieInfoReleaseDate.Size = new System.Drawing.Size(96, 20);
            this.movieInfoReleaseDate.TabIndex = 13;
            this.movieInfoReleaseDate.Text = "Release Date";
            // 
            // movieInfoDescription
            // 
            this.movieInfoDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoDescription.AutoSize = true;
            this.movieInfoDescription.BackColor = System.Drawing.Color.Transparent;
            this.panelMovieItems.SetFlowBreak(this.movieInfoDescription, true);
            this.movieInfoDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movieInfoDescription.Location = new System.Drawing.Point(5, 88);
            this.movieInfoDescription.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.movieInfoDescription.Name = "movieInfoDescription";
            this.movieInfoDescription.Size = new System.Drawing.Size(33, 19);
            this.movieInfoDescription.TabIndex = 3;
            this.movieInfoDescription.Text = "Plot";
            // 
            // btnMoviePlay
            // 
            this.btnMoviePlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnMoviePlay.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnMoviePlay.ContextMenuStrip = this.contextFileName;
            this.btnMoviePlay.Corners.All = 2;
            this.btnMoviePlay.Corners.LowerLeft = 2;
            this.btnMoviePlay.Corners.LowerRight = 2;
            this.btnMoviePlay.Corners.UpperLeft = 2;
            this.btnMoviePlay.Corners.UpperRight = 2;
            this.btnMoviePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoviePlay.DesignerSelected = false;
            this.btnMoviePlay.DimFactorClick = 0;
            this.btnMoviePlay.DimFactorHover = 0;
            this.btnMoviePlay.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnMoviePlay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMoviePlay.ImageIndex = 0;
            this.btnMoviePlay.Location = new System.Drawing.Point(9, 127);
            this.btnMoviePlay.Margin = new System.Windows.Forms.Padding(9, 0, 3, 3);
            this.btnMoviePlay.Name = "btnMoviePlay";
            this.btnMoviePlay.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnMoviePlay.Size = new System.Drawing.Size(44, 25);
            this.btnMoviePlay.TabIndex = 4;
            this.btnMoviePlay.Text = "Play";
            this.btnMoviePlay.TextShadowShow = false;
            this.btnMoviePlay.Click += new System.EventHandler(this.btnMoviePlay_Click);
            // 
            // btnMovieDownload
            // 
            this.btnMovieDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnMovieDownload.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnMovieDownload.Corners.All = 2;
            this.btnMovieDownload.Corners.LowerLeft = 2;
            this.btnMovieDownload.Corners.LowerRight = 2;
            this.btnMovieDownload.Corners.UpperLeft = 2;
            this.btnMovieDownload.Corners.UpperRight = 2;
            this.btnMovieDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieDownload.DesignerSelected = false;
            this.btnMovieDownload.DimFactorClick = 0;
            this.btnMovieDownload.DimFactorHover = 0;
            this.btnMovieDownload.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnMovieDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMovieDownload.ImageIndex = 0;
            this.btnMovieDownload.Location = new System.Drawing.Point(59, 127);
            this.btnMovieDownload.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnMovieDownload.Name = "btnMovieDownload";
            this.btnMovieDownload.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnMovieDownload.Size = new System.Drawing.Size(80, 25);
            this.btnMovieDownload.TabIndex = 5;
            this.btnMovieDownload.Text = "Download";
            this.btnMovieDownload.TextShadowShow = false;
            this.btnMovieDownload.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnMovieDownload_ClickButtonArea);
            // 
            // btnMovieTrailer
            // 
            this.btnMovieTrailer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnMovieTrailer.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnMovieTrailer.Corners.All = 2;
            this.btnMovieTrailer.Corners.LowerLeft = 2;
            this.btnMovieTrailer.Corners.LowerRight = 2;
            this.btnMovieTrailer.Corners.UpperLeft = 2;
            this.btnMovieTrailer.Corners.UpperRight = 2;
            this.btnMovieTrailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieTrailer.DesignerSelected = false;
            this.btnMovieTrailer.DimFactorClick = 0;
            this.btnMovieTrailer.DimFactorHover = 0;
            this.btnMovieTrailer.FillType = CButtonLib.CButton.eFillType.Solid;
            this.panelMovieItems.SetFlowBreak(this.btnMovieTrailer, true);
            this.btnMovieTrailer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMovieTrailer.ImageIndex = 0;
            this.btnMovieTrailer.Location = new System.Drawing.Point(145, 127);
            this.btnMovieTrailer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnMovieTrailer.Name = "btnMovieTrailer";
            this.btnMovieTrailer.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnMovieTrailer.Size = new System.Drawing.Size(58, 25);
            this.btnMovieTrailer.TabIndex = 9;
            this.btnMovieTrailer.Text = "Trailer";
            this.btnMovieTrailer.TextShadowShow = false;
            this.btnMovieTrailer.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnMovieTrailer_ClickButtonArea);
            // 
            // movieInfoPopcornFanartURL
            // 
            this.movieInfoPopcornFanartURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoPopcornFanartURL.AutoSize = true;
            this.movieInfoPopcornFanartURL.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoPopcornFanartURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movieInfoPopcornFanartURL.Location = new System.Drawing.Point(5, 155);
            this.movieInfoPopcornFanartURL.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.movieInfoPopcornFanartURL.Name = "movieInfoPopcornFanartURL";
            this.movieInfoPopcornFanartURL.Size = new System.Drawing.Size(77, 19);
            this.movieInfoPopcornFanartURL.TabIndex = 8;
            this.movieInfoPopcornFanartURL.Text = "Fanart URL";
            this.movieInfoPopcornFanartURL.Visible = false;
            // 
            // movieInfoPopcornTrailerURL
            // 
            this.movieInfoPopcornTrailerURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoPopcornTrailerURL.AutoSize = true;
            this.movieInfoPopcornTrailerURL.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoPopcornTrailerURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movieInfoPopcornTrailerURL.Location = new System.Drawing.Point(87, 155);
            this.movieInfoPopcornTrailerURL.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.movieInfoPopcornTrailerURL.Name = "movieInfoPopcornTrailerURL";
            this.movieInfoPopcornTrailerURL.Size = new System.Drawing.Size(74, 19);
            this.movieInfoPopcornTrailerURL.TabIndex = 7;
            this.movieInfoPopcornTrailerURL.Text = "Trailer URL";
            this.movieInfoPopcornTrailerURL.Visible = false;
            // 
            // movieInfoIMDbId
            // 
            this.movieInfoIMDbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoIMDbId.AutoSize = true;
            this.movieInfoIMDbId.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoIMDbId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.movieInfoIMDbId.Location = new System.Drawing.Point(166, 155);
            this.movieInfoIMDbId.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.movieInfoIMDbId.Name = "movieInfoIMDbId";
            this.movieInfoIMDbId.Size = new System.Drawing.Size(65, 20);
            this.movieInfoIMDbId.TabIndex = 6;
            this.movieInfoIMDbId.Text = "IMDb ID";
            this.movieInfoIMDbId.Visible = false;
            // 
            // movieInfoFileURL
            // 
            this.movieInfoFileURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieInfoFileURL.AutoSize = true;
            this.movieInfoFileURL.BackColor = System.Drawing.Color.Transparent;
            this.movieInfoFileURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movieInfoFileURL.Location = new System.Drawing.Point(236, 155);
            this.movieInfoFileURL.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.movieInfoFileURL.Name = "movieInfoFileURL";
            this.movieInfoFileURL.Size = new System.Drawing.Size(58, 19);
            this.movieInfoFileURL.TabIndex = 6;
            this.movieInfoFileURL.Text = "File URL";
            this.movieInfoFileURL.Visible = false;
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAbout.Controls.Add(this.lblAboutVersion);
            this.tabAbout.Controls.Add(this.lblAboutReportIssue);
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
            // lblAboutReportIssue
            // 
            this.lblAboutReportIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAboutReportIssue.AutoSize = true;
            this.lblAboutReportIssue.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutReportIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutReportIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAboutReportIssue.Location = new System.Drawing.Point(6, 496);
            this.lblAboutReportIssue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblAboutReportIssue.Name = "lblAboutReportIssue";
            this.lblAboutReportIssue.Size = new System.Drawing.Size(87, 15);
            this.lblAboutReportIssue.TabIndex = 11;
            this.lblAboutReportIssue.Text = "Report an issue";
            this.lblAboutReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutReportIssue.Click += new System.EventHandler(this.lblAboutReportIssue_Click);
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
            // imgCloseMovieDetails
            // 
            this.imgCloseMovieDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseMovieDetails.BackColor = System.Drawing.Color.Transparent;
            this.imgCloseMovieDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseMovieDetails.Image = global::OpenPlex.Properties.Resources.iconCLoseL;
            this.imgCloseMovieDetails.Location = new System.Drawing.Point(900, 25);
            this.imgCloseMovieDetails.Name = "imgCloseMovieDetails";
            this.imgCloseMovieDetails.Size = new System.Drawing.Size(24, 24);
            this.imgCloseMovieDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCloseMovieDetails.TabIndex = 7;
            this.imgCloseMovieDetails.TabStop = false;
            this.imgCloseMovieDetails.Click += new System.EventHandler(this.imgCloseMovieDetails_Click);
            // 
            // imgMovieInfoPoster
            // 
            this.imgMovieInfoPoster.BackColor = System.Drawing.Color.Transparent;
            this.imgMovieInfoPoster.Location = new System.Drawing.Point(31, 26);
            this.imgMovieInfoPoster.Name = "imgMovieInfoPoster";
            this.imgMovieInfoPoster.Size = new System.Drawing.Size(162, 246);
            this.imgMovieInfoPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMovieInfoPoster.TabIndex = 0;
            this.imgMovieInfoPoster.TabStop = false;
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
            this.tabSearchResults.ResumeLayout(false);
            this.panelSearchHeaders.ResumeLayout(false);
            this.panelSearchHeaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextFileName.ResumeLayout(false);
            this.tabMovieDetails.ResumeLayout(false);
            this.panelMovieItems.ResumeLayout(false);
            this.panelMovieItems.PerformLayout();
            this.panelMovieSubItems.ResumeLayout(false);
            this.panelMovieSubItems.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenPlex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseMovieDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovieInfoPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePosterBackground)).EndInit();
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
        private System.Windows.Forms.Label lblAboutReportIssue;
        private System.Windows.Forms.TabPage tabMovieDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFileName;
        private System.Windows.Forms.FlowLayoutPanel panelMovieSubItems;
        private System.Windows.Forms.Label movieInfoGenre;
        private System.Windows.Forms.Label movieInfoSplitter1;
        private System.Windows.Forms.Label movieInfoIMDbRating;
        private System.Windows.Forms.Label movieInfoTitle;
        private System.Windows.Forms.PictureBox imgMovieInfoPoster;
        private System.Windows.Forms.FlowLayoutPanel panelMovieItems;
        private System.Windows.Forms.Label movieInfoDescription;
        private CButtonLib.CButton btnMoviePlay;
        private CButtonLib.CButton btnMovieDownload;
        private System.Windows.Forms.PictureBox imgCloseMovieDetails;
        private System.Windows.Forms.Label movieInfoIMDbId;
        private System.Windows.Forms.PictureBox imgMoviePosterBackground;
        private System.Windows.Forms.Label movieInfoFileURL;
        private System.Windows.Forms.FlowLayoutPanel panelSearchHeaders;
        private System.Windows.Forms.Label lblHeaderResults;
        private System.Windows.Forms.Label lblHeaderResultsText;
        private System.Windows.Forms.Label movieInfoPopcornTrailerURL;
        private System.Windows.Forms.Label movieInfoPopcornFanartURL;
        private CButtonLib.CButton btnMovieTrailer;
        private System.Windows.Forms.Label movieInfoSplitter2;
        private System.Windows.Forms.Label movieInfoRuntime;
        private System.Windows.Forms.Label movieInfoSplitter3;
        private System.Windows.Forms.Label movieInfoReleaseDate;
        private System.Windows.Forms.PictureBox imgCloseSearchResults;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
    }
}

