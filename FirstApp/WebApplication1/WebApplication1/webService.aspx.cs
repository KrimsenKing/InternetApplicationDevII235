using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Service1;

namespace WebApplication1
{
    public partial class webService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();

            string name = TextBox1.Text;
            Label1.Text = service.Welcome(name);
        }
    }
}