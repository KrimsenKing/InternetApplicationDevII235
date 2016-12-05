<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="WebApplication1.Repeater2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Repeater</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlMovieCats" runat="server" ConnectionString='<%$ ConnectionStrings:dbMovies2ConnectionString %>' SelectCommand="SELECT [Id], [Name] FROM [MovieCategories]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlMovieCats">
            <ItemTemplate>
               <a href='Repeater.aspx?id=<%#Eval("id")%>'><%#Eval("Name")%></a>
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlMovies" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies2ConnectionString %>" SelectCommand="SELECT [Title], [Director], [Description] FROM [Movies] WHERE ([CategoryId] = @CategoryId)">
            <SelectParameters>
                <asp:QueryStringParameter Name="CategoryId" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlMovies">
            <ItemTemplate>
                Title:
                <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                <br />
                Director:
                <asp:Label ID="DirectorLabel" runat="server" Text='<%# Eval("Director") %>' />
                <br />
                Description:
                <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
