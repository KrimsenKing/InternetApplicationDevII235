using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieLibrary
{
    class MovieData
    {
        public string connectionString;

        public MovieData()
        {
            connectionString = Connections.ConnectionString();
        }

        public SqlDataReader getMoviesUsingReader()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand("Select ID, Title, Director, Description from Movies");

            cmd.Connection = con;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;

        }
        public List<Movies> getMovies()
        {
            List<Movies> movies = new List<Movies>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand("Select ID, Title, Director, Description From Movies");

            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                movies.Add(new Movies(Convert.ToInt32(reader["id"].ToString()), reader["Title"].ToString(), reader["Director"].ToString(), reader["Description"].ToString()));
            }
            con.Close();
            return movies;
        }

        //public List<MovieCategory> getMovieCategories()
        //{
        //    List<MovieCategory> movies = new List<MovieCategory>();
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = connectionString;
        //    SqlCommand cmd = new SqlCommand("Select ID, Name From MovieCategories");
        //    cmd.Connection = con;
        //    con.Open();
        //    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //    while (reader.Read())
        //    {
        //        movies.Add(new MovieCategory(Convert.ToInt32(reader["id"].ToString()), reader["Name"].ToString()));
        //    }
        //    con.Close();
        //    return movies;
        //}

        public SqlDataReader getMoviesBycatID(int catID)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand("Select ID, Title, Director, Description From Movies Where CategoryID=@catID");

            cmd.Parameters.AddWithValue("catID", catID);
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public void updateMovie(int id, string title, string director, string description)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand("Update Movies set Title=@Title, Director=@Director, Description=@Description Where ID=@Id");
            cmd.Parameters.AddWithValue("Title", title);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("Description", description);
            cmd.Parameters.AddWithValue("Director", director);

            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteMovie(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand("Delete from Movies Where ID=@id");
            cmd.Parameters.AddWithValue("id", id);

            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void insertMovie(int id, string title, string director, string description)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand("Insert into Movies set Title=@Title, Director=@Director, Description=@Description, ID=@Id");
            cmd.Parameters.AddWithValue("Title", title);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("Description", description);
            cmd.Parameters.AddWithValue("Director", director);

            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
