<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="AppSite.AboutUs" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="AboutUsMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div class="breadcumb_area bg-img" style="background-image: url(img/breadcumb.jpg);">
                <div class="container h-100">
                    <div class="row h-100 align-items-center">
                        <div class="col-12">
                            <div class="page-title text-center">
                                <h2>Web Store</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
            <div class="breadcumb_area bg-img">
                <div class="container h-100">
                    <div class="row h-100 align-items-center">
                        <div class="col-12">
                            <div class="text-center">
                                <h2>Download apps available and Upload your apps for everyone</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>