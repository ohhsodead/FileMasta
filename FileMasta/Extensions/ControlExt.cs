using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FileMasta.Forms;

namespace FileMasta.Extensions
{
    class ControlExt
    {
        /// <summary>
        /// Show Filled Control Window docked inside TabPage
        /// </summary>
        /// <param name="window">UserControl to display</param>
        public static void ShowControlWindow(UserControl window)
        {
            MainForm.Form.Controls.Add(window);
            window.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            window.Location = new Point(0, 0);
            window.Size = MainForm.Form.ClientSize;
            window.BringToFront();
            window.Show();
            window.Focus();
        }

        /// <summary>
        /// Shows raw text from the specified URL in a window box
        /// </summary>
        /// <param name="title">Text to display in title</param>
        /// <param name="url">URL to fetch string data from</param>
        public static void ShowDataWindow(string title, string url)
        {
            DataDialog frmInfo = new DataDialog { Text = title };

            //using (var client = Program._webClient)
            using (var stream = Program._webClient.OpenRead(url))
            using (var reader = new StreamReader(stream))
                frmInfo.labelData.Text = reader.ReadToEnd();

            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, MainForm.Form.Height - 100);
            frmInfo.ShowDialog(MainForm.Form);
        }

        /// <summary>
        /// Change button text and auto size
        /// </summary>
        /// <param name="ctrl">Control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlTextWidth(Button ctrl, string text)
        {
            ctrl.Text = text;
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (int)Math.Round(mySize.Width, 0) + 22;
            ctrl.Refresh();
        }

        /// <summary>
        /// Create a keyword label from template
        /// </summary>
        /// <param name="text">Most Search text/value</param>
        /// <param name="count">Number of the control, used for naming</param>
        /// <returns></returns>
        public static Label LabelKeyword(string text, int count)
        {
            var a = new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Verdana", 8.25F, FontStyle.Regular | FontStyle.Underline),
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Margin = new Padding(0, 0, 0, 1),
                Cursor = Cursors.Hand,
                Name = "MostSearch" + count,
            };

            // Click event performs a search in main form
            a.Click += delegate
            {
                MainForm.Form.TextboxSearchName.Text = a.Text;
                MainForm.Form.SearchFiles();
            };

            return a;
        }
    }
}