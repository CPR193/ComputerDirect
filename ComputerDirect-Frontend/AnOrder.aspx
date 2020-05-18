<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 62px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" style="margin-left: 15px" OnClick="btnFind_Click"/>
        </div>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" style="margin-left: 50px"></asp:TextBox>
        </p>
        
        <p>
            <asp:Label ID="lblOrderTotal" runat="server" Text="Order Total"></asp:Label>
            <asp:TextBox ID="txtOrderTotal" runat="server" style="margin-left: 46px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="margin-left: 40px"></asp:TextBox>
        &nbsp;</p>
        <p>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 70px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status"></asp:Label>
            <asp:CheckBox ID="chkOrderStatus" runat="server" Text="Active" style="margin-left: 35px" OnCheckedChanged="CheckBox1_CheckedChanged"/>
        </p>
        <p>
            <asp:Label ID="lblOrderProgress" runat="server" Text="Order Progress"></asp:Label>
            <asp:TextBox ID="txtOrderProgress" runat="server" style="margin-left: 25px"></asp:TextBox>
        </p>
        <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click"/>
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="margin-left: 10px" OnClick="btnCancel_Click"/>
        <br />
        <br />
        <asp:Label ID="lblOrderLines" runat="server" Text="Order Lines"></asp:Label>
        <asp:Button ID="btnView" runat="server" Text="View" style="margin-left: 15px" OnClick="btnView_Click"/>
        <br />
        <p>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
