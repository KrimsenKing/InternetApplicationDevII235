using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoadTime.Text = DateTime.Now.ToString();
            
        }

        protected void lnkPartialSubmit_Click(object sender, EventArgs e)
        {
            lblPartialLoadTime.Text = DateTime.Now.ToString();
        }

        protected void lnkSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void lnkNoAjax_Click(object sender, EventArgs e)
        {
            lblPartialLoadTime.Text = DateTime.Now.ToString();
        }
    }
}