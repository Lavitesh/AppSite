<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AppSite.Home" 
    MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="HomeMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <%--<div>
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
                
            </div>--%>
            <section class="welcome_area bg-img background-overlay" style="background-image: url(img/breadcumb.jpg);">
                <div class="container h-100">
                    <div class="row h-100 align-items-center">
                        <div class="col-12">
                            <div class="hero-content">
                                <h6>Web Store</h6>
                                <h2>View Applications</h2>
                                <asp:LinkButton runat="server" PostBackUrl="~/DownloadsPage.aspx" CssClass="btn essence-btn">View All Applications</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

            <div class="top_catagory_area section-padding-80 clearfix">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-12 col-sm-6 col-md-3">
                            <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(img/mswindows.jpg);">
                                <div class="catagory-content">
                                    <asp:LinkButton runat="server" OnClick="Unnamed_Click" CustomParameter = "Windows">Windows</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div class="col-12 col-sm-6 col-md-3">
                            <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(img/Android.png);">
                                <div class="catagory-content">
                                    <asp:LinkButton runat="server" OnClick="Unnamed_Click" CustomParameter = "Android">Android</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div class="col-12 col-sm-6 col-md-3">
                            <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(img/ios.png);">
                                <div class="catagory-content">
                                    <asp:LinkButton runat="server" OnClick="Unnamed_Click" CustomParameter = "Iphone">Iphone</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div class="col-12 col-sm-6 col-md-3">
                            <div class="single_catagory_area d-flex align-items-center justify-content-center bg-img" style="background-image: url(img/Linux.jpg);">
                                <div class="catagory-content">
                                    <asp:LinkButton runat="server" OnClick="Unnamed_Click" CustomParameter = "Linux">Linux</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

