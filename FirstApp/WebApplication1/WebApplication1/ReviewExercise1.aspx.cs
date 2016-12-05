using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ReviewExersice1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal decShippingCost = 0.35m;
            int intQuantity;
            int intDistance;
            decimal decFinalShippingCost;
            decimal decShippingFee;

            try
            {
                intQuantity = Convert.ToInt32(txtQuantity.Text);
                intDistance = Convert.ToInt32(txtDistance.Text);
                decShippingFee = Convert.ToDecimal(drpShippingType.SelectedValue);

                decFinalShippingCost = intQuantity * intDistance * decShippingCost;
                decFinalShippingCost += intQuantity * decShippingFee;

                lblShippingCost.Text = String.Format("{0:c}", decFinalShippingCost);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch(FormatException fe)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                lblShippingCost.ForeColor = System.Drawing.Color.Red;
                lblShippingCost.Text = "You I D I O T!";
            }

        }

        protected void drpShippingType_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string shippingFee = String.Format("{0:c}", drpShippingType.SelectedValue);
            lblShippingFee.Text = shippingFee + "/ Unit";
        }
    }
}