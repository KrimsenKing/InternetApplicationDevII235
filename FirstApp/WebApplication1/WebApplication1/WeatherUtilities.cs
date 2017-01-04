using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
//using WeatherReport;

namespace WebApplication1
{
    public class WeatherUtilities
    {
        string conString;
        public WeatherUtilities()
        {
            conString = WebConfigurationManager.ConnectionStrings["dbWeatherData"].ConnectionString;
        }

        public void addWeatherReport(WeatherReport wr)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conString;
            SqlCommand cmd = new SqlCommand("Insert Into reports (lat, lon, timesubmitted, facing) values(@lat, @lon, @datesubmitted, @facing)");
            cmd.Parameters.AddWithValue("lat", wr.Latitude);
            cmd.Parameters.AddWithValue("lon", wr.Longitude);
            cmd.Parameters.AddWithValue("datesubmitted", wr.DateSubmitted);
            cmd.Parameters.AddWithValue("facing", wr.Facing);

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}