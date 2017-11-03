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

            ClientSize = new Size(Parent.ClientSize.Width - 120, ClientSize.Height);
        }

        private void btnPlay_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            contextFileName.Show(btnPlay, btnPlay.PointToClient(Cursor.Position));
        }

        private void btnDownload_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (!frmOpenPlex.form.frmClient.Visible)
            {
                frmOpenPlex.form.frmClient.Show();
                frmOpenPlex.form.frmClient.doDownloadFile(infoFileURL);
            }
            else
            {
                frmOpenPlex.form.frmClient.doDownloadFile(infoFileURL);
                frmOpenPlex.form.frmClient.Focus();
            }
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
    }
}
