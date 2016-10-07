<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
        &nbsp;</div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Invoices.aspx?InvoiceID=100">Invoice ID: 100</asp:HyperLink><br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Invoices.aspx?InvoiceID=101">Invoice ID: 101</asp:HyperLink><br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Invoices.aspx?InvoiceID=102">Invoice ID: 102</asp:HyperLink><br />
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Invoices.aspx?InvoiceID=103">Invoice ID: 103</asp:HyperLink><br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Invoices.aspx?InvoiceID=104">Invoice ID: 104</asp:HyperLink>
    </form>
</body>
</html>
