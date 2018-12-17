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
    public partial class AdminLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True");
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string querystring = "select COUNT(*) from tbluser where Username = '"+ User_login.Text +"' and Password = '"+ Pass.Text +"';";
                cmd = new SqlCommand(querystring, con);
                string output = cmd.ExecuteScalar().ToString();
                if(output == "1")
                {
                    Session["User"] = User_login.Text;
                    Response.Redirect("~/Admin/AdminPage.aspx");
                }
                else
                {
                    Session.RemoveAll();
                    Response.Redirect("~/Home.aspx");
                }
            }
            catch (Exception ex)
            {
                Status.Text = "Upload Status: Upload Failed. Reason: " + ex.Message;
            }
        }
    }
}