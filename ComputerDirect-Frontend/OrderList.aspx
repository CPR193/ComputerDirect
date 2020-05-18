<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="280px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" Width="350px"></asp:ListBox>
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"/>
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="margin-left: 10px"/>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="margin-left: 10px"/>
        <br />
        <br />
        <asp:Label ID="lblFilter" runat="server" Text="Enter Order Progress Status"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" style="margin-left: 10px" OnClick="btnClear_Click"/>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
