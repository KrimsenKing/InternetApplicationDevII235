<%@ Page Language="C#" AutoEventWireup="true" CodeFile="midTermStudyGuide3.aspx.cs" Inherits="midTermStudyGuide3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" OnPreRender="Page_PreRender">
            <ItemTemplate>
               <a href='Repeater.aspx?id=<%#Eval("id")%>'><%#Eval("Title")%></a>
            </ItemTemplate>
        </asp:Repeater>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
