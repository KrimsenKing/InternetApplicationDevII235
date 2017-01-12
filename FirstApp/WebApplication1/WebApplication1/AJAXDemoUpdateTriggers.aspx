<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXDemoUpdateTriggers.aspx.cs" Inherits="WebApplication1.AJAXDemoUpdateTriggers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:Button ID="btnTop" runat="server" Text="Top Panel" OnClick="btnTop_Click" />
        <asp:Button ID="btnBottom" runat="server" Text="Bottom Panel" />


        <hr />


        <asp:UpdatePanel UpdateMode="Conditional" ID="udpTop" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblTop" runat="server" Text="Label"></asp:Label>
                Last update: <%=DateTime.Now.ToString() %>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnTop" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel UpdateMode="Conditional" ID="udpBottom" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblBottom" runat="server" Text="Label"></asp:Label>
                Last update: <%=DateTime.Now.ToString() %>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnBottom" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
