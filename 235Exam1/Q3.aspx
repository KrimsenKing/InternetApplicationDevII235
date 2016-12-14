<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q3.aspx.cs" Inherits="Q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getEmployees" TypeName="EmployeeManager" InsertMethod="insertEmployee" UpdateMethod="updateEmployee">
            <InsertParameters>
                <asp:Parameter Name="employeeID" Type="Int32" />
                <asp:Parameter Name="firstName" Type="String" />
                <asp:Parameter Name="lastName" Type="String" />
                <asp:Parameter Name="jobCode" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="employeeID" Type="Int32" />
                <asp:Parameter Name="firstName" Type="String" />
                <asp:Parameter Name="lastName" Type="String" />
                <asp:Parameter Name="jobCode" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="EmployeeNumber">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="EmployeeNumber" HeaderText="EmployeeNumber" SortExpression="EmployeeNumber" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="JobCode" HeaderText="JobCode" SortExpression="JobCode" />
            </Columns>
        </asp:GridView>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Add Employee">
            <table class="auto-style1">
                <tr>
                    <td>Employee First Name:</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee Last Name:</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Job Title</td>
                    <td>
                        <asp:DropDownList ID="ddlJobCode" runat="server" DataSourceID="SqlDataSource1" DataTextField="JobDescription" DataValueField="JobCode" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbEmp2ConnectionString %>" SelectCommand="SELECT [JobCode], [JobDescription] FROM [Jobs]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="addEmployee" runat="server" Text="Add Employee" OnClick="addEmployee_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
