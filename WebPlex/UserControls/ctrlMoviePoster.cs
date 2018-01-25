using System;
using System.Collections.Generic;
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

        protected override void OnPaint(PaintEventArgs e) { }

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

        public List<Models.Stream> infoMovieStreams = new List<Models.Stream>();

        private void ctrlMoviePoster_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            if (infoPoster.BackgroundImage == null) { infoPoster.BackgroundImage = Properties.Resources.poster_default; }
        }

        private void InfoPoster_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Main.form.tabBlank.Controls.Clear();

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
            MovieDetails.ImdbId = infoImdbId;
            MovieDetails.TrailerURL = infoTrailer;
            MovieDetails.FanartURL = infoImageFanart;
            MovieDetails.PosterURL = infoImagePoster;

            try
            {
                if (infoImagePoster != "") { MovieDetails.imgPoster.Image = Utilities.ChangeOpacity(Utilities.LoadPicture(infoImagePoster), 1); }
                if (infoImageFanart != "") { MovieDetails.BackgroundImage = Utilities.ChangeOpacity(Utilities.LoadPicture(infoImageFanart), 0.2F); }
            }
            catch { }

            foreach (var movieLink in infoMovieStreams)
            {
                MovieDetails.AddStream(movieLink, false, MovieDetails.panelFiles);
            }

            MovieDetails.Dock = DockStyle.Fill;
            Main.form.tabBlank.Controls.Clear();
            Main.form.tabBlank.Controls.Add(MovieDetails);
            Main.form.tab.SelectedTab = Main.form.tabBlank;
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
                infoPoster.BackgroundImage = Utilities.ChangeOpacity(infoPoster2.Image, 1);
            }
            catch
            {
                infoPoster.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.poster_default, 1);
            }
        }

    }
}