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

namespace OpenTheatre
{
    public partial class ctrlDetails : UserControl
    {
        public ctrlDetails()
        {
            InitializeComponent();
        }

        public string infoImdbId = "";
        public string infoFanartUrl = "";
        public string infoTrailerUrl = "";

        private void ctrlMovieDetails_Load(object sender, EventArgs e)
        {
            if (infoFanartUrl == "") { BackColor = Color.Transparent; }
            if (infoTrailerUrl == "") { btnWatchTrailer.Visible = false; } 
            panelSubHeaders.Size = new Size(panelDetails.Size.Width, panelSubHeaders.Size.Height);
            panelStreams.Size = new Size(panelDetails.Size.Width, panelStreams.Size.Height);

            foreach (Control ctrl in panelStreams.Controls)
            {
                ctrl.Size = new Size(panelStreams.Size.Width - 5, ctrl.Size.Height);
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
            panelStreams.Size = new Size(panelDetails.Size.Width, panelStreams.Size.Height);

            foreach (Control ctrl in panelStreams.Controls)
            {
                ctrl.Size = new Size(panelStreams.Size.Width - 5, ctrl.Size.Height);
            }
        }

        private void btnWatchTrailer_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            var a = new frmVLCPlayer();
            a.Text = "Trailer: " + infoTitle.Text + " (" + infoYear.Text + ")";
            a.axVLCPlugin21.playlist.add(infoTrailerUrl);
            a.axVLCPlugin21.playlist.play();
            a.Show();
        }
    }
}
