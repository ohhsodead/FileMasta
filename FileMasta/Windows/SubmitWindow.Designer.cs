namespace FileMasta.Windows
{
    partial class SubmitWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitWindow));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxWebsite = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSubmit.Location = new System.Drawing.Point(310, 11);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(50, 24);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxWebsite.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWebsite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWebsite.Location = new System.Drawing.Point(12, 12);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(292, 22);
            this.textBoxWebsite.TabIndex = 9;
            this.textBoxWebsite.WaterMark = "Enter your website...";
            this.textBoxWebsite.WaterMarkActiveForeColor = System.Drawing.Color.White;
            this.textBoxWebsite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.textBoxWebsite.WaterMarkForeColor = System.Drawing.Color.DimGray;
            // 
            // SubmitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 46);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxWebsite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubmitWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Submit Website";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        public ChreneLib.Controls.TextBoxes.CTextBox textBoxWebsite;
    }
}