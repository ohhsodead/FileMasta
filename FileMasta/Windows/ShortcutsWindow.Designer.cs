namespace FileMasta.Windows
{
    partial class ShortcutsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortcutsWindow));
            this.textShortcuts = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textShortcuts
            // 
            this.textShortcuts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textShortcuts.Location = new System.Drawing.Point(12, 12);
            this.textShortcuts.Name = "textShortcuts";
            this.textShortcuts.ReadOnly = true;
            this.textShortcuts.Size = new System.Drawing.Size(358, 156);
            this.textShortcuts.TabIndex = 0;
            this.textShortcuts.Text = resources.GetString("textShortcuts.Text");
            // 
            // ShortcutsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 180);
            this.Controls.Add(this.textShortcuts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortcutsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keyboard Shortcuts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textShortcuts;
    }
}