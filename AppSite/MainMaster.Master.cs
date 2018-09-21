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
            Application["SearchVal"] = null;
            Application["NameSearch"] = null;
            Application["Category"] = null;
        }

        protected void Unnamed_TextChanged(object sender, EventArgs e)
        {
            Application["SearchVal"] = SearchItem.Text;
            Response.Redirect("~/SearchPage.aspx");
        }
    }
}