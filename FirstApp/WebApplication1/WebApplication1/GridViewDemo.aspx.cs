using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class GridViewDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkAdd_Click(object sender, EventArgs e)
        {
            sqlMovies.InsertParameters["Title"].DefaultValue = txtTitle.Text;
            sqlMovies.InsertParameters["Director"].DefaultValue = txtDirector.Text;
            sqlMovies.InsertParameters["InTheaters"].DefaultValue = chkNowPlaying.Checked.ToString();
            sqlMovies.InsertParameters["Description"].DefaultValue = txtDescription.Text;
            sqlMovies.InsertParameters["CategoryID"].DefaultValue = ddlCategory.SelectedValue;

            sqlMovies.Insert();
        }
    }
}