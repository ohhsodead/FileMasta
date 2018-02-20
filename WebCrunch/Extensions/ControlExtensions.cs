using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WebCrunch.Dialogs;

namespace WebCrunch.Extensions
{
    class ControlExtensions
    {
        /// <summary>
        /// Gets maximum width for ComboBox dropdown to fit its contents
        /// </summary>
        /// <param name="myCombo">ComboBox to get max item length</param>
        /// <returns>Integer of max size to fit contents</returns>
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
        /// <param name="ctrl">CButton control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlText(CButtonLib.CButton ctrl, string text)
        {
            ctrl.Text = text;
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (((int)(Math.Round(mySize.Width, 0))) + 46);
        }

        /// <summary>
        /// Shows raw text from the specified URL in a dialog box
        /// </summary>
        /// <param name="URL">URL to fetch string from</param>
        /// <param name="Title">Text to display in title bar</param>
        public static void ShowTextFromURL(string URL, string Title)
        {
            DataWindow frmInfo = new DataWindow { Text = Title };

            WebClient client = new WebClient();
            using (var stream = client.OpenRead(URL))
            using (var reader = new StreamReader(stream))
                frmInfo.dataInfo.Text = reader.ReadToEnd();

            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, MainForm.form.Height - 100);
            frmInfo.ShowDialog(MainForm.form);
        }
    }
}
