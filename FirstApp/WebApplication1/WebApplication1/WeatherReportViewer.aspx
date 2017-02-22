<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherReportViewer.aspx.cs" Inherits="WebApplication1.WeatherReportViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?key=AIzaSyAmkSKVsRdroxTHS3ZYbo5SHPwdMxOmLrA&sensor=false"></script> 
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.gomap-1.3.3.min.js"></script> 
    <title></title>
<style> 
/* Map */ 
#map { 
    width:700px; 
    height:400px; 
} 
/* Info window size (optional) */ 
.gomapMarker { 
    display: block; 
    width: 150px; 
    height: auto; 
} 
</style>
    <script>
        $(document).ready(function () {
            $("#map").goMap({
                latitude: 50.3196,
                longitude: -105.5349,
                zoom: 4
            });
            num = 0;
            $(".coord").each(function (index) {
                $.goMap.createMarker({
                    latitude: $(this).text().split("x")[0],
                    longitude: $(this).text().split("x")[1],
                    title: 'marker ' + num
                });
                num++;
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlWeatherReport" runat="server" GroupingText="Add a Report">
                <br />
                <table class="auto-style">
                    <tr><td>Lat</td>
                        <td><asp:TextBox ID="txtLat" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Lon</td>
                        <td><asp:TextBox ID="txtLon" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Facing</td>
                        <td><asp:TextBox ID="txtFacing" runat="server"></asp:TextBox></td></tr>
                </table>
                <br />
                <asp:LinkButton ID="btnSubmit" runat="server" OnClick="btnSubmit_Click">Add</asp:LinkButton>
            </asp:Panel>
        </div>
    </form>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbWeatherData %>" SelectCommand="SELECT [Lat], [Lon], [Facing], [TimeSubmitted], [id] FROM [Reports]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <span style="visibility:hidden" class="coord"><%#Eval("Lat")%>x<%#Eval("Lon")%></span>
            </ItemTemplate>
        </asp:Repeater>
    <div id="map">
    </div>
</body>
</html>
