<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewExercise2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Manager</title>
    <style type="text/css">
        .auto-style1 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Contact Manager</h1>
        <table>
            <tr>
                <td>First Name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                </td>
                <td rowspan = "4" class = "auto-style1">
                    <asp:Panel ID="pnlAddress" runat="server" GroupingText="Address">
                        <table>
                            <tr>
                                <td>Street</td>
                                <td><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>City</td>
                                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>State</td>
                                <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Zip</td>
                                <td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:LinkButton ID="lnkPrevious" runat="server" OnClick="lnkPrevious_Click">&lt;&lt;Previous</asp:LinkButton></td>
                <td class="auto-style1"><asp:LinkButton ID="lnkNext" runat="server" OnClick="lnkNext_Click">Next&gt;&gt;</asp:LinkButton></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" OnClick="btnSaveChanges_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
