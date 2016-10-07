<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ChangePassword.aspx.vb" Inherits="ChangePassword" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span style="font-size: 14pt">Change Password<br />
            <br />
        </span></strong>
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 126px">
                    Current Password:</td>
                <td style="width: 127px">
                    <asp:TextBox ID="textOldPassword" runat="server" TextMode="Password" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 126px">
                    New Password:</td>
                <td style="width: 127px">
                    <asp:TextBox ID="textNewPassword" runat="server" TextMode="Password" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 126px">
                </td>
                <td style="width: 127px">
                    <asp:Button ID="Button1" runat="server" Text="Update Password" /></td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:Label ID="labelMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
