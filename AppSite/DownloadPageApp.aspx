<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadPageApp.aspx.cs" Inherits="AppSite.DownloadPageApp" MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="DownloadAppMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
            <div style="align-items:center" runat="server" id ="Divisiona">
                <asp:Label ID="beta" runat="server" Visible="false"></asp:Label><br />
                <asp:GridView ID="Gd" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="Gd_RowCommand" >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField HeaderText="Icon">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("IconName") %>' Tooltip='<%# Eval("IconName") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("IconName") %>' ImageUrl='<%# "~/Apps/"+Eval("AppName")+"/img/"+Eval("IconName") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="AppName" HeaderText="Filename" />
                        <asp:BoundField DataField="Extension" HeaderText="Extension" />
                        <asp:ButtonField CommandName="Download" Text="Download" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>

            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Gd" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>