<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="Glossary.Config" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width: 100%;">
                <tr>
                    <td>
                         <asp:Panel ID="pnlLogin" runat="server" Visible="true">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                             </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Visible="false">Uploader</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Visible="false">Config</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Visible="false">Comments</asp:LinkButton>
                  
                          &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Visible="false">Logout</asp:LinkButton>
            </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel runat="server" ID="pnlUpload" Visible="false">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload"  />
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel runat="server" Visible="false" ID="pnlConfig">
                            <table style="width: 100%;">
                                <tr>
                                    <td style="width: 100px">text</td>
                                    <td>
                                        <asp:TextBox ID="txtText" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>address</td>
                                    <td>
                                        <asp:TextBox ID="txtAddress" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>tel</td>
                                    <td>
                                        <asp:TextBox ID="txtTel" runat="server" Width="100%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>fax</td>
                                    <td>
                                        <asp:TextBox ID="txtFax" runat="server" Width="100%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>email</td>
                                    <td>
                                        <asp:TextBox ID="txtEmail" runat="server" Width="100%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>url</td>
                                    <td>
                                        <asp:TextBox ID="txtUrl" runat="server" Width="100%"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save Config" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Panel ID="pnlComments" runat="server" Visible="false">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="word" HeaderText="Word" />
                                    <asp:BoundField DataField="text" HeaderText="Text" />
                                    <asp:BoundField DataField="datetime" HeaderText="Time" >
                                     <ItemStyle Width="180px" />
                                    </asp:BoundField>
                                     <asp:TemplateField HeaderText="حذف">
                            <ItemTemplate>
                                <asp:ImageButton ID="imgBtnDelete" OnClientClick="return confirm('آیا محتوای انتخاب شده حذف گردد؟');"
                                    CommandName="DeleteContent" CommandArgument='<%# Eval("ID") %>'
                                    ImageUrl="/assets/img/no.png" runat="server" />
                            </ItemTemplate>
                                         <ItemStyle Width="30px" />
                        </asp:TemplateField>
                                </Columns>
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                <SortedDescendingHeaderStyle BackColor="#820000" />
                            </asp:GridView>
                        </asp:Panel>

                    </td>
                </tr>
                <tr>
                    <td></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
