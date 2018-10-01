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
                Session["AppName"] = e.CommandArgument;
                Response.Redirect("~/DownloadPageApp.aspx");
            }
        }

        protected void gD_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gD.PageIndex = e.NewPageIndex;
            CreateTable();
        }

        protected void PageDropDownList_SelectedIndexChanged(Object sender, EventArgs e)
        {

            // Retrieve the pager row.
            GridViewRow pagerRow = gD.BottomPagerRow;

            // Retrieve the PageDropDownList DropDownList from the bottom pager row.
            DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");

            // Set the PageIndex property to display that page selected by the user.
            gD.PageIndex = pageList.SelectedIndex;
            CreateTable();
        }
        protected void PreviousPage_Click(object sender, EventArgs e)
        {
            int currentPage = gD.PageIndex;
            if (currentPage != 0)
            {
                gD.PageIndex = currentPage - 1;
                CreateTable();
            }
        }

        protected void NextPage_Click(object sender, EventArgs e)
        {
            int currentPage = gD.PageIndex;
            if (currentPage != gD.PageCount)
            {
                gD.PageIndex = currentPage + 1;
                CreateTable();
            }
        }

        protected void gD_DataBound(Object sender, EventArgs e)
        {

            // Retrieve the pager row.
            GridViewRow pagerRow = gD.BottomPagerRow;

            // Retrieve the DropDownList and Label controls from the row.
            DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
            Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
            

            if (pageList != null)
            {

                // Create the values for the DropDownList control based on 
                // the  total number of pages required to display the data
                // source.
                for (int i = 0; i < gD.PageCount; i++)
                {

                    // Create a ListItem object to represent a page.
                    int pageNumber = i + 1;
                    ListItem item = new ListItem(pageNumber.ToString());

                    // If the ListItem object matches the currently selected
                    // page, flag the ListItem object as being selected. Because
                    // the DropDownList control is recreated each time the pager
                    // row gets created, this will persist the selected item in
                    // the DropDownList control.   
                    if (i == gD.PageIndex)
                    {
                        item.Selected = true;
                    }

                    // Add the ListItem object to the Items collection of the 
                    // DropDownList.
                    pageList.Items.Add(item);

                }

            }

            if (pageLabel != null)
            {

                // Calculate the current page number.
                int currentPage = gD.PageIndex + 1;

                // Update the Label control with the current page information.
                pageLabel.Text = "Page " + currentPage.ToString() + " of " + gD.PageCount.ToString();                
            }            
            
        }

    }
}