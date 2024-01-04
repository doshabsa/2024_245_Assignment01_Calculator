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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TxtDisplay.Text = "0";
                TxtDisplay.Style["Text-Align"] = "Right";
            }
        }

        protected void Number(object sender, EventArgs e)
        {
            string str = $"{TxtDisplay.Text}{((Button)sender).Text}";
            if (((Button)sender).Text == ".")
                TxtDisplay.Text = TxtDisplay.Text.Contains(".") ? TxtDisplay.Text = TxtDisplay.Text : TxtDisplay.Text = str;
            else
                TxtDisplay.Text = TxtDisplay.Text == "0" ? TxtDisplay.Text = ((Button)sender).Text : TxtDisplay.Text = str;
        }

        protected void NonNumber(object sender, EventArgs e)
        {
            Calculate(sender, e);
            TxtDisplay.Text = $"{TxtDisplay.Text}{((Button)sender).Text}";
        }

        protected void Calculate(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            TxtDisplay.Text = dt.Compute(TxtDisplay.Text, null).ToString();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }
    }
}