using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LastResortBADPJ
{
    public partial class AdminFAQ : System.Web.UI.Page
    {
        FAQ aFAQ = new FAQ();
        protected void Page_Load(object sender, EventArgs e)
  
        {
            if (!IsPostBack)
            {
                bind();
            }

        }

        protected void bind()
        {

            List<FAQ> faqList = new List<FAQ>();
            faqList = aFAQ.getFAQAll();
            gvFAQ.DataSource = faqList;
            gvFAQ.DataBind();

        }

        protected void gvFAQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected row.
            GridViewRow row = gvFAQ.SelectedRow;

            // Get Product ID from the selected row, which is the 
            // first row, i.e. index 0.
            string faqID = row.Cells[0].Text;

            // Redirect to next page, with the Product Id added to the URL,
            // e.g. FAQ.aspx?FAQID=1
            Response.Redirect("FAQ.aspx?FAQID=" + faqID);
        }

    }
}