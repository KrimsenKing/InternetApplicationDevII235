<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXDemo2.aspx.cs" Inherits="WebApplication1.AJAXDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cascading Controls</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


        <asp:SqlDataSource ID="SqlCategories" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies2ConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [MovieCategories]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlMovies" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies2ConnectionString %>" SelectCommand="SELECT [Id], [CategoryId], [Title], [Director], [InTheaters] FROM [Movies] WHERE ([CategoryId] = @CategoryId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="1" Name="CategoryId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlSelectedMovie" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies2ConnectionString %>" SelectCommand="SELECT [Title], [Director], [Id], [InTheaters], [Description] FROM [Movies] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" DefaultValue="1" Name="Id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlCategories" DataTextField="Name" DataValueField="Id" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlMovies" DataTextField="Title" DataValueField="Id" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" DataSourceID="SqlSelectedMovie">
                    <ItemTemplate>
                        Title:
                        <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                        <br />
                        Director:
                        <asp:Label ID="DirectorLabel" runat="server" Text='<%# Eval("Director") %>' />
                        <br />
                        Id:
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                        <br />
                        InTheaters:
                        <asp:Label ID="InTheatersLabel" runat="server" Text='<%# Eval("InTheaters") %>' />
                        <br />
                        Description:
                        <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
            </ContentTemplate>
        </asp:UpdatePanel>
        

    </div>
    </form>
</body>
</html>
