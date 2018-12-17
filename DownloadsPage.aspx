<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadsPage.aspx.cs" Inherits="AppSite.DownloadsPage" 
        MasterPageFile="~/MainMaster.Master" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="DownloadsPageHead" ContentPlaceHolderID="head" runat="server">
    <style>
        .custom-style{
            font-size : 16px !important;
        }
    </style>
</asp:Content>
<asp:Content ID="DownloadsPageMain" ContentPlaceHolderID="main" runat="server" Visible="true">
    <asp:UpdatePanel runat="server" >
        <ContentTemplate>
                    <asp:GridView ID="gD" runat="server" AutoGenerateColumns="False" OnRowCommand="gD_RowCommand" ShowHeader="False" 
                        GridLines="None" CssClass="card-body" RowStyle-CssClass="card" ClientIDMode="Static" AllowPaging="True" 
                        PageSize="5" OnDataBound="gD_DataBound" AllowCustomPaging="False" PageIndex="0">
                        <Columns>
                            <asp:TemplateField HeaderText="Icon">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("IconName") %>' 
                                        Tooltip='<%# Eval("IconName") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Image CssClass="card-img" Height="200px" Width="200px" ID="Image1" runat="server"  
                                        AlternateText='<%# "~/"+Eval("AppName") +"/img/" + Eval("IconName") %>' 
                                        ImageUrl='<%# "~/Apps/"+Eval("AppName") +"/img/" + Eval("IconName") %>'/>
                                </ItemTemplate>
                                <ItemStyle CssClass="card-header" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="App Name">
                                <ItemTemplate>
                                    <asp:LinkButton CssClass="card-link" ID="LinkButton1" runat="server" Text='<%# Eval("AppName") %>' 
                                        CommandArgument='<%# Eval("AppName") %>' CommandName="DownloadPage"></asp:LinkButton>
                                </ItemTemplate><ItemStyle CssClass="card-footer" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="Extension" HeaderText="Extension"><ItemStyle CssClass="card-footer" /></asp:BoundField>
                            <asp:BoundField DataField="Size" HeaderText="Size" DataFormatString="{0} Kb"><ItemStyle CssClass="card-footer" /></asp:BoundField>
                            <asp:BoundField DataField="Description" HeaderText="Description"><ItemStyle CssClass="card-footer"/></asp:BoundField>
                        </Columns>  
                        <PagerTemplate>
                            <tr style="width:100%; display:table">
                                <td>
                                    <asp:LinkButton ID="PreviousPage" runat="server" OnClick="PreviousPage_Click" CssClass="custom-style">
                                        Previous
                                    </asp:LinkButton>
                                </td>
                                <td>
                                    <asp:DropDownList ID="PageDropDownList" AutoPostBack="true" CssClass="fa-pull-right"
                                        OnSelectedIndexChanged="PageDropDownList_SelectedIndexChanged" runat="server" />
                                </td>
                                <td class="dropdown">
                                    <asp:Label ID="CurrentPageLabel" runat="server" CssClass="custom-style" />
                                </td>
                                <td style="text-align:right">
                                    <asp:LinkButton ID="NextPage" runat="server" OnClick="NextPage_Click" CssClass="custom-style">
                                        Next
                                    </asp:LinkButton>
                                </td>
                            </tr>
                        </PagerTemplate>
                        <RowStyle CssClass="card" />
                    </asp:GridView>         
                <asp:Label ID="ErrorLabel" runat="server" Visible="false"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="gD"/>
        </Triggers>
    </asp:UpdatePanel>
    <script>
    </script>
</asp:Content>

