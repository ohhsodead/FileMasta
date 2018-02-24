using CButtonLib;
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
        public static void SetControlText(CButton ctrl, string text)
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

        /// <summary>
        /// Sets selected tab style to title
        /// </summary>
        /// <param name="ctrl">Tab title button to set as highlighted</param>
        public static void SelectTabTitle(CButton ctrl)
        {
            MainForm.form.titleHome.ColorFillSolid = Colors.nonSelectedTitleRGB;
            MainForm.form.titleHome.BorderColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleHome.BackColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSearch.ColorFillSolid = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSearch.BorderColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSearch.BackColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleDiscover.ColorFillSolid = Colors.nonSelectedTitleRGB;
            MainForm.form.titleDiscover.BorderColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleDiscover.BackColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSubmit.ColorFillSolid = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSubmit.BorderColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSubmit.BackColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSettings.ColorFillSolid = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSettings.BorderColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleSettings.BackColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleInformation.ColorFillSolid = Colors.nonSelectedTitleRGB;
            MainForm.form.titleInformation.BorderColor = Colors.nonSelectedTitleRGB;
            MainForm.form.titleInformation.BackColor = Colors.nonSelectedTitleRGB;

            ctrl.ColorFillSolid = Colors.selectedTitleRGB;
            ctrl.BorderColor = Colors.selectedTitleRGB;
            ctrl.BackColor = Colors.selectedTitleRGB;
        }

        /// <summary>
        /// Sets selected file category style to title
        /// </summary>
        /// <param name="cbtn"></param>
        public static void SelectFilesTab(CButton cbtn)
        {
            MainForm.form.titleFilesAll.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesAll.BorderColor = Color.Transparent;
            MainForm.form.titleFilesVideo.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesVideo.BorderColor = Color.Transparent;
            MainForm.form.titleFilesAudio.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesAudio.BorderColor = Color.Transparent;
            MainForm.form.titleFilesBooks.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesBooks.BorderColor = Color.Transparent;
            MainForm.form.titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesSubtitles.BorderColor = Color.Transparent;
            MainForm.form.titleFilesTorrents.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesTorrents.BorderColor = Color.Transparent;
            MainForm.form.titleFilesSoftware.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesSoftware.BorderColor = Color.Transparent;
            MainForm.form.titleFilesCustom.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesCustom.BorderColor = Color.Transparent;
            MainForm.form.titleFilesOther.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesOther.BorderColor = Color.Transparent;
            MainForm.form.titleFilesLocal.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesLocal.BorderColor = Color.Transparent;
            MainForm.form.titleFilesBookmarks.ColorFillSolid = Color.Transparent;
            MainForm.form.titleFilesBookmarks.BorderColor = Color.Transparent;

            cbtn.ColorFillSolid = Colors.uiColorOrange;
            cbtn.BorderColor = Colors.uiColorOrange;
        }

        /* Focus effect for Button/Combobox */
        static Bitmap tmpButtonImage = null;

        public static void BtnCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            tmpButtonImage = (Bitmap)ctrl.Image;
            if (ctrl.Image != null) { ctrl.Image = ImageExtensions.ChangeColor((Bitmap)ctrl.Image, Color.White); }
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Color.White;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public static void BtnCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.Image = tmpButtonImage;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Colors.uiColorOrange;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        public static void ComboboxCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Color.White;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public static void ComboboxCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorGray;
            ctrl.ForeColor = Colors.uiColorGray;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        // Focus effect for Social images
        static Bitmap tmpSocialImage = null;

        public static void SocialImage_MouseEnter(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox;
            tmpSocialImage = (Bitmap)ctrl.Image;
            ctrl.Image = ImageExtensions.ChangeColor((Bitmap)ctrl.Image, Colors.uiColorOrange);
        }

        public static void SocialImage_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox; ctrl.Image = tmpSocialImage;
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
                ForeColor = Colors.uiColorOrange,
                TextMargin = new Padding(0, 2, 0, 2),
                BorderColor = Colors.uiColorOrange,
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
            var tagItem = Sender as CButton;
            MainForm.form.txtSearchFilesHome.Text = tagItem.Text;
            MainForm.form.DoSearchFilesFromHome();
        }
    }
}
