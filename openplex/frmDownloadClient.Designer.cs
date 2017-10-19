namespace OpenPlex
{
    partial class frmDownloadClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloadClient));
            this.panelDownloadItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelDownloadItems
            // 
            this.panelDownloadItems.AutoScroll = true;
            this.panelDownloadItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDownloadItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDownloadItems.Location = new System.Drawing.Point(0, 0);
            this.panelDownloadItems.Name = "panelDownloadItems";
            this.panelDownloadItems.Size = new System.Drawing.Size(642, 337);
            this.panelDownloadItems.TabIndex = 0;
            this.panelDownloadItems.WrapContents = false;
            this.panelDownloadItems.SizeChanged += new System.EventHandler(this.panelDownloadItems_SizeChanged);
            // 
            // frmDownloadClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(642, 337);
            this.Controls.Add(this.panelDownloadItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDownloadClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPlex - Downloads";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDownloadClient_FormClosing);
            this.Load += new System.EventHandler(this.frmDownloadClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDownloadItems;
    }
}