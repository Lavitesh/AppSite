<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="AppSite.AdminLogin" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="LoginMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div class="col-12 col-md-6 col-lg-5 ml-lg-auto" style="margin:10% 30% 0  0">
                <div class="order-details-confirmation mt-50">
                    <div class="cart-page-heading">
                        <h5>Login</h5>
                        <div class="col-12 mb-3">
                            <b>User Name: </b></br>
                            <asp:TextBox ID="User_login" CssClass="form-control" runat="server" CausesValidation="true"></asp:TextBox>
                        </div>
                        <div class="col-12 mb-3">
                            <b>Password: </b></br>
                            <asp:TextBox ID="Pass" CssClass="form-control" runat="server" TextMode="Password" CausesValidation="true"></asp:TextBox>
                        </div>
                        <div class="col-12 mb-3">
                            <asp:Button ID="Submit" CssClass=" btn-danger form-control" runat="server" OnClick="Submit_Click" Text="Submit" />
                        </div>
                        <div class="col-12 mb-3">
                            <asp:Label ID="Status" runat="server" Visible="false"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
