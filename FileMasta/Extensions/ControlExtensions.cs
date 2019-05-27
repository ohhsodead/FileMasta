using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FileMasta.Forms;

namespace FileMasta.Extensions
{
    internal abstract class ControlExtensions
    {
        /// <summary>
        /// Shows raw text from the specified URL in a window box
        /// </summary>
        /// <param name="owner">Text to display in title</param>
        /// <param name="title">Text to display in title</param>
        /// <param name="url">URL to fetch string data from</param>
        public static void ShowDataWindow(Form owner, string title, string url)
        {
            DataViewWindow frmInfo = new DataViewWindow { Text = title };

            //using (var client = Program._webClient)
            using (Stream stream = Program.WebClient.OpenRead(url))
            using (StreamReader reader = new StreamReader(stream ?? throw new InvalidOperationException("Unable to read data")))
                frmInfo.labelData.Text = reader.ReadToEnd();

            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, owner.Height - 100);
            frmInfo.ShowDialog(owner);
        }

        /// <summary>
        /// Change button text and auto size
        /// </summary>
        /// <param name="ctrl">Control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlTextWidth(Button ctrl, string text)
        {
            ctrl.Text = text;
            Font myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            SizeF mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int)Math.Round(mySize.Width, 0) + 22;
            ctrl.Refresh();
        }

        /// <summary>
        /// Create a keyword label from template
        /// </summary>
        /// <param name="text">Most Search text/value</param>
        /// <param name="clickEvent">Most Search text/value</param>
        /// <returns></returns>
        public static Label KeywordLabel(string text, EventHandler clickEvent)
        {
            Label a = new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Verdana", 8.25F, FontStyle.Regular | FontStyle.Underline),
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Margin = new Padding(0, 0, 0, 1),
                Cursor = Cursors.Hand,
                Name = "LabelKeyword",
            };

            // Click event performs a search in main form
            a.Click += clickEvent;

            return a;
        }
    }
}