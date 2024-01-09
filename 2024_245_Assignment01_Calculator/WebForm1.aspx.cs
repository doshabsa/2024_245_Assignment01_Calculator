using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private string operators = "=+-*/";

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
                Session["stored"] = null;
                Session["input"] = "0";
                TxtDisplay.Text = "0";
            }

            // Display the current old string
            Update_Display();
        }

        protected void Input(object sender, EventArgs e)
        {
            if (((Button)sender).Text == ".")
                Session["input"] = AddDecimal(sender);
            else
                Session["input"] = CheckZero(sender);

            // Update the display with the new old string
            Update_Display();
        }

        protected string CheckZero(object sender)
        {
            // Check if old is currently 0; likely could narrow this code with a .Trim function
            if (Session["input"] is "0")
            {
                if (operators.Contains(((Button)sender).Text))
                    return "0" + ((Button)sender).Text;
                else
                    return ((Button)sender).Text;
            }
            else
                // Add input to the old string
                return Session["input"] + ((Button)sender).Text;
        }

        protected string AddDecimal(object sender)
        {
            if (Session["input"] is "0")
                return "0" + ((Button)sender).Text;
            else if (!Session["input"].ToString().Contains("."))
                return Session["input"].ToString() + ((Button)sender).Text;
            else
                return Session["input"].ToString();
        }

        protected void Calculate(object sender, EventArgs e)
        {
            if (Session["stored"] is "0" || Session["stored"] is null)
                Session["stored"] = PerformCalc(Session["input"].ToString());

            else if (Session["input"] is "0" || Session["input"] is null)
            {
                // No changes to stored
            }
            else
                Session["stored"] = PerformCalc(Session["stored"].ToString() + Session["input"].ToString());


            Session["input"] = "0";
            Update_Display();
        }

        protected string PerformCalc(string input)
        {
            DataTable dt = new DataTable();
            return dt.Compute(input, null).ToString();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            // Reset sessions and display
            Session["stored"] = null;
            Session["input"] = "0";
            TxtDisplay.Text = Session["input"].ToString();
        }

        protected void Update_Display()
        {
            // Update the display
            if (Session["stored"] is null || Session["stored"] is "0")
                TxtDisplay.Text = Session["input"].ToString();
            else if (Session["input"] is null || Session["input"] is "0")
                TxtDisplay.Text = Session["stored"].ToString();
            else
                TxtDisplay.Text = Session["stored"].ToString() + Session["input"].ToString();
        }
    }
}