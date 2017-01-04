using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WeatherReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            float lat = Convert.ToSingle(txtLat.Text);
            float lon = Convert.ToSingle(txtLon.Text);
            float facing = Convert.ToSingle(txtFacing.Text);

            WeatherReport wr = new WeatherReport(lat, lon, facing, DateTime.Now, -1);
            WeatherUtilities wu = new WeatherUtilities();
            wu.addWeatherReport(wr);
            clear();

        }
        protected void clear()
        {
            txtLat.Text = "";
            txtLon.Text = "";
            txtFacing.Text = "";
        }
    }
}