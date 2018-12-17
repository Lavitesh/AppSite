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


namespace AppSite.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["SearchVal"] = null;
            Session["Category"] = null;
            if (Session["User"] == null)
            {
                Session.Abandon();
                Session.RemoveAll();
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Username.Text = Session["User"].ToString().ToUpper();
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("~/Home.aspx");
        }
    }
}