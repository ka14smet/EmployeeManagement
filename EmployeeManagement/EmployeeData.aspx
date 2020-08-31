<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeData.aspx.cs" Inherits="EmployeeManagement.EmployeeData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width:470px">

                <legend> 3 Tier example of Employee Management</legend>

                <table>
                    <tr>
                        <td>Name:</td>
                        <td>
                            <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br />
                        </td>
                    </tr>

                    <tr>
                        <td>Age:</td>
                        <td>
                            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br />
                        </td>
                    </tr>

                    <tr>
                        <td>Email:</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />

                        </td>
                        </tr>
                        <tr>
                            <td colspan ="2">
                                <asp:Label ID="lblStatus" runat="server" ></asp:Label>
                            </td>
                        </tr>
                    
                </table>
            </fieldset>
        </div>
    </form>
</body>
</html>
