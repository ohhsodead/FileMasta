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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorInfo));
            this.titleStatus = new System.Windows.Forms.Label();
            this.btnRestart = new Controls.CtrlButton();
            this.SuspendLayout();
            // 
            // titleStatus
            // 
            resources.ApplyResources(this.titleStatus, "titleStatus");
            this.titleStatus.BackColor = System.Drawing.Color.Transparent;
            this.titleStatus.ForeColor = System.Drawing.Color.Silver;
            this.titleStatus.Name = "titleStatus";
            // 
            // btnRestart
            // 
            resources.ApplyResources(this.btnRestart, "btnRestart");
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
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(26)))));
            this.btnRestart.ImageIndex = 0;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnRestart.TextShadowShow = false;
            this.btnRestart.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnRestart_ClickButtonArea);
            // 
            // ErrorInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.titleStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ErrorInfo";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label titleStatus;
        public CtrlButton btnRestart;
    }
}
