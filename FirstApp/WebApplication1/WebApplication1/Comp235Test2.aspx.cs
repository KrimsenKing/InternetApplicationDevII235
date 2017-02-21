using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Service1;

namespace WebApplication1
{
    public partial class Comp235Test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Service1Client sc1 = new Service1Client();
                dlStockListing.DataSource = sc1.GetAllStocks();
                dlStockListing.DataBind();
            }
        }

        protected void btnLookUpStock_Click(object sender, EventArgs e)
        {
            Service1Client sc1 = new Service1Client();
            dlStockListing.DataSource = sc1.GetStockByCode(tbStockCode.Text);
            dlStockListing.DataBind();
        }
    }
}