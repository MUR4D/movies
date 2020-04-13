using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Service
{
   public class MovieRepository:IMovieRepository
    {
        public List<Movie> movies { get; set; }

        public FavoritesRepository FavoritesRepository { get; set; }

        private WebClient webClient;

        public MovieRepository()
        {
            movies = new List<Movie>()
            {
                new Movie{Title="test"},
                new Movie{Title="test2"}
            };
        }
       

        public Movie GetMovieFromAPI(string title)
        {
            webClient = new WebClient();
           var result= webClient.DownloadString($"http://www.omdbapi.com/?apikey=4760f926&t={title}");
            dynamic json=JsonConvert.DeserializeObject<Movie>(result);

            return json;
        }

        public void AddMovie(Movie newMovie)
        {
            movies.Add(newMovie);
        }

      

        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        public void AddtoFavorite(Movie newFavoriteMovie)
        {
            FavoritesRepository.Favorites.Add(newFavoriteMovie);
        }
    }
}
