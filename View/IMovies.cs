using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.View
{
    public interface IMovies
    {
        void UpdateMovies(IEnumerable<Movie> movies);

         string SearchTitle { get; set; }

        
    }
}
