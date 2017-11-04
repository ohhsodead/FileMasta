using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace OpenPlex
{
    public partial class ctrlStreamInfo : UserControl
    {
        public ctrlStreamInfo()
        {
            InitializeComponent();
        }

        public string infoFileURL;

        private void ctrlStreamInfo_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            VLCToolStripMenuItem.Visible = File.Exists(frmOpenPlex.pathVLC);
        }

        private void btnPlay_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            contextFileName.Show(btnPlay, btnPlay.PointToClient(Cursor.Position));
        }

        private void btnDownload_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            frmOpenPlex.form.Show();
            frmOpenPlex.form.doDownloadFile(infoFileURL);
        }

        private void WMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("wmplayer.exe", infoFileURL);
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process VLC = new Process();
                VLC.StartInfo.FileName = frmOpenPlex.pathVLC;
                VLC.StartInfo.Arguments = ("-vvv " + infoFileURL);
                VLC.Start();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void btnReportBroken_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            openBrokenFileIssue(infoFileURL);
        }

        public void openBrokenFileIssue(string webFile)
        {
            Process.Start("https://github.com/invu/openplex-app/issues/new?title=" + "Found Broken File" +
                "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "File Name: " + Path.GetFileName(webFile).Replace("%20", ""));
        }
    }
}
