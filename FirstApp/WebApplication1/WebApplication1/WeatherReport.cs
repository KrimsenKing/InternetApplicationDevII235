using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class WeatherReport
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Facing { get; set; }
        public DateTime DateSubmitted { get; set; }
        public int Id { get; set; }

        public WeatherReport(){}
        public WeatherReport(float latitude, float longitude, float face, DateTime datesubmited, int id)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Facing = face;
            this.DateSubmitted = datesubmited;
            this.Id = id;
        }
    }
}