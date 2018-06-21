using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FileMasta.Windows;

namespace FileMasta.Extensions
{
    class ControlExtensions
    {
        /// <summary>
        /// Show Filled Control Window docked inside TabPage
        /// </summary>
        /// <param name="window">UserControl to display</param>
        public static void ShowControlWindow(UserControl window)
        {
            MainForm.Form.Controls.Add(window);
            window.Dock = DockStyle.Fill;
            window.BringToFront();
            window.Show();
            window.Focus();
        }

        /// <summary>
        /// Shows raw text from the specified URL in a window box
        /// </summary>
        /// <param name="Title">Text to display in title</param>
        /// <param name="URL">URL to fetch string data from</param>
        public static void ShowDataWindow(string Title, string URL)
        {
            DataWindow frmInfo = new DataWindow { Text = Title };

            using (var client = MainForm._webClient)
            using (var stream = client.OpenRead(URL))
            using (var reader = new StreamReader(stream))
                frmInfo.labelData.Text = reader.ReadToEnd();

            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, MainForm.Form.Height - 100);
            frmInfo.ShowDialog(MainForm.Form);
        }

        /// <summary>
        /// Gets maximum width for ComboBox dropdown to fit its contents
        /// </summary>
        /// <param name="myCombo">ComboBox to get max item length</param>
        /// <returns>Integer of max size to fit contents</returns>
        public static int GetMaxDropDownWidth(ComboBox myCombo)
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
        public static void SetControlText(Button ctrl, string text)
        {
            ctrl.Text = text;
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (((int)(Math.Round(mySize.Width, 0))) + 46);
        }

        // Add top search item to panel
        public static Label GetMostSearchTag(string text, int count)
        {
            var a = new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Regular | FontStyle.Underline),
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.DimGray,
                Margin = new Padding(0, 0, 1, 1),
                Cursor = Cursors.Hand,
                Name = "tagItem" + count,
            };

            //var myFont = new Font(a.Font.FontFamily, a.Font.Size);
            //var mySize = a.CreateGraphics().MeasureString(a.Text, myFont);
            //a.Width = (((int)(Math.Round(mySize.Width, 0))) + 13);
            a.Click += buttonMostSearches_Click;
            return a;
        }

        public static void buttonMostSearches_Click(object sender, EventArgs e)
        {
            MainForm.Form.textBoxSearchQuery.Text = ((Label)sender).Text;
            MainForm.Form.SearchFiles();
        }
    }
}