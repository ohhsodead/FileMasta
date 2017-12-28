namespace OpenTheatre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlStatus));
            this.components = new System.ComponentModel.Container();
            this.titleStatus = new System.Windows.Forms.Label();
            this.btnRestartApp = new CButtonLib.CButton();
            this.SuspendLayout();
            // 
            // titleStatus
            // 
            resources.ApplyResources(this.titleStatus, "titleStatus");
            this.titleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleStatus.BackColor = System.Drawing.Color.Transparent;
            this.titleStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.titleStatus.ForeColor = System.Drawing.Color.Silver;
            this.titleStatus.Location = new System.Drawing.Point(60, 0);
            this.titleStatus.Name = "titleStatus";
            this.titleStatus.Size = new System.Drawing.Size(341, 155);
            this.titleStatus.TabIndex = 0;
            this.titleStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnRestartApp
            // 
            resources.ApplyResources(this.btnRestartApp, "btnRestartApp");
            this.btnRestartApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnRestartApp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnRestartApp.ImageIndex = 0;
            this.btnRestartApp.Location = new System.Drawing.Point(181, 208);
            this.btnRestartApp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnRestartApp.Name = "btnRestartApp";
            this.btnRestartApp.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnRestartApp.Size = new System.Drawing.Size(98, 34);
            this.btnRestartApp.TabIndex = 9;
            this.btnRestartApp.TextShadowShow = false;
            this.btnRestartApp.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnRestartApp_ClickButtonArea);
            // 
            // ctrlStatus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnRestartApp);
            this.Controls.Add(this.titleStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStatus";
            this.Size = new System.Drawing.Size(460, 361);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label titleStatus;
        private CButtonLib.CButton btnRestartApp;
    }
}
