using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calendar_Appointment_App
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmir_Click(object sender, EventArgs e)
        {
            lblResult.Text = "You selected this date: <br />";
            lblResult.Text += Calendar1.SelectedDate.ToLongDateString() + "<br />";
            lblResult.Text += "Time: " + listTimes.Text;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            listTimes.Items.Clear();

            switch (Calendar1.SelectedDate.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    listTimes.Items.Add("10:00");
                    listTimes.Items.Add("10:30");
                    listTimes.Items.Add("11:00");
                    break;
                default:
                    listTimes.Items.Add("10:00");
                    listTimes.Items.Add("10:30");
                    listTimes.Items.Add("11:00");
                    listTimes.Items.Add("11:30");
                    listTimes.Items.Add("12:00");
                    listTimes.Items.Add("12:30");
                    break;
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
            }
        }
    }
}