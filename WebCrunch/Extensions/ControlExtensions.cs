using System;
using System.Drawing;
using System.Windows.Forms;

namespace Extensions
{
    class ControlExtensions
    {
        /// <summary>
        /// Gets maximum width for ComboBox dropdown to fit its contents
        /// </summary>
        /// <param name="myCombo"></param>
        /// <returns></returns>
        public static int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items) {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                    maxWidth = temp;                
            }
            return maxWidth;
        }

        /// <summary>
        /// Change button text and auto size
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetControlText(CButtonLib.CButton ctrl, string text)
        {
            ctrl.Text = text;
            Font myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            SizeF mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (((int)(Math.Round(mySize.Width, 0))) + 46);
        }
    }
}
