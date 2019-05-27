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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CButtonLib.cBlendItems cBlendItems2 = new CButtonLib.cBlendItems();
            this.DataGridFiles = new System.Windows.Forms.DataGridView();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileLastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilesURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuFileViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileCopyURL = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileMinimizeToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripBookmarks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpChangelog = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHelpCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelpSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripFooter = new System.Windows.Forms.StatusStrip();
            this.StatusStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripDatabaseInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotifyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuSearchExternal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSearchGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchGoogol = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchStartPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchSearx = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelFileDetails = new System.Windows.Forms.Panel();
            this.cButton1 = new CButtonLib.CButton();
            this.LabelFileAge = new System.Windows.Forms.Label();
            this.LabelFileValueAge = new System.Windows.Forms.Label();
            this.LabelFileValueURL = new System.Windows.Forms.Label();
            this.FlowpanelFileButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonDownloadFile = new System.Windows.Forms.Button();
            this.ButtonOpenWith = new System.Windows.Forms.Button();
            this.ButtonBookmark = new System.Windows.Forms.Button();
            this.LabelFileUrlBG = new CButtonLib.CButton();
            this.InfoSplitter1 = new CButtonLib.CButton();
            this.ButtonRequestFileSize = new System.Windows.Forms.Button();
            this.labelTitleExtension = new System.Windows.Forms.Label();
            this.LabelFileValueExtension = new System.Windows.Forms.Label();
            this.InfoSplitter5 = new CButtonLib.CButton();
            this.LabelFileDateModified = new System.Windows.Forms.Label();
            this.LabelFileValueModified = new System.Windows.Forms.Label();
            this.InfoSplitter3 = new CButtonLib.CButton();
            this.InfoSplitter2 = new CButtonLib.CButton();
            this.LabelFileReferrer = new System.Windows.Forms.Label();
            this.LabelFileValueDomain = new System.Windows.Forms.Label();
            this.labelTitleSize = new System.Windows.Forms.Label();
            this.LabelFileValueSize = new System.Windows.Forms.Label();
            this.LabelFileValueName = new System.Windows.Forms.Label();
            this.ContextFileOpenWith = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NitroReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KMPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PotPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextboxSearchName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.LabelSearchType = new System.Windows.Forms.Label();
            this.DropdownSearchSort = new System.Windows.Forms.ComboBox();
            this.LabelSort = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.FlowpanelKeywords = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonSearchExternal = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.ListboxSearchType = new System.Windows.Forms.ListBox();
            this.LabelSearchSizeMoreOrEqualTo = new System.Windows.Forms.Label();
            this.NumericSearchGreaterThan = new System.Windows.Forms.NumericUpDown();
            this.LabelSearchLastModified = new System.Windows.Forms.Label();
            this.DateTimeMinMTime = new System.Windows.Forms.DateTimePicker();
            this.DateTimeMaxMTime = new System.Windows.Forms.DateTimePicker();
            this.LabelSearchModifiedTo = new System.Windows.Forms.Label();
            this.DropdownSearchSizePrefix = new System.Windows.Forms.ComboBox();
            this.PanelSearchControls = new System.Windows.Forms.Panel();
            this.LabelSearchKeywords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiles)).BeginInit();
            this.ContextMenuFile.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.StatusStripFooter.SuspendLayout();
            this.ContextMenuSearchExternal.SuspendLayout();
            this.PanelFileDetails.SuspendLayout();
            this.FlowpanelFileButtons.SuspendLayout();
            this.ContextFileOpenWith.SuspendLayout();
            this.FlowpanelKeywords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSearchGreaterThan)).BeginInit();
            this.PanelSearchControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridFiles
            // 
            this.DataGridFiles.AllowUserToAddRows = false;
            this.DataGridFiles.AllowUserToDeleteRows = false;
            this.DataGridFiles.AllowUserToResizeColumns = false;
            this.DataGridFiles.AllowUserToResizeRows = false;
            this.DataGridFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 2, 2, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridFiles.ColumnHeadersHeight = 26;
            this.DataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFileName,
            this.ColumnFileSize,
            this.ColumnFileLastModified,
            this.ColumnFilesURL});
            this.DataGridFiles.ContextMenuStrip = this.ContextMenuFile;
            this.DataGridFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridFiles.EnableHeadersVisualStyles = false;
            this.DataGridFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.Location = new System.Drawing.Point(0, 166);
            this.DataGridFiles.MultiSelect = false;
            this.DataGridFiles.Name = "DataGridFiles";
            this.DataGridFiles.ReadOnly = true;
            this.DataGridFiles.RowHeadersVisible = false;
            this.DataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DataGridFiles.RowTemplate.ContextMenuStrip = this.ContextMenuFile;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.DataGridFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.DataGridFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFiles.RowTemplate.ReadOnly = true;
            this.DataGridFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridFiles.ShowCellErrors = false;
            this.DataGridFiles.ShowEditingIcon = false;
            this.DataGridFiles.ShowRowErrors = false;
            this.DataGridFiles.Size = new System.Drawing.Size(694, 373);
            this.DataGridFiles.TabIndex = 7;
            this.DataGridFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFileItems_CellDoubleClick);
            this.DataGridFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridFileItems_CellPainting);
            this.DataGridFiles.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridFileItems_RowPrePaint);
            this.DataGridFiles.SelectionChanged += new System.EventHandler(this.DataGridFileItems_SelectionChanged);
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileName.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColumnFileName.HeaderText = "Name";
            this.ColumnFileName.Name = "ColumnFileName";
            this.ColumnFileName.ReadOnly = true;
            this.ColumnFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnFileSize
            // 
            this.ColumnFileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileSize.DefaultCellStyle = dataGridViewCellStyle25;
            this.ColumnFileSize.HeaderText = "Size";
            this.ColumnFileSize.Name = "ColumnFileSize";
            this.ColumnFileSize.ReadOnly = true;
            this.ColumnFileSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ColumnFileSize.Width = 98;
            // 
            // ColumnFileLastModified
            // 
            this.ColumnFileLastModified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileLastModified.DefaultCellStyle = dataGridViewCellStyle26;
            this.ColumnFileLastModified.HeaderText = "Last Modified";
            this.ColumnFileLastModified.Name = "ColumnFileLastModified";
            this.ColumnFileLastModified.ReadOnly = true;
            this.ColumnFileLastModified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ColumnFileLastModified.Width = 175;
            // 
            // ColumnFilesURL
            // 
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFilesURL.DefaultCellStyle = dataGridViewCellStyle27;
            this.ColumnFilesURL.HeaderText = "URL";
            this.ColumnFilesURL.Name = "ColumnFilesURL";
            this.ColumnFilesURL.ReadOnly = true;
            this.ColumnFilesURL.Visible = false;
            // 
            // ContextMenuFile
            // 
            this.ContextMenuFile.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileViewDetails,
            this.MenuFileBookmark,
            this.MenuFileSeperator0,
            this.MenuFileOpen,
            this.MenuFileSeperator1,
            this.MenuFileCopyURL,
            this.MenuFileEmail});
            this.ContextMenuFile.Name = "contextMenuFileItem";
            this.ContextMenuFile.Size = new System.Drawing.Size(138, 126);
            // 
            // MenuFileViewDetails
            // 
            this.MenuFileViewDetails.Name = "MenuFileViewDetails";
            this.MenuFileViewDetails.Size = new System.Drawing.Size(137, 22);
            this.MenuFileViewDetails.Text = "View Details";
            this.MenuFileViewDetails.Click += new System.EventHandler(this.MenuFileViewDetails_Click);
            // 
            // MenuFileBookmark
            // 
            this.MenuFileBookmark.Name = "MenuFileBookmark";
            this.MenuFileBookmark.Size = new System.Drawing.Size(137, 22);
            this.MenuFileBookmark.Text = "Bookmark";
            this.MenuFileBookmark.Click += new System.EventHandler(this.MenuFileBookmark_Click);
            // 
            // MenuFileSeperator0
            // 
            this.MenuFileSeperator0.Name = "MenuFileSeperator0";
            this.MenuFileSeperator0.Size = new System.Drawing.Size(134, 6);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(137, 22);
            this.MenuFileOpen.Text = "Open...";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSeperator1
            // 
            this.MenuFileSeperator1.Name = "MenuFileSeperator1";
            this.MenuFileSeperator1.Size = new System.Drawing.Size(134, 6);
            // 
            // MenuFileCopyURL
            // 
            this.MenuFileCopyURL.Name = "MenuFileCopyURL";
            this.MenuFileCopyURL.Size = new System.Drawing.Size(137, 22);
            this.MenuFileCopyURL.Text = "Copy URL";
            this.MenuFileCopyURL.Click += new System.EventHandler(this.MenuFileCopyURL_Click);
            // 
            // MenuFileEmail
            // 
            this.MenuFileEmail.Name = "MenuFileEmail";
            this.MenuFileEmail.Size = new System.Drawing.Size(137, 22);
            this.MenuFileEmail.Text = "Email";
            this.MenuFileEmail.Click += new System.EventHandler(this.MenuFileEmail_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripBookmarks,
            this.MenuStripTools,
            this.MenuStripHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1056, 24);
            this.MenuStrip.TabIndex = 3;
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileMinimizeToTray,
            this.toolStripSeparator2,
            this.MenuFileExit});
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(38, 20);
            this.MenuStripFile.Text = "File";
            // 
            // MenuFileMinimizeToTray
            // 
            this.MenuFileMinimizeToTray.Name = "MenuFileMinimizeToTray";
            this.MenuFileMinimizeToTray.Size = new System.Drawing.Size(167, 22);
            this.MenuFileMinimizeToTray.Text = "Minimize to Tray";
            this.MenuFileMinimizeToTray.Click += new System.EventHandler(this.MenuFileMinimizeToTray_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(167, 22);
            this.MenuFileExit.Text = "Exit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // MenuStripBookmarks
            // 
            this.MenuStripBookmarks.Name = "MenuStripBookmarks";
            this.MenuStripBookmarks.Size = new System.Drawing.Size(84, 20);
            this.MenuStripBookmarks.Text = "Bookmarks";
            this.MenuStripBookmarks.Click += new System.EventHandler(this.MenuStripBookmarks_Click);
            // 
            // MenuStripTools
            // 
            this.MenuStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolsOptions});
            this.MenuStripTools.Name = "MenuStripTools";
            this.MenuStripTools.Size = new System.Drawing.Size(48, 20);
            this.MenuStripTools.Text = "Tools";
            // 
            // MenuToolsOptions
            // 
            this.MenuToolsOptions.Name = "MenuToolsOptions";
            this.MenuToolsOptions.Size = new System.Drawing.Size(117, 22);
            this.MenuToolsOptions.Text = "Options";
            this.MenuToolsOptions.Click += new System.EventHandler(this.MenuToolsOptions_Click);
            // 
            // MenuStripHelp
            // 
            this.MenuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpChangelog,
            this.MenuStripHelpSeperator0,
            this.MenuHelpCheckForUpdate,
            this.MenuHelpReportIssue,
            this.MenuStripHelpSeperator1,
            this.MenuHelpAbout});
            this.MenuStripHelp.Name = "MenuStripHelp";
            this.MenuStripHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuStripHelp.Text = "Help";
            // 
            // MenuHelpChangelog
            // 
            this.MenuHelpChangelog.Name = "MenuHelpChangelog";
            this.MenuHelpChangelog.Size = new System.Drawing.Size(174, 22);
            this.MenuHelpChangelog.Text = "Change Log";
            this.MenuHelpChangelog.Click += new System.EventHandler(this.MenuHelpChangelog_Click);
            // 
            // MenuStripHelpSeperator0
            // 
            this.MenuStripHelpSeperator0.Name = "MenuStripHelpSeperator0";
            this.MenuStripHelpSeperator0.Size = new System.Drawing.Size(171, 6);
            // 
            // MenuHelpCheckForUpdate
            // 
            this.MenuHelpCheckForUpdate.Name = "MenuHelpCheckForUpdate";
            this.MenuHelpCheckForUpdate.Size = new System.Drawing.Size(174, 22);
            this.MenuHelpCheckForUpdate.Text = "Check for Update";
            this.MenuHelpCheckForUpdate.Click += new System.EventHandler(this.MenuHelpCheckForUpdate_Click);
            // 
            // MenuHelpReportIssue
            // 
            this.MenuHelpReportIssue.Name = "MenuHelpReportIssue";
            this.MenuHelpReportIssue.Size = new System.Drawing.Size(174, 22);
            this.MenuHelpReportIssue.Text = "Report Issue";
            this.MenuHelpReportIssue.Click += new System.EventHandler(this.MenuHelpReportIssue_Click);
            // 
            // MenuStripHelpSeperator1
            // 
            this.MenuStripHelpSeperator1.Name = "MenuStripHelpSeperator1";
            this.MenuStripHelpSeperator1.Size = new System.Drawing.Size(171, 6);
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(174, 22);
            this.MenuHelpAbout.Text = "About";
            this.MenuHelpAbout.Click += new System.EventHandler(this.MenuHelpAbout_Click);
            // 
            // StatusStripFooter
            // 
            this.StatusStripFooter.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.StatusStripFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripStatus,
            this.StatusStripSpring,
            this.StatusStripDatabaseInfo});
            this.StatusStripFooter.Location = new System.Drawing.Point(0, 539);
            this.StatusStripFooter.Name = "StatusStripFooter";
            this.StatusStripFooter.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStripFooter.Size = new System.Drawing.Size(1056, 22);
            this.StatusStripFooter.TabIndex = 0;
            // 
            // StatusStripStatus
            // 
            this.StatusStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripStatus.Name = "StatusStripStatus";
            this.StatusStripStatus.Size = new System.Drawing.Size(59, 17);
            this.StatusStripStatus.Text = "Waiting...";
            // 
            // StatusStripSpring
            // 
            this.StatusStripSpring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripSpring.Name = "StatusStripSpring";
            this.StatusStripSpring.Size = new System.Drawing.Size(845, 17);
            this.StatusStripSpring.Spring = true;
            // 
            // StatusStripDatabaseInfo
            // 
            this.StatusStripDatabaseInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripDatabaseInfo.Name = "StatusStripDatabaseInfo";
            this.StatusStripDatabaseInfo.Size = new System.Drawing.Size(53, 17);
            this.StatusStripDatabaseInfo.Text = "{0} Files";
            // 
            // NotifyTrayIcon
            // 
            this.NotifyTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyTrayIcon.BalloonTipText = "Double click tray icon to restore...";
            this.NotifyTrayIcon.BalloonTipTitle = "FileMasta Minimized to Tray";
            this.NotifyTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyTrayIcon.Icon")));
            this.NotifyTrayIcon.Text = "FileMasta";
            this.NotifyTrayIcon.Visible = true;
            this.NotifyTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyTrayIcon_MouseDoubleClick);
            // 
            // ContextMenuSearchExternal
            // 
            this.ContextMenuSearchExternal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuSearchExternal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuSearchExternal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearchGoogle,
            this.MenuSearchGoogol,
            this.MenuSearchStartPage,
            this.MenuSearchSearx});
            this.ContextMenuSearchExternal.Name = "contextMenuFileItem";
            this.ContextMenuSearchExternal.Size = new System.Drawing.Size(124, 92);
            // 
            // MenuSearchGoogle
            // 
            this.MenuSearchGoogle.Name = "MenuSearchGoogle";
            this.MenuSearchGoogle.Size = new System.Drawing.Size(123, 22);
            this.MenuSearchGoogle.Text = "Google";
            this.MenuSearchGoogle.Click += new System.EventHandler(this.MenuSearchGoogle_Click);
            // 
            // MenuSearchGoogol
            // 
            this.MenuSearchGoogol.Name = "MenuSearchGoogol";
            this.MenuSearchGoogol.Size = new System.Drawing.Size(123, 22);
            this.MenuSearchGoogol.Text = "Googol";
            this.MenuSearchGoogol.Click += new System.EventHandler(this.MenuSearchGoogol_Click);
            // 
            // MenuSearchStartPage
            // 
            this.MenuSearchStartPage.Name = "MenuSearchStartPage";
            this.MenuSearchStartPage.Size = new System.Drawing.Size(123, 22);
            this.MenuSearchStartPage.Text = "StartPage";
            this.MenuSearchStartPage.Click += new System.EventHandler(this.MenuSearchStartPage_Click);
            // 
            // MenuSearchSearx
            // 
            this.MenuSearchSearx.Name = "MenuSearchSearx";
            this.MenuSearchSearx.Size = new System.Drawing.Size(123, 22);
            this.MenuSearchSearx.Text = "Searx";
            this.MenuSearchSearx.Click += new System.EventHandler(this.MenuSearchSearx_Click);
            // 
            // PanelFileDetails
            // 
            this.PanelFileDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFileDetails.Controls.Add(this.cButton1);
            this.PanelFileDetails.Controls.Add(this.LabelFileAge);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueAge);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueURL);
            this.PanelFileDetails.Controls.Add(this.FlowpanelFileButtons);
            this.PanelFileDetails.Controls.Add(this.LabelFileUrlBG);
            this.PanelFileDetails.Controls.Add(this.InfoSplitter1);
            this.PanelFileDetails.Controls.Add(this.ButtonRequestFileSize);
            this.PanelFileDetails.Controls.Add(this.labelTitleExtension);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueExtension);
            this.PanelFileDetails.Controls.Add(this.InfoSplitter5);
            this.PanelFileDetails.Controls.Add(this.LabelFileDateModified);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueModified);
            this.PanelFileDetails.Controls.Add(this.InfoSplitter3);
            this.PanelFileDetails.Controls.Add(this.InfoSplitter2);
            this.PanelFileDetails.Controls.Add(this.LabelFileReferrer);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueDomain);
            this.PanelFileDetails.Controls.Add(this.labelTitleSize);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueSize);
            this.PanelFileDetails.Controls.Add(this.LabelFileValueName);
            this.PanelFileDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFileDetails.Enabled = false;
            this.PanelFileDetails.Location = new System.Drawing.Point(694, 166);
            this.PanelFileDetails.Name = "PanelFileDetails";
            this.PanelFileDetails.Size = new System.Drawing.Size(362, 373);
            this.PanelFileDetails.TabIndex = 1114;
            // 
            // cButton1
            // 
            this.cButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton1.BackColor = System.Drawing.Color.Transparent;
            this.cButton1.BorderColor = System.Drawing.Color.LightGray;
            this.cButton1.ColorFillSolid = System.Drawing.Color.LightGray;
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cButton1.DesignerSelected = false;
            this.cButton1.DimFactorClick = 0;
            this.cButton1.DimFactorHover = 0;
            this.cButton1.FillType = CButtonLib.CButton.eFillType.Solid;
            this.cButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cButton1.ImageIndex = 0;
            this.cButton1.Location = new System.Drawing.Point(13, 146);
            this.cButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cButton1.Name = "cButton1";
            this.cButton1.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.cButton1.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cButton1.SideImageSize = new System.Drawing.Size(21, 21);
            this.cButton1.Size = new System.Drawing.Size(334, 1);
            this.cButton1.TabIndex = 100128;
            this.cButton1.TabStop = false;
            this.cButton1.Text = "";
            this.cButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cButton1.TextShadowShow = false;
            // 
            // LabelFileAge
            // 
            this.LabelFileAge.AutoSize = true;
            this.LabelFileAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileAge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelFileAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileAge.Location = new System.Drawing.Point(10, 122);
            this.LabelFileAge.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileAge.Name = "LabelFileAge";
            this.LabelFileAge.Size = new System.Drawing.Size(36, 13);
            this.LabelFileAge.TabIndex = 100127;
            this.LabelFileAge.Text = "Age:";
            // 
            // LabelFileValueAge
            // 
            this.LabelFileValueAge.AutoSize = true;
            this.LabelFileValueAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileValueAge.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileValueAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueAge.Location = new System.Drawing.Point(143, 122);
            this.LabelFileValueAge.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileValueAge.Name = "LabelFileValueAge";
            this.LabelFileValueAge.Size = new System.Drawing.Size(12, 13);
            this.LabelFileValueAge.TabIndex = 100126;
            this.LabelFileValueAge.Text = "-";
            // 
            // LabelFileValueURL
            // 
            this.LabelFileValueURL.AutoSize = true;
            this.LabelFileValueURL.BackColor = System.Drawing.Color.LightGray;
            this.LabelFileValueURL.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelFileValueURL.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileValueURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueURL.Location = new System.Drawing.Point(22, 230);
            this.LabelFileValueURL.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileValueURL.MaximumSize = new System.Drawing.Size(314, 0);
            this.LabelFileValueURL.MinimumSize = new System.Drawing.Size(314, 0);
            this.LabelFileValueURL.Name = "LabelFileValueURL";
            this.LabelFileValueURL.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.LabelFileValueURL.Size = new System.Drawing.Size(314, 20);
            this.LabelFileValueURL.TabIndex = 100125;
            this.LabelFileValueURL.Text = "-";
            // 
            // FlowpanelFileButtons
            // 
            this.FlowpanelFileButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowpanelFileButtons.Controls.Add(this.ButtonDownloadFile);
            this.FlowpanelFileButtons.Controls.Add(this.ButtonOpenWith);
            this.FlowpanelFileButtons.Controls.Add(this.ButtonBookmark);
            this.FlowpanelFileButtons.Location = new System.Drawing.Point(13, 330);
            this.FlowpanelFileButtons.Name = "FlowpanelFileButtons";
            this.FlowpanelFileButtons.Size = new System.Drawing.Size(337, 28);
            this.FlowpanelFileButtons.TabIndex = 23;
            // 
            // ButtonDownloadFile
            // 
            this.ButtonDownloadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDownloadFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonDownloadFile.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ButtonDownloadFile.Name = "ButtonDownloadFile";
            this.ButtonDownloadFile.Size = new System.Drawing.Size(120, 28);
            this.ButtonDownloadFile.TabIndex = 100128;
            this.ButtonDownloadFile.Text = "Direct Download";
            this.ButtonDownloadFile.UseVisualStyleBackColor = true;
            this.ButtonDownloadFile.Click += new System.EventHandler(this.ButtonFileDownload_Click);
            // 
            // ButtonOpenWith
            // 
            this.ButtonOpenWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOpenWith.Location = new System.Drawing.Point(126, 0);
            this.ButtonOpenWith.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ButtonOpenWith.Name = "ButtonOpenWith";
            this.ButtonOpenWith.Size = new System.Drawing.Size(96, 28);
            this.ButtonOpenWith.TabIndex = 100130;
            this.ButtonOpenWith.Text = "Open with...";
            this.ButtonOpenWith.UseVisualStyleBackColor = true;
            this.ButtonOpenWith.Click += new System.EventHandler(this.ButtonFileOpenWith_Click);
            // 
            // ButtonBookmark
            // 
            this.ButtonBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonBookmark.Location = new System.Drawing.Point(228, 0);
            this.ButtonBookmark.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ButtonBookmark.Name = "ButtonBookmark";
            this.ButtonBookmark.Size = new System.Drawing.Size(88, 28);
            this.ButtonBookmark.TabIndex = 100129;
            this.ButtonBookmark.Text = "Bookmark";
            this.ButtonBookmark.UseVisualStyleBackColor = true;
            this.ButtonBookmark.Click += new System.EventHandler(this.ButtonFileSave_Click);
            // 
            // LabelFileUrlBG
            // 
            this.LabelFileUrlBG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFileUrlBG.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileUrlBG.BorderColor = System.Drawing.Color.LightGray;
            cBlendItems2.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems2.iPoint = new float[] {
        0F,
        1F};
            this.LabelFileUrlBG.ColorFillBlend = cBlendItems2;
            this.LabelFileUrlBG.ColorFillSolid = System.Drawing.Color.LightGray;
            this.LabelFileUrlBG.Corners.All = 2;
            this.LabelFileUrlBG.Corners.LowerLeft = 2;
            this.LabelFileUrlBG.Corners.LowerRight = 2;
            this.LabelFileUrlBG.Corners.UpperLeft = 2;
            this.LabelFileUrlBG.Corners.UpperRight = 2;
            this.LabelFileUrlBG.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelFileUrlBG.DesignerSelected = false;
            this.LabelFileUrlBG.DimFactorClick = 0;
            this.LabelFileUrlBG.DimFactorHover = 0;
            this.LabelFileUrlBG.FillType = CButtonLib.CButton.eFillType.Solid;
            this.LabelFileUrlBG.FocalPoints.CenterPtX = 0F;
            this.LabelFileUrlBG.FocalPoints.CenterPtY = 0F;
            this.LabelFileUrlBG.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileUrlBG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelFileUrlBG.ImageIndex = 0;
            this.LabelFileUrlBG.ImageSize = new System.Drawing.Size(24, 24);
            this.LabelFileUrlBG.Location = new System.Drawing.Point(13, 222);
            this.LabelFileUrlBG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LabelFileUrlBG.Name = "LabelFileUrlBG";
            this.LabelFileUrlBG.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.LabelFileUrlBG.SideImageSize = new System.Drawing.Size(24, 24);
            this.LabelFileUrlBG.Size = new System.Drawing.Size(334, 36);
            this.LabelFileUrlBG.TabIndex = 100124;
            this.LabelFileUrlBG.TabStop = false;
            this.LabelFileUrlBG.Text = "";
            this.LabelFileUrlBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelFileUrlBG.TextMargin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.LabelFileUrlBG.TextShadowShow = false;
            // 
            // InfoSplitter1
            // 
            this.InfoSplitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter1.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter1.BorderColor = System.Drawing.Color.LightGray;
            this.InfoSplitter1.ColorFillSolid = System.Drawing.Color.LightGray;
            this.InfoSplitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter1.DesignerSelected = false;
            this.InfoSplitter1.DimFactorClick = 0;
            this.InfoSplitter1.DimFactorHover = 0;
            this.InfoSplitter1.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter1.ImageIndex = 0;
            this.InfoSplitter1.Location = new System.Drawing.Point(13, 37);
            this.InfoSplitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoSplitter1.Name = "InfoSplitter1";
            this.InfoSplitter1.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter1.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter1.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter1.Size = new System.Drawing.Size(334, 2);
            this.InfoSplitter1.TabIndex = 100123;
            this.InfoSplitter1.TabStop = false;
            this.InfoSplitter1.Text = "";
            this.InfoSplitter1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter1.TextShadowShow = false;
            // 
            // ButtonRequestFileSize
            // 
            this.ButtonRequestFileSize.Location = new System.Drawing.Point(146, 44);
            this.ButtonRequestFileSize.Name = "ButtonRequestFileSize";
            this.ButtonRequestFileSize.Size = new System.Drawing.Size(100, 26);
            this.ButtonRequestFileSize.TabIndex = 100122;
            this.ButtonRequestFileSize.Text = "Request Size";
            this.ButtonRequestFileSize.UseVisualStyleBackColor = true;
            this.ButtonRequestFileSize.Click += new System.EventHandler(this.ButtonFileRequestSize_Click);
            // 
            // labelTitleExtension
            // 
            this.labelTitleExtension.AutoSize = true;
            this.labelTitleExtension.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleExtension.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelTitleExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleExtension.Location = new System.Drawing.Point(10, 191);
            this.labelTitleExtension.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.labelTitleExtension.Name = "labelTitleExtension";
            this.labelTitleExtension.Size = new System.Drawing.Size(43, 13);
            this.labelTitleExtension.TabIndex = 100118;
            this.labelTitleExtension.Text = "Type:";
            // 
            // LabelFileValueExtension
            // 
            this.LabelFileValueExtension.AutoSize = true;
            this.LabelFileValueExtension.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileValueExtension.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileValueExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueExtension.Location = new System.Drawing.Point(143, 191);
            this.LabelFileValueExtension.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileValueExtension.Name = "LabelFileValueExtension";
            this.LabelFileValueExtension.Size = new System.Drawing.Size(12, 13);
            this.LabelFileValueExtension.TabIndex = 100117;
            this.LabelFileValueExtension.Text = "-";
            // 
            // InfoSplitter5
            // 
            this.InfoSplitter5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter5.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter5.BorderColor = System.Drawing.Color.LightGray;
            this.InfoSplitter5.ColorFillSolid = System.Drawing.Color.LightGray;
            this.InfoSplitter5.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter5.DesignerSelected = false;
            this.InfoSplitter5.DimFactorClick = 0;
            this.InfoSplitter5.DimFactorHover = 0;
            this.InfoSplitter5.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter5.ImageIndex = 0;
            this.InfoSplitter5.Location = new System.Drawing.Point(13, 111);
            this.InfoSplitter5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoSplitter5.Name = "InfoSplitter5";
            this.InfoSplitter5.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter5.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter5.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter5.Size = new System.Drawing.Size(334, 1);
            this.InfoSplitter5.TabIndex = 100115;
            this.InfoSplitter5.TabStop = false;
            this.InfoSplitter5.Text = "";
            this.InfoSplitter5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter5.TextShadowShow = false;
            // 
            // LabelFileDateModified
            // 
            this.LabelFileDateModified.AutoSize = true;
            this.LabelFileDateModified.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileDateModified.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelFileDateModified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileDateModified.Location = new System.Drawing.Point(10, 87);
            this.LabelFileDateModified.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileDateModified.Name = "LabelFileDateModified";
            this.LabelFileDateModified.Size = new System.Drawing.Size(66, 13);
            this.LabelFileDateModified.TabIndex = 100114;
            this.LabelFileDateModified.Text = "Modified:";
            // 
            // LabelFileValueModified
            // 
            this.LabelFileValueModified.AutoSize = true;
            this.LabelFileValueModified.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileValueModified.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileValueModified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueModified.Location = new System.Drawing.Point(143, 87);
            this.LabelFileValueModified.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileValueModified.Name = "LabelFileValueModified";
            this.LabelFileValueModified.Size = new System.Drawing.Size(12, 13);
            this.LabelFileValueModified.TabIndex = 100108;
            this.LabelFileValueModified.Text = "-";
            // 
            // InfoSplitter3
            // 
            this.InfoSplitter3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter3.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter3.BorderColor = System.Drawing.Color.LightGray;
            this.InfoSplitter3.ColorFillSolid = System.Drawing.Color.LightGray;
            this.InfoSplitter3.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter3.DesignerSelected = false;
            this.InfoSplitter3.DimFactorClick = 0;
            this.InfoSplitter3.DimFactorHover = 0;
            this.InfoSplitter3.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter3.ImageIndex = 0;
            this.InfoSplitter3.Location = new System.Drawing.Point(13, 180);
            this.InfoSplitter3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoSplitter3.Name = "InfoSplitter3";
            this.InfoSplitter3.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter3.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter3.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter3.Size = new System.Drawing.Size(334, 1);
            this.InfoSplitter3.TabIndex = 100113;
            this.InfoSplitter3.TabStop = false;
            this.InfoSplitter3.Text = "";
            this.InfoSplitter3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter3.TextShadowShow = false;
            // 
            // InfoSplitter2
            // 
            this.InfoSplitter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter2.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter2.BorderColor = System.Drawing.Color.LightGray;
            this.InfoSplitter2.ColorFillSolid = System.Drawing.Color.LightGray;
            this.InfoSplitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter2.DesignerSelected = false;
            this.InfoSplitter2.DimFactorClick = 0;
            this.InfoSplitter2.DimFactorHover = 0;
            this.InfoSplitter2.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter2.ImageIndex = 0;
            this.InfoSplitter2.Location = new System.Drawing.Point(13, 75);
            this.InfoSplitter2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoSplitter2.Name = "InfoSplitter2";
            this.InfoSplitter2.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter2.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter2.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter2.Size = new System.Drawing.Size(334, 1);
            this.InfoSplitter2.TabIndex = 100110;
            this.InfoSplitter2.TabStop = false;
            this.InfoSplitter2.Text = "";
            this.InfoSplitter2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter2.TextShadowShow = false;
            // 
            // LabelFileReferrer
            // 
            this.LabelFileReferrer.AutoSize = true;
            this.LabelFileReferrer.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileReferrer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelFileReferrer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileReferrer.Location = new System.Drawing.Point(10, 156);
            this.LabelFileReferrer.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileReferrer.Name = "LabelFileReferrer";
            this.LabelFileReferrer.Size = new System.Drawing.Size(60, 13);
            this.LabelFileReferrer.TabIndex = 100109;
            this.LabelFileReferrer.Text = "Domain:";
            // 
            // LabelFileValueDomain
            // 
            this.LabelFileValueDomain.AutoSize = true;
            this.LabelFileValueDomain.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileValueDomain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelFileValueDomain.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileValueDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueDomain.Location = new System.Drawing.Point(143, 156);
            this.LabelFileValueDomain.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileValueDomain.Name = "LabelFileValueDomain";
            this.LabelFileValueDomain.Size = new System.Drawing.Size(12, 13);
            this.LabelFileValueDomain.TabIndex = 100116;
            this.LabelFileValueDomain.Text = "-";
            // 
            // labelTitleSize
            // 
            this.labelTitleSize.AutoSize = true;
            this.labelTitleSize.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleSize.Location = new System.Drawing.Point(10, 50);
            this.labelTitleSize.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.labelTitleSize.Name = "labelTitleSize";
            this.labelTitleSize.Size = new System.Drawing.Size(38, 13);
            this.labelTitleSize.TabIndex = 100121;
            this.labelTitleSize.Text = "Size:";
            // 
            // LabelFileValueSize
            // 
            this.LabelFileValueSize.AutoSize = true;
            this.LabelFileValueSize.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileValueSize.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LabelFileValueSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueSize.Location = new System.Drawing.Point(143, 50);
            this.LabelFileValueSize.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.LabelFileValueSize.Name = "LabelFileValueSize";
            this.LabelFileValueSize.Size = new System.Drawing.Size(12, 13);
            this.LabelFileValueSize.TabIndex = 100120;
            this.LabelFileValueSize.Text = "-";
            // 
            // LabelFileValueName
            // 
            this.LabelFileValueName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFileValueName.AutoEllipsis = true;
            this.LabelFileValueName.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileValueName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelFileValueName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFileValueName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileValueName.Location = new System.Drawing.Point(10, 8);
            this.LabelFileValueName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFileValueName.Name = "LabelFileValueName";
            this.LabelFileValueName.Size = new System.Drawing.Size(341, 21);
            this.LabelFileValueName.TabIndex = 100099;
            this.LabelFileValueName.Text = "File Name";
            this.LabelFileValueName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContextFileOpenWith
            // 
            this.ContextFileOpenWith.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextFileOpenWith.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NitroReaderToolStripMenuItem,
            this.VLCToolStripMenuItem,
            this.WMPToolStripMenuItem,
            this.MPCToolStripMenuItem,
            this.KMPlayerToolStripMenuItem,
            this.PotPlayerToolStripMenuItem,
            this.IDMToolStripMenuItem,
            this.IDAToolStripMenuItem,
            this.FDMToolStripMenuItem});
            this.ContextFileOpenWith.Name = "contextMenuStrip1";
            this.ContextFileOpenWith.ShowItemToolTips = false;
            this.ContextFileOpenWith.Size = new System.Drawing.Size(240, 238);
            // 
            // NitroReaderToolStripMenuItem
            // 
            this.NitroReaderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NitroReaderToolStripMenuItem.Image")));
            this.NitroReaderToolStripMenuItem.Name = "NitroReaderToolStripMenuItem";
            this.NitroReaderToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.NitroReaderToolStripMenuItem.Text = "Nitro Reader";
            this.NitroReaderToolStripMenuItem.Visible = false;
            this.NitroReaderToolStripMenuItem.Click += new System.EventHandler(this.NitroReaderToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Image = global::FileMasta.Properties.Resources.vlc;
            this.VLCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.VLCToolStripMenuItem.Text = "VLC Player";
            this.VLCToolStripMenuItem.Visible = false;
            this.VLCToolStripMenuItem.Click += new System.EventHandler(this.VLCToolStripMenuItem_Click);
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Image = global::FileMasta.Properties.Resources.windows;
            this.WMPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.WMPToolStripMenuItem.Text = "Windows Media Player";
            this.WMPToolStripMenuItem.Visible = false;
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.WMPToolStripMenuItem_Click);
            // 
            // MPCToolStripMenuItem
            // 
            this.MPCToolStripMenuItem.Image = global::FileMasta.Properties.Resources.play_circle;
            this.MPCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MPCToolStripMenuItem.Name = "MPCToolStripMenuItem";
            this.MPCToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.MPCToolStripMenuItem.Text = "Media Player Classic";
            this.MPCToolStripMenuItem.Visible = false;
            this.MPCToolStripMenuItem.Click += new System.EventHandler(this.MPCToolStripMenuItem_Click);
            // 
            // KMPlayerToolStripMenuItem
            // 
            this.KMPlayerToolStripMenuItem.Image = global::FileMasta.Properties.Resources.play_circle;
            this.KMPlayerToolStripMenuItem.Name = "KMPlayerToolStripMenuItem";
            this.KMPlayerToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.KMPlayerToolStripMenuItem.Text = "KMPlayer";
            this.KMPlayerToolStripMenuItem.Visible = false;
            this.KMPlayerToolStripMenuItem.Click += new System.EventHandler(this.KMPlayerToolStripMenuItem_Click);
            // 
            // PotPlayerToolStripMenuItem
            // 
            this.PotPlayerToolStripMenuItem.Image = global::FileMasta.Properties.Resources.play_circle;
            this.PotPlayerToolStripMenuItem.Name = "PotPlayerToolStripMenuItem";
            this.PotPlayerToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.PotPlayerToolStripMenuItem.Text = "PotPlayer";
            this.PotPlayerToolStripMenuItem.Visible = false;
            this.PotPlayerToolStripMenuItem.Click += new System.EventHandler(this.PotPlayerToolStripMenuItem_Click);
            // 
            // IDMToolStripMenuItem
            // 
            this.IDMToolStripMenuItem.Image = global::FileMasta.Properties.Resources.download;
            this.IDMToolStripMenuItem.Name = "IDMToolStripMenuItem";
            this.IDMToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.IDMToolStripMenuItem.Text = "Internet Download Manager";
            this.IDMToolStripMenuItem.Visible = false;
            this.IDMToolStripMenuItem.Click += new System.EventHandler(this.IDMToolStripMenuItem_Click);
            // 
            // IDAToolStripMenuItem
            // 
            this.IDAToolStripMenuItem.Image = global::FileMasta.Properties.Resources.download;
            this.IDAToolStripMenuItem.Name = "IDAToolStripMenuItem";
            this.IDAToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.IDAToolStripMenuItem.Text = "Internet Download Accelerator";
            this.IDAToolStripMenuItem.Visible = false;
            this.IDAToolStripMenuItem.Click += new System.EventHandler(this.IDAToolStripMenuItem_Click);
            // 
            // FDMToolStripMenuItem
            // 
            this.FDMToolStripMenuItem.Image = global::FileMasta.Properties.Resources.download;
            this.FDMToolStripMenuItem.Name = "FDMToolStripMenuItem";
            this.FDMToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.FDMToolStripMenuItem.Text = "Free Download Manager";
            this.FDMToolStripMenuItem.Visible = false;
            this.FDMToolStripMenuItem.Click += new System.EventHandler(this.FDMToolStripMenuItem_Click);
            // 
            // TextboxSearchName
            // 
            this.TextboxSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxSearchName.BackColor = System.Drawing.SystemColors.Window;
            this.TextboxSearchName.Location = new System.Drawing.Point(62, 10);
            this.TextboxSearchName.Name = "TextboxSearchName";
            this.TextboxSearchName.Size = new System.Drawing.Size(639, 21);
            this.TextboxSearchName.TabIndex = 0;
            this.TextboxSearchName.WaterMark = "Search the web for anything...";
            this.TextboxSearchName.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.TextboxSearchName.WaterMarkFont = new System.Drawing.Font("Verdana", 8.25F);
            this.TextboxSearchName.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextboxSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchQuery_KeyDown);
            // 
            // LabelSearchType
            // 
            this.LabelSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearchType.AutoSize = true;
            this.LabelSearchType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchType.Location = new System.Drawing.Point(710, 14);
            this.LabelSearchType.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelSearchType.Name = "LabelSearchType";
            this.LabelSearchType.Size = new System.Drawing.Size(39, 13);
            this.LabelSearchType.TabIndex = 2;
            this.LabelSearchType.Text = "Type:";
            // 
            // DropdownSearchSort
            // 
            this.DropdownSearchSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownSearchSort.FormattingEnabled = true;
            this.DropdownSearchSort.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Modified"});
            this.DropdownSearchSort.Location = new System.Drawing.Point(564, 40);
            this.DropdownSearchSort.Name = "DropdownSearchSort";
            this.DropdownSearchSort.Size = new System.Drawing.Size(64, 21);
            this.DropdownSearchSort.TabIndex = 2;
            this.DropdownSearchSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // LabelSort
            // 
            this.LabelSort.AutoSize = true;
            this.LabelSort.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSort.Location = new System.Drawing.Point(525, 45);
            this.LabelSort.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(36, 13);
            this.LabelSort.TabIndex = 5;
            this.LabelSort.Text = "Sort:";
            this.LabelSort.Click += new System.EventHandler(this.LabelSort_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.Location = new System.Drawing.Point(953, 10);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(71, 26);
            this.ButtonSearch.TabIndex = 4;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearchFiles_Click);
            // 
            // FlowpanelKeywords
            // 
            this.FlowpanelKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowpanelKeywords.BackColor = System.Drawing.Color.Transparent;
            this.FlowpanelKeywords.Controls.Add(this.LabelSearchKeywords);
            this.FlowpanelKeywords.Location = new System.Drawing.Point(10, 74);
            this.FlowpanelKeywords.Name = "FlowpanelKeywords";
            this.FlowpanelKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlowpanelKeywords.Size = new System.Drawing.Size(1036, 58);
            this.FlowpanelKeywords.TabIndex = 6;
            this.FlowpanelKeywords.TabStop = true;
            // 
            // ButtonSearchExternal
            // 
            this.ButtonSearchExternal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearchExternal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchExternal.Location = new System.Drawing.Point(1024, 10);
            this.ButtonSearchExternal.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonSearchExternal.Name = "ButtonSearchExternal";
            this.ButtonSearchExternal.Size = new System.Drawing.Size(20, 26);
            this.ButtonSearchExternal.TabIndex = 5;
            this.ButtonSearchExternal.Text = "⯆";
            this.ButtonSearchExternal.UseVisualStyleBackColor = true;
            this.ButtonSearchExternal.Click += new System.EventHandler(this.ButtonSearchEngine_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(10, 14);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 13);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name:";
            // 
            // ListboxSearchType
            // 
            this.ListboxSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListboxSearchType.FormattingEnabled = true;
            this.ListboxSearchType.Items.AddRange(new object[] {
            "Any",
            "Audio",
            "Compressed",
            "Document",
            "Executable",
            "Picture",
            "Video"});
            this.ListboxSearchType.Location = new System.Drawing.Point(752, 10);
            this.ListboxSearchType.Name = "ListboxSearchType";
            this.ListboxSearchType.Size = new System.Drawing.Size(192, 56);
            this.ListboxSearchType.TabIndex = 11;
            this.ListboxSearchType.SelectedIndexChanged += new System.EventHandler(this.ListboxType_SelectedIndexChanged);
            // 
            // LabelSearchSizeMoreOrEqualTo
            // 
            this.LabelSearchSizeMoreOrEqualTo.AutoSize = true;
            this.LabelSearchSizeMoreOrEqualTo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchSizeMoreOrEqualTo.Location = new System.Drawing.Point(10, 46);
            this.LabelSearchSizeMoreOrEqualTo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LabelSearchSizeMoreOrEqualTo.Name = "LabelSearchSizeMoreOrEqualTo";
            this.LabelSearchSizeMoreOrEqualTo.Size = new System.Drawing.Size(49, 13);
            this.LabelSearchSizeMoreOrEqualTo.TabIndex = 12;
            this.LabelSearchSizeMoreOrEqualTo.Text = "Size ≥:";
            // 
            // NumericSearchGreaterThan
            // 
            this.NumericSearchGreaterThan.Location = new System.Drawing.Point(62, 42);
            this.NumericSearchGreaterThan.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NumericSearchGreaterThan.Name = "NumericSearchGreaterThan";
            this.NumericSearchGreaterThan.Size = new System.Drawing.Size(74, 21);
            this.NumericSearchGreaterThan.TabIndex = 14;
            // 
            // LabelSearchLastModified
            // 
            this.LabelSearchLastModified.AutoSize = true;
            this.LabelSearchLastModified.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchLastModified.Location = new System.Drawing.Point(202, 46);
            this.LabelSearchLastModified.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelSearchLastModified.Name = "LabelSearchLastModified";
            this.LabelSearchLastModified.Size = new System.Drawing.Size(59, 13);
            this.LabelSearchLastModified.TabIndex = 17;
            this.LabelSearchLastModified.Text = "Modified:";
            this.LabelSearchLastModified.Click += new System.EventHandler(this.LabelSearchLastModified_Click);
            // 
            // DateTimeMinMTime
            // 
            this.DateTimeMinMTime.CustomFormat = "MMMd, yyyy";
            this.DateTimeMinMTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeMinMTime.Location = new System.Drawing.Point(264, 41);
            this.DateTimeMinMTime.Name = "DateTimeMinMTime";
            this.DateTimeMinMTime.Size = new System.Drawing.Size(114, 21);
            this.DateTimeMinMTime.TabIndex = 19;
            this.DateTimeMinMTime.Value = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            this.DateTimeMinMTime.ValueChanged += new System.EventHandler(this.DateTimeMinMTime_ValueChanged);
            // 
            // DateTimeMaxMTime
            // 
            this.DateTimeMaxMTime.CustomFormat = "MMMd, yyyy";
            this.DateTimeMaxMTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeMaxMTime.Location = new System.Drawing.Point(404, 41);
            this.DateTimeMaxMTime.Name = "DateTimeMaxMTime";
            this.DateTimeMaxMTime.Size = new System.Drawing.Size(114, 21);
            this.DateTimeMaxMTime.TabIndex = 20;
            this.DateTimeMaxMTime.Value = new System.DateTime(2019, 1, 8, 0, 0, 0, 0);
            this.DateTimeMaxMTime.ValueChanged += new System.EventHandler(this.DateTimeMaxMTime_ValueChanged);
            // 
            // LabelSearchModifiedTo
            // 
            this.LabelSearchModifiedTo.AutoSize = true;
            this.LabelSearchModifiedTo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchModifiedTo.Location = new System.Drawing.Point(383, 45);
            this.LabelSearchModifiedTo.Name = "LabelSearchModifiedTo";
            this.LabelSearchModifiedTo.Size = new System.Drawing.Size(18, 13);
            this.LabelSearchModifiedTo.TabIndex = 21;
            this.LabelSearchModifiedTo.Text = "to";
            this.LabelSearchModifiedTo.Click += new System.EventHandler(this.LabelSearchModifiedTo_Click);
            // 
            // DropdownSearchSizePrefix
            // 
            this.DropdownSearchSizePrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownSearchSizePrefix.FormattingEnabled = true;
            this.DropdownSearchSizePrefix.Items.AddRange(new object[] {
            "Bytes",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB"});
            this.DropdownSearchSizePrefix.Location = new System.Drawing.Point(139, 42);
            this.DropdownSearchSizePrefix.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DropdownSearchSizePrefix.Name = "DropdownSearchSizePrefix";
            this.DropdownSearchSizePrefix.Size = new System.Drawing.Size(56, 21);
            this.DropdownSearchSizePrefix.TabIndex = 22;
            this.DropdownSearchSizePrefix.SelectedIndexChanged += new System.EventHandler(this.DropdownSearchSizePrefix_SelectedIndexChanged);
            // 
            // PanelSearchControls
            // 
            this.PanelSearchControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.PanelSearchControls.Controls.Add(this.DropdownSearchSizePrefix);
            this.PanelSearchControls.Controls.Add(this.LabelSearchModifiedTo);
            this.PanelSearchControls.Controls.Add(this.DateTimeMaxMTime);
            this.PanelSearchControls.Controls.Add(this.DateTimeMinMTime);
            this.PanelSearchControls.Controls.Add(this.LabelSearchLastModified);
            this.PanelSearchControls.Controls.Add(this.NumericSearchGreaterThan);
            this.PanelSearchControls.Controls.Add(this.LabelSearchSizeMoreOrEqualTo);
            this.PanelSearchControls.Controls.Add(this.ListboxSearchType);
            this.PanelSearchControls.Controls.Add(this.LabelName);
            this.PanelSearchControls.Controls.Add(this.ButtonSearchExternal);
            this.PanelSearchControls.Controls.Add(this.FlowpanelKeywords);
            this.PanelSearchControls.Controls.Add(this.ButtonSearch);
            this.PanelSearchControls.Controls.Add(this.LabelSort);
            this.PanelSearchControls.Controls.Add(this.DropdownSearchSort);
            this.PanelSearchControls.Controls.Add(this.LabelSearchType);
            this.PanelSearchControls.Controls.Add(this.TextboxSearchName);
            this.PanelSearchControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchControls.Location = new System.Drawing.Point(0, 24);
            this.PanelSearchControls.Name = "PanelSearchControls";
            this.PanelSearchControls.Size = new System.Drawing.Size(1056, 142);
            this.PanelSearchControls.TabIndex = 1;
            // 
            // LabelSearchKeywords
            // 
            this.LabelSearchKeywords.AutoSize = true;
            this.LabelSearchKeywords.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchKeywords.Location = new System.Drawing.Point(0, 0);
            this.LabelSearchKeywords.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSearchKeywords.Name = "LabelSearchKeywords";
            this.LabelSearchKeywords.Size = new System.Drawing.Size(68, 13);
            this.LabelSearchKeywords.TabIndex = 13;
            this.LabelSearchKeywords.Text = "Keywords:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1056, 561);
            this.Controls.Add(this.DataGridFiles);
            this.Controls.Add(this.PanelFileDetails);
            this.Controls.Add(this.StatusStripFooter);
            this.Controls.Add(this.PanelSearchControls);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(989, 450);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMasta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiles)).EndInit();
            this.ContextMenuFile.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStripFooter.ResumeLayout(false);
            this.StatusStripFooter.PerformLayout();
            this.ContextMenuSearchExternal.ResumeLayout(false);
            this.PanelFileDetails.ResumeLayout(false);
            this.PanelFileDetails.PerformLayout();
            this.FlowpanelFileButtons.ResumeLayout(false);
            this.ContextFileOpenWith.ResumeLayout(false);
            this.FlowpanelKeywords.ResumeLayout(false);
            this.FlowpanelKeywords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSearchGreaterThan)).EndInit();
            this.PanelSearchControls.ResumeLayout(false);
            this.PanelSearchControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView DataGridFiles;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTools;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelp;
        private System.Windows.Forms.StatusStrip StatusStripFooter;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripDatabaseInfo;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripSpring;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpReportIssue;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuFileViewDetails;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeperator1;
        private System.Windows.Forms.ToolStripMenuItem MenuFileCopyURL;
        private System.Windows.Forms.ToolStripMenuItem MenuStripBookmarks;
        private System.Windows.Forms.ToolStripMenuItem MenuFileMinimizeToTray;
        private System.Windows.Forms.NotifyIcon NotifyTrayIcon;
        private System.Windows.Forms.ToolStripSeparator MenuStripHelpSeperator0;
        private System.Windows.Forms.ToolStripMenuItem MenuToolsOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip ContextMenuSearchExternal;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchGoogle;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchGoogol;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchStartPage;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchSearx;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpCheckForUpdate;
        private System.Windows.Forms.ToolStripSeparator MenuStripHelpSeperator1;
        private System.Windows.Forms.Panel PanelFileDetails;
        public System.Windows.Forms.Label LabelFileValueName;
        private System.Windows.Forms.Button ButtonRequestFileSize;
        public System.Windows.Forms.Label labelTitleExtension;
        public System.Windows.Forms.Label LabelFileValueExtension;
        public CButtonLib.CButton InfoSplitter5;
        public System.Windows.Forms.Label LabelFileDateModified;
        public System.Windows.Forms.Label LabelFileValueModified;
        public CButtonLib.CButton InfoSplitter3;
        public CButtonLib.CButton InfoSplitter2;
        public System.Windows.Forms.Label LabelFileReferrer;
        public System.Windows.Forms.Label LabelFileValueDomain;
        public System.Windows.Forms.Label labelTitleSize;
        public System.Windows.Forms.Label LabelFileValueSize;
        public CButtonLib.CButton InfoSplitter1;
        public CButtonLib.CButton LabelFileUrlBG;
        private System.Windows.Forms.Button ButtonBookmark;
        private System.Windows.Forms.Button ButtonDownloadFile;
        private System.Windows.Forms.Button ButtonOpenWith;
        public System.Windows.Forms.ContextMenuStrip ContextFileOpenWith;
        private System.Windows.Forms.ToolStripMenuItem NitroReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KMPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PotPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FDMToolStripMenuItem;
        public ChreneLib.Controls.TextBoxes.CTextBox TextboxSearchName;
        private System.Windows.Forms.Label LabelSearchType;
        private System.Windows.Forms.ComboBox DropdownSearchSort;
        private System.Windows.Forms.Label LabelSort;
        public System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.FlowLayoutPanel FlowpanelKeywords;
        public System.Windows.Forms.Button ButtonSearchExternal;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.ListBox ListboxSearchType;
        private System.Windows.Forms.Label LabelSearchSizeMoreOrEqualTo;
        private System.Windows.Forms.NumericUpDown NumericSearchGreaterThan;
        private System.Windows.Forms.Label LabelSearchLastModified;
        private System.Windows.Forms.DateTimePicker DateTimeMinMTime;
        private System.Windows.Forms.DateTimePicker DateTimeMaxMTime;
        private System.Windows.Forms.Label LabelSearchModifiedTo;
        private System.Windows.Forms.ComboBox DropdownSearchSizePrefix;
        private System.Windows.Forms.Panel PanelSearchControls;
        private System.Windows.Forms.FlowLayoutPanel FlowpanelFileButtons;
        public System.Windows.Forms.Label LabelFileValueURL;
        private System.Windows.Forms.ToolStripMenuItem MenuFileEmail;
        private System.Windows.Forms.ToolStripMenuItem MenuFileBookmark;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpChangelog;
        public CButtonLib.CButton cButton1;
        public System.Windows.Forms.Label LabelFileAge;
        public System.Windows.Forms.Label LabelFileValueAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileLastModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilesURL;
        private System.Windows.Forms.Label LabelSearchKeywords;
    }
}

