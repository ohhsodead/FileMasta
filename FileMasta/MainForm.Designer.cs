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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBoxSearchQuery = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.DataGridFiles = new System.Windows.Forms.DataGridView();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileReferrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilesURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileViewWebPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileCopyURL = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileMinimizeToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripBookmarks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolsFtpServerList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolsSubmitFtpServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpKeyboardShortcuts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripFileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelSearchControls = new System.Windows.Forms.Panel();
            this.ButtonSearchEngine = new System.Windows.Forms.Button();
            this.FlowPanelMostSearches = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelMostSearches = new System.Windows.Forms.Label();
            this.ButtonSearchFiles = new System.Windows.Forms.Button();
            this.LabelHost = new System.Windows.Forms.Label();
            this.ComboBoxHost = new System.Windows.Forms.ComboBox();
            this.LabelSort = new System.Windows.Forms.Label();
            this.ComboBoxSort = new System.Windows.Forms.ComboBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.StatusStripFooter = new System.Windows.Forms.StatusStrip();
            this.StatusStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripDatabaseInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotifyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuSearchEngine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSearchGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchGoogol = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchStartPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchSearx = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiles)).BeginInit();
            this.ContextMenuFile.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.PanelSearchControls.SuspendLayout();
            this.StatusStripFooter.SuspendLayout();
            this.ContextMenuSearchEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearchQuery
            // 
            this.TextBoxSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearchQuery.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxSearchQuery.Location = new System.Drawing.Point(12, 10);
            this.TextBoxSearchQuery.Name = "TextBoxSearchQuery";
            this.TextBoxSearchQuery.Size = new System.Drawing.Size(432, 22);
            this.TextBoxSearchQuery.TabIndex = 0;
            this.TextBoxSearchQuery.WaterMark = "Search for file names, add tags or insert a link...";
            this.TextBoxSearchQuery.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.TextBoxSearchQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextBoxSearchQuery.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchQuery_KeyDown);
            // 
            // DataGridFiles
            // 
            this.DataGridFiles.AllowUserToAddRows = false;
            this.DataGridFiles.AllowUserToDeleteRows = false;
            this.DataGridFiles.AllowUserToResizeColumns = false;
            this.DataGridFiles.AllowUserToResizeRows = false;
            this.DataGridFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFileName,
            this.ColumnFileSize,
            this.ColumnFileAge,
            this.ColumnFileReferrer,
            this.ColumnFilesURL});
            this.DataGridFiles.ContextMenuStrip = this.ContextMenuFile;
            this.DataGridFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridFiles.EnableHeadersVisualStyles = false;
            this.DataGridFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.Location = new System.Drawing.Point(0, 170);
            this.DataGridFiles.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridFiles.MultiSelect = false;
            this.DataGridFiles.Name = "DataGridFiles";
            this.DataGridFiles.ReadOnly = true;
            this.DataGridFiles.RowHeadersVisible = false;
            this.DataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridFiles.RowTemplate.ContextMenuStrip = this.ContextMenuFile;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataGridFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFiles.RowTemplate.ErrorText = "Can\'t load info";
            this.DataGridFiles.RowTemplate.Height = 24;
            this.DataGridFiles.RowTemplate.ReadOnly = true;
            this.DataGridFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridFiles.ShowCellErrors = false;
            this.DataGridFiles.ShowEditingIcon = false;
            this.DataGridFiles.ShowRowErrors = false;
            this.DataGridFiles.Size = new System.Drawing.Size(992, 302);
            this.DataGridFiles.TabIndex = 14;
            this.DataGridFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFiles_CellClick);
            this.DataGridFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFiles_CellDoubleClick);
            this.DataGridFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridFiles_CellPainting);
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnFileName.HeaderText = "Name";
            this.ColumnFileName.Name = "ColumnFileName";
            this.ColumnFileName.ReadOnly = true;
            this.ColumnFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnFileSize
            // 
            this.ColumnFileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileSize.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnFileSize.HeaderText = "Size";
            this.ColumnFileSize.Name = "ColumnFileSize";
            this.ColumnFileSize.ReadOnly = true;
            this.ColumnFileSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnFileSize.Width = 105;
            // 
            // ColumnFileAge
            // 
            this.ColumnFileAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileAge.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnFileAge.HeaderText = "Age";
            this.ColumnFileAge.Name = "ColumnFileAge";
            this.ColumnFileAge.ReadOnly = true;
            this.ColumnFileAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnFileAge.Width = 84;
            // 
            // ColumnFileReferrer
            // 
            this.ColumnFileReferrer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileReferrer.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnFileReferrer.HeaderText = "Referrer";
            this.ColumnFileReferrer.Name = "ColumnFileReferrer";
            this.ColumnFileReferrer.ReadOnly = true;
            this.ColumnFileReferrer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnFileReferrer.Width = 165;
            // 
            // ColumnFilesURL
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFilesURL.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnFilesURL.HeaderText = "URL";
            this.ColumnFilesURL.Name = "ColumnFilesURL";
            this.ColumnFilesURL.ReadOnly = true;
            this.ColumnFilesURL.Visible = false;
            // 
            // ContextMenuFile
            // 
            this.ContextMenuFile.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOpen,
            this.MenuFileSeperator1,
            this.MenuFileViewDetails,
            this.MenuFileViewWebPage,
            this.MenuFileSeperator2,
            this.MenuFileCopyURL});
            this.ContextMenuFile.Name = "contextMenuFileItem";
            this.ContextMenuFile.Size = new System.Drawing.Size(181, 104);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuFileOpen.Text = "Open File...";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSeperator1
            // 
            this.MenuFileSeperator1.Name = "MenuFileSeperator1";
            this.MenuFileSeperator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuFileViewDetails
            // 
            this.MenuFileViewDetails.Name = "MenuFileViewDetails";
            this.MenuFileViewDetails.Size = new System.Drawing.Size(180, 22);
            this.MenuFileViewDetails.Text = "View File Details...";
            this.MenuFileViewDetails.Click += new System.EventHandler(this.MenuFileViewDetails_Click);
            // 
            // MenuFileViewWebPage
            // 
            this.MenuFileViewWebPage.Name = "MenuFileViewWebPage";
            this.MenuFileViewWebPage.Size = new System.Drawing.Size(180, 22);
            this.MenuFileViewWebPage.Text = "View Web Page...";
            this.MenuFileViewWebPage.Click += new System.EventHandler(this.MenuFileViewWebPage_Click);
            // 
            // MenuFileSeperator2
            // 
            this.MenuFileSeperator2.Name = "MenuFileSeperator2";
            this.MenuFileSeperator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuFileCopyURL
            // 
            this.MenuFileCopyURL.Name = "MenuFileCopyURL";
            this.MenuFileCopyURL.Size = new System.Drawing.Size(180, 22);
            this.MenuFileCopyURL.Text = "File URL > Clipboard";
            this.MenuFileCopyURL.Click += new System.EventHandler(this.MenuFileCopyURL_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripBookmarks,
            this.MenuStripTools,
            this.MenuStripHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(992, 24);
            this.MenuStrip.TabIndex = 3;
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileMinimizeToTray,
            this.toolStripSeparator2,
            this.MenuFileExit});
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(37, 20);
            this.MenuStripFile.Text = "File";
            // 
            // MenuFileMinimizeToTray
            // 
            this.MenuFileMinimizeToTray.Name = "MenuFileMinimizeToTray";
            this.MenuFileMinimizeToTray.Size = new System.Drawing.Size(180, 22);
            this.MenuFileMinimizeToTray.Text = "Minimize to Tray";
            this.MenuFileMinimizeToTray.Click += new System.EventHandler(this.MenuFileMinimizeToTray_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(180, 22);
            this.MenuFileExit.Text = "Exit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // MenuStripBookmarks
            // 
            this.MenuStripBookmarks.Name = "MenuStripBookmarks";
            this.MenuStripBookmarks.Size = new System.Drawing.Size(76, 20);
            this.MenuStripBookmarks.Text = "Bookmarks";
            this.MenuStripBookmarks.Click += new System.EventHandler(this.MenuStripBookmarks_Click);
            // 
            // MenuStripTools
            // 
            this.MenuStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolsFtpServerList,
            this.MenuToolsSubmitFtpServer,
            this.toolStripSeparator1,
            this.MenuToolsOptions});
            this.MenuStripTools.Name = "MenuStripTools";
            this.MenuStripTools.Size = new System.Drawing.Size(45, 20);
            this.MenuStripTools.Text = "Tools";
            // 
            // MenuToolsFtpServerList
            // 
            this.MenuToolsFtpServerList.Name = "MenuToolsFtpServerList";
            this.MenuToolsFtpServerList.Size = new System.Drawing.Size(180, 22);
            this.MenuToolsFtpServerList.Text = "FTP Servers...";
            this.MenuToolsFtpServerList.Click += new System.EventHandler(this.MenuToolsFtpServerList_Click);
            // 
            // MenuToolsSubmitFtpServer
            // 
            this.MenuToolsSubmitFtpServer.Name = "MenuToolsSubmitFtpServer";
            this.MenuToolsSubmitFtpServer.Size = new System.Drawing.Size(180, 22);
            this.MenuToolsSubmitFtpServer.Text = "Submit FTP Server";
            this.MenuToolsSubmitFtpServer.Click += new System.EventHandler(this.MenuToolsSubmitFtpServer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuToolsOptions
            // 
            this.MenuToolsOptions.Name = "MenuToolsOptions";
            this.MenuToolsOptions.Size = new System.Drawing.Size(180, 22);
            this.MenuToolsOptions.Text = "Options...";
            this.MenuToolsOptions.Click += new System.EventHandler(this.MenuToolsOptions_Click);
            // 
            // MenuStripHelp
            // 
            this.MenuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpKeyboardShortcuts,
            this.MenuStripFileSeperator1,
            this.MenuHelpAbout,
            this.MenuHelpReportIssue});
            this.MenuStripHelp.Name = "MenuStripHelp";
            this.MenuStripHelp.Size = new System.Drawing.Size(43, 20);
            this.MenuStripHelp.Text = "Help";
            // 
            // MenuHelpKeyboardShortcuts
            // 
            this.MenuHelpKeyboardShortcuts.Name = "MenuHelpKeyboardShortcuts";
            this.MenuHelpKeyboardShortcuts.Size = new System.Drawing.Size(180, 22);
            this.MenuHelpKeyboardShortcuts.Text = "Keyboard Shortcuts";
            this.MenuHelpKeyboardShortcuts.Click += new System.EventHandler(this.MenuHelpKeyboardShortcuts_Click);
            // 
            // MenuStripFileSeperator1
            // 
            this.MenuStripFileSeperator1.Name = "MenuStripFileSeperator1";
            this.MenuStripFileSeperator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.MenuHelpAbout.Text = "About FileMasta...";
            this.MenuHelpAbout.Click += new System.EventHandler(this.MenuHelpAbout_Click);
            // 
            // MenuHelpReportIssue
            // 
            this.MenuHelpReportIssue.Name = "MenuHelpReportIssue";
            this.MenuHelpReportIssue.Size = new System.Drawing.Size(180, 22);
            this.MenuHelpReportIssue.Text = "Report Issue...";
            this.MenuHelpReportIssue.Click += new System.EventHandler(this.MenuHelpReportIssue_Click);
            // 
            // PanelSearchControls
            // 
            this.PanelSearchControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.PanelSearchControls.Controls.Add(this.ButtonSearchEngine);
            this.PanelSearchControls.Controls.Add(this.FlowPanelMostSearches);
            this.PanelSearchControls.Controls.Add(this.LabelMostSearches);
            this.PanelSearchControls.Controls.Add(this.ButtonSearchFiles);
            this.PanelSearchControls.Controls.Add(this.LabelHost);
            this.PanelSearchControls.Controls.Add(this.ComboBoxHost);
            this.PanelSearchControls.Controls.Add(this.LabelSort);
            this.PanelSearchControls.Controls.Add(this.ComboBoxSort);
            this.PanelSearchControls.Controls.Add(this.LabelType);
            this.PanelSearchControls.Controls.Add(this.ComboBoxType);
            this.PanelSearchControls.Controls.Add(this.TextBoxSearchQuery);
            this.PanelSearchControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchControls.Location = new System.Drawing.Point(0, 24);
            this.PanelSearchControls.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSearchControls.Name = "PanelSearchControls";
            this.PanelSearchControls.Size = new System.Drawing.Size(992, 146);
            this.PanelSearchControls.TabIndex = 1111;
            // 
            // ButtonSearchEngine
            // 
            this.ButtonSearchEngine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearchEngine.Font = new System.Drawing.Font("Segoe UI", 6.25F);
            this.ButtonSearchEngine.Location = new System.Drawing.Point(964, 9);
            this.ButtonSearchEngine.Name = "ButtonSearchEngine";
            this.ButtonSearchEngine.Size = new System.Drawing.Size(20, 23);
            this.ButtonSearchEngine.TabIndex = 11;
            this.ButtonSearchEngine.Text = "▼";
            this.ButtonSearchEngine.UseVisualStyleBackColor = true;
            this.ButtonSearchEngine.Click += new System.EventHandler(this.ButtonSearchEngine_Click);
            // 
            // FlowPanelMostSearches
            // 
            this.FlowPanelMostSearches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanelMostSearches.BackColor = System.Drawing.Color.Transparent;
            this.FlowPanelMostSearches.Location = new System.Drawing.Point(10, 58);
            this.FlowPanelMostSearches.Name = "FlowPanelMostSearches";
            this.FlowPanelMostSearches.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlowPanelMostSearches.Size = new System.Drawing.Size(970, 78);
            this.FlowPanelMostSearches.TabIndex = 10;
            // 
            // LabelMostSearches
            // 
            this.LabelMostSearches.AutoSize = true;
            this.LabelMostSearches.BackColor = System.Drawing.Color.Transparent;
            this.LabelMostSearches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelMostSearches.Location = new System.Drawing.Point(9, 38);
            this.LabelMostSearches.Margin = new System.Windows.Forms.Padding(0);
            this.LabelMostSearches.Name = "LabelMostSearches";
            this.LabelMostSearches.Size = new System.Drawing.Size(84, 13);
            this.LabelMostSearches.TabIndex = 9;
            this.LabelMostSearches.Text = "Most Searches:";
            // 
            // ButtonSearchFiles
            // 
            this.ButtonSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearchFiles.Location = new System.Drawing.Point(907, 9);
            this.ButtonSearchFiles.Name = "ButtonSearchFiles";
            this.ButtonSearchFiles.Size = new System.Drawing.Size(56, 23);
            this.ButtonSearchFiles.TabIndex = 8;
            this.ButtonSearchFiles.Text = "Search";
            this.ButtonSearchFiles.UseVisualStyleBackColor = true;
            this.ButtonSearchFiles.Click += new System.EventHandler(this.ButtonSearchFiles_Click);
            // 
            // LabelHost
            // 
            this.LabelHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(706, 13);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(34, 13);
            this.LabelHost.TabIndex = 7;
            this.LabelHost.Text = "Host:";
            // 
            // ComboBoxHost
            // 
            this.ComboBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHost.FormattingEnabled = true;
            this.ComboBoxHost.Items.AddRange(new object[] {
            "Any"});
            this.ComboBoxHost.Location = new System.Drawing.Point(746, 10);
            this.ComboBoxHost.Name = "ComboBoxHost";
            this.ComboBoxHost.Size = new System.Drawing.Size(155, 21);
            this.ComboBoxHost.TabIndex = 6;
            this.ComboBoxHost.TabStop = false;
            this.ComboBoxHost.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHost_SelectedIndexChanged);
            // 
            // LabelSort
            // 
            this.LabelSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSort.AutoSize = true;
            this.LabelSort.Location = new System.Drawing.Point(592, 13);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(31, 13);
            this.LabelSort.TabIndex = 5;
            this.LabelSort.Text = "Sort:";
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Age"});
            this.ComboBoxSort.Location = new System.Drawing.Point(629, 10);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(74, 21);
            this.ComboBoxSort.TabIndex = 4;
            this.ComboBoxSort.TabStop = false;
            this.ComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // LabelType
            // 
            this.LabelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(450, 13);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(32, 13);
            this.LabelType.TabIndex = 2;
            this.LabelType.Text = "Type:";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Any",
            "Audio",
            "Compressed",
            "Document",
            "Executable",
            "Picture",
            "Video"});
            this.ComboBoxType.Location = new System.Drawing.Point(488, 10);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(98, 21);
            this.ComboBoxType.TabIndex = 1;
            this.ComboBoxType.TabStop = false;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // StatusStripFooter
            // 
            this.StatusStripFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StatusStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripStatus,
            this.StatusStripSpring,
            this.StatusStripDatabaseInfo});
            this.StatusStripFooter.Location = new System.Drawing.Point(0, 472);
            this.StatusStripFooter.Name = "StatusStripFooter";
            this.StatusStripFooter.Size = new System.Drawing.Size(992, 22);
            this.StatusStripFooter.TabIndex = 1112;
            this.StatusStripFooter.Text = "statusStrip1";
            // 
            // StatusStripStatus
            // 
            this.StatusStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripStatus.Name = "StatusStripStatus";
            this.StatusStripStatus.Size = new System.Drawing.Size(57, 17);
            this.StatusStripStatus.Text = "Waiting...";
            // 
            // StatusStripSpring
            // 
            this.StatusStripSpring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripSpring.Name = "StatusStripSpring";
            this.StatusStripSpring.Size = new System.Drawing.Size(620, 17);
            this.StatusStripSpring.Spring = true;
            // 
            // StatusStripDatabaseInfo
            // 
            this.StatusStripDatabaseInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripDatabaseInfo.Name = "StatusStripDatabaseInfo";
            this.StatusStripDatabaseInfo.Size = new System.Drawing.Size(300, 17);
            this.StatusStripDatabaseInfo.Text = "Files: {0} - Total Size: {1} - FTP Servers {2} - Last Updated: {3}";
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
            // ContextMenuSearchEngine
            // 
            this.ContextMenuSearchEngine.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ContextMenuSearchEngine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearchGoogle,
            this.MenuSearchGoogol,
            this.MenuSearchStartPage,
            this.MenuSearchSearx});
            this.ContextMenuSearchEngine.Name = "contextMenuFileItem";
            this.ContextMenuSearchEngine.Size = new System.Drawing.Size(124, 92);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(992, 494);
            this.Controls.Add(this.DataGridFiles);
            this.Controls.Add(this.StatusStripFooter);
            this.Controls.Add(this.PanelSearchControls);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMasta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiles)).EndInit();
            this.ContextMenuFile.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.PanelSearchControls.ResumeLayout(false);
            this.PanelSearchControls.PerformLayout();
            this.StatusStripFooter.ResumeLayout(false);
            this.StatusStripFooter.PerformLayout();
            this.ContextMenuSearchEngine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearchQuery;
        public System.Windows.Forms.DataGridView DataGridFiles;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTools;
        private System.Windows.Forms.ToolStripMenuItem MenuStripHelp;
        private System.Windows.Forms.Panel PanelSearchControls;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.ComboBox ComboBoxHost;
        private System.Windows.Forms.Label LabelSort;
        private System.Windows.Forms.ComboBox ComboBoxSort;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.StatusStrip StatusStripFooter;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripDatabaseInfo;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelMostSearches;
        internal System.Windows.Forms.Label LabelMostSearches;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripSpring;
        private System.Windows.Forms.ToolStripMenuItem MenuToolsFtpServerList;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuToolsSubmitFtpServer;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpKeyboardShortcuts;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpReportIssue;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeperator1;
        private System.Windows.Forms.ToolStripMenuItem MenuFileViewDetails;
        private System.Windows.Forms.ToolStripMenuItem MenuFileViewWebPage;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeperator2;
        private System.Windows.Forms.ToolStripMenuItem MenuFileCopyURL;
        public System.Windows.Forms.Button ButtonSearchFiles;
        private System.Windows.Forms.ToolStripMenuItem MenuStripBookmarks;
        private System.Windows.Forms.ToolStripMenuItem MenuFileMinimizeToTray;
        private System.Windows.Forms.NotifyIcon NotifyTrayIcon;
        private System.Windows.Forms.ToolStripSeparator MenuStripFileSeperator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilesURL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolsOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.Button ButtonSearchEngine;
        private System.Windows.Forms.ContextMenuStrip ContextMenuSearchEngine;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchGoogle;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchGoogol;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchStartPage;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchSearx;
    }
}

