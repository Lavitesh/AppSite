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
    public partial class DownloadsPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                CreateTable();
            }
        }

        protected void CreateTable()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("AppName");
                dt.Columns.Add("FileName");
                dt.Columns.Add("Extension");
                dt.Columns.Add("Size");
                dt.Columns.Add("Description");
                dt.Columns.Add("IconName");

                con.Open();
                cmd = new SqlCommand("select * from AppDetailsWCat;", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                con.Close();

                gD.DataSource = dt;
                gD.DataBind();
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }

        protected void gD_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DownloadPage")
            {
                Application["AppName"] = e.CommandArgument;
                Response.Redirect("~/DownloadPageApp.aspx");
            }
        }
    }
}