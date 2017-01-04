<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherReportViewer.aspx.cs" Inherits="WebApplication1.WeatherReportViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="pnlWeatherReport" runat="server" GroupingText="Add a Report">
            <br />
            <table class="auto-style">
                <tr>
                    <td>
                        Lat
                    </td>
                    <td>
                        <asp:TextBox ID="txtLat" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Lon
                    </td>
                    <td>
                        <asp:TextBox ID="txtLon" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Facing
                    </td>
                    <td>
                        <asp:TextBox ID="txtFacing" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
            </table>
            <br />
            <asp:LinkButton ID="btnSubmit" runat="server" OnClick="btnSubmit_Click">Add</asp:LinkButton>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
