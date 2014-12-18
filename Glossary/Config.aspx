<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="Glossary.Config" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Visible="False" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload" Visible="False" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel runat="server" Visible="false" ID="pnlConfig">
                        <table style="width: 100%;">
                            <tr>
                                <td style="width: 200px">Title:</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Contact:</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>

                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
                        <Columns>
                            <asp:BoundField DataField="word" HeaderText="Word" />
                            <asp:BoundField DataField="text" HeaderText="Text" />
                            <asp:BoundField DataField="datetime" HeaderText="Time" />
                        </Columns>
                    </asp:GridView>

                </td>
            </tr>
              <tr>
                <td>

                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
