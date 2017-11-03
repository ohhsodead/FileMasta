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

namespace OpenPlex
{
    public partial class ctrlDetails : UserControl
    {
        public ctrlDetails()
        {
            InitializeComponent();
        }

        public string infoImdbId;
        public string infoFanartUrl;
        public string infoTrailerUrl;

        private void ctrlMovieDetails_Load(object sender, EventArgs e)
        {
            if (infoFanartUrl == "") { BackColor = Color.Transparent; }
            panelSubHeaders.Size = new Size(panelDetails.Size.Width, panelSubHeaders.Size.Height);           
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            frmOpenPlex.form.tab.SelectedTab = frmOpenPlex.form.currentTab;
            Parent.Controls.Clear();
        }

        private void imgIMDb_Click(object sender, EventArgs e)
        {
            Process.Start("www.imdb.com/title/" + infoImdbId);
        }
    }
}
