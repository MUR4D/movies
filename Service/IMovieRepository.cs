using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Service
{
    public interface IMovieRepository
    {
         Movie GetMovieFromAPI(string title);

        void AddMovie(Movie newMovie);

        void AddtoFavorite(Movie newFavoriteMovie);

        IEnumerable<Movie> GetMovies();

    }
}
