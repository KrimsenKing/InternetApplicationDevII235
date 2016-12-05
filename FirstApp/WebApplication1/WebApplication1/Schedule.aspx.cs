using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        String[,] schedule;
        FileStream schedIO;
        BinaryFormatter schedObjectIO;


        protected void Page_Load(object sender, EventArgs e)
        {
            schedule = (string[,])Session["schedule"];

            if (schedule == null)
            {
                if (File.Exists(MapPath("ToDoList\\ToDoList.bin")))
                {
                    schedIO = new FileStream(MapPath("ToDoList\\ToDoList.bin"), FileMode.Create);
                    schedObjectIO = new BinaryFormatter();
                    schedule = (string[,])schedObjectIO.Deserialize(schedIO);
                }
                else {
                    schedule = new string[13, 32];
                }
            }
            Session["schedule"] = schedule;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int x = calMeetings.SelectedDate.Month;
            int y = calMeetings.SelectedDate.Day;

            schedule[x, y] = mltSession.Text;
            Session["schedule"] = schedule;

            schedIO = new FileStream(MapPath("ToDoList\\ToDoList.bin"), FileMode.Create);
            schedObjectIO = new BinaryFormatter();
            schedObjectIO.Serialize(schedIO, schedule);

            schedIO.Close();

        }

        protected void calMeetings_SelectionChanged(object sender, EventArgs e)
        {

            int x = calMeetings.SelectedDate.Month;
            int y = calMeetings.SelectedDate.Day;

            mltSession.Text = schedule[x, y];
            Session["schedule"] = schedule;
        }

        protected void calMeetings_DayRender(object sender, DayRenderEventArgs e)
        {
            int x = e.Day.Date.Month;
            int y = e.Day.Date.Day;


            if (schedule[x, y] != null && schedule[x, y].Length > 0)
            {
                TableCell c;
                c = e.Cell;
                c.BackColor = Color.FromName("Gray");
            }
        }

    }
}