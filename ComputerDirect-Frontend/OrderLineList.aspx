<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLineList" runat="server" Height="280px" Width="350px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"/>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" style="margin-left: 10px" OnClick="btnEdit_Click"/>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" style="margin-left: 10px" OnClick="btnDelete_Click"/>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" style="margin-left: 10px"/>
        </p>
        <br />
            <asp:Label ID="lblFilter" runat="server" Text="Filter by Order ID"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 20px" Width="50px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" style="margin-left: 10px" OnClick="btnClear_Click"/>
        <br/>
        <p>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
