using FileMasta.Extensions;

namespace FileMasta
{
    partial class MainForm
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
            CButtonLib.cBlendItems cBlendItems1 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems2 = new CButtonLib.cBlendItems();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            CButtonLib.cBlendItems cBlendItems3 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems4 = new CButtonLib.cBlendItems();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.flowLayoutTopSearches = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTopSearches = new System.Windows.Forms.Label();
            this.splitterHeaderTopSearches = new CButtonLib.CButton();
            this.flowLayoutSearchItems = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutSearchHome = new System.Windows.Forms.Panel();
            this.buttonSearchHome = new CButtonLib.CButton();
            this.comboBoxSearchHome = new System.Windows.Forms.ComboBox();
            this.containerFileType = new System.Windows.Forms.Panel();
            this.buttonFileType = new CButtonLib.CButton();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.dataGridRecentlyAdded = new System.Windows.Forms.DataGridView();
            this.columnRecentlyAddedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRecentlyAddedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRecentlyAddedSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRecentlyAddedAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRecentlyAddedReferrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRecentlyAddedURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRecentlyAdded = new System.Windows.Forms.Label();
            this.splitterHeaderRecentlyAdded = new CButtonLib.CButton();
            this.labelDatabaseUpdatedDate = new System.Windows.Forms.Label();
            this.labelDatabaseStats = new System.Windows.Forms.Label();
            this.textBoxSearchHome = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundSearchHome = new CButtonLib.CButton();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.labelNoResultsFound = new System.Windows.Forms.Label();
            this.flowLayoutSearchFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.imageSearchFiles = new System.Windows.Forms.PictureBox();
            this.flowLayoutFilterFiles = new System.Windows.Forms.Panel();
            this.buttonFilterFiles = new CButtonLib.CButton();
            this.comboBoxFilterFiles = new System.Windows.Forms.ComboBox();
            this.flowLayoutSortFiles = new System.Windows.Forms.Panel();
            this.buttonSortFiles = new CButtonLib.CButton();
            this.comboBoxSortFiles = new System.Windows.Forms.ComboBox();
            this.textBoxSearchFiles = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.columnFilesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesReferrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitterFilesType = new CButtonLib.CButton();
            this.textBoxBackgroundSearchFiles = new CButtonLib.CButton();
            this.labelResultsInfo = new System.Windows.Forms.Label();
            this.buttonFilesAudio = new FileMasta.Controls.buttonFileType();
            this.buttonFilesBookmarks = new FileMasta.Controls.buttonFileType();
            this.buttonFilesLocal = new FileMasta.Controls.buttonFileType();
            this.buttonFilesTorrents = new FileMasta.Controls.buttonFileType();
            this.buttonFilesOther = new FileMasta.Controls.buttonFileType();
            this.buttonFilesSoftware = new FileMasta.Controls.buttonFileType();
            this.buttonFilesCustom = new FileMasta.Controls.buttonFileType();
            this.buttonFilesSubtitles = new FileMasta.Controls.buttonFileType();
            this.buttonFilesAll = new FileMasta.Controls.buttonFileType();
            this.buttonFilesBooks = new FileMasta.Controls.buttonFileType();
            this.buttonFilesVideo = new FileMasta.Controls.buttonFileType();
            this.tabDiscover = new System.Windows.Forms.TabPage();
            this.splitterHeaderDiscover = new CButtonLib.CButton();
            this.labelTitleDiscover = new System.Windows.Forms.Label();
            this.dataGridDiscover = new System.Windows.Forms.DataGridView();
            this.columnDiscoverCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSubmit = new System.Windows.Forms.TabPage();
            this.splitterHeaderSubmit = new CButtonLib.CButton();
            this.flowLayoutSubmitControls = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSubmitDescription = new System.Windows.Forms.Label();
            this.panelSubmitLink = new System.Windows.Forms.Panel();
            this.buttonSubmitUrl = new FileMasta.Controls.buttonCustom();
            this.textBoxSubmitLink = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundSubmitLink = new CButtonLib.CButton();
            this.labelTitleSubmit = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.buttonSaveSettings = new FileMasta.Controls.buttonCustom();
            this.buttonRestoreSettings = new FileMasta.Controls.buttonCustom();
            this.splitterHeaderSettings = new CButtonLib.CButton();
            this.labelTitleGeneral = new System.Windows.Forms.Label();
            this.labelClearDataOnClose = new System.Windows.Forms.Label();
            this.checkBoxClearDataOnClose = new System.Windows.Forms.CheckBox();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.labelKeyboardShortcuts = new System.Windows.Forms.Label();
            this.labelPrivacyPolicy = new System.Windows.Forms.Label();
            this.labelTermsOfUse = new System.Windows.Forms.Label();
            this.labelChangeLog = new System.Windows.Forms.Label();
            this.labelReportIssue = new System.Windows.Forms.Label();
            this.labelMadeWithLove = new System.Windows.Forms.Label();
            this.labelAboutApp = new System.Windows.Forms.Label();
            this.tabBlank = new System.Windows.Forms.TabPage();
            this.panelTabTitles = new System.Windows.Forms.Panel();
            this.titleInformation = new FileMasta.Controls.buttonTabTitle();
            this.titleSettings = new FileMasta.Controls.buttonTabTitle();
            this.titleSubmit = new FileMasta.Controls.buttonTabTitle();
            this.titleDiscover = new FileMasta.Controls.buttonTabTitle();
            this.titleSearch = new FileMasta.Controls.buttonTabTitle();
            this.titleHome = new FileMasta.Controls.buttonTabTitle();
            this.imageFacebook = new System.Windows.Forms.PictureBox();
            this.imageTwitter = new System.Windows.Forms.PictureBox();
            this.tab.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.flowLayoutSearchItems.SuspendLayout();
            this.flowLayoutSearchHome.SuspendLayout();
            this.containerFileType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentlyAdded)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.flowLayoutSearchFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSearchFiles)).BeginInit();
            this.flowLayoutFilterFiles.SuspendLayout();
            this.flowLayoutSortFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.tabDiscover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscover)).BeginInit();
            this.tabSubmit.SuspendLayout();
            this.flowLayoutSubmitControls.SuspendLayout();
            this.panelSubmitLink.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabInformation.SuspendLayout();
            this.panelTabTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwitter)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabHome);
            this.tab.Controls.Add(this.tabSearch);
            this.tab.Controls.Add(this.tabDiscover);
            this.tab.Controls.Add(this.tabSubmit);
            this.tab.Controls.Add(this.tabSettings);
            this.tab.Controls.Add(this.tabInformation);
            this.tab.Controls.Add(this.tabBlank);
            this.tab.Location = new System.Drawing.Point(-4, 12);
            this.tab.Margin = new System.Windows.Forms.Padding(0);
            this.tab.Name = "tab";
            this.tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1056, 633);
            this.tab.TabIndex = 0;
            this.tab.TabStop = false;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHome.Controls.Add(this.flowLayoutTopSearches);
            this.tabHome.Controls.Add(this.labelTopSearches);
            this.tabHome.Controls.Add(this.splitterHeaderTopSearches);
            this.tabHome.Controls.Add(this.flowLayoutSearchItems);
            this.tabHome.Controls.Add(this.dataGridRecentlyAdded);
            this.tabHome.Controls.Add(this.labelRecentlyAdded);
            this.tabHome.Controls.Add(this.splitterHeaderRecentlyAdded);
            this.tabHome.Controls.Add(this.labelDatabaseUpdatedDate);
            this.tabHome.Controls.Add(this.labelDatabaseStats);
            this.tabHome.Controls.Add(this.textBoxSearchHome);
            this.tabHome.Controls.Add(this.textBoxBackgroundSearchHome);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabHome.Size = new System.Drawing.Size(1048, 607);
            this.tabHome.TabIndex = 10;
            // 
            // flowLayoutTopSearches
            // 
            this.flowLayoutTopSearches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutTopSearches.AutoSize = true;
            this.flowLayoutTopSearches.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutTopSearches.Location = new System.Drawing.Point(15, 93);
            this.flowLayoutTopSearches.Name = "flowLayoutTopSearches";
            this.flowLayoutTopSearches.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutTopSearches.Size = new System.Drawing.Size(1022, 156);
            this.flowLayoutTopSearches.TabIndex = 2;
            // 
            // labelTopSearches
            // 
            this.labelTopSearches.AutoSize = true;
            this.labelTopSearches.BackColor = System.Drawing.Color.Transparent;
            this.labelTopSearches.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelTopSearches.ForeColor = System.Drawing.Color.White;
            this.labelTopSearches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTopSearches.Location = new System.Drawing.Point(11, 65);
            this.labelTopSearches.Margin = new System.Windows.Forms.Padding(0);
            this.labelTopSearches.Name = "labelTopSearches";
            this.labelTopSearches.Size = new System.Drawing.Size(106, 19);
            this.labelTopSearches.TabIndex = 0;
            this.labelTopSearches.Text = "TOP SEARCHES";
            // 
            // splitterHeaderTopSearches
            // 
            this.splitterHeaderTopSearches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderTopSearches.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderTopSearches.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderTopSearches.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderTopSearches.DesignerSelected = false;
            this.splitterHeaderTopSearches.DimFactorClick = 0;
            this.splitterHeaderTopSearches.DimFactorHover = 0;
            this.splitterHeaderTopSearches.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderTopSearches.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderTopSearches.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderTopSearches.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderTopSearches.ImageIndex = 0;
            this.splitterHeaderTopSearches.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderTopSearches.Location = new System.Drawing.Point(15, 86);
            this.splitterHeaderTopSearches.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderTopSearches.Name = "splitterHeaderTopSearches";
            this.splitterHeaderTopSearches.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderTopSearches.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderTopSearches.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderTopSearches.Size = new System.Drawing.Size(1023, 1);
            this.splitterHeaderTopSearches.TabIndex = 0;
            this.splitterHeaderTopSearches.TabStop = false;
            this.splitterHeaderTopSearches.Text = "";
            this.splitterHeaderTopSearches.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderTopSearches.TextShadowShow = false;
            // 
            // flowLayoutSearchItems
            // 
            this.flowLayoutSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.flowLayoutSearchItems.Controls.Add(this.flowLayoutSearchHome);
            this.flowLayoutSearchItems.Controls.Add(this.containerFileType);
            this.flowLayoutSearchItems.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutSearchItems.Location = new System.Drawing.Point(756, 22);
            this.flowLayoutSearchItems.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.flowLayoutSearchItems.Name = "flowLayoutSearchItems";
            this.flowLayoutSearchItems.Size = new System.Drawing.Size(271, 22);
            this.flowLayoutSearchItems.TabIndex = 1;
            // 
            // flowLayoutSearchHome
            // 
            this.flowLayoutSearchHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutSearchHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.flowLayoutSearchHome.Controls.Add(this.buttonSearchHome);
            this.flowLayoutSearchHome.Controls.Add(this.comboBoxSearchHome);
            this.flowLayoutSearchHome.Location = new System.Drawing.Point(232, 0);
            this.flowLayoutSearchHome.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutSearchHome.Name = "flowLayoutSearchHome";
            this.flowLayoutSearchHome.Size = new System.Drawing.Size(39, 22);
            this.flowLayoutSearchHome.TabIndex = 5;
            // 
            // buttonSearchHome
            // 
            this.buttonSearchHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchHome.BorderColor = System.Drawing.Color.Transparent;
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems1.iPoint = new float[] {
        0F,
        1F};
            this.buttonSearchHome.ColorFillBlend = cBlendItems1;
            this.buttonSearchHome.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonSearchHome.Corners.All = 2;
            this.buttonSearchHome.Corners.LowerLeft = 2;
            this.buttonSearchHome.Corners.LowerRight = 2;
            this.buttonSearchHome.Corners.UpperLeft = 2;
            this.buttonSearchHome.Corners.UpperRight = 2;
            this.buttonSearchHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchHome.DesignerSelected = false;
            this.buttonSearchHome.DimFactorClick = 0;
            this.buttonSearchHome.DimFactorHover = 0;
            this.buttonSearchHome.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonSearchHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.buttonSearchHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            this.buttonSearchHome.Image = global::FileMasta.Properties.Resources.magnify_orange;
            this.buttonSearchHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchHome.ImageIndex = 0;
            this.buttonSearchHome.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonSearchHome.Location = new System.Drawing.Point(0, 0);
            this.buttonSearchHome.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchHome.Name = "buttonSearchHome";
            this.buttonSearchHome.SideImage = global::FileMasta.Properties.Resources.menu_down;
            this.buttonSearchHome.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchHome.SideImageIsClickable = true;
            this.buttonSearchHome.SideImageSize = new System.Drawing.Size(16, 16);
            this.buttonSearchHome.Size = new System.Drawing.Size(39, 22);
            this.buttonSearchHome.TabIndex = 3;
            this.buttonSearchHome.Text = "";
            this.buttonSearchHome.TextMargin = new System.Windows.Forms.Padding(0);
            this.buttonSearchHome.TextShadowShow = false;
            this.buttonSearchHome.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonSearchHome_ClickButtonArea);
            this.buttonSearchHome.SideImageClicked += new CButtonLib.CButton.SideImageClickedEventHandler(this.buttonSearchHome_SideImageClicked);
            // 
            // comboBoxSearchHome
            // 
            this.comboBoxSearchHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.comboBoxSearchHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.comboBoxSearchHome.ForeColor = System.Drawing.Color.White;
            this.comboBoxSearchHome.FormattingEnabled = true;
            this.comboBoxSearchHome.Items.AddRange(new object[] {
            "Google",
            "Googol",
            "Startpage",
            "Searx"});
            this.comboBoxSearchHome.Location = new System.Drawing.Point(0, -2);
            this.comboBoxSearchHome.Name = "comboBoxSearchHome";
            this.comboBoxSearchHome.Size = new System.Drawing.Size(39, 23);
            this.comboBoxSearchHome.TabIndex = 0;
            this.comboBoxSearchHome.TabStop = false;
            this.comboBoxSearchHome.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchHome_SelectedIndexChanged);
            // 
            // containerFileType
            // 
            this.containerFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.containerFileType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.containerFileType.Controls.Add(this.buttonFileType);
            this.containerFileType.Controls.Add(this.comboBoxFileType);
            this.containerFileType.Location = new System.Drawing.Point(116, 0);
            this.containerFileType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.containerFileType.Name = "containerFileType";
            this.containerFileType.Size = new System.Drawing.Size(110, 22);
            this.containerFileType.TabIndex = 4;
            // 
            // buttonFileType
            // 
            this.buttonFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileType.BackColor = System.Drawing.Color.Transparent;
            this.buttonFileType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            cBlendItems2.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems2.iPoint = new float[] {
        0F,
        1F};
            this.buttonFileType.ColorFillBlend = cBlendItems2;
            this.buttonFileType.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFileType.Corners.All = 2;
            this.buttonFileType.Corners.LowerLeft = 2;
            this.buttonFileType.Corners.LowerRight = 2;
            this.buttonFileType.Corners.UpperLeft = 2;
            this.buttonFileType.Corners.UpperRight = 2;
            this.buttonFileType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFileType.DesignerSelected = false;
            this.buttonFileType.DimFactorClick = 0;
            this.buttonFileType.DimFactorHover = 0;
            this.buttonFileType.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFileType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.buttonFileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            this.buttonFileType.Image = global::FileMasta.Properties.Resources.menu_down;
            this.buttonFileType.ImageIndex = 0;
            this.buttonFileType.Location = new System.Drawing.Point(0, 0);
            this.buttonFileType.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFileType.Name = "buttonFileType";
            this.buttonFileType.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonFileType.SideImageSize = new System.Drawing.Size(24, 24);
            this.buttonFileType.Size = new System.Drawing.Size(110, 22);
            this.buttonFileType.TabIndex = 2;
            this.buttonFileType.Text = "Filetype : All";
            this.buttonFileType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonFileType.TextMargin = new System.Windows.Forms.Padding(0);
            this.buttonFileType.TextShadowShow = false;
            this.buttonFileType.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonHomeFileType_ClickButtonArea);
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFileType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.comboBoxFileType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.comboBoxFileType.ForeColor = System.Drawing.Color.White;
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Items.AddRange(new object[] {
            "All",
            "TV/Movies/Video",
            "Audio",
            "Books",
            "Subtitles",
            "Torrents",
            "Software/Games",
            "Other"});
            this.comboBoxFileType.Location = new System.Drawing.Point(0, -2);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(110, 23);
            this.comboBoxFileType.TabIndex = 0;
            this.comboBoxFileType.TabStop = false;
            this.comboBoxFileType.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeFileType_SelectedIndexChanged);
            // 
            // dataGridRecentlyAdded
            // 
            this.dataGridRecentlyAdded.AllowUserToAddRows = false;
            this.dataGridRecentlyAdded.AllowUserToDeleteRows = false;
            this.dataGridRecentlyAdded.AllowUserToResizeColumns = false;
            this.dataGridRecentlyAdded.AllowUserToResizeRows = false;
            this.dataGridRecentlyAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRecentlyAdded.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridRecentlyAdded.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRecentlyAdded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridRecentlyAdded.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridRecentlyAdded.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRecentlyAdded.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRecentlyAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecentlyAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnRecentlyAddedType,
            this.columnRecentlyAddedName,
            this.columnRecentlyAddedSize,
            this.columnRecentlyAddedAge,
            this.columnRecentlyAddedReferrer,
            this.columnRecentlyAddedURL});
            this.dataGridRecentlyAdded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridRecentlyAdded.EnableHeadersVisualStyles = false;
            this.dataGridRecentlyAdded.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridRecentlyAdded.Location = new System.Drawing.Point(15, 286);
            this.dataGridRecentlyAdded.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dataGridRecentlyAdded.MultiSelect = false;
            this.dataGridRecentlyAdded.Name = "dataGridRecentlyAdded";
            this.dataGridRecentlyAdded.ReadOnly = true;
            this.dataGridRecentlyAdded.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridRecentlyAdded.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridRecentlyAdded.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridRecentlyAdded.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.dataGridRecentlyAdded.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridRecentlyAdded.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridRecentlyAdded.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridRecentlyAdded.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridRecentlyAdded.RowTemplate.Height = 28;
            this.dataGridRecentlyAdded.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridRecentlyAdded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRecentlyAdded.ShowCellErrors = false;
            this.dataGridRecentlyAdded.ShowEditingIcon = false;
            this.dataGridRecentlyAdded.ShowRowErrors = false;
            this.dataGridRecentlyAdded.Size = new System.Drawing.Size(1022, 248);
            this.dataGridRecentlyAdded.TabIndex = 3;
            this.dataGridRecentlyAdded.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecentlyAddedFiles_CellClick);
            // 
            // columnRecentlyAddedType
            // 
            this.columnRecentlyAddedType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnRecentlyAddedType.HeaderText = "Type";
            this.columnRecentlyAddedType.Name = "columnRecentlyAddedType";
            this.columnRecentlyAddedType.ReadOnly = true;
            this.columnRecentlyAddedType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnRecentlyAddedType.Width = 43;
            // 
            // columnRecentlyAddedName
            // 
            this.columnRecentlyAddedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnRecentlyAddedName.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnRecentlyAddedName.HeaderText = "Name";
            this.columnRecentlyAddedName.Name = "columnRecentlyAddedName";
            this.columnRecentlyAddedName.ReadOnly = true;
            // 
            // columnRecentlyAddedSize
            // 
            this.columnRecentlyAddedSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnRecentlyAddedSize.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnRecentlyAddedSize.HeaderText = "Size";
            this.columnRecentlyAddedSize.Name = "columnRecentlyAddedSize";
            this.columnRecentlyAddedSize.ReadOnly = true;
            this.columnRecentlyAddedSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnRecentlyAddedSize.Width = 41;
            // 
            // columnRecentlyAddedAge
            // 
            this.columnRecentlyAddedAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnRecentlyAddedAge.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnRecentlyAddedAge.HeaderText = "Age";
            this.columnRecentlyAddedAge.Name = "columnRecentlyAddedAge";
            this.columnRecentlyAddedAge.ReadOnly = true;
            this.columnRecentlyAddedAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnRecentlyAddedAge.Width = 41;
            // 
            // columnRecentlyAddedReferrer
            // 
            this.columnRecentlyAddedReferrer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnRecentlyAddedReferrer.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnRecentlyAddedReferrer.HeaderText = "Referrer";
            this.columnRecentlyAddedReferrer.Name = "columnRecentlyAddedReferrer";
            this.columnRecentlyAddedReferrer.ReadOnly = true;
            this.columnRecentlyAddedReferrer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnRecentlyAddedReferrer.Width = 62;
            // 
            // columnRecentlyAddedURL
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnRecentlyAddedURL.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnRecentlyAddedURL.HeaderText = "URL";
            this.columnRecentlyAddedURL.Name = "columnRecentlyAddedURL";
            this.columnRecentlyAddedURL.ReadOnly = true;
            this.columnRecentlyAddedURL.Visible = false;
            // 
            // labelRecentlyAdded
            // 
            this.labelRecentlyAdded.AutoSize = true;
            this.labelRecentlyAdded.BackColor = System.Drawing.Color.Transparent;
            this.labelRecentlyAdded.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelRecentlyAdded.ForeColor = System.Drawing.Color.White;
            this.labelRecentlyAdded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRecentlyAdded.Location = new System.Drawing.Point(11, 258);
            this.labelRecentlyAdded.Margin = new System.Windows.Forms.Padding(0);
            this.labelRecentlyAdded.Name = "labelRecentlyAdded";
            this.labelRecentlyAdded.Size = new System.Drawing.Size(124, 19);
            this.labelRecentlyAdded.TabIndex = 1110;
            this.labelRecentlyAdded.Text = "RECENTLY ADDED";
            // 
            // splitterHeaderRecentlyAdded
            // 
            this.splitterHeaderRecentlyAdded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderRecentlyAdded.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderRecentlyAdded.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderRecentlyAdded.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderRecentlyAdded.DesignerSelected = false;
            this.splitterHeaderRecentlyAdded.DimFactorClick = 0;
            this.splitterHeaderRecentlyAdded.DimFactorHover = 0;
            this.splitterHeaderRecentlyAdded.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderRecentlyAdded.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderRecentlyAdded.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderRecentlyAdded.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderRecentlyAdded.ImageIndex = 0;
            this.splitterHeaderRecentlyAdded.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderRecentlyAdded.Location = new System.Drawing.Point(15, 279);
            this.splitterHeaderRecentlyAdded.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderRecentlyAdded.Name = "splitterHeaderRecentlyAdded";
            this.splitterHeaderRecentlyAdded.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderRecentlyAdded.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderRecentlyAdded.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderRecentlyAdded.Size = new System.Drawing.Size(1023, 1);
            this.splitterHeaderRecentlyAdded.TabIndex = 0;
            this.splitterHeaderRecentlyAdded.TabStop = false;
            this.splitterHeaderRecentlyAdded.Text = "";
            this.splitterHeaderRecentlyAdded.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderRecentlyAdded.TextShadowShow = false;
            // 
            // labelDatabaseUpdatedDate
            // 
            this.labelDatabaseUpdatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseUpdatedDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDatabaseUpdatedDate.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelDatabaseUpdatedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDatabaseUpdatedDate.Location = new System.Drawing.Point(210, 569);
            this.labelDatabaseUpdatedDate.Name = "labelDatabaseUpdatedDate";
            this.labelDatabaseUpdatedDate.Size = new System.Drawing.Size(632, 20);
            this.labelDatabaseUpdatedDate.TabIndex = 0;
            this.labelDatabaseUpdatedDate.Text = "Updated: {0}";
            this.labelDatabaseUpdatedDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDatabaseStats
            // 
            this.labelDatabaseStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseStats.BackColor = System.Drawing.Color.Transparent;
            this.labelDatabaseStats.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDatabaseStats.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDatabaseStats.Location = new System.Drawing.Point(210, 545);
            this.labelDatabaseStats.Name = "labelDatabaseStats";
            this.labelDatabaseStats.Size = new System.Drawing.Size(632, 20);
            this.labelDatabaseStats.TabIndex = 1106;
            this.labelDatabaseStats.Text = "Searching {0} files ({1}+) in {2} web servers";
            this.labelDatabaseStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSearchHome
            // 
            this.textBoxSearchHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxSearchHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchHome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.textBoxSearchHome.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchHome.Location = new System.Drawing.Point(22, 22);
            this.textBoxSearchHome.Name = "textBoxSearchHome";
            this.textBoxSearchHome.Size = new System.Drawing.Size(729, 19);
            this.textBoxSearchHome.TabIndex = 0;
            this.textBoxSearchHome.WaterMark = "What are you looking for?";
            this.textBoxSearchHome.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxSearchHome.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.textBoxSearchHome.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchHome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchFilesHome_KeyDown);
            // 
            // textBoxBackgroundSearchHome
            // 
            this.textBoxBackgroundSearchHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBackgroundSearchHome.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundSearchHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundSearchHome.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundSearchHome.Corners.All = 2;
            this.textBoxBackgroundSearchHome.Corners.LowerLeft = 2;
            this.textBoxBackgroundSearchHome.Corners.LowerRight = 2;
            this.textBoxBackgroundSearchHome.Corners.UpperLeft = 2;
            this.textBoxBackgroundSearchHome.Corners.UpperRight = 2;
            this.textBoxBackgroundSearchHome.DesignerSelected = false;
            this.textBoxBackgroundSearchHome.DimFactorClick = 0;
            this.textBoxBackgroundSearchHome.DimFactorHover = 0;
            this.textBoxBackgroundSearchHome.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundSearchHome.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundSearchHome.ImageIndex = 0;
            this.textBoxBackgroundSearchHome.Location = new System.Drawing.Point(13, 14);
            this.textBoxBackgroundSearchHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxBackgroundSearchHome.Name = "textBoxBackgroundSearchHome";
            this.textBoxBackgroundSearchHome.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundSearchHome.Size = new System.Drawing.Size(1022, 38);
            this.textBoxBackgroundSearchHome.TabIndex = 0;
            this.textBoxBackgroundSearchHome.TabStop = false;
            this.textBoxBackgroundSearchHome.Text = "";
            this.textBoxBackgroundSearchHome.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.bgSearchFilesHome_ClickButtonArea);
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabSearch.Controls.Add(this.labelNoResultsFound);
            this.tabSearch.Controls.Add(this.flowLayoutSearchFiles);
            this.tabSearch.Controls.Add(this.textBoxSearchFiles);
            this.tabSearch.Controls.Add(this.dataGridFiles);
            this.tabSearch.Controls.Add(this.splitterFilesType);
            this.tabSearch.Controls.Add(this.textBoxBackgroundSearchFiles);
            this.tabSearch.Controls.Add(this.labelResultsInfo);
            this.tabSearch.Controls.Add(this.buttonFilesAudio);
            this.tabSearch.Controls.Add(this.buttonFilesBookmarks);
            this.tabSearch.Controls.Add(this.buttonFilesLocal);
            this.tabSearch.Controls.Add(this.buttonFilesTorrents);
            this.tabSearch.Controls.Add(this.buttonFilesOther);
            this.tabSearch.Controls.Add(this.buttonFilesSoftware);
            this.tabSearch.Controls.Add(this.buttonFilesCustom);
            this.tabSearch.Controls.Add(this.buttonFilesSubtitles);
            this.tabSearch.Controls.Add(this.buttonFilesAll);
            this.tabSearch.Controls.Add(this.buttonFilesBooks);
            this.tabSearch.Controls.Add(this.buttonFilesVideo);
            this.tabSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tabSearch.ForeColor = System.Drawing.Color.White;
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1048, 607);
            this.tabSearch.TabIndex = 9;
            // 
            // labelNoResultsFound
            // 
            this.labelNoResultsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNoResultsFound.AutoSize = true;
            this.labelNoResultsFound.BackColor = System.Drawing.Color.Transparent;
            this.labelNoResultsFound.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelNoResultsFound.ForeColor = System.Drawing.Color.Silver;
            this.labelNoResultsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNoResultsFound.Location = new System.Drawing.Point(464, 180);
            this.labelNoResultsFound.Name = "labelNoResultsFound";
            this.labelNoResultsFound.Size = new System.Drawing.Size(120, 19);
            this.labelNoResultsFound.TabIndex = 0;
            this.labelNoResultsFound.Text = "No Results Found";
            this.labelNoResultsFound.Visible = false;
            // 
            // flowLayoutSearchFiles
            // 
            this.flowLayoutSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutSearchFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.flowLayoutSearchFiles.Controls.Add(this.imageSearchFiles);
            this.flowLayoutSearchFiles.Controls.Add(this.flowLayoutFilterFiles);
            this.flowLayoutSearchFiles.Controls.Add(this.flowLayoutSortFiles);
            this.flowLayoutSearchFiles.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutSearchFiles.Location = new System.Drawing.Point(660, 22);
            this.flowLayoutSearchFiles.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.flowLayoutSearchFiles.Name = "flowLayoutSearchFiles";
            this.flowLayoutSearchFiles.Size = new System.Drawing.Size(367, 22);
            this.flowLayoutSearchFiles.TabIndex = 1;
            this.flowLayoutSearchFiles.TabStop = true;
            // 
            // imageSearchFiles
            // 
            this.imageSearchFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageSearchFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.imageSearchFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSearchFiles.Image = global::FileMasta.Properties.Resources.magnify_orange;
            this.imageSearchFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageSearchFiles.Location = new System.Drawing.Point(347, 1);
            this.imageSearchFiles.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.imageSearchFiles.Name = "imageSearchFiles";
            this.imageSearchFiles.Size = new System.Drawing.Size(20, 20);
            this.imageSearchFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSearchFiles.TabIndex = 1110;
            this.imageSearchFiles.TabStop = false;
            this.imageSearchFiles.Click += new System.EventHandler(this.imgSearch_Click);
            // 
            // flowLayoutFilterFiles
            // 
            this.flowLayoutFilterFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.flowLayoutFilterFiles.Controls.Add(this.buttonFilterFiles);
            this.flowLayoutFilterFiles.Controls.Add(this.comboBoxFilterFiles);
            this.flowLayoutFilterFiles.Location = new System.Drawing.Point(241, 0);
            this.flowLayoutFilterFiles.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutFilterFiles.Name = "flowLayoutFilterFiles";
            this.flowLayoutFilterFiles.Size = new System.Drawing.Size(100, 22);
            this.flowLayoutFilterFiles.TabIndex = 3;
            // 
            // buttonFilterFiles
            // 
            this.buttonFilterFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilterFiles.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilterFiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            cBlendItems3.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems3.iPoint = new float[] {
        0F,
        1F};
            this.buttonFilterFiles.ColorFillBlend = cBlendItems3;
            this.buttonFilterFiles.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilterFiles.Corners.All = 2;
            this.buttonFilterFiles.Corners.LowerLeft = 2;
            this.buttonFilterFiles.Corners.LowerRight = 2;
            this.buttonFilterFiles.Corners.UpperLeft = 2;
            this.buttonFilterFiles.Corners.UpperRight = 2;
            this.buttonFilterFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterFiles.DesignerSelected = false;
            this.buttonFilterFiles.DimFactorClick = 0;
            this.buttonFilterFiles.DimFactorHover = 0;
            this.buttonFilterFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilterFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.buttonFilterFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            this.buttonFilterFiles.Image = global::FileMasta.Properties.Resources.menu_down;
            this.buttonFilterFiles.ImageIndex = 0;
            this.buttonFilterFiles.Location = new System.Drawing.Point(0, 0);
            this.buttonFilterFiles.Name = "buttonFilterFiles";
            this.buttonFilterFiles.Size = new System.Drawing.Size(100, 22);
            this.buttonFilterFiles.TabIndex = 2;
            this.buttonFilterFiles.Text = "Filter : Any";
            this.buttonFilterFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonFilterFiles.TextMargin = new System.Windows.Forms.Padding(0);
            this.buttonFilterFiles.TextShadowShow = false;
            this.buttonFilterFiles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesHost_ClickButtonArea);
            // 
            // comboBoxFilterFiles
            // 
            this.comboBoxFilterFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilterFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.comboBoxFilterFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.comboBoxFilterFiles.ForeColor = System.Drawing.Color.White;
            this.comboBoxFilterFiles.FormattingEnabled = true;
            this.comboBoxFilterFiles.Items.AddRange(new object[] {
            "Any"});
            this.comboBoxFilterFiles.Location = new System.Drawing.Point(0, -2);
            this.comboBoxFilterFiles.Name = "comboBoxFilterFiles";
            this.comboBoxFilterFiles.Size = new System.Drawing.Size(100, 23);
            this.comboBoxFilterFiles.TabIndex = 0;
            this.comboBoxFilterFiles.TabStop = false;
            this.comboBoxFilterFiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilesHost_SelectedIndexChanged);
            // 
            // flowLayoutSortFiles
            // 
            this.flowLayoutSortFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.flowLayoutSortFiles.Controls.Add(this.buttonSortFiles);
            this.flowLayoutSortFiles.Controls.Add(this.comboBoxSortFiles);
            this.flowLayoutSortFiles.Location = new System.Drawing.Point(129, 0);
            this.flowLayoutSortFiles.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutSortFiles.Name = "flowLayoutSortFiles";
            this.flowLayoutSortFiles.Size = new System.Drawing.Size(106, 22);
            this.flowLayoutSortFiles.TabIndex = 6;
            // 
            // buttonSortFiles
            // 
            this.buttonSortFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortFiles.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortFiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            cBlendItems4.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems4.iPoint = new float[] {
        0F,
        1F};
            this.buttonSortFiles.ColorFillBlend = cBlendItems4;
            this.buttonSortFiles.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonSortFiles.Corners.All = 2;
            this.buttonSortFiles.Corners.LowerLeft = 2;
            this.buttonSortFiles.Corners.LowerRight = 2;
            this.buttonSortFiles.Corners.UpperLeft = 2;
            this.buttonSortFiles.Corners.UpperRight = 2;
            this.buttonSortFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortFiles.DesignerSelected = false;
            this.buttonSortFiles.DimFactorClick = 0;
            this.buttonSortFiles.DimFactorHover = 0;
            this.buttonSortFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonSortFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.buttonSortFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            this.buttonSortFiles.Image = global::FileMasta.Properties.Resources.menu_down;
            this.buttonSortFiles.ImageIndex = 0;
            this.buttonSortFiles.Location = new System.Drawing.Point(0, 0);
            this.buttonSortFiles.Name = "buttonSortFiles";
            this.buttonSortFiles.SideImageSize = new System.Drawing.Size(24, 24);
            this.buttonSortFiles.Size = new System.Drawing.Size(106, 22);
            this.buttonSortFiles.TabIndex = 1;
            this.buttonSortFiles.Text = "Sort : Name";
            this.buttonSortFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSortFiles.TextMargin = new System.Windows.Forms.Padding(0);
            this.buttonSortFiles.TextShadowShow = false;
            this.buttonSortFiles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesSort_ClickButtonArea);
            // 
            // comboBoxSortFiles
            // 
            this.comboBoxSortFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSortFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.comboBoxSortFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.comboBoxSortFiles.ForeColor = System.Drawing.Color.White;
            this.comboBoxSortFiles.FormattingEnabled = true;
            this.comboBoxSortFiles.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Date"});
            this.comboBoxSortFiles.Location = new System.Drawing.Point(0, -2);
            this.comboBoxSortFiles.Name = "comboBoxSortFiles";
            this.comboBoxSortFiles.Size = new System.Drawing.Size(106, 23);
            this.comboBoxSortFiles.TabIndex = 0;
            this.comboBoxSortFiles.TabStop = false;
            this.comboBoxSortFiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilesSort_SelectedIndexChanged);
            // 
            // textBoxSearchFiles
            // 
            this.textBoxSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxSearchFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.textBoxSearchFiles.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchFiles.Location = new System.Drawing.Point(22, 22);
            this.textBoxSearchFiles.Name = "textBoxSearchFiles";
            this.textBoxSearchFiles.Size = new System.Drawing.Size(633, 19);
            this.textBoxSearchFiles.TabIndex = 0;
            this.textBoxSearchFiles.WaterMark = "Search for file names, add tags or insert a link...";
            this.textBoxSearchFiles.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxSearchFiles.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.textBoxSearchFiles.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchFiles_KeyDown);
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
            this.dataGridFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFilesType,
            this.columnFilesName,
            this.columnFilesSize,
            this.columnFilesAge,
            this.columnFilesReferrer,
            this.columnFilesURL});
            this.dataGridFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridFiles.EnableHeadersVisualStyles = false;
            this.dataGridFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridFiles.Location = new System.Drawing.Point(0, 90);
            this.dataGridFiles.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dataGridFiles.MultiSelect = false;
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            this.dataGridFiles.RowHeadersVisible = false;
            this.dataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowTemplate.Height = 30;
            this.dataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFiles.ShowCellErrors = false;
            this.dataGridFiles.ShowEditingIcon = false;
            this.dataGridFiles.ShowRowErrors = false;
            this.dataGridFiles.Size = new System.Drawing.Size(1047, 516);
            this.dataGridFiles.TabIndex = 14;
            this.dataGridFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFiles_CellClick);
            // 
            // columnFilesType
            // 
            this.columnFilesType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnFilesType.HeaderText = "Type";
            this.columnFilesType.Name = "columnFilesType";
            this.columnFilesType.ReadOnly = true;
            this.columnFilesType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesType.Width = 50;
            // 
            // columnFilesName
            // 
            this.columnFilesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesName.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnFilesName.HeaderText = "Name";
            this.columnFilesName.Name = "columnFilesName";
            this.columnFilesName.ReadOnly = true;
            // 
            // columnFilesSize
            // 
            this.columnFilesSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesSize.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnFilesSize.HeaderText = "Size";
            this.columnFilesSize.Name = "columnFilesSize";
            this.columnFilesSize.ReadOnly = true;
            this.columnFilesSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesSize.Width = 45;
            // 
            // columnFilesAge
            // 
            this.columnFilesAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesAge.DefaultCellStyle = dataGridViewCellStyle11;
            this.columnFilesAge.HeaderText = "Age";
            this.columnFilesAge.Name = "columnFilesAge";
            this.columnFilesAge.ReadOnly = true;
            this.columnFilesAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesAge.Width = 46;
            // 
            // columnFilesReferrer
            // 
            this.columnFilesReferrer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesReferrer.DefaultCellStyle = dataGridViewCellStyle12;
            this.columnFilesReferrer.HeaderText = "Referrer";
            this.columnFilesReferrer.Name = "columnFilesReferrer";
            this.columnFilesReferrer.ReadOnly = true;
            this.columnFilesReferrer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesReferrer.Width = 70;
            // 
            // columnFilesURL
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesURL.DefaultCellStyle = dataGridViewCellStyle13;
            this.columnFilesURL.HeaderText = "URL";
            this.columnFilesURL.Name = "columnFilesURL";
            this.columnFilesURL.ReadOnly = true;
            this.columnFilesURL.Visible = false;
            // 
            // splitterFilesType
            // 
            this.splitterFilesType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterFilesType.BackColor = System.Drawing.Color.Transparent;
            this.splitterFilesType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterFilesType.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterFilesType.DesignerSelected = false;
            this.splitterFilesType.DimFactorClick = 0;
            this.splitterFilesType.DimFactorHover = 0;
            this.splitterFilesType.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterFilesType.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.splitterFilesType.ImageIndex = 0;
            this.splitterFilesType.Location = new System.Drawing.Point(13, 87);
            this.splitterFilesType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitterFilesType.Name = "splitterFilesType";
            this.splitterFilesType.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterFilesType.Size = new System.Drawing.Size(1022, 1);
            this.splitterFilesType.TabIndex = 0;
            this.splitterFilesType.TabStop = false;
            this.splitterFilesType.Text = "";
            // 
            // textBoxBackgroundSearchFiles
            // 
            this.textBoxBackgroundSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBackgroundSearchFiles.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundSearchFiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundSearchFiles.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundSearchFiles.Corners.All = 2;
            this.textBoxBackgroundSearchFiles.Corners.LowerLeft = 2;
            this.textBoxBackgroundSearchFiles.Corners.LowerRight = 2;
            this.textBoxBackgroundSearchFiles.Corners.UpperLeft = 2;
            this.textBoxBackgroundSearchFiles.Corners.UpperRight = 2;
            this.textBoxBackgroundSearchFiles.DesignerSelected = false;
            this.textBoxBackgroundSearchFiles.DimFactorClick = 0;
            this.textBoxBackgroundSearchFiles.DimFactorHover = 0;
            this.textBoxBackgroundSearchFiles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundSearchFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundSearchFiles.ImageIndex = 0;
            this.textBoxBackgroundSearchFiles.Location = new System.Drawing.Point(13, 14);
            this.textBoxBackgroundSearchFiles.Name = "textBoxBackgroundSearchFiles";
            this.textBoxBackgroundSearchFiles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundSearchFiles.Size = new System.Drawing.Size(1022, 38);
            this.textBoxBackgroundSearchFiles.TabIndex = 0;
            this.textBoxBackgroundSearchFiles.TabStop = false;
            this.textBoxBackgroundSearchFiles.Text = "";
            this.textBoxBackgroundSearchFiles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.bgSearchFiles_ClickButtonArea);
            // 
            // labelResultsInfo
            // 
            this.labelResultsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultsInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.labelResultsInfo.ForeColor = System.Drawing.Color.White;
            this.labelResultsInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelResultsInfo.Location = new System.Drawing.Point(865, 65);
            this.labelResultsInfo.Margin = new System.Windows.Forms.Padding(0, 9, 3, 9);
            this.labelResultsInfo.Name = "labelResultsInfo";
            this.labelResultsInfo.Size = new System.Drawing.Size(168, 20);
            this.labelResultsInfo.TabIndex = 0;
            this.labelResultsInfo.Text = "0 / 0 Files";
            this.labelResultsInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonFilesAudio
            // 
            this.buttonFilesAudio.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesAudio.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesAudio.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesAudio.Corners.UpperLeft = 2;
            this.buttonFilesAudio.Corners.UpperRight = 2;
            this.buttonFilesAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesAudio.DesignerSelected = false;
            this.buttonFilesAudio.DimFactorClick = 0;
            this.buttonFilesAudio.DimFactorHover = 0;
            this.buttonFilesAudio.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesAudio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesAudio.ImageIndex = 0;
            this.buttonFilesAudio.Location = new System.Drawing.Point(183, 61);
            this.buttonFilesAudio.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesAudio.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesAudio.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesAudio.Name = "buttonFilesAudio";
            this.buttonFilesAudio.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesAudio.Size = new System.Drawing.Size(60, 27);
            this.buttonFilesAudio.TabIndex = 6;
            this.buttonFilesAudio.Text = "Music";
            this.buttonFilesAudio.TextShadowShow = false;
            this.buttonFilesAudio.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesAudio_ClickButtonArea);
            // 
            // buttonFilesBookmarks
            // 
            this.buttonFilesBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesBookmarks.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesBookmarks.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesBookmarks.Corners.UpperLeft = 2;
            this.buttonFilesBookmarks.Corners.UpperRight = 2;
            this.buttonFilesBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesBookmarks.DesignerSelected = false;
            this.buttonFilesBookmarks.DimFactorClick = 0;
            this.buttonFilesBookmarks.DimFactorHover = 0;
            this.buttonFilesBookmarks.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesBookmarks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesBookmarks.ImageIndex = 0;
            this.buttonFilesBookmarks.Location = new System.Drawing.Point(773, 61);
            this.buttonFilesBookmarks.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesBookmarks.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesBookmarks.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesBookmarks.Name = "buttonFilesBookmarks";
            this.buttonFilesBookmarks.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesBookmarks.Size = new System.Drawing.Size(92, 27);
            this.buttonFilesBookmarks.TabIndex = 13;
            this.buttonFilesBookmarks.Text = "Bookmarks";
            this.buttonFilesBookmarks.TextShadowShow = false;
            this.buttonFilesBookmarks.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesBookmarks_ClickButtonArea);
            // 
            // buttonFilesLocal
            // 
            this.buttonFilesLocal.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesLocal.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesLocal.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesLocal.Corners.UpperLeft = 2;
            this.buttonFilesLocal.Corners.UpperRight = 2;
            this.buttonFilesLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesLocal.DesignerSelected = false;
            this.buttonFilesLocal.DimFactorClick = 0;
            this.buttonFilesLocal.DimFactorHover = 0;
            this.buttonFilesLocal.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesLocal.ImageIndex = 0;
            this.buttonFilesLocal.Location = new System.Drawing.Point(717, 61);
            this.buttonFilesLocal.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesLocal.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesLocal.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesLocal.Name = "buttonFilesLocal";
            this.buttonFilesLocal.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesLocal.Size = new System.Drawing.Size(56, 27);
            this.buttonFilesLocal.TabIndex = 12;
            this.buttonFilesLocal.Text = "Local";
            this.buttonFilesLocal.TextShadowShow = false;
            this.buttonFilesLocal.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesLocal_ClickButtonArea);
            // 
            // buttonFilesTorrents
            // 
            this.buttonFilesTorrents.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesTorrents.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesTorrents.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesTorrents.Corners.UpperLeft = 2;
            this.buttonFilesTorrents.Corners.UpperRight = 2;
            this.buttonFilesTorrents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesTorrents.DesignerSelected = false;
            this.buttonFilesTorrents.DimFactorClick = 0;
            this.buttonFilesTorrents.DimFactorHover = 0;
            this.buttonFilesTorrents.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesTorrents.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesTorrents.ImageIndex = 0;
            this.buttonFilesTorrents.Location = new System.Drawing.Point(429, 61);
            this.buttonFilesTorrents.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesTorrents.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesTorrents.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesTorrents.Name = "buttonFilesTorrents";
            this.buttonFilesTorrents.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesTorrents.Size = new System.Drawing.Size(75, 27);
            this.buttonFilesTorrents.TabIndex = 8;
            this.buttonFilesTorrents.Text = "Torrents";
            this.buttonFilesTorrents.TextShadowShow = false;
            this.buttonFilesTorrents.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesTorrents_ClickButtonArea);
            // 
            // buttonFilesOther
            // 
            this.buttonFilesOther.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesOther.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesOther.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesOther.Corners.UpperLeft = 2;
            this.buttonFilesOther.Corners.UpperRight = 2;
            this.buttonFilesOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesOther.DesignerSelected = false;
            this.buttonFilesOther.DimFactorClick = 0;
            this.buttonFilesOther.DimFactorHover = 0;
            this.buttonFilesOther.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesOther.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesOther.ImageIndex = 0;
            this.buttonFilesOther.Location = new System.Drawing.Point(581, 61);
            this.buttonFilesOther.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesOther.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesOther.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesOther.Name = "buttonFilesOther";
            this.buttonFilesOther.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesOther.Size = new System.Drawing.Size(59, 27);
            this.buttonFilesOther.TabIndex = 11;
            this.buttonFilesOther.Text = "Other";
            this.buttonFilesOther.TextShadowShow = false;
            this.buttonFilesOther.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesOther_ClickButtonArea);
            // 
            // buttonFilesSoftware
            // 
            this.buttonFilesSoftware.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesSoftware.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesSoftware.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesSoftware.Corners.UpperLeft = 2;
            this.buttonFilesSoftware.Corners.UpperRight = 2;
            this.buttonFilesSoftware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesSoftware.DesignerSelected = false;
            this.buttonFilesSoftware.DimFactorClick = 0;
            this.buttonFilesSoftware.DimFactorHover = 0;
            this.buttonFilesSoftware.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesSoftware.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesSoftware.ImageIndex = 0;
            this.buttonFilesSoftware.Location = new System.Drawing.Point(304, 61);
            this.buttonFilesSoftware.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesSoftware.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesSoftware.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesSoftware.Name = "buttonFilesSoftware";
            this.buttonFilesSoftware.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesSoftware.Size = new System.Drawing.Size(125, 27);
            this.buttonFilesSoftware.TabIndex = 7;
            this.buttonFilesSoftware.Text = "Software/Games";
            this.buttonFilesSoftware.TextShadowShow = false;
            this.buttonFilesSoftware.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesSoftware_ClickButtonArea);
            // 
            // buttonFilesCustom
            // 
            this.buttonFilesCustom.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesCustom.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesCustom.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesCustom.Corners.UpperLeft = 2;
            this.buttonFilesCustom.Corners.UpperRight = 2;
            this.buttonFilesCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesCustom.DesignerSelected = false;
            this.buttonFilesCustom.DimFactorClick = 0;
            this.buttonFilesCustom.DimFactorHover = 0;
            this.buttonFilesCustom.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesCustom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesCustom.ImageIndex = 0;
            this.buttonFilesCustom.Location = new System.Drawing.Point(640, 61);
            this.buttonFilesCustom.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesCustom.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesCustom.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesCustom.Name = "buttonFilesCustom";
            this.buttonFilesCustom.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesCustom.Size = new System.Drawing.Size(77, 27);
            this.buttonFilesCustom.TabIndex = 10;
            this.buttonFilesCustom.Text = "Custom*";
            this.buttonFilesCustom.TextShadowShow = false;
            this.buttonFilesCustom.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesCustom_ClickButtonArea);
            // 
            // buttonFilesSubtitles
            // 
            this.buttonFilesSubtitles.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesSubtitles.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesSubtitles.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesSubtitles.Corners.UpperLeft = 2;
            this.buttonFilesSubtitles.Corners.UpperRight = 2;
            this.buttonFilesSubtitles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesSubtitles.DesignerSelected = false;
            this.buttonFilesSubtitles.DimFactorClick = 0;
            this.buttonFilesSubtitles.DimFactorHover = 0;
            this.buttonFilesSubtitles.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesSubtitles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesSubtitles.ImageIndex = 0;
            this.buttonFilesSubtitles.Location = new System.Drawing.Point(504, 61);
            this.buttonFilesSubtitles.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesSubtitles.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesSubtitles.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesSubtitles.Name = "buttonFilesSubtitles";
            this.buttonFilesSubtitles.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesSubtitles.Size = new System.Drawing.Size(77, 27);
            this.buttonFilesSubtitles.TabIndex = 9;
            this.buttonFilesSubtitles.Text = "Subtitles";
            this.buttonFilesSubtitles.TextShadowShow = false;
            this.buttonFilesSubtitles.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesSubtitles_ClickButtonArea);
            // 
            // buttonFilesAll
            // 
            this.buttonFilesAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonFilesAll.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonFilesAll.Corners.UpperLeft = 2;
            this.buttonFilesAll.Corners.UpperRight = 2;
            this.buttonFilesAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesAll.DesignerSelected = false;
            this.buttonFilesAll.DimFactorClick = 0;
            this.buttonFilesAll.DimFactorHover = 0;
            this.buttonFilesAll.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesAll.ImageIndex = 0;
            this.buttonFilesAll.Location = new System.Drawing.Point(13, 61);
            this.buttonFilesAll.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesAll.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesAll.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesAll.Name = "buttonFilesAll";
            this.buttonFilesAll.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesAll.Size = new System.Drawing.Size(40, 27);
            this.buttonFilesAll.TabIndex = 3;
            this.buttonFilesAll.Text = "All";
            this.buttonFilesAll.TextShadowShow = false;
            this.buttonFilesAll.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesAll_ClickButtonArea);
            // 
            // buttonFilesBooks
            // 
            this.buttonFilesBooks.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesBooks.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesBooks.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesBooks.Corners.UpperLeft = 2;
            this.buttonFilesBooks.Corners.UpperRight = 2;
            this.buttonFilesBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesBooks.DesignerSelected = false;
            this.buttonFilesBooks.DimFactorClick = 0;
            this.buttonFilesBooks.DimFactorHover = 0;
            this.buttonFilesBooks.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesBooks.ImageIndex = 0;
            this.buttonFilesBooks.Location = new System.Drawing.Point(243, 61);
            this.buttonFilesBooks.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesBooks.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesBooks.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesBooks.Name = "buttonFilesBooks";
            this.buttonFilesBooks.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesBooks.Size = new System.Drawing.Size(61, 27);
            this.buttonFilesBooks.TabIndex = 5;
            this.buttonFilesBooks.Text = "Books";
            this.buttonFilesBooks.TextShadowShow = false;
            this.buttonFilesBooks.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesBooks_ClickButtonArea);
            // 
            // buttonFilesVideo
            // 
            this.buttonFilesVideo.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesVideo.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesVideo.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesVideo.Corners.UpperLeft = 2;
            this.buttonFilesVideo.Corners.UpperRight = 2;
            this.buttonFilesVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesVideo.DesignerSelected = false;
            this.buttonFilesVideo.DimFactorClick = 0;
            this.buttonFilesVideo.DimFactorHover = 0;
            this.buttonFilesVideo.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesVideo.ImageIndex = 0;
            this.buttonFilesVideo.Location = new System.Drawing.Point(53, 61);
            this.buttonFilesVideo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesVideo.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesVideo.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesVideo.Name = "buttonFilesVideo";
            this.buttonFilesVideo.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesVideo.Size = new System.Drawing.Size(130, 27);
            this.buttonFilesVideo.TabIndex = 4;
            this.buttonFilesVideo.Text = "TV/Movies/Video";
            this.buttonFilesVideo.TextShadowShow = false;
            this.buttonFilesVideo.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesVideo_ClickButtonArea);
            // 
            // tabDiscover
            // 
            this.tabDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabDiscover.Controls.Add(this.splitterHeaderDiscover);
            this.tabDiscover.Controls.Add(this.labelTitleDiscover);
            this.tabDiscover.Controls.Add(this.dataGridDiscover);
            this.tabDiscover.ForeColor = System.Drawing.Color.White;
            this.tabDiscover.Location = new System.Drawing.Point(4, 22);
            this.tabDiscover.Name = "tabDiscover";
            this.tabDiscover.Size = new System.Drawing.Size(1048, 607);
            this.tabDiscover.TabIndex = 7;
            // 
            // splitterHeaderDiscover
            // 
            this.splitterHeaderDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderDiscover.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderDiscover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderDiscover.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderDiscover.DesignerSelected = false;
            this.splitterHeaderDiscover.DimFactorClick = 0;
            this.splitterHeaderDiscover.DimFactorHover = 0;
            this.splitterHeaderDiscover.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderDiscover.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderDiscover.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderDiscover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderDiscover.ImageIndex = 0;
            this.splitterHeaderDiscover.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderDiscover.Location = new System.Drawing.Point(14, 45);
            this.splitterHeaderDiscover.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderDiscover.Name = "splitterHeaderDiscover";
            this.splitterHeaderDiscover.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderDiscover.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderDiscover.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderDiscover.Size = new System.Drawing.Size(1020, 1);
            this.splitterHeaderDiscover.TabIndex = 0;
            this.splitterHeaderDiscover.TabStop = false;
            this.splitterHeaderDiscover.Text = "";
            this.splitterHeaderDiscover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderDiscover.TextShadowShow = false;
            // 
            // labelTitleDiscover
            // 
            this.labelTitleDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleDiscover.AutoEllipsis = true;
            this.labelTitleDiscover.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleDiscover.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.labelTitleDiscover.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleDiscover.Location = new System.Drawing.Point(9, 13);
            this.labelTitleDiscover.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleDiscover.Name = "labelTitleDiscover";
            this.labelTitleDiscover.Size = new System.Drawing.Size(1020, 32);
            this.labelTitleDiscover.TabIndex = 0;
            this.labelTitleDiscover.Text = "Every website/domain crawled by FileMasta ready to be discovered.";
            this.labelTitleDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridDiscover
            // 
            this.dataGridDiscover.AllowUserToAddRows = false;
            this.dataGridDiscover.AllowUserToDeleteRows = false;
            this.dataGridDiscover.AllowUserToResizeColumns = false;
            this.dataGridDiscover.AllowUserToResizeRows = false;
            this.dataGridDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDiscover.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDiscover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDiscover.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridDiscover.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridDiscover.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDiscover.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridDiscover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiscover.ColumnHeadersVisible = false;
            this.dataGridDiscover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDiscoverCount,
            this.columnDiscoverSite,
            this.columnDiscoverType,
            this.columnDiscoverURL});
            this.dataGridDiscover.EnableHeadersVisualStyles = false;
            this.dataGridDiscover.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDiscover.Location = new System.Drawing.Point(0, 50);
            this.dataGridDiscover.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGridDiscover.MultiSelect = false;
            this.dataGridDiscover.Name = "dataGridDiscover";
            this.dataGridDiscover.ReadOnly = true;
            this.dataGridDiscover.RowHeadersVisible = false;
            this.dataGridDiscover.RowHeadersWidth = 40;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDiscover.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDiscover.RowTemplate.Height = 30;
            this.dataGridDiscover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDiscover.ShowEditingIcon = false;
            this.dataGridDiscover.Size = new System.Drawing.Size(1048, 557);
            this.dataGridDiscover.TabIndex = 0;
            this.dataGridDiscover.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDiscover_CellClick);
            // 
            // columnDiscoverCount
            // 
            this.columnDiscoverCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.columnDiscoverCount.HeaderText = "Count";
            this.columnDiscoverCount.Name = "columnDiscoverCount";
            this.columnDiscoverCount.ReadOnly = true;
            this.columnDiscoverCount.Width = 5;
            // 
            // columnDiscoverSite
            // 
            this.columnDiscoverSite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDiscoverSite.HeaderText = "Site";
            this.columnDiscoverSite.Name = "columnDiscoverSite";
            this.columnDiscoverSite.ReadOnly = true;
            // 
            // columnDiscoverType
            // 
            this.columnDiscoverType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnDiscoverType.HeaderText = "Type";
            this.columnDiscoverType.Name = "columnDiscoverType";
            this.columnDiscoverType.ReadOnly = true;
            // 
            // columnDiscoverURL
            // 
            this.columnDiscoverURL.HeaderText = "URL";
            this.columnDiscoverURL.Name = "columnDiscoverURL";
            this.columnDiscoverURL.ReadOnly = true;
            this.columnDiscoverURL.Visible = false;
            // 
            // tabSubmit
            // 
            this.tabSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSubmit.Controls.Add(this.splitterHeaderSubmit);
            this.tabSubmit.Controls.Add(this.flowLayoutSubmitControls);
            this.tabSubmit.Controls.Add(this.labelTitleSubmit);
            this.tabSubmit.ForeColor = System.Drawing.Color.White;
            this.tabSubmit.Location = new System.Drawing.Point(4, 22);
            this.tabSubmit.Name = "tabSubmit";
            this.tabSubmit.Size = new System.Drawing.Size(1048, 607);
            this.tabSubmit.TabIndex = 8;
            // 
            // splitterHeaderSubmit
            // 
            this.splitterHeaderSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderSubmit.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderSubmit.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderSubmit.DesignerSelected = false;
            this.splitterHeaderSubmit.DimFactorClick = 0;
            this.splitterHeaderSubmit.DimFactorHover = 0;
            this.splitterHeaderSubmit.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderSubmit.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderSubmit.ImageIndex = 0;
            this.splitterHeaderSubmit.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderSubmit.Location = new System.Drawing.Point(14, 45);
            this.splitterHeaderSubmit.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderSubmit.Name = "splitterHeaderSubmit";
            this.splitterHeaderSubmit.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderSubmit.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderSubmit.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderSubmit.Size = new System.Drawing.Size(1020, 1);
            this.splitterHeaderSubmit.TabIndex = 0;
            this.splitterHeaderSubmit.TabStop = false;
            this.splitterHeaderSubmit.Text = "";
            this.splitterHeaderSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderSubmit.TextShadowShow = false;
            // 
            // flowLayoutSubmitControls
            // 
            this.flowLayoutSubmitControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutSubmitControls.AutoSize = true;
            this.flowLayoutSubmitControls.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutSubmitControls.Controls.Add(this.labelSubmitDescription);
            this.flowLayoutSubmitControls.Controls.Add(this.panelSubmitLink);
            this.flowLayoutSubmitControls.Location = new System.Drawing.Point(10, 56);
            this.flowLayoutSubmitControls.Name = "flowLayoutSubmitControls";
            this.flowLayoutSubmitControls.Size = new System.Drawing.Size(1036, 496);
            this.flowLayoutSubmitControls.TabIndex = 0;
            this.flowLayoutSubmitControls.TabStop = true;
            // 
            // labelSubmitDescription
            // 
            this.labelSubmitDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubmitDescription.AutoEllipsis = true;
            this.labelSubmitDescription.AutoSize = true;
            this.labelSubmitDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelSubmitDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelSubmitDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSubmitDescription.Location = new System.Drawing.Point(0, 0);
            this.labelSubmitDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelSubmitDescription.Name = "labelSubmitDescription";
            this.labelSubmitDescription.Size = new System.Drawing.Size(1033, 255);
            this.labelSubmitDescription.TabIndex = 0;
            this.labelSubmitDescription.Text = resources.GetString("labelSubmitDescription.Text");
            // 
            // panelSubmitLink
            // 
            this.panelSubmitLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubmitLink.BackColor = System.Drawing.Color.Transparent;
            this.panelSubmitLink.Controls.Add(this.buttonSubmitUrl);
            this.panelSubmitLink.Controls.Add(this.textBoxSubmitLink);
            this.panelSubmitLink.Controls.Add(this.textBoxBackgroundSubmitLink);
            this.panelSubmitLink.Location = new System.Drawing.Point(0, 280);
            this.panelSubmitLink.Margin = new System.Windows.Forms.Padding(0, 25, 0, 3);
            this.panelSubmitLink.Name = "panelSubmitLink";
            this.panelSubmitLink.Size = new System.Drawing.Size(1036, 38);
            this.panelSubmitLink.TabIndex = 0;
            // 
            // buttonSubmitUrl
            // 
            this.buttonSubmitUrl.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmitUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonSubmitUrl.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonSubmitUrl.Corners.All = 2;
            this.buttonSubmitUrl.Corners.LowerLeft = 2;
            this.buttonSubmitUrl.Corners.LowerRight = 2;
            this.buttonSubmitUrl.Corners.UpperLeft = 2;
            this.buttonSubmitUrl.Corners.UpperRight = 2;
            this.buttonSubmitUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmitUrl.DesignerSelected = false;
            this.buttonSubmitUrl.DimFactorClick = 0;
            this.buttonSubmitUrl.DimFactorHover = 0;
            this.buttonSubmitUrl.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonSubmitUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonSubmitUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonSubmitUrl.ImageIndex = 0;
            this.buttonSubmitUrl.Location = new System.Drawing.Point(414, 4);
            this.buttonSubmitUrl.MaximumSize = new System.Drawing.Size(1000, 30);
            this.buttonSubmitUrl.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonSubmitUrl.Name = "buttonSubmitUrl";
            this.buttonSubmitUrl.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonSubmitUrl.Size = new System.Drawing.Size(66, 30);
            this.buttonSubmitUrl.TabIndex = 1;
            this.buttonSubmitUrl.Text = "Submit";
            this.buttonSubmitUrl.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSubmitUrl.TextShadowShow = false;
            this.buttonSubmitUrl.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonSubmitUrl_ClickButtonArea);
            // 
            // textBoxSubmitLink
            // 
            this.textBoxSubmitLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxSubmitLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSubmitLink.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxSubmitLink.ForeColor = System.Drawing.Color.White;
            this.textBoxSubmitLink.Location = new System.Drawing.Point(13, 9);
            this.textBoxSubmitLink.Name = "textBoxSubmitLink";
            this.textBoxSubmitLink.Size = new System.Drawing.Size(386, 18);
            this.textBoxSubmitLink.TabIndex = 0;
            this.textBoxSubmitLink.WaterMark = "Link/website";
            this.textBoxSubmitLink.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxSubmitLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxSubmitLink.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            // 
            // textBoxBackgroundSubmitLink
            // 
            this.textBoxBackgroundSubmitLink.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundSubmitLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundSubmitLink.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundSubmitLink.Corners.All = 2;
            this.textBoxBackgroundSubmitLink.Corners.LowerLeft = 2;
            this.textBoxBackgroundSubmitLink.Corners.LowerRight = 2;
            this.textBoxBackgroundSubmitLink.Corners.UpperLeft = 2;
            this.textBoxBackgroundSubmitLink.Corners.UpperRight = 2;
            this.textBoxBackgroundSubmitLink.DesignerSelected = false;
            this.textBoxBackgroundSubmitLink.DimFactorClick = 0;
            this.textBoxBackgroundSubmitLink.DimFactorHover = 0;
            this.textBoxBackgroundSubmitLink.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundSubmitLink.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundSubmitLink.ImageIndex = 0;
            this.textBoxBackgroundSubmitLink.Location = new System.Drawing.Point(4, 4);
            this.textBoxBackgroundSubmitLink.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.textBoxBackgroundSubmitLink.Name = "textBoxBackgroundSubmitLink";
            this.textBoxBackgroundSubmitLink.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundSubmitLink.Size = new System.Drawing.Size(405, 30);
            this.textBoxBackgroundSubmitLink.TabIndex = 0;
            this.textBoxBackgroundSubmitLink.TabStop = false;
            this.textBoxBackgroundSubmitLink.Text = "";
            this.textBoxBackgroundSubmitLink.TextShadow = System.Drawing.Color.Empty;
            // 
            // labelTitleSubmit
            // 
            this.labelTitleSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleSubmit.AutoEllipsis = true;
            this.labelTitleSubmit.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.labelTitleSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleSubmit.Location = new System.Drawing.Point(9, 13);
            this.labelTitleSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleSubmit.Name = "labelTitleSubmit";
            this.labelTitleSubmit.Size = new System.Drawing.Size(1030, 32);
            this.labelTitleSubmit.TabIndex = 0;
            this.labelTitleSubmit.Text = "Submit Link";
            this.labelTitleSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabSettings
            // 
            this.tabSettings.AutoScroll = true;
            this.tabSettings.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSettings.Controls.Add(this.buttonSaveSettings);
            this.tabSettings.Controls.Add(this.buttonRestoreSettings);
            this.tabSettings.Controls.Add(this.splitterHeaderSettings);
            this.tabSettings.Controls.Add(this.labelTitleGeneral);
            this.tabSettings.Controls.Add(this.labelClearDataOnClose);
            this.tabSettings.Controls.Add(this.checkBoxClearDataOnClose);
            this.tabSettings.ForeColor = System.Drawing.Color.White;
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1048, 607);
            this.tabSettings.TabIndex = 6;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonSaveSettings.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonSaveSettings.Corners.All = 2;
            this.buttonSaveSettings.Corners.LowerLeft = 2;
            this.buttonSaveSettings.Corners.LowerRight = 2;
            this.buttonSaveSettings.Corners.UpperLeft = 2;
            this.buttonSaveSettings.Corners.UpperRight = 2;
            this.buttonSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveSettings.DesignerSelected = false;
            this.buttonSaveSettings.DimFactorClick = 0;
            this.buttonSaveSettings.DimFactorHover = 0;
            this.buttonSaveSettings.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonSaveSettings.ImageIndex = 0;
            this.buttonSaveSettings.Location = new System.Drawing.Point(89, 110);
            this.buttonSaveSettings.MaximumSize = new System.Drawing.Size(1000, 30);
            this.buttonSaveSettings.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonSaveSettings.Size = new System.Drawing.Size(52, 30);
            this.buttonSaveSettings.TabIndex = 3;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonSaveSettings.TextShadowShow = false;
            this.buttonSaveSettings.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonSettingsSave_ClickButtonArea);
            // 
            // buttonRestoreSettings
            // 
            this.buttonRestoreSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestoreSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonRestoreSettings.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonRestoreSettings.Corners.All = 2;
            this.buttonRestoreSettings.Corners.LowerLeft = 2;
            this.buttonRestoreSettings.Corners.LowerRight = 2;
            this.buttonRestoreSettings.Corners.UpperLeft = 2;
            this.buttonRestoreSettings.Corners.UpperRight = 2;
            this.buttonRestoreSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestoreSettings.DesignerSelected = false;
            this.buttonRestoreSettings.DimFactorClick = 0;
            this.buttonRestoreSettings.DimFactorHover = 0;
            this.buttonRestoreSettings.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonRestoreSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonRestoreSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonRestoreSettings.ImageIndex = 0;
            this.buttonRestoreSettings.Location = new System.Drawing.Point(14, 110);
            this.buttonRestoreSettings.MaximumSize = new System.Drawing.Size(1000, 30);
            this.buttonRestoreSettings.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonRestoreSettings.Name = "buttonRestoreSettings";
            this.buttonRestoreSettings.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonRestoreSettings.Size = new System.Drawing.Size(69, 30);
            this.buttonRestoreSettings.TabIndex = 2;
            this.buttonRestoreSettings.Text = "Restore";
            this.buttonRestoreSettings.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonRestoreSettings.TextShadowShow = false;
            this.buttonRestoreSettings.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonSettingsRestoreDefault_ClickButtonArea);
            // 
            // splitterHeaderSettings
            // 
            this.splitterHeaderSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderSettings.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderSettings.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderSettings.DesignerSelected = false;
            this.splitterHeaderSettings.DimFactorClick = 0;
            this.splitterHeaderSettings.DimFactorHover = 0;
            this.splitterHeaderSettings.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderSettings.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderSettings.ImageIndex = 0;
            this.splitterHeaderSettings.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderSettings.Location = new System.Drawing.Point(14, 45);
            this.splitterHeaderSettings.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderSettings.Name = "splitterHeaderSettings";
            this.splitterHeaderSettings.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderSettings.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderSettings.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderSettings.Size = new System.Drawing.Size(993, 1);
            this.splitterHeaderSettings.TabIndex = 0;
            this.splitterHeaderSettings.TabStop = false;
            this.splitterHeaderSettings.Text = "";
            this.splitterHeaderSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderSettings.TextShadowShow = false;
            // 
            // labelTitleGeneral
            // 
            this.labelTitleGeneral.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.labelTitleGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleGeneral.Location = new System.Drawing.Point(9, 13);
            this.labelTitleGeneral.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelTitleGeneral.Name = "labelTitleGeneral";
            this.labelTitleGeneral.Size = new System.Drawing.Size(1030, 32);
            this.labelTitleGeneral.TabIndex = 0;
            this.labelTitleGeneral.Text = "General";
            // 
            // labelClearDataOnClose
            // 
            this.labelClearDataOnClose.AutoSize = true;
            this.labelClearDataOnClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClearDataOnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelClearDataOnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelClearDataOnClose.Location = new System.Drawing.Point(11, 61);
            this.labelClearDataOnClose.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelClearDataOnClose.Name = "labelClearDataOnClose";
            this.labelClearDataOnClose.Size = new System.Drawing.Size(124, 17);
            this.labelClearDataOnClose.TabIndex = 0;
            this.labelClearDataOnClose.Text = "Clear data on close:";
            // 
            // checkBoxClearDataOnClose
            // 
            this.checkBoxClearDataOnClose.AutoSize = true;
            this.checkBoxClearDataOnClose.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxClearDataOnClose.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.checkBoxClearDataOnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxClearDataOnClose.Location = new System.Drawing.Point(275, 63);
            this.checkBoxClearDataOnClose.Name = "checkBoxClearDataOnClose";
            this.checkBoxClearDataOnClose.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClearDataOnClose.TabIndex = 1;
            this.checkBoxClearDataOnClose.UseVisualStyleBackColor = false;
            // 
            // tabInformation
            // 
            this.tabInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabInformation.Controls.Add(this.labelKeyboardShortcuts);
            this.tabInformation.Controls.Add(this.labelPrivacyPolicy);
            this.tabInformation.Controls.Add(this.labelTermsOfUse);
            this.tabInformation.Controls.Add(this.labelChangeLog);
            this.tabInformation.Controls.Add(this.labelReportIssue);
            this.tabInformation.Controls.Add(this.labelMadeWithLove);
            this.tabInformation.Controls.Add(this.labelAboutApp);
            this.tabInformation.ForeColor = System.Drawing.Color.White;
            this.tabInformation.Location = new System.Drawing.Point(4, 22);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.Size = new System.Drawing.Size(1048, 607);
            this.tabInformation.TabIndex = 2;
            // 
            // labelKeyboardShortcuts
            // 
            this.labelKeyboardShortcuts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKeyboardShortcuts.AutoSize = true;
            this.labelKeyboardShortcuts.BackColor = System.Drawing.Color.Transparent;
            this.labelKeyboardShortcuts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelKeyboardShortcuts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelKeyboardShortcuts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKeyboardShortcuts.Location = new System.Drawing.Point(256, 578);
            this.labelKeyboardShortcuts.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelKeyboardShortcuts.Name = "labelKeyboardShortcuts";
            this.labelKeyboardShortcuts.Size = new System.Drawing.Size(110, 15);
            this.labelKeyboardShortcuts.TabIndex = 15;
            this.labelKeyboardShortcuts.Text = "Keyboard Shortcuts";
            this.labelKeyboardShortcuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKeyboardShortcuts.Click += new System.EventHandler(this.labelKeyboardShortcuts_Click);
            // 
            // labelPrivacyPolicy
            // 
            this.labelPrivacyPolicy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPrivacyPolicy.AutoSize = true;
            this.labelPrivacyPolicy.BackColor = System.Drawing.Color.Transparent;
            this.labelPrivacyPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPrivacyPolicy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPrivacyPolicy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrivacyPolicy.Location = new System.Drawing.Point(170, 578);
            this.labelPrivacyPolicy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelPrivacyPolicy.Name = "labelPrivacyPolicy";
            this.labelPrivacyPolicy.Size = new System.Drawing.Size(80, 15);
            this.labelPrivacyPolicy.TabIndex = 14;
            this.labelPrivacyPolicy.Text = "Privacy Policy";
            this.labelPrivacyPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrivacyPolicy.Click += new System.EventHandler(this.buttonPrivacyPolicy_Click);
            // 
            // labelTermsOfUse
            // 
            this.labelTermsOfUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTermsOfUse.AutoSize = true;
            this.labelTermsOfUse.BackColor = System.Drawing.Color.Transparent;
            this.labelTermsOfUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTermsOfUse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTermsOfUse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTermsOfUse.Location = new System.Drawing.Point(89, 578);
            this.labelTermsOfUse.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelTermsOfUse.Name = "labelTermsOfUse";
            this.labelTermsOfUse.Size = new System.Drawing.Size(75, 15);
            this.labelTermsOfUse.TabIndex = 13;
            this.labelTermsOfUse.Text = "Terms of Use";
            this.labelTermsOfUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTermsOfUse.Click += new System.EventHandler(this.buttonTermsOfUse_Click);
            // 
            // labelChangeLog
            // 
            this.labelChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChangeLog.BackColor = System.Drawing.Color.Transparent;
            this.labelChangeLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangeLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelChangeLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelChangeLog.Location = new System.Drawing.Point(863, 578);
            this.labelChangeLog.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelChangeLog.Name = "labelChangeLog";
            this.labelChangeLog.Size = new System.Drawing.Size(173, 15);
            this.labelChangeLog.TabIndex = 12;
            this.labelChangeLog.Text = "Change Log - v{0}";
            this.labelChangeLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelChangeLog.Click += new System.EventHandler(this.labelChangeLog_Click);
            // 
            // labelReportIssue
            // 
            this.labelReportIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReportIssue.AutoSize = true;
            this.labelReportIssue.BackColor = System.Drawing.Color.Transparent;
            this.labelReportIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReportIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelReportIssue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelReportIssue.Location = new System.Drawing.Point(12, 578);
            this.labelReportIssue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelReportIssue.Name = "labelReportIssue";
            this.labelReportIssue.Size = new System.Drawing.Size(71, 15);
            this.labelReportIssue.TabIndex = 11;
            this.labelReportIssue.Text = "Report Issue";
            this.labelReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReportIssue.Click += new System.EventHandler(this.labelReportIssue_Click);
            // 
            // labelMadeWithLove
            // 
            this.labelMadeWithLove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMadeWithLove.AutoSize = true;
            this.labelMadeWithLove.BackColor = System.Drawing.Color.Transparent;
            this.labelMadeWithLove.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMadeWithLove.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelMadeWithLove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMadeWithLove.Location = new System.Drawing.Point(367, 539);
            this.labelMadeWithLove.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelMadeWithLove.Name = "labelMadeWithLove";
            this.labelMadeWithLove.Size = new System.Drawing.Size(314, 20);
            this.labelMadeWithLove.TabIndex = 10;
            this.labelMadeWithLove.Text = "Made with ❤ by geeks from around the world";
            this.labelMadeWithLove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAboutApp
            // 
            this.labelAboutApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAboutApp.AutoEllipsis = true;
            this.labelAboutApp.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutApp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelAboutApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAboutApp.Location = new System.Drawing.Point(128, 84);
            this.labelAboutApp.Name = "labelAboutApp";
            this.labelAboutApp.Size = new System.Drawing.Size(792, 439);
            this.labelAboutApp.TabIndex = 0;
            this.labelAboutApp.Text = resources.GetString("labelAboutApp.Text");
            this.labelAboutApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabBlank
            // 
            this.tabBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabBlank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBlank.ForeColor = System.Drawing.Color.White;
            this.tabBlank.Location = new System.Drawing.Point(4, 22);
            this.tabBlank.Name = "tabBlank";
            this.tabBlank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBlank.Size = new System.Drawing.Size(1048, 607);
            this.tabBlank.TabIndex = 3;
            // 
            // panelTabTitles
            // 
            this.panelTabTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelTabTitles.Controls.Add(this.titleInformation);
            this.panelTabTitles.Controls.Add(this.titleSettings);
            this.panelTabTitles.Controls.Add(this.titleSubmit);
            this.panelTabTitles.Controls.Add(this.titleDiscover);
            this.panelTabTitles.Controls.Add(this.titleSearch);
            this.panelTabTitles.Controls.Add(this.titleHome);
            this.panelTabTitles.Controls.Add(this.imageFacebook);
            this.panelTabTitles.Controls.Add(this.imageTwitter);
            this.panelTabTitles.ForeColor = System.Drawing.Color.White;
            this.panelTabTitles.Location = new System.Drawing.Point(0, 0);
            this.panelTabTitles.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabTitles.Name = "panelTabTitles";
            this.panelTabTitles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTabTitles.Size = new System.Drawing.Size(1048, 34);
            this.panelTabTitles.TabIndex = 1;
            // 
            // titleInformation
            // 
            this.titleInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleInformation.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleInformation.Corners.All = 2;
            this.titleInformation.Corners.LowerLeft = 2;
            this.titleInformation.Corners.LowerRight = 2;
            this.titleInformation.Corners.UpperLeft = 2;
            this.titleInformation.Corners.UpperRight = 2;
            this.titleInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleInformation.DesignerSelected = false;
            this.titleInformation.DimFactorClick = 0;
            this.titleInformation.DimFactorHover = 0;
            this.titleInformation.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.titleInformation.Image = global::FileMasta.Properties.Resources.info;
            this.titleInformation.ImageIndex = 0;
            this.titleInformation.Location = new System.Drawing.Point(444, 0);
            this.titleInformation.Margin = new System.Windows.Forms.Padding(0);
            this.titleInformation.MaximumSize = new System.Drawing.Size(1000, 34);
            this.titleInformation.MinimumSize = new System.Drawing.Size(0, 34);
            this.titleInformation.Name = "titleInformation";
            this.titleInformation.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleInformation.Size = new System.Drawing.Size(117, 34);
            this.titleInformation.TabIndex = 0;
            this.titleInformation.Text = "Information";
            this.titleInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.titleInformation.TextMargin = new System.Windows.Forms.Padding(0);
            this.titleInformation.TextShadowShow = false;
            this.titleInformation.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleInformation_ClickButtonArea);
            // 
            // titleSettings
            // 
            this.titleSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSettings.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSettings.Corners.All = 2;
            this.titleSettings.Corners.LowerLeft = 2;
            this.titleSettings.Corners.LowerRight = 2;
            this.titleSettings.Corners.UpperLeft = 2;
            this.titleSettings.Corners.UpperRight = 2;
            this.titleSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleSettings.DesignerSelected = false;
            this.titleSettings.DimFactorClick = 0;
            this.titleSettings.DimFactorHover = 0;
            this.titleSettings.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.titleSettings.Image = global::FileMasta.Properties.Resources.settings;
            this.titleSettings.ImageIndex = 0;
            this.titleSettings.Location = new System.Drawing.Point(350, 0);
            this.titleSettings.Margin = new System.Windows.Forms.Padding(0);
            this.titleSettings.MaximumSize = new System.Drawing.Size(1000, 34);
            this.titleSettings.MinimumSize = new System.Drawing.Size(0, 34);
            this.titleSettings.Name = "titleSettings";
            this.titleSettings.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleSettings.Size = new System.Drawing.Size(94, 34);
            this.titleSettings.TabIndex = 1;
            this.titleSettings.Text = "Settings";
            this.titleSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.titleSettings.TextMargin = new System.Windows.Forms.Padding(0);
            this.titleSettings.TextShadowShow = false;
            this.titleSettings.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleSettings_ClickButtonArea);
            // 
            // titleSubmit
            // 
            this.titleSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSubmit.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSubmit.Corners.All = 2;
            this.titleSubmit.Corners.LowerLeft = 2;
            this.titleSubmit.Corners.LowerRight = 2;
            this.titleSubmit.Corners.UpperLeft = 2;
            this.titleSubmit.Corners.UpperRight = 2;
            this.titleSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleSubmit.DesignerSelected = false;
            this.titleSubmit.DimFactorClick = 0;
            this.titleSubmit.DimFactorHover = 0;
            this.titleSubmit.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.titleSubmit.Image = global::FileMasta.Properties.Resources.send;
            this.titleSubmit.ImageIndex = 0;
            this.titleSubmit.Location = new System.Drawing.Point(262, 0);
            this.titleSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.titleSubmit.MaximumSize = new System.Drawing.Size(1000, 34);
            this.titleSubmit.MinimumSize = new System.Drawing.Size(0, 34);
            this.titleSubmit.Name = "titleSubmit";
            this.titleSubmit.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleSubmit.Size = new System.Drawing.Size(88, 34);
            this.titleSubmit.TabIndex = 2;
            this.titleSubmit.Text = "Submit";
            this.titleSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.titleSubmit.TextMargin = new System.Windows.Forms.Padding(0);
            this.titleSubmit.TextShadowShow = false;
            this.titleSubmit.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleSubmit_ClickButtonArea);
            // 
            // titleDiscover
            // 
            this.titleDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleDiscover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleDiscover.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleDiscover.Corners.All = 2;
            this.titleDiscover.Corners.LowerLeft = 2;
            this.titleDiscover.Corners.LowerRight = 2;
            this.titleDiscover.Corners.UpperLeft = 2;
            this.titleDiscover.Corners.UpperRight = 2;
            this.titleDiscover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleDiscover.DesignerSelected = false;
            this.titleDiscover.DimFactorClick = 0;
            this.titleDiscover.DimFactorHover = 0;
            this.titleDiscover.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleDiscover.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.titleDiscover.Image = global::FileMasta.Properties.Resources.web;
            this.titleDiscover.ImageIndex = 0;
            this.titleDiscover.Location = new System.Drawing.Point(166, 0);
            this.titleDiscover.Margin = new System.Windows.Forms.Padding(0);
            this.titleDiscover.MaximumSize = new System.Drawing.Size(1000, 34);
            this.titleDiscover.MinimumSize = new System.Drawing.Size(0, 34);
            this.titleDiscover.Name = "titleDiscover";
            this.titleDiscover.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleDiscover.Size = new System.Drawing.Size(96, 34);
            this.titleDiscover.TabIndex = 3;
            this.titleDiscover.Text = "Discover";
            this.titleDiscover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.titleDiscover.TextMargin = new System.Windows.Forms.Padding(0);
            this.titleDiscover.TextShadowShow = false;
            this.titleDiscover.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleDiscover_ClickButtonArea);
            // 
            // titleSearch
            // 
            this.titleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSearch.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleSearch.Corners.All = 2;
            this.titleSearch.Corners.LowerLeft = 2;
            this.titleSearch.Corners.LowerRight = 2;
            this.titleSearch.Corners.UpperLeft = 2;
            this.titleSearch.Corners.UpperRight = 2;
            this.titleSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleSearch.DesignerSelected = false;
            this.titleSearch.DimFactorClick = 0;
            this.titleSearch.DimFactorHover = 0;
            this.titleSearch.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.titleSearch.Image = global::FileMasta.Properties.Resources.magnify;
            this.titleSearch.ImageIndex = 0;
            this.titleSearch.Location = new System.Drawing.Point(81, 0);
            this.titleSearch.Margin = new System.Windows.Forms.Padding(0);
            this.titleSearch.MaximumSize = new System.Drawing.Size(1000, 34);
            this.titleSearch.MinimumSize = new System.Drawing.Size(0, 34);
            this.titleSearch.Name = "titleSearch";
            this.titleSearch.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleSearch.Size = new System.Drawing.Size(85, 34);
            this.titleSearch.TabIndex = 4;
            this.titleSearch.Text = "Search";
            this.titleSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.titleSearch.TextMargin = new System.Windows.Forms.Padding(0);
            this.titleSearch.TextShadowShow = false;
            this.titleSearch.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleSearch_ClickButtonArea);
            // 
            // titleHome
            // 
            this.titleHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleHome.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleHome.Corners.All = 2;
            this.titleHome.Corners.LowerLeft = 2;
            this.titleHome.Corners.LowerRight = 2;
            this.titleHome.Corners.UpperLeft = 2;
            this.titleHome.Corners.UpperRight = 2;
            this.titleHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleHome.DesignerSelected = false;
            this.titleHome.DimFactorClick = 0;
            this.titleHome.DimFactorHover = 0;
            this.titleHome.FillType = CButtonLib.CButton.eFillType.Solid;
            this.titleHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.titleHome.Image = global::FileMasta.Properties.Resources.home;
            this.titleHome.ImageIndex = 0;
            this.titleHome.Location = new System.Drawing.Point(0, 0);
            this.titleHome.Margin = new System.Windows.Forms.Padding(0);
            this.titleHome.MaximumSize = new System.Drawing.Size(1000, 34);
            this.titleHome.MinimumSize = new System.Drawing.Size(0, 34);
            this.titleHome.Name = "titleHome";
            this.titleHome.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.titleHome.Size = new System.Drawing.Size(81, 34);
            this.titleHome.TabIndex = 5;
            this.titleHome.Text = "Home";
            this.titleHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.titleHome.TextMargin = new System.Windows.Forms.Padding(0);
            this.titleHome.TextShadowShow = false;
            this.titleHome.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.titleHome_ClickButtonArea);
            // 
            // imageFacebook
            // 
            this.imageFacebook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imageFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageFacebook.Image = global::FileMasta.Properties.Resources.facebook;
            this.imageFacebook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageFacebook.Location = new System.Drawing.Point(988, 7);
            this.imageFacebook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imageFacebook.Name = "imageFacebook";
            this.imageFacebook.Size = new System.Drawing.Size(20, 20);
            this.imageFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageFacebook.TabIndex = 34;
            this.imageFacebook.TabStop = false;
            this.imageFacebook.Click += new System.EventHandler(this.imageShareFacebook_Click);
            // 
            // imageTwitter
            // 
            this.imageTwitter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imageTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageTwitter.Image = global::FileMasta.Properties.Resources.twitter;
            this.imageTwitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageTwitter.Location = new System.Drawing.Point(1016, 7);
            this.imageTwitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imageTwitter.Name = "imageTwitter";
            this.imageTwitter.Size = new System.Drawing.Size(20, 20);
            this.imageTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageTwitter.TabIndex = 33;
            this.imageTwitter.TabStop = false;
            this.imageTwitter.Click += new System.EventHandler(this.imageShareTwitter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1048, 641);
            this.Controls.Add(this.panelTabTitles);
            this.Controls.Add(this.tab);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1025, 625);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMasta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tab.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.flowLayoutSearchItems.ResumeLayout(false);
            this.flowLayoutSearchHome.ResumeLayout(false);
            this.containerFileType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecentlyAdded)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.flowLayoutSearchFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSearchFiles)).EndInit();
            this.flowLayoutFilterFiles.ResumeLayout(false);
            this.flowLayoutSortFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.tabDiscover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscover)).EndInit();
            this.tabSubmit.ResumeLayout(false);
            this.tabSubmit.PerformLayout();
            this.flowLayoutSubmitControls.ResumeLayout(false);
            this.flowLayoutSubmitControls.PerformLayout();
            this.panelSubmitLink.ResumeLayout(false);
            this.panelSubmitLink.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabInformation.ResumeLayout(false);
            this.tabInformation.PerformLayout();
            this.panelTabTitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabInformation;
        private System.Windows.Forms.Label labelAboutApp;
        private System.Windows.Forms.Label labelChangeLog;
        private System.Windows.Forms.Label labelReportIssue;
        public System.Windows.Forms.TabControl tab;
        public System.Windows.Forms.TabPage tabBlank;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label labelClearDataOnClose;
        private System.Windows.Forms.CheckBox checkBoxClearDataOnClose;
        private System.Windows.Forms.Label labelTitleGeneral;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxSearchHome;
        private CButtonLib.CButton textBoxBackgroundSearchHome;
        public System.Windows.Forms.TabPage tabDiscover;
        private System.Windows.Forms.DataGridView dataGridDiscover;
        public System.Windows.Forms.Label labelTitleDiscover;
        public System.Windows.Forms.TabPage tabSubmit;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxSubmitLink;
        private CButtonLib.CButton textBoxBackgroundSubmitLink;
        public System.Windows.Forms.Label labelSubmitDescription;
        public System.Windows.Forms.Label labelTitleSubmit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSubmitControls;
        private System.Windows.Forms.Panel panelSubmitLink;
        public System.Windows.Forms.TabPage tabSearch;
        public System.Windows.Forms.Label labelNoResultsFound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSearchFiles;
        private System.Windows.Forms.Panel flowLayoutSortFiles;
        private CButtonLib.CButton buttonSortFiles;
        private System.Windows.Forms.ComboBox comboBoxSortFiles;
        private System.Windows.Forms.Panel flowLayoutFilterFiles;
        private CButtonLib.CButton buttonFilterFiles;
        private System.Windows.Forms.ComboBox comboBoxFilterFiles;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxSearchFiles;
        private CButtonLib.CButton splitterFilesType;
        private CButtonLib.CButton textBoxBackgroundSearchFiles;
        public System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Panel containerFileType;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTopSearches;
        private System.Windows.Forms.Label labelResultsInfo;
        private System.Windows.Forms.Label labelDatabaseStats;
        private System.Windows.Forms.Label labelDatabaseUpdatedDate;
        private System.Windows.Forms.Label labelTermsOfUse;
        private System.Windows.Forms.Label labelPrivacyPolicy;
        private System.Windows.Forms.PictureBox imageTwitter;
        private System.Windows.Forms.PictureBox imageFacebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesURL;
        private System.Windows.Forms.PictureBox imageSearchFiles;
        public CButtonLib.CButton splitterHeaderSettings;
        public CButtonLib.CButton splitterHeaderDiscover;
        public CButtonLib.CButton splitterHeaderSubmit;
        private Controls.buttonCustom buttonSubmitUrl;
        private Controls.buttonCustom buttonSaveSettings;
        private Controls.buttonCustom buttonRestoreSettings;
        internal System.Windows.Forms.Label labelRecentlyAdded;
        public CButtonLib.CButton splitterHeaderRecentlyAdded;
        public System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.Label labelMadeWithLove;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSearchItems;
        private System.Windows.Forms.DataGridView dataGridRecentlyAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRecentlyAddedType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRecentlyAddedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRecentlyAddedSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRecentlyAddedAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRecentlyAddedReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRecentlyAddedURL;
        internal System.Windows.Forms.Label labelTopSearches;
        public CButtonLib.CButton splitterHeaderTopSearches;
        private System.Windows.Forms.Panel flowLayoutSearchHome;
        private CButtonLib.CButton buttonSearchHome;
        private System.Windows.Forms.ComboBox comboBoxSearchHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverURL;
        public System.Windows.Forms.Panel panelTabTitles;
        public Controls.buttonTabTitle titleSearch;
        public Controls.buttonTabTitle titleHome;
        public Controls.buttonTabTitle titleSettings;
        public Controls.buttonTabTitle titleSubmit;
        public Controls.buttonTabTitle titleDiscover;
        public Controls.buttonTabTitle titleInformation;
        public CButtonLib.CButton buttonFileType;
        public Controls.buttonFileType buttonFilesVideo;
        public Controls.buttonFileType buttonFilesAudio;
        public Controls.buttonFileType buttonFilesBookmarks;
        public Controls.buttonFileType buttonFilesLocal;
        public Controls.buttonFileType buttonFilesTorrents;
        public Controls.buttonFileType buttonFilesOther;
        public Controls.buttonFileType buttonFilesSoftware;
        public Controls.buttonFileType buttonFilesCustom;
        public Controls.buttonFileType buttonFilesSubtitles;
        public Controls.buttonFileType buttonFilesAll;
        public Controls.buttonFileType buttonFilesBooks;
        private System.Windows.Forms.Label labelKeyboardShortcuts;
    }
}

