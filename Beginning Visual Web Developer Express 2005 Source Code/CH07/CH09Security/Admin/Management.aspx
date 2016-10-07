<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Management.aspx.vb" Inherits="Management" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Orientation="Horizontal"
            StaticDisplayLevels="3">
        </asp:Menu>
        &nbsp;
        
        <h1>
            This page is reserved for managers.</h1>
    </div>
    </form>
</body>
</html>
