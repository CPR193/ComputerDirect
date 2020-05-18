<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrderLine.aspx.cs" Inherits="DeleteOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Are you sure you want to delete this record?</b><br />
            <br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" style="margin-left: 10px"/>
        </div>
    </form>
</body>
</html>
