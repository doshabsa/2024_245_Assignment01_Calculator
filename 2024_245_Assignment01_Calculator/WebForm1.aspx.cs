using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2024_245_Assignment01_Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string numbers = "0123456789.";
        private string operands = "=+-*/";

        /*  TODO:
         *      Max string length to 21 in order to preserve display, or allow some sort of wrapping
         *      ... willl break data table to bee too long of an integer (INT32)
         *  
         *  NOTE:
         *      This ended up ~2 lines (of actual code) longer than the original version, which included LINQ
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                // Establish res string
                Session["res"] = "0";

            // Display the current res string
            Update_Display();
        }

        protected void Input(object sender, EventArgs e)
        {
            // Check if a number or opperand input was selected 
            if (numbers.Contains(((Button)sender).Text) || operands.Contains(((Button)sender).Text))
            {
                // Check if res is currently 0; likely could narrow this code with a .Trim function
                if (Session["res"].ToString() == "0" && !operands.Contains(((Button)sender).Text))
                    // Set res string to new input
                    Session["res"] = ((Button)sender).Text;
                // Add check if an operand is already present, calc first then add new operand to string
                else
                    // Add input to the res string
                    Session["res"] += ((Button)sender).Text;
            }
            // Update the display with the new res string
            Update_Display();
        }

        protected void Calculate(object sender, EventArgs e)
        {
            // Honestly, the most simple way to force a computation without fancy splitting:
            DataTable dt = new DataTable();
            Session["res"] = dt.Compute(Session["res"].ToString(), null).ToString();
            Update_Display();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            // Reset res and display
            Session["res"] = "0";
            Update_Display();
        }

        protected void Update_Display()
        {
            // Update the display
            TxtDisplay.Text = Session["res"].ToString();
        }
    }
}