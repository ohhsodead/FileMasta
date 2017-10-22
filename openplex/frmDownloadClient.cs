using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenPlex
{
    public partial class frmDownloadClient : Form
    {
        public frmDownloadClient()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) { }

        private void frmDownloadClient_Load(object sender, EventArgs e)
        {
            BackgroundImage = frmOpenPlex.ChangeOpacity(Properties.Resources.Dark_Sky_Night, 0.4F);

            panelDownloadItems.SuspendLayout();
            foreach (Control ctrl in panelDownloadItems.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = panelDownloadItems.ClientSize.Width;
            }
            panelDownloadItems.ResumeLayout();
        }

        public void doDownloadFile(string url)
        {
            ctrlDownloadItem ctrlItem = new ctrlDownloadItem();
            ctrlItem.lblPercentage.Text = "Connecting...";
            ctrlItem.Width = panelDownloadItems.ClientSize.Width - 7;
            panelDownloadItems.Controls.Add(ctrlItem);
            ctrlItem.doDownloadFile(url);
        }

        private void panelDownloadItems_SizeChanged(object sender, EventArgs e)
        {
            panelDownloadItems.SuspendLayout();
            foreach (Control ctrl in panelDownloadItems.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = panelDownloadItems.ClientSize.Width - 7;
            }
            panelDownloadItems.ResumeLayout();
        }

        private void frmDownloadClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            panelDownloadItems.Controls.Clear();
            Hide();
            e.Cancel = true;
        }

        private void panelDownloadItems_ControlAdded(object sender, ControlEventArgs e)
        {
            if (panelDownloadItems.Controls.Count == 0) lblNoDownloads.Visible = true;
            else lblNoDownloads.Visible = false;
        }

        private void panelDownloadItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (panelDownloadItems.Controls.Count == 0) lblNoDownloads.Visible = true;
            else lblNoDownloads.Visible = false;
        }

        private void frmDownloadClient_Enter(object sender, EventArgs e)
        {
            panelDownloadItems.SuspendLayout();
            foreach (Control ctrl in panelDownloadItems.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = panelDownloadItems.ClientSize.Width - 7;
            }
            panelDownloadItems.ResumeLayout();
        }

        private void panelDownloadItems_Scroll(object sender, ScrollEventArgs e)
        {
            panelDownloadItems.Refresh();
        }
    }
}
