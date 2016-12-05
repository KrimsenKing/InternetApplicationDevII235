<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewExercise1.aspx.cs" Inherits="WebApplication1.ReviewExersice1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td>Quantity</td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server" Width="120px" BorderColor="#0066FF" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Distance</td>
                <td>
                    <asp:TextBox ID="txtDistance" runat="server" Width="120px" BorderColor="#0066FF" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Shipping Type</td>
                <td>
                    <asp:DropDownList ID="drpShippingType" runat="server" OnSelectedIndexChanged="drpShippingType_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Value="0">Ground</asp:ListItem>
                        <asp:ListItem Value="0.05">Priority Ground</asp:ListItem>
                        <asp:ListItem Value="0.1">Air</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Shipping Fee</td>
                <td>
                    <asp:Label ID="lblShippingFee" runat="server" Height="20px" width="120px" BorderColor="#0066FF" BorderStyle="Solid"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Shipping Cost</td>
                <td>
                    <asp:Label ID="lblShippingCost" runat="server" Height="20px" width="120px" BorderColor="#0066FF" BorderStyle="Solid"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
