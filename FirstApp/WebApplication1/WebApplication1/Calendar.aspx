﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="WebApplication1.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="calHorrorscope" runat="server" OnDayRender="calHorrorscope_DayRender">

        </asp:Calendar>
    </div>
    </form>
</body>
</html>
