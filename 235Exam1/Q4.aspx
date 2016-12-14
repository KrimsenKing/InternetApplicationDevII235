<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q4.aspx.cs" Inherits="Q4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" OnLoad="Page_Load">
            <ItemTemplate>
               <a href='Q4.aspx?id=<%#Eval("JobCode")%>'><%#Eval("JobCode")%> <%#Eval("JobDescription")%></a>
            </ItemTemplate>
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
