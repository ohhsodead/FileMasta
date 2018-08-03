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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServersWindow));
            this.DataGridServers = new System.Windows.Forms.DataGridView();
            this.labelTitleDiscover = new System.Windows.Forms.Label();
            this.ContextMenuServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuFileZilla = new System.Windows.Forms.ToolStripMenuItem();
            this.columnDiscoverNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverHostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiscoverURI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServers)).BeginInit();
            this.ContextMenuServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridServers
            // 
            this.DataGridServers.AllowUserToAddRows = false;
            this.DataGridServers.AllowUserToDeleteRows = false;
            this.DataGridServers.AllowUserToResizeColumns = false;
            this.DataGridServers.AllowUserToResizeRows = false;
            this.DataGridServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridServers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridServers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridServers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridServers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridServers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDiscoverNo,
            this.columnDiscoverHostname,
            this.columnDiscoverProtocol,
            this.columnDiscoverURI});
            this.DataGridServers.ContextMenuStrip = this.ContextMenuServer;
            this.DataGridServers.EnableHeadersVisualStyles = false;
            this.DataGridServers.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridServers.Location = new System.Drawing.Point(0, 37);
            this.DataGridServers.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.DataGridServers.MultiSelect = false;
            this.DataGridServers.Name = "DataGridServers";
            this.DataGridServers.ReadOnly = true;
            this.DataGridServers.RowHeadersVisible = false;
            this.DataGridServers.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridServers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridServers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.DataGridServers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DataGridServers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridServers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DataGridServers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridServers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridServers.RowTemplate.Height = 24;
            this.DataGridServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridServers.ShowEditingIcon = false;
            this.DataGridServers.Size = new System.Drawing.Size(494, 415);
            this.DataGridServers.TabIndex = 1;
            this.DataGridServers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridServers_CellDoubleClick);
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
            this.labelTitleDiscover.Size = new System.Drawing.Size(250, 20);
            this.labelTitleDiscover.TabIndex = 3;
            this.labelTitleDiscover.Text = "Every Server Crawled by FileMasta.";
            this.labelTitleDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContextMenuServer
            // 
            this.ContextMenuServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileZilla});
            this.ContextMenuServer.Name = "contextMenuFileItem";
            this.ContextMenuServer.Size = new System.Drawing.Size(115, 26);
            // 
            // MenuFileZilla
            // 
            this.MenuFileZilla.Name = "MenuFileZilla";
            this.MenuFileZilla.Size = new System.Drawing.Size(114, 22);
            this.MenuFileZilla.Text = "FileZilla";
            this.MenuFileZilla.Click += new System.EventHandler(this.MenuFileZilla_Click);
            // 
            // columnDiscoverNo
            // 
            this.columnDiscoverNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnDiscoverNo.HeaderText = "No.";
            this.columnDiscoverNo.Name = "columnDiscoverNo";
            this.columnDiscoverNo.ReadOnly = true;
            this.columnDiscoverNo.Width = 58;
            // 
            // columnDiscoverHostname
            // 
            this.columnDiscoverHostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDiscoverHostname.HeaderText = "Hostname";
            this.columnDiscoverHostname.Name = "columnDiscoverHostname";
            this.columnDiscoverHostname.ReadOnly = true;
            // 
            // columnDiscoverProtocol
            // 
            this.columnDiscoverProtocol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnDiscoverProtocol.HeaderText = "Protocol";
            this.columnDiscoverProtocol.Name = "columnDiscoverProtocol";
            this.columnDiscoverProtocol.ReadOnly = true;
            this.columnDiscoverProtocol.Width = 83;
            // 
            // columnDiscoverURI
            // 
            this.columnDiscoverURI.HeaderText = "URL";
            this.columnDiscoverURI.Name = "columnDiscoverURI";
            this.columnDiscoverURI.ReadOnly = true;
            this.columnDiscoverURI.Visible = false;
            // 
            // ServersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 452);
            this.Controls.Add(this.DataGridServers);
            this.Controls.Add(this.labelTitleDiscover);
            this.DoubleBuffered = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServers)).EndInit();
            this.ContextMenuServer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridServers;
        public System.Windows.Forms.Label labelTitleDiscover;
        private System.Windows.Forms.ContextMenuStrip ContextMenuServer;
        private System.Windows.Forms.ToolStripMenuItem MenuFileZilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverHostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiscoverURI;
    }
}