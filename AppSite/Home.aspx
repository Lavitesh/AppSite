<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AppSite.Home" 
    MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="HomeMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div>
                <h1 style="font-family:'Book Antiqua'">Web Store: Download anything you want.</h1>
            </div>
            <div>
                <h3 style="font-family:'Book Antiqua'">Search By Name: 
                    <asp:TextBox ID="SearchName" runat="server"></asp:TextBox>
                    <asp:Button ID="NameButton" runat="server" Text="Search" OnClick="NameButton_Click"/>
                </h3>                
                <h3>OR</h3>
                <h3 style="font-family:'Book Antiqua'">Search By Category: 
                    <asp:TextBox ID="SearchCate" runat="server"></asp:TextBox>
                    <asp:Button ID="CategoryBotton" runat="server" Text="Search" OnClick="CategoryBotton_Click"/>
                </h3>
                
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

