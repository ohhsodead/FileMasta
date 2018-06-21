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
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.menuStripToolsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsWebServerList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsSubmitWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripToolsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termsOfUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privacyPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripAgeDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSPRING = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFilesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTotalFileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTotalWebServers = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
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
            this.textBoxSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchFiles_KeyDown);
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.AllowUserToAddRows = false;
            this.dataGridFiles.AllowUserToDeleteRows = false;
            this.dataGridFiles.AllowUserToResizeColumns = false;
            this.dataGridFiles.AllowUserToResizeRows = false;
            this.dataGridFiles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
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
            this.dataGridFiles.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridFiles.Location = new System.Drawing.Point(0, 170);
            this.dataGridFiles.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridFiles.MultiSelect = false;
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            this.dataGridFiles.RowHeadersVisible = false;
            this.dataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFiles.RowTemplate.Height = 30;
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
            this.columnFilesType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnFilesType.HeaderText = "Type";
            this.columnFilesType.Name = "columnFilesType";
            this.columnFilesType.ReadOnly = true;
            this.columnFilesType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFilesType.Width = 43;
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
            this.columnFilesSize.Width = 41;
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
            this.columnFilesAge.Width = 41;
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
            this.columnFilesReferrer.Width = 62;
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
            // menuStripHeader
            // 
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripToolsFile,
            this.menuStripTools,
            this.menuStripToolsOptions,
            this.menuStripToolsAbout});
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
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuStripTools
            // 
            this.menuStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsWebServerList,
            this.menuToolsSubmitWebsite});
            this.menuStripTools.Name = "menuStripTools";
            this.menuStripTools.Size = new System.Drawing.Size(47, 20);
            this.menuStripTools.Text = "Tools";
            // 
            // menuToolsWebServerList
            // 
            this.menuToolsWebServerList.Name = "menuToolsWebServerList";
            this.menuToolsWebServerList.Size = new System.Drawing.Size(180, 22);
            this.menuToolsWebServerList.Text = "Web Server List";
            this.menuToolsWebServerList.Click += new System.EventHandler(this.menuToolsWebServerList_Click);
            // 
            // menuToolsSubmitWebsite
            // 
            this.menuToolsSubmitWebsite.Name = "menuToolsSubmitWebsite";
            this.menuToolsSubmitWebsite.Size = new System.Drawing.Size(180, 22);
            this.menuToolsSubmitWebsite.Text = "Submit Website";
            this.menuToolsSubmitWebsite.Click += new System.EventHandler(this.menuToolsSubmitWebsite_Click);
            // 
            // menuStripToolsOptions
            // 
            this.menuStripToolsOptions.Name = "menuStripToolsOptions";
            this.menuStripToolsOptions.Size = new System.Drawing.Size(61, 20);
            this.menuStripToolsOptions.Text = "Options";
            this.menuStripToolsOptions.Click += new System.EventHandler(this.menuStripToolsOptions_Click);
            // 
            // menuStripToolsAbout
            // 
            this.menuStripToolsAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.reportIssueToolStripMenuItem,
            this.keyboardShortcutsToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.termsOfUseToolStripMenuItem,
            this.privacyPolicyToolStripMenuItem});
            this.menuStripToolsAbout.Name = "menuStripToolsAbout";
            this.menuStripToolsAbout.Size = new System.Drawing.Size(44, 20);
            this.menuStripToolsAbout.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
            this.reportIssueToolStripMenuItem.Click += new System.EventHandler(this.reportIssueToolStripMenuItem_Click);
            // 
            // keyboardShortcutsToolStripMenuItem
            // 
            this.keyboardShortcutsToolStripMenuItem.Name = "keyboardShortcutsToolStripMenuItem";
            this.keyboardShortcutsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keyboardShortcutsToolStripMenuItem.Text = "Keyboard Shortcuts";
            this.keyboardShortcutsToolStripMenuItem.Click += new System.EventHandler(this.keyboardShortcutsToolStripMenuItem_Click);
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeLogToolStripMenuItem.Text = "Change Log";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // termsOfUseToolStripMenuItem
            // 
            this.termsOfUseToolStripMenuItem.Name = "termsOfUseToolStripMenuItem";
            this.termsOfUseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.termsOfUseToolStripMenuItem.Text = "Terms of Use";
            this.termsOfUseToolStripMenuItem.Click += new System.EventHandler(this.termsOfUseToolStripMenuItem_Click);
            // 
            // privacyPolicyToolStripMenuItem
            // 
            this.privacyPolicyToolStripMenuItem.Name = "privacyPolicyToolStripMenuItem";
            this.privacyPolicyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.privacyPolicyToolStripMenuItem.Text = "Privacy Policy";
            this.privacyPolicyToolStripMenuItem.Click += new System.EventHandler(this.privacyPolicyToolStripMenuItem_Click);
            // 
            // panelSearchControls
            // 
            this.panelSearchControls.BackColor = System.Drawing.SystemColors.Window;
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
            this.flowPanelMostSearches.Size = new System.Drawing.Size(1026, 75);
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
            this.buttonSearchFiles.Location = new System.Drawing.Point(524, 9);
            this.buttonSearchFiles.Name = "buttonSearchFiles";
            this.buttonSearchFiles.Size = new System.Drawing.Size(54, 24);
            this.buttonSearchFiles.TabIndex = 8;
            this.buttonSearchFiles.Text = "Search";
            this.buttonSearchFiles.UseVisualStyleBackColor = true;
            this.buttonSearchFiles.Click += new System.EventHandler(this.buttonSearchFiles_Click);
            // 
            // labelHost
            // 
            this.labelHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(841, 13);
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
            this.comboBoxHost.Location = new System.Drawing.Point(881, 10);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(155, 21);
            this.comboBoxHost.TabIndex = 6;
            this.comboBoxHost.TabStop = false;
            // 
            // labelSort
            // 
            this.labelSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(727, 13);
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
            this.comboBoxSort.Location = new System.Drawing.Point(764, 10);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(74, 21);
            this.comboBoxSort.TabIndex = 4;
            this.comboBoxSort.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(585, 13);
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
            this.comboBoxType.Location = new System.Drawing.Point(623, 10);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(98, 21);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.TabStop = false;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // statusStripFooter
            // 
            this.statusStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgeDB,
            this.toolStripSPRING,
            this.toolStripFilesCount,
            this.toolStripTotalFileSize,
            this.toolStripTotalWebServers});
            this.statusStripFooter.Location = new System.Drawing.Point(0, 619);
            this.statusStripFooter.Name = "statusStripFooter";
            this.statusStripFooter.Size = new System.Drawing.Size(1048, 22);
            this.statusStripFooter.TabIndex = 1112;
            this.statusStripFooter.Text = "statusStrip1";
            // 
            // toolStripAgeDB
            // 
            this.toolStripAgeDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAgeDB.Name = "toolStripAgeDB";
            this.toolStripAgeDB.Size = new System.Drawing.Size(113, 17);
            this.toolStripAgeDB.Text = "Age of Database: {0}";
            // 
            // toolStripSPRING
            // 
            this.toolStripSPRING.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSPRING.Name = "toolStripSPRING";
            this.toolStripSPRING.Size = new System.Drawing.Size(653, 17);
            this.toolStripSPRING.Spring = true;
            // 
            // toolStripFilesCount
            // 
            this.toolStripFilesCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFilesCount.Name = "toolStripFilesCount";
            this.toolStripFilesCount.Size = new System.Drawing.Size(79, 17);
            this.toolStripFilesCount.Text = "Total Files: {0}";
            // 
            // toolStripTotalFileSize
            // 
            this.toolStripTotalFileSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTotalFileSize.Name = "toolStripTotalFileSize";
            this.toolStripTotalFileSize.Size = new System.Drawing.Size(97, 17);
            this.toolStripTotalFileSize.Text = "Total File Size: {0}";
            // 
            // toolStripTotalWebServers
            // 
            this.toolStripTotalWebServers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTotalWebServers.Name = "toolStripTotalWebServers";
            this.toolStripTotalWebServers.Size = new System.Drawing.Size(91, 17);
            this.toolStripTotalWebServers.Text = "Web Servers: {0}";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1048, 641);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilesURL;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsOptions;
        private System.Windows.Forms.ToolStripMenuItem menuStripTools;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsAbout;
        private System.Windows.Forms.Panel panelSearchControls;
        private System.Windows.Forms.Button buttonSearchFiles;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.ComboBox comboBoxHost;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.StatusStrip statusStripFooter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAgeDB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFilesCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTotalFileSize;
        private System.Windows.Forms.FlowLayoutPanel flowPanelMostSearches;
        internal System.Windows.Forms.Label labelMostSearches;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSPRING;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTotalWebServers;
        private System.Windows.Forms.ToolStripMenuItem menuToolsWebServerList;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuToolsSubmitWebsite;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termsOfUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privacyPolicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyboardShortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportIssueToolStripMenuItem;
    }
}

