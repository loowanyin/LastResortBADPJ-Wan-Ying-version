using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LastResortBADPJ
{
    public partial class ThankYou_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Extract data from QueryString - Request object and save it to the label
            /*lbl_Gender.Text = Request.QueryString["Gender"];
            lbl_Email.Text = Request.QueryString["Email"];
            lbl_PhoneNumber.Text = Request.QueryString["PhoneNumber"];
            lbl_YourQuestion.Text = Request.QueryString["YourQuestion"]; */

            //Extract data from session variables and save it to the label 
            lbl_Gender.Text = (string)Session["Gender"];
            lbl_Email.Text = (string)Session["Email"];
            lbl_PhoneNumber.Text = (string)Session["PhoneNumber"];
            lbl_YourQuestion.Text = (String)Session["YourQuestion"];
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FAQ.aspx");
        }
    }
}