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
    public partial class DownloadPageApp : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                something();
            }            
        }

        void something()
        {
            if (Application["AppName"] != null)
            {
                beta.Visible = true;
                beta.Text = Application["Appname"].ToString();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("AppName");
                dt.Columns.Add("FileName");
                dt.Columns.Add("Extension");
                dt.Columns.Add("Size");
                dt.Columns.Add("Description");                

                con.Open();
                cmd = new SqlCommand("select * from AppDetailsWCat where AppName = '" + Application["AppName"].ToString() + "';", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);                
                con.Close();

                Gd.DataSource = dt;
                Gd.DataBind();
            }
        }

        protected void Gd_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                con.Open();
                cmd = new SqlCommand("select * from AppDetailsWCat where AppName = '"+ Application["AppName"].ToString() +"';",con);
                
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("AppName");
                dt.Columns.Add("FileName");
                dt.Columns.Add("Extension");
                dt.Columns.Add("AppSize");
                dt.Columns.Add("Description");
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                con.Close();

                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "filename=" + dt.Rows[0][2]);
                Response.TransmitFile(Server.MapPath("~/Apps/" + dt.Rows[0][1] +"/"+ dt.Rows[0][2]));
                Response.End();
            }   
        }
    }
}