using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Service;
using WindowsFormsApp3.View.UserControls;

namespace WindowsFormsApp3.Presenter
{
    public class FavoritesPresenter
    {
        public IFavorites Favorites { get; set; }

        public IFavoriteRepository FavoriteRepository { get; set; }

        public IMovieRepository Repository { get; set; }

        public FavoritesPresenter(IFavorites favorites,IFavoriteRepository favoriteRepository)
        {
            Favorites = favorites;
            FavoriteRepository = favoriteRepository;
            Favorites.UpdateFavorites(FavoriteRepository.GetFavorites());
        }

        public void AddToFavorites(Movie newFavoriteMovie)
        {
            FavoriteRepository.AddToFavorites(newFavoriteMovie);
            Favorites.UpdateFavorites(FavoriteRepository.GetFavorites());
        }

    }
}
