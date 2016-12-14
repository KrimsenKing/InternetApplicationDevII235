using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Jobs j = new Jobs();
        Repeater1.DataSource = j.SelectAll();
        Repeater1.DataBind();

    }
}