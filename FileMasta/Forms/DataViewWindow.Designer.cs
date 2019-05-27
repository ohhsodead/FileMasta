namespace FileMasta.Forms
{
    partial class DataViewWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewWindow));
            this.panelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.labelData = new System.Windows.Forms.Label();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItems
            // 
            this.panelItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItems.AutoSize = true;
            this.panelItems.Controls.Add(this.labelData);
            this.panelItems.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.panelItems.Location = new System.Drawing.Point(14, 12);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(436, 56);
            this.panelItems.TabIndex = 0;
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelData.Location = new System.Drawing.Point(0, 0);
            this.labelData.Margin = new System.Windows.Forms.Padding(0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(35, 14);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Text";
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(464, 81);
            this.Controls.Add(this.panelItems);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 40);
            this.Name = "DataWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataDialog_Scroll);
            this.panelItems.ResumeLayout(false);
            this.panelItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelItems;
        public System.Windows.Forms.Label labelData;
    }
}