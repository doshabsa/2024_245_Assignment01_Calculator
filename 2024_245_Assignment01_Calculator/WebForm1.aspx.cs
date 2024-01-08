using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2024_245_Assignment01_Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string numbers = "0123456789";
        private string operands = "=+-*/";

        /* 
         *  NOTES:
         *      Does not like dealing with NaN
         *      Occasionally, ONLY if breakpoints are used, will break by coming out of all methods and getting stuck on the global private strings?
         *      Will break data table if no longer working within INT32
         *      Will still add if no operand is selected (as in button presses (3 = 3 = 3) == 333)
         *      
         *      Previous rendition did allow for continual entry of numbers (met bonus) but would not allow more than one decimal anywhere within that input (1.25 * [no longer may enter a decimal anywhere])
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Establish old string
                Session["old"] = "0";
                Session["new"] = null;
            }

            // Display the current old string
            Update_Display();
        }

        protected void Input(object sender, EventArgs e)
        {
            if (((Button)sender).Text == ".")
                Session["new"] = AddDecimal(sender);
            else
                Session["new"] = CheckZero(sender);

            // Update the display with the new old string
            Update_Display();
        }

        protected void Opperand(object sender, EventArgs e)
        {
            Session["old"] = Session["new"];
            Session["new"] = "0";
            Input(sender, e);
        }

        protected string CheckZero(object sender)
        {
            // Check if old is currently 0; likely could narrow this code with a .Trim function
            if (Session["new"] == null)
                // Set old string to new input
                return ((Button)sender).Text;
            // Add check if an operand is already poldent, calc first then add new operand to string
            else
                // Add input to the old string
                return Session["new"] + ((Button)sender).Text;
        }

        protected string AddDecimal(object sender)
        {
            if (Session["new"] == null)
                return "0" + ((Button)sender).Text;
            else if (!Session["new"].ToString().Contains("."))
            {
                if (operands.Contains(Session["new"].ToString().First()))
                    return Session["new"].ToString() + "0" + ((Button)sender).Text;
                else
                    return Session["new"].ToString() + ((Button)sender).Text;
            }
            else
                return Session["new"].ToString();
        }

        protected void Calculate(object sender, EventArgs e)
        {
            // Honestly, the most simple way to force a computation without fancy splitting:
            if (Session["new"] != null && Session["old"] != null)
            {
                DataTable dt = new DataTable();
                Session["old"] = dt.Compute(Session["old"].ToString() + Session["new"].ToString().ToString(), null).ToString();
                Session["new"] = null;
            }
            Update_Display();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            // Reset sessions and display
            Session["old"] = "0";
            Session["new"] = null;
            Update_Display();
        }

        protected void Update_Display()
        {
            // Update the display
            if (Session["new"] == null)
                TxtDisplay.Text = Session["old"].ToString();
            else
                TxtDisplay.Text = Session["new"].ToString();
        }
    }
}