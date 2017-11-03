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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenPlex));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.panelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMoviesSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btnSearchMovies = new CButtonLib.CButton();
            this.bgMoviesSearchBox = new CButtonLib.CButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMoviesGenre = new System.Windows.Forms.Panel();
            this.btnMoviesGenre = new CButtonLib.CButton();
            this.cmboBoxMoviesGenre = new System.Windows.Forms.ComboBox();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.txtFilesSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgFilesSearchBox = new CButtonLib.CButton();
            this.btnSearchFiles = new CButtonLib.CButton();
            this.tabBlank = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.btnAboutReportIssue = new System.Windows.Forms.Label();
            this.lblAboutSubText = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.imgCloseAbout = new System.Windows.Forms.PictureBox();
            this.imgHeaderAbout = new System.Windows.Forms.PictureBox();
            this.panelTitles = new System.Windows.Forms.Panel();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.titleLineAbout = new CButtonLib.CButton();
            this.titleAbout = new System.Windows.Forms.Label();
            this.imgFiles = new System.Windows.Forms.PictureBox();
            this.imgMovies = new System.Windows.Forms.PictureBox();
            this.titleLineFiles = new CButtonLib.CButton();
            this.titleLineMovies = new CButtonLib.CButton();
            this.titleFiles = new System.Windows.Forms.Label();
            this.titleMovies = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelMoviesGenre.SuspendLayout();
            this.tabFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).BeginInit();
            this.panelTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabMovies);
            this.tab.Controls.Add(this.tabFiles);
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
            this.tabMovies.Controls.Add(this.flowLayoutPanel1);
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
            this.btnSearchMovies.Image = global::OpenPlex.Properties.Resources.SearchIconH;
            this.btnSearchMovies.ImageIndex = 0;
            this.btnSearchMovies.ImageSize = new System.Drawing.Size(17, 17);
            this.btnSearchMovies.Location = new System.Drawing.Point(429, 13);
            this.btnSearchMovies.Name = "btnSearchMovies";
            this.btnSearchMovies.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearchMovies.Size = new System.Drawing.Size(36, 36);
            this.btnSearchMovies.TabIndex = 1;
            this.btnSearchMovies.Text = "";
            this.btnSearchMovies.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearchMovies_ClickButtonArea);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panelMoviesGenre);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(472, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 36);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.btnMoviesGenre.SideImage = global::OpenPlex.Properties.Resources.iconArrowDown;
            this.btnMoviesGenre.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoviesGenre.SideImageSize = new System.Drawing.Size(17, 10);
            this.btnMoviesGenre.Size = new System.Drawing.Size(109, 36);
            this.btnMoviesGenre.TabIndex = 2;
            this.btnMoviesGenre.Text = "Genre : Any";
            this.btnMoviesGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoviesGenre.TextMargin = new System.Windows.Forms.Padding(8, 3, 2, 2);
            this.btnMoviesGenre.TextShadowShow = false;
            this.btnMoviesGenre.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnMoviesGenre_ClickButtonArea);
            // 
            // cmboBoxMoviesGenre
            // 
            this.cmboBoxMoviesGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboBoxMoviesGenre.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cmboBoxMoviesGenre.FormattingEnabled = true;
            this.cmboBoxMoviesGenre.Items.AddRange(new object[] {
            "Any Genre",
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
            this.tabFiles.Controls.Add(this.txtFilesSearchBox);
            this.tabFiles.Controls.Add(this.dataGrid);
            this.tabFiles.Controls.Add(this.btnSearchFiles);
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
            this.columnHost,
            this.columnFileName,
            this.columnURL});
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 64);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.Size = new System.Drawing.Size(852, 454);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGrid_RowPrePaint);
            // 
            // columnHost
            // 
            this.columnHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnHost.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnHost.HeaderText = "Host";
            this.columnHost.Name = "columnHost";
            this.columnHost.ReadOnly = true;
            this.columnHost.Width = 60;
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
            // columnURL
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnURL.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.btnSearchFiles.Image = global::OpenPlex.Properties.Resources.SearchIconH;
            this.btnSearchFiles.ImageIndex = 0;
            this.btnSearchFiles.ImageSize = new System.Drawing.Size(17, 17);
            this.btnSearchFiles.Location = new System.Drawing.Point(429, 13);
            this.btnSearchFiles.Name = "btnSearchFiles";
            this.btnSearchFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearchFiles.Size = new System.Drawing.Size(36, 36);
            this.btnSearchFiles.TabIndex = 1;
            this.btnSearchFiles.Text = "";
            this.btnSearchFiles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearchFiles_ClickButtonArea);
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
            this.lblAboutVersion.Location = new System.Drawing.Point(707, 496);
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
            this.lblAboutSubText.Location = new System.Drawing.Point(276, 484);
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
            this.lblAboutText.Location = new System.Drawing.Point(64, 178);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(659, 201);
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
            this.imgCloseAbout.Location = new System.Drawing.Point(738, 25);
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
            this.imgHeaderAbout.Location = new System.Drawing.Point(291, 21);
            this.imgHeaderAbout.Name = "imgHeaderAbout";
            this.imgHeaderAbout.Size = new System.Drawing.Size(204, 30);
            this.imgHeaderAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeaderAbout.TabIndex = 5;
            this.imgHeaderAbout.TabStop = false;
            // 
            // panelTitles
            // 
            this.panelTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
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
            // imgAbout
            // 
            this.imgAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAbout.Image = global::OpenPlex.Properties.Resources.iconAbout;
            this.imgAbout.Location = new System.Drawing.Point(18, 246);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(18, 18);
            this.imgAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAbout.TabIndex = 8;
            this.imgAbout.TabStop = false;
            this.imgAbout.Click += new System.EventHandler(this.imgAbout_Click);
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
            this.titleLineAbout.Location = new System.Drawing.Point(162, 245);
            this.titleLineAbout.Name = "titleLineAbout";
            this.titleLineAbout.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineAbout.Size = new System.Drawing.Size(2, 24);
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
            this.titleAbout.Location = new System.Drawing.Point(41, 245);
            this.titleAbout.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleAbout.Name = "titleAbout";
            this.titleAbout.Size = new System.Drawing.Size(50, 20);
            this.titleAbout.TabIndex = 6;
            this.titleAbout.Text = "About";
            this.titleAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // imgFiles
            // 
            this.imgFiles.BackColor = System.Drawing.Color.Transparent;
            this.imgFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFiles.Image = global::OpenPlex.Properties.Resources.iconFiles;
            this.imgFiles.Location = new System.Drawing.Point(18, 64);
            this.imgFiles.Name = "imgFiles";
            this.imgFiles.Size = new System.Drawing.Size(18, 18);
            this.imgFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFiles.TabIndex = 5;
            this.imgFiles.TabStop = false;
            this.imgFiles.Click += new System.EventHandler(this.imgFiles_Click);
            // 
            // imgMovies
            // 
            this.imgMovies.BackColor = System.Drawing.Color.Transparent;
            this.imgMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMovies.Image = global::OpenPlex.Properties.Resources.iconMovies;
            this.imgMovies.Location = new System.Drawing.Point(18, 24);
            this.imgMovies.Name = "imgMovies";
            this.imgMovies.Size = new System.Drawing.Size(18, 18);
            this.imgMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMovies.TabIndex = 4;
            this.imgMovies.TabStop = false;
            this.imgMovies.Click += new System.EventHandler(this.imgMovies_Click);
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
            this.titleLineFiles.Location = new System.Drawing.Point(162, 63);
            this.titleLineFiles.Name = "titleLineFiles";
            this.titleLineFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineFiles.Size = new System.Drawing.Size(2, 24);
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
            this.titleLineMovies.Location = new System.Drawing.Point(162, 23);
            this.titleLineMovies.Name = "titleLineMovies";
            this.titleLineMovies.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleLineMovies.Size = new System.Drawing.Size(2, 24);
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
            this.titleFiles.Location = new System.Drawing.Point(41, 63);
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
            this.titleMovies.Location = new System.Drawing.Point(41, 23);
            this.titleMovies.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titleMovies.Name = "titleMovies";
            this.titleMovies.Size = new System.Drawing.Size(56, 20);
            this.titleMovies.TabIndex = 0;
            this.titleMovies.Text = "Movies";
            this.titleMovies.Click += new System.EventHandler(this.imgMovies_Click);
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
            this.MaximizeBox = false;
            this.Name = "frmOpenPlex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPlex";
            this.Load += new System.EventHandler(this.frmOpenPlex_Load);
            this.tab.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelMoviesGenre.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeaderAbout)).EndInit();
            this.panelTitles.ResumeLayout(false);
            this.panelTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovies)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnURL;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

