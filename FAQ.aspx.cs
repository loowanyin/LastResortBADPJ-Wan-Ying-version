using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LastResortBADPJ
{
    public partial class FAQ : System.Web.UI.Page
    {
        private object rdl_Gender;
        private object tb_Email;
        private object tb_PhoneNo;
        private object tb_Question;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            //queryString - http://url/ThankYou_form.aspx?Gender=Male&Email=JakeLoh@gmail.com&PhoneNumber=99199919&YourQuestion=howmuchisit
            //extract information from textbox and add to the query string 
            //string queryString = "?Gender=" + rdl_Gender.Text + "&Email=" + tb_Email.Text + "&PhoneNumber=" + tb_PhoneNo.Text + "&YourQuestion=" + tb_Question.Text;

            //Redirect to Thank You Form for processing
            //Response.Redirect("ThankYou_Form.aspx" + queryString);

            //extract info from textbox and save into session 
            Session["Gender"] = rdl_Gender;
            Session["Email"] = tb_Email;
            Session["Phone Number"] = tb_PhoneNo;
            Session["Your Question"] = tb_Question;

            //Redirect to Thank You Form
            Response.Redirect("ThankYou_Form.aspx");

        }

        protected void gvFAQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}