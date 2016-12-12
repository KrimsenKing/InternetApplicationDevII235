using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieLibrary;

public partial class midTermStudyGuide3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MovieUtilities mu = new MovieUtilities();
        Repeater1.DataSource = mu.SelectAll();
        Repeater1.DataBind();

        string id;
     try
        {
            if (Request.QueryString["id"].ToString() != null)
                id = Request.QueryString["id"].ToString();
            else
                id ="1";
            MovieData md = new MovieData();
            GridView1.DataSource = md.getMoviesById(Convert.ToInt32(id));
            GridView1.DataBind();
        }   
        catch { }
    }
}