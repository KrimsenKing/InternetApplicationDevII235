<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxDemo_Presenting___.aspx.cs" Inherits="WebApplication1.AjaxDemo_Presenting___" %>

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
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel  updateMode="Conditional" ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
     <script type="text/javascript">
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_initializeRequest(prm_initializeRequest);

        function prm_initializeRequest(sender, args) {
            alert("hi");
            if (prm.get_isInAsyncPostBack()) {
                alert('Still Processing First Request');
                args.set_cancel(true);
            }
        }
    </script>
</body>
</html>
