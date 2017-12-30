using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Utilities;
using System.IO;
using System.Net;

namespace OpenTheatre
{
    public partial class ctrlFileDetails : UserControl
    {
        public ctrlFileDetails()
        {
            InitializeComponent();
        }
        
        private void ctrlFileDetails_Load(object sender, EventArgs e)
        {
            if (infoSize.Text == "-") { btnRequestFileSize.Visible = true; }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            frmOpenTheatre.form.tab.SelectedTab = frmOpenTheatre.form.currentTab;
            Parent.Controls.Clear();
        }

        private void btnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Process.Start(infoFileURL.Text);
        }

        private void btnCopyURL_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Clipboard.SetText(infoFileURL.Text);
            btnCopyURL.SideImage = Properties.Resources.clipboard_check_black;
            btnCopyURL.SideImageSize = new Size(22, 22);
        }

        private void btnReportFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboboxReportFile.DroppedDown = true;
        }

        private void cmboboxReportFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboboxReportFile.SelectedIndex == 0)
            {
                UtilityTools.openBrokenFileIssue(infoFileURL.Text);
            }
            else if (cmboboxReportFile.SelectedIndex == 1)
            {
                MessageBox.Show("Coming Soon.");
            }
            else if (cmboboxReportFile.SelectedIndex == 2)
            {
                UtilityTools.openPoorQualityFileIssue(infoFileURL.Text);
            }
        }

        private void btnShareFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            var a = new frmShareFile();
            a.infoFileURL = infoFileURL.Text;
            a.ShowDialog(this);
        }

        private void infoDirectory_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(infoFileURL.Text);
            string parentName = GetParentUriString(uri).Remove(GetParentUriString(uri).Length - 1);

            Process browser = new Process();

            // true is the default, but it is important not to set it to false
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = parentName;
            browser.Start();
        }

        static string GetParentUriString(Uri uri)
        {
            StringBuilder parentName = new StringBuilder();

            // Append the scheme: http, ftp etc.
            parentName.Append(uri.Scheme);

            // Appned the '://' after the http, ftp etc.
            parentName.Append("://");

            // Append the host name www.foo.com
            parentName.Append(uri.Host);

            // Append each segment except the last one. The last one is the
            // leaf and we will ignore it.
            for (int i = 0; i < uri.Segments.Length - 1; i++)
            {
                parentName.Append(uri.Segments[i]);
            }
            return parentName.ToString();
        }

        private void infoReferrer_Click(object sender, EventArgs e)
        {
            Process browser = new Process();

            // true is the default, but it is important not to set it to false
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = new Uri(infoFileURL.Text).GetLeftPart(UriPartial.Authority).ToString();
            browser.Start();
        }

        private void btnRequestFileSize_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                btnRequestFileSize.Visible = false;

                WebRequest req = WebRequest.Create(infoFileURL.Text);
                req.Method = "HEAD";
                req.Timeout = 10000;
                using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                {
                    int ContentLength;
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out ContentLength))
                    {
                        infoSize.Text = UtilityTools.ToFileSize(Convert.ToDouble(ContentLength));
                    }
                    else { infoSize.Text = "Error"; }
                }
            }
            catch { infoSize.Text = "Error"; }
        }
    }
}
