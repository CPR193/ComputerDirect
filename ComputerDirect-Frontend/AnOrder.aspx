<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 62px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 50px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Order Lines ID"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 25px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Order Status"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Active" style="margin-left: 35px"/>
        </p>
        <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Cancel" style="margin-left: 10px"/>
    </form>
</body>
</html>
