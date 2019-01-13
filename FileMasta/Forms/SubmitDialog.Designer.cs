namespace FileMasta.Forms
{
    partial class SubmitDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitDialog));
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.TextBoxServer = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SuspendLayout();
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSubmit.Location = new System.Drawing.Point(286, 11);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(50, 24);
            this.ButtonSubmit.TabIndex = 1;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // TextBoxServer
            // 
            this.TextBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxServer.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxServer.Location = new System.Drawing.Point(12, 12);
            this.TextBoxServer.Name = "TextBoxServer";
            this.TextBoxServer.Size = new System.Drawing.Size(268, 22);
            this.TextBoxServer.TabIndex = 0;
            this.TextBoxServer.WaterMark = "e.g. 192.0.1.28:80@anonymous:password";
            this.TextBoxServer.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.TextBoxServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextBoxServer.WaterMarkForeColor = System.Drawing.Color.DimGray;
            // 
            // SubmitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 46);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextBoxServer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubmitWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Submit Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSubmit;
        public ChreneLib.Controls.TextBoxes.CTextBox TextBoxServer;
    }
}