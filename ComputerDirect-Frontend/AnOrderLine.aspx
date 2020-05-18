<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 20px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblItemNo" runat="server" Text="Item ID"></asp:Label>
            <asp:TextBox ID="txtItemNo" runat="server" style="margin-left: 30px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblItemDescription" runat="server" Text="Item Name"></asp:Label>
            <asp:TextBox ID="txtItemDescription" style="margin-left: 10px" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 25px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblUnitCost" runat="server" Text="Item Price"></asp:Label>
            <asp:TextBox ID="txtUnitCost" runat="server" style="margin-left: 15px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="margin-left: 10px"/>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
