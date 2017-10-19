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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenPlex));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.txtSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btnTag5 = new CButtonLib.CButton();
            this.btnTag4 = new CButtonLib.CButton();
            this.btnTag3 = new CButtonLib.CButton();
            this.btnTag2 = new CButtonLib.CButton();
            this.btnTag1 = new CButtonLib.CButton();
            this.lblAddTags = new System.Windows.Forms.Label();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.imgSettings = new System.Windows.Forms.PictureBox();
            this.imgOpenPlex = new System.Windows.Forms.PictureBox();
            this.btnSearch = new CButtonLib.CButton();
            this.bgSearchBox = new CButtonLib.CButton();
            this.tabSearchResults = new System.Windows.Forms.TabPage();
            this.btnBack = new CButtonLib.CButton();
            this.btnDownloadSelected = new CButtonLib.CButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.headerFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenPlex)).BeginInit();
            this.tabSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabHome);
            this.tab.Controls.Add(this.tabSearchResults);
            this.tab.Location = new System.Drawing.Point(-4, -22);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(959, 535);
            this.tab.TabIndex = 0;
            this.tab.TabStop = false;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHome.Controls.Add(this.txtSearchBox);
            this.tabHome.Controls.Add(this.btnTag5);
            this.tabHome.Controls.Add(this.btnTag4);
            this.tabHome.Controls.Add(this.btnTag3);
            this.tabHome.Controls.Add(this.btnTag2);
            this.tabHome.Controls.Add(this.btnTag1);
            this.tabHome.Controls.Add(this.lblAddTags);
            this.tabHome.Controls.Add(this.imgAbout);
            this.tabHome.Controls.Add(this.imgSettings);
            this.tabHome.Controls.Add(this.imgOpenPlex);
            this.tabHome.Controls.Add(this.btnSearch);
            this.tabHome.Controls.Add(this.bgSearchBox);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(951, 509);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtSearchBox.Location = new System.Drawing.Point(100, 215);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(700, 25);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.WaterMark = "Find movies, enter tags, insert url link...";
            this.txtSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.Silver;
            this.txtSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // btnTag5
            // 
            this.btnTag5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag5.BackColor = System.Drawing.Color.Transparent;
            this.btnTag5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag5.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag5.Corners.All = 2;
            this.btnTag5.Corners.LowerLeft = 2;
            this.btnTag5.Corners.LowerRight = 2;
            this.btnTag5.Corners.UpperLeft = 2;
            this.btnTag5.Corners.UpperRight = 2;
            this.btnTag5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag5.DesignerSelected = false;
            this.btnTag5.DimFactorClick = 0;
            this.btnTag5.DimFactorHover = 0;
            this.btnTag5.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag5.ImageIndex = 0;
            this.btnTag5.Location = new System.Drawing.Point(431, 274);
            this.btnTag5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag5.Name = "btnTag5";
            this.btnTag5.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag5.Size = new System.Drawing.Size(56, 31);
            this.btnTag5.TabIndex = 6;
            this.btnTag5.TabStop = false;
            this.btnTag5.Text = "720p";
            this.btnTag5.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag5.TextShadowShow = false;
            this.btnTag5.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag4
            // 
            this.btnTag4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag4.BackColor = System.Drawing.Color.Transparent;
            this.btnTag4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag4.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag4.Corners.All = 2;
            this.btnTag4.Corners.LowerLeft = 2;
            this.btnTag4.Corners.LowerRight = 2;
            this.btnTag4.Corners.UpperLeft = 2;
            this.btnTag4.Corners.UpperRight = 2;
            this.btnTag4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag4.DesignerSelected = false;
            this.btnTag4.DimFactorClick = 0;
            this.btnTag4.DimFactorHover = 0;
            this.btnTag4.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag4.ImageIndex = 0;
            this.btnTag4.Location = new System.Drawing.Point(365, 274);
            this.btnTag4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag4.Name = "btnTag4";
            this.btnTag4.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag4.Size = new System.Drawing.Size(56, 31);
            this.btnTag4.TabIndex = 5;
            this.btnTag4.TabStop = false;
            this.btnTag4.Text = "2013";
            this.btnTag4.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag4.TextShadowShow = false;
            this.btnTag4.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag3
            // 
            this.btnTag3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag3.BackColor = System.Drawing.Color.Transparent;
            this.btnTag3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag3.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag3.Corners.All = 2;
            this.btnTag3.Corners.LowerLeft = 2;
            this.btnTag3.Corners.LowerRight = 2;
            this.btnTag3.Corners.UpperLeft = 2;
            this.btnTag3.Corners.UpperRight = 2;
            this.btnTag3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag3.DesignerSelected = false;
            this.btnTag3.DimFactorClick = 0;
            this.btnTag3.DimFactorHover = 0;
            this.btnTag3.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag3.ImageIndex = 0;
            this.btnTag3.Location = new System.Drawing.Point(312, 274);
            this.btnTag3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag3.Name = "btnTag3";
            this.btnTag3.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag3.Size = new System.Drawing.Size(43, 31);
            this.btnTag3.TabIndex = 4;
            this.btnTag3.TabStop = false;
            this.btnTag3.Text = "HD";
            this.btnTag3.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag3.TextShadowShow = false;
            this.btnTag3.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag2
            // 
            this.btnTag2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag2.BackColor = System.Drawing.Color.Transparent;
            this.btnTag2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag2.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag2.Corners.All = 2;
            this.btnTag2.Corners.LowerLeft = 2;
            this.btnTag2.Corners.LowerRight = 2;
            this.btnTag2.Corners.UpperLeft = 2;
            this.btnTag2.Corners.UpperRight = 2;
            this.btnTag2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag2.DesignerSelected = false;
            this.btnTag2.DimFactorClick = 0;
            this.btnTag2.DimFactorHover = 0;
            this.btnTag2.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag2.ImageIndex = 0;
            this.btnTag2.Location = new System.Drawing.Point(238, 274);
            this.btnTag2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag2.Name = "btnTag2";
            this.btnTag2.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag2.Size = new System.Drawing.Size(64, 31);
            this.btnTag2.TabIndex = 3;
            this.btnTag2.TabStop = false;
            this.btnTag2.Text = "1080p";
            this.btnTag2.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag2.TextShadowShow = false;
            this.btnTag2.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // btnTag1
            // 
            this.btnTag1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTag1.BackColor = System.Drawing.Color.Transparent;
            this.btnTag1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag1.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTag1.Corners.All = 2;
            this.btnTag1.Corners.LowerLeft = 2;
            this.btnTag1.Corners.LowerRight = 2;
            this.btnTag1.Corners.UpperLeft = 2;
            this.btnTag1.Corners.UpperRight = 2;
            this.btnTag1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTag1.DesignerSelected = false;
            this.btnTag1.DimFactorClick = 0;
            this.btnTag1.DimFactorHover = 0;
            this.btnTag1.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnTag1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTag1.ImageIndex = 0;
            this.btnTag1.Location = new System.Drawing.Point(172, 274);
            this.btnTag1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTag1.Name = "btnTag1";
            this.btnTag1.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnTag1.Size = new System.Drawing.Size(56, 31);
            this.btnTag1.TabIndex = 2;
            this.btnTag1.TabStop = false;
            this.btnTag1.Text = "2017";
            this.btnTag1.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnTag1.TextShadowShow = false;
            this.btnTag1.Click += new System.EventHandler(this.btnTag4_Click);
            // 
            // lblAddTags
            // 
            this.lblAddTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddTags.AutoSize = true;
            this.lblAddTags.BackColor = System.Drawing.Color.Transparent;
            this.lblAddTags.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.lblAddTags.ForeColor = System.Drawing.Color.Silver;
            this.lblAddTags.Location = new System.Drawing.Point(88, 280);
            this.lblAddTags.Name = "lblAddTags";
            this.lblAddTags.Size = new System.Drawing.Size(70, 17);
            this.lblAddTags.TabIndex = 1;
            this.lblAddTags.Text = "ADD TAGS";
            // 
            // imgAbout
            // 
            this.imgAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAbout.BackColor = System.Drawing.Color.Transparent;
            this.imgAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAbout.Image = global::OpenPlex.Properties.Resources.iconAbout;
            this.imgAbout.Location = new System.Drawing.Point(870, 25);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(24, 24);
            this.imgAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAbout.TabIndex = 4;
            this.imgAbout.TabStop = false;
            this.imgAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // imgSettings
            // 
            this.imgSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgSettings.BackColor = System.Drawing.Color.Transparent;
            this.imgSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSettings.Image = global::OpenPlex.Properties.Resources.iconSettings;
            this.imgSettings.Location = new System.Drawing.Point(900, 25);
            this.imgSettings.Name = "imgSettings";
            this.imgSettings.Size = new System.Drawing.Size(24, 24);
            this.imgSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSettings.TabIndex = 3;
            this.imgSettings.TabStop = false;
            // 
            // imgOpenPlex
            // 
            this.imgOpenPlex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgOpenPlex.BackColor = System.Drawing.Color.Transparent;
            this.imgOpenPlex.Image = global::OpenPlex.Properties.Resources.openplex_text;
            this.imgOpenPlex.Location = new System.Drawing.Point(373, 21);
            this.imgOpenPlex.Name = "imgOpenPlex";
            this.imgOpenPlex.Size = new System.Drawing.Size(204, 30);
            this.imgOpenPlex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpenPlex.TabIndex = 1;
            this.imgOpenPlex.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(143)))), ((int)(((byte)(209)))));
            this.btnSearch.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(143)))), ((int)(((byte)(209)))));
            this.btnSearch.Corners.LowerRight = 2;
            this.btnSearch.Corners.UpperRight = 2;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DesignerSelected = false;
            this.btnSearch.DimFactorClick = -15;
            this.btnSearch.DimFactorHover = -15;
            this.btnSearch.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearch.FocalPoints.CenterPtX = 0F;
            this.btnSearch.FocalPoints.CenterPtY = 0F;
            this.btnSearch.Image = global::OpenPlex.Properties.Resources.SearchIconH;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageSize = new System.Drawing.Size(21, 21);
            this.btnSearch.Location = new System.Drawing.Point(811, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnSearch.Size = new System.Drawing.Size(48, 48);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "";
            this.btnSearch.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnSearch_ClickButtonArea);
            // 
            // bgSearchBox
            // 
            this.bgSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bgSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.bgSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bgSearchBox.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bgSearchBox.Corners.All = 2;
            this.bgSearchBox.Corners.LowerLeft = 2;
            this.bgSearchBox.Corners.LowerRight = 2;
            this.bgSearchBox.Corners.UpperLeft = 2;
            this.bgSearchBox.Corners.UpperRight = 2;
            this.bgSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bgSearchBox.DesignerSelected = false;
            this.bgSearchBox.DimFactorClick = 0;
            this.bgSearchBox.DimFactorHover = 0;
            this.bgSearchBox.FillType = CButtonLib.CButton.eFillType.Solid;
            this.bgSearchBox.ImageIndex = 0;
            this.bgSearchBox.Location = new System.Drawing.Point(91, 204);
            this.bgSearchBox.Name = "bgSearchBox";
            this.bgSearchBox.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSearchBox.Size = new System.Drawing.Size(768, 48);
            this.bgSearchBox.TabIndex = 0;
            this.bgSearchBox.TabStop = false;
            this.bgSearchBox.Text = "";
            // 
            // tabSearchResults
            // 
            this.tabSearchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabSearchResults.Controls.Add(this.btnBack);
            this.tabSearchResults.Controls.Add(this.btnDownloadSelected);
            this.tabSearchResults.Controls.Add(this.dataGrid);
            this.tabSearchResults.Location = new System.Drawing.Point(4, 22);
            this.tabSearchResults.Name = "tabSearchResults";
            this.tabSearchResults.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabSearchResults.Size = new System.Drawing.Size(951, 509);
            this.tabSearchResults.TabIndex = 1;
            this.tabSearchResults.Text = "tabPage2";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.btnBack.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.btnBack.Corners.All = 1;
            this.btnBack.Corners.LowerLeft = 1;
            this.btnBack.Corners.LowerRight = 1;
            this.btnBack.Corners.UpperLeft = 1;
            this.btnBack.Corners.UpperRight = 1;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DesignerSelected = false;
            this.btnBack.DimFactorClick = 0;
            this.btnBack.DimFactorHover = 0;
            this.btnBack.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.btnBack.ImageIndex = 0;
            this.btnBack.Location = new System.Drawing.Point(6, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnBack.Size = new System.Drawing.Size(50, 25);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.TextShadowShow = false;
            this.btnBack.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnBack_ClickButtonArea);
            // 
            // btnDownloadSelected
            // 
            this.btnDownloadSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.btnDownloadSelected.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.btnDownloadSelected.Corners.All = 1;
            this.btnDownloadSelected.Corners.LowerLeft = 1;
            this.btnDownloadSelected.Corners.LowerRight = 1;
            this.btnDownloadSelected.Corners.UpperLeft = 1;
            this.btnDownloadSelected.Corners.UpperRight = 1;
            this.btnDownloadSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadSelected.DesignerSelected = false;
            this.btnDownloadSelected.DimFactorClick = 0;
            this.btnDownloadSelected.DimFactorHover = 0;
            this.btnDownloadSelected.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnDownloadSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.btnDownloadSelected.ImageIndex = 0;
            this.btnDownloadSelected.Location = new System.Drawing.Point(62, 478);
            this.btnDownloadSelected.Name = "btnDownloadSelected";
            this.btnDownloadSelected.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnDownloadSelected.Size = new System.Drawing.Size(111, 25);
            this.btnDownloadSelected.TabIndex = 2;
            this.btnDownloadSelected.Text = "Download File";
            this.btnDownloadSelected.TextShadowShow = false;
            this.btnDownloadSelected.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnDownloadSelected_ClickButtonArea);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerFileName});
            this.dataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.Height = 26;
            this.dataGrid.Size = new System.Drawing.Size(951, 470);
            this.dataGrid.TabIndex = 0;
            // 
            // headerFileName
            // 
            this.headerFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerFileName.DefaultCellStyle = dataGridViewCellStyle3;
            this.headerFileName.HeaderText = "File Name";
            this.headerFileName.Name = "headerFileName";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWithToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // OpenWithToolStripMenuItem
            // 
            this.OpenWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WMPToolStripMenuItem,
            this.VLCToolStripMenuItem1});
            this.OpenWithToolStripMenuItem.Name = "OpenWithToolStripMenuItem";
            this.OpenWithToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.OpenWithToolStripMenuItem.Text = "Open with...";
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.WMPToolStripMenuItem.Text = "WMP";
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.wMPToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem1
            // 
            this.VLCToolStripMenuItem1.Name = "VLCToolStripMenuItem1";
            this.VLCToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.VLCToolStripMenuItem1.Text = "VLC";
            this.VLCToolStripMenuItem1.Click += new System.EventHandler(this.VLCToolStripMenuItem1_Click);
            // 
            // frmOpenPlex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.tab);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpenPlex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPlex";
            this.Load += new System.EventHandler(this.frmOpenPlex_Load);
            this.tab.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenPlex)).EndInit();
            this.tabSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSearchResults;
        private CButtonLib.CButton btnSearch;
        private CButtonLib.CButton bgSearchBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerFileName;
        private System.Windows.Forms.PictureBox imgOpenPlex;
        private System.Windows.Forms.PictureBox imgSettings;
        private System.Windows.Forms.PictureBox imgAbout;
        private CButtonLib.CButton btnDownloadSelected;
        private CButtonLib.CButton btnBack;
        private CButtonLib.CButton btnTag1;
        private System.Windows.Forms.Label lblAddTags;
        private CButtonLib.CButton btnTag4;
        private CButtonLib.CButton btnTag3;
        private CButtonLib.CButton btnTag2;
        private CButtonLib.CButton btnTag5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem1;
        private ChreneLib.Controls.TextBoxes.CTextBox txtSearchBox;
    }
}

