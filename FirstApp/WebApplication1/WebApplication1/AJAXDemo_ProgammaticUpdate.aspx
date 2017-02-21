<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXDemo_ProgammaticUpdate.aspx.cs" Inherits="WebApplication1.AJAXDemo_ProgammaticUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel updateMode="Conditional" ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Get Movie: <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                <asp:LinkButton ID="lnkBtnMovie" runat="server" OnClick="lnkBtnMovie_Click">Get Movie</asp:LinkButton>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:UpdatePanel updateMode="Conditional" ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:GridView ID="ddlMovie" runat="server"></asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
