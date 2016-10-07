<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManageRoles.aspx.vb" Inherits="ManageRoles" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 14pt"><strong>Manage User Roles<br />
        </strong><span style="font-size: 12pt">Role Name:
            <asp:TextBox ID="textRolename" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Role" />&nbsp;<br />
            <br />
            </span></span>
        <asp:ListBox ID="listboxRoles" runat="server"></asp:ListBox></div>
    </form>
</body>
</html>
