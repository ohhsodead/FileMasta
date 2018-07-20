namespace FileMasta.Windows
{
    partial class FileDetailsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDetailsWindow));
            CButtonLib.cBlendItems cBlendItems1 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems2 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems3 = new CButtonLib.cBlendItems();
            this.ButtonOpenWith = new System.Windows.Forms.Button();
            this.ButtonRequestSize = new System.Windows.Forms.Button();
            this.ImageNextFile = new System.Windows.Forms.PictureBox();
            this.ImagePreviousFile = new System.Windows.Forms.PictureBox();
            this.FlowPanelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonViewDirectory = new System.Windows.Forms.Button();
            this.ButtonBookmark = new System.Windows.Forms.Button();
            this.PanelShare = new System.Windows.Forms.Panel();
            this.ButtonShare = new CButtonLib.CButton();
            this.ComboBoxShare = new System.Windows.Forms.ComboBox();
            this.InfoSplitter4 = new CButtonLib.CButton();
            this.labelTitleExtension = new System.Windows.Forms.Label();
            this.LabelValueExtension = new System.Windows.Forms.Label();
            this.LabelDisclaimer = new System.Windows.Forms.Label();
            this.InfoFileURL = new CButtonLib.CButton();
            this.InfoSplitter5 = new CButtonLib.CButton();
            this.LabelTitleAge = new System.Windows.Forms.Label();
            this.LabelValueAge = new System.Windows.Forms.Label();
            this.InfoSplitter3 = new CButtonLib.CButton();
            this.LabelTitleDirectory = new System.Windows.Forms.Label();
            this.LabelValueDirectory = new System.Windows.Forms.Label();
            this.InfoSplitter2 = new CButtonLib.CButton();
            this.LabelTitleReferrer = new System.Windows.Forms.Label();
            this.LabelValueRefferer = new System.Windows.Forms.Label();
            this.labelTitleSize = new System.Windows.Forms.Label();
            this.LabelValueSize = new System.Windows.Forms.Label();
            this.InfoSplitter1 = new CButtonLib.CButton();
            this.InfoSplitter0 = new CButtonLib.CButton();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.LabelTitleName = new System.Windows.Forms.Label();
            this.LabelValueName = new System.Windows.Forms.Label();
            this.ButtonDirectLink = new CButtonLib.CButton();
            this.ContextOpenFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NitroReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KMPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PotPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ImageNextFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviousFile)).BeginInit();
            this.FlowPanelActions.SuspendLayout();
            this.PanelShare.SuspendLayout();
            this.ContextOpenFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOpenWith
            // 
            this.ButtonOpenWith.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOpenWith.Image = global::FileMasta.Properties.Resources.file_send;
            this.ButtonOpenWith.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOpenWith.Location = new System.Drawing.Point(9, 478);
            this.ButtonOpenWith.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ButtonOpenWith.Name = "ButtonOpenWith";
            this.ButtonOpenWith.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ButtonOpenWith.Size = new System.Drawing.Size(110, 28);
            this.ButtonOpenWith.TabIndex = 100108;
            this.ButtonOpenWith.Text = "Open With...";
            this.ButtonOpenWith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOpenWith.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonOpenWith.UseVisualStyleBackColor = true;
            this.ButtonOpenWith.Click += new System.EventHandler(this.ButtonOpenWith_Click);
            // 
            // ButtonRequestSize
            // 
            this.ButtonRequestSize.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonRequestSize.Image = global::FileMasta.Properties.Resources.file_find;
            this.ButtonRequestSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRequestSize.Location = new System.Drawing.Point(180, 112);
            this.ButtonRequestSize.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ButtonRequestSize.Name = "ButtonRequestSize";
            this.ButtonRequestSize.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ButtonRequestSize.Size = new System.Drawing.Size(138, 28);
            this.ButtonRequestSize.TabIndex = 100107;
            this.ButtonRequestSize.Text = "Request File Size";
            this.ButtonRequestSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRequestSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRequestSize.UseVisualStyleBackColor = true;
            this.ButtonRequestSize.Click += new System.EventHandler(this.ButtonRequestSize_Click);
            // 
            // ImageNextFile
            // 
            this.ImageNextFile.BackColor = System.Drawing.Color.Transparent;
            this.ImageNextFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageNextFile.Image = ((System.Drawing.Image)(resources.GetObject("ImageNextFile.Image")));
            this.ImageNextFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImageNextFile.Location = new System.Drawing.Point(37, 17);
            this.ImageNextFile.Margin = new System.Windows.Forms.Padding(2, 25, 2, 3);
            this.ImageNextFile.Name = "ImageNextFile";
            this.ImageNextFile.Size = new System.Drawing.Size(24, 24);
            this.ImageNextFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageNextFile.TabIndex = 100106;
            this.ImageNextFile.TabStop = false;
            this.ImageNextFile.Click += new System.EventHandler(this.ImageNextFile_Click);
            // 
            // ImagePreviousFile
            // 
            this.ImagePreviousFile.BackColor = System.Drawing.Color.Transparent;
            this.ImagePreviousFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagePreviousFile.Image = ((System.Drawing.Image)(resources.GetObject("ImagePreviousFile.Image")));
            this.ImagePreviousFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImagePreviousFile.Location = new System.Drawing.Point(11, 17);
            this.ImagePreviousFile.Margin = new System.Windows.Forms.Padding(2, 25, 2, 3);
            this.ImagePreviousFile.Name = "ImagePreviousFile";
            this.ImagePreviousFile.Size = new System.Drawing.Size(24, 24);
            this.ImagePreviousFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePreviousFile.TabIndex = 100105;
            this.ImagePreviousFile.TabStop = false;
            this.ImagePreviousFile.Click += new System.EventHandler(this.ImagePreviousFile_Click);
            // 
            // FlowPanelActions
            // 
            this.FlowPanelActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanelActions.Controls.Add(this.ButtonViewDirectory);
            this.FlowPanelActions.Controls.Add(this.ButtonBookmark);
            this.FlowPanelActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowPanelActions.Location = new System.Drawing.Point(622, 14);
            this.FlowPanelActions.Name = "FlowPanelActions";
            this.FlowPanelActions.Size = new System.Drawing.Size(332, 28);
            this.FlowPanelActions.TabIndex = 100096;
            this.FlowPanelActions.TabStop = true;
            // 
            // ButtonViewDirectory
            // 
            this.ButtonViewDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewDirectory.Image = global::FileMasta.Properties.Resources.search_web;
            this.ButtonViewDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonViewDirectory.Location = new System.Drawing.Point(208, 0);
            this.ButtonViewDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ButtonViewDirectory.Name = "ButtonViewDirectory";
            this.ButtonViewDirectory.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ButtonViewDirectory.Size = new System.Drawing.Size(124, 28);
            this.ButtonViewDirectory.TabIndex = 100080;
            this.ButtonViewDirectory.Text = "View Directory";
            this.ButtonViewDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonViewDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonViewDirectory.UseVisualStyleBackColor = true;
            this.ButtonViewDirectory.Click += new System.EventHandler(this.ButtonViewDirectory_Click);
            // 
            // ButtonBookmark
            // 
            this.ButtonBookmark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBookmark.Image = global::FileMasta.Properties.Resources.bookmark;
            this.ButtonBookmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBookmark.Location = new System.Drawing.Point(56, 0);
            this.ButtonBookmark.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ButtonBookmark.Name = "ButtonBookmark";
            this.ButtonBookmark.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ButtonBookmark.Size = new System.Drawing.Size(148, 28);
            this.ButtonBookmark.TabIndex = 100078;
            this.ButtonBookmark.Text = "Add to Bookmarks";
            this.ButtonBookmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBookmark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBookmark.UseVisualStyleBackColor = true;
            this.ButtonBookmark.Click += new System.EventHandler(this.ButtonBookmark_Click);
            // 
            // PanelShare
            // 
            this.PanelShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelShare.BackColor = System.Drawing.Color.Silver;
            this.PanelShare.Controls.Add(this.ButtonShare);
            this.PanelShare.Controls.Add(this.ComboBoxShare);
            this.PanelShare.Location = new System.Drawing.Point(874, 350);
            this.PanelShare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PanelShare.Name = "PanelShare";
            this.PanelShare.Size = new System.Drawing.Size(73, 22);
            this.PanelShare.TabIndex = 100104;
            // 
            // ButtonShare
            // 
            this.ButtonShare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonShare.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShare.BorderColor = System.Drawing.SystemColors.Control;
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems1.iPoint = new float[] {
        0F,
        1F};
            this.ButtonShare.ColorFillBlend = cBlendItems1;
            this.ButtonShare.Corners.All = 2;
            this.ButtonShare.Corners.LowerLeft = 2;
            this.ButtonShare.Corners.LowerRight = 2;
            this.ButtonShare.Corners.UpperLeft = 2;
            this.ButtonShare.Corners.UpperRight = 2;
            this.ButtonShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShare.DesignerSelected = false;
            this.ButtonShare.DimFactorClick = 0;
            this.ButtonShare.DimFactorHover = 0;
            this.ButtonShare.FillType = CButtonLib.CButton.eFillType.Solid;
            this.ButtonShare.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.ButtonShare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonShare.Image = ((System.Drawing.Image)(resources.GetObject("ButtonShare.Image")));
            this.ButtonShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShare.ImageIndex = 0;
            this.ButtonShare.Location = new System.Drawing.Point(0, 0);
            this.ButtonShare.Name = "ButtonShare";
            this.ButtonShare.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.ButtonShare.SideImage = global::FileMasta.Properties.Resources.menu_down;
            this.ButtonShare.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonShare.SideImageSize = new System.Drawing.Size(16, 16);
            this.ButtonShare.Size = new System.Drawing.Size(73, 22);
            this.ButtonShare.TabIndex = 4;
            this.ButtonShare.Text = "Share";
            this.ButtonShare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShare.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.ButtonShare.TextShadow = System.Drawing.Color.Empty;
            this.ButtonShare.TextShadowShow = false;
            this.ButtonShare.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.ButtonShare_ClickButtonArea);
            // 
            // ComboBoxShare
            // 
            this.ComboBoxShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxShare.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxShare.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.ComboBoxShare.FormattingEnabled = true;
            this.ComboBoxShare.Items.AddRange(new object[] {
            "Facebook",
            "Twitter",
            "Google+",
            "Reddit",
            "Email"});
            this.ComboBoxShare.Location = new System.Drawing.Point(0, -2);
            this.ComboBoxShare.Name = "ComboBoxShare";
            this.ComboBoxShare.Size = new System.Drawing.Size(73, 23);
            this.ComboBoxShare.TabIndex = 0;
            this.ComboBoxShare.TabStop = false;
            this.ComboBoxShare.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShare_SelectedIndexChanged);
            // 
            // InfoSplitter4
            // 
            this.InfoSplitter4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter4.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter4.BorderColor = System.Drawing.Color.Silver;
            this.InfoSplitter4.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoSplitter4.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter4.DesignerSelected = false;
            this.InfoSplitter4.DimFactorClick = 0;
            this.InfoSplitter4.DimFactorHover = 0;
            this.InfoSplitter4.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter4.ImageIndex = 0;
            this.InfoSplitter4.Location = new System.Drawing.Point(12, 234);
            this.InfoSplitter4.Name = "InfoSplitter4";
            this.InfoSplitter4.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter4.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter4.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter4.Size = new System.Drawing.Size(943, 1);
            this.InfoSplitter4.TabIndex = 100094;
            this.InfoSplitter4.TabStop = false;
            this.InfoSplitter4.Text = "";
            this.InfoSplitter4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter4.TextShadowShow = false;
            // 
            // labelTitleExtension
            // 
            this.labelTitleExtension.AutoSize = true;
            this.labelTitleExtension.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleExtension.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTitleExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleExtension.Location = new System.Drawing.Point(16, 246);
            this.labelTitleExtension.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.labelTitleExtension.Name = "labelTitleExtension";
            this.labelTitleExtension.Size = new System.Drawing.Size(70, 19);
            this.labelTitleExtension.TabIndex = 100093;
            this.labelTitleExtension.Text = "Extension:";
            // 
            // LabelValueExtension
            // 
            this.LabelValueExtension.AutoSize = true;
            this.LabelValueExtension.BackColor = System.Drawing.Color.Transparent;
            this.LabelValueExtension.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelValueExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelValueExtension.Location = new System.Drawing.Point(176, 246);
            this.LabelValueExtension.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelValueExtension.Name = "LabelValueExtension";
            this.LabelValueExtension.Size = new System.Drawing.Size(15, 19);
            this.LabelValueExtension.TabIndex = 100092;
            this.LabelValueExtension.Text = "-";
            // 
            // LabelDisclaimer
            // 
            this.LabelDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDisclaimer.BackColor = System.Drawing.Color.Transparent;
            this.LabelDisclaimer.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.LabelDisclaimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDisclaimer.Location = new System.Drawing.Point(9, 435);
            this.LabelDisclaimer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LabelDisclaimer.Name = "LabelDisclaimer";
            this.LabelDisclaimer.Size = new System.Drawing.Size(945, 38);
            this.LabelDisclaimer.TabIndex = 100103;
            this.LabelDisclaimer.Text = resources.GetString("LabelDisclaimer.Text");
            // 
            // InfoFileURL
            // 
            this.InfoFileURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoFileURL.BackColor = System.Drawing.Color.Transparent;
            this.InfoFileURL.BorderColor = System.Drawing.Color.Silver;
            cBlendItems2.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            cBlendItems2.iPoint = new float[] {
        0F,
        1F};
            this.InfoFileURL.ColorFillBlend = cBlendItems2;
            this.InfoFileURL.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoFileURL.Corners.All = 2;
            this.InfoFileURL.Corners.LowerLeft = 2;
            this.InfoFileURL.Corners.LowerRight = 2;
            this.InfoFileURL.Corners.UpperLeft = 2;
            this.InfoFileURL.Corners.UpperRight = 2;
            this.InfoFileURL.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoFileURL.DesignerSelected = false;
            this.InfoFileURL.DimFactorClick = 0;
            this.InfoFileURL.DimFactorHover = 0;
            this.InfoFileURL.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoFileURL.FocalPoints.CenterPtX = 0F;
            this.InfoFileURL.FocalPoints.CenterPtY = 0F;
            this.InfoFileURL.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.InfoFileURL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoFileURL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoFileURL.ImageIndex = 0;
            this.InfoFileURL.ImageSize = new System.Drawing.Size(24, 24);
            this.InfoFileURL.Location = new System.Drawing.Point(12, 344);
            this.InfoFileURL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InfoFileURL.Name = "InfoFileURL";
            this.InfoFileURL.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoFileURL.SideImageSize = new System.Drawing.Size(24, 24);
            this.InfoFileURL.Size = new System.Drawing.Size(942, 34);
            this.InfoFileURL.TabIndex = 100091;
            this.InfoFileURL.TabStop = false;
            this.InfoFileURL.Text = "URL";
            this.InfoFileURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoFileURL.TextMargin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.InfoFileURL.TextShadowShow = false;
            // 
            // InfoSplitter5
            // 
            this.InfoSplitter5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter5.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter5.BorderColor = System.Drawing.Color.Silver;
            this.InfoSplitter5.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoSplitter5.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter5.DesignerSelected = false;
            this.InfoSplitter5.DimFactorClick = 0;
            this.InfoSplitter5.DimFactorHover = 0;
            this.InfoSplitter5.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter5.ImageIndex = 0;
            this.InfoSplitter5.Location = new System.Drawing.Point(12, 277);
            this.InfoSplitter5.Name = "InfoSplitter5";
            this.InfoSplitter5.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter5.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter5.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter5.Size = new System.Drawing.Size(943, 1);
            this.InfoSplitter5.TabIndex = 100089;
            this.InfoSplitter5.TabStop = false;
            this.InfoSplitter5.Text = "";
            this.InfoSplitter5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter5.TextShadowShow = false;
            // 
            // LabelTitleAge
            // 
            this.LabelTitleAge.AutoSize = true;
            this.LabelTitleAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelTitleAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleAge.Location = new System.Drawing.Point(16, 289);
            this.LabelTitleAge.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelTitleAge.Name = "LabelTitleAge";
            this.LabelTitleAge.Size = new System.Drawing.Size(36, 19);
            this.LabelTitleAge.TabIndex = 100088;
            this.LabelTitleAge.Text = "Age:";
            // 
            // LabelValueAge
            // 
            this.LabelValueAge.AutoSize = true;
            this.LabelValueAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelValueAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelValueAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelValueAge.Location = new System.Drawing.Point(176, 289);
            this.LabelValueAge.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelValueAge.Name = "LabelValueAge";
            this.LabelValueAge.Size = new System.Drawing.Size(15, 19);
            this.LabelValueAge.TabIndex = 100081;
            this.LabelValueAge.Text = "-";
            // 
            // InfoSplitter3
            // 
            this.InfoSplitter3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter3.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter3.BorderColor = System.Drawing.Color.Silver;
            this.InfoSplitter3.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoSplitter3.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter3.DesignerSelected = false;
            this.InfoSplitter3.DimFactorClick = 0;
            this.InfoSplitter3.DimFactorHover = 0;
            this.InfoSplitter3.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter3.ImageIndex = 0;
            this.InfoSplitter3.Location = new System.Drawing.Point(12, 191);
            this.InfoSplitter3.Name = "InfoSplitter3";
            this.InfoSplitter3.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter3.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter3.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter3.Size = new System.Drawing.Size(943, 1);
            this.InfoSplitter3.TabIndex = 100086;
            this.InfoSplitter3.TabStop = false;
            this.InfoSplitter3.Text = "";
            this.InfoSplitter3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter3.TextShadowShow = false;
            // 
            // LabelTitleDirectory
            // 
            this.LabelTitleDirectory.AutoSize = true;
            this.LabelTitleDirectory.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleDirectory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelTitleDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleDirectory.Location = new System.Drawing.Point(16, 203);
            this.LabelTitleDirectory.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelTitleDirectory.Name = "LabelTitleDirectory";
            this.LabelTitleDirectory.Size = new System.Drawing.Size(68, 19);
            this.LabelTitleDirectory.TabIndex = 100085;
            this.LabelTitleDirectory.Text = "Directory:";
            // 
            // LabelValueDirectory
            // 
            this.LabelValueDirectory.AutoSize = true;
            this.LabelValueDirectory.BackColor = System.Drawing.Color.Transparent;
            this.LabelValueDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelValueDirectory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelValueDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelValueDirectory.Location = new System.Drawing.Point(176, 203);
            this.LabelValueDirectory.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelValueDirectory.Name = "LabelValueDirectory";
            this.LabelValueDirectory.Size = new System.Drawing.Size(15, 19);
            this.LabelValueDirectory.TabIndex = 100084;
            this.LabelValueDirectory.Text = "-";
            // 
            // InfoSplitter2
            // 
            this.InfoSplitter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter2.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter2.BorderColor = System.Drawing.Color.Silver;
            this.InfoSplitter2.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoSplitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter2.DesignerSelected = false;
            this.InfoSplitter2.DimFactorClick = 0;
            this.InfoSplitter2.DimFactorHover = 0;
            this.InfoSplitter2.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter2.ImageIndex = 0;
            this.InfoSplitter2.Location = new System.Drawing.Point(12, 148);
            this.InfoSplitter2.Name = "InfoSplitter2";
            this.InfoSplitter2.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter2.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter2.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter2.Size = new System.Drawing.Size(943, 1);
            this.InfoSplitter2.TabIndex = 100083;
            this.InfoSplitter2.TabStop = false;
            this.InfoSplitter2.Text = "";
            this.InfoSplitter2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter2.TextShadowShow = false;
            // 
            // LabelTitleReferrer
            // 
            this.LabelTitleReferrer.AutoSize = true;
            this.LabelTitleReferrer.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleReferrer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelTitleReferrer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleReferrer.Location = new System.Drawing.Point(16, 160);
            this.LabelTitleReferrer.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelTitleReferrer.Name = "LabelTitleReferrer";
            this.LabelTitleReferrer.Size = new System.Drawing.Size(60, 19);
            this.LabelTitleReferrer.TabIndex = 100082;
            this.LabelTitleReferrer.Text = "Referrer:";
            // 
            // LabelValueRefferer
            // 
            this.LabelValueRefferer.AutoSize = true;
            this.LabelValueRefferer.BackColor = System.Drawing.Color.Transparent;
            this.LabelValueRefferer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelValueRefferer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelValueRefferer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelValueRefferer.Location = new System.Drawing.Point(176, 160);
            this.LabelValueRefferer.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelValueRefferer.Name = "LabelValueRefferer";
            this.LabelValueRefferer.Size = new System.Drawing.Size(15, 19);
            this.LabelValueRefferer.TabIndex = 100090;
            this.LabelValueRefferer.Text = "-";
            // 
            // labelTitleSize
            // 
            this.labelTitleSize.AutoSize = true;
            this.labelTitleSize.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleSize.Location = new System.Drawing.Point(16, 117);
            this.labelTitleSize.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.labelTitleSize.Name = "labelTitleSize";
            this.labelTitleSize.Size = new System.Drawing.Size(35, 19);
            this.labelTitleSize.TabIndex = 100101;
            this.labelTitleSize.Text = "Size:";
            // 
            // LabelValueSize
            // 
            this.LabelValueSize.AutoSize = true;
            this.LabelValueSize.BackColor = System.Drawing.Color.Transparent;
            this.LabelValueSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelValueSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelValueSize.Location = new System.Drawing.Point(176, 117);
            this.LabelValueSize.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelValueSize.Name = "LabelValueSize";
            this.LabelValueSize.Size = new System.Drawing.Size(15, 19);
            this.LabelValueSize.TabIndex = 100100;
            this.LabelValueSize.Text = "-";
            // 
            // InfoSplitter1
            // 
            this.InfoSplitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter1.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter1.BorderColor = System.Drawing.Color.Silver;
            this.InfoSplitter1.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoSplitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter1.DesignerSelected = false;
            this.InfoSplitter1.DimFactorClick = 0;
            this.InfoSplitter1.DimFactorHover = 0;
            this.InfoSplitter1.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter1.ImageIndex = 0;
            this.InfoSplitter1.Location = new System.Drawing.Point(12, 104);
            this.InfoSplitter1.Name = "InfoSplitter1";
            this.InfoSplitter1.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter1.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter1.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter1.Size = new System.Drawing.Size(943, 2);
            this.InfoSplitter1.TabIndex = 100095;
            this.InfoSplitter1.TabStop = false;
            this.InfoSplitter1.Text = "";
            this.InfoSplitter1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter1.TextShadowShow = false;
            // 
            // InfoSplitter0
            // 
            this.InfoSplitter0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoSplitter0.BackColor = System.Drawing.Color.Transparent;
            this.InfoSplitter0.BorderColor = System.Drawing.Color.Silver;
            this.InfoSplitter0.ColorFillSolid = System.Drawing.Color.Silver;
            this.InfoSplitter0.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoSplitter0.DesignerSelected = false;
            this.InfoSplitter0.DimFactorClick = 0;
            this.InfoSplitter0.DimFactorHover = 0;
            this.InfoSplitter0.FillType = CButtonLib.CButton.eFillType.Solid;
            this.InfoSplitter0.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InfoSplitter0.ImageIndex = 0;
            this.InfoSplitter0.Location = new System.Drawing.Point(12, 61);
            this.InfoSplitter0.Name = "InfoSplitter0";
            this.InfoSplitter0.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.InfoSplitter0.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoSplitter0.SideImageSize = new System.Drawing.Size(21, 21);
            this.InfoSplitter0.Size = new System.Drawing.Size(943, 1);
            this.InfoSplitter0.TabIndex = 100097;
            this.InfoSplitter0.TabStop = false;
            this.InfoSplitter0.Text = "";
            this.InfoSplitter0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoSplitter0.TextShadowShow = false;
            // 
            // LabelFileName
            // 
            this.LabelFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFileName.AutoEllipsis = true;
            this.LabelFileName.BackColor = System.Drawing.Color.Transparent;
            this.LabelFileName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F);
            this.LabelFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFileName.Location = new System.Drawing.Point(72, 13);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(547, 30);
            this.LabelFileName.TabIndex = 100098;
            this.LabelFileName.Text = "File Name";
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTitleName
            // 
            this.LabelTitleName.AutoSize = true;
            this.LabelTitleName.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.LabelTitleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTitleName.Location = new System.Drawing.Point(16, 73);
            this.LabelTitleName.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelTitleName.Name = "LabelTitleName";
            this.LabelTitleName.Size = new System.Drawing.Size(49, 19);
            this.LabelTitleName.TabIndex = 100099;
            this.LabelTitleName.Text = "Name:";
            // 
            // LabelValueName
            // 
            this.LabelValueName.AutoSize = true;
            this.LabelValueName.BackColor = System.Drawing.Color.Transparent;
            this.LabelValueName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.LabelValueName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelValueName.Location = new System.Drawing.Point(176, 73);
            this.LabelValueName.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.LabelValueName.Name = "LabelValueName";
            this.LabelValueName.Size = new System.Drawing.Size(15, 19);
            this.LabelValueName.TabIndex = 100087;
            this.LabelValueName.Text = "-";
            // 
            // ButtonDirectLink
            // 
            this.ButtonDirectLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDirectLink.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDirectLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(186)))), ((int)(((byte)(96)))));
            cBlendItems3.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(186)))), ((int)(((byte)(96))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(184)))), ((int)(((byte)(85)))))};
            cBlendItems3.iPoint = new float[] {
        0F,
        1F};
            this.ButtonDirectLink.ColorFillBlend = cBlendItems3;
            this.ButtonDirectLink.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(186)))), ((int)(((byte)(96)))));
            this.ButtonDirectLink.Corners.All = 2;
            this.ButtonDirectLink.Corners.LowerLeft = 2;
            this.ButtonDirectLink.Corners.LowerRight = 2;
            this.ButtonDirectLink.Corners.UpperLeft = 2;
            this.ButtonDirectLink.Corners.UpperRight = 2;
            this.ButtonDirectLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDirectLink.DesignerSelected = false;
            this.ButtonDirectLink.DimFactorClick = 0;
            this.ButtonDirectLink.DimFactorHover = 0;
            this.ButtonDirectLink.FillType = CButtonLib.CButton.eFillType.Solid;
            this.ButtonDirectLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ButtonDirectLink.Image = global::FileMasta.Properties.Resources.link_variant;
            this.ButtonDirectLink.ImageIndex = 0;
            this.ButtonDirectLink.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonDirectLink.Location = new System.Drawing.Point(12, 396);
            this.ButtonDirectLink.Name = "ButtonDirectLink";
            this.ButtonDirectLink.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.ButtonDirectLink.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDirectLink.SideImageSize = new System.Drawing.Size(22, 22);
            this.ButtonDirectLink.Size = new System.Drawing.Size(942, 32);
            this.ButtonDirectLink.TabIndex = 100102;
            this.ButtonDirectLink.Text = "Direct Download Link";
            this.ButtonDirectLink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDirectLink.TextShadow = System.Drawing.Color.Empty;
            this.ButtonDirectLink.TextShadowShow = false;
            this.ButtonDirectLink.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.ButtonDirectLink_ClickButtonArea);
            // 
            // ContextOpenFile
            // 
            this.ContextOpenFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NitroReaderToolStripMenuItem,
            this.VLCToolStripMenuItem,
            this.WMPToolStripMenuItem,
            this.MPCToolStripMenuItem,
            this.KMPlayerToolStripMenuItem,
            this.PotPlayerToolStripMenuItem,
            this.IDMToolStripMenuItem,
            this.IDAToolStripMenuItem,
            this.FDMToolStripMenuItem});
            this.ContextOpenFile.Name = "contextMenuStrip1";
            this.ContextOpenFile.ShowItemToolTips = false;
            this.ContextOpenFile.Size = new System.Drawing.Size(236, 224);
            // 
            // NitroReaderToolStripMenuItem
            // 
            this.NitroReaderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NitroReaderToolStripMenuItem.Image")));
            this.NitroReaderToolStripMenuItem.Name = "NitroReaderToolStripMenuItem";
            this.NitroReaderToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.NitroReaderToolStripMenuItem.Text = "Nitro Reader";
            this.NitroReaderToolStripMenuItem.Visible = false;
            this.NitroReaderToolStripMenuItem.Click += new System.EventHandler(this.NitroPDFToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Image = global::FileMasta.Properties.Resources.vlc;
            this.VLCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.VLCToolStripMenuItem.Text = "VLC Player";
            this.VLCToolStripMenuItem.Visible = false;
            this.VLCToolStripMenuItem.Click += new System.EventHandler(this.VLCToolStripMenuItem_Click);
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Image = global::FileMasta.Properties.Resources.windows;
            this.WMPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.WMPToolStripMenuItem.Text = "Windows Media Player";
            this.WMPToolStripMenuItem.Visible = false;
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.WMPToolStripMenuItem_Click);
            // 
            // MPCToolStripMenuItem
            // 
            this.MPCToolStripMenuItem.Image = global::FileMasta.Properties.Resources.play_circle;
            this.MPCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MPCToolStripMenuItem.Name = "MPCToolStripMenuItem";
            this.MPCToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.MPCToolStripMenuItem.Text = "Media Player Classic";
            this.MPCToolStripMenuItem.Visible = false;
            this.MPCToolStripMenuItem.Click += new System.EventHandler(this.MPCToolStripMenuItem_Click);
            // 
            // KMPlayerToolStripMenuItem
            // 
            this.KMPlayerToolStripMenuItem.Image = global::FileMasta.Properties.Resources.play_circle;
            this.KMPlayerToolStripMenuItem.Name = "KMPlayerToolStripMenuItem";
            this.KMPlayerToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.KMPlayerToolStripMenuItem.Text = "KMPlayer";
            this.KMPlayerToolStripMenuItem.Visible = false;
            this.KMPlayerToolStripMenuItem.Click += new System.EventHandler(this.KMPlayerToolStripMenuItem_Click);
            // 
            // PotPlayerToolStripMenuItem
            // 
            this.PotPlayerToolStripMenuItem.Image = global::FileMasta.Properties.Resources.play_circle;
            this.PotPlayerToolStripMenuItem.Name = "PotPlayerToolStripMenuItem";
            this.PotPlayerToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.PotPlayerToolStripMenuItem.Text = "PotPlayer";
            this.PotPlayerToolStripMenuItem.Visible = false;
            this.PotPlayerToolStripMenuItem.Click += new System.EventHandler(this.PotPlayerToolStripMenuItem_Click);
            // 
            // IDMToolStripMenuItem
            // 
            this.IDMToolStripMenuItem.Image = global::FileMasta.Properties.Resources.download;
            this.IDMToolStripMenuItem.Name = "IDMToolStripMenuItem";
            this.IDMToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.IDMToolStripMenuItem.Text = "Internet Download Manager";
            this.IDMToolStripMenuItem.Visible = false;
            this.IDMToolStripMenuItem.Click += new System.EventHandler(this.IDMToolStripMenuItem_Click);
            // 
            // IDAToolStripMenuItem
            // 
            this.IDAToolStripMenuItem.Image = global::FileMasta.Properties.Resources.download;
            this.IDAToolStripMenuItem.Name = "IDAToolStripMenuItem";
            this.IDAToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.IDAToolStripMenuItem.Text = "Internet Download Accelerator";
            this.IDAToolStripMenuItem.Visible = false;
            this.IDAToolStripMenuItem.Click += new System.EventHandler(this.InternetDownloadAccelaratorToolStripMenuItem_Click);
            // 
            // FDMToolStripMenuItem
            // 
            this.FDMToolStripMenuItem.Image = global::FileMasta.Properties.Resources.download;
            this.FDMToolStripMenuItem.Name = "FDMToolStripMenuItem";
            this.FDMToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.FDMToolStripMenuItem.Text = "Free Download Manager";
            this.FDMToolStripMenuItem.Visible = false;
            this.FDMToolStripMenuItem.Click += new System.EventHandler(this.FDMToolStripMenuItem_Click);
            // 
            // FileDetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(967, 519);
            this.Controls.Add(this.ButtonOpenWith);
            this.Controls.Add(this.ButtonRequestSize);
            this.Controls.Add(this.ImageNextFile);
            this.Controls.Add(this.ImagePreviousFile);
            this.Controls.Add(this.FlowPanelActions);
            this.Controls.Add(this.PanelShare);
            this.Controls.Add(this.InfoSplitter4);
            this.Controls.Add(this.labelTitleExtension);
            this.Controls.Add(this.LabelValueExtension);
            this.Controls.Add(this.LabelDisclaimer);
            this.Controls.Add(this.InfoFileURL);
            this.Controls.Add(this.InfoSplitter5);
            this.Controls.Add(this.LabelTitleAge);
            this.Controls.Add(this.LabelValueAge);
            this.Controls.Add(this.InfoSplitter3);
            this.Controls.Add(this.LabelTitleDirectory);
            this.Controls.Add(this.LabelValueDirectory);
            this.Controls.Add(this.InfoSplitter2);
            this.Controls.Add(this.LabelTitleReferrer);
            this.Controls.Add(this.LabelValueRefferer);
            this.Controls.Add(this.labelTitleSize);
            this.Controls.Add(this.LabelValueSize);
            this.Controls.Add(this.InfoSplitter1);
            this.Controls.Add(this.InfoSplitter0);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.LabelTitleName);
            this.Controls.Add(this.LabelValueName);
            this.Controls.Add(this.ButtonDirectLink);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileDetailsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Details";
            this.Load += new System.EventHandler(this.FileDetailsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageNextFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviousFile)).EndInit();
            this.FlowPanelActions.ResumeLayout(false);
            this.PanelShare.ResumeLayout(false);
            this.ContextOpenFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenWith;
        private System.Windows.Forms.Button ButtonRequestSize;
        public System.Windows.Forms.PictureBox ImageNextFile;
        public System.Windows.Forms.PictureBox ImagePreviousFile;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelActions;
        private System.Windows.Forms.Button ButtonViewDirectory;
        private System.Windows.Forms.Button ButtonBookmark;
        private System.Windows.Forms.Panel PanelShare;
        private CButtonLib.CButton ButtonShare;
        private System.Windows.Forms.ComboBox ComboBoxShare;
        public CButtonLib.CButton InfoSplitter4;
        public System.Windows.Forms.Label labelTitleExtension;
        public System.Windows.Forms.Label LabelValueExtension;
        public System.Windows.Forms.Label LabelDisclaimer;
        public CButtonLib.CButton InfoFileURL;
        public CButtonLib.CButton InfoSplitter5;
        public System.Windows.Forms.Label LabelTitleAge;
        public System.Windows.Forms.Label LabelValueAge;
        public CButtonLib.CButton InfoSplitter3;
        public System.Windows.Forms.Label LabelTitleDirectory;
        public System.Windows.Forms.Label LabelValueDirectory;
        public CButtonLib.CButton InfoSplitter2;
        public System.Windows.Forms.Label LabelTitleReferrer;
        public System.Windows.Forms.Label LabelValueRefferer;
        public System.Windows.Forms.Label labelTitleSize;
        public System.Windows.Forms.Label LabelValueSize;
        public CButtonLib.CButton InfoSplitter1;
        public CButtonLib.CButton InfoSplitter0;
        public System.Windows.Forms.Label LabelFileName;
        public System.Windows.Forms.Label LabelTitleName;
        public System.Windows.Forms.Label LabelValueName;
        public CButtonLib.CButton ButtonDirectLink;
        public System.Windows.Forms.ContextMenuStrip ContextOpenFile;
        private System.Windows.Forms.ToolStripMenuItem NitroReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KMPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PotPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FDMToolStripMenuItem;
    }
}