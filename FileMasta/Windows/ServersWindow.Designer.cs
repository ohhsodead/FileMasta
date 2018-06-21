namespace FileMasta.Windows
{
    partial class ServersWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServersWindow));
            this.dataGridDiscover = new System.Windows.Forms.DataGridView();
            this.columnDiscoverCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitleDiscover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscover)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridDiscover.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridDiscover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDiscover.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridDiscover.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridDiscover.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDiscover.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDiscover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiscover.ColumnHeadersVisible = false;
            this.dataGridDiscover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDiscoverCount,
            this.columnDiscoverSite,
            this.columnDiscoverType,
            this.columnDiscoverURL});
            this.dataGridDiscover.EnableHeadersVisualStyles = false;
            this.dataGridDiscover.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridDiscover.Location = new System.Drawing.Point(0, 37);
            this.dataGridDiscover.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGridDiscover.MultiSelect = false;
            this.dataGridDiscover.Name = "dataGridDiscover";
            this.dataGridDiscover.ReadOnly = true;
            this.dataGridDiscover.RowHeadersVisible = false;
            this.dataGridDiscover.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridDiscover.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridDiscover.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDiscover.RowTemplate.Height = 30;
            this.dataGridDiscover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDiscover.ShowEditingIcon = false;
            this.dataGridDiscover.Size = new System.Drawing.Size(424, 413);
            this.dataGridDiscover.TabIndex = 1;
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
            // labelTitleDiscover
            // 
            this.labelTitleDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleDiscover.AutoEllipsis = true;
            this.labelTitleDiscover.AutoSize = true;
            this.labelTitleDiscover.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleDiscover.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleDiscover.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitleDiscover.Location = new System.Drawing.Point(9, 9);
            this.labelTitleDiscover.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleDiscover.Name = "labelTitleDiscover";
            this.labelTitleDiscover.Size = new System.Drawing.Size(312, 20);
            this.labelTitleDiscover.TabIndex = 3;
            this.labelTitleDiscover.Text = "Every website/domain crawled by FileMasta.";
            this.labelTitleDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.dataGridDiscover);
            this.Controls.Add(this.labelTitleDiscover);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WebServers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Servers List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDiscover;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverURL;
        public System.Windows.Forms.Label labelTitleDiscover;
    }
}