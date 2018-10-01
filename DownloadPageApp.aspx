<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadPageApp.aspx.cs" Inherits="AppSite.DownloadPageApp" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="DownloadAppHead" ContentPlaceHolderID="head" runat="server">
    <style>
        .abc{
            text-transform:initial!important;
            font-family:'Buxton Sketch' !important;
            font-size:30px!important;
            overflow-wrap: break-word;
        }
        .def{
            max-height:300px;
            max-width:500px;
            min-height:200px;
            min-width:200px;
        }
    </style>
</asp:Content>
<asp:Content ID="DownloadAppMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <section class="single_product_details_area d-flex align-items-center col-12">
                <asp:Image ID="Image1" runat="server" CssClass="def" />
                <div class="single_product_desc clearfix">
                    <asp:Label ID="AppExt" runat="server"></asp:Label>
                    <asp:Label ID="beta" runat="server"></asp:Label>
                    <p class="product-price"><asp:Label ID="AppSizeLabel" runat="server"></asp:Label></p>
                    <p class="product-desc"><asp:Label CssClass="abc" ID="AppDesc" runat="server"></asp:Label></p>
                    <div class="cart-fav-box d-flex align-items-center">
                        <asp:Button ID="DownloadNow" runat="server" CssClass="btn essence-btn" OnClick="DownloadNow_Click" Text="Download" Visible="false"/>
                    </div>
                </div>
            </section>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="DownloadNow" />
        </Triggers>        
    </asp:UpdatePanel>
</asp:Content>
