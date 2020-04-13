using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Presenter;

namespace WindowsFormsApp3.View.UserControls
{
    public partial class FavoritesView : UserControl,IFavorites
    {
        public FavoritesPresenter Presenter { get; set; }
        public FavoritesView()
        {
            InitializeComponent();
        
            
        }

        public void UpdateFavorites(IEnumerable<Movie> favorites)
        {
            favoritesList.Items.Clear();
            favoritesList.Items.AddRange(favorites.ToArray());
        }

        private void favoritesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
