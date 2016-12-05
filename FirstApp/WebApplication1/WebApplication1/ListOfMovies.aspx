<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfMovies.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            height: 252px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="deleteMovie" SelectMethod="getMoviesBycatID" TypeName="WebApplication1.MovieManager" UpdateMethod="updateMovie" InsertMethod="insertMovie">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="director" Type="String" />
                <asp:Parameter Name="description" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="1" Name="catID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="director" Type="String" />
                <asp:Parameter Name="description" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="getMovieCategories" TypeName="WebApplication1.MovieManager"></asp:ObjectDataSource>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="id" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" AutoPostBack="True" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
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
                        <asp:LinkButton ID="lnkAdd" runat="server" OnClick="insertMovie">Add</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
