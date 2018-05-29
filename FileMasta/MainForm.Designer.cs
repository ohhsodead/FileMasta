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
            CButtonLib.cBlendItems cBlendItems3 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems4 = new CButtonLib.cBlendItems();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelDatabaseStats = new System.Windows.Forms.Label();
            this.textBoxSearchHome = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundSearchHome = new CButtonLib.CButton();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.buttonFilesImage = new FileMasta.Controls.buttonFileType();
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
            this.tabsDiscover = new System.Windows.Forms.TabControl();
            this.tabDiscoverHosts = new System.Windows.Forms.TabPage();
            this.dataGridDiscover = new System.Windows.Forms.DataGridView();
            this.columnDiscoverCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitterHeaderDiscover = new CButtonLib.CButton();
            this.labelTitleDiscover = new System.Windows.Forms.Label();
            this.tabDiscoverListings = new System.Windows.Forms.TabPage();
            this.labelDirectoryStatus = new System.Windows.Forms.Label();
            this.labelDirectoryEmptyResults = new System.Windows.Forms.Label();
            this.dataGridDirectoryListing = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelWebExplorerURL = new System.Windows.Forms.Label();
            this.buttonCloseDiscoverListing = new System.Windows.Forms.PictureBox();
            this.buttonViewDirectory = new FileMasta.Controls.buttonCustom();
            this.buttonGoUp = new FileMasta.Controls.buttonCustom();
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
            this.textBoxConnectionPassword = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundConnectionPassword = new CButtonLib.CButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConnectionUsername = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundConnectionUsername = new CButtonLib.CButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConnectionPort = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundConnectionPort = new CButtonLib.CButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConnectionAddress = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textBoxBackgroundConnectionAddress = new CButtonLib.CButton();
            this.labelConnectionAddress = new System.Windows.Forms.Label();
            this.splitterHeaderConnection = new CButtonLib.CButton();
            this.labelTitleSettings = new System.Windows.Forms.Label();
            this.labelConnectionDefault = new System.Windows.Forms.Label();
            this.checkBoxConnectionDefault = new System.Windows.Forms.CheckBox();
            this.buttonSaveSettings = new FileMasta.Controls.buttonCustom();
            this.buttonRestoreSettings = new FileMasta.Controls.buttonCustom();
            this.splitterHeaderGeneral = new CButtonLib.CButton();
            this.labelTitleGeneral = new System.Windows.Forms.Label();
            this.labelGeneralClearDataOnClose = new System.Windows.Forms.Label();
            this.checkBoxGeneralClearDataOnClose = new System.Windows.Forms.CheckBox();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.labelKeyboardShortcuts = new System.Windows.Forms.Label();
            this.labelPrivacyPolicy = new System.Windows.Forms.Label();
            this.labelTermsOfUse = new System.Windows.Forms.Label();
            this.labelChangeLog = new System.Windows.Forms.Label();
            this.labelReportIssue = new System.Windows.Forms.Label();
            this.labelMadeWithLove = new System.Windows.Forms.Label();
            this.labelAboutApp = new System.Windows.Forms.Label();
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
            this.tabSearch.SuspendLayout();
            this.flowLayoutSearchFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSearchFiles)).BeginInit();
            this.flowLayoutFilterFiles.SuspendLayout();
            this.flowLayoutSortFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.tabDiscover.SuspendLayout();
            this.tabsDiscover.SuspendLayout();
            this.tabDiscoverHosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscover)).BeginInit();
            this.tabDiscoverListings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDirectoryListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseDiscoverListing)).BeginInit();
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
            this.flowLayoutTopSearches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutTopSearches.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutTopSearches.Location = new System.Drawing.Point(15, 93);
            this.flowLayoutTopSearches.Name = "flowLayoutTopSearches";
            this.flowLayoutTopSearches.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutTopSearches.Size = new System.Drawing.Size(1022, 419);
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
            // labelDatabaseStats
            // 
            this.labelDatabaseStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseStats.BackColor = System.Drawing.Color.Transparent;
            this.labelDatabaseStats.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDatabaseStats.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDatabaseStats.Location = new System.Drawing.Point(208, 524);
            this.labelDatabaseStats.Name = "labelDatabaseStats";
            this.labelDatabaseStats.Size = new System.Drawing.Size(632, 56);
            this.labelDatabaseStats.TabIndex = 1106;
            this.labelDatabaseStats.Text = "Searching {0} files ({1}+) in {2} web servers\r\n\r\nUpdated: {3}";
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
            this.tabSearch.Controls.Add(this.buttonFilesImage);
            this.tabSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tabSearch.ForeColor = System.Drawing.Color.White;
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1048, 607);
            this.tabSearch.TabIndex = 9;
            // 
            // buttonFilesImage
            // 
            this.buttonFilesImage.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilesImage.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilesImage.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonFilesImage.Corners.UpperLeft = 2;
            this.buttonFilesImage.Corners.UpperRight = 2;
            this.buttonFilesImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilesImage.DesignerSelected = false;
            this.buttonFilesImage.DimFactorClick = 0;
            this.buttonFilesImage.DimFactorHover = 0;
            this.buttonFilesImage.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonFilesImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilesImage.ImageIndex = 0;
            this.buttonFilesImage.Location = new System.Drawing.Point(285, 61);
            this.buttonFilesImage.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonFilesImage.MaximumSize = new System.Drawing.Size(1000, 27);
            this.buttonFilesImage.MinimumSize = new System.Drawing.Size(0, 27);
            this.buttonFilesImage.Name = "buttonFilesImage";
            this.buttonFilesImage.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonFilesImage.Size = new System.Drawing.Size(68, 27);
            this.buttonFilesImage.TabIndex = 15;
            this.buttonFilesImage.Text = "Images";
            this.buttonFilesImage.TextShadowShow = false;
            this.buttonFilesImage.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonFilesImage_ClickButtonArea);
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
            this.flowLayoutSearchFiles.Location = new System.Drawing.Point(640, 22);
            this.flowLayoutSearchFiles.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.flowLayoutSearchFiles.Name = "flowLayoutSearchFiles";
            this.flowLayoutSearchFiles.Size = new System.Drawing.Size(387, 22);
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
            this.imageSearchFiles.Location = new System.Drawing.Point(367, 1);
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
            this.flowLayoutFilterFiles.Location = new System.Drawing.Point(261, 0);
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
            this.flowLayoutSortFiles.Location = new System.Drawing.Point(149, 0);
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
            this.textBoxSearchFiles.Size = new System.Drawing.Size(613, 19);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesName.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnFilesName.HeaderText = "Name";
            this.columnFilesName.Name = "columnFilesName";
            this.columnFilesName.ReadOnly = true;
            this.columnFilesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnFilesSize
            // 
            this.columnFilesSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesSize.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnFilesSize.HeaderText = "Size";
            this.columnFilesSize.Name = "columnFilesSize";
            this.columnFilesSize.ReadOnly = true;
            this.columnFilesSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesSize.Width = 45;
            // 
            // columnFilesAge
            // 
            this.columnFilesAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesAge.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnFilesAge.HeaderText = "Age";
            this.columnFilesAge.Name = "columnFilesAge";
            this.columnFilesAge.ReadOnly = true;
            this.columnFilesAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesAge.Width = 46;
            // 
            // columnFilesReferrer
            // 
            this.columnFilesReferrer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesReferrer.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnFilesReferrer.HeaderText = "Referrer";
            this.columnFilesReferrer.Name = "columnFilesReferrer";
            this.columnFilesReferrer.ReadOnly = true;
            this.columnFilesReferrer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesReferrer.Width = 70;
            // 
            // columnFilesURL
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesURL.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.labelResultsInfo.Location = new System.Drawing.Point(975, 65);
            this.labelResultsInfo.Margin = new System.Windows.Forms.Padding(0, 9, 3, 9);
            this.labelResultsInfo.Name = "labelResultsInfo";
            this.labelResultsInfo.Size = new System.Drawing.Size(58, 20);
            this.labelResultsInfo.TabIndex = 0;
            this.labelResultsInfo.Text = "0 Results";
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
            this.buttonFilesAudio.Size = new System.Drawing.Size(102, 27);
            this.buttonFilesAudio.TabIndex = 6;
            this.buttonFilesAudio.Text = "Music/Audio";
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
            this.buttonFilesBookmarks.Location = new System.Drawing.Point(883, 61);
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
            this.buttonFilesLocal.Location = new System.Drawing.Point(827, 61);
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
            this.buttonFilesTorrents.Location = new System.Drawing.Point(539, 61);
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
            this.buttonFilesOther.Location = new System.Drawing.Point(691, 61);
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
            this.buttonFilesSoftware.Location = new System.Drawing.Point(414, 61);
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
            this.buttonFilesCustom.Location = new System.Drawing.Point(750, 61);
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
            this.buttonFilesSubtitles.Location = new System.Drawing.Point(614, 61);
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
            this.buttonFilesBooks.Location = new System.Drawing.Point(353, 61);
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
            this.tabDiscover.Controls.Add(this.tabsDiscover);
            this.tabDiscover.ForeColor = System.Drawing.Color.White;
            this.tabDiscover.Location = new System.Drawing.Point(4, 22);
            this.tabDiscover.Name = "tabDiscover";
            this.tabDiscover.Size = new System.Drawing.Size(1048, 607);
            this.tabDiscover.TabIndex = 7;
            // 
            // tabsDiscover
            // 
            this.tabsDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsDiscover.Controls.Add(this.tabDiscoverHosts);
            this.tabsDiscover.Controls.Add(this.tabDiscoverListings);
            this.tabsDiscover.Location = new System.Drawing.Point(-4, -22);
            this.tabsDiscover.Name = "tabsDiscover";
            this.tabsDiscover.SelectedIndex = 0;
            this.tabsDiscover.Size = new System.Drawing.Size(1056, 633);
            this.tabsDiscover.TabIndex = 1;
            // 
            // tabDiscoverHosts
            // 
            this.tabDiscoverHosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabDiscoverHosts.Controls.Add(this.dataGridDiscover);
            this.tabDiscoverHosts.Controls.Add(this.splitterHeaderDiscover);
            this.tabDiscoverHosts.Controls.Add(this.labelTitleDiscover);
            this.tabDiscoverHosts.Location = new System.Drawing.Point(4, 22);
            this.tabDiscoverHosts.Name = "tabDiscoverHosts";
            this.tabDiscoverHosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscoverHosts.Size = new System.Drawing.Size(1048, 607);
            this.tabDiscoverHosts.TabIndex = 0;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDiscover.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDiscover.RowsDefaultCellStyle = dataGridViewCellStyle9;
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
            this.splitterHeaderDiscover.Location = new System.Drawing.Point(17, 45);
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
            this.labelTitleDiscover.Location = new System.Drawing.Point(12, 13);
            this.labelTitleDiscover.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleDiscover.Name = "labelTitleDiscover";
            this.labelTitleDiscover.Size = new System.Drawing.Size(1020, 32);
            this.labelTitleDiscover.TabIndex = 0;
            this.labelTitleDiscover.Text = "Every website/domain crawled by FileMasta ready to be discovered.";
            this.labelTitleDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDiscoverListings
            // 
            this.tabDiscoverListings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabDiscoverListings.Controls.Add(this.labelDirectoryStatus);
            this.tabDiscoverListings.Controls.Add(this.labelDirectoryEmptyResults);
            this.tabDiscoverListings.Controls.Add(this.dataGridDirectoryListing);
            this.tabDiscoverListings.Controls.Add(this.labelWebExplorerURL);
            this.tabDiscoverListings.Controls.Add(this.buttonCloseDiscoverListing);
            this.tabDiscoverListings.Controls.Add(this.buttonViewDirectory);
            this.tabDiscoverListings.Controls.Add(this.buttonGoUp);
            this.tabDiscoverListings.Location = new System.Drawing.Point(4, 22);
            this.tabDiscoverListings.Name = "tabDiscoverListings";
            this.tabDiscoverListings.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscoverListings.Size = new System.Drawing.Size(1048, 607);
            this.tabDiscoverListings.TabIndex = 1;
            // 
            // labelDirectoryStatus
            // 
            this.labelDirectoryStatus.AutoSize = true;
            this.labelDirectoryStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelDirectoryStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectoryStatus.ForeColor = System.Drawing.Color.Silver;
            this.labelDirectoryStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDirectoryStatus.Location = new System.Drawing.Point(108, 79);
            this.labelDirectoryStatus.Name = "labelDirectoryStatus";
            this.labelDirectoryStatus.Size = new System.Drawing.Size(64, 17);
            this.labelDirectoryStatus.TabIndex = 0;
            this.labelDirectoryStatus.Text = "Loading...";
            // 
            // labelDirectoryEmptyResults
            // 
            this.labelDirectoryEmptyResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDirectoryEmptyResults.AutoSize = true;
            this.labelDirectoryEmptyResults.BackColor = System.Drawing.Color.Transparent;
            this.labelDirectoryEmptyResults.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDirectoryEmptyResults.ForeColor = System.Drawing.Color.Silver;
            this.labelDirectoryEmptyResults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDirectoryEmptyResults.Location = new System.Drawing.Point(482, 178);
            this.labelDirectoryEmptyResults.Name = "labelDirectoryEmptyResults";
            this.labelDirectoryEmptyResults.Size = new System.Drawing.Size(120, 19);
            this.labelDirectoryEmptyResults.TabIndex = 0;
            this.labelDirectoryEmptyResults.Text = "No Results Found";
            this.labelDirectoryEmptyResults.Visible = false;
            // 
            // dataGridDirectoryListing
            // 
            this.dataGridDirectoryListing.AllowUserToAddRows = false;
            this.dataGridDirectoryListing.AllowUserToDeleteRows = false;
            this.dataGridDirectoryListing.AllowUserToResizeColumns = false;
            this.dataGridDirectoryListing.AllowUserToResizeRows = false;
            this.dataGridDirectoryListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDirectoryListing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDirectoryListing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDirectoryListing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridDirectoryListing.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridDirectoryListing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDirectoryListing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridDirectoryListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDirectoryListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridDirectoryListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridDirectoryListing.EnableHeadersVisualStyles = false;
            this.dataGridDirectoryListing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDirectoryListing.Location = new System.Drawing.Point(0, 103);
            this.dataGridDirectoryListing.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dataGridDirectoryListing.MultiSelect = false;
            this.dataGridDirectoryListing.Name = "dataGridDirectoryListing";
            this.dataGridDirectoryListing.ReadOnly = true;
            this.dataGridDirectoryListing.RowHeadersVisible = false;
            this.dataGridDirectoryListing.RowHeadersWidth = 40;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDirectoryListing.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridDirectoryListing.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDirectoryListing.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridDirectoryListing.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridDirectoryListing.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridDirectoryListing.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridDirectoryListing.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDirectoryListing.RowTemplate.Height = 30;
            this.dataGridDirectoryListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDirectoryListing.ShowCellErrors = false;
            this.dataGridDirectoryListing.ShowEditingIcon = false;
            this.dataGridDirectoryListing.ShowRowErrors = false;
            this.dataGridDirectoryListing.Size = new System.Drawing.Size(1048, 504);
            this.dataGridDirectoryListing.TabIndex = 100118;
            this.dataGridDirectoryListing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDirectoryListing_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 41;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 41;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn5.HeaderText = "Referrer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn6.HeaderText = "URL";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // labelWebExplorerURL
            // 
            this.labelWebExplorerURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebExplorerURL.AutoEllipsis = true;
            this.labelWebExplorerURL.BackColor = System.Drawing.Color.Transparent;
            this.labelWebExplorerURL.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelWebExplorerURL.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F);
            this.labelWebExplorerURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWebExplorerURL.Location = new System.Drawing.Point(14, 17);
            this.labelWebExplorerURL.Margin = new System.Windows.Forms.Padding(0);
            this.labelWebExplorerURL.Name = "labelWebExplorerURL";
            this.labelWebExplorerURL.Size = new System.Drawing.Size(835, 34);
            this.labelWebExplorerURL.TabIndex = 100114;
            this.labelWebExplorerURL.Text = "URL";
            this.labelWebExplorerURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCloseDiscoverListing
            // 
            this.buttonCloseDiscoverListing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseDiscoverListing.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseDiscoverListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseDiscoverListing.Image = global::FileMasta.Properties.Resources.close;
            this.buttonCloseDiscoverListing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCloseDiscoverListing.Location = new System.Drawing.Point(1002, 20);
            this.buttonCloseDiscoverListing.Margin = new System.Windows.Forms.Padding(3, 25, 25, 3);
            this.buttonCloseDiscoverListing.Name = "buttonCloseDiscoverListing";
            this.buttonCloseDiscoverListing.Size = new System.Drawing.Size(30, 30);
            this.buttonCloseDiscoverListing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCloseDiscoverListing.TabIndex = 100117;
            this.buttonCloseDiscoverListing.TabStop = false;
            this.buttonCloseDiscoverListing.Click += new System.EventHandler(this.buttonCloseDiscoverListing_Click);
            // 
            // buttonViewDirectory
            // 
            this.buttonViewDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewDirectory.BackColor = System.Drawing.Color.Transparent;
            this.buttonViewDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonViewDirectory.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonViewDirectory.Corners.All = 2;
            this.buttonViewDirectory.Corners.LowerLeft = 2;
            this.buttonViewDirectory.Corners.LowerRight = 2;
            this.buttonViewDirectory.Corners.UpperLeft = 2;
            this.buttonViewDirectory.Corners.UpperRight = 2;
            this.buttonViewDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewDirectory.DesignerSelected = false;
            this.buttonViewDirectory.DimFactorClick = 0;
            this.buttonViewDirectory.DimFactorHover = 0;
            this.buttonViewDirectory.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonViewDirectory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.buttonViewDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonViewDirectory.Image = global::FileMasta.Properties.Resources.search_web_orange;
            this.buttonViewDirectory.ImageIndex = 0;
            this.buttonViewDirectory.ImageSize = new System.Drawing.Size(18, 18);
            this.buttonViewDirectory.Location = new System.Drawing.Point(865, 20);
            this.buttonViewDirectory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonViewDirectory.MaximumSize = new System.Drawing.Size(1000, 30);
            this.buttonViewDirectory.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonViewDirectory.Name = "buttonViewDirectory";
            this.buttonViewDirectory.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonViewDirectory.Size = new System.Drawing.Size(130, 30);
            this.buttonViewDirectory.TabIndex = 1;
            this.buttonViewDirectory.Text = "View Directory";
            this.buttonViewDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewDirectory.TextShadowShow = false;
            this.buttonViewDirectory.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonViewDirectory_ClickButtonArea);
            // 
            // buttonGoUp
            // 
            this.buttonGoUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonGoUp.ColorFillSolid = System.Drawing.Color.Transparent;
            this.buttonGoUp.Corners.All = 2;
            this.buttonGoUp.Corners.LowerLeft = 2;
            this.buttonGoUp.Corners.LowerRight = 2;
            this.buttonGoUp.Corners.UpperLeft = 2;
            this.buttonGoUp.Corners.UpperRight = 2;
            this.buttonGoUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoUp.DesignerSelected = false;
            this.buttonGoUp.DimFactorClick = 0;
            this.buttonGoUp.DimFactorHover = 0;
            this.buttonGoUp.FillType = CButtonLib.CButton.eFillType.Solid;
            this.buttonGoUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.buttonGoUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.buttonGoUp.Image = global::FileMasta.Properties.Resources.chevron_up_orange;
            this.buttonGoUp.ImageIndex = 0;
            this.buttonGoUp.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonGoUp.Location = new System.Drawing.Point(18, 66);
            this.buttonGoUp.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.buttonGoUp.MaximumSize = new System.Drawing.Size(1000, 30);
            this.buttonGoUp.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonGoUp.Name = "buttonGoUp";
            this.buttonGoUp.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.buttonGoUp.Size = new System.Drawing.Size(82, 30);
            this.buttonGoUp.TabIndex = 100112;
            this.buttonGoUp.Text = "Go Up";
            this.buttonGoUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGoUp.TextShadowShow = false;
            this.buttonGoUp.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.buttonGoUp_ClickButtonArea);
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
            this.labelSubmitDescription.Size = new System.Drawing.Size(1034, 221);
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
            this.panelSubmitLink.Location = new System.Drawing.Point(0, 246);
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
            this.tabSettings.Controls.Add(this.textBoxConnectionPassword);
            this.tabSettings.Controls.Add(this.textBoxBackgroundConnectionPassword);
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.textBoxConnectionUsername);
            this.tabSettings.Controls.Add(this.textBoxBackgroundConnectionUsername);
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.textBoxConnectionPort);
            this.tabSettings.Controls.Add(this.textBoxBackgroundConnectionPort);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.textBoxConnectionAddress);
            this.tabSettings.Controls.Add(this.textBoxBackgroundConnectionAddress);
            this.tabSettings.Controls.Add(this.labelConnectionAddress);
            this.tabSettings.Controls.Add(this.splitterHeaderConnection);
            this.tabSettings.Controls.Add(this.labelTitleSettings);
            this.tabSettings.Controls.Add(this.labelConnectionDefault);
            this.tabSettings.Controls.Add(this.checkBoxConnectionDefault);
            this.tabSettings.Controls.Add(this.buttonSaveSettings);
            this.tabSettings.Controls.Add(this.buttonRestoreSettings);
            this.tabSettings.Controls.Add(this.splitterHeaderGeneral);
            this.tabSettings.Controls.Add(this.labelTitleGeneral);
            this.tabSettings.Controls.Add(this.labelGeneralClearDataOnClose);
            this.tabSettings.Controls.Add(this.checkBoxGeneralClearDataOnClose);
            this.tabSettings.ForeColor = System.Drawing.Color.White;
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1048, 607);
            this.tabSettings.TabIndex = 6;
            // 
            // textBoxConnectionPassword
            // 
            this.textBoxConnectionPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxConnectionPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectionPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxConnectionPassword.Location = new System.Drawing.Point(283, 271);
            this.textBoxConnectionPassword.Name = "textBoxConnectionPassword";
            this.textBoxConnectionPassword.Size = new System.Drawing.Size(328, 18);
            this.textBoxConnectionPassword.TabIndex = 18;
            this.textBoxConnectionPassword.WaterMark = "Password";
            this.textBoxConnectionPassword.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxConnectionPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionPassword.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            // 
            // textBoxBackgroundConnectionPassword
            // 
            this.textBoxBackgroundConnectionPassword.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundConnectionPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionPassword.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionPassword.Corners.All = 2;
            this.textBoxBackgroundConnectionPassword.Corners.LowerLeft = 2;
            this.textBoxBackgroundConnectionPassword.Corners.LowerRight = 2;
            this.textBoxBackgroundConnectionPassword.Corners.UpperLeft = 2;
            this.textBoxBackgroundConnectionPassword.Corners.UpperRight = 2;
            this.textBoxBackgroundConnectionPassword.DesignerSelected = false;
            this.textBoxBackgroundConnectionPassword.DimFactorClick = 0;
            this.textBoxBackgroundConnectionPassword.DimFactorHover = 0;
            this.textBoxBackgroundConnectionPassword.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundConnectionPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundConnectionPassword.ImageIndex = 0;
            this.textBoxBackgroundConnectionPassword.Location = new System.Drawing.Point(274, 266);
            this.textBoxBackgroundConnectionPassword.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.textBoxBackgroundConnectionPassword.Name = "textBoxBackgroundConnectionPassword";
            this.textBoxBackgroundConnectionPassword.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundConnectionPassword.Size = new System.Drawing.Size(347, 30);
            this.textBoxBackgroundConnectionPassword.TabIndex = 19;
            this.textBoxBackgroundConnectionPassword.TabStop = false;
            this.textBoxBackgroundConnectionPassword.Text = "";
            this.textBoxBackgroundConnectionPassword.TextShadow = System.Drawing.Color.Empty;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // textBoxConnectionUsername
            // 
            this.textBoxConnectionUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxConnectionUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectionUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxConnectionUsername.Location = new System.Drawing.Point(283, 238);
            this.textBoxConnectionUsername.Name = "textBoxConnectionUsername";
            this.textBoxConnectionUsername.Size = new System.Drawing.Size(328, 18);
            this.textBoxConnectionUsername.TabIndex = 15;
            this.textBoxConnectionUsername.WaterMark = "Username";
            this.textBoxConnectionUsername.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxConnectionUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionUsername.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            // 
            // textBoxBackgroundConnectionUsername
            // 
            this.textBoxBackgroundConnectionUsername.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundConnectionUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionUsername.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionUsername.Corners.All = 2;
            this.textBoxBackgroundConnectionUsername.Corners.LowerLeft = 2;
            this.textBoxBackgroundConnectionUsername.Corners.LowerRight = 2;
            this.textBoxBackgroundConnectionUsername.Corners.UpperLeft = 2;
            this.textBoxBackgroundConnectionUsername.Corners.UpperRight = 2;
            this.textBoxBackgroundConnectionUsername.DesignerSelected = false;
            this.textBoxBackgroundConnectionUsername.DimFactorClick = 0;
            this.textBoxBackgroundConnectionUsername.DimFactorHover = 0;
            this.textBoxBackgroundConnectionUsername.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundConnectionUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundConnectionUsername.ImageIndex = 0;
            this.textBoxBackgroundConnectionUsername.Location = new System.Drawing.Point(274, 233);
            this.textBoxBackgroundConnectionUsername.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.textBoxBackgroundConnectionUsername.Name = "textBoxBackgroundConnectionUsername";
            this.textBoxBackgroundConnectionUsername.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundConnectionUsername.Size = new System.Drawing.Size(347, 30);
            this.textBoxBackgroundConnectionUsername.TabIndex = 16;
            this.textBoxBackgroundConnectionUsername.TabStop = false;
            this.textBoxBackgroundConnectionUsername.Text = "";
            this.textBoxBackgroundConnectionUsername.TextShadow = System.Drawing.Color.Empty;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address:";
            // 
            // textBoxConnectionPort
            // 
            this.textBoxConnectionPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxConnectionPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectionPort.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionPort.ForeColor = System.Drawing.Color.White;
            this.textBoxConnectionPort.Location = new System.Drawing.Point(283, 205);
            this.textBoxConnectionPort.Name = "textBoxConnectionPort";
            this.textBoxConnectionPort.Size = new System.Drawing.Size(328, 18);
            this.textBoxConnectionPort.TabIndex = 12;
            this.textBoxConnectionPort.WaterMark = "Port";
            this.textBoxConnectionPort.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxConnectionPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionPort.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            // 
            // textBoxBackgroundConnectionPort
            // 
            this.textBoxBackgroundConnectionPort.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundConnectionPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionPort.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionPort.Corners.All = 2;
            this.textBoxBackgroundConnectionPort.Corners.LowerLeft = 2;
            this.textBoxBackgroundConnectionPort.Corners.LowerRight = 2;
            this.textBoxBackgroundConnectionPort.Corners.UpperLeft = 2;
            this.textBoxBackgroundConnectionPort.Corners.UpperRight = 2;
            this.textBoxBackgroundConnectionPort.DesignerSelected = false;
            this.textBoxBackgroundConnectionPort.DimFactorClick = 0;
            this.textBoxBackgroundConnectionPort.DimFactorHover = 0;
            this.textBoxBackgroundConnectionPort.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundConnectionPort.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundConnectionPort.ImageIndex = 0;
            this.textBoxBackgroundConnectionPort.Location = new System.Drawing.Point(274, 200);
            this.textBoxBackgroundConnectionPort.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.textBoxBackgroundConnectionPort.Name = "textBoxBackgroundConnectionPort";
            this.textBoxBackgroundConnectionPort.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundConnectionPort.Size = new System.Drawing.Size(347, 30);
            this.textBoxBackgroundConnectionPort.TabIndex = 13;
            this.textBoxBackgroundConnectionPort.TabStop = false;
            this.textBoxBackgroundConnectionPort.Text = "";
            this.textBoxBackgroundConnectionPort.TextShadow = System.Drawing.Color.Empty;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(11, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port:";
            // 
            // textBoxConnectionAddress
            // 
            this.textBoxConnectionAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxConnectionAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectionAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionAddress.ForeColor = System.Drawing.Color.White;
            this.textBoxConnectionAddress.Location = new System.Drawing.Point(284, 172);
            this.textBoxConnectionAddress.Name = "textBoxConnectionAddress";
            this.textBoxConnectionAddress.Size = new System.Drawing.Size(328, 18);
            this.textBoxConnectionAddress.TabIndex = 9;
            this.textBoxConnectionAddress.WaterMark = "Address";
            this.textBoxConnectionAddress.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxConnectionAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxConnectionAddress.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            // 
            // textBoxBackgroundConnectionAddress
            // 
            this.textBoxBackgroundConnectionAddress.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBackgroundConnectionAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionAddress.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.textBoxBackgroundConnectionAddress.Corners.All = 2;
            this.textBoxBackgroundConnectionAddress.Corners.LowerLeft = 2;
            this.textBoxBackgroundConnectionAddress.Corners.LowerRight = 2;
            this.textBoxBackgroundConnectionAddress.Corners.UpperLeft = 2;
            this.textBoxBackgroundConnectionAddress.Corners.UpperRight = 2;
            this.textBoxBackgroundConnectionAddress.DesignerSelected = false;
            this.textBoxBackgroundConnectionAddress.DimFactorClick = 0;
            this.textBoxBackgroundConnectionAddress.DimFactorHover = 0;
            this.textBoxBackgroundConnectionAddress.FillType = CButtonLib.CButton.eFillType.Solid;
            this.textBoxBackgroundConnectionAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxBackgroundConnectionAddress.ImageIndex = 0;
            this.textBoxBackgroundConnectionAddress.Location = new System.Drawing.Point(275, 167);
            this.textBoxBackgroundConnectionAddress.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.textBoxBackgroundConnectionAddress.Name = "textBoxBackgroundConnectionAddress";
            this.textBoxBackgroundConnectionAddress.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.textBoxBackgroundConnectionAddress.Size = new System.Drawing.Size(347, 30);
            this.textBoxBackgroundConnectionAddress.TabIndex = 10;
            this.textBoxBackgroundConnectionAddress.TabStop = false;
            this.textBoxBackgroundConnectionAddress.Text = "";
            this.textBoxBackgroundConnectionAddress.TextShadow = System.Drawing.Color.Empty;
            // 
            // labelConnectionAddress
            // 
            this.labelConnectionAddress.AutoSize = true;
            this.labelConnectionAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelConnectionAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelConnectionAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelConnectionAddress.Location = new System.Drawing.Point(12, 177);
            this.labelConnectionAddress.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelConnectionAddress.Name = "labelConnectionAddress";
            this.labelConnectionAddress.Size = new System.Drawing.Size(59, 17);
            this.labelConnectionAddress.TabIndex = 8;
            this.labelConnectionAddress.Text = "Address:";
            // 
            // splitterHeaderConnection
            // 
            this.splitterHeaderConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderConnection.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderConnection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderConnection.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderConnection.DesignerSelected = false;
            this.splitterHeaderConnection.DimFactorClick = 0;
            this.splitterHeaderConnection.DimFactorHover = 0;
            this.splitterHeaderConnection.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderConnection.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderConnection.ImageIndex = 0;
            this.splitterHeaderConnection.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderConnection.Location = new System.Drawing.Point(14, 128);
            this.splitterHeaderConnection.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderConnection.Name = "splitterHeaderConnection";
            this.splitterHeaderConnection.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderConnection.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderConnection.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderConnection.Size = new System.Drawing.Size(1020, 1);
            this.splitterHeaderConnection.TabIndex = 4;
            this.splitterHeaderConnection.TabStop = false;
            this.splitterHeaderConnection.Text = "";
            this.splitterHeaderConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderConnection.TextShadowShow = false;
            // 
            // labelTitleSettings
            // 
            this.labelTitleSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F);
            this.labelTitleSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleSettings.Location = new System.Drawing.Point(9, 96);
            this.labelTitleSettings.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelTitleSettings.Name = "labelTitleSettings";
            this.labelTitleSettings.Size = new System.Drawing.Size(1030, 32);
            this.labelTitleSettings.TabIndex = 5;
            this.labelTitleSettings.Text = "Connection";
            // 
            // labelConnectionDefault
            // 
            this.labelConnectionDefault.AutoSize = true;
            this.labelConnectionDefault.BackColor = System.Drawing.Color.Transparent;
            this.labelConnectionDefault.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelConnectionDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelConnectionDefault.Location = new System.Drawing.Point(11, 144);
            this.labelConnectionDefault.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelConnectionDefault.Name = "labelConnectionDefault";
            this.labelConnectionDefault.Size = new System.Drawing.Size(55, 17);
            this.labelConnectionDefault.TabIndex = 6;
            this.labelConnectionDefault.Text = "Custom:";
            // 
            // checkBoxConnectionDefault
            // 
            this.checkBoxConnectionDefault.AutoSize = true;
            this.checkBoxConnectionDefault.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxConnectionDefault.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.checkBoxConnectionDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxConnectionDefault.Location = new System.Drawing.Point(275, 146);
            this.checkBoxConnectionDefault.Name = "checkBoxConnectionDefault";
            this.checkBoxConnectionDefault.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConnectionDefault.TabIndex = 7;
            this.checkBoxConnectionDefault.UseVisualStyleBackColor = false;
            this.checkBoxConnectionDefault.CheckedChanged += new System.EventHandler(this.checkBoxConnectionDefault_CheckedChanged);
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
            this.buttonSaveSettings.Location = new System.Drawing.Point(89, 324);
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
            this.buttonRestoreSettings.Location = new System.Drawing.Point(14, 324);
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
            // splitterHeaderGeneral
            // 
            this.splitterHeaderGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterHeaderGeneral.BackColor = System.Drawing.Color.Transparent;
            this.splitterHeaderGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderGeneral.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.splitterHeaderGeneral.DesignerSelected = false;
            this.splitterHeaderGeneral.DimFactorClick = 0;
            this.splitterHeaderGeneral.DimFactorHover = 0;
            this.splitterHeaderGeneral.FillType = CButtonLib.CButton.eFillType.Solid;
            this.splitterHeaderGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.splitterHeaderGeneral.ForeColor = System.Drawing.Color.Silver;
            this.splitterHeaderGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderGeneral.ImageIndex = 0;
            this.splitterHeaderGeneral.ImageSize = new System.Drawing.Size(25, 36);
            this.splitterHeaderGeneral.Location = new System.Drawing.Point(14, 45);
            this.splitterHeaderGeneral.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.splitterHeaderGeneral.Name = "splitterHeaderGeneral";
            this.splitterHeaderGeneral.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.splitterHeaderGeneral.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitterHeaderGeneral.SideImageSize = new System.Drawing.Size(36, 36);
            this.splitterHeaderGeneral.Size = new System.Drawing.Size(1020, 1);
            this.splitterHeaderGeneral.TabIndex = 0;
            this.splitterHeaderGeneral.TabStop = false;
            this.splitterHeaderGeneral.Text = "";
            this.splitterHeaderGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.splitterHeaderGeneral.TextShadowShow = false;
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
            // labelGeneralClearDataOnClose
            // 
            this.labelGeneralClearDataOnClose.AutoSize = true;
            this.labelGeneralClearDataOnClose.BackColor = System.Drawing.Color.Transparent;
            this.labelGeneralClearDataOnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelGeneralClearDataOnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGeneralClearDataOnClose.Location = new System.Drawing.Point(11, 61);
            this.labelGeneralClearDataOnClose.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelGeneralClearDataOnClose.Name = "labelGeneralClearDataOnClose";
            this.labelGeneralClearDataOnClose.Size = new System.Drawing.Size(124, 17);
            this.labelGeneralClearDataOnClose.TabIndex = 0;
            this.labelGeneralClearDataOnClose.Text = "Clear data on close:";
            // 
            // checkBoxGeneralClearDataOnClose
            // 
            this.checkBoxGeneralClearDataOnClose.AutoSize = true;
            this.checkBoxGeneralClearDataOnClose.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGeneralClearDataOnClose.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.checkBoxGeneralClearDataOnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxGeneralClearDataOnClose.Location = new System.Drawing.Point(275, 63);
            this.checkBoxGeneralClearDataOnClose.Name = "checkBoxGeneralClearDataOnClose";
            this.checkBoxGeneralClearDataOnClose.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGeneralClearDataOnClose.TabIndex = 1;
            this.checkBoxGeneralClearDataOnClose.UseVisualStyleBackColor = false;
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
            this.imageFacebook.Click += new System.EventHandler(this.ImageShareFacebook_Click);
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
            this.imageTwitter.Click += new System.EventHandler(this.ImageShareTwitter_Click);
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
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.flowLayoutSearchFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSearchFiles)).EndInit();
            this.flowLayoutFilterFiles.ResumeLayout(false);
            this.flowLayoutSortFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.tabDiscover.ResumeLayout(false);
            this.tabsDiscover.ResumeLayout(false);
            this.tabDiscoverHosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscover)).EndInit();
            this.tabDiscoverListings.ResumeLayout(false);
            this.tabDiscoverListings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDirectoryListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseDiscoverListing)).EndInit();
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
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label labelGeneralClearDataOnClose;
        private System.Windows.Forms.CheckBox checkBoxGeneralClearDataOnClose;
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
        private System.Windows.Forms.Label labelTermsOfUse;
        private System.Windows.Forms.Label labelPrivacyPolicy;
        private System.Windows.Forms.PictureBox imageTwitter;
        private System.Windows.Forms.PictureBox imageFacebook;
        private System.Windows.Forms.PictureBox imageSearchFiles;
        public CButtonLib.CButton splitterHeaderGeneral;
        public CButtonLib.CButton splitterHeaderDiscover;
        public CButtonLib.CButton splitterHeaderSubmit;
        private Controls.buttonCustom buttonSubmitUrl;
        private Controls.buttonCustom buttonSaveSettings;
        private Controls.buttonCustom buttonRestoreSettings;
        public System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.Label labelMadeWithLove;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSearchItems;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesURL;
        private System.Windows.Forms.TabControl tabsDiscover;
        private System.Windows.Forms.TabPage tabDiscoverHosts;
        private System.Windows.Forms.TabPage tabDiscoverListings;
        private Controls.buttonCustom buttonGoUp;
        private Controls.buttonCustom buttonViewDirectory;
        public System.Windows.Forms.Label labelWebExplorerURL;
        public System.Windows.Forms.PictureBox buttonCloseDiscoverListing;
        public System.Windows.Forms.DataGridView dataGridDirectoryListing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.Label labelDirectoryEmptyResults;
        public System.Windows.Forms.Label labelDirectoryStatus;
        public CButtonLib.CButton splitterHeaderConnection;
        private System.Windows.Forms.Label labelTitleSettings;
        private System.Windows.Forms.Label labelConnectionDefault;
        private System.Windows.Forms.CheckBox checkBoxConnectionDefault;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxConnectionPassword;
        private CButtonLib.CButton textBoxBackgroundConnectionPassword;
        private System.Windows.Forms.Label label4;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxConnectionUsername;
        private CButtonLib.CButton textBoxBackgroundConnectionUsername;
        private System.Windows.Forms.Label label3;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxConnectionPort;
        private CButtonLib.CButton textBoxBackgroundConnectionPort;
        private System.Windows.Forms.Label label2;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxConnectionAddress;
        private CButtonLib.CButton textBoxBackgroundConnectionAddress;
        private System.Windows.Forms.Label labelConnectionAddress;
        public Controls.buttonFileType buttonFilesImage;
    }
}

