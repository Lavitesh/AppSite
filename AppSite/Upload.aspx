<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="AppSite.Upload" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="UploadMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div style="align-items:center">
                <br /><b>Enter Name Of The App: </b><asp:TextBox ID="appName" runat="server"></asp:TextBox><br />                
                <b>Select File: </b><asp:FileUpload ID="FControl" runat="server"/><br />          
                <b>Select Icon: </b><asp:FileUpload ID="IconControl" runat="server" accept=".ico" /><br />
                <b>Description: </b><asp:TextBox ID="Description" runat="server" TextMode="MultiLine" Rows="5" Columns="50"></asp:TextBox><br />
                <b>Categories: </b><asp:ListBox ID="Category" runat="server" SelectionMode="Multiple" DataSourceID="SqlDataSource1" DataTextField="Category" DataValueField="CategoryIndex"></asp:ListBox>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AppSiteTestConnectionString %>" SelectCommand="SELECT * FROM [CategoryMaster]"></asp:SqlDataSource>                <br />
                <asp:Button ID="UploadOnclick" runat="server" OnClick="Upload_Click" Text="Submit"/><br /><br />                
                <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="UploadOnClick"/>
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>