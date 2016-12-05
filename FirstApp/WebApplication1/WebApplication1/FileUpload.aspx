<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="fupUploader" runat="server" />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <br />
        <br />
        <asp:DataList ID="dtlstImage" runat="server">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" style="width:200px" 
                    ImageUrl='<%# Eval("Name", "~/UploadedFiles/{0}") %>' />
                
                <br />
                <%# Eval("Name") %> <a href='FileUpload.aspx?id=<%# Eval("Name")%>'>Delete</a><br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
