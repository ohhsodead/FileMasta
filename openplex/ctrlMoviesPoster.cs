using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CButtonLib;
using System.Net;
using System.Web.Script.Serialization;
using PopcornTimeAPI;
using System.IO;

namespace OpenPlex
{

    public partial class ctrlMoviesPoster : UserControl
    {
        public ctrlMoviesPoster()
        {
            InitializeComponent();
        }

        public string infoGenres;
        public string infoSynopsis;
        public string infoRuntime;
        public string infoRated;
        public string infoDirector;
        public string infoCast;
        public string infoImdbId;
        public string infoImdbRating;
        public string infoImagePoster;
        public string infoImageFanart;
        public string infoTrailer;

        public string[] infoMovieLinks;

        private void ctrlPosterTitle_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void InfoPoster_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            frmOpenPlex.form.tabBlank.Controls.Clear();

            ctrlDetails MovieDetails = new ctrlDetails();

            MovieDetails.infoTitle.Text = infoTitle.Text;
            MovieDetails.infoYear.Text = infoYear.Text;
            MovieDetails.infoGenre.Text = infoGenres;
            MovieDetails.infoSynopsis.Text = infoSynopsis;
            MovieDetails.infoRuntime.Text = infoRuntime;
            MovieDetails.infoRated.Text = infoRated;
            MovieDetails.infoDirector.Text = infoDirector;
            MovieDetails.infoCast.Text = infoCast;
            MovieDetails.infoRatingIMDb.Text = infoImdbRating;
            MovieDetails.infoImdbId = infoImdbId;

            try
            {
                MovieDetails.imgPoster.Image = frmOpenPlex.ChangeOpacity(frmOpenPlex.LoadPicture(infoImagePoster), 1);
                MovieDetails.BackgroundImage = frmOpenPlex.ChangeOpacity(frmOpenPlex.LoadPicture(infoImageFanart), 0.2F);
            }
            catch { }

            if (infoImagePoster == "") { MovieDetails.imgPoster.Image = frmOpenPlex.ChangeOpacity(Properties.Resources.PosterDefault, 1); }

            foreach (string movieLink in infoMovieLinks)
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.infoFileURL = movieLink;
                ctrlInfo.infoFileHost.Text = new Uri(movieLink).Host;
                ctrlInfo.infoFileName.Text = Path.GetFileName(movieLink);
                MovieDetails.panelStreams.Controls.Add(ctrlInfo);
            }

            MovieDetails.Dock = DockStyle.Fill;
            frmOpenPlex.form.tabBlank.Controls.Clear();
            frmOpenPlex.form.tabBlank.Controls.Add(MovieDetails);
            frmOpenPlex.form.tab.SelectedTab = frmOpenPlex.form.tabBlank;
        }

        private void InfoPoster_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (!(infoPoster2.Image == null))
                {
                    infoPoster2.Image.Dispose();
                }

                infoPoster2.Image = new Bitmap(infoPoster.BackgroundImage);
                infoPoster.BorderShow = true;
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BackgroundImage = frmOpenPlex.ChangeOpacity(infoPoster2.Image, 0.4F);
                Update();
            }
            catch
            { //InfoPoster.BackgroundImage = frmOpenPlex.ChangeOpacity(Properties.Resources.defaultPoster, 0.4F); 
            }
        }

        private void InfoPoster_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BorderShow = false;
                infoPoster.BackgroundImage = frmOpenPlex.ChangeOpacity(infoPoster2.Image, 1);
            }
            catch
            { //InfoPoster.BackgroundImage = frmOpenPlex.ChangeOpacity(Properties.Resources.defaultPoster, 1);
            }
        }

    }
}