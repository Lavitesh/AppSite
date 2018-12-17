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
    public partial class RemovePage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True");
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            dosomething();
        }

        protected void dosomething()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("App");
            dt.Columns.Add("File");
            dt.Columns.Add("Size");
            dt.Columns.Add("Type");

            foreach (string strfolder in Directory.GetDirectories(Server.MapPath("~/Apps/")))
            {//No Database Interaction....
                DirectoryInfo di = new DirectoryInfo(strfolder);
                foreach (string strfile in Directory.GetFiles(Server.MapPath("~/Apps/" + di.Name + "/")))
                {
                    FileInfo fi = new FileInfo(strfile);
                    dt.Rows.Add(di.Name, fi.Name, fi.Length.ToString(), fi.Extension);
                }
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                string[] commandargs = e.CommandArgument.ToString().Split('/');
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "filename=" + commandargs[1]);
                Response.TransmitFile(Server.MapPath("~/Apps/" + e.CommandArgument));
                Response.End();
            }
            if(e.CommandName == "Delete")
            {
                try
                {
                    string[] commandargs = e.CommandArgument.ToString().Split('/');
                    con.Open();
                    string folderpath = Server.MapPath("~/Apps/" + commandargs[0] + "/");
                    if (Directory.Exists(folderpath))
                    {
                        Directory.Delete(folderpath, true);
                    }
                    string querystring = "select ID from App where AppName = '" + commandargs[0] + "';";
                    cmd = new SqlCommand(querystring , con);
                    string str = cmd.ExecuteScalar().ToString();
                    int ID = int.Parse(str);
                    SqlCommand command = new SqlCommand("sp_removeApp", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("ID", ID);                    
                    command.ExecuteNonQuery();
                    con.Close();
                    Response.Redirect("RemovePage.aspx");                    
                }
                catch (Exception ex)
                {
                    Status.Visible = true;
                    Status.Text = "Remove Status : Failed, Reason : " + ex.Message ;
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            dosomething();
        }
    }
}