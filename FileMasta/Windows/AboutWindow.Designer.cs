namespace FileMasta.Windows
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.labelAboutApp = new System.Windows.Forms.Label();
            this.labelMadeWithLove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAboutApp
            // 
            this.labelAboutApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAboutApp.AutoEllipsis = true;
            this.labelAboutApp.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAboutApp.Location = new System.Drawing.Point(12, 9);
            this.labelAboutApp.Name = "labelAboutApp";
            this.labelAboutApp.Size = new System.Drawing.Size(416, 351);
            this.labelAboutApp.TabIndex = 1;
            this.labelAboutApp.Text = resources.GetString("labelAboutApp.Text");
            this.labelAboutApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMadeWithLove
            // 
            this.labelMadeWithLove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMadeWithLove.AutoSize = true;
            this.labelMadeWithLove.BackColor = System.Drawing.Color.Transparent;
            this.labelMadeWithLove.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMadeWithLove.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.labelMadeWithLove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMadeWithLove.Location = new System.Drawing.Point(74, 362);
            this.labelMadeWithLove.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelMadeWithLove.Name = "labelMadeWithLove";
            this.labelMadeWithLove.Size = new System.Drawing.Size(293, 19);
            this.labelMadeWithLove.TabIndex = 16;
            this.labelMadeWithLove.Text = "Made with ❤ by geeks from around the world";
            this.labelMadeWithLove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 413);
            this.Controls.Add(this.labelMadeWithLove);
            this.Controls.Add(this.labelAboutApp);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAboutApp;
        private System.Windows.Forms.Label labelMadeWithLove;
    }
}