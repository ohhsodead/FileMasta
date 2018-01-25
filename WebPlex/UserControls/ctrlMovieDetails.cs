using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

namespace WebPlex.CControls
{
    public partial class ctrlMovieDetails : UserControl
    {
        public ctrlMovieDetails()
        {
            InitializeComponent();

            panelFiles.Size = new Size(panelDetails.Size.Width, panelFiles.Size.Height);
        }

        public string ImdbId { get; set; }
        public string PosterURL { get; set; }
        public string FanartURL { get; set; }
        public string TrailerURL { get; set; }

        private void ctrlMovieDetails_Load(object sender, EventArgs e)
        {
            if (TrailerURL == "") { btnWatchTrailer.Visible = false; }
            imgPoster.Image = Utilities.ChangeOpacity(Properties.Resources.poster_default, 1); panelTitleFiles.Size = new Size(panelDetails.Size.Width, panelTitleFiles.Size.Height);
            panelFiles.Size = new Size(panelDetails.Size.Width, panelFiles.Size.Height);

            foreach (Control ctrl in panelFiles.Controls)
            {
                ctrl.Size = new Size(panelDetails.Size.Width - 3, ctrl.Size.Height);
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            Main.form.tab.SelectedTab = Main.form.currentTab;
            Parent.Controls.Clear();
        }

        private void imgIMDb_Click(object sender, EventArgs e)
        {
            Process.Start("www.imdb.com/title/" + ImdbId);
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
            Process.Start(TrailerURL);
        }

        private void imgSearchForMore_Click(object sender, EventArgs e)
        {
            string noSymbolsTitle = Regex.Replace(infoTitle.Text, "[^A-Za-z0-9 _]", " ");
            string ifYearExists = ""; if (infoYear.Text != "Year") { ifYearExists = " " + infoYear.Text; }
            Main.form.txtSearchFiles.Text = noSymbolsTitle + ifYearExists;
            Main.form.showFiles(Main.selectedFiles);
            Main.form.tab.SelectedTab = Main.form.tabFiles;
            Parent.Controls.Clear();
        }

        public void AddStream(Models.Stream stream, bool local, Panel toPanel)
        {
            ctrlStreamInfo ctrlInfo = new ctrlStreamInfo
            {
                infoFileURL = stream.URL,
            };

            if (stream.Size != "-") { ctrlInfo.infoSize.Text = Utilities.bytesToString(Convert.ToInt32(stream.Size)); } else { ctrlInfo.infoSize.Text = stream.Size; }
            if (stream.DateUploaded != "-") { ctrlInfo.infoAge.Text = Utilities.getTimeAgo(Convert.ToDateTime(stream.DateUploaded)); } else { ctrlInfo.infoAge.Text = stream.DateUploaded; }
            ctrlInfo.infoSize.Text = stream.Size;
            toPanel.Controls.Add(ctrlInfo);
        }
    }
}
