using CButtonLib;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FileMasta.Windows;

namespace FileMasta.Extensions
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
        /// Returns max size to fit button text, plus some
        /// </summary>
        /// <param name="ctrl">CButton control to measure text from</param>
        /// <returns>Int of the max size</returns>
        public static int GetPanelComboBoxWidth(CButton ctrl)
        {
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            return ((int)(Math.Round(mySize.Width, 0))) + 26;
        }

        /// <summary>
        /// Change button text and auto size
        /// </summary>
        /// <param name="ctrl">CButton control to set text</param>
        /// <param name="text">Text to set to control</param>
        public static void SetControlText(CButton ctrl, string text)
        {
            ctrl.Text = text;
            var myFont = new Font(ctrl.Font.FontFamily, ctrl.Font.Size);
            var mySize = ctrl.CreateGraphics().MeasureString(ctrl.Text, myFont);
            ctrl.Width = (((int)(Math.Round(mySize.Width, 0))) + 46);
        }

        /// <summary>
        /// Shows raw text from the specified URL in a window box
        /// </summary>
        /// <param name="Title">Text to display in title</param>
        /// <param name="URL">URL to fetch string data from</param>
        public static void ShowDataWindow(string Title, string URL)
        {
            DataWindow frmInfo = new DataWindow { Text = Title };

            var client = new WebClient();
            using (var stream = client.OpenRead(URL))
            using (var reader = new StreamReader(stream))
                frmInfo.labelData.Text = reader.ReadToEnd();

            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, MainForm.Form.Height - 100);
            frmInfo.ShowDialog(MainForm.Form);
        }

        /// <summary>
        /// Sets selected tab style to title
        /// </summary>
        /// <param name="ctrl">Tab title button to set as highlighted</param>
        public static void SelectTabTitle(CButton ctrl)
        {
            MainForm.Form.titleHome.ColorFillSolid = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleHome.BorderColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleHome.BackColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSearch.ColorFillSolid = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSearch.BorderColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSearch.BackColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleDiscover.ColorFillSolid = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleDiscover.BorderColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleDiscover.BackColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSubmit.ColorFillSolid = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSubmit.BorderColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSubmit.BackColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSettings.ColorFillSolid = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSettings.BorderColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleSettings.BackColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleInformation.ColorFillSolid = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleInformation.BorderColor = Colors.NonSelectedTitleRGB;
            MainForm.Form.titleInformation.BackColor = Colors.NonSelectedTitleRGB;

            ctrl.ColorFillSolid = Colors.SelectedTitleRGB;
            ctrl.BorderColor = Colors.SelectedTitleRGB;
            ctrl.BackColor = Colors.SelectedTitleRGB;
        }

        /// <summary>
        /// Set active file type title
        /// </summary>
        /// <param name="cbtn">Button to set Active</param>
        public static void SelectFilesTab(CButton cbtn)
        {
            MainForm.Form.buttonFilesAll.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesAll.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesVideo.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesVideo.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesAudio.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesAudio.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesBooks.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesBooks.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesSubtitles.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesSubtitles.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesTorrents.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesTorrents.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesSoftware.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesSoftware.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesCustom.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesCustom.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesOther.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesOther.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesLocal.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesLocal.BorderColor = Color.Transparent;
            MainForm.Form.buttonFilesBookmarks.ColorFillSolid = Color.Transparent;
            MainForm.Form.buttonFilesBookmarks.BorderColor = Color.Transparent;

            cbtn.ColorFillSolid = Colors.ColorOrange;
            cbtn.BorderColor = Colors.ColorOrange;
        }

        // Focus effect for Button/Combobox
        static Bitmap tmpButtonImage = null;

        public static void BtnCButton_MouseEnter(object sender, EventArgs e)
        {
            tmpButtonImage = (Bitmap)((CButton)sender).Image;
            if (((CButton)sender).Image != null) { ((CButton)sender).Image = ImageExtensions.ChangeColor((Bitmap)((CButton)sender).Image, Color.White); }
            ((CButton)sender).BorderColor = Colors.ColorOrange;
            ((CButton)sender).ForeColor = Color.White;
            ((CButton)sender).ColorFillSolid = Colors.ColorOrange;
        }

        public static void BtnCButton_MouseLeave(object sender, EventArgs e)
        {
            ((CButton)sender).Image = tmpButtonImage;
            ((CButton)sender).BorderColor = Colors.ColorOrange;
            ((CButton)sender).ForeColor = Colors.ColorOrange;
            ((CButton)sender).ColorFillSolid = Color.Transparent;
        }

        public static void ComboboxCButton_MouseEnter(object sender, EventArgs e)
        {
            ((CButton)sender).BorderColor = Colors.ColorOrange;
            ((CButton)sender).ForeColor = Color.White;
            ((CButton)sender).ColorFillSolid = Colors.ColorOrange;
        }

        public static void ComboboxCButton_MouseLeave(object sender, EventArgs e)
        {
            ((CButton)sender).BorderColor = Colors.ColorGray;
            ((CButton)sender).ForeColor = Colors.ColorGray;
            ((CButton)sender).ColorFillSolid = Color.Transparent;
        }

        // Focus effect for Social images
        static Bitmap tmpSocialImage = null;

        public static void SocialImage_MouseEnter(object sender, EventArgs e)
        {
            tmpSocialImage = (Bitmap)((PictureBox)sender).Image;
            ((PictureBox)sender).Image = ImageExtensions.ChangeColor((Bitmap)((PictureBox)sender).Image, Colors.ColorOrange);
        }

        public static void SocialImage_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = tmpSocialImage;
        }

        // Add top search item to panel
        public static CButton AddTopSearchTag(string text, int count)
        {
            var a = new CButton
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Regular),
                Size = new Size(70, 24),
                BackColor = Color.Transparent,
                ForeColor = Colors.ColorOrange,
                TextMargin = new Padding(0, 2, 0, 2),
                BorderColor = Colors.ColorOrange,
                ColorFillSolid = Color.Transparent,
                FillType = CButton.eFillType.Solid,
                TextShadowShow = false,
                ShowFocus = CButton.eFocus.None,
                Margin = new Padding(0, 3, 6, 3),
                BorderShow = true,
                DimFactorClick = 0,
                DimFactorHover = 0,
                Cursor = Cursors.Hand,
                Name = "tagItem" + count,
                Corners = new CornersProperty(2),
            };

            var myFont = new Font(a.Font.FontFamily, a.Font.Size);
            var mySize = a.CreateGraphics().MeasureString(a.Text, myFont);
            a.Width = (((int)(Math.Round(mySize.Width, 0))) + 10);
            a.ClickButtonArea += btnTopSearchesTag_ClickButtonArea;
            a.MouseEnter += BtnCButton_MouseEnter;
            a.MouseLeave += BtnCButton_MouseLeave;
            return a;
        }

        public static void btnTopSearchesTag_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            MainForm.Form.textBoxSearchHome.Text = ((CButton)Sender).Text;
            MainForm.Form.DoSearchFilesFromHome();
        }
    }
}