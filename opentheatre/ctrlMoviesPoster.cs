using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace OpenTheatre
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
            frmOpenTheatre.form.tabBlank.Controls.Clear();

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
                MovieDetails.imgPoster.Image = frmOpenTheatre.ChangeOpacity(frmOpenTheatre.LoadPicture(infoImagePoster), 1);
                MovieDetails.BackgroundImage = frmOpenTheatre.ChangeOpacity(frmOpenTheatre.LoadPicture(infoImageFanart), 0.2F);
            }
            catch { }

            if (infoImagePoster == "") { MovieDetails.imgPoster.Image = frmOpenTheatre.ChangeOpacity(Properties.Resources.default_poster, 1); }

            foreach (string movieLink in infoMovieLinks)
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.infoFileURL = movieLink;
                ctrlInfo.infoFileHost.Text = new Uri(movieLink).Host;
                ctrlInfo.infoFileName.Text = Path.GetFileName(new Uri(movieLink).LocalPath);
                MovieDetails.panelStreams.Controls.Add(ctrlInfo);
            }

            MovieDetails.Dock = DockStyle.Fill;
            frmOpenTheatre.form.tabBlank.Controls.Clear();
            frmOpenTheatre.form.tabBlank.Controls.Add(MovieDetails);
            frmOpenTheatre.form.tab.SelectedTab = frmOpenTheatre.form.tabBlank;
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
                infoPoster.BackgroundImage = frmOpenTheatre.ChangeOpacity(infoPoster2.Image, 0.4F);
                Update();
            }
            catch
            { //InfoPoster.BackgroundImage = frmOpenTheatre.ChangeOpacity(Properties.Resources.defaultPoster, 0.4F); 
            }
        }

        private void InfoPoster_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BorderShow = false;
                infoPoster.BackgroundImage = frmOpenTheatre.ChangeOpacity(infoPoster2.Image, 1);
            }
            catch
            { //InfoPoster.BackgroundImage = frmOpenTheatre.ChangeOpacity(Properties.Resources.defaultPoster, 1);
            }
        }

    }
}