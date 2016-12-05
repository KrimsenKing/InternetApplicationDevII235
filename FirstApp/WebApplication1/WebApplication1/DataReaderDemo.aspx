<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReaderDemo.aspx.cs" Inherits="WebApplication1.DataReaderDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" DataKeyNames="Id" runat="server" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>

        </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getMovies" TypeName="WebApplication1.MovieManager" UpdateMethod="updateMovie" DeleteMethod="deleteMovie">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="director" Type="String" />
                <asp:Parameter Name="description" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
