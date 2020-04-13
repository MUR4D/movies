using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.View.UserControls
{
   public interface IFavorites
    {
        void UpdateFavorites(IEnumerable<Movie> favorites);

    }
}
