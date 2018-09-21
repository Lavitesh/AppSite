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
    public partial class SearchPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getTable();
            }
        }

        void getTable()
        {
            if (Application["SearchVal"] != null)
            {
                NotFound.Text = Application["SearchVal"].ToString();
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("AppName");
                    dt.Columns.Add("AppFileName");
                    dt.Columns.Add("Extension");
                    dt.Columns.Add("AppSize");
                    dt.Columns.Add("Description");

                    con.Open();
                    cmd = new SqlCommand("select * from AppDetailsWCat where AppName like '%" + Application["SearchVal"].ToString() + "%';", con);
                    rd = cmd.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        NotFound.Text = Application["SearchVal"].ToString() + " Not Found";
                    }
                    dt.Load(rd);
                    rd.Close();
                    con.Close();                    
                    SearchView.DataSource = dt;
                    SearchView.DataBind();
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = ex.Message;
                }
            }
            else if(Application["Category"] != null)
            {
                NotFound.Text = Application["Category"].ToString();
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("AppName");
                    dt.Columns.Add("AppFileName");
                    dt.Columns.Add("Extension");
                    dt.Columns.Add("AppSize");
                    dt.Columns.Add("Description");
                    dt.Columns.Add("Category");

                    con.Open();                    
                    cmd = new SqlCommand("select * from AppDetails where Category like '%" + Application["Category"].ToString() + "%';", con);
                    rd = cmd.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        NotFound.Text = Application["Category"].ToString() + " Not Found";
                    }
                    dt.Load(rd);
                    rd.Close();
                    con.Close();
                    BoundField b = new BoundField();
                    b.DataField = "Category";
                    b.HeaderText = "Category";
                    SearchView.Columns.Add(b);
                    SearchView.DataSource = dt;
                    SearchView.DataBind();
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = ex.Message;
                }
            }
            else if (Application["NameSearch"] != null)
            {
                NotFound.Text = Application["NameSearch"].ToString();
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("AppName");
                    dt.Columns.Add("AppFileName");
                    dt.Columns.Add("Extension");
                    dt.Columns.Add("AppSize");
                    dt.Columns.Add("Description");

                    con.Open();
                    cmd = new SqlCommand("select * from AppDetailsWCat where AppName like '%" + Application["NameSearch"].ToString() + "%';", con);
                    rd = cmd.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        NotFound.Text = Application["NameSearch"].ToString() + " Not Found";
                    }
                    dt.Load(rd);
                    rd.Close();
                    con.Close();
                    SearchView.DataSource = dt;
                    SearchView.DataBind();
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = ex.Message;
                }
            }
        }

        protected void SearchView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "GoToApp")
            {
                Application["AppName"] = e.CommandArgument;
                Response.Redirect("~/DownloadPageApp.aspx");
            }
        }
    }
}