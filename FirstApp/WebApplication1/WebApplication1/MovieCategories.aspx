<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieCategories.aspx.cs" Inherits="WebApplication1.MovieCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Categories</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlMovieCats" runat="server" ConnectionString='<%$ ConnectionStrings:dbMovies2ConnectionString %>' SelectCommand="SELECT [Id], [Name] FROM [MovieCategories]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" DataSourceID="SqlMovieCats" DataTextField="Name" DataValueField="ID"></asp:DropDownList>
        </div>
    <div>

        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                Title:
                <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="TitleLabel" /><br />
                Director:
                <asp:Label Text='<%# Eval("Director") %>' runat="server" ID="DirectorLabel" /><br />
                Description:
                <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:dbMovies2ConnectionString %>' SelectCommand="SELECT [Title], [Director], [Description] FROM [Movies] WHERE ([CategoryId] = @CategoryId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="1" Name="CategoryId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
