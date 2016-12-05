using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Calendar : System.Web.UI.Page
    {
        Random r = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calHorrorscope_DayRender(object sender, DayRenderEventArgs e)
        {
            TableCell c;
            string horrorScope = "";
            c = e.Cell;

            int num = r.Next(4);

            switch (num)
            {
                case 0:
                    horrorScope = "Good Things Will Happen Today";
                    c.BackColor = Color.FromName("Green");
                    break;

                case 1:
                    horrorScope = "Beware the Strange";
                    c.BackColor = Color.FromName("Blue");
                    break;

                case 2:
                    horrorScope = "Injury is imminent";
                    c.BackColor = Color.FromName("Orange");
                    break;

                case 3:
                    horrorScope = "Death is sure to happen";
                    c.BackColor = Color.FromName("Red");
                    break;
            }

            c.Controls.Add(new LiteralControl("<p>"));
            c.Controls.Add(new LiteralControl(horrorScope));
            c.Controls.Add(new LiteralControl("</p>"));

        }
    }
}