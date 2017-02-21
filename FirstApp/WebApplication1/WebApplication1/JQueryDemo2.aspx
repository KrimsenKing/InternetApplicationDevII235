<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQueryDemo2.aspx.cs" Inherits="WebApplication1.JQueryDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        var sat = "Life if good";
        var sun = "Stay home today";
        var now = new Date().getDay();

        $(document).ready(function () {

            // JQuery methods go here
            $("#sat").click(function () {
                $("#horrorscope").html(sat);
            });
            $("#sun").click(function () {
                $("#horrorscope").html(sun);
            });
            $("#mon").click(function () {
                $.get("HorrorScope/Monday.txt", function (h, status) {
                    $("#horrorscope").html(h);
                });
            });
            $.get("HorrorScope/" + now + ".txt", function (h, status) {
                $("#dailyHorrorscope").html(h);
            });
        });

    </script>
    <title></title>
</head>
<body>
    
    <div id="sat">
        Saturday
    </div>
    <div id="sun">
        Sunday
    </div>
    <h2>Click above for your horrorscope</h2>
    <div id="horrorscope">
    </div>
    <hr />
    <div id="mon">
        Monday
    </div>
    <hr />
    Today' s Horrorscope:
    <div id="dailyHorrorscope">
    </div>
</body>
</html>
