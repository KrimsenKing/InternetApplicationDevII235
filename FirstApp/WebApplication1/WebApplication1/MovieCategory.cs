using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebApplication1
{
    public class MovieCategory
    {
        public string connectionString;
        public int ID { get; set; }
        public string Name { get; set; }

        public MovieCategory()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["dbMovies2ConnectionString"].ConnectionString;
        }
        public MovieCategory(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}