<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server">Log Out</asp:LinkButton><br />
        <br />
        <strong><span style="text-decoration: underline"> Account Details:<br />
        </span></strong>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid">
            <tr>
                <td style="width: 110px; height: 19px;" bordercolordark="black">
                    <strong><span style="text-decoration: underline">Order Number</span></strong></td>
                <td style="width: 250px; height: 19px;" bordercolordark="black">
                    <strong><span style="text-decoration: underline">Description</span></strong></td>
                <td style="width: 100px; height: 19px;" bordercolordark="black">
                    <strong><span style="text-decoration: underline">Price</span></strong></td>
            </tr>
            <tr>
                <td style="width: 110px" bordercolordark="black">
                    00123</td>
                <td style="width: 250px" bordercolordark="black">
                    Product one</td>
                <td style="width: 100px" bordercolordark="black">
                    $12.50</td>
            </tr>
            <tr>
                <td style="width: 110px" bordercolordark="black">
                    00124</td>
                <td style="width: 250px" bordercolordark="black">
                    Product two</td>
                <td style="width: 100px" bordercolordark="black">
                    $29.99</td>
            </tr>
            <tr>
                <td style="width: 110px" bordercolordark="black">
                    00125</td>
                <td style="width: 250px" bordercolordark="black">
                    Product three</td>
                <td style="width: 100px" bordercolordark="black">
                    $9.99</td>
            </tr>
            <tr>
                <td style="width: 110px" bordercolordark="black">
                    00126</td>
                <td style="width: 250px" bordercolordark="black">
                    Product four</td>
                <td style="width: 100px" bordercolordark="black">
                    $5.99</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
