namespace FileMasta.Windows
{
    partial class BookmarksWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarksWindow));
            this.DataGridFiles = new System.Windows.Forms.DataGridView();
            this.PanelSearchControls = new System.Windows.Forms.Panel();
            this.ButtonSearchFiles = new System.Windows.Forms.Button();
            this.LabelHost = new System.Windows.Forms.Label();
            this.ComboBoxHost = new System.Windows.Forms.ComboBox();
            this.LabelSort = new System.Windows.Forms.Label();
            this.ComboBoxSort = new System.Windows.Forms.ComboBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.TextBoxSearchQuery = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.PanelBookmarkControls = new System.Windows.Forms.Panel();
            this.ButtonViewDetails = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ButtonRemoveFile = new System.Windows.Forms.Button();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.labelNoResultsFound = new System.Windows.Forms.Label();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileReferrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiles)).BeginInit();
            this.PanelSearchControls.SuspendLayout();
            this.PanelBookmarkControls.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ColumnFileURL});
            this.DataGridFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridFiles.EnableHeadersVisualStyles = false;
            this.DataGridFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.Location = new System.Drawing.Point(0, 43);
            this.DataGridFiles.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridFiles.MultiSelect = false;
            this.DataGridFiles.Name = "DataGridFiles";
            this.DataGridFiles.ReadOnly = true;
            this.DataGridFiles.RowHeadersVisible = false;
            this.DataGridFiles.RowHeadersWidth = 40;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridFiles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
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
            this.DataGridFiles.Size = new System.Drawing.Size(847, 388);
            this.DataGridFiles.TabIndex = 15;
            this.DataGridFiles.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridFiles_RowPrePaint);
            this.DataGridFiles.SelectionChanged += new System.EventHandler(this.DataGridFiles_SelectionChanged);
            // 
            // PanelSearchControls
            // 
            this.PanelSearchControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.PanelSearchControls.Controls.Add(this.ButtonSearchFiles);
            this.PanelSearchControls.Controls.Add(this.LabelHost);
            this.PanelSearchControls.Controls.Add(this.ComboBoxHost);
            this.PanelSearchControls.Controls.Add(this.LabelSort);
            this.PanelSearchControls.Controls.Add(this.ComboBoxSort);
            this.PanelSearchControls.Controls.Add(this.LabelType);
            this.PanelSearchControls.Controls.Add(this.ComboBoxType);
            this.PanelSearchControls.Controls.Add(this.TextBoxSearchQuery);
            this.PanelSearchControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchControls.Location = new System.Drawing.Point(0, 0);
            this.PanelSearchControls.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSearchControls.Name = "PanelSearchControls";
            this.PanelSearchControls.Size = new System.Drawing.Size(847, 43);
            this.PanelSearchControls.TabIndex = 1112;
            // 
            // ButtonSearchFiles
            // 
            this.ButtonSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearchFiles.Location = new System.Drawing.Point(782, 9);
            this.ButtonSearchFiles.Name = "ButtonSearchFiles";
            this.ButtonSearchFiles.Size = new System.Drawing.Size(54, 23);
            this.ButtonSearchFiles.TabIndex = 4;
            this.ButtonSearchFiles.Text = "Search";
            this.ButtonSearchFiles.UseVisualStyleBackColor = true;
            this.ButtonSearchFiles.Click += new System.EventHandler(this.ButtonSearchFiles_Click);
            // 
            // LabelHost
            // 
            this.LabelHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(581, 13);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(34, 13);
            this.LabelHost.TabIndex = 7;
            this.LabelHost.Text = "Host:";
            // 
            // ComboBoxHost
            // 
            this.ComboBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHost.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ComboBoxHost.FormattingEnabled = true;
            this.ComboBoxHost.Items.AddRange(new object[] {
            "Any"});
            this.ComboBoxHost.Location = new System.Drawing.Point(621, 10);
            this.ComboBoxHost.Name = "ComboBoxHost";
            this.ComboBoxHost.Size = new System.Drawing.Size(155, 21);
            this.ComboBoxHost.TabIndex = 3;
            this.ComboBoxHost.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHost_SelectedIndexChanged);
            // 
            // LabelSort
            // 
            this.LabelSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSort.AutoSize = true;
            this.LabelSort.Location = new System.Drawing.Point(467, 13);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(31, 13);
            this.LabelSort.TabIndex = 5;
            this.LabelSort.Text = "Sort:";
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSort.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Date"});
            this.ComboBoxSort.Location = new System.Drawing.Point(504, 10);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(74, 21);
            this.ComboBoxSort.TabIndex = 2;
            this.ComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // LabelType
            // 
            this.LabelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(325, 13);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(32, 13);
            this.LabelType.TabIndex = 2;
            this.LabelType.Text = "Type:";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Any",
            "Audio",
            "Compressed",
            "Document",
            "Executable",
            "Picture",
            "Video"});
            this.ComboBoxType.Location = new System.Drawing.Point(363, 10);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(98, 21);
            this.ComboBoxType.TabIndex = 1;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // TextBoxSearchQuery
            // 
            this.TextBoxSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearchQuery.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxSearchQuery.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearchQuery.Location = new System.Drawing.Point(12, 10);
            this.TextBoxSearchQuery.Name = "TextBoxSearchQuery";
            this.TextBoxSearchQuery.Size = new System.Drawing.Size(307, 22);
            this.TextBoxSearchQuery.TabIndex = 0;
            this.TextBoxSearchQuery.WaterMark = "Search your bookmarks...";
            this.TextBoxSearchQuery.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.TextBoxSearchQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextBoxSearchQuery.WaterMarkForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxSearchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchQuery_KeyDown);
            // 
            // PanelBookmarkControls
            // 
            this.PanelBookmarkControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.PanelBookmarkControls.Controls.Add(this.ButtonViewDetails);
            this.PanelBookmarkControls.Controls.Add(this.LabelStatus);
            this.PanelBookmarkControls.Controls.Add(this.ButtonRemoveFile);
            this.PanelBookmarkControls.Controls.Add(this.ButtonClearAll);
            this.PanelBookmarkControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBookmarkControls.Location = new System.Drawing.Point(0, 431);
            this.PanelBookmarkControls.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBookmarkControls.Name = "PanelBookmarkControls";
            this.PanelBookmarkControls.Size = new System.Drawing.Size(847, 43);
            this.PanelBookmarkControls.TabIndex = 1113;
            // 
            // ButtonViewDetails
            // 
            this.ButtonViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonViewDetails.Enabled = false;
            this.ButtonViewDetails.Location = new System.Drawing.Point(608, 9);
            this.ButtonViewDetails.Name = "ButtonViewDetails";
            this.ButtonViewDetails.Size = new System.Drawing.Size(88, 23);
            this.ButtonViewDetails.TabIndex = 1115;
            this.ButtonViewDetails.Text = "View Details";
            this.ButtonViewDetails.UseVisualStyleBackColor = true;
            this.ButtonViewDetails.Click += new System.EventHandler(this.ButtonViewDetails_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(12, 19);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(118, 13);
            this.LabelStatus.TabIndex = 1114;
            this.LabelStatus.Text = "Loading bookmarks...";
            // 
            // ButtonRemoveFile
            // 
            this.ButtonRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemoveFile.Enabled = false;
            this.ButtonRemoveFile.Location = new System.Drawing.Point(702, 9);
            this.ButtonRemoveFile.Name = "ButtonRemoveFile";
            this.ButtonRemoveFile.Size = new System.Drawing.Size(83, 23);
            this.ButtonRemoveFile.TabIndex = 5;
            this.ButtonRemoveFile.Text = "Remove File";
            this.ButtonRemoveFile.UseVisualStyleBackColor = true;
            this.ButtonRemoveFile.Click += new System.EventHandler(this.ButtonRemoveFile_Click);
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearAll.Location = new System.Drawing.Point(791, 9);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(45, 23);
            this.ButtonClearAll.TabIndex = 6;
            this.ButtonClearAll.Text = "Clear";
            this.ButtonClearAll.UseVisualStyleBackColor = true;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // labelNoResultsFound
            // 
            this.labelNoResultsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNoResultsFound.AutoSize = true;
            this.labelNoResultsFound.BackColor = System.Drawing.SystemColors.Control;
            this.labelNoResultsFound.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelNoResultsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNoResultsFound.Location = new System.Drawing.Point(373, 139);
            this.labelNoResultsFound.Name = "labelNoResultsFound";
            this.labelNoResultsFound.Size = new System.Drawing.Size(100, 15);
            this.labelNoResultsFound.TabIndex = 1116;
            this.labelNoResultsFound.Text = "No Results Found";
            this.labelNoResultsFound.Visible = false;
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
            this.ColumnFileAge.Width = 80;
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
            // ColumnFileURL
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ColumnFileURL.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnFileURL.HeaderText = "URL";
            this.ColumnFileURL.Name = "ColumnFileURL";
            this.ColumnFileURL.ReadOnly = true;
            this.ColumnFileURL.Visible = false;
            // 
            // BookmarksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 474);
            this.Controls.Add(this.labelNoResultsFound);
            this.Controls.Add(this.DataGridFiles);
            this.Controls.Add(this.PanelBookmarkControls);
            this.Controls.Add(this.PanelSearchControls);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookmarksWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.BookmarksWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiles)).EndInit();
            this.PanelSearchControls.ResumeLayout(false);
            this.PanelSearchControls.PerformLayout();
            this.PanelBookmarkControls.ResumeLayout(false);
            this.PanelBookmarkControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridFiles;
        private System.Windows.Forms.Panel PanelSearchControls;
        public System.Windows.Forms.Button ButtonSearchFiles;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.ComboBox ComboBoxHost;
        private System.Windows.Forms.Label LabelSort;
        private System.Windows.Forms.ComboBox ComboBoxSort;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.ComboBox ComboBoxType;
        public ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearchQuery;
        private System.Windows.Forms.Panel PanelBookmarkControls;
        public System.Windows.Forms.Button ButtonRemoveFile;
        public System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.Label LabelStatus;
        public System.Windows.Forms.Label labelNoResultsFound;
        public System.Windows.Forms.Button ButtonViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileReferrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileURL;
    }
}