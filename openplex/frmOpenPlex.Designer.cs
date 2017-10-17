namespace openplex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.txtSearchBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btnSearch = new CButtonLib.CButton();
            this.bgSearchBox = new CButtonLib.CButton();
            this.tabSearchResults = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.headerFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBackHome = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.tabHome.BackColor = System.Drawing.Color.Black;
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHome.Controls.Add(this.txtSearchBox);
            this.tabHome.Controls.Add(this.btnSearch);
            this.tabHome.Controls.Add(this.bgSearchBox);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(951, 509);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "tabPage1";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtSearchBox.Location = new System.Drawing.Point(100, 241);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(700, 25);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.WaterMark = "Find movies, enter tags, insert url link...";
            this.txtSearchBox.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.txtSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchBox.WaterMarkForeColor = System.Drawing.Color.Silver;
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
            this.btnSearch.DimFactorClick = 0;
            this.btnSearch.DimFactorHover = 0;
            this.btnSearch.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnSearch.FocalPoints.CenterPtX = 0F;
            this.btnSearch.FocalPoints.CenterPtY = 0F;
            this.btnSearch.Image = global::openplex.Properties.Resources.SearchIconH;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageSize = new System.Drawing.Size(21, 21);
            this.btnSearch.Location = new System.Drawing.Point(811, 230);
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
            this.bgSearchBox.Location = new System.Drawing.Point(91, 230);
            this.bgSearchBox.Name = "bgSearchBox";
            this.bgSearchBox.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.bgSearchBox.Size = new System.Drawing.Size(768, 48);
            this.bgSearchBox.TabIndex = 2;
            this.bgSearchBox.TabStop = false;
            this.bgSearchBox.Text = "";
            // 
            // tabSearchResults
            // 
            this.tabSearchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.tabSearchResults.Controls.Add(this.dataGrid);
            this.tabSearchResults.Controls.Add(this.lblBackHome);
            this.tabSearchResults.Location = new System.Drawing.Point(4, 22);
            this.tabSearchResults.Name = "tabSearchResults";
            this.tabSearchResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchResults.Size = new System.Drawing.Size(951, 509);
            this.tabSearchResults.TabIndex = 1;
            this.tabSearchResults.Text = "tabPage2";
            // 
            // dataGrid
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerFileName});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.dataGrid.Location = new System.Drawing.Point(3, 26);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.Height = 26;
            this.dataGrid.Size = new System.Drawing.Size(945, 480);
            this.dataGrid.TabIndex = 0;
            // 
            // headerFileName
            // 
            this.headerFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerFileName.DefaultCellStyle = dataGridViewCellStyle15;
            this.headerFileName.HeaderText = "File Name";
            this.headerFileName.Name = "headerFileName";
            // 
            // lblBackHome
            // 
            this.lblBackHome.AutoSize = true;
            this.lblBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBackHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBackHome.ForeColor = System.Drawing.Color.White;
            this.lblBackHome.Location = new System.Drawing.Point(3, 3);
            this.lblBackHome.Name = "lblBackHome";
            this.lblBackHome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblBackHome.Size = new System.Drawing.Size(88, 23);
            this.lblBackHome.TabIndex = 1;
            this.lblBackHome.Text = "Search Again";
            this.lblBackHome.Click += new System.EventHandler(this.lblBackHome_Click);
            // 
            // frmOpenPlex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.tab);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOpenPlex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Plex";
            this.Load += new System.EventHandler(this.frmOpenPlex_Load);
            this.tab.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabSearchResults.ResumeLayout(false);
            this.tabSearchResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSearchResults;
        private CButtonLib.CButton btnSearch;
        private CButtonLib.CButton bgSearchBox;
        private ChreneLib.Controls.TextBoxes.CTextBox txtSearchBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerFileName;
        private System.Windows.Forms.Label lblBackHome;
    }
}

