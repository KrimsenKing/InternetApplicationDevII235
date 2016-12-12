<%@ Page Language="C#" AutoEventWireup="true" CodeFile="midTermStudyGuide5.aspx.cs" Inherits="midTermStudyGuide5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="MovieLibrary.Categories" SelectMethod="getMovieCategories" TypeName="MovieLibrary.MovieData" UpdateMethod="CategoryUpdate"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
