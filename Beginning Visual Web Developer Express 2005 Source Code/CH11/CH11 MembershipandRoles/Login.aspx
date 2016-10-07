<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span style="font-size: 14pt">Please login before continuing!</span></strong><br />
        <br />
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 100px">
                    Username:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="textUsername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Password:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="textPassword" runat="server" TextMode="Password" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="Button1" runat="server" Text="Login" /></td>
            </tr>
        </table>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Register as a new user.</asp:LinkButton><br />
        <asp:Panel ID="panelNewUser" runat="server" Height="50px" Visible="False" Width="125px">
            <table border="1" style="width: 348px">
                <caption>
                    Create a new user.</caption>
                <tr>
                    <td style="width: 162px">
                        Username:</td>
                    <td style="width: 149px">
                        <asp:TextBox ID="textNewUsername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 162px">
                        Password:</td>
                    <td style="width: 149px">
                        <asp:TextBox ID="textNewPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 162px">
                        Email:</td>
                    <td style="width: 149px">
                        <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 162px">
                        Security Question:</td>
                    <td style="width: 149px">
                        <asp:DropDownList ID="dropdownlistQuestion" runat="server">
                            <asp:ListItem>Pets Name?</asp:ListItem>
                            <asp:ListItem>Mothers Maiden Name</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 162px; height: 21px">
                        Security Question Answer:</td>
                    <td style="width: 149px; height: 21px">
                        <asp:TextBox ID="textAnswer" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="Button2" runat="server" Text="Add User" Width="133px" /><br />
            <br />
            <asp:Label ID="Label1" runat="server" Width="100%"></asp:Label></asp:Panel>
    
    </div>
    </form>
</body>
</html>
