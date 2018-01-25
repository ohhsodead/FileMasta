using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using WebCrunch;
using Utilities;
using WebCrunch.UserControls;

namespace UserControls
{
    public partial class MovieDetails : UserControl
    {
        public MovieDetails()
        {
            InitializeComponent();

            panelStreams.Size = new Size(panelDetails.Size.Width, panelStreams.Size.Height);
        }

        public string ImdbId = "";
        public string PosterURL = "";
        public string FanartURL = "";
        public string TrailerURL = "";

        private void ctrlMovieDetails_Load(object sender, EventArgs e)
        {
            if (TrailerURL == "") { btnWatchTrailer.Visible = false; }
            if (PosterURL == "") { imgPoster.Image = UtilityTools.SetAlpha (WebCrunch.Properties.Resources.poster_default, 255); }
            panelTitleFiles.Size = new Size(panelDetails.Size.Width, panelTitleFiles.Size.Height);
            panelStreams.Size = new Size(panelDetails.Size.Width, panelStreams.Size.Height);

            foreach (Control ctrl in panelStreams.Controls)
            {
                ctrl.Size = new Size(panelDetails.Size.Width - 3, ctrl.Size.Height);
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            MainForm.form.tab.SelectedTab = MainForm.form.currentTab;
            Parent.Controls.Clear();
        }

        private void imgIMDb_Click(object sender, EventArgs e)
        {
            Process.Start("www.imdb.com/title/" + ImdbId);
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
            Process.Start(TrailerURL);
        }

        private void imgSearchForMore_Click(object sender, EventArgs e)
        {
            string noSymbolsTitle = Regex.Replace(infoTitle.Text, "[^A-Za-z0-9 _]", " ");
            string ifYearExists = ""; if (infoYear.Text != "Year") { ifYearExists = " " + infoYear.Text; }
            MainForm.form.txtSearchFiles.Text = noSymbolsTitle + ifYearExists;
            MainForm.form.showFiles(MainForm.selectedFiles);
            MainForm.form.tab.SelectedTab = MainForm.form.tabFiles;
            Parent.Controls.Clear();
        }

        public void AddStream(Models.Stream stream, bool local, Panel toPanel)
        {
            StreamInfo ctrlInfo = new StreamInfo
            {
                infoFileURL = stream.URL,
            };

            if (stream.Size != "-") { ctrlInfo.infoSize.Text = UtilityTools.bytesToString(Convert.ToInt32(stream.Size)); } else { ctrlInfo.infoSize.Text = stream.Size; }
            if (stream.DateUploaded != "-") { ctrlInfo.infoAge.Text = UtilityTools.getTimeAgo(Convert.ToDateTime(stream.DateUploaded)); } else { ctrlInfo.infoAge.Text = stream.DateUploaded; }
            ctrlInfo.infoName.Text = stream.Name;
            toPanel.Controls.Add(ctrlInfo);
        }
    }
}
