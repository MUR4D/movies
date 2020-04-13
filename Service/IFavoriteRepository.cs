using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Service
{
   public interface IFavoriteRepository
    {
        void AddToFavorites(Movie movie);

        IEnumerable<Movie> GetFavorites();
    }
}
