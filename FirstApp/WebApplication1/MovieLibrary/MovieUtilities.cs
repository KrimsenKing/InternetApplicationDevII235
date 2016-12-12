using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieUtilities
    {
        public List<Movies> SelectAll()
        {
            MovieData md = new MovieData();
            return md.getMovies();
        }

        public void UpdateMovie(int id, string title, string director, string description)
        {
            Movies MovieToUpdate = new Movies(id, title, director, description);
            MovieData mu = new MovieData();
            mu.MovieUpdate(MovieToUpdate);
        }

        public void UpdateCategories(int id, string name, int position)
        {
            Categories CategoryToUpdate = new Categories(id, name, position);
            MovieData mu = new MovieData();
            mu.CategoryUpdate(CategoryToUpdate);
        }
    }
}
