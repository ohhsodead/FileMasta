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
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.panelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMoviesSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bgMoviesSearchBox = new CButtonLib.CButton();
            this.panelMovieFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMoviesGenre = new System.Windows.Forms.Panel();
            this.cmboBoxMoviesGenre = new System.Windows.Forms.ComboBox();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.txtFilesSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgFilesSearchBox = new CButtonLib.CButton();
            this.tabDownloads = new System.Windows.Forms.TabPage();
            this.lblNoDownloads = new System.Windows.Forms.Label();
            this.panelDownloads = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBlank = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.btnAboutReportIssue = new System.Windows.Forms.Label();
            this.lblAboutSubText = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.panelTitles = new System.Windows.Forms.Panel();
            this.titleLineDownloads = new CButtonLib.CButton();
            this.titleDownloads = new System.Windows.Forms.Label();
            this.titleLineAbout = new CButtonLib.CButton();
            this.titleAbout = new System.Windows.Forms.Label();
            this.titleLineFiles = new CButtonLib.CButton();
            this.titleLineMovies = new CButtonLib.CButton();
            this.titleFiles = new System.Windows.Forms.Label();
            this.titleMovies = new System.Windows.Forms.Label();
            this.imgDownloads = new System.Windows.Forms.PictureBox();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.imgFiles = new System.Windows.Forms.PictureBox();
            this.imgMovies = new System.Windows.Forms.PictureBox();
            this.btnSearchMovies = new CButtonLib.CButton();
            this.btnMoviesGenre = new CButtonLib.CButton();
            this.btnSearchFiles = new CButtonLib.CButton();
            this.imgCloseAbout = new System.Windows.Forms.PictureBox();
            this.imgHeaderAbout = new System.Windows.Forms.PictureBox();
            this.tab.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.panelMovieFilters.SuspendLayout();
            this.panelMoviesGenre.SuspendLayout();
            this.tabFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabDownloads.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.panelTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovies)).BeginInit();
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
            this.tab.Controls.Add(this.tabDownloads);
            this.tab.Controls.Add(this.tabBlank);
            this.tab.Controls.Add(this.tabAbout);
            this.tab.Location = new System.Drawing.Point(160, -22);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(860, 544);
            this.tab.TabIndex = 0;
            this.tab.TabStop = false;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabMovies
            // 
            this.tabMovies.AllowDrop = true;
            this.tabMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMovies.Controls.Add(this.panelMovies);
            this.tabMovies.Controls.Add(this.txtMoviesSearchBox);
            this.tabMovies.Controls.Add(this.btnSearchMovies);
            this.tabMovies.Controls.Add(this.bgMoviesSearchBox);
            this.tabMovies.Controls.Add(this.panelMovieFilters);
            this.tabMovies.ForeColor = System.Drawing.Color.White;
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(852, 518);
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
            this.panelMovies.Size = new System.Drawing.Size(852, 455);
            this.panelMovies.TabIndex = 2;
            this.panelMovies.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelMovies_Scroll);
            // 
            // txtMoviesSearchBox
            // 
            this.txtMoviesSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtMoviesSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoviesSearchBox.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtMoviesSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtMoviesSearchBox.Location = new System.Drawing.Point(22, 21);
            this.txtMoviesSearchBox.Name = "txtMoviesSearchBox";
            this.txtMoviesSearchBox.Size = new System.Drawing.Size(399, 20);
            this.txtMoviesSearchBox.TabIndex = 0;
            this.txtMoviesSearchBox.WaterMark = "Search movie title, people, years...";
            this.txtMoviesSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtMoviesSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtMoviesSearchBox.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // bgMoviesSearchBox
            // 
            this.bgMoviesSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgMoviesSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgMoviesSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.bgMoviesSearchBox.Size = new System.Drawing.Size(452, 36);
            this.bgMoviesSearchBox.TabIndex = 0;
            this.bgMoviesSearchBox.TabStop = false;
            this.bgMoviesSearchBox.Text = "";
            // 
            // panelMovieFilters
            // 
            this.panelMovieFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMovieFilters.Controls.Add(this.panelMoviesGenre);
            this.panelMovieFilters.Location = new System.Drawing.Point(474, 13);
            this.panelMovieFilters.Name = "panelMovieFilters";
            this.panelMovieFilters.Size = new System.Drawing.Size(366, 36);
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
            // tabFiles
            // 
            this.tabFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabFiles.Controls.Add(this.btnSearchFiles);
            this.tabFiles.Controls.Add(this.txtFilesSearchBox);
            this.tabFiles.Controls.Add(this.dataGrid);
            this.tabFiles.Controls.Add(this.bgFilesSearchBox);
            this.tabFiles.ForeColor = System.Drawing.Color.White;
            this.tabFiles.Location = new System.Drawing.Point(4, 22);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabFiles.Size = new System.Drawing.Size(852, 518);
            this.tabFiles.TabIndex = 1;
            // 
            // txtFilesSearchBox
            // 
            this.txtFilesSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtFilesSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilesSearchBox.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtFilesSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtFilesSearchBox.Location = new System.Drawing.Point(22, 21);
            this.txtFilesSearchBox.Name = "txtFilesSearchBox";
            this.txtFilesSearchBox.Size = new System.Drawing.Size(399, 20);
            this.txtFilesSearchBox.TabIndex = 0;
            this.txtFilesSearchBox.WaterMark = "Search file names, add some tags, insert a link...";
            this.txtFilesSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.txtFilesSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtFilesSearchBox.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
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
            this.columnFileName,
            this.columnType,
            this.columnHost,
            this.columnURL});
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 62);
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
            this.dataGrid.Size = new System.Drawing.Size(852, 456);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGrid_RowPrePaint);
            // 
            // columnFileName
            // 
            this.columnFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFileName.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnFileName.HeaderText = "File Name";
            this.columnFileName.Name = "columnFileName";
            this.columnFileName.ReadOnly = true;
            // 
            // columnType
            // 
            this.columnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnType.HeaderText = "Type";
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            this.columnType.Width = 58;
            // 
            // columnHost
            // 
            this.columnHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnHost.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnHost.HeaderText = "Host";
            this.columnHost.Name = "columnHost";
            this.columnHost.ReadOnly = true;
            this.columnHost.Width = 60;
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
            // bgFilesSearchBox
            // 
            this.bgFilesSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgFilesSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bgFilesSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.bgFilesSearchBox.Size = new System.Drawing.Size(452, 36);
            this.bgFilesSearchBox.TabIndex = 0;
            this.bgFilesSearchBox.TabStop = false;
            this.bgFilesSearchBox.Text = "";
            // 
            // tabDownloads
            // 
            this.tabDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabDownloads.Controls.Add(this.lblNoDownloads);
            this.tabDownloads.Controls.Add(this.panelDownloads);
            this.tabDownloads.ForeColor = System.Drawing.Color.White;
            this.tabDownloads.Location = new System.Drawing.Point(4, 22);
            this.tabDownloads.Name = "tabDownloads";
            this.tabDownloads.Size = new System.Drawing.Size(852, 518);
            this.tabDownloads.TabIndex = 4;
            // 
            // lblNoDownloads
            // 
            this.lblNoDownloads.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoDownloads.AutoSize = true;
            this.lblNoDownloads.BackColor = System.Drawing.Color.Transparent;
            this.lblNoDownloads.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblNoDownloads.ForeColor = System.Drawing.Color.White;
            this.lblNoDownloads.Location = new System.Drawing.Point(355, 247);
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
            this.panelDownloads.Size = new System.Drawing.Size(852, 518);
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
            this.tabBlank.Size = new System.Drawing.Size(852, 518);
            this.tabBlank.TabIndex = 3;
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
            this.tabAbout.Size = new System.Drawing.Size(852, 518);
            this.tabAbout.TabIndex = 2;
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAboutVersion.Location = new System.Drawing.Point(773, 496);
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
            this.lblAboutSubText.Location = new System.Drawing.Point(309, 484);
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
            this.lblAboutText.Location = new System.Drawing.Point(69, 178);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(715, 201);
            this.lblAboutText.TabIndex = 0;
            this.lblAboutText.Text = resources.GetString("lblAboutText.Text");
            this.lblAboutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitles
            // 
            this.panelTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
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
            this.panelTitles.Size = new System.Drawing.Size(164, 518);
            this.panelTitles.TabIndex = 1;
            // 
            // titleLineDownloads
            // 
            this.titleLineDownloads.BackColor = System.Drawing.Color.Transparent;
            this.titleLineDownloads.BorderColor = System.Drawing.Color.White;
            this.titleLineDownloads.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineDownloads.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineDownloads.DesignerSelected = false;
            this.titleLineDownloads.DimFactorClick = 0;
            this.titleLineDownloads.DimFactorHover = 0;
            this.titleLineDownloads.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineDownloads.ImageIndex = 0;
            this.titleLineDownloads.Location = new System.Drawing.Point(162, 101);
            this.titleLineDownloads.Name = "titleLineDownloads";
            this.titleLineDownloads.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineDownloads.Size = new System.Drawing.Size(2, 28);
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
            this.titleDownloads.Location = new System.Drawing.Point(42, 103);
            this.titleDownloads.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleDownloads.Name = "titleDownloads";
            this.titleDownloads.Size = new System.Drawing.Size(84, 20);
            this.titleDownloads.TabIndex = 9;
            this.titleDownloads.Text = "Downloads";
            this.titleDownloads.Click += new System.EventHandler(this.imgDownloads_Click);
            // 
            // titleLineAbout
            // 
            this.titleLineAbout.BackColor = System.Drawing.Color.Transparent;
            this.titleLineAbout.BorderColor = System.Drawing.Color.White;
            this.titleLineAbout.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineAbout.DesignerSelected = false;
            this.titleLineAbout.DimFactorClick = 0;
            this.titleLineAbout.DimFactorHover = 0;
            this.titleLineAbout.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineAbout.ImageIndex = 0;
            this.titleLineAbout.Location = new System.Drawing.Point(162, 244);
            this.titleLineAbout.Name = "titleLineAbout";
            this.titleLineAbout.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineAbout.Size = new System.Drawing.Size(2, 28);
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
            this.titleAbout.Location = new System.Drawing.Point(42, 246);
            this.titleAbout.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleAbout.Name = "titleAbout";
            this.titleAbout.Size = new System.Drawing.Size(50, 20);
            this.titleAbout.TabIndex = 6;
            this.titleAbout.Text = "About";
            this.titleAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // titleLineFiles
            // 
            this.titleLineFiles.BackColor = System.Drawing.Color.Transparent;
            this.titleLineFiles.BorderColor = System.Drawing.Color.White;
            this.titleLineFiles.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineFiles.DesignerSelected = false;
            this.titleLineFiles.DimFactorClick = 0;
            this.titleLineFiles.DimFactorHover = 0;
            this.titleLineFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineFiles.ImageIndex = 0;
            this.titleLineFiles.Location = new System.Drawing.Point(162, 62);
            this.titleLineFiles.Name = "titleLineFiles";
            this.titleLineFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineFiles.Size = new System.Drawing.Size(2, 28);
            this.titleLineFiles.TabIndex = 3;
            this.titleLineFiles.TabStop = false;
            this.titleLineFiles.Text = "";
            this.titleLineFiles.Visible = false;
            // 
            // titleLineMovies
            // 
            this.titleLineMovies.BackColor = System.Drawing.Color.Transparent;
            this.titleLineMovies.BorderColor = System.Drawing.Color.White;
            this.titleLineMovies.ColorFillSolid = System.Drawing.Color.White;
            this.titleLineMovies.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLineMovies.DesignerSelected = false;
            this.titleLineMovies.DimFactorClick = 0;
            this.titleLineMovies.DimFactorHover = 0;
            this.titleLineMovies.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleLineMovies.ImageIndex = 0;
            this.titleLineMovies.Location = new System.Drawing.Point(162, 22);
            this.titleLineMovies.Name = "titleLineMovies";
            this.titleLineMovies.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineMovies.Size = new System.Drawing.Size(2, 28);
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
            // imgDownloads
            // 
            this.imgDownloads.BackColor = System.Drawing.Color.Transparent;
            this.imgDownloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDownloads.Image = global::OpenPlex.Properties.Resources.download;
            this.imgDownloads.Location = new System.Drawing.Point(17, 102);
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
            this.imgAbout.Image = global::OpenPlex.Properties.Resources.information;
            this.imgAbout.Location = new System.Drawing.Point(17, 245);
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
            this.imgFiles.Image = global::OpenPlex.Properties.Resources.buffer;
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
            this.imgMovies.Image = global::OpenPlex.Properties.Resources.filmstrip;
            this.imgMovies.Location = new System.Drawing.Point(17, 23);
            this.imgMovies.Name = "imgMovies";
            this.imgMovies.Size = new System.Drawing.Size(22, 22);
            this.imgMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMovies.TabIndex = 4;
            this.imgMovies.TabStop = false;
            this.imgMovies.Click += new System.EventHandler(this.imgMovies_Click);
            // 
            // btnSearchMovies
            // 
            this.btnSearchMovies.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchMovies.ColorFillSolid = System.Drawing.Color.SteelBlue;
            this.btnSearchMovies.Corners.LowerRight = 2;
            this.btnSearchMovies.Corners.UpperRight = 2;
            this.btnSearchMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMovies.DesignerSelected = false;
            this.btnSearchMovies.DimFactorClick = 0;
            this.btnSearchMovies.DimFactorHover = 0;
            this.btnSearchMovies.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearchMovies.FocalPoints.CenterPtX = 0F;
            this.btnSearchMovies.FocalPoints.CenterPtY = 0F;
            this.btnSearchMovies.Image = global::OpenPlex.Properties.Resources.magnify;
            this.btnSearchMovies.ImageIndex = 0;
            this.btnSearchMovies.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearchMovies.Location = new System.Drawing.Point(429, 13);
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
            this.btnMoviesGenre.SideImage = global::OpenPlex.Properties.Resources.chevron_down;
            this.btnMoviesGenre.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoviesGenre.SideImageSize = new System.Drawing.Size(19, 19);
            this.btnMoviesGenre.Size = new System.Drawing.Size(109, 36);
            this.btnMoviesGenre.TabIndex = 2;
            this.btnMoviesGenre.Text = "Genre : Any";
            this.btnMoviesGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMoviesGenre.TextMargin = new System.Windows.Forms.Padding(10, 3, 2, 2);
            this.btnMoviesGenre.TextShadowShow = false;
            this.btnMoviesGenre.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnMoviesGenre_ClickButtonArea);
            // 
            // btnSearchFiles
            // 
            this.btnSearchFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFiles.ColorFillSolid = System.Drawing.Color.SteelBlue;
            this.btnSearchFiles.Corners.LowerRight = 2;
            this.btnSearchFiles.Corners.UpperRight = 2;
            this.btnSearchFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFiles.DesignerSelected = false;
            this.btnSearchFiles.DimFactorClick = 0;
            this.btnSearchFiles.DimFactorHover = 0;
            this.btnSearchFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearchFiles.FocalPoints.CenterPtX = 0F;
            this.btnSearchFiles.FocalPoints.CenterPtY = 0F;
            this.btnSearchFiles.Image = global::OpenPlex.Properties.Resources.magnify;
            this.btnSearchFiles.ImageIndex = 0;
            this.btnSearchFiles.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearchFiles.Location = new System.Drawing.Point(429, 13);
            this.btnSearchFiles.Name = "btnSearchFiles";
            this.btnSearchFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearchFiles.Size = new System.Drawing.Size(36, 36);
            this.btnSearchFiles.TabIndex = 1;
            this.btnSearchFiles.Text = "";
            this.btnSearchFiles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearchFiles_ClickButtonArea);
            // 
            // imgCloseAbout
            // 
            this.imgCloseAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCloseAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgCloseAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCloseAbout.Image = global::OpenPlex.Properties.Resources.close;
            this.imgCloseAbout.Location = new System.Drawing.Point(795, 25);
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
            this.imgHeaderAbout.Image = global::OpenPlex.Properties.Resources.openplex_text;
            this.imgHeaderAbout.Location = new System.Drawing.Point(324, 21);
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
            this.ClientSize = new System.Drawing.Size(1016, 518);
            this.Controls.Add(this.panelTitles);
            this.Controls.Add(this.tab);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmOpenPlex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPlex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOpenPlex_Load);
            this.tab.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            this.panelMovieFilters.ResumeLayout(false);
            this.panelMoviesGenre.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabDownloads.ResumeLayout(false);
            this.tabDownloads.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.panelTitles.ResumeLayout(false);
            this.panelTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDownloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.DataGridView dataGrid;
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
        private System.Windows.Forms.FlowLayoutPanel panelDownloads;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnURL;
    }
}

