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
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" onClick="btnSubmit_Click" />

                        </td>
                        </tr>
                        <tr>
                            <td colspan ="2">
                                <asp:Label ID="lblStatus" runat="server" ></asp:Label>
                            </td>
                        </tr>
                    
                </table>

                <asp:GridView ID="grdEmpDetails" runat="server" DataKeyNames="Id"
                    AutoGenerateColumns="false"
                    onpageindexchanging="grdEmpDetails_PageIndexChanging"
                    onrowcancelingedit="grdEmpDetails_RowcancelingEdit"
                    onrowediting="grdEmpDetails_RowEditing"
                    onrowupdating="grdEmpDetails_RowUpdating"
                    AllowPaging="True" PageSize="5"
                    CellPadding="4" ForeColor="Blue" GridLines="None">
                    
                    <AlternatingRowStyle BackColor="White" ForeColor="LightCoral" />

                    <Columns>
                        <asp:TemplateField HeaderText="Employee ID">
                            <ItemTemplate>
                                <asp:Label ID="lblEmpID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtEmpIDEdit" runat="server" Text='<%#Eval("ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Employee Name">
                            <ItemTemplate>
                                <asp:Label ID="lblEmpName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtEmpnameEdit" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Employee Age">
                            <ItemTemplate>
                                <asp:Label ID="lblEmpAge" runat="server" Text='<%#Eval("Age") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtEmpAgeEdit" runat="server" Text='<%#Eval("Age") %>'></asp:TextBox>
                            </EditItemTemplate>
                    </asp:TemplateField>

                        <asp:TemplateField HeaderText="Employee Email">
                            <ItemTemplate>
                                <asp:Label ID="lblEmpEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtEmpEmailEdit" runat="server" Text='<%#Eval("Email") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Button ID="imgEdit" runat="server" CommandName="Edit" Text="Edit" CausesValidation="false" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:LinkButton ID="lnkUpdate" runat="server" Text="Update" CommandName="Update" CausesValidation="false" />
                                <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel" CausesValidation="false" />

                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                    <EditRowStyle BackColor="#42b3f5" />
                    <FooterStyle BackColor ="#42b3f5" Font-Bold="true" ForeColor="White" />
                    <HeaderStyle BackColor ="#5D789D" Font-Bold="true" ForeColor="White" />
                    <PagerStyle BackColor ="#a742f5" Font-Bold="true" ForeColor="White" />

                    <RowStyle BackColor ="#ddf542" Font-Bold="true" ForeColor="White" />
                    </asp:GridView>
            </fieldset>
        </div>
    </form>
</body>
</html>
