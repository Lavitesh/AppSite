<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="AppSite.AboutUs" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="AboutUsMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div>
                <p>This is About Us Page.</p>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>