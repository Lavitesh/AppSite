using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppSite
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["SearchVal"] = null;
            Session["Category"] = null;
        }

        protected void Unnamed_TextChanged(object sender, EventArgs e)
        {
            Session["SearchVal"] = headerSearch.Text;
            Response.Redirect("~/SearchPage.aspx");
        }
        
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            LinkButton lnk = sender as LinkButton;
            Session["Category"] = lnk.Attributes["CustomParameter"].ToString();
            Response.Redirect("~/SearchPage.aspx");
        }
    }
}