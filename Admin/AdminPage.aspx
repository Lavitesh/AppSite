﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="AppSite.Admin.AdminPage" %>

<asp:Content ID="HomeMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <section class="welcome_area bg-img background-overlay" style="background-image: url(../img/breadcumb.jpg);">
                <div class="container h-100">
                    <div class="row h-100 align-items-center">
                        <div class="col-12">
                            <div class="hero-content">
                                <h6>Web Store</h6>
                                <h2>View all Items</h2>
                                <asp:LinkButton runat="server" PostBackUrl="Download.aspx" CssClass="btn essence-btn">View All Applications</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
