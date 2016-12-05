using System;
using System.Collections.Generic;
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
    }
}
