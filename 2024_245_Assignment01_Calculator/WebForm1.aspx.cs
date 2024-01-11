using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace _2024_245_Assignment01_Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string numbers = "0123456789";
        private string operators = "+-*/";

        /* 
         *  NOTES:
         *      Does not like dealing with NaN, please be gentle
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Establish old string
                Session["stored"] = "0";
                Session["input"] = "0";
                TxtDisplay.Text = "0";
            }

            // Display the current calculation
            Update_Display();
        }

        protected void Press(object sender, EventArgs e)
        {
            if (((Button)sender).Text == ".")
                Session["input"] = AddDecimal(Session["input"].ToString());
            else if (numbers.Contains(((Button)sender).Text) || operators.Contains(((Button)sender).Text))
                Session["input"] = AddDigit(Session["input"].ToString(), ((Button)sender).Text);

            Update_Display();
        }


        protected string AddDecimal(string input)
        {
            if (input.Contains("."))
                return input;
            else
            {
                switch (input)
                {
                    case "0":
                        return "0.";

                    default:
                        if (operators.Contains(input))
                            return Session["input"] + "0.";
                        else
                            return input + ".";
                }
            }
        }

        protected string AddDigit(string session, string input)
        {
            switch (session)
            {
                case "0":
                    return input;

                default:
                    return session + input;
            }
        }

        protected void Calculate(object sender, EventArgs e)
        {
            // I think this had better functionality with the last rendition of the project
            // Would have preferred to add even more error checking, but this quickly snowballs into a lot more QA
            DataTable dt = new DataTable();
            Session["stored"] = dt.Compute(Session["stored"] + Session["input"].ToString(), null).ToString();
            Session["input"] = "0";
            TxtDisplay.Text = Session["stored"].ToString();
        }

        protected void AllClear_Click(object sender, EventArgs e)
        {
            Session["stored"] = "0";
            Session["input"] = "0";
            Update_Display();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Session["input"] = "0";
            Update_Display();
        }

        protected void Update_Display()
        {
            if (Session["stored"].ToString() != "0")
                TxtDisplay.Text = Session["stored"].ToString() + Session["input"].ToString();
            else
                TxtDisplay.Text = Session["input"].ToString();
        }
    }
}