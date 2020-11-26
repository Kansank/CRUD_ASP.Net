<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PhoneBookApp.WebForm1" %>

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
                    <td>
                        Name:
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Phone Number
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Address
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                   
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
