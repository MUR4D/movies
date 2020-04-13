using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Presenter;
using WindowsFormsApp3.View.UserControls;

namespace WindowsFormsApp3.View
{
    public partial class fMain : Form,IMovies
    {
        public MoviePresenter Presenter { get; set; }

       

        public FavoritesPresenter FavoritesPresenter { get; set; }
       

        public fMain()
        {
            InitializeComponent();
           
            
        }

        public string SearchTitle { get => searchBox.Text; set => searchBox.Text=value; }
        public void UpdateMovies(IEnumerable<Movie> movies)
        {
            moviesList.Items.Clear();
            moviesList.Items.AddRange(movies.ToArray());

        }

     

       

        private void tofavoritesButton_Click(object sender, EventArgs e)
        {
            var newToFavorites = moviesList.SelectedItem as Movie;
            FavoritesPresenter.AddToFavorites(newToFavorites);
        }

        private void Favorites_Click(object sender, EventArgs e)
        {
           
            favoritesView1.Show();
            favoritesView1.BringToFront();
           
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            Presenter.GetMovie(searchBox.Text);
        }

        private void moviesList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            var selectedMovie = moviesList.SelectedItem as Movie;
            moviePoster.ImageLocation = selectedMovie.Poster;
        }

        private void favoritesView1_Load(object sender, EventArgs e)
        {
           
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            favoritesView1.Hide();

        }

        private void Laters_Click(object sender, EventArgs e)
        {
            
        }
    }
}
