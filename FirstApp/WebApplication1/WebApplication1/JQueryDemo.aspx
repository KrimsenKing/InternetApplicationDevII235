<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQueryDemo.aspx.cs" Inherits="WebApplication1.JQueryDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {

            // JQuery methods go here
                $("#btnHide").click(function(){
                    $("p").hide();
                });
                $("#show").click(function() {
                    $("#missingLink").fadeIn(3000).slideUp(2000).slideDown(2000);
                });
                $("#btnShow").click(function () {
                    $("p").show();
                });
        });
    </script>
    <title>JQuery Demo 1</title>
</head>
<body>
    
    <div>
    
        <h2>This is a heading</h2>
        <p>This is a paragraph.</p>
        <p>This is another paragraph.</p>
        <button id="btnHide">Click Me</button>
        <button id="btnShow">Revert</button>
        <hr />
        <p id="show">
            Click to see the magic LINK.
        </p>
        <a id="missingLink" style="display:none" href="http://hasthelargehadroncolliderdestroyedtheworldyet.com/">Is the world destroyed?</a>

    </div>
    
</body>
</html>
