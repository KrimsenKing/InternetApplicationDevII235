<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Meeting Schedule</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="calMeetings" runat="server" OnDayRender="calMeetings_DayRender" OnSelectionChanged="calMeetings_SelectionChanged"></asp:Calendar>
    </div>
        <p>
        <asp:TextBox ID="mltSession" runat="server" TextMode="MultiLine" Height="96px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </p>
    </form>
</body>
</html>
