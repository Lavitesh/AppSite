<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadsPage.aspx.cs" Inherits="AppSite.DownloadsPage" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="DownloadsPageMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div style="align-items:center">
                <div id="alpha" runat="server">
                    <asp:GridView ID="gD" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnRowCommand="gD_RowCommand">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:TemplateField HeaderText="Icon">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("IconName") %>' Tooltip='<%# Eval("IconName") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" AlternateText='<%# "~/"+Eval("AppName") +"/img/" + Eval("IconName") %>' ImageUrl='<%# "~/Apps/"+Eval("AppName") +"/img/" + Eval("IconName") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="App Name">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("AppName") %>' Text='<%# Eval("AppName") %>' CommandName="DownloadPage"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Extension" HeaderText="Extension" />
                            <asp:BoundField DataField="Size" HeaderText="Size"  />
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                        </Columns>
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </div>
                
                <asp:Label ID="ErrorLabel" runat="server" Visible="false"></asp:Label>
            </div>
        </ContentTemplate>
<%--    <Triggers>
            <asp:PostBackTrigger ControlID=""/>
        </Triggers>--%>
    </asp:UpdatePanel>
</asp:Content>

