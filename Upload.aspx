<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="AppSite.Upload" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="UploadMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div class="breadcumb_area bg-img" style="background-image: url(img/breadcumb.jpg);">
                <div class="container h-100">
                    <div class="row h-100 align-items-center">
                        <div class="col-12">
                            <div class="page-title text-center">
                                <h2>Upload</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="checkout_area section-padding-80">
                <div class="container">
                    <div class="row">
                        <div class="col-12 col-md-6">
                            <div class="checkout_details_area mt-50 clearfix">

                                <div class="cart-page-heading mb-30">
                                    <h5>Application Info</h5>
                                </div>

                                <div class="row">
                                    <div class="col-12 mb-3">
                                        <b>Enter Name Of The App: </b>
                                        <asp:TextBox ID="appName" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-12 mb-3">
                                        <b>Categories: </b>
                                        <br />
                                        <asp:ListBox ID="Category" runat="server" CssClass="close form-control list-group-item-action" SelectionMode="Multiple" DataSourceID="SqlDataSource1" DataTextField="Category" DataValueField="CategoryIndex" ></asp:ListBox>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AppSiteTestConnectionString %>" SelectCommand="SELECT * FROM [CategoryMaster]"></asp:SqlDataSource>
                                    </div>
                                    <div class="col-12 mb-3">
                                        <b>Description: </b>
                                        <asp:TextBox ID="Description" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" Columns="50"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12 col-md-6 col-lg-5 ml-lg-auto">
                            <div class="order-details-confirmation mt-50">
                                <div class="cart-page-heading">
                                    <h5>Upload Files</h5>
                                    <div class="col-12 mb-3">
                                        <b>Select File: </b>
                                        <asp:FileUpload ID="FControl" CssClass="form-control" runat="server"/>
                                    </div>
                                    <div class="col-12 mb-3">
                                        <b>Select Icon: </b>
                                        <asp:FileUpload ID="IconControl" CssClass="form-control" runat="server" accept=".ico" />
                                    </div>
                                </div>
                            </div>
                        </div>  
                        <div class="col-12 mb-3">                        
                            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
                            <asp:Button ID="UploadOnclick" runat="server" CssClass=" btn-secondary form-control" OnClick="Upload_Click" Text="Submit" />
                        </div>                      
                    </div>
                </div>
            </div>
            
        </ContentTemplate>

        <Triggers>
            <asp:PostBackTrigger ControlID="UploadOnClick"/>
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>                 
                                