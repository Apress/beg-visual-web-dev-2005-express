<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StandardControls.aspx.vb" Inherits="StandardControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">



<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <asp:TextBox ID="textDisplay" runat="server"></asp:TextBox>&nbsp;
        <asp:Button ID="buttonCopy" runat="server" Text="Copy" />
        <br />
        <br />
        <asp:Label ID="labelDisplay" runat="server"></asp:Label>
        <asp:DropDownList ID="dropdownlistDisplay" runat="server">
        </asp:DropDownList></div>
    </form>
</body>
</html>
