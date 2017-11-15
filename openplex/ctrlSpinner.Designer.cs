namespace OpenPlex
{
    partial class ctrlSpinner
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
            this.imageSpinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSpinner
            // 
            this.imageSpinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageSpinner.BackColor = System.Drawing.Color.Transparent;
            this.imageSpinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSpinner.Image = global::OpenPlex.Properties.Resources.spinner;
            this.imageSpinner.Location = new System.Drawing.Point(90, 90);
            this.imageSpinner.Name = "imageSpinner";
            this.imageSpinner.Size = new System.Drawing.Size(20, 20);
            this.imageSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSpinner.TabIndex = 13;
            this.imageSpinner.TabStop = false;
            this.imageSpinner.Visible = false;
            // 
            // ctrlSpinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.imageSpinner);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlSpinner";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.imageSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageSpinner;
    }
}
