using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Stock> GetAllStocks()
        {
            List<Stock> stocks = new List<Stock>();

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["dbStock"].ConnectionString);

            SqlCommand cmd = new SqlCommand("Select StockName, StockSymbol, Shares, Price from Stocks");
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Stock st = new Stock(reader["StockSymbol"].ToString(), reader["StockName"].ToString(),Convert.ToInt32(reader["Shares"].ToString()), Convert.ToDouble(reader["Price"].ToString()));
                stocks.Add(st);
            }
            return stocks;
        }

        public List<Stock> GetStockByCode(string code)
        {
            List<Stock> stocks = new List<Stock>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["dbStock"].ConnectionString);

            SqlCommand cmd = new SqlCommand("Select StockName, Shares, Price from Stocks where StockSymbol = @StockCode");
            cmd.Parameters.AddWithValue("StockCode", code);
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Stock st = new Stock(code, reader["StockName"].ToString(), Convert.ToInt32(reader["Shares"].ToString()), Convert.ToDouble(reader["Price"].ToString()));
                stocks.Add(st);
            }
            return stocks;
        }


        //*********************************************
        public List<MovieCategory> GetAllMovieCategories()
        {
            List<MovieCategory> cats = new List<MovieCategory>();

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["dbMovies"].ConnectionString);

            SqlCommand cmd = new SqlCommand("Select Id, Name from MovieCategories");
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MovieCategory mc = new MovieCategory(Convert.ToInt32(reader["Id"].ToString()), reader["Name"].ToString());
                cats.Add(mc);
            }
            return cats;
        }

        public List<Movie> GetMoviesByCategoryId(int catid)
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["dbMovies"].ConnectionString);

            SqlCommand cmd = new SqlCommand("Select Title, Director, Description from Movies where CategoryId = @CategoryId");
            cmd.Parameters.AddWithValue("CategoryId", catid);
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movie m = new Movie(reader["Title"].ToString(), reader["Director"].ToString(), reader["Description"].ToString());
                movies.Add(m);
            }
            return movies;
        }
        //*********************************************
        public List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["dbMovies"].ConnectionString);

            SqlCommand cmd = new SqlCommand("Select Title, Director, Description from Movies");
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movie m = new Movie(reader["Title"].ToString(), reader["Director"].ToString(), reader["Description"].ToString());
                movies.Add(m);
            }
            return movies;
        }

        public string Welcome(string userName)
        {
            return string.Format("Hello {0}, welcome to the world of Web Services!", userName);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Equation GenerateEquation()
        {
            Random r = new Random();
            int a = r.Next(200);
            int b = r.Next(200);

            int op = r.Next(3);
            string s = "";

            switch (op)
            {
                case (0):
                    s = "add";
                    break;
                case (1):
                    s = "subtract";
                    break;
                case (2):
                    s = "multiply";
                    break;
            }
            Equation e = new Equation(a, b, s);
            return e;
        }
    }
}
