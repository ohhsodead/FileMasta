using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebPlex.CControls
{
    public partial class ctrlMoviePoster : UserControl
    {
        public ctrlMoviePoster()
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

        public string[] infoMovieFiles;

        public string infoYifyTorrent480p;
        public string infoYifyTorrent720p;
        public string infoYifyTorrent1080p;

        public string infoPopcornTorrent720p;
        public string infoPopcornTorrent1080p;

        private void ctrlMoviePoster_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            if (infoPoster.BackgroundImage == null) { infoPoster.BackgroundImage = Properties.Resources.poster_default; }
        }

        private void InfoPoster_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            frmWebPlex.form.tabBlank.Controls.Clear();

            ctrlMovieDetails MovieDetails = new ctrlMovieDetails();

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
            MovieDetails.infoTrailerUrl = infoTrailer;
            MovieDetails.infoFanartUrl = infoImageFanart;
            MovieDetails.infoImagePoster = infoImagePoster;

            try
            {
                MovieDetails.imgPoster.Image = Utilities.ChangeOpacity(Utilities.LoadPicture(infoImagePoster), 1);
                MovieDetails.BackgroundImage = Utilities.ChangeOpacity(Utilities.LoadPicture(infoImageFanart), 0.2F);
            }
            catch { }

            foreach (string movieLink in infoMovieFiles)
            {
                MovieDetails.AddStream(movieLink, false, false, MovieDetails.panelFiles);
            }

            if (infoYifyTorrent480p != null && infoYifyTorrent480p != "")
            {
                MovieDetails.AddStream(infoYifyTorrent480p, false, true, MovieDetails.panelTorrents, "YIFY", "480p");
            }

            if (infoYifyTorrent720p != null && infoYifyTorrent720p != "")
            {
                MovieDetails.AddStream(infoYifyTorrent720p, false, true, MovieDetails.panelTorrents, "YIFY", "720p");
            }

            if (infoYifyTorrent1080p != null && infoYifyTorrent1080p != "")
            {
                MovieDetails.AddStream(infoYifyTorrent1080p, false, true, MovieDetails.panelTorrents, "YIFY", "1080p");
            }

            if (infoPopcornTorrent720p != null && infoPopcornTorrent720p != "")
            {
                MovieDetails.AddStream(infoPopcornTorrent720p, false, true, MovieDetails.panelTorrents, "POPCORN", "720p");
            }

            if (infoPopcornTorrent1080p != null && infoPopcornTorrent1080p != "")
            {
                MovieDetails.AddStream(infoPopcornTorrent1080p, false, true, MovieDetails.panelTorrents, "POPCORN", "1080p");
            }

            MovieDetails.Dock = DockStyle.Fill;
            frmWebPlex.form.tabBlank.Controls.Clear();
            frmWebPlex.form.tabBlank.Controls.Add(MovieDetails);
            frmWebPlex.form.tab.SelectedTab = frmWebPlex.form.tabBlank;
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
                infoPoster.BackgroundImage = Utilities.ChangeOpacity(infoPoster2.Image, 0.4F);
                Update();
            }
            catch
            {
                infoPoster.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.poster_default, 0.4F); 
            }
        }

        private void InfoPoster_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BorderShow = false;
                infoPoster.BackgroundImage = Utilities.ChangeOpacity(infoPoster2.Image, 1);
            }
            catch
            {
                infoPoster.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.poster_default, 1);
            }
        }

    }
}