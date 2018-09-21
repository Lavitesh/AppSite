using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace AppSite
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Application["NameSearch"] = null;
            Application["Category"] = null;
            Application["SearchVal"] = null;
        }

        protected void NameButton_Click(object sender, EventArgs e)
        {
            Application["NameSearch"] = SearchName.Text;
            Response.Redirect("~/SearchPage.aspx");
        }

        protected void CategoryBotton_Click(object sender, EventArgs e)
        {
            Application["Category"] = SearchCate.Text;
            Response.Redirect("~/SearchPage.aspx");
        }
    }
}