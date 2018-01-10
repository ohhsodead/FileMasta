namespace WebPlex.CControls
{
    partial class ctrlStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlStatus));
            this.titleStatus = new System.Windows.Forms.Label();
            this.btnRestartApp = new CButtonLib.CButton();
            this.SuspendLayout();
            // 
            // titleStatus
            // 
            resources.ApplyResources(this.titleStatus, "titleStatus");
            this.titleStatus.BackColor = System.Drawing.Color.Transparent;
            this.titleStatus.ForeColor = System.Drawing.Color.Silver;
            this.titleStatus.Name = "titleStatus";
            // 
            // btnRestartApp
            // 
            resources.ApplyResources(this.btnRestartApp, "btnRestartApp");
            this.btnRestartApp.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartApp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnRestartApp.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnRestartApp.Corners.All = 2;
            this.btnRestartApp.Corners.LowerLeft = 2;
            this.btnRestartApp.Corners.LowerRight = 2;
            this.btnRestartApp.Corners.UpperLeft = 2;
            this.btnRestartApp.Corners.UpperRight = 2;
            this.btnRestartApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartApp.DesignerSelected = false;
            this.btnRestartApp.DimFactorClick = 0;
            this.btnRestartApp.DimFactorHover = 0;
            this.btnRestartApp.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnRestartApp.ImageIndex = 0;
            this.btnRestartApp.Name = "btnRestartApp";
            this.btnRestartApp.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnRestartApp.TextShadowShow = false;
            this.btnRestartApp.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnRestartApp_ClickButtonArea);
            // 
            // ctrlStatus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnRestartApp);
            this.Controls.Add(this.titleStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStatus";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label titleStatus;
        public CButtonLib.CButton btnRestartApp;
    }
}
