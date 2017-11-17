using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenTheatre
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
            VLCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathMPCCodec64) || File.Exists(frmOpenTheatre.pathMPC64) || File.Exists(frmOpenTheatre.pathMPC86);
        }

        private void btnPlay_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            contextFileName.Show(btnWatchNow, btnWatchNow.PointToClient(Cursor.Position));
        }

        private void btnDownload_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            frmOpenTheatre.form.Show();
            frmOpenTheatre.form.doDownloadFile(infoFileURL);
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
                VLC.StartInfo.FileName = frmOpenTheatre.pathVLC;
                VLC.StartInfo.Arguments = ("-vvv " + infoFileURL);
                VLC.Start();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process MPC = new Process();
                if (File.Exists(frmOpenTheatre.pathMPCCodec64))
                    MPC.StartInfo.FileName = frmOpenTheatre.pathMPCCodec64;
                else if (File.Exists(frmOpenTheatre.pathMPC64))
                    MPC.StartInfo.FileName = frmOpenTheatre.pathMPC64;
                else
                    MPC.StartInfo.FileName = frmOpenTheatre.pathMPC86;
                MPC.StartInfo.Arguments = (infoFileURL);
                MPC.Start();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void btnReportBroken_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            openBrokenFileIssue(infoFileURL);
        }

        public void openBrokenFileIssue(string webFile)
        {
            Process.Start("https://github.com/invu/OpenTheatre-app/issues/new?title=" + "Found Broken File" +
                "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "File Name: " + new Uri(webFile).LocalPath);
        }

    }
}