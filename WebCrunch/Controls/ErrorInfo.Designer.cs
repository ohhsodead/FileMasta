namespace Controls
{
    partial class ErrorInfo
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
            this.titleStatus = new System.Windows.Forms.Label();
            this.btnRestart = new Controls.CtrlButton();
            this.SuspendLayout();
            // 
            // titleStatus
            // 
            this.titleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleStatus.BackColor = System.Drawing.Color.Transparent;
            this.titleStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.titleStatus.ForeColor = System.Drawing.Color.Silver;
            this.titleStatus.Location = new System.Drawing.Point(60, 0);
            this.titleStatus.Name = "titleStatus";
            this.titleStatus.Size = new System.Drawing.Size(341, 155);
            this.titleStatus.TabIndex = 0;
            this.titleStatus.Text = "Unable to connect to the the Internet";
            this.titleStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.btnRestart.ColorFillSolid = System.Drawing.Color.Transparent;
            this.btnRestart.Corners.All = 2;
            this.btnRestart.Corners.LowerLeft = 2;
            this.btnRestart.Corners.LowerRight = 2;
            this.btnRestart.Corners.UpperLeft = 2;
            this.btnRestart.Corners.UpperRight = 2;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.DesignerSelected = false;
            this.btnRestart.DimFactorClick = 0;
            this.btnRestart.DimFactorHover = 0;
            this.btnRestart.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.btnRestart.ImageIndex = 0;
            this.btnRestart.Location = new System.Drawing.Point(197, 208);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.btnRestart.MaximumSize = new System.Drawing.Size(1000, 30);
            this.btnRestart.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnRestart.Size = new System.Drawing.Size(66, 30);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.TextShadowShow = false;
            this.btnRestart.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnRestart_ClickButtonArea);
            // 
            // ErrorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.titleStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ErrorInfo";
            this.Size = new System.Drawing.Size(460, 361);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label titleStatus;
        public CtrlButton btnRestart;
    }
}
