<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html>
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList><br />
        <asp:WebPartManager ID="WebPartManager1" runat="server">
        </asp:WebPartManager>
        <br />
        <div style="text-align: center">
            <table width="100%" runat="server" id="webpartTable">
                <tr>
                    <td width="33%" valign="top">
                        <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                            Padding="6" Width="100%">
                            
                            <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                            <MenuLabelHoverStyle ForeColor="#E2DED6" />
                            <EmptyZoneTextStyle Font-Size="0.8em" />
                            <MenuLabelStyle ForeColor="White" />
                            <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid"
                                BorderWidth="1px" ForeColor="#333333" />
                            <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                            <ZoneTemplate>
                                <asp:Label ID="Label1" runat="server" title="My Local Weather" 
                                Text="<script src='http://voap.weather.com/weather/oap/15205?template=GENXH&par=1009624279&unit=0&key=bce0ccdcde3556afd178545e369e6038'></script>" Height="53px">
                                </asp:Label>
                            </ZoneTemplate>
                            <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                            <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                            <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                            <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                                Font-Size="0.6em" />
                            <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                        </asp:WebPartZone>
                        &nbsp;
                    </td>
                    <td width="33%">
                        <asp:WebPartZone ID="WebPartZone2" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                            Padding="6" Width="100%">
                            <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                            <MenuLabelHoverStyle ForeColor="#E2DED6" />
                            <EmptyZoneTextStyle Font-Size="0.8em" />
                            <MenuLabelStyle ForeColor="White" />
                            <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid"
                                BorderWidth="1px" ForeColor="#333333" />
                            <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                            <ZoneTemplate>
                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black"
                                    BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
                                    Height="250px" NextPrevFormat="ShortMonth" Width="330px" Title="Calendar">
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <DayStyle BackColor="#CCCCCC" />
                                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
                                        ForeColor="White" Height="12pt" />
                                </asp:Calendar>
                            </ZoneTemplate>
                            <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                            <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                            <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                            <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                                Font-Size="0.6em" />
                            <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                        </asp:WebPartZone>
                    </td>
                    <td width="33%" valign="top">
                        <asp:WebPartZone ID="WebPartZone3" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                            Padding="6" Width="100%">
                            <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                            <MenuLabelHoverStyle ForeColor="#E2DED6" />
                            <EmptyZoneTextStyle Font-Size="0.8em" />
                            <MenuLabelStyle ForeColor="White" />
                            <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid"
                                BorderWidth="1px" ForeColor="#333333" />
                            <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                            <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                            <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                            <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                            <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                                Font-Size="0.6em" />
                            <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                        </asp:WebPartZone>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>


