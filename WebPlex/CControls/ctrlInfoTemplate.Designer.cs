namespace WebPlex.CControls
{
    partial class ctrlInfoTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTitle = new System.Windows.Forms.Label();
            this.dataInfo = new System.Windows.Forms.Label();
            this.appClose = new System.Windows.Forms.PictureBox();
            this.panelDataItems = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.appClose)).BeginInit();
            this.panelDataItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTitle
            // 
            this.dataTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTitle.AutoEllipsis = true;
            this.dataTitle.BackColor = System.Drawing.Color.Transparent;
            this.dataTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.dataTitle.ForeColor = System.Drawing.Color.White;
            this.dataTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataTitle.Location = new System.Drawing.Point(15, 20);
            this.dataTitle.Margin = new System.Windows.Forms.Padding(0);
            this.dataTitle.Name = "dataTitle";
            this.dataTitle.Size = new System.Drawing.Size(898, 32);
            this.dataTitle.TabIndex = 100048;
            this.dataTitle.Text = "Title";
            // 
            // dataInfo
            // 
            this.dataInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInfo.AutoSize = true;
            this.dataInfo.BackColor = System.Drawing.Color.Transparent;
            this.dataInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.dataInfo.ForeColor = System.Drawing.Color.White;
            this.dataInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataInfo.Location = new System.Drawing.Point(0, 0);
            this.dataInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.Size = new System.Drawing.Size(37, 20);
            this.dataInfo.TabIndex = 100046;
            this.dataInfo.Text = "Text";
            // 
            // appClose
            // 
            this.appClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appClose.BackColor = System.Drawing.Color.Transparent;
            this.appClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appClose.Image = global::WebPlex.Properties.Resources.close;
            this.appClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.appClose.Location = new System.Drawing.Point(916, 20);
            this.appClose.Margin = new System.Windows.Forms.Padding(3, 25, 25, 3);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(32, 32);
            this.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appClose.TabIndex = 100047;
            this.appClose.TabStop = false;
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // panelDataItems
            // 
            this.panelDataItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataItems.AutoScroll = true;
            this.panelDataItems.AutoSize = true;
            this.panelDataItems.Controls.Add(this.dataInfo);
            this.panelDataItems.Location = new System.Drawing.Point(18, 80);
            this.panelDataItems.Name = "panelDataItems";
            this.panelDataItems.Size = new System.Drawing.Size(930, 469);
            this.panelDataItems.TabIndex = 100049;
            // 
            // ctrlInfoTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 16);
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelDataItems);
            this.Controls.Add(this.dataTitle);
            this.Controls.Add(this.appClose);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlInfoTemplate";
            this.Size = new System.Drawing.Size(967, 565);
            this.Load += new System.EventHandler(this.ctrlInfoTemplate_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ctrlInfoTemplate_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.appClose)).EndInit();
            this.panelDataItems.ResumeLayout(false);
            this.panelDataItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label dataTitle;
        public System.Windows.Forms.Label dataInfo;
        public System.Windows.Forms.PictureBox appClose;
        private System.Windows.Forms.FlowLayoutPanel panelDataItems;
    }
}
