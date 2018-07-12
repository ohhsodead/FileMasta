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
            this.DataGridDiscover = new System.Windows.Forms.DataGridView();
            this.labelTitleDiscover = new System.Windows.Forms.Label();
            this.columnDiscoverCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDiscover)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridDiscover
            // 
            this.DataGridDiscover.AllowUserToAddRows = false;
            this.DataGridDiscover.AllowUserToDeleteRows = false;
            this.DataGridDiscover.AllowUserToResizeColumns = false;
            this.DataGridDiscover.AllowUserToResizeRows = false;
            this.DataGridDiscover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridDiscover.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridDiscover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDiscover.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridDiscover.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridDiscover.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDiscover.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDiscover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDiscover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDiscoverCount,
            this.columnDiscoverServer,
            this.columnDiscoverType,
            this.columnDiscoverURL});
            this.DataGridDiscover.EnableHeadersVisualStyles = false;
            this.DataGridDiscover.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridDiscover.Location = new System.Drawing.Point(0, 37);
            this.DataGridDiscover.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.DataGridDiscover.MultiSelect = false;
            this.DataGridDiscover.Name = "DataGridDiscover";
            this.DataGridDiscover.ReadOnly = true;
            this.DataGridDiscover.RowHeadersVisible = false;
            this.DataGridDiscover.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridDiscover.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridDiscover.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridDiscover.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DataGridDiscover.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridDiscover.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataGridDiscover.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridDiscover.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridDiscover.RowTemplate.Height = 24;
            this.DataGridDiscover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridDiscover.ShowEditingIcon = false;
            this.DataGridDiscover.Size = new System.Drawing.Size(424, 413);
            this.DataGridDiscover.TabIndex = 1;
            this.DataGridDiscover.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDiscover_CellClick);
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
            this.labelTitleDiscover.Size = new System.Drawing.Size(275, 20);
            this.labelTitleDiscover.TabIndex = 3;
            this.labelTitleDiscover.Text = "Every FTP server crawled by FileMasta.";
            this.labelTitleDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnDiscoverCount
            // 
            this.columnDiscoverCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.columnDiscoverCount.HeaderText = "Count";
            this.columnDiscoverCount.Name = "columnDiscoverCount";
            this.columnDiscoverCount.ReadOnly = true;
            this.columnDiscoverCount.Width = 5;
            // 
            // columnDiscoverServer
            // 
            this.columnDiscoverServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDiscoverServer.HeaderText = "Server";
            this.columnDiscoverServer.Name = "columnDiscoverServer";
            this.columnDiscoverServer.ReadOnly = true;
            // 
            // columnDiscoverType
            // 
            this.columnDiscoverType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnDiscoverType.HeaderText = "Type";
            this.columnDiscoverType.Name = "columnDiscoverType";
            this.columnDiscoverType.ReadOnly = true;
            this.columnDiscoverType.Width = 56;
            // 
            // columnDiscoverURL
            // 
            this.columnDiscoverURL.HeaderText = "URL";
            this.columnDiscoverURL.Name = "columnDiscoverURL";
            this.columnDiscoverURL.ReadOnly = true;
            this.columnDiscoverURL.Visible = false;
            // 
            // ServersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.DataGridDiscover);
            this.Controls.Add(this.labelTitleDiscover);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServersWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server List";
            this.Load += new System.EventHandler(this.ServersWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDiscover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridDiscover;
        public System.Windows.Forms.Label labelTitleDiscover;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverURL;
    }
}