using CButtonLib;
using System;
using System.Drawing;
using System.Windows.Forms;
using FileMasta.Extensions;

namespace FileMasta.Controls
{
    public partial class buttonTabTitle : CButton
    {
        private static Font _normalFont = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        public buttonTabTitle() : base()
        {
            base.Font = _normalFont;
            base.BackColor = Colors.NonSelectedTitleRGB;
            base.ForeColor = Color.White;
            base.Cursor = Cursors.Hand;
            base.MaximumSize = new Size(1000, 34);
            base.MinimumSize = new Size(0, 34);
            Size = new Size(34, 34);
            TextAlign = ContentAlignment.MiddleCenter;
            Corners = new CornersProperty(2);
            TextMargin = new Padding(2, 2, 2, 2);
            BorderColor = Colors.NonSelectedTitleRGB;
            ColorFillSolid = Colors.NonSelectedTitleRGB;
            FillType = eFillType.Solid;
            TextShadowShow = false;
            ShowFocus = eFocus.None;
            Margin = new Padding(3,3,3,3);
            BorderShow = true;
            DimFactorClick = 0;
            DimFactorHover = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int increaseBy = 40;
            Font myFont = _normalFont;
            SizeF mySize = base.CreateGraphics().MeasureString(base.Text, myFont);
            base.Width = (((int)(Math.Round(mySize.Width, 0))) + increaseBy);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }

        Bitmap tmpButtonImage = null;
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            tmpButtonImage = (Bitmap)base.Image;
            base.Image = ImageExtensions.ChangeColor(tmpButtonImage, Colors.ColorOrange);

            base.ColorFillSolid = Colors.SelectedTitleRGB;
            base.BackColor = Colors.SelectedTitleRGB;
            base.BorderColor = Colors.SelectedTitleRGB;

            base.ForeColor = Colors.ColorOrange;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (MainForm.Form.CurrentTabTitle == this)
            {
                base.Image = tmpButtonImage;
                base.ForeColor = Color.White;

                base.ColorFillSolid = Colors.SelectedTitleRGB;
                base.BackColor = Colors.SelectedTitleRGB;
                base.BorderColor = Colors.SelectedTitleRGB;
            }
            else
            {
                base.Image = tmpButtonImage;
                base.ForeColor = Color.White;

                base.ColorFillSolid = Color.Transparent;
                base.BackColor = Color.Transparent;
                base.BorderColor = Color.Transparent;
            }
        }
    }
}
