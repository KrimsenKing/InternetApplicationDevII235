using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AJAXDemo_ProgammaticUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MovieManager mm = new MovieManager();
            ddlMovie.DataSource = mm.getMovies();
            ddlMovie.DataBind();
            UpdatePanel2.Update();

        }

        protected void lnkBtnMovie_Click(object sender, EventArgs e)
        {
            MovieManager mm = new MovieManager();
            ddlMovie.DataSource = mm.getMoviesByTitle(txtTitle.Text);
            ddlMovie.DataBind();
            UpdatePanel2.Update();

        }
    }
}