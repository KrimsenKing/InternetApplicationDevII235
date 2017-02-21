<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comp235Test2.aspx.cs" Inherits="WebApplication1.Comp235Test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Comp 235 Test 2</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="tbStockCode" runat="server"></asp:TextBox>
                <asp:Button ID="btnLookUpStock" runat="server" Text="Look Up" OnClick="btnLookUpStock_Click" />
                <asp:DataList ID="dlStockListing" runat="server">
                     <ItemTemplate>
                        <span class="StockCodes"><%#Eval("StockCode")%><br />
                            <span style="display:none" class="StockDetail">
                                <%#Eval("StockName")%><br />
                                <%#Eval("Quantity")%><br />
                                <%#Eval("Price")%><br />
                                <hr />
                            </span>
                        </span>
                    </ItemTemplate>
                </asp:DataList>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>

    <script>
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_endRequest(function() {
                $(".StockCodes").each(function(index) {
                    $(this).click(function() {
                        $(this).children().show();
                    });
                });
            });
    </script>

</body>
</html>
