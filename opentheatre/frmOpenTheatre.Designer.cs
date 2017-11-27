namespace OpenTheatre
{
    partial class frmOpenTheatre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenTheatre));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.panelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMoviesSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgMoviesSearchBox = new CButtonLib.CButton();
            this.panelMovieFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMoviesGenre = new System.Windows.Forms.Panel();
            this.cmboBoxMoviesGenre = new System.Windows.Forms.ComboBox();
            this.panelMoviesYear = new System.Windows.Forms.Panel();
            this.cmboBoxMoviesYear = new System.Windows.Forms.ComboBox();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.panelFileFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilesSort = new System.Windows.Forms.Panel();
            this.cmboBoxFilesSort = new System.Windows.Forms.ComboBox();
            this.panelFilesFormat = new System.Windows.Forms.Panel();
            this.cmboBoxFilesFormat = new System.Windows.Forms.ComboBox();
            this.panelFilesHost = new System.Windows.Forms.Panel();
            this.cmboBoxFilesHost = new System.Windows.Forms.ComboBox();
            this.panelFilesQuality = new System.Windows.Forms.Panel();
            this.cmboBoxFilesQuality = new System.Windows.Forms.ComboBox();
            this.titleFilesSplitter = new CButtonLib.CButton();
            this.txtFilesSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.columnFilesFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleFilesMovies = new CButtonLib.CButton();
            this.titleFilesAnime = new CButtonLib.CButton();
            this.titleFilesSeries = new CButtonLib.CButton();
            this.titleFilesSubtitles = new CButtonLib.CButton();
            this.titleFilesTorrents = new CButtonLib.CButton();
            this.titleFilesArchives = new CButtonLib.CButton();
            this.bgFilesSearchBox = new CButtonLib.CButton();
            this.tabBookmarks = new System.Windows.Forms.TabPage();
            this.panelBookmarksFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBookmarksSort = new System.Windows.Forms.Panel();
            this.cmboBoxBookmarksSort = new System.Windows.Forms.ComboBox();
            this.panelBookmarksType = new System.Windows.Forms.Panel();
            this.cmboBoxBookmarksType = new System.Windows.Forms.ComboBox();
            this.txtBookmarksSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dataGridBookmarks = new System.Windows.Forms.DataGridView();
            this.columnBookmarksType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookmarksFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookmarksFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookmarksHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookmarksURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgBookmarksSearchBox = new CButtonLib.CButton();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabDownloads = new System.Windows.Forms.TabPage();
            this.lblNoDownloads = new System.Windows.Forms.Label();
            this.panelDownloads = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBlank = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSettingsDownloadsDirectory = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgSettingsDownloadsDirectory = new CButtonLib.CButton();
            this.lblSettingsDownloadsDirectory = new System.Windows.Forms.Label();
            this.lblSettingsConnectionCustom = new System.Windows.Forms.Label();
            this.chkSettingsCustomConnection = new System.Windows.Forms.CheckBox();
            this.btnSettingsSave = new CButtonLib.CButton();
            this.btnSettingsRestoreDefault = new CButtonLib.CButton();
            this.titleSettingsGeneral = new System.Windows.Forms.Label();
            this.lblSettingsGeneralClearDataOnClose = new System.Windows.Forms.Label();
            this.chkSettingsClearData = new System.Windows.Forms.CheckBox();
            this.txtBoxSettingsConnectionPassword = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgSettingsConnectionPassword = new CButtonLib.CButton();
            this.lblSettingsConnectionPassword = new System.Windows.Forms.Label();
            this.txtBoxSettingsConnectionUsername = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgSettingsConnectionUsername = new CButtonLib.CButton();
            this.lblSettingsConnectionUsername = new System.Windows.Forms.Label();
            this.txtBoxSettingsConnectionPort = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgSettingsConnectionPort = new CButtonLib.CButton();
            this.lblSettingsConnectionPort = new System.Windows.Forms.Label();
            this.txtBoxSettingsConnectionHost = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgSettingsConnectionHost = new CButtonLib.CButton();
            this.lblSettingsConnectionHost = new System.Windows.Forms.Label();
            this.titleSettingsConnection = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.btnAboutReportIssue = new System.Windows.Forms.Label();
            this.lblAboutSubText = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.panelTitles = new System.Windows.Forms.Panel();
            this.titleLineSettings = new CButtonLib.CButton();
            this.titleSettings = new System.Windows.Forms.Label();
            this.titleLineBookmarks = new CButtonLib.CButton();
            this.titleBookmarks = new System.Windows.Forms.Label();
            this.titleLineDownloads = new CButtonLib.CButton();
            this.titleDownloads = new System.Windows.Forms.Label();
            this.titleLineAbout = new CButtonLib.CButton();
            this.titleAbout = new System.Windows.Forms.Label();
            this.titleLineFiles = new CButtonLib.CButton();
            this.titleLineMovies = new CButtonLib.CButton();
            this.titleFiles = new System.Windows.Forms.Label();
            this.titleMovies = new System.Windows.Forms.Label();
            this.imgSettings = new System.Windows.Forms.PictureBox();
            this.imgBookmarks = new System.Windows.Forms.PictureBox();
            this.imgDownloads = new System.Windows.Forms.PictureBox();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.imgFiles = new System.Windows.Forms.PictureBox();
            this.imgMovies = new System.Windows.Forms.PictureBox();
            this.imgSpinnerGIF = new System.Windows.Forms.PictureBox();
            this.btnSearchMovies = new CButtonLib.CButton();
            this.btnMoviesGenre = new CButtonLib.CButton();
            this.btnMoviesYear = new CButtonLib.CButton();
            this.btnFilesSort = new CButtonLib.CButton();
            this.btnFilesFormat = new CButtonLib.CButton();
            this.btnFilesHost = new CButtonLib.CButton();
            this.btnFilesQuality = new CButtonLib.CButton();
            this.btnSearchFiles = new CButtonLib.CButton();
            this.btnBookmarksSort = new CButtonLib.CButton();
            this.btnBookmarksType = new CButtonLib.CButton();
            this.btnSearchBookmarks = new CButtonLib.CButton();
            this.imgSettingsDownloadsDirectory = new System.Windows.Forms.PictureBox();
            this.imgCloseAbout = new System.Windows.Forms.PictureBox();
            this.imgHeaderAbout = new System.Windows.Forms.PictureBox();
            this.tab.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.panelMovieFilters.SuspendLayout();
            this.panelMoviesGenre.SuspendLayout();
            this.panelMoviesYear.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.panelFileFilters.SuspendLayout();
            this.panelFilesSort.SuspendLayout();
            this.panelFilesFormat.SuspendLayout();
            this.panelFilesHost.SuspendLayout();
            this.panelFilesQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.tabBookmarks.SuspendLayout();
            this.panelBookmarksFilters.SuspendLayout();
            this.panelBookmarksSort.SuspendLayout();
            this.panelBookmarksType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookmarks)).BeginInit();
            this.tabDownloads.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.panelTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBookmarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinnerGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettingsDownloadsDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabMovies);
            this.tab.Controls.Add(this.tabFiles);
            this.tab.Controls.Add(this.tabBookmarks);
            this.tab.Controls.Add(this.tabHistory);
            this.tab.Controls.Add(this.tabDownloads);
            this.tab.Controls.Add(this.tabBlank);
            this.tab.Controls.Add(this.tabSettings);
            this.tab.Controls.Add(this.tabAbout);
            this.tab.Location = new System.Drawing.Point(176, -22);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(876, 544);
            this.tab.TabIndex = 0;
            this.tab.TabStop = false;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabMovies
            // 
            this.tabMovies.AllowDrop = true;
            this.tabMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMovies.Controls.Add(this.imgSpinnerGIF);
            this.tabMovies.Controls.Add(this.panelMovies);
            this.tabMovies.Controls.Add(this.txtMoviesSearchBox);
            this.tabMovies.Controls.Add(this.btnSearchMovies);
            this.tabMovies.Controls.Add(this.bgMoviesSearchBox);
            this.tabMovies.Controls.Add(this.panelMovieFilters);
            this.tabMovies.ForeColor = System.Drawing.Color.White;
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(868, 518);
            this.tabMovies.TabIndex = 0;
            // 
            // panelMovies
            // 
            this.panelMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMovies.AutoScroll = true;
            this.panelMovies.BackColor = System.Drawing.Color.Transparent;
            this.panelMovies.Location = new System.Drawing.Point(0, 63);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelMovies.Size = new System.Drawing.Size(868, 455);
            this.panelMovies.TabIndex = 4;
            this.panelMovies.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelMovies_Scroll);
            // 
            // txtMoviesSearchBox
            // 
            this.txtMoviesSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.txtMoviesSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoviesSearchBox.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtMoviesSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtMoviesSearchBox.Location = new System.Drawing.Point(22, 21);
            this.txtMoviesSearchBox.Name = "txtMoviesSearchBox";
            this.txtMoviesSearchBox.Size = new System.Drawing.Size(348, 20);
            this.txtMoviesSearchBox.TabIndex = 0;
            this.txtMoviesSearchBox.WaterMark = "Search movies, people or imdb id...";
            this.txtMoviesSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.txtMoviesSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtMoviesSearchBox.WaterMarkForeColor = System.Drawing.Color.Silver;
            this.txtMoviesSearchBox.Enter += new System.EventHandler(this.txtMoviesSearchBox_Enter);
            this.txtMoviesSearchBox.Leave += new System.EventHandler(this.txtMoviesSearchBox_Leave);
            // 
            // bgMoviesSearchBox
            // 
            this.bgMoviesSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgMoviesSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.bgMoviesSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.bgMoviesSearchBox.Corners.All = 2;
            this.bgMoviesSearchBox.Corners.LowerLeft = 2;
            this.bgMoviesSearchBox.Corners.LowerRight = 2;
            this.bgMoviesSearchBox.Corners.UpperLeft = 2;
            this.bgMoviesSearchBox.Corners.UpperRight = 2;
            this.bgMoviesSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgMoviesSearchBox.DesignerSelected = false;
            this.bgMoviesSearchBox.DimFactorClick = 0;
            this.bgMoviesSearchBox.DimFactorHover = 0;
            this.bgMoviesSearchBox.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgMoviesSearchBox.ImageIndex = 0;
            this.bgMoviesSearchBox.Location = new System.Drawing.Point(13, 13);
            this.bgMoviesSearchBox.Name = "bgMoviesSearchBox";
            this.bgMoviesSearchBox.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgMoviesSearchBox.Size = new System.Drawing.Size(399, 36);
            this.bgMoviesSearchBox.TabIndex = 0;
            this.bgMoviesSearchBox.TabStop = false;
            this.bgMoviesSearchBox.Text = "";
            this.bgMoviesSearchBox.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.bgMoviesSearchBox_ClickButtonArea);
            // 
            // panelMovieFilters
            // 
            this.panelMovieFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMovieFilters.Controls.Add(this.panelMoviesGenre);
            this.panelMovieFilters.Controls.Add(this.panelMoviesYear);
            this.panelMovieFilters.Location = new System.Drawing.Point(419, 13);
            this.panelMovieFilters.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.panelMovieFilters.Name = "panelMovieFilters";
            this.panelMovieFilters.Size = new System.Drawing.Size(437, 36);
            this.panelMovieFilters.TabIndex = 2;
            // 
            // panelMoviesGenre
            // 
            this.panelMoviesGenre.Controls.Add(this.btnMoviesGenre);
            this.panelMoviesGenre.Controls.Add(this.cmboBoxMoviesGenre);
            this.panelMoviesGenre.Location = new System.Drawing.Point(0, 0);
            this.panelMoviesGenre.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelMoviesGenre.Name = "panelMoviesGenre";
            this.panelMoviesGenre.Size = new System.Drawing.Size(109, 36);
            this.panelMoviesGenre.TabIndex = 0;
            // 
            // cmboBoxMoviesGenre
            // 
            this.cmboBoxMoviesGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxMoviesGenre.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxMoviesGenre.FormattingEnabled = true;
            this.cmboBoxMoviesGenre.Items.AddRange(new object[] {
            "Any",
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Documentary",
            "Drama",
            "Family",
            "Fantasy",
            "History",
            "Horror",
            "Music",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "War",
            "Western"});
            this.cmboBoxMoviesGenre.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxMoviesGenre.Name = "cmboBoxMoviesGenre";
            this.cmboBoxMoviesGenre.Size = new System.Drawing.Size(109, 27);
            this.cmboBoxMoviesGenre.TabIndex = 0;
            this.cmboBoxMoviesGenre.TabStop = false;
            this.cmboBoxMoviesGenre.SelectedIndexChanged += new System.EventHandler(this.cmboBoxMoviesGenre_SelectedIndexChanged);
            // 
            // panelMoviesYear
            // 
            this.panelMoviesYear.Controls.Add(this.btnMoviesYear);
            this.panelMoviesYear.Controls.Add(this.cmboBoxMoviesYear);
            this.panelMoviesYear.Location = new System.Drawing.Point(116, 0);
            this.panelMoviesYear.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelMoviesYear.Name = "panelMoviesYear";
            this.panelMoviesYear.Size = new System.Drawing.Size(98, 36);
            this.panelMoviesYear.TabIndex = 3;
            // 
            // cmboBoxMoviesYear
            // 
            this.cmboBoxMoviesYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxMoviesYear.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxMoviesYear.FormattingEnabled = true;
            this.cmboBoxMoviesYear.Items.AddRange(new object[] {
            "Any",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991"});
            this.cmboBoxMoviesYear.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxMoviesYear.Name = "cmboBoxMoviesYear";
            this.cmboBoxMoviesYear.Size = new System.Drawing.Size(98, 27);
            this.cmboBoxMoviesYear.TabIndex = 0;
            this.cmboBoxMoviesYear.TabStop = false;
            this.cmboBoxMoviesYear.SelectedIndexChanged += new System.EventHandler(this.cmboBoxMoviesYear_SelectedIndexChanged);
            // 
            // tabFiles
            // 
            this.tabFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabFiles.Controls.Add(this.panelFileFilters);
            this.tabFiles.Controls.Add(this.titleFilesSplitter);
            this.tabFiles.Controls.Add(this.txtFilesSearchBox);
            this.tabFiles.Controls.Add(this.dataGridFiles);
            this.tabFiles.Controls.Add(this.titleFilesMovies);
            this.tabFiles.Controls.Add(this.titleFilesAnime);
            this.tabFiles.Controls.Add(this.titleFilesSeries);
            this.tabFiles.Controls.Add(this.titleFilesSubtitles);
            this.tabFiles.Controls.Add(this.titleFilesTorrents);
            this.tabFiles.Controls.Add(this.titleFilesArchives);
            this.tabFiles.Controls.Add(this.btnSearchFiles);
            this.tabFiles.Controls.Add(this.bgFilesSearchBox);
            this.tabFiles.ForeColor = System.Drawing.Color.White;
            this.tabFiles.Location = new System.Drawing.Point(4, 22);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabFiles.Size = new System.Drawing.Size(868, 518);
            this.tabFiles.TabIndex = 1;
            // 
            // panelFileFilters
            // 
            this.panelFileFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFileFilters.Controls.Add(this.panelFilesSort);
            this.panelFileFilters.Controls.Add(this.panelFilesFormat);
            this.panelFileFilters.Controls.Add(this.panelFilesHost);
            this.panelFileFilters.Controls.Add(this.panelFilesQuality);
            this.panelFileFilters.Location = new System.Drawing.Point(419, 13);
            this.panelFileFilters.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.panelFileFilters.Name = "panelFileFilters";
            this.panelFileFilters.Size = new System.Drawing.Size(437, 36);
            this.panelFileFilters.TabIndex = 9;
            // 
            // panelFilesSort
            // 
            this.panelFilesSort.Controls.Add(this.btnFilesSort);
            this.panelFilesSort.Controls.Add(this.cmboBoxFilesSort);
            this.panelFilesSort.Location = new System.Drawing.Point(0, 0);
            this.panelFilesSort.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelFilesSort.Name = "panelFilesSort";
            this.panelFilesSort.Size = new System.Drawing.Size(95, 36);
            this.panelFilesSort.TabIndex = 6;
            // 
            // cmboBoxFilesSort
            // 
            this.cmboBoxFilesSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxFilesSort.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxFilesSort.FormattingEnabled = true;
            this.cmboBoxFilesSort.Items.AddRange(new object[] {
            "Any",
            "A-Z",
            "Z-A"});
            this.cmboBoxFilesSort.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxFilesSort.Name = "cmboBoxFilesSort";
            this.cmboBoxFilesSort.Size = new System.Drawing.Size(95, 27);
            this.cmboBoxFilesSort.TabIndex = 0;
            this.cmboBoxFilesSort.TabStop = false;
            this.cmboBoxFilesSort.SelectedIndexChanged += new System.EventHandler(this.cmboBoxFilesSort_SelectedIndexChanged);
            // 
            // panelFilesFormat
            // 
            this.panelFilesFormat.Controls.Add(this.btnFilesFormat);
            this.panelFilesFormat.Controls.Add(this.cmboBoxFilesFormat);
            this.panelFilesFormat.Location = new System.Drawing.Point(102, 0);
            this.panelFilesFormat.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelFilesFormat.Name = "panelFilesFormat";
            this.panelFilesFormat.Size = new System.Drawing.Size(115, 36);
            this.panelFilesFormat.TabIndex = 0;
            // 
            // cmboBoxFilesFormat
            // 
            this.cmboBoxFilesFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxFilesFormat.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxFilesFormat.FormattingEnabled = true;
            this.cmboBoxFilesFormat.Items.AddRange(new object[] {
            "Any",
            "MKV",
            "MP4",
            "AVI",
            "MPEG"});
            this.cmboBoxFilesFormat.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxFilesFormat.Name = "cmboBoxFilesFormat";
            this.cmboBoxFilesFormat.Size = new System.Drawing.Size(115, 27);
            this.cmboBoxFilesFormat.TabIndex = 0;
            this.cmboBoxFilesFormat.TabStop = false;
            this.cmboBoxFilesFormat.SelectedIndexChanged += new System.EventHandler(this.cmboBoxFilesFileFormat_SelectedIndexChanged);
            // 
            // panelFilesHost
            // 
            this.panelFilesHost.Controls.Add(this.btnFilesHost);
            this.panelFilesHost.Controls.Add(this.cmboBoxFilesHost);
            this.panelFilesHost.Location = new System.Drawing.Point(224, 0);
            this.panelFilesHost.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelFilesHost.Name = "panelFilesHost";
            this.panelFilesHost.Size = new System.Drawing.Size(100, 36);
            this.panelFilesHost.TabIndex = 3;
            // 
            // cmboBoxFilesHost
            // 
            this.cmboBoxFilesHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxFilesHost.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxFilesHost.FormattingEnabled = true;
            this.cmboBoxFilesHost.Items.AddRange(new object[] {
            "Any"});
            this.cmboBoxFilesHost.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxFilesHost.Name = "cmboBoxFilesHost";
            this.cmboBoxFilesHost.Size = new System.Drawing.Size(100, 27);
            this.cmboBoxFilesHost.TabIndex = 0;
            this.cmboBoxFilesHost.TabStop = false;
            this.cmboBoxFilesHost.SelectedIndexChanged += new System.EventHandler(this.cmboBoxFilesHost_SelectedIndexChanged);
            // 
            // panelFilesQuality
            // 
            this.panelFilesQuality.Controls.Add(this.btnFilesQuality);
            this.panelFilesQuality.Controls.Add(this.cmboBoxFilesQuality);
            this.panelFilesQuality.Location = new System.Drawing.Point(0, 36);
            this.panelFilesQuality.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelFilesQuality.Name = "panelFilesQuality";
            this.panelFilesQuality.Size = new System.Drawing.Size(115, 36);
            this.panelFilesQuality.TabIndex = 4;
            // 
            // cmboBoxFilesQuality
            // 
            this.cmboBoxFilesQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxFilesQuality.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxFilesQuality.FormattingEnabled = true;
            this.cmboBoxFilesQuality.Items.AddRange(new object[] {
            "Any",
            "SD",
            "480p",
            "720p",
            "1080p"});
            this.cmboBoxFilesQuality.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxFilesQuality.Name = "cmboBoxFilesQuality";
            this.cmboBoxFilesQuality.Size = new System.Drawing.Size(115, 27);
            this.cmboBoxFilesQuality.TabIndex = 0;
            this.cmboBoxFilesQuality.TabStop = false;
            this.cmboBoxFilesQuality.SelectedIndexChanged += new System.EventHandler(this.cmboBoxFilesQuality_SelectedIndexChanged);
            // 
            // titleFilesSplitter
            // 
            this.titleFilesSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleFilesSplitter.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesSplitter.BorderColor = System.Drawing.Color.Silver;
            this.titleFilesSplitter.ColorFillSolid = System.Drawing.Color.Silver;
            this.titleFilesSplitter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleFilesSplitter.DesignerSelected = false;
            this.titleFilesSplitter.DimFactorClick = 0;
            this.titleFilesSplitter.DimFactorHover = 0;
            this.titleFilesSplitter.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesSplitter.ImageIndex = 0;
            this.titleFilesSplitter.Location = new System.Drawing.Point(13, 89);
            this.titleFilesSplitter.Name = "titleFilesSplitter";
            this.titleFilesSplitter.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleFilesSplitter.Size = new System.Drawing.Size(842, 1);
            this.titleFilesSplitter.TabIndex = 4;
            this.titleFilesSplitter.TabStop = false;
            this.titleFilesSplitter.Text = "";
            // 
            // txtFilesSearchBox
            // 
            this.txtFilesSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.txtFilesSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilesSearchBox.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtFilesSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtFilesSearchBox.Location = new System.Drawing.Point(22, 21);
            this.txtFilesSearchBox.Name = "txtFilesSearchBox";
            this.txtFilesSearchBox.Size = new System.Drawing.Size(348, 20);
            this.txtFilesSearchBox.TabIndex = 0;
            this.txtFilesSearchBox.WaterMark = "Search file names, add some tags, insert a link...";
            this.txtFilesSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.txtFilesSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtFilesSearchBox.WaterMarkForeColor = System.Drawing.Color.Silver;
            this.txtFilesSearchBox.Enter += new System.EventHandler(this.txtFilesSearchBox_Enter);
            this.txtFilesSearchBox.Leave += new System.EventHandler(this.txtFilesSearchBox_Leave);
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.AllowUserToAddRows = false;
            this.dataGridFiles.AllowUserToDeleteRows = false;
            this.dataGridFiles.AllowUserToResizeColumns = false;
            this.dataGridFiles.AllowUserToResizeRows = false;
            this.dataGridFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFilesFileName,
            this.columnFilesFormat,
            this.columnFilesHost,
            this.columnFilesURL});
            this.dataGridFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridFiles.EnableHeadersVisualStyles = false;
            this.dataGridFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridFiles.Location = new System.Drawing.Point(0, 97);
            this.dataGridFiles.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGridFiles.MultiSelect = false;
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            this.dataGridFiles.RowHeadersVisible = false;
            this.dataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowTemplate.Height = 30;
            this.dataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFiles.ShowEditingIcon = false;
            this.dataGridFiles.Size = new System.Drawing.Size(868, 421);
            this.dataGridFiles.TabIndex = 2;
            this.dataGridFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFiles_CellContentClick);
            this.dataGridFiles.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridFiles_RowPrePaint);
            // 
            // columnFilesFileName
            // 
            this.columnFilesFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesFileName.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnFilesFileName.HeaderText = "File Name";
            this.columnFilesFileName.Name = "columnFilesFileName";
            this.columnFilesFileName.ReadOnly = true;
            // 
            // columnFilesFormat
            // 
            this.columnFilesFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnFilesFormat.HeaderText = "Format";
            this.columnFilesFormat.Name = "columnFilesFormat";
            this.columnFilesFormat.ReadOnly = true;
            this.columnFilesFormat.Width = 76;
            // 
            // columnFilesHost
            // 
            this.columnFilesHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesHost.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnFilesHost.HeaderText = "Host";
            this.columnFilesHost.Name = "columnFilesHost";
            this.columnFilesHost.ReadOnly = true;
            this.columnFilesHost.Width = 64;
            // 
            // columnFilesURL
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesURL.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnFilesURL.HeaderText = "URL";
            this.columnFilesURL.Name = "columnFilesURL";
            this.columnFilesURL.ReadOnly = true;
            this.columnFilesURL.Visible = false;
            this.columnFilesURL.Width = 851;
            // 
            // titleFilesMovies
            // 
            this.titleFilesMovies.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesMovies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.titleFilesMovies.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.titleFilesMovies.Corners.UpperLeft = 2;
            this.titleFilesMovies.Corners.UpperRight = 2;
            this.titleFilesMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFilesMovies.DesignerSelected = false;
            this.titleFilesMovies.DimFactorClick = 0;
            this.titleFilesMovies.DimFactorHover = 0;
            this.titleFilesMovies.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesMovies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFilesMovies.ImageIndex = 0;
            this.titleFilesMovies.Location = new System.Drawing.Point(13, 63);
            this.titleFilesMovies.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.titleFilesMovies.Name = "titleFilesMovies";
            this.titleFilesMovies.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.titleFilesMovies.Size = new System.Drawing.Size(68, 27);
            this.titleFilesMovies.TabIndex = 3;
            this.titleFilesMovies.TabStop = false;
            this.titleFilesMovies.Text = "Movies";
            this.titleFilesMovies.TextShadowShow = false;
            this.titleFilesMovies.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleFilesMovies_ClickButtonArea);
            // 
            // titleFilesAnime
            // 
            this.titleFilesAnime.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesAnime.BorderColor = System.Drawing.Color.Transparent;
            this.titleFilesAnime.ColorFillSolid = System.Drawing.Color.Transparent;
            this.titleFilesAnime.Corners.UpperLeft = 2;
            this.titleFilesAnime.Corners.UpperRight = 2;
            this.titleFilesAnime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFilesAnime.DesignerSelected = false;
            this.titleFilesAnime.DimFactorClick = 0;
            this.titleFilesAnime.DimFactorHover = 0;
            this.titleFilesAnime.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesAnime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFilesAnime.ImageIndex = 0;
            this.titleFilesAnime.Location = new System.Drawing.Point(141, 63);
            this.titleFilesAnime.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.titleFilesAnime.Name = "titleFilesAnime";
            this.titleFilesAnime.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.titleFilesAnime.Size = new System.Drawing.Size(60, 27);
            this.titleFilesAnime.TabIndex = 5;
            this.titleFilesAnime.TabStop = false;
            this.titleFilesAnime.Text = "Anime";
            this.titleFilesAnime.TextShadowShow = false;
            this.titleFilesAnime.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleFilesAnime_ClickButtonArea);
            // 
            // titleFilesSeries
            // 
            this.titleFilesSeries.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesSeries.BorderColor = System.Drawing.Color.Transparent;
            this.titleFilesSeries.ColorFillSolid = System.Drawing.Color.Transparent;
            this.titleFilesSeries.Corners.UpperLeft = 2;
            this.titleFilesSeries.Corners.UpperRight = 2;
            this.titleFilesSeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFilesSeries.DesignerSelected = false;
            this.titleFilesSeries.DimFactorClick = 0;
            this.titleFilesSeries.DimFactorHover = 0;
            this.titleFilesSeries.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesSeries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFilesSeries.ImageIndex = 0;
            this.titleFilesSeries.Location = new System.Drawing.Point(81, 63);
            this.titleFilesSeries.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.titleFilesSeries.Name = "titleFilesSeries";
            this.titleFilesSeries.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.titleFilesSeries.Size = new System.Drawing.Size(60, 27);
            this.titleFilesSeries.TabIndex = 6;
            this.titleFilesSeries.TabStop = false;
            this.titleFilesSeries.Text = "Series";
            this.titleFilesSeries.TextShadowShow = false;
            this.titleFilesSeries.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleFilesSeries_ClickButtonArea);
            // 
            // titleFilesSubtitles
            // 
            this.titleFilesSubtitles.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesSubtitles.BorderColor = System.Drawing.Color.Transparent;
            this.titleFilesSubtitles.ColorFillSolid = System.Drawing.Color.Transparent;
            this.titleFilesSubtitles.Corners.UpperLeft = 2;
            this.titleFilesSubtitles.Corners.UpperRight = 2;
            this.titleFilesSubtitles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFilesSubtitles.DesignerSelected = false;
            this.titleFilesSubtitles.DimFactorClick = 0;
            this.titleFilesSubtitles.DimFactorHover = 0;
            this.titleFilesSubtitles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesSubtitles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFilesSubtitles.ImageIndex = 0;
            this.titleFilesSubtitles.Location = new System.Drawing.Point(201, 63);
            this.titleFilesSubtitles.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.titleFilesSubtitles.Name = "titleFilesSubtitles";
            this.titleFilesSubtitles.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.titleFilesSubtitles.Size = new System.Drawing.Size(72, 27);
            this.titleFilesSubtitles.TabIndex = 8;
            this.titleFilesSubtitles.TabStop = false;
            this.titleFilesSubtitles.Text = "Subtitles";
            this.titleFilesSubtitles.TextShadowShow = false;
            this.titleFilesSubtitles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleFilesSubtitles_ClickButtonArea);
            // 
            // titleFilesTorrents
            // 
            this.titleFilesTorrents.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesTorrents.BorderColor = System.Drawing.Color.Transparent;
            this.titleFilesTorrents.ColorFillSolid = System.Drawing.Color.Transparent;
            this.titleFilesTorrents.Corners.UpperLeft = 2;
            this.titleFilesTorrents.Corners.UpperRight = 2;
            this.titleFilesTorrents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFilesTorrents.DesignerSelected = false;
            this.titleFilesTorrents.DimFactorClick = 0;
            this.titleFilesTorrents.DimFactorHover = 0;
            this.titleFilesTorrents.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesTorrents.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFilesTorrents.ImageIndex = 0;
            this.titleFilesTorrents.Location = new System.Drawing.Point(273, 63);
            this.titleFilesTorrents.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.titleFilesTorrents.Name = "titleFilesTorrents";
            this.titleFilesTorrents.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.titleFilesTorrents.Size = new System.Drawing.Size(72, 27);
            this.titleFilesTorrents.TabIndex = 7;
            this.titleFilesTorrents.TabStop = false;
            this.titleFilesTorrents.Text = "Torrents";
            this.titleFilesTorrents.TextShadowShow = false;
            this.titleFilesTorrents.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleFilesTorrents_ClickButtonArea);
            // 
            // titleFilesArchives
            // 
            this.titleFilesArchives.BackColor = System.Drawing.Color.Transparent;
            this.titleFilesArchives.BorderColor = System.Drawing.Color.Transparent;
            this.titleFilesArchives.ColorFillSolid = System.Drawing.Color.Transparent;
            this.titleFilesArchives.Corners.UpperLeft = 2;
            this.titleFilesArchives.Corners.UpperRight = 2;
            this.titleFilesArchives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFilesArchives.DesignerSelected = false;
            this.titleFilesArchives.DimFactorClick = 0;
            this.titleFilesArchives.DimFactorHover = 0;
            this.titleFilesArchives.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleFilesArchives.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFilesArchives.ImageIndex = 0;
            this.titleFilesArchives.Location = new System.Drawing.Point(347, 63);
            this.titleFilesArchives.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.titleFilesArchives.Name = "titleFilesArchives";
            this.titleFilesArchives.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.titleFilesArchives.Size = new System.Drawing.Size(70, 27);
            this.titleFilesArchives.TabIndex = 10;
            this.titleFilesArchives.TabStop = false;
            this.titleFilesArchives.Text = "Archives";
            this.titleFilesArchives.TextShadowShow = false;
            this.titleFilesArchives.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleFilesArchives_ClickButtonArea);
            // 
            // bgFilesSearchBox
            // 
            this.bgFilesSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgFilesSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.bgFilesSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.bgFilesSearchBox.Corners.All = 2;
            this.bgFilesSearchBox.Corners.LowerLeft = 2;
            this.bgFilesSearchBox.Corners.LowerRight = 2;
            this.bgFilesSearchBox.Corners.UpperLeft = 2;
            this.bgFilesSearchBox.Corners.UpperRight = 2;
            this.bgFilesSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgFilesSearchBox.DesignerSelected = false;
            this.bgFilesSearchBox.DimFactorClick = 0;
            this.bgFilesSearchBox.DimFactorHover = 0;
            this.bgFilesSearchBox.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgFilesSearchBox.ImageIndex = 0;
            this.bgFilesSearchBox.Location = new System.Drawing.Point(13, 13);
            this.bgFilesSearchBox.Name = "bgFilesSearchBox";
            this.bgFilesSearchBox.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgFilesSearchBox.Size = new System.Drawing.Size(399, 36);
            this.bgFilesSearchBox.TabIndex = 0;
            this.bgFilesSearchBox.TabStop = false;
            this.bgFilesSearchBox.Text = "";
            this.bgFilesSearchBox.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.bgFilesSearchBox_ClickButtonArea);
            // 
            // tabBookmarks
            // 
            this.tabBookmarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabBookmarks.Controls.Add(this.btnSearchBookmarks);
            this.tabBookmarks.Controls.Add(this.panelBookmarksFilters);
            this.tabBookmarks.Controls.Add(this.txtBookmarksSearchBox);
            this.tabBookmarks.Controls.Add(this.dataGridBookmarks);
            this.tabBookmarks.Controls.Add(this.bgBookmarksSearchBox);
            this.tabBookmarks.ForeColor = System.Drawing.Color.White;
            this.tabBookmarks.Location = new System.Drawing.Point(4, 22);
            this.tabBookmarks.Name = "tabBookmarks";
            this.tabBookmarks.Size = new System.Drawing.Size(868, 518);
            this.tabBookmarks.TabIndex = 5;
            // 
            // panelBookmarksFilters
            // 
            this.panelBookmarksFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookmarksFilters.Controls.Add(this.panelBookmarksSort);
            this.panelBookmarksFilters.Controls.Add(this.panelBookmarksType);
            this.panelBookmarksFilters.Location = new System.Drawing.Point(419, 13);
            this.panelBookmarksFilters.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.panelBookmarksFilters.Name = "panelBookmarksFilters";
            this.panelBookmarksFilters.Size = new System.Drawing.Size(442, 36);
            this.panelBookmarksFilters.TabIndex = 20;
            // 
            // panelBookmarksSort
            // 
            this.panelBookmarksSort.Controls.Add(this.btnBookmarksSort);
            this.panelBookmarksSort.Controls.Add(this.cmboBoxBookmarksSort);
            this.panelBookmarksSort.Location = new System.Drawing.Point(0, 0);
            this.panelBookmarksSort.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelBookmarksSort.Name = "panelBookmarksSort";
            this.panelBookmarksSort.Size = new System.Drawing.Size(168, 36);
            this.panelBookmarksSort.TabIndex = 5;
            // 
            // cmboBoxBookmarksSort
            // 
            this.cmboBoxBookmarksSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxBookmarksSort.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxBookmarksSort.FormattingEnabled = true;
            this.cmboBoxBookmarksSort.Items.AddRange(new object[] {
            "Recently Added",
            "A-Z",
            "Z-A"});
            this.cmboBoxBookmarksSort.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxBookmarksSort.Name = "cmboBoxBookmarksSort";
            this.cmboBoxBookmarksSort.Size = new System.Drawing.Size(168, 27);
            this.cmboBoxBookmarksSort.TabIndex = 0;
            this.cmboBoxBookmarksSort.TabStop = false;
            this.cmboBoxBookmarksSort.SelectedIndexChanged += new System.EventHandler(this.cmboBoxBookmarksSort_SelectedIndexChanged);
            // 
            // panelBookmarksType
            // 
            this.panelBookmarksType.Controls.Add(this.btnBookmarksType);
            this.panelBookmarksType.Controls.Add(this.cmboBoxBookmarksType);
            this.panelBookmarksType.Location = new System.Drawing.Point(175, 0);
            this.panelBookmarksType.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.panelBookmarksType.Name = "panelBookmarksType";
            this.panelBookmarksType.Size = new System.Drawing.Size(98, 36);
            this.panelBookmarksType.TabIndex = 0;
            // 
            // cmboBoxBookmarksType
            // 
            this.cmboBoxBookmarksType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxBookmarksType.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxBookmarksType.FormattingEnabled = true;
            this.cmboBoxBookmarksType.Items.AddRange(new object[] {
            "Any",
            "Movies",
            "Series",
            "Anime",
            "Subtitles",
            "Torrents"});
            this.cmboBoxBookmarksType.Location = new System.Drawing.Point(0, 8);
            this.cmboBoxBookmarksType.Name = "cmboBoxBookmarksType";
            this.cmboBoxBookmarksType.Size = new System.Drawing.Size(98, 27);
            this.cmboBoxBookmarksType.TabIndex = 0;
            this.cmboBoxBookmarksType.TabStop = false;
            this.cmboBoxBookmarksType.SelectedIndexChanged += new System.EventHandler(this.cmboBoxBookmarksType_SelectedIndexChanged);
            // 
            // txtBookmarksSearchBox
            // 
            this.txtBookmarksSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.txtBookmarksSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookmarksSearchBox.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBookmarksSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtBookmarksSearchBox.Location = new System.Drawing.Point(22, 21);
            this.txtBookmarksSearchBox.Name = "txtBookmarksSearchBox";
            this.txtBookmarksSearchBox.Size = new System.Drawing.Size(348, 20);
            this.txtBookmarksSearchBox.TabIndex = 10;
            this.txtBookmarksSearchBox.WaterMark = "Search file names, add some tags, insert a link...";
            this.txtBookmarksSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.txtBookmarksSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBookmarksSearchBox.WaterMarkForeColor = System.Drawing.Color.Silver;
            this.txtBookmarksSearchBox.Enter += new System.EventHandler(this.txtBookmarksSearchBox_Enter);
            this.txtBookmarksSearchBox.Leave += new System.EventHandler(this.txtBookmarksSearchBox_Leave);
            // 
            // dataGridBookmarks
            // 
            this.dataGridBookmarks.AllowUserToAddRows = false;
            this.dataGridBookmarks.AllowUserToDeleteRows = false;
            this.dataGridBookmarks.AllowUserToResizeColumns = false;
            this.dataGridBookmarks.AllowUserToResizeRows = false;
            this.dataGridBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBookmarks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBookmarks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridBookmarks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridBookmarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBookmarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridBookmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookmarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBookmarksType,
            this.columnBookmarksFileName,
            this.columnBookmarksFormat,
            this.columnBookmarksHost,
            this.columnBookmarksURL});
            this.dataGridBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridBookmarks.EnableHeadersVisualStyles = false;
            this.dataGridBookmarks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridBookmarks.Location = new System.Drawing.Point(0, 63);
            this.dataGridBookmarks.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGridBookmarks.MultiSelect = false;
            this.dataGridBookmarks.Name = "dataGridBookmarks";
            this.dataGridBookmarks.ReadOnly = true;
            this.dataGridBookmarks.RowHeadersVisible = false;
            this.dataGridBookmarks.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridBookmarks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridBookmarks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridBookmarks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dataGridBookmarks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridBookmarks.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridBookmarks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGridBookmarks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridBookmarks.RowTemplate.Height = 30;
            this.dataGridBookmarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBookmarks.ShowEditingIcon = false;
            this.dataGridBookmarks.Size = new System.Drawing.Size(868, 455);
            this.dataGridBookmarks.TabIndex = 13;
            this.dataGridBookmarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBookmarks_CellContentClick);
            // 
            // columnBookmarksType
            // 
            this.columnBookmarksType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.columnBookmarksType.HeaderText = "Type";
            this.columnBookmarksType.Name = "columnBookmarksType";
            this.columnBookmarksType.ReadOnly = true;
            this.columnBookmarksType.Width = 5;
            // 
            // columnBookmarksFileName
            // 
            this.columnBookmarksFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnBookmarksFileName.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnBookmarksFileName.HeaderText = "File Name";
            this.columnBookmarksFileName.Name = "columnBookmarksFileName";
            this.columnBookmarksFileName.ReadOnly = true;
            // 
            // columnBookmarksFormat
            // 
            this.columnBookmarksFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnBookmarksFormat.HeaderText = "Format";
            this.columnBookmarksFormat.Name = "columnBookmarksFormat";
            this.columnBookmarksFormat.ReadOnly = true;
            this.columnBookmarksFormat.Width = 76;
            // 
            // columnBookmarksHost
            // 
            this.columnBookmarksHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnBookmarksHost.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnBookmarksHost.HeaderText = "Host";
            this.columnBookmarksHost.Name = "columnBookmarksHost";
            this.columnBookmarksHost.ReadOnly = true;
            this.columnBookmarksHost.Width = 64;
            // 
            // columnBookmarksURL
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnBookmarksURL.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnBookmarksURL.HeaderText = "URL";
            this.columnBookmarksURL.Name = "columnBookmarksURL";
            this.columnBookmarksURL.ReadOnly = true;
            this.columnBookmarksURL.Visible = false;
            this.columnBookmarksURL.Width = 851;
            // 
            // bgBookmarksSearchBox
            // 
            this.bgBookmarksSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgBookmarksSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.bgBookmarksSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(131)))));
            this.bgBookmarksSearchBox.Corners.All = 2;
            this.bgBookmarksSearchBox.Corners.LowerLeft = 2;
            this.bgBookmarksSearchBox.Corners.LowerRight = 2;
            this.bgBookmarksSearchBox.Corners.UpperLeft = 2;
            this.bgBookmarksSearchBox.Corners.UpperRight = 2;
            this.bgBookmarksSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgBookmarksSearchBox.DesignerSelected = false;
            this.bgBookmarksSearchBox.DimFactorClick = 0;
            this.bgBookmarksSearchBox.DimFactorHover = 0;
            this.bgBookmarksSearchBox.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgBookmarksSearchBox.ImageIndex = 0;
            this.bgBookmarksSearchBox.Location = new System.Drawing.Point(13, 13);
            this.bgBookmarksSearchBox.Name = "bgBookmarksSearchBox";
            this.bgBookmarksSearchBox.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgBookmarksSearchBox.Size = new System.Drawing.Size(399, 36);
            this.bgBookmarksSearchBox.TabIndex = 11;
            this.bgBookmarksSearchBox.TabStop = false;
            this.bgBookmarksSearchBox.Text = "";
            this.bgBookmarksSearchBox.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.bgBookmarksSearchBox_ClickButtonArea);
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabHistory.ForeColor = System.Drawing.Color.White;
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(868, 518);
            this.tabHistory.TabIndex = 7;
            // 
            // tabDownloads
            // 
            this.tabDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabDownloads.Controls.Add(this.lblNoDownloads);
            this.tabDownloads.Controls.Add(this.panelDownloads);
            this.tabDownloads.ForeColor = System.Drawing.Color.White;
            this.tabDownloads.Location = new System.Drawing.Point(4, 22);
            this.tabDownloads.Name = "tabDownloads";
            this.tabDownloads.Size = new System.Drawing.Size(868, 518);
            this.tabDownloads.TabIndex = 4;
            // 
            // lblNoDownloads
            // 
            this.lblNoDownloads.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoDownloads.AutoSize = true;
            this.lblNoDownloads.BackColor = System.Drawing.Color.Transparent;
            this.lblNoDownloads.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblNoDownloads.ForeColor = System.Drawing.Color.White;
            this.lblNoDownloads.Location = new System.Drawing.Point(347, 247);
            this.lblNoDownloads.Name = "lblNoDownloads";
            this.lblNoDownloads.Size = new System.Drawing.Size(143, 25);
            this.lblNoDownloads.TabIndex = 4;
            this.lblNoDownloads.Text = "No Downloads...";
            // 
            // panelDownloads
            // 
            this.panelDownloads.AutoScroll = true;
            this.panelDownloads.BackColor = System.Drawing.Color.Transparent;
            this.panelDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDownloads.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDownloads.Location = new System.Drawing.Point(0, 0);
            this.panelDownloads.Name = "panelDownloads";
            this.panelDownloads.Size = new System.Drawing.Size(868, 518);
            this.panelDownloads.TabIndex = 2;
            this.panelDownloads.WrapContents = false;
            this.panelDownloads.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelDownloadItems_ControlAdded);
            this.panelDownloads.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelDownloadItems_ControlRemoved);
            // 
            // tabBlank
            // 
            this.tabBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabBlank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBlank.ForeColor = System.Drawing.Color.White;
            this.tabBlank.Location = new System.Drawing.Point(4, 22);
            this.tabBlank.Name = "tabBlank";
            this.tabBlank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBlank.Size = new System.Drawing.Size(868, 518);
            this.tabBlank.TabIndex = 3;
            // 
            // tabSettings
            // 
            this.tabSettings.AutoScroll = true;
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSettings.Controls.Add(this.imgSettingsDownloadsDirectory);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.txtBoxSettingsDownloadsDirectory);
            this.tabSettings.Controls.Add(this.bgSettingsDownloadsDirectory);
            this.tabSettings.Controls.Add(this.lblSettingsDownloadsDirectory);
            this.tabSettings.Controls.Add(this.lblSettingsConnectionCustom);
            this.tabSettings.Controls.Add(this.chkSettingsCustomConnection);
            this.tabSettings.Controls.Add(this.btnSettingsSave);
            this.tabSettings.Controls.Add(this.btnSettingsRestoreDefault);
            this.tabSettings.Controls.Add(this.titleSettingsGeneral);
            this.tabSettings.Controls.Add(this.lblSettingsGeneralClearDataOnClose);
            this.tabSettings.Controls.Add(this.chkSettingsClearData);
            this.tabSettings.Controls.Add(this.txtBoxSettingsConnectionPassword);
            this.tabSettings.Controls.Add(this.bgSettingsConnectionPassword);
            this.tabSettings.Controls.Add(this.lblSettingsConnectionPassword);
            this.tabSettings.Controls.Add(this.txtBoxSettingsConnectionUsername);
            this.tabSettings.Controls.Add(this.bgSettingsConnectionUsername);
            this.tabSettings.Controls.Add(this.lblSettingsConnectionUsername);
            this.tabSettings.Controls.Add(this.txtBoxSettingsConnectionPort);
            this.tabSettings.Controls.Add(this.bgSettingsConnectionPort);
            this.tabSettings.Controls.Add(this.lblSettingsConnectionPort);
            this.tabSettings.Controls.Add(this.txtBoxSettingsConnectionHost);
            this.tabSettings.Controls.Add(this.bgSettingsConnectionHost);
            this.tabSettings.Controls.Add(this.lblSettingsConnectionHost);
            this.tabSettings.Controls.Add(this.titleSettingsConnection);
            this.tabSettings.ForeColor = System.Drawing.Color.White;
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(868, 518);
            this.tabSettings.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "Downloads";
            // 
            // txtBoxSettingsDownloadsDirectory
            // 
            this.txtBoxSettingsDownloadsDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBoxSettingsDownloadsDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSettingsDownloadsDirectory.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsDownloadsDirectory.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsDownloadsDirectory.Location = new System.Drawing.Point(244, 155);
            this.txtBoxSettingsDownloadsDirectory.Name = "txtBoxSettingsDownloadsDirectory";
            this.txtBoxSettingsDownloadsDirectory.ReadOnly = true;
            this.txtBoxSettingsDownloadsDirectory.Size = new System.Drawing.Size(323, 20);
            this.txtBoxSettingsDownloadsDirectory.TabIndex = 1;
            this.txtBoxSettingsDownloadsDirectory.WaterMark = "default";
            this.txtBoxSettingsDownloadsDirectory.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsDownloadsDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsDownloadsDirectory.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // bgSettingsDownloadsDirectory
            // 
            this.bgSettingsDownloadsDirectory.BackColor = System.Drawing.Color.Transparent;
            this.bgSettingsDownloadsDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsDownloadsDirectory.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsDownloadsDirectory.Corners.All = 2;
            this.bgSettingsDownloadsDirectory.Corners.LowerLeft = 2;
            this.bgSettingsDownloadsDirectory.Corners.LowerRight = 2;
            this.bgSettingsDownloadsDirectory.Corners.UpperLeft = 2;
            this.bgSettingsDownloadsDirectory.Corners.UpperRight = 2;
            this.bgSettingsDownloadsDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSettingsDownloadsDirectory.DesignerSelected = false;
            this.bgSettingsDownloadsDirectory.DimFactorClick = 0;
            this.bgSettingsDownloadsDirectory.DimFactorHover = 0;
            this.bgSettingsDownloadsDirectory.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSettingsDownloadsDirectory.ImageIndex = 0;
            this.bgSettingsDownloadsDirectory.Location = new System.Drawing.Point(238, 150);
            this.bgSettingsDownloadsDirectory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bgSettingsDownloadsDirectory.Name = "bgSettingsDownloadsDirectory";
            this.bgSettingsDownloadsDirectory.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSettingsDownloadsDirectory.Size = new System.Drawing.Size(335, 31);
            this.bgSettingsDownloadsDirectory.TabIndex = 39;
            this.bgSettingsDownloadsDirectory.TabStop = false;
            this.bgSettingsDownloadsDirectory.Text = "";
            // 
            // lblSettingsDownloadsDirectory
            // 
            this.lblSettingsDownloadsDirectory.AutoSize = true;
            this.lblSettingsDownloadsDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsDownloadsDirectory.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsDownloadsDirectory.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsDownloadsDirectory.ForeColor = System.Drawing.Color.White;
            this.lblSettingsDownloadsDirectory.Location = new System.Drawing.Point(13, 158);
            this.lblSettingsDownloadsDirectory.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsDownloadsDirectory.Name = "lblSettingsDownloadsDirectory";
            this.lblSettingsDownloadsDirectory.Size = new System.Drawing.Size(91, 19);
            this.lblSettingsDownloadsDirectory.TabIndex = 0;
            this.lblSettingsDownloadsDirectory.Text = "Download to:";
            // 
            // lblSettingsConnectionCustom
            // 
            this.lblSettingsConnectionCustom.AutoSize = true;
            this.lblSettingsConnectionCustom.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsConnectionCustom.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsConnectionCustom.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsConnectionCustom.ForeColor = System.Drawing.Color.White;
            this.lblSettingsConnectionCustom.Location = new System.Drawing.Point(13, 254);
            this.lblSettingsConnectionCustom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsConnectionCustom.Name = "lblSettingsConnectionCustom";
            this.lblSettingsConnectionCustom.Size = new System.Drawing.Size(60, 19);
            this.lblSettingsConnectionCustom.TabIndex = 36;
            this.lblSettingsConnectionCustom.Text = "Custom:";
            // 
            // chkSettingsCustomConnection
            // 
            this.chkSettingsCustomConnection.AutoSize = true;
            this.chkSettingsCustomConnection.BackColor = System.Drawing.Color.Transparent;
            this.chkSettingsCustomConnection.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.chkSettingsCustomConnection.Location = new System.Drawing.Point(238, 259);
            this.chkSettingsCustomConnection.Name = "chkSettingsCustomConnection";
            this.chkSettingsCustomConnection.Size = new System.Drawing.Size(15, 14);
            this.chkSettingsCustomConnection.TabIndex = 2;
            this.chkSettingsCustomConnection.UseVisualStyleBackColor = false;
            this.chkSettingsCustomConnection.CheckedChanged += new System.EventHandler(this.chkSettingsCustomConnection_CheckedChanged);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettingsSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingsSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSettingsSave.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSettingsSave.Corners.All = 2;
            this.btnSettingsSave.Corners.LowerLeft = 2;
            this.btnSettingsSave.Corners.LowerRight = 2;
            this.btnSettingsSave.Corners.UpperLeft = 2;
            this.btnSettingsSave.Corners.UpperRight = 2;
            this.btnSettingsSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsSave.DesignerSelected = false;
            this.btnSettingsSave.DimFactorClick = 0;
            this.btnSettingsSave.DimFactorHover = 0;
            this.btnSettingsSave.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSettingsSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSettingsSave.ImageIndex = 0;
            this.btnSettingsSave.Location = new System.Drawing.Point(147, 473);
            this.btnSettingsSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSettingsSave.Size = new System.Drawing.Size(106, 30);
            this.btnSettingsSave.TabIndex = 8;
            this.btnSettingsSave.Text = "Save settings";
            this.btnSettingsSave.TextShadowShow = false;
            this.btnSettingsSave.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSettingsSave_ClickButtonArea);
            // 
            // btnSettingsRestoreDefault
            // 
            this.btnSettingsRestoreDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettingsRestoreDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingsRestoreDefault.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSettingsRestoreDefault.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSettingsRestoreDefault.Corners.All = 2;
            this.btnSettingsRestoreDefault.Corners.LowerLeft = 2;
            this.btnSettingsRestoreDefault.Corners.LowerRight = 2;
            this.btnSettingsRestoreDefault.Corners.UpperLeft = 2;
            this.btnSettingsRestoreDefault.Corners.UpperRight = 2;
            this.btnSettingsRestoreDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsRestoreDefault.DesignerSelected = false;
            this.btnSettingsRestoreDefault.DimFactorClick = 0;
            this.btnSettingsRestoreDefault.DimFactorHover = 0;
            this.btnSettingsRestoreDefault.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSettingsRestoreDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSettingsRestoreDefault.ImageIndex = 0;
            this.btnSettingsRestoreDefault.Location = new System.Drawing.Point(17, 473);
            this.btnSettingsRestoreDefault.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnSettingsRestoreDefault.Name = "btnSettingsRestoreDefault";
            this.btnSettingsRestoreDefault.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSettingsRestoreDefault.Size = new System.Drawing.Size(124, 30);
            this.btnSettingsRestoreDefault.TabIndex = 7;
            this.btnSettingsRestoreDefault.Text = "Restore defaults";
            this.btnSettingsRestoreDefault.TextShadowShow = false;
            this.btnSettingsRestoreDefault.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSettingsRestoreDefault_ClickButtonArea);
            // 
            // titleSettingsGeneral
            // 
            this.titleSettingsGeneral.AutoSize = true;
            this.titleSettingsGeneral.BackColor = System.Drawing.Color.Transparent;
            this.titleSettingsGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleSettingsGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.titleSettingsGeneral.ForeColor = System.Drawing.Color.White;
            this.titleSettingsGeneral.Location = new System.Drawing.Point(12, 14);
            this.titleSettingsGeneral.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleSettingsGeneral.Name = "titleSettingsGeneral";
            this.titleSettingsGeneral.Size = new System.Drawing.Size(86, 30);
            this.titleSettingsGeneral.TabIndex = 32;
            this.titleSettingsGeneral.Text = "General";
            // 
            // lblSettingsGeneralClearDataOnClose
            // 
            this.lblSettingsGeneralClearDataOnClose.AutoSize = true;
            this.lblSettingsGeneralClearDataOnClose.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsGeneralClearDataOnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsGeneralClearDataOnClose.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsGeneralClearDataOnClose.ForeColor = System.Drawing.Color.White;
            this.lblSettingsGeneralClearDataOnClose.Location = new System.Drawing.Point(13, 60);
            this.lblSettingsGeneralClearDataOnClose.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsGeneralClearDataOnClose.Name = "lblSettingsGeneralClearDataOnClose";
            this.lblSettingsGeneralClearDataOnClose.Size = new System.Drawing.Size(128, 19);
            this.lblSettingsGeneralClearDataOnClose.TabIndex = 31;
            this.lblSettingsGeneralClearDataOnClose.Text = "Clear data on close:";
            // 
            // chkSettingsClearData
            // 
            this.chkSettingsClearData.AutoSize = true;
            this.chkSettingsClearData.BackColor = System.Drawing.Color.Transparent;
            this.chkSettingsClearData.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.chkSettingsClearData.Location = new System.Drawing.Point(238, 63);
            this.chkSettingsClearData.Name = "chkSettingsClearData";
            this.chkSettingsClearData.Size = new System.Drawing.Size(15, 14);
            this.chkSettingsClearData.TabIndex = 0;
            this.chkSettingsClearData.UseVisualStyleBackColor = false;
            this.chkSettingsClearData.CheckedChanged += new System.EventHandler(this.chkSettingsClearData_CheckedChanged);
            // 
            // txtBoxSettingsConnectionPassword
            // 
            this.txtBoxSettingsConnectionPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBoxSettingsConnectionPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSettingsConnectionPassword.Enabled = false;
            this.txtBoxSettingsConnectionPassword.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionPassword.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionPassword.Location = new System.Drawing.Point(244, 416);
            this.txtBoxSettingsConnectionPassword.Name = "txtBoxSettingsConnectionPassword";
            this.txtBoxSettingsConnectionPassword.Size = new System.Drawing.Size(323, 20);
            this.txtBoxSettingsConnectionPassword.TabIndex = 6;
            this.txtBoxSettingsConnectionPassword.WaterMark = "default";
            this.txtBoxSettingsConnectionPassword.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionPassword.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // bgSettingsConnectionPassword
            // 
            this.bgSettingsConnectionPassword.BackColor = System.Drawing.Color.Transparent;
            this.bgSettingsConnectionPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionPassword.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionPassword.Corners.All = 2;
            this.bgSettingsConnectionPassword.Corners.LowerLeft = 2;
            this.bgSettingsConnectionPassword.Corners.LowerRight = 2;
            this.bgSettingsConnectionPassword.Corners.UpperLeft = 2;
            this.bgSettingsConnectionPassword.Corners.UpperRight = 2;
            this.bgSettingsConnectionPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSettingsConnectionPassword.DesignerSelected = false;
            this.bgSettingsConnectionPassword.DimFactorClick = 0;
            this.bgSettingsConnectionPassword.DimFactorHover = 0;
            this.bgSettingsConnectionPassword.Enabled = false;
            this.bgSettingsConnectionPassword.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSettingsConnectionPassword.ImageIndex = 0;
            this.bgSettingsConnectionPassword.Location = new System.Drawing.Point(238, 411);
            this.bgSettingsConnectionPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bgSettingsConnectionPassword.Name = "bgSettingsConnectionPassword";
            this.bgSettingsConnectionPassword.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSettingsConnectionPassword.Size = new System.Drawing.Size(335, 31);
            this.bgSettingsConnectionPassword.TabIndex = 29;
            this.bgSettingsConnectionPassword.TabStop = false;
            this.bgSettingsConnectionPassword.Text = "";
            // 
            // lblSettingsConnectionPassword
            // 
            this.lblSettingsConnectionPassword.AutoSize = true;
            this.lblSettingsConnectionPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsConnectionPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsConnectionPassword.Enabled = false;
            this.lblSettingsConnectionPassword.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsConnectionPassword.ForeColor = System.Drawing.Color.White;
            this.lblSettingsConnectionPassword.Location = new System.Drawing.Point(13, 419);
            this.lblSettingsConnectionPassword.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsConnectionPassword.Name = "lblSettingsConnectionPassword";
            this.lblSettingsConnectionPassword.Size = new System.Drawing.Size(70, 19);
            this.lblSettingsConnectionPassword.TabIndex = 27;
            this.lblSettingsConnectionPassword.Text = "Password:";
            // 
            // txtBoxSettingsConnectionUsername
            // 
            this.txtBoxSettingsConnectionUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBoxSettingsConnectionUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSettingsConnectionUsername.Enabled = false;
            this.txtBoxSettingsConnectionUsername.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionUsername.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionUsername.Location = new System.Drawing.Point(244, 375);
            this.txtBoxSettingsConnectionUsername.Name = "txtBoxSettingsConnectionUsername";
            this.txtBoxSettingsConnectionUsername.Size = new System.Drawing.Size(323, 20);
            this.txtBoxSettingsConnectionUsername.TabIndex = 5;
            this.txtBoxSettingsConnectionUsername.WaterMark = "default";
            this.txtBoxSettingsConnectionUsername.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionUsername.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // bgSettingsConnectionUsername
            // 
            this.bgSettingsConnectionUsername.BackColor = System.Drawing.Color.Transparent;
            this.bgSettingsConnectionUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionUsername.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionUsername.Corners.All = 2;
            this.bgSettingsConnectionUsername.Corners.LowerLeft = 2;
            this.bgSettingsConnectionUsername.Corners.LowerRight = 2;
            this.bgSettingsConnectionUsername.Corners.UpperLeft = 2;
            this.bgSettingsConnectionUsername.Corners.UpperRight = 2;
            this.bgSettingsConnectionUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSettingsConnectionUsername.DesignerSelected = false;
            this.bgSettingsConnectionUsername.DimFactorClick = 0;
            this.bgSettingsConnectionUsername.DimFactorHover = 0;
            this.bgSettingsConnectionUsername.Enabled = false;
            this.bgSettingsConnectionUsername.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSettingsConnectionUsername.ImageIndex = 0;
            this.bgSettingsConnectionUsername.Location = new System.Drawing.Point(238, 370);
            this.bgSettingsConnectionUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bgSettingsConnectionUsername.Name = "bgSettingsConnectionUsername";
            this.bgSettingsConnectionUsername.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSettingsConnectionUsername.Size = new System.Drawing.Size(335, 31);
            this.bgSettingsConnectionUsername.TabIndex = 26;
            this.bgSettingsConnectionUsername.TabStop = false;
            this.bgSettingsConnectionUsername.Text = "";
            // 
            // lblSettingsConnectionUsername
            // 
            this.lblSettingsConnectionUsername.AutoSize = true;
            this.lblSettingsConnectionUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsConnectionUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsConnectionUsername.Enabled = false;
            this.lblSettingsConnectionUsername.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsConnectionUsername.ForeColor = System.Drawing.Color.White;
            this.lblSettingsConnectionUsername.Location = new System.Drawing.Point(13, 378);
            this.lblSettingsConnectionUsername.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsConnectionUsername.Name = "lblSettingsConnectionUsername";
            this.lblSettingsConnectionUsername.Size = new System.Drawing.Size(74, 19);
            this.lblSettingsConnectionUsername.TabIndex = 24;
            this.lblSettingsConnectionUsername.Text = "Username:";
            // 
            // txtBoxSettingsConnectionPort
            // 
            this.txtBoxSettingsConnectionPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBoxSettingsConnectionPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSettingsConnectionPort.Enabled = false;
            this.txtBoxSettingsConnectionPort.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionPort.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionPort.Location = new System.Drawing.Point(244, 334);
            this.txtBoxSettingsConnectionPort.Name = "txtBoxSettingsConnectionPort";
            this.txtBoxSettingsConnectionPort.Size = new System.Drawing.Size(323, 20);
            this.txtBoxSettingsConnectionPort.TabIndex = 4;
            this.txtBoxSettingsConnectionPort.WaterMark = "8080";
            this.txtBoxSettingsConnectionPort.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionPort.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // bgSettingsConnectionPort
            // 
            this.bgSettingsConnectionPort.BackColor = System.Drawing.Color.Transparent;
            this.bgSettingsConnectionPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionPort.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionPort.Corners.All = 2;
            this.bgSettingsConnectionPort.Corners.LowerLeft = 2;
            this.bgSettingsConnectionPort.Corners.LowerRight = 2;
            this.bgSettingsConnectionPort.Corners.UpperLeft = 2;
            this.bgSettingsConnectionPort.Corners.UpperRight = 2;
            this.bgSettingsConnectionPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSettingsConnectionPort.DesignerSelected = false;
            this.bgSettingsConnectionPort.DimFactorClick = 0;
            this.bgSettingsConnectionPort.DimFactorHover = 0;
            this.bgSettingsConnectionPort.Enabled = false;
            this.bgSettingsConnectionPort.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSettingsConnectionPort.ImageIndex = 0;
            this.bgSettingsConnectionPort.Location = new System.Drawing.Point(238, 329);
            this.bgSettingsConnectionPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bgSettingsConnectionPort.Name = "bgSettingsConnectionPort";
            this.bgSettingsConnectionPort.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSettingsConnectionPort.Size = new System.Drawing.Size(335, 31);
            this.bgSettingsConnectionPort.TabIndex = 23;
            this.bgSettingsConnectionPort.TabStop = false;
            this.bgSettingsConnectionPort.Text = "";
            // 
            // lblSettingsConnectionPort
            // 
            this.lblSettingsConnectionPort.AutoSize = true;
            this.lblSettingsConnectionPort.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsConnectionPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsConnectionPort.Enabled = false;
            this.lblSettingsConnectionPort.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsConnectionPort.ForeColor = System.Drawing.Color.White;
            this.lblSettingsConnectionPort.Location = new System.Drawing.Point(13, 333);
            this.lblSettingsConnectionPort.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsConnectionPort.Name = "lblSettingsConnectionPort";
            this.lblSettingsConnectionPort.Size = new System.Drawing.Size(37, 19);
            this.lblSettingsConnectionPort.TabIndex = 21;
            this.lblSettingsConnectionPort.Text = "Port:";
            // 
            // txtBoxSettingsConnectionHost
            // 
            this.txtBoxSettingsConnectionHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBoxSettingsConnectionHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSettingsConnectionHost.Enabled = false;
            this.txtBoxSettingsConnectionHost.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionHost.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionHost.Location = new System.Drawing.Point(244, 293);
            this.txtBoxSettingsConnectionHost.Name = "txtBoxSettingsConnectionHost";
            this.txtBoxSettingsConnectionHost.Size = new System.Drawing.Size(323, 20);
            this.txtBoxSettingsConnectionHost.TabIndex = 3;
            this.txtBoxSettingsConnectionHost.WaterMark = "192.0.0.1";
            this.txtBoxSettingsConnectionHost.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtBoxSettingsConnectionHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtBoxSettingsConnectionHost.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // bgSettingsConnectionHost
            // 
            this.bgSettingsConnectionHost.BackColor = System.Drawing.Color.Transparent;
            this.bgSettingsConnectionHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionHost.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgSettingsConnectionHost.Corners.All = 2;
            this.bgSettingsConnectionHost.Corners.LowerLeft = 2;
            this.bgSettingsConnectionHost.Corners.LowerRight = 2;
            this.bgSettingsConnectionHost.Corners.UpperLeft = 2;
            this.bgSettingsConnectionHost.Corners.UpperRight = 2;
            this.bgSettingsConnectionHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSettingsConnectionHost.DesignerSelected = false;
            this.bgSettingsConnectionHost.DimFactorClick = 0;
            this.bgSettingsConnectionHost.DimFactorHover = 0;
            this.bgSettingsConnectionHost.Enabled = false;
            this.bgSettingsConnectionHost.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSettingsConnectionHost.ImageIndex = 0;
            this.bgSettingsConnectionHost.Location = new System.Drawing.Point(238, 288);
            this.bgSettingsConnectionHost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bgSettingsConnectionHost.Name = "bgSettingsConnectionHost";
            this.bgSettingsConnectionHost.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSettingsConnectionHost.Size = new System.Drawing.Size(335, 31);
            this.bgSettingsConnectionHost.TabIndex = 20;
            this.bgSettingsConnectionHost.TabStop = false;
            this.bgSettingsConnectionHost.Text = "";
            // 
            // lblSettingsConnectionHost
            // 
            this.lblSettingsConnectionHost.AutoSize = true;
            this.lblSettingsConnectionHost.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsConnectionHost.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSettingsConnectionHost.Enabled = false;
            this.lblSettingsConnectionHost.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblSettingsConnectionHost.ForeColor = System.Drawing.Color.White;
            this.lblSettingsConnectionHost.Location = new System.Drawing.Point(13, 294);
            this.lblSettingsConnectionHost.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblSettingsConnectionHost.Name = "lblSettingsConnectionHost";
            this.lblSettingsConnectionHost.Size = new System.Drawing.Size(41, 19);
            this.lblSettingsConnectionHost.TabIndex = 18;
            this.lblSettingsConnectionHost.Text = "Host:";
            // 
            // titleSettingsConnection
            // 
            this.titleSettingsConnection.AutoSize = true;
            this.titleSettingsConnection.BackColor = System.Drawing.Color.Transparent;
            this.titleSettingsConnection.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleSettingsConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.titleSettingsConnection.ForeColor = System.Drawing.Color.White;
            this.titleSettingsConnection.Location = new System.Drawing.Point(12, 210);
            this.titleSettingsConnection.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleSettingsConnection.Name = "titleSettingsConnection";
            this.titleSettingsConnection.Size = new System.Drawing.Size(122, 30);
            this.titleSettingsConnection.TabIndex = 18;
            this.titleSettingsConnection.Text = "Connection";
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
            this.tabAbout.Size = new System.Drawing.Size(868, 518);
            this.tabAbout.TabIndex = 2;
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAboutVersion.Location = new System.Drawing.Point(787, 496);
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
            this.btnAboutReportIssue.Location = new System.Drawing.Point(7, 496);
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
            this.lblAboutSubText.Location = new System.Drawing.Point(317, 484);
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
            this.lblAboutText.Location = new System.Drawing.Point(85, 178);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(699, 201);
            this.lblAboutText.TabIndex = 0;
            this.lblAboutText.Text = resources.GetString("lblAboutText.Text");
            this.lblAboutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitles
            // 
            this.panelTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.panelTitles.Controls.Add(this.imgSettings);
            this.panelTitles.Controls.Add(this.titleLineSettings);
            this.panelTitles.Controls.Add(this.titleSettings);
            this.panelTitles.Controls.Add(this.titleLineBookmarks);
            this.panelTitles.Controls.Add(this.imgBookmarks);
            this.panelTitles.Controls.Add(this.titleBookmarks);
            this.panelTitles.Controls.Add(this.imgDownloads);
            this.panelTitles.Controls.Add(this.titleLineDownloads);
            this.panelTitles.Controls.Add(this.titleDownloads);
            this.panelTitles.Controls.Add(this.imgAbout);
            this.panelTitles.Controls.Add(this.titleLineAbout);
            this.panelTitles.Controls.Add(this.titleAbout);
            this.panelTitles.Controls.Add(this.imgFiles);
            this.panelTitles.Controls.Add(this.imgMovies);
            this.panelTitles.Controls.Add(this.titleLineFiles);
            this.panelTitles.Controls.Add(this.titleLineMovies);
            this.panelTitles.Controls.Add(this.titleFiles);
            this.panelTitles.Controls.Add(this.titleMovies);
            this.panelTitles.ForeColor = System.Drawing.Color.White;
            this.panelTitles.Location = new System.Drawing.Point(0, 0);
            this.panelTitles.Name = "panelTitles";
            this.panelTitles.Size = new System.Drawing.Size(180, 518);
            this.panelTitles.TabIndex = 1;
            // 
            // titleLineSettings
            // 
            this.titleLineSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLineSettings.BackColor = System.Drawing.Color.Transparent;
            this.titleLineSettings.BorderColor = System.Drawing.Color.White;
            this.titleLineSettings.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineSettings.DesignerSelected = false;
            this.titleLineSettings.DimFactorClick = 0;
            this.titleLineSettings.DimFactorHover = 0;
            this.titleLineSettings.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineSettings.ImageIndex = 0;
            this.titleLineSettings.Location = new System.Drawing.Point(176, 230);
            this.titleLineSettings.Name = "titleLineSettings";
            this.titleLineSettings.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineSettings.Size = new System.Drawing.Size(3, 28);
            this.titleLineSettings.TabIndex = 16;
            this.titleLineSettings.TabStop = false;
            this.titleLineSettings.Text = "";
            this.titleLineSettings.Visible = false;
            // 
            // titleSettings
            // 
            this.titleSettings.AutoSize = true;
            this.titleSettings.BackColor = System.Drawing.Color.Transparent;
            this.titleSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleSettings.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.titleSettings.ForeColor = System.Drawing.Color.White;
            this.titleSettings.Location = new System.Drawing.Point(42, 234);
            this.titleSettings.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleSettings.Name = "titleSettings";
            this.titleSettings.Size = new System.Drawing.Size(62, 20);
            this.titleSettings.TabIndex = 15;
            this.titleSettings.Text = "Settings";
            this.titleSettings.Click += new System.EventHandler(this.imgSettings_Click);
            // 
            // titleLineBookmarks
            // 
            this.titleLineBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLineBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.titleLineBookmarks.BorderColor = System.Drawing.Color.White;
            this.titleLineBookmarks.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineBookmarks.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineBookmarks.DesignerSelected = false;
            this.titleLineBookmarks.DimFactorClick = 0;
            this.titleLineBookmarks.DimFactorHover = 0;
            this.titleLineBookmarks.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineBookmarks.ImageIndex = 0;
            this.titleLineBookmarks.Location = new System.Drawing.Point(176, 98);
            this.titleLineBookmarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.titleLineBookmarks.Name = "titleLineBookmarks";
            this.titleLineBookmarks.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineBookmarks.Size = new System.Drawing.Size(3, 28);
            this.titleLineBookmarks.TabIndex = 14;
            this.titleLineBookmarks.TabStop = false;
            this.titleLineBookmarks.Text = "";
            this.titleLineBookmarks.Visible = false;
            // 
            // titleBookmarks
            // 
            this.titleBookmarks.AutoSize = true;
            this.titleBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.titleBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleBookmarks.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.titleBookmarks.ForeColor = System.Drawing.Color.White;
            this.titleBookmarks.Location = new System.Drawing.Point(42, 102);
            this.titleBookmarks.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleBookmarks.Name = "titleBookmarks";
            this.titleBookmarks.Size = new System.Drawing.Size(82, 20);
            this.titleBookmarks.TabIndex = 12;
            this.titleBookmarks.Text = "Bookmarks";
            this.titleBookmarks.Click += new System.EventHandler(this.imgBookmarks_Click);
            // 
            // titleLineDownloads
            // 
            this.titleLineDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLineDownloads.BackColor = System.Drawing.Color.Transparent;
            this.titleLineDownloads.BorderColor = System.Drawing.Color.White;
            this.titleLineDownloads.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineDownloads.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineDownloads.DesignerSelected = false;
            this.titleLineDownloads.DimFactorClick = 0;
            this.titleLineDownloads.DimFactorHover = 0;
            this.titleLineDownloads.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineDownloads.ImageIndex = 0;
            this.titleLineDownloads.Location = new System.Drawing.Point(176, 137);
            this.titleLineDownloads.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.titleLineDownloads.Name = "titleLineDownloads";
            this.titleLineDownloads.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineDownloads.Size = new System.Drawing.Size(3, 28);
            this.titleLineDownloads.TabIndex = 10;
            this.titleLineDownloads.TabStop = false;
            this.titleLineDownloads.Text = "";
            this.titleLineDownloads.Visible = false;
            // 
            // titleDownloads
            // 
            this.titleDownloads.AutoSize = true;
            this.titleDownloads.BackColor = System.Drawing.Color.Transparent;
            this.titleDownloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleDownloads.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.titleDownloads.ForeColor = System.Drawing.Color.White;
            this.titleDownloads.Location = new System.Drawing.Point(42, 141);
            this.titleDownloads.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleDownloads.Name = "titleDownloads";
            this.titleDownloads.Size = new System.Drawing.Size(84, 20);
            this.titleDownloads.TabIndex = 9;
            this.titleDownloads.Text = "Downloads";
            this.titleDownloads.Click += new System.EventHandler(this.imgDownloads_Click);
            // 
            // titleLineAbout
            // 
            this.titleLineAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLineAbout.BackColor = System.Drawing.Color.Transparent;
            this.titleLineAbout.BorderColor = System.Drawing.Color.White;
            this.titleLineAbout.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineAbout.DesignerSelected = false;
            this.titleLineAbout.DimFactorClick = 0;
            this.titleLineAbout.DimFactorHover = 0;
            this.titleLineAbout.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineAbout.ImageIndex = 0;
            this.titleLineAbout.Location = new System.Drawing.Point(176, 269);
            this.titleLineAbout.Name = "titleLineAbout";
            this.titleLineAbout.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineAbout.Size = new System.Drawing.Size(3, 28);
            this.titleLineAbout.TabIndex = 7;
            this.titleLineAbout.TabStop = false;
            this.titleLineAbout.Text = "";
            this.titleLineAbout.Visible = false;
            // 
            // titleAbout
            // 
            this.titleAbout.AutoSize = true;
            this.titleAbout.BackColor = System.Drawing.Color.Transparent;
            this.titleAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleAbout.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.titleAbout.ForeColor = System.Drawing.Color.White;
            this.titleAbout.Location = new System.Drawing.Point(42, 273);
            this.titleAbout.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleAbout.Name = "titleAbout";
            this.titleAbout.Size = new System.Drawing.Size(50, 20);
            this.titleAbout.TabIndex = 6;
            this.titleAbout.Text = "About";
            this.titleAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // titleLineFiles
            // 
            this.titleLineFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLineFiles.BackColor = System.Drawing.Color.Transparent;
            this.titleLineFiles.BorderColor = System.Drawing.Color.White;
            this.titleLineFiles.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineFiles.DesignerSelected = false;
            this.titleLineFiles.DimFactorClick = 0;
            this.titleLineFiles.DimFactorHover = 0;
            this.titleLineFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineFiles.ImageIndex = 0;
            this.titleLineFiles.Location = new System.Drawing.Point(176, 60);
            this.titleLineFiles.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.titleLineFiles.Name = "titleLineFiles";
            this.titleLineFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineFiles.Size = new System.Drawing.Size(3, 28);
            this.titleLineFiles.TabIndex = 3;
            this.titleLineFiles.TabStop = false;
            this.titleLineFiles.Text = "";
            this.titleLineFiles.Visible = false;
            // 
            // titleLineMovies
            // 
            this.titleLineMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLineMovies.BackColor = System.Drawing.Color.Transparent;
            this.titleLineMovies.BorderColor = System.Drawing.Color.White;
            this.titleLineMovies.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineMovies.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineMovies.DesignerSelected = false;
            this.titleLineMovies.DimFactorClick = 0;
            this.titleLineMovies.DimFactorHover = 0;
            this.titleLineMovies.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineMovies.ImageIndex = 0;
            this.titleLineMovies.Location = new System.Drawing.Point(176, 21);
            this.titleLineMovies.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.titleLineMovies.Name = "titleLineMovies";
            this.titleLineMovies.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineMovies.Size = new System.Drawing.Size(3, 28);
            this.titleLineMovies.TabIndex = 2;
            this.titleLineMovies.TabStop = false;
            this.titleLineMovies.Text = "";
            // 
            // titleFiles
            // 
            this.titleFiles.AutoSize = true;
            this.titleFiles.BackColor = System.Drawing.Color.Transparent;
            this.titleFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFiles.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.titleFiles.ForeColor = System.Drawing.Color.White;
            this.titleFiles.Location = new System.Drawing.Point(42, 63);
            this.titleFiles.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleFiles.Name = "titleFiles";
            this.titleFiles.Size = new System.Drawing.Size(38, 20);
            this.titleFiles.TabIndex = 1;
            this.titleFiles.Text = "Files";
            this.titleFiles.Click += new System.EventHandler(this.imgFiles_Click);
            // 
            // titleMovies
            // 
            this.titleMovies.AutoSize = true;
            this.titleMovies.BackColor = System.Drawing.Color.Transparent;
            this.titleMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleMovies.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.titleMovies.ForeColor = System.Drawing.Color.White;
            this.titleMovies.Location = new System.Drawing.Point(42, 24);
            this.titleMovies.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleMovies.Name = "titleMovies";
            this.titleMovies.Size = new System.Drawing.Size(56, 20);
            this.titleMovies.TabIndex = 0;
            this.titleMovies.Text = "Movies";
            this.titleMovies.Click += new System.EventHandler(this.imgMovies_Click);
            // 
            // imgSettings
            // 
            this.imgSettings.BackColor = System.Drawing.Color.Transparent;
            this.imgSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSettings.Image = global::OpenTheatre.Properties.Resources.settings;
            this.imgSettings.Location = new System.Drawing.Point(17, 233);
            this.imgSettings.Name = "imgSettings";
            this.imgSettings.Size = new System.Drawing.Size(22, 22);
            this.imgSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSettings.TabIndex = 17;
            this.imgSettings.TabStop = false;
            this.imgSettings.Click += new System.EventHandler(this.imgSettings_Click);
            // 
            // imgBookmarks
            // 
            this.imgBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.imgBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBookmarks.Image = global::OpenTheatre.Properties.Resources.bookmark;
            this.imgBookmarks.Location = new System.Drawing.Point(17, 101);
            this.imgBookmarks.Name = "imgBookmarks";
            this.imgBookmarks.Size = new System.Drawing.Size(22, 22);
            this.imgBookmarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBookmarks.TabIndex = 13;
            this.imgBookmarks.TabStop = false;
            this.imgBookmarks.Click += new System.EventHandler(this.imgBookmarks_Click);
            // 
            // imgDownloads
            // 
            this.imgDownloads.BackColor = System.Drawing.Color.Transparent;
            this.imgDownloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDownloads.Image = global::OpenTheatre.Properties.Resources.file_download;
            this.imgDownloads.Location = new System.Drawing.Point(17, 140);
            this.imgDownloads.Name = "imgDownloads";
            this.imgDownloads.Size = new System.Drawing.Size(22, 22);
            this.imgDownloads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDownloads.TabIndex = 11;
            this.imgDownloads.TabStop = false;
            this.imgDownloads.Click += new System.EventHandler(this.imgDownloads_Click);
            // 
            // imgAbout
            // 
            this.imgAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAbout.Image = global::OpenTheatre.Properties.Resources.info;
            this.imgAbout.Location = new System.Drawing.Point(17, 272);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(22, 22);
            this.imgAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAbout.TabIndex = 8;
            this.imgAbout.TabStop = false;
            this.imgAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // imgFiles
            // 
            this.imgFiles.BackColor = System.Drawing.Color.Transparent;
            this.imgFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFiles.Image = global::OpenTheatre.Properties.Resources.folder;
            this.imgFiles.Location = new System.Drawing.Point(17, 63);
            this.imgFiles.Name = "imgFiles";
            this.imgFiles.Size = new System.Drawing.Size(22, 22);
            this.imgFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFiles.TabIndex = 5;
            this.imgFiles.TabStop = false;
            this.imgFiles.Click += new System.EventHandler(this.imgFiles_Click);
            // 
            // imgMovies
            // 
            this.imgMovies.BackColor = System.Drawing.Color.Transparent;
            this.imgMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMovies.Image = global::OpenTheatre.Properties.Resources.local_movies;
            this.imgMovies.Location = new System.Drawing.Point(17, 23);
            this.imgMovies.Name = "imgMovies";
            this.imgMovies.Size = new System.Drawing.Size(22, 22);
            this.imgMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMovies.TabIndex = 4;
            this.imgMovies.TabStop = false;
            this.imgMovies.Click += new System.EventHandler(this.imgMovies_Click);
            // 
            // imgSpinnerGIF
            // 
            this.imgSpinnerGIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgSpinnerGIF.BackColor = System.Drawing.Color.Transparent;
            this.imgSpinnerGIF.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinnerGIF.Image")));
            this.imgSpinnerGIF.Location = new System.Drawing.Point(423, 248);
            this.imgSpinnerGIF.Name = "imgSpinnerGIF";
            this.imgSpinnerGIF.Size = new System.Drawing.Size(22, 22);
            this.imgSpinnerGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSpinnerGIF.TabIndex = 8;
            this.imgSpinnerGIF.TabStop = false;
            this.imgSpinnerGIF.Visible = false;
            // 
            // btnSearchMovies
            // 
            this.btnSearchMovies.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchMovies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchMovies.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchMovies.Corners.LowerRight = 2;
            this.btnSearchMovies.Corners.UpperRight = 2;
            this.btnSearchMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMovies.DesignerSelected = false;
            this.btnSearchMovies.DimFactorClick = 0;
            this.btnSearchMovies.DimFactorHover = 0;
            this.btnSearchMovies.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearchMovies.FocalPoints.CenterPtX = 0F;
            this.btnSearchMovies.FocalPoints.CenterPtY = 0F;
            this.btnSearchMovies.Image = global::OpenTheatre.Properties.Resources.search;
            this.btnSearchMovies.ImageIndex = 0;
            this.btnSearchMovies.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearchMovies.Location = new System.Drawing.Point(376, 13);
            this.btnSearchMovies.Name = "btnSearchMovies";
            this.btnSearchMovies.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearchMovies.Size = new System.Drawing.Size(36, 36);
            this.btnSearchMovies.TabIndex = 1;
            this.btnSearchMovies.Text = "";
            this.btnSearchMovies.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearchMovies_ClickButtonArea);
            // 
            // btnMoviesGenre
            // 
            this.btnMoviesGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoviesGenre.BackColor = System.Drawing.Color.Transparent;
            this.btnMoviesGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMoviesGenre.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMoviesGenre.Corners.All = 2;
            this.btnMoviesGenre.Corners.LowerLeft = 2;
            this.btnMoviesGenre.Corners.LowerRight = 2;
            this.btnMoviesGenre.Corners.UpperLeft = 2;
            this.btnMoviesGenre.Corners.UpperRight = 2;
            this.btnMoviesGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoviesGenre.DesignerSelected = false;
            this.btnMoviesGenre.DimFactorClick = 0;
            this.btnMoviesGenre.DimFactorHover = 0;
            this.btnMoviesGenre.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnMoviesGenre.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnMoviesGenre.ForeColor = System.Drawing.Color.Black;
            this.btnMoviesGenre.ImageIndex = 0;
            this.btnMoviesGenre.Location = new System.Drawing.Point(0, 0);
            this.btnMoviesGenre.Name = "btnMoviesGenre";
            this.btnMoviesGenre.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnMoviesGenre.SideImage = ((System.Drawing.Image)(resources.GetObject("btnMoviesGenre.SideImage")));
            this.btnMoviesGenre.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoviesGenre.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnMoviesGenre.Size = new System.Drawing.Size(109, 36);
            this.btnMoviesGenre.TabIndex = 2;
            this.btnMoviesGenre.Text = "Genre : Any";
            this.btnMoviesGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMoviesGenre.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnMoviesGenre.TextShadowShow = false;
            this.btnMoviesGenre.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnMoviesGenre_ClickButtonArea);
            // 
            // btnMoviesYear
            // 
            this.btnMoviesYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoviesYear.BackColor = System.Drawing.Color.Transparent;
            this.btnMoviesYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMoviesYear.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMoviesYear.Corners.All = 2;
            this.btnMoviesYear.Corners.LowerLeft = 2;
            this.btnMoviesYear.Corners.LowerRight = 2;
            this.btnMoviesYear.Corners.UpperLeft = 2;
            this.btnMoviesYear.Corners.UpperRight = 2;
            this.btnMoviesYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoviesYear.DesignerSelected = false;
            this.btnMoviesYear.DimFactorClick = 0;
            this.btnMoviesYear.DimFactorHover = 0;
            this.btnMoviesYear.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnMoviesYear.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnMoviesYear.ForeColor = System.Drawing.Color.Black;
            this.btnMoviesYear.ImageIndex = 0;
            this.btnMoviesYear.Location = new System.Drawing.Point(0, 0);
            this.btnMoviesYear.Name = "btnMoviesYear";
            this.btnMoviesYear.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnMoviesYear.SideImage = ((System.Drawing.Image)(resources.GetObject("btnMoviesYear.SideImage")));
            this.btnMoviesYear.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoviesYear.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnMoviesYear.Size = new System.Drawing.Size(98, 36);
            this.btnMoviesYear.TabIndex = 3;
            this.btnMoviesYear.Text = "Year : Any";
            this.btnMoviesYear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMoviesYear.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnMoviesYear.TextShadowShow = false;
            this.btnMoviesYear.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnMoviesYear_ClickButtonArea);
            // 
            // btnFilesSort
            // 
            this.btnFilesSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilesSort.BackColor = System.Drawing.Color.Transparent;
            this.btnFilesSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesSort.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesSort.Corners.All = 2;
            this.btnFilesSort.Corners.LowerLeft = 2;
            this.btnFilesSort.Corners.LowerRight = 2;
            this.btnFilesSort.Corners.UpperLeft = 2;
            this.btnFilesSort.Corners.UpperRight = 2;
            this.btnFilesSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilesSort.DesignerSelected = false;
            this.btnFilesSort.DimFactorClick = 0;
            this.btnFilesSort.DimFactorHover = 0;
            this.btnFilesSort.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnFilesSort.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnFilesSort.ForeColor = System.Drawing.Color.Black;
            this.btnFilesSort.ImageIndex = 0;
            this.btnFilesSort.Location = new System.Drawing.Point(0, 0);
            this.btnFilesSort.Name = "btnFilesSort";
            this.btnFilesSort.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFilesSort.SideImage = ((System.Drawing.Image)(resources.GetObject("btnFilesSort.SideImage")));
            this.btnFilesSort.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilesSort.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnFilesSort.Size = new System.Drawing.Size(95, 36);
            this.btnFilesSort.TabIndex = 2;
            this.btnFilesSort.Text = "Sort : Any";
            this.btnFilesSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilesSort.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnFilesSort.TextShadowShow = false;
            this.btnFilesSort.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFilesSort_ClickButtonArea);
            // 
            // btnFilesFormat
            // 
            this.btnFilesFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilesFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnFilesFormat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesFormat.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesFormat.Corners.All = 2;
            this.btnFilesFormat.Corners.LowerLeft = 2;
            this.btnFilesFormat.Corners.LowerRight = 2;
            this.btnFilesFormat.Corners.UpperLeft = 2;
            this.btnFilesFormat.Corners.UpperRight = 2;
            this.btnFilesFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilesFormat.DesignerSelected = false;
            this.btnFilesFormat.DimFactorClick = 0;
            this.btnFilesFormat.DimFactorHover = 0;
            this.btnFilesFormat.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnFilesFormat.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnFilesFormat.ForeColor = System.Drawing.Color.Black;
            this.btnFilesFormat.ImageIndex = 0;
            this.btnFilesFormat.Location = new System.Drawing.Point(0, 0);
            this.btnFilesFormat.Name = "btnFilesFormat";
            this.btnFilesFormat.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFilesFormat.SideImage = ((System.Drawing.Image)(resources.GetObject("btnFilesFormat.SideImage")));
            this.btnFilesFormat.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilesFormat.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnFilesFormat.Size = new System.Drawing.Size(115, 36);
            this.btnFilesFormat.TabIndex = 3;
            this.btnFilesFormat.Text = "Format : Any";
            this.btnFilesFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilesFormat.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnFilesFormat.TextShadowShow = false;
            this.btnFilesFormat.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFilesFileType_ClickButtonArea);
            // 
            // btnFilesHost
            // 
            this.btnFilesHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilesHost.BackColor = System.Drawing.Color.Transparent;
            this.btnFilesHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesHost.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesHost.Corners.All = 2;
            this.btnFilesHost.Corners.LowerLeft = 2;
            this.btnFilesHost.Corners.LowerRight = 2;
            this.btnFilesHost.Corners.UpperLeft = 2;
            this.btnFilesHost.Corners.UpperRight = 2;
            this.btnFilesHost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilesHost.DesignerSelected = false;
            this.btnFilesHost.DimFactorClick = 0;
            this.btnFilesHost.DimFactorHover = 0;
            this.btnFilesHost.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnFilesHost.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnFilesHost.ForeColor = System.Drawing.Color.Black;
            this.btnFilesHost.ImageIndex = 0;
            this.btnFilesHost.Location = new System.Drawing.Point(0, 0);
            this.btnFilesHost.Name = "btnFilesHost";
            this.btnFilesHost.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFilesHost.SideImage = ((System.Drawing.Image)(resources.GetObject("btnFilesHost.SideImage")));
            this.btnFilesHost.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilesHost.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnFilesHost.Size = new System.Drawing.Size(100, 36);
            this.btnFilesHost.TabIndex = 4;
            this.btnFilesHost.Text = "Host : Any";
            this.btnFilesHost.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilesHost.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnFilesHost.TextShadowShow = false;
            this.btnFilesHost.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFilesHost_ClickButtonArea);
            // 
            // btnFilesQuality
            // 
            this.btnFilesQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilesQuality.BackColor = System.Drawing.Color.Transparent;
            this.btnFilesQuality.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesQuality.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilesQuality.Corners.All = 2;
            this.btnFilesQuality.Corners.LowerLeft = 2;
            this.btnFilesQuality.Corners.LowerRight = 2;
            this.btnFilesQuality.Corners.UpperLeft = 2;
            this.btnFilesQuality.Corners.UpperRight = 2;
            this.btnFilesQuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilesQuality.DesignerSelected = false;
            this.btnFilesQuality.DimFactorClick = 0;
            this.btnFilesQuality.DimFactorHover = 0;
            this.btnFilesQuality.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnFilesQuality.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnFilesQuality.ForeColor = System.Drawing.Color.Black;
            this.btnFilesQuality.ImageIndex = 0;
            this.btnFilesQuality.Location = new System.Drawing.Point(0, 0);
            this.btnFilesQuality.Name = "btnFilesQuality";
            this.btnFilesQuality.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnFilesQuality.SideImage = global::OpenTheatre.Properties.Resources.arrow_drop_down_black;
            this.btnFilesQuality.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilesQuality.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnFilesQuality.Size = new System.Drawing.Size(115, 36);
            this.btnFilesQuality.TabIndex = 2;
            this.btnFilesQuality.Text = "Quality : Any";
            this.btnFilesQuality.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilesQuality.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnFilesQuality.TextShadowShow = false;
            this.btnFilesQuality.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnFilesQuality_ClickButtonArea);
            // 
            // btnSearchFiles
            // 
            this.btnSearchFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchFiles.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchFiles.Corners.LowerRight = 2;
            this.btnSearchFiles.Corners.UpperRight = 2;
            this.btnSearchFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFiles.DesignerSelected = false;
            this.btnSearchFiles.DimFactorClick = 0;
            this.btnSearchFiles.DimFactorHover = 0;
            this.btnSearchFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearchFiles.FocalPoints.CenterPtX = 0F;
            this.btnSearchFiles.FocalPoints.CenterPtY = 0F;
            this.btnSearchFiles.Image = global::OpenTheatre.Properties.Resources.search;
            this.btnSearchFiles.ImageIndex = 0;
            this.btnSearchFiles.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearchFiles.Location = new System.Drawing.Point(376, 13);
            this.btnSearchFiles.Name = "btnSearchFiles";
            this.btnSearchFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearchFiles.Size = new System.Drawing.Size(36, 36);
            this.btnSearchFiles.TabIndex = 1;
            this.btnSearchFiles.Text = "";
            this.btnSearchFiles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearchFiles_ClickButtonArea);
            // 
            // btnBookmarksSort
            // 
            this.btnBookmarksSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookmarksSort.BackColor = System.Drawing.Color.Transparent;
            this.btnBookmarksSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBookmarksSort.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBookmarksSort.Corners.All = 2;
            this.btnBookmarksSort.Corners.LowerLeft = 2;
            this.btnBookmarksSort.Corners.LowerRight = 2;
            this.btnBookmarksSort.Corners.UpperLeft = 2;
            this.btnBookmarksSort.Corners.UpperRight = 2;
            this.btnBookmarksSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookmarksSort.DesignerSelected = false;
            this.btnBookmarksSort.DimFactorClick = 0;
            this.btnBookmarksSort.DimFactorHover = 0;
            this.btnBookmarksSort.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnBookmarksSort.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnBookmarksSort.ForeColor = System.Drawing.Color.Black;
            this.btnBookmarksSort.ImageIndex = 0;
            this.btnBookmarksSort.Location = new System.Drawing.Point(0, 0);
            this.btnBookmarksSort.Name = "btnBookmarksSort";
            this.btnBookmarksSort.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnBookmarksSort.SideImage = ((System.Drawing.Image)(resources.GetObject("btnBookmarksSort.SideImage")));
            this.btnBookmarksSort.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookmarksSort.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnBookmarksSort.Size = new System.Drawing.Size(168, 36);
            this.btnBookmarksSort.TabIndex = 2;
            this.btnBookmarksSort.Text = "Sort : Recently Added";
            this.btnBookmarksSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookmarksSort.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnBookmarksSort.TextShadowShow = false;
            this.btnBookmarksSort.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnBookmarksSort_ClickButtonArea);
            // 
            // btnBookmarksType
            // 
            this.btnBookmarksType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookmarksType.BackColor = System.Drawing.Color.Transparent;
            this.btnBookmarksType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBookmarksType.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBookmarksType.Corners.All = 2;
            this.btnBookmarksType.Corners.LowerLeft = 2;
            this.btnBookmarksType.Corners.LowerRight = 2;
            this.btnBookmarksType.Corners.UpperLeft = 2;
            this.btnBookmarksType.Corners.UpperRight = 2;
            this.btnBookmarksType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookmarksType.DesignerSelected = false;
            this.btnBookmarksType.DimFactorClick = 0;
            this.btnBookmarksType.DimFactorHover = 0;
            this.btnBookmarksType.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnBookmarksType.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.btnBookmarksType.ForeColor = System.Drawing.Color.Black;
            this.btnBookmarksType.ImageIndex = 0;
            this.btnBookmarksType.Location = new System.Drawing.Point(0, 0);
            this.btnBookmarksType.Name = "btnBookmarksType";
            this.btnBookmarksType.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnBookmarksType.SideImage = ((System.Drawing.Image)(resources.GetObject("btnBookmarksType.SideImage")));
            this.btnBookmarksType.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookmarksType.SideImageSize = new System.Drawing.Size(20, 20);
            this.btnBookmarksType.Size = new System.Drawing.Size(98, 36);
            this.btnBookmarksType.TabIndex = 3;
            this.btnBookmarksType.Text = "Type : Any";
            this.btnBookmarksType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookmarksType.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnBookmarksType.TextShadowShow = false;
            this.btnBookmarksType.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnBookmarksType_ClickButtonArea);
            // 
            // btnSearchBookmarks
            // 
            this.btnSearchBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBookmarks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchBookmarks.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchBookmarks.Corners.LowerRight = 2;
            this.btnSearchBookmarks.Corners.UpperRight = 2;
            this.btnSearchBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBookmarks.DesignerSelected = false;
            this.btnSearchBookmarks.DimFactorClick = 0;
            this.btnSearchBookmarks.DimFactorHover = 0;
            this.btnSearchBookmarks.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearchBookmarks.FocalPoints.CenterPtX = 0F;
            this.btnSearchBookmarks.FocalPoints.CenterPtY = 0F;
            this.btnSearchBookmarks.ForeColor = System.Drawing.Color.Black;
            this.btnSearchBookmarks.Image = global::OpenTheatre.Properties.Resources.search;
            this.btnSearchBookmarks.ImageIndex = 0;
            this.btnSearchBookmarks.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearchBookmarks.Location = new System.Drawing.Point(376, 13);
            this.btnSearchBookmarks.Name = "btnSearchBookmarks";
            this.btnSearchBookmarks.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearchBookmarks.Size = new System.Drawing.Size(36, 36);
            this.btnSearchBookmarks.TabIndex = 12;
            this.btnSearchBookmarks.Text = "";
            this.btnSearchBookmarks.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearchBookmarks_ClickButtonArea);
            // 
            // imgSettingsDownloadsDirectory
            // 
            this.imgSettingsDownloadsDirectory.BackColor = System.Drawing.Color.Transparent;
            this.imgSettingsDownloadsDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSettingsDownloadsDirectory.Image = global::OpenTheatre.Properties.Resources.folder;
            this.imgSettingsDownloadsDirectory.Location = new System.Drawing.Point(579, 153);
            this.imgSettingsDownloadsDirectory.Name = "imgSettingsDownloadsDirectory";
            this.imgSettingsDownloadsDirectory.Size = new System.Drawing.Size(25, 25);
            this.imgSettingsDownloadsDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSettingsDownloadsDirectory.TabIndex = 18;
            this.imgSettingsDownloadsDirectory.TabStop = false;
            this.imgSettingsDownloadsDirectory.Click += new System.EventHandler(this.imgSettingsDownloadsDirectory_Click);
            // 
            // imgCloseAbout
            // 
            this.imgCloseAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgCloseAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseAbout.Image = ((System.Drawing.Image)(resources.GetObject("imgCloseAbout.Image")));
            this.imgCloseAbout.Location = new System.Drawing.Point(813, 25);
            this.imgCloseAbout.Margin = new System.Windows.Forms.Padding(3, 25, 25, 3);
            this.imgCloseAbout.Name = "imgCloseAbout";
            this.imgCloseAbout.Size = new System.Drawing.Size(32, 32);
            this.imgCloseAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCloseAbout.TabIndex = 6;
            this.imgCloseAbout.TabStop = false;
            this.imgCloseAbout.Click += new System.EventHandler(this.imgCloseAbout_Click);
            // 
            // imgHeaderAbout
            // 
            this.imgHeaderAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgHeaderAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgHeaderAbout.Image = ((System.Drawing.Image)(resources.GetObject("imgHeaderAbout.Image")));
            this.imgHeaderAbout.Location = new System.Drawing.Point(316, 22);
            this.imgHeaderAbout.Name = "imgHeaderAbout";
            this.imgHeaderAbout.Size = new System.Drawing.Size(204, 52);
            this.imgHeaderAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeaderAbout.TabIndex = 5;
            this.imgHeaderAbout.TabStop = false;
            // 
            // frmOpenTheatre
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1048, 518);
            this.Controls.Add(this.panelTitles);
            this.Controls.Add(this.tab);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmOpenTheatre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTheatre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpenTheatre_FormClosing);
            this.Load += new System.EventHandler(this.frmOpenTheatre_Load);
            this.tab.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            this.panelMovieFilters.ResumeLayout(false);
            this.panelMoviesGenre.ResumeLayout(false);
            this.panelMoviesYear.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabFiles.PerformLayout();
            this.panelFileFilters.ResumeLayout(false);
            this.panelFilesSort.ResumeLayout(false);
            this.panelFilesFormat.ResumeLayout(false);
            this.panelFilesHost.ResumeLayout(false);
            this.panelFilesQuality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.tabBookmarks.ResumeLayout(false);
            this.tabBookmarks.PerformLayout();
            this.panelBookmarksFilters.ResumeLayout(false);
            this.panelBookmarksSort.ResumeLayout(false);
            this.panelBookmarksType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookmarks)).EndInit();
            this.tabDownloads.ResumeLayout(false);
            this.tabDownloads.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.panelTitles.ResumeLayout(false);
            this.panelTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBookmarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinnerGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettingsDownloadsDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.PictureBox imgCloseAbout;
        private System.Windows.Forms.PictureBox imgHeaderAbout;
        private System.Windows.Forms.Label lblAboutText;
        private System.Windows.Forms.Label lblAboutSubText;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.Label btnAboutReportIssue;
        public System.Windows.Forms.TabPage tabMovies;
        private ChreneLib.Controls.TextBoxes.CTextBox txtMoviesSearchBox;
        private CButtonLib.CButton btnSearchMovies;
        private CButtonLib.CButton bgMoviesSearchBox;
        private System.Windows.Forms.Panel panelTitles;
        private System.Windows.Forms.PictureBox imgFiles;
        private System.Windows.Forms.PictureBox imgMovies;
        private CButtonLib.CButton titleLineFiles;
        private CButtonLib.CButton titleLineMovies;
        private System.Windows.Forms.Label titleFiles;
        private System.Windows.Forms.Label titleMovies;
        private System.Windows.Forms.FlowLayoutPanel panelMovies;
        public System.Windows.Forms.TabControl tab;
        public System.Windows.Forms.TabPage tabBlank;
        private ChreneLib.Controls.TextBoxes.CTextBox txtFilesSearchBox;
        private CButtonLib.CButton btnSearchFiles;
        private CButtonLib.CButton bgFilesSearchBox;
        private System.Windows.Forms.PictureBox imgAbout;
        private CButtonLib.CButton titleLineAbout;
        private System.Windows.Forms.Label titleAbout;
        private System.Windows.Forms.Panel panelMoviesGenre;
        private CButtonLib.CButton btnMoviesGenre;
        private System.Windows.Forms.ComboBox cmboBoxMoviesGenre;
        private System.Windows.Forms.FlowLayoutPanel panelMovieFilters;
        private System.Windows.Forms.PictureBox imgDownloads;
        private CButtonLib.CButton titleLineDownloads;
        private System.Windows.Forms.Label titleDownloads;
        private System.Windows.Forms.TabPage tabDownloads;
        private System.Windows.Forms.Label lblNoDownloads;
        private CButtonLib.CButton titleFilesAnime;
        private CButtonLib.CButton titleFilesMovies;
        private CButtonLib.CButton titleFilesSplitter;
        private CButtonLib.CButton titleFilesSeries;
        private System.Windows.Forms.PictureBox imgSpinnerGIF;
        private CButtonLib.CButton titleFilesTorrents;
        private CButtonLib.CButton titleFilesSubtitles;
        private System.Windows.Forms.Panel panelMoviesYear;
        private CButtonLib.CButton btnMoviesYear;
        private System.Windows.Forms.ComboBox cmboBoxMoviesYear;
        private System.Windows.Forms.FlowLayoutPanel panelFileFilters;
        private System.Windows.Forms.Panel panelFilesFormat;
        private CButtonLib.CButton btnFilesFormat;
        private System.Windows.Forms.ComboBox cmboBoxFilesFormat;
        private System.Windows.Forms.Panel panelFilesHost;
        private CButtonLib.CButton btnFilesHost;
        private System.Windows.Forms.ComboBox cmboBoxFilesHost;
        public System.Windows.Forms.FlowLayoutPanel panelDownloads;
        private System.Windows.Forms.Panel panelFilesQuality;
        private CButtonLib.CButton btnFilesQuality;
        private System.Windows.Forms.ComboBox cmboBoxFilesQuality;
        private System.Windows.Forms.PictureBox imgBookmarks;
        private System.Windows.Forms.Label titleBookmarks;
        private System.Windows.Forms.TabPage tabBookmarks;
        private System.Windows.Forms.FlowLayoutPanel panelBookmarksFilters;
        private System.Windows.Forms.Panel panelBookmarksType;
        private CButtonLib.CButton btnBookmarksType;
        private System.Windows.Forms.ComboBox cmboBoxBookmarksType;
        private ChreneLib.Controls.TextBoxes.CTextBox txtBookmarksSearchBox;
        private System.Windows.Forms.DataGridView dataGridBookmarks;
        private CButtonLib.CButton btnSearchBookmarks;
        private CButtonLib.CButton bgBookmarksSearchBox;
        private CButtonLib.CButton titleLineBookmarks;
        private System.Windows.Forms.Panel panelBookmarksSort;
        private CButtonLib.CButton btnBookmarksSort;
        private System.Windows.Forms.ComboBox cmboBoxBookmarksSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookmarksType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookmarksFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookmarksFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookmarksHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookmarksURL;
        private System.Windows.Forms.Panel panelFilesSort;
        private CButtonLib.CButton btnFilesSort;
        private System.Windows.Forms.ComboBox cmboBoxFilesSort;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.PictureBox imgSettings;
        private CButtonLib.CButton titleLineSettings;
        private System.Windows.Forms.Label titleSettings;
        private System.Windows.Forms.Label lblSettingsGeneralClearDataOnClose;
        private System.Windows.Forms.CheckBox chkSettingsClearData;
        private ChreneLib.Controls.TextBoxes.CTextBox txtBoxSettingsConnectionPassword;
        private CButtonLib.CButton bgSettingsConnectionPassword;
        private System.Windows.Forms.Label lblSettingsConnectionPassword;
        private ChreneLib.Controls.TextBoxes.CTextBox txtBoxSettingsConnectionUsername;
        private CButtonLib.CButton bgSettingsConnectionUsername;
        private System.Windows.Forms.Label lblSettingsConnectionUsername;
        private ChreneLib.Controls.TextBoxes.CTextBox txtBoxSettingsConnectionPort;
        private CButtonLib.CButton bgSettingsConnectionPort;
        private System.Windows.Forms.Label lblSettingsConnectionPort;
        private ChreneLib.Controls.TextBoxes.CTextBox txtBoxSettingsConnectionHost;
        private CButtonLib.CButton bgSettingsConnectionHost;
        private System.Windows.Forms.Label lblSettingsConnectionHost;
        private System.Windows.Forms.Label titleSettingsConnection;
        private System.Windows.Forms.Label titleSettingsGeneral;
        private System.Windows.Forms.Label lblSettingsConnectionCustom;
        private System.Windows.Forms.CheckBox chkSettingsCustomConnection;
        private CButtonLib.CButton btnSettingsSave;
        private CButtonLib.CButton btnSettingsRestoreDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesURL;
        private System.Windows.Forms.TabPage tabHistory;
        private CButtonLib.CButton titleFilesArchives;
        private System.Windows.Forms.Label label2;
        private ChreneLib.Controls.TextBoxes.CTextBox txtBoxSettingsDownloadsDirectory;
        private CButtonLib.CButton bgSettingsDownloadsDirectory;
        private System.Windows.Forms.Label lblSettingsDownloadsDirectory;
        private System.Windows.Forms.PictureBox imgSettingsDownloadsDirectory;
    }
}

