<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="AppSite.SearchPage" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="SearchMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div style="align-items:center">
                <asp:Label ID ="NotFound" runat="server" style="font-family:Symbol"></asp:Label>
                <asp:GridView ID="SearchView" runat="server" AutoGenerateColumns="False" OnRowCommand="SearchView_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Icon">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# "~/Apps/"+Eval("AppName")+"/img/"+Eval("IconName") %>' Tooltip='<%# Eval("IconName") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("IconName") %>' ImageUrl='<%# "~/Apps/"+Eval("AppName")+"/img/"+Eval("IconName") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="App Name">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="GoToApp" CommandArgument='<%# Eval("AppName") %>' Text='<%# Eval("AppName") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Extension" HeaderText="Extension" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
            </div>
        </ContentTemplate>
<%--        <Triggers>
            <asp:PostBackTrigger ControlID="SearchView"/>
        </Triggers>--%>
    </asp:UpdatePanel>
</asp:Content>