<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewDemo.aspx.cs" Inherits="WebApplication1.GridViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grid View Demo</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 252px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:SqlDataSource ID="sqlMovies" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies2ConnectionString %>" 
            SelectCommand="SELECT [Director], [InTheaters], [Id], [Title] FROM [Movies]" 
            DeleteCommand="DELETE FROM [Movies] WHERE [Id] = @Id" 
            InsertCommand="INSERT INTO [Movies] ([Director], [InTheaters], [Title], [CategoryID], [Description]) VALUES (@Director, @InTheaters, @Title, @CategoryID, @Description)"
            UpdateCommand="UPDATE [Movies] SET [Director] = @Director, [InTheaters] = @InTheaters, [Title] = @Title WHERE [Id] = @Id">
            
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Director" Type="String" />
                <asp:Parameter Name="InTheaters" Type="Boolean" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="CategoryID" />
                <asp:Parameter Name="Description" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Director" Type="String" />
                <asp:Parameter Name="InTheaters" Type="Boolean" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="sqlMovieCategories" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies2ConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [MovieCategories]"></asp:SqlDataSource>
        <asp:GridView ID="grdMovies" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sqlMovies" AutoGenerateEditButton="True">
            <Columns>

                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Director" HeaderText="Director" SortExpression="Director" />
                <asp:CheckBoxField DataField="InTheaters" HeaderText="InTheaters" SortExpression="InTheaters" />
                
            </Columns>
        </asp:GridView>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Add Panel">
            <table class="auto-style1">
                <tr>
                    <td>Title:</td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Director:</td>
                    <td>
                        <asp:TextBox ID="txtDirector" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Now Playing:</td>
                    <td>
                        <asp:CheckBox ID="chkNowPlaying" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Category</td>
                    <td>
                        <asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="sqlMovieCategories" DataTextField="Name" DataValueField="Id">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Description:</td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server" Height="92px" TextMode="MultiLine" Width="336px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:LinkButton ID="lnkAdd" runat="server" OnClick="lnkAdd_Click">Add</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
