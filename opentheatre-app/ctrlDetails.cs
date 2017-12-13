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
using UnhandledExceptions;

namespace OpenTheatre
{
    public partial class ctrlDetails : UserControl
    {
        public ctrlDetails()
        {
            InitializeComponent();

            panelFiles.Size = new Size(panelDetails.Size.Width, panelFiles.Size.Height);

            panelTorrents.Size = new Size(panelDetails.Size.Width, panelTorrents.Size.Height);
        }

        public string infoImdbId = "";
        public string infoFanartUrl = "";
        public string infoTrailerUrl = "";

        private void ctrlMovieDetails_Load(object sender, EventArgs e)
        {
            if (infoFanartUrl == "") { BackColor = Color.Transparent; }
            if (infoTrailerUrl == "") { btnWatchTrailer.Visible = false; }
            panelTitleFiles.Size = new Size(panelDetails.Size.Width, panelTitleFiles.Size.Height);
            panelTitleTorrents.Size = new Size(panelDetails.Size.Width, panelTitleTorrents.Size.Height);
            panelFiles.Size = new Size(panelDetails.Size.Width, panelFiles.Size.Height);

            foreach (Control ctrl in panelFiles.Controls)
            {
                ctrl.Size = new Size(panelDetails.Size.Width - 3, ctrl.Size.Height);
            }

            panelTorrents.Size = new Size(panelDetails.Size.Width, panelTorrents.Size.Height);

            foreach (Control ctrl in panelTorrents.Controls)
            {
                ctrl.Size = new Size(panelDetails.Size.Width - 3, ctrl.Size.Height);
            }

        }

        private void appClose_Click(object sender, EventArgs e)
        {
            frmOpenTheatre.form.tab.SelectedTab = frmOpenTheatre.form.currentTab;
            Parent.Controls.Clear();
        }

        private void imgIMDb_Click(object sender, EventArgs e)
        {
            Process.Start("www.imdb.com/title/" + infoImdbId);
        }

        private void ctrlDetails_SizeChanged(object sender, EventArgs e)
        {
            panelFiles.Size = new Size(panelDetails.Size.Width, panelFiles.Size.Height);

            foreach (Control ctrl in panelFiles.Controls)
            {
                ctrl.Size = new Size(panelFiles.Size.Width - 5, ctrl.Size.Height);
            }
        }

        private void btnWatchTrailer_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Process.Start(infoTrailerUrl);
        }
    }
}
