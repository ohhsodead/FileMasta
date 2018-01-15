namespace WebPlex
{
    partial class frmDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataView));
            this.panelDataItems = new System.Windows.Forms.FlowLayoutPanel();
            this.dataInfo = new System.Windows.Forms.Label();
            this.panelDataItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataItems
            // 
            this.panelDataItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataItems.AutoSize = true;
            this.panelDataItems.Controls.Add(this.dataInfo);
            this.panelDataItems.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.panelDataItems.Location = new System.Drawing.Point(12, 12);
            this.panelDataItems.Name = "panelDataItems";
            this.panelDataItems.Size = new System.Drawing.Size(460, 85);
            this.panelDataItems.TabIndex = 100052;
            // 
            // dataInfo
            // 
            this.dataInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInfo.AutoSize = true;
            this.dataInfo.BackColor = System.Drawing.Color.Transparent;
            this.dataInfo.ForeColor = System.Drawing.Color.Black;
            this.dataInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataInfo.Location = new System.Drawing.Point(0, 0);
            this.dataInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.Size = new System.Drawing.Size(31, 17);
            this.dataInfo.TabIndex = 100046;
            this.dataInfo.Text = "Text";
            // 
            // frmDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 110);
            this.Controls.Add(this.panelDataItems);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "frmDataView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.panelDataItems.ResumeLayout(false);
            this.panelDataItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDataItems;
        public System.Windows.Forms.Label dataInfo;
    }
}