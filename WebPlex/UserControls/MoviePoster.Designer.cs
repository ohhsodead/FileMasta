namespace WebPlex.CControls
{
    partial class MoviePoster
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
            this.components = new System.ComponentModel.Container();
            this.infoPoster = new CButtonLib.CButton();
            this.infoSearches = new System.Windows.Forms.RichTextBox();
            this.infoYear = new System.Windows.Forms.Label();
            this.infoTitle = new System.Windows.Forms.Label();
            this.infoPoster2 = new CButtonLib.CButton();
            this.imageBackgroundEffect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBackgroundEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPoster
            // 
            this.infoPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infoPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPoster.BorderColor = System.Drawing.Color.Transparent;
            this.infoPoster.BorderShow = false;
            this.infoPoster.ColorFillSolid = System.Drawing.Color.Transparent;
            this.infoPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoPoster.DesignerSelected = false;
            this.infoPoster.DimFactorClick = 0;
            this.infoPoster.DimFactorHover = 0;
            this.infoPoster.FillType = CButtonLib.CButton.eFillType.Solid;
            this.infoPoster.ForeColor = System.Drawing.Color.DarkGray;
            this.infoPoster.ImageIndex = 0;
            this.infoPoster.Location = new System.Drawing.Point(7, 8);
            this.infoPoster.Name = "infoPoster";
            this.infoPoster.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.infoPoster.Size = new System.Drawing.Size(140, 202);
            this.infoPoster.TabIndex = 72;
            this.infoPoster.TabStop = false;
            this.infoPoster.Text = "";
            this.infoPoster.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.InfoPoster_ClickButtonArea);
            this.infoPoster.MouseEnter += new System.EventHandler(this.InfoPoster_MouseEnter);
            this.infoPoster.MouseLeave += new System.EventHandler(this.InfoPoster_MouseLeave);
            // 
            // infoSearches
            // 
            this.infoSearches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoSearches.Location = new System.Drawing.Point(26, 22);
            this.infoSearches.Name = "infoSearches";
            this.infoSearches.Size = new System.Drawing.Size(15, 13);
            this.infoSearches.TabIndex = 68;
            this.infoSearches.Text = "";
            this.infoSearches.Visible = false;
            // 
            // infoYear
            // 
            this.infoYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoYear.AutoSize = true;
            this.infoYear.BackColor = System.Drawing.Color.Transparent;
            this.infoYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infoYear.ForeColor = System.Drawing.Color.DarkGray;
            this.infoYear.Location = new System.Drawing.Point(7, 240);
            this.infoYear.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.infoYear.Name = "infoYear";
            this.infoYear.Size = new System.Drawing.Size(29, 15);
            this.infoYear.TabIndex = 62;
            this.infoYear.Text = "Year";
            // 
            // infoTitle
            // 
            this.infoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoTitle.AutoEllipsis = true;
            this.infoTitle.BackColor = System.Drawing.Color.Transparent;
            this.infoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.infoTitle.ForeColor = System.Drawing.Color.White;
            this.infoTitle.Location = new System.Drawing.Point(6, 219);
            this.infoTitle.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(145, 20);
            this.infoTitle.TabIndex = 89;
            this.infoTitle.Text = "Title";
            // 
            // infoPoster2
            // 
            this.infoPoster2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPoster2.BackColor = System.Drawing.Color.Transparent;
            this.infoPoster2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPoster2.BorderColor = System.Drawing.Color.Black;
            this.infoPoster2.BorderShow = false;
            this.infoPoster2.ColorFillSolid = System.Drawing.Color.Transparent;
            this.infoPoster2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoPoster2.DesignerSelected = false;
            this.infoPoster2.DimFactorClick = 0;
            this.infoPoster2.DimFactorHover = 0;
            this.infoPoster2.FillType = CButtonLib.CButton.eFillType.Solid;
            this.infoPoster2.ForeColor = System.Drawing.Color.DarkGray;
            this.infoPoster2.ImageIndex = 0;
            this.infoPoster2.Location = new System.Drawing.Point(8, 8);
            this.infoPoster2.Name = "infoPoster2";
            this.infoPoster2.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.infoPoster2.Size = new System.Drawing.Size(138, 200);
            this.infoPoster2.TabIndex = 74;
            this.infoPoster2.TabStop = false;
            this.infoPoster2.Text = "";
            // 
            // imageBackgroundEffect
            // 
            this.imageBackgroundEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBackgroundEffect.Image = global::WebPlex.Properties.Resources.poster_glow;
            this.imageBackgroundEffect.Location = new System.Drawing.Point(-1, -2);
            this.imageBackgroundEffect.Name = "imageBackgroundEffect";
            this.imageBackgroundEffect.Size = new System.Drawing.Size(157, 220);
            this.imageBackgroundEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBackgroundEffect.TabIndex = 75;
            this.imageBackgroundEffect.TabStop = false;
            // 
            // MoviePoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.infoTitle);
            this.Controls.Add(this.infoPoster);
            this.Controls.Add(this.infoSearches);
            this.Controls.Add(this.infoYear);
            this.Controls.Add(this.infoPoster2);
            this.Controls.Add(this.imageBackgroundEffect);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.Name = "MoviePoster";
            this.Size = new System.Drawing.Size(155, 260);
            this.Load += new System.EventHandler(this.ctrlMoviePoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBackgroundEffect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CButtonLib.CButton infoPoster;
        internal System.Windows.Forms.RichTextBox infoSearches;
        internal System.Windows.Forms.Label infoYear;
        internal System.Windows.Forms.PictureBox imageBackgroundEffect;
        internal System.Windows.Forms.Label infoTitle;
        public CButtonLib.CButton infoPoster2;
    }
}
