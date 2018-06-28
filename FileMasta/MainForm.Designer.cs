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
            this.textBoxSearchQuery = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.columnFilesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesReferrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilesURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuFileItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewFileDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWebPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileURLClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.menuStripToolsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileBookmarks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsFtpServerList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsSubmitFtpServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpKeyboardShortcuts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpTermsOfUse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpPrivacyPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSearchControls = new System.Windows.Forms.Panel();
            this.flowPanelMostSearches = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMostSearches = new System.Windows.Forms.Label();
            this.buttonSearchFiles = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.statusStripFooter = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSPRING = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDatabaseInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNoResultsFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.contextMenuFileItem.SuspendLayout();
            this.menuStripHeader.SuspendLayout();
            this.panelSearchControls.SuspendLayout();
            this.statusStripFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearchQuery
            // 
            this.textBoxSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchQuery.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchQuery.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchQuery.Location = new System.Drawing.Point(12, 10);
            this.textBoxSearchQuery.Name = "textBoxSearchQuery";
            this.textBoxSearchQuery.Size = new System.Drawing.Size(508, 22);
            this.textBoxSearchQuery.TabIndex = 0;
            this.textBoxSearchQuery.WaterMark = "Search for file names, add tags or insert a link...";
            this.textBoxSearchQuery.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxSearchQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxSearchQuery.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchQuery_KeyDown);
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.AllowUserToAddRows = false;
            this.dataGridFiles.AllowUserToDeleteRows = false;
            this.dataGridFiles.AllowUserToResizeColumns = false;
            this.dataGridFiles.AllowUserToResizeRows = false;
            this.dataGridFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.dataGridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
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
            this.dataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFiles.EnableHeadersVisualStyles = false;
            this.dataGridFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.dataGridFiles.Location = new System.Drawing.Point(0, 170);
            this.dataGridFiles.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridFiles.MultiSelect = false;
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            this.dataGridFiles.RowHeadersVisible = false;
            this.dataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridFiles.RowTemplate.ContextMenuStrip = this.contextMenuFileItem;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowTemplate.ErrorText = "Can\'t load info";
            this.dataGridFiles.RowTemplate.Height = 24;
            this.dataGridFiles.RowTemplate.ReadOnly = true;
            this.dataGridFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFiles.ShowCellErrors = false;
            this.dataGridFiles.ShowEditingIcon = false;
            this.dataGridFiles.ShowRowErrors = false;
            this.dataGridFiles.Size = new System.Drawing.Size(1048, 449);
            this.dataGridFiles.TabIndex = 14;
            this.dataGridFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFiles_CellClick);
            // 
            // columnFilesType
            // 
            this.columnFilesType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnFilesType.HeaderText = "Type";
            this.columnFilesType.Name = "columnFilesType";
            this.columnFilesType.ReadOnly = true;
            this.columnFilesType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesType.Width = 56;
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
            this.columnFilesSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesSize.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnFilesSize.HeaderText = "Size";
            this.columnFilesSize.Name = "columnFilesSize";
            this.columnFilesSize.ReadOnly = true;
            this.columnFilesSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesSize.Width = 105;
            // 
            // columnFilesAge
            // 
            this.columnFilesAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesAge.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnFilesAge.HeaderText = "Age";
            this.columnFilesAge.Name = "columnFilesAge";
            this.columnFilesAge.ReadOnly = true;
            this.columnFilesAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesAge.Width = 84;
            // 
            // columnFilesReferrer
            // 
            this.columnFilesReferrer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.columnFilesReferrer.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnFilesReferrer.HeaderText = "Referrer";
            this.columnFilesReferrer.Name = "columnFilesReferrer";
            this.columnFilesReferrer.ReadOnly = true;
            this.columnFilesReferrer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesReferrer.Width = 165;
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
            // contextMenuFileItem
            // 
            this.contextMenuFileItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewFileDetailsToolStripMenuItem,
            this.viewWebPageToolStripMenuItem,
            this.toolStripSeparator2,
            this.fileURLClipboardToolStripMenuItem});
            this.contextMenuFileItem.Name = "contextMenuFileItem";
            this.contextMenuFileItem.Size = new System.Drawing.Size(183, 104);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // viewFileDetailsToolStripMenuItem
            // 
            this.viewFileDetailsToolStripMenuItem.Name = "viewFileDetailsToolStripMenuItem";
            this.viewFileDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewFileDetailsToolStripMenuItem.Text = "View File Details...";
            this.viewFileDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewFileDetailsToolStripMenuItem_Click);
            // 
            // viewWebPageToolStripMenuItem
            // 
            this.viewWebPageToolStripMenuItem.Name = "viewWebPageToolStripMenuItem";
            this.viewWebPageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewWebPageToolStripMenuItem.Text = "View Web Page...";
            this.viewWebPageToolStripMenuItem.Click += new System.EventHandler(this.viewWebPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // fileURLClipboardToolStripMenuItem
            // 
            this.fileURLClipboardToolStripMenuItem.Name = "fileURLClipboardToolStripMenuItem";
            this.fileURLClipboardToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fileURLClipboardToolStripMenuItem.Text = "File URL > Clipboard";
            this.fileURLClipboardToolStripMenuItem.Click += new System.EventHandler(this.fileURLClipboardToolStripMenuItem_Click);
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripToolsFile,
            this.menuFileBookmarks,
            this.menuStripTools,
            this.menuStripToolsOptions,
            this.menuHelp});
            this.menuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.Size = new System.Drawing.Size(1048, 24);
            this.menuStripHeader.TabIndex = 3;
            this.menuStripHeader.Text = "menuStrip1";
            // 
            // menuStripToolsFile
            // 
            this.menuStripToolsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuStripToolsFile.Name = "menuStripToolsFile";
            this.menuStripToolsFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripToolsFile.Text = "File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(92, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuFileBookmarks
            // 
            this.menuFileBookmarks.Name = "menuFileBookmarks";
            this.menuFileBookmarks.Size = new System.Drawing.Size(78, 20);
            this.menuFileBookmarks.Text = "Bookmarks";
            this.menuFileBookmarks.Click += new System.EventHandler(this.menuFileBookmarks_Click);
            // 
            // menuStripTools
            // 
            this.menuStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsFtpServerList,
            this.menuToolsSubmitFtpServer});
            this.menuStripTools.Name = "menuStripTools";
            this.menuStripTools.Size = new System.Drawing.Size(47, 20);
            this.menuStripTools.Text = "Tools";
            // 
            // menuToolsFtpServerList
            // 
            this.menuToolsFtpServerList.Name = "menuToolsFtpServerList";
            this.menuToolsFtpServerList.Size = new System.Drawing.Size(170, 22);
            this.menuToolsFtpServerList.Text = "FTP Server List";
            this.menuToolsFtpServerList.Click += new System.EventHandler(this.menuToolsWebServerList_Click);
            // 
            // menuToolsSubmitFtpServer
            // 
            this.menuToolsSubmitFtpServer.Name = "menuToolsSubmitFtpServer";
            this.menuToolsSubmitFtpServer.Size = new System.Drawing.Size(170, 22);
            this.menuToolsSubmitFtpServer.Text = "Submit FTP Server";
            this.menuToolsSubmitFtpServer.Click += new System.EventHandler(this.menuToolsSubmitWebsite_Click);
            // 
            // menuStripToolsOptions
            // 
            this.menuStripToolsOptions.Name = "menuStripToolsOptions";
            this.menuStripToolsOptions.Size = new System.Drawing.Size(61, 20);
            this.menuStripToolsOptions.Text = "Options";
            this.menuStripToolsOptions.Click += new System.EventHandler(this.menuStripToolsOptions_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout,
            this.menuHelpReportIssue,
            this.menuHelpKeyboardShortcuts,
            this.menuHelpTermsOfUse,
            this.menuHelpPrivacyPolicy,
            this.menuHelpChangeLog});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(177, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuHelpReportIssue
            // 
            this.menuHelpReportIssue.Name = "menuHelpReportIssue";
            this.menuHelpReportIssue.Size = new System.Drawing.Size(177, 22);
            this.menuHelpReportIssue.Text = "Report Issue";
            this.menuHelpReportIssue.Click += new System.EventHandler(this.reportIssueToolStripMenuItem_Click);
            // 
            // menuHelpKeyboardShortcuts
            // 
            this.menuHelpKeyboardShortcuts.Name = "menuHelpKeyboardShortcuts";
            this.menuHelpKeyboardShortcuts.Size = new System.Drawing.Size(177, 22);
            this.menuHelpKeyboardShortcuts.Text = "Keyboard Shortcuts";
            this.menuHelpKeyboardShortcuts.Click += new System.EventHandler(this.keyboardShortcutsToolStripMenuItem_Click);
            // 
            // menuHelpTermsOfUse
            // 
            this.menuHelpTermsOfUse.Name = "menuHelpTermsOfUse";
            this.menuHelpTermsOfUse.Size = new System.Drawing.Size(177, 22);
            this.menuHelpTermsOfUse.Text = "Terms of Use";
            this.menuHelpTermsOfUse.Click += new System.EventHandler(this.termsOfUseToolStripMenuItem_Click);
            // 
            // menuHelpPrivacyPolicy
            // 
            this.menuHelpPrivacyPolicy.Name = "menuHelpPrivacyPolicy";
            this.menuHelpPrivacyPolicy.Size = new System.Drawing.Size(177, 22);
            this.menuHelpPrivacyPolicy.Text = "Privacy Policy";
            this.menuHelpPrivacyPolicy.Click += new System.EventHandler(this.privacyPolicyToolStripMenuItem_Click);
            // 
            // menuHelpChangeLog
            // 
            this.menuHelpChangeLog.Name = "menuHelpChangeLog";
            this.menuHelpChangeLog.Size = new System.Drawing.Size(177, 22);
            this.menuHelpChangeLog.Text = "Change Log - {0}";
            this.menuHelpChangeLog.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // panelSearchControls
            // 
            this.panelSearchControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.panelSearchControls.Controls.Add(this.flowPanelMostSearches);
            this.panelSearchControls.Controls.Add(this.labelMostSearches);
            this.panelSearchControls.Controls.Add(this.buttonSearchFiles);
            this.panelSearchControls.Controls.Add(this.labelHost);
            this.panelSearchControls.Controls.Add(this.comboBoxHost);
            this.panelSearchControls.Controls.Add(this.labelSort);
            this.panelSearchControls.Controls.Add(this.comboBoxSort);
            this.panelSearchControls.Controls.Add(this.labelType);
            this.panelSearchControls.Controls.Add(this.comboBoxType);
            this.panelSearchControls.Controls.Add(this.textBoxSearchQuery);
            this.panelSearchControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchControls.Location = new System.Drawing.Point(0, 24);
            this.panelSearchControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelSearchControls.Name = "panelSearchControls";
            this.panelSearchControls.Size = new System.Drawing.Size(1048, 146);
            this.panelSearchControls.TabIndex = 1111;
            // 
            // flowPanelMostSearches
            // 
            this.flowPanelMostSearches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelMostSearches.BackColor = System.Drawing.Color.Transparent;
            this.flowPanelMostSearches.Location = new System.Drawing.Point(10, 58);
            this.flowPanelMostSearches.Name = "flowPanelMostSearches";
            this.flowPanelMostSearches.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowPanelMostSearches.Size = new System.Drawing.Size(1026, 78);
            this.flowPanelMostSearches.TabIndex = 10;
            // 
            // labelMostSearches
            // 
            this.labelMostSearches.AutoSize = true;
            this.labelMostSearches.BackColor = System.Drawing.Color.Transparent;
            this.labelMostSearches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMostSearches.Location = new System.Drawing.Point(9, 40);
            this.labelMostSearches.Margin = new System.Windows.Forms.Padding(0);
            this.labelMostSearches.Name = "labelMostSearches";
            this.labelMostSearches.Size = new System.Drawing.Size(84, 13);
            this.labelMostSearches.TabIndex = 9;
            this.labelMostSearches.Text = "Most Searches:";
            // 
            // buttonSearchFiles
            // 
            this.buttonSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchFiles.Location = new System.Drawing.Point(983, 9);
            this.buttonSearchFiles.Name = "buttonSearchFiles";
            this.buttonSearchFiles.Size = new System.Drawing.Size(54, 23);
            this.buttonSearchFiles.TabIndex = 8;
            this.buttonSearchFiles.Text = "Search";
            this.buttonSearchFiles.UseVisualStyleBackColor = true;
            this.buttonSearchFiles.Click += new System.EventHandler(this.buttonSearchFiles_Click);
            // 
            // labelHost
            // 
            this.labelHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(782, 13);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(34, 13);
            this.labelHost.TabIndex = 7;
            this.labelHost.Text = "Host:";
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHost.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Items.AddRange(new object[] {
            "Any"});
            this.comboBoxHost.Location = new System.Drawing.Point(822, 10);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(155, 21);
            this.comboBoxHost.TabIndex = 6;
            this.comboBoxHost.TabStop = false;
            this.comboBoxHost.SelectedIndexChanged += new System.EventHandler(this.comboBoxHost_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(668, 13);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(31, 13);
            this.labelSort.TabIndex = 5;
            this.labelSort.Text = "Sort:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Date"});
            this.comboBoxSort.Location = new System.Drawing.Point(705, 10);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(74, 21);
            this.comboBoxSort.TabIndex = 4;
            this.comboBoxSort.TabStop = false;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(526, 13);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(32, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Any",
            "Video",
            "Audio",
            "Image",
            "eBook",
            "Software",
            "Torrent",
            "Subtitle",
            "Other"});
            this.comboBoxType.Location = new System.Drawing.Point(564, 10);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(98, 21);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.TabStop = false;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // statusStripFooter
            // 
            this.statusStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripSPRING,
            this.toolStripDatabaseInfo});
            this.statusStripFooter.Location = new System.Drawing.Point(0, 619);
            this.statusStripFooter.Name = "statusStripFooter";
            this.statusStripFooter.Size = new System.Drawing.Size(1048, 22);
            this.statusStripFooter.TabIndex = 1112;
            this.statusStripFooter.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatus.Text = "Waiting...";
            // 
            // toolStripSPRING
            // 
            this.toolStripSPRING.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSPRING.Name = "toolStripSPRING";
            this.toolStripSPRING.Size = new System.Drawing.Size(654, 17);
            this.toolStripSPRING.Spring = true;
            // 
            // toolStripDatabaseInfo
            // 
            this.toolStripDatabaseInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDatabaseInfo.Name = "toolStripDatabaseInfo";
            this.toolStripDatabaseInfo.Size = new System.Drawing.Size(322, 17);
            this.toolStripDatabaseInfo.Text = "Files: {0} - Total Size: {1} - Web Servers {2} - Last Updated: {3}";
            // 
            // labelNoResultsFound
            // 
            this.labelNoResultsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNoResultsFound.AutoSize = true;
            this.labelNoResultsFound.BackColor = System.Drawing.SystemColors.Control;
            this.labelNoResultsFound.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoResultsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNoResultsFound.Location = new System.Drawing.Point(474, 279);
            this.labelNoResultsFound.Name = "labelNoResultsFound";
            this.labelNoResultsFound.Size = new System.Drawing.Size(100, 15);
            this.labelNoResultsFound.TabIndex = 1115;
            this.labelNoResultsFound.Text = "No Results Found";
            this.labelNoResultsFound.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1048, 641);
            this.Controls.Add(this.labelNoResultsFound);
            this.Controls.Add(this.dataGridFiles);
            this.Controls.Add(this.statusStripFooter);
            this.Controls.Add(this.panelSearchControls);
            this.Controls.Add(this.menuStripHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripHeader;
            this.MinimumSize = new System.Drawing.Size(1025, 625);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMasta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.contextMenuFileItem.ResumeLayout(false);
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            this.panelSearchControls.ResumeLayout(false);
            this.panelSearchControls.PerformLayout();
            this.statusStripFooter.ResumeLayout(false);
            this.statusStripFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxSearchQuery;
        public System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsOptions;
        private System.Windows.Forms.ToolStripMenuItem menuStripTools;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Panel panelSearchControls;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.ComboBox comboBoxHost;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.StatusStrip statusStripFooter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDatabaseInfo;
        private System.Windows.Forms.FlowLayoutPanel flowPanelMostSearches;
        internal System.Windows.Forms.Label labelMostSearches;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSPRING;
        private System.Windows.Forms.ToolStripMenuItem menuToolsFtpServerList;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuToolsSubmitFtpServer;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuHelpChangeLog;
        private System.Windows.Forms.ToolStripMenuItem menuHelpTermsOfUse;
        private System.Windows.Forms.ToolStripMenuItem menuHelpPrivacyPolicy;
        private System.Windows.Forms.ToolStripMenuItem menuHelpKeyboardShortcuts;
        private System.Windows.Forms.ToolStripMenuItem menuHelpReportIssue;
        private System.Windows.Forms.ContextMenuStrip contextMenuFileItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewFileDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWebPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileURLClipboardToolStripMenuItem;
        public System.Windows.Forms.Label labelNoResultsFound;
        public System.Windows.Forms.Button buttonSearchFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesURL;
        private System.Windows.Forms.ToolStripMenuItem menuFileBookmarks;
    }
}

