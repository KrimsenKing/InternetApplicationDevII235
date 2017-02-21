<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewExercise.aspx.cs" Inherits="WebApplication1.ReviewExercise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
       
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <asp:DropDownList ID="ddlMovieCats" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMovieCats_SelectedIndexChanged"></asp:DropDownList>
                <br />
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <span class="MovieTitle"><%#Eval("Title")%>
                            <span style="display:none" class="MovieDetail">
                                <%#Eval("Director")%><br />
                                <%#Eval("Description")%><br />
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
                $(".MovieTitle").each(function(index) {
                    $(this).click(function() {
                        $(this).children().show();
                    });
                });
            });
    </script>
</body>
</html>
