using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Utilities;
using WebCrunch;

namespace UserControls
{
    public partial class MoviePoster : UserControl
    {
        public MoviePoster()
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
            if (infoPoster.BackgroundImage == null) { infoPoster.BackgroundImage = WebCrunch.Properties.Resources.poster_default; }
        }

        private void InfoPoster_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            MainForm.form.tabBlank.Controls.Clear();

            MovieDetails MovieDetails = new MovieDetails();

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
                if (infoImagePoster != "") { MovieDetails.imgPoster.Image = UtilityTools.SetAlpha(UtilityTools.LoadPicture(infoImagePoster), 255); }
                if (infoImageFanart != "") { MovieDetails.BackgroundImage = UtilityTools.SetAlpha(UtilityTools.LoadPicture(infoImageFanart), 50); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n\n" + infoImageFanart); }

            foreach (var movieLink in infoMovieStreams)
            {
                MovieDetails.AddStream(movieLink, false, MovieDetails.panelStreams);
            }

            MovieDetails.Dock = DockStyle.Fill;
            MainForm.form.tabBlank.Controls.Clear();
            MainForm.form.tabBlank.Controls.Add(MovieDetails);
            MainForm.form.tab.SelectedTab = MainForm.form.tabBlank;
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
                infoPoster.BackgroundImage = UtilityTools.SetAlpha((Bitmap)infoPoster2.Image, 100);
                Update();
            }
            catch
            {
                infoPoster.BackgroundImage = UtilityTools.SetAlpha(WebCrunch.Properties.Resources.poster_default, 255); 
            }
        }

        private void InfoPoster_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BackgroundImage = UtilityTools.SetAlpha((Bitmap)infoPoster2.Image, 255);
            }
            catch
            {
                infoPoster.BackgroundImage = UtilityTools.SetAlpha(WebCrunch.Properties.Resources.poster_default, 255);
            }
        }

    }
}