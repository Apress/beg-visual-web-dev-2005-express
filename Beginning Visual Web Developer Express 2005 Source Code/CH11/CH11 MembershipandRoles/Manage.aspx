<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Manage.aspx.vb" Inherits="Manage" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span style="font-size: 14pt">Delete User<br /></span></strong>
            <asp:TextBox ID="textUsername" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Delete" />
            <br />
            <asp:Label ID="labelMessage" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
