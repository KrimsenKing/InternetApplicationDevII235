using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Service1;

namespace WebApplication1
{
    public partial class ReviewExercise : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlMovieCats.DataValueField = "Id";
                ddlMovieCats.DataTextField = "Name";

                Service1Client sc = new Service1Client();
                ddlMovieCats.DataSource = sc.GetAllMovieCategories();
                ddlMovieCats.DataBind();
            }
        }

        protected void ddlMovieCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service1Client sc = new Service1Client();
            DataList1.DataSource = sc.GetMoviesByCategoryId(Convert.ToInt32(ddlMovieCats.SelectedValue));
            DataList1.DataBind();
        }
    }
}