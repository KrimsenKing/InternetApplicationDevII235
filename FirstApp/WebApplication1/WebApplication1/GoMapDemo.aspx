<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoMapDemo.aspx.cs" Inherits="WebApplication1.GoMapDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GoMap Demo</title>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?key=AIzaSyAmkSKVsRdroxTHS3ZYbo5SHPwdMxOmLrA&sensor=false"></script> 
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="scripts/jquery.gomap-1.3.3.min.js"></script> 
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
  
    <div id="map">
    
    </div>
    <span class="coord">56.94x-105.7</span>
    <span class="coord">60.94x-105.7</span>
</body>
</html>
