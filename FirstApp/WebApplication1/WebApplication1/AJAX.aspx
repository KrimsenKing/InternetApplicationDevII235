<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAX.aspx.cs" Inherits="WebApplication1.AJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        Page Load Time:<asp:Label ID="lblLoadTime" runat="server" Text="Label"></asp:Label>
        
        <br />

        <asp:LinkButton ID="lnkSubmit" runat="server" OnClick="lnkSubmit_Click">Full Submit</asp:LinkButton>

        <asp:UpdatePanel ID="udpPartialUpdatePanel" runat="server">
            <ContentTemplate>
                Partial Page Load Time: <asp:Label ID="lblPartialLoadTime" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:LinkButton ID="lnkPartialSubmit" runat="server" OnClick="lnkPartialSubmit_Click">Partial Submit</asp:LinkButton>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:LinkButton ID="lnkNoAjax" runat="server" OnClick="lnkNoAjax_Click">Not a Partial Submit</asp:LinkButton>
    </div>
    </form>
</body>
</html>
