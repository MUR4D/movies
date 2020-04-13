using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Service;
using WindowsFormsApp3.View;

namespace WindowsFormsApp3.Presenter
{
   public class MoviePresenter
    {
        public IMovies View { get; set; }

        public IMovieRepository Repository { get; set; }

        
        public MoviePresenter(IMovies view,IMovieRepository repository)
        {
            View = view;
            Repository = repository;

            View.UpdateMovies(Repository.GetMovies());
        }

        public void GetMovie(string title)
        {
           Movie movie= Repository.GetMovieFromAPI(title);
            Repository.AddMovie(movie);
            View.UpdateMovies(Repository.GetMovies());
        }

        public void toFavorites(Movie movie)
        {
            Repository.AddtoFavorite(movie);
        }
    }
}
