using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Presenter;
using WindowsFormsApp3.Service;
using WindowsFormsApp3.View;
using WindowsFormsApp3.View.UserControls;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var movieRepository = new MovieRepository();
            var movieView = new fMain();
            var moviePresenter = new MoviePresenter(movieView,movieRepository);
            var favoriteRepository = new FavoritesRepository();
            var favoriteView = new FavoritesView();
            var favoritePresenter = new FavoritesPresenter(favoriteView, favoriteRepository);
            movieView.Presenter = moviePresenter;
            moviePresenter.View = movieView;
            movieView.FavoritesPresenter = favoritePresenter;
            favoritePresenter.Favorites = favoriteView;
            favoriteView.Presenter=favoritePresenter;
            Application.Run(movieView);
        }
    }
}
