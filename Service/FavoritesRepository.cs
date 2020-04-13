using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Service
{
   public class FavoritesRepository:IFavoriteRepository
    {
       public List<Movie> Favorites { get; set; }

        public FavoritesRepository()
        {
            Favorites = new List<Movie>()
            {
                new Movie{Title="test1"},
                new Movie{Title="test2"}
            };
        }

        
        public IEnumerable<Movie> GetFavorites()
        {
            return Favorites;
        }

        public void AddToFavorites(Movie movie)
        {
            Favorites.Add(movie);
        }
    }
}
