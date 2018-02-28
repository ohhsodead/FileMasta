using System;
using System.Drawing;
using System.Windows.Forms;
using CButtonLib;

namespace FileMasta.Controls
{
    public partial class buttonFileType : CButton
    {
        private static Font _normalFont = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        public buttonFileType() : base()
        {
            base.Font = _normalFont;
            base.BackColor = Color.Transparent;
            base.ForeColor = Color.White;
            base.Cursor = Cursors.Hand;
            base.MaximumSize = new Size(1000, 27);
            base.MinimumSize = new Size(0, 27);
            Size = new Size(30, 27);
            TextAlign = ContentAlignment.MiddleCenter;
            Corners = new CornersProperty(0, 0, 2, 2);
            TextMargin = new Padding(2, 2, 2, 2);
            BorderColor = Color.Transparent;
            ColorFillSolid = Color.Transparent;
            FillType = eFillType.Solid;
            TextShadowShow = false;
            ShowFocus = eFocus.None;
            Margin = new Padding(0, 3, 0, 0);
            BorderShow = true;
            DimFactorClick = 0;
            DimFactorHover = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int increaseBy = 20;
            if (Image != null) { increaseBy = 40; }
            Font myFont = _normalFont;
            SizeF mySize = base.CreateGraphics().MeasureString(base.Text, myFont);
            base.Width = (((int)(Math.Round(mySize.Width, 0))) + increaseBy);
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }
    }
}
