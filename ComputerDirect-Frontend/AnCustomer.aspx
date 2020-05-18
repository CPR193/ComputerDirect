<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Checkbox1 {
            width: 34px;
            height: 29px;
            margin-left: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            Guest<input id="Checkbox1" type="checkbox" /></p>
        <p>
            Customer Name<asp:TextBox ID="TextBox6" runat="server" Height="16px" style="margin-left: 19px" Width="144px"></asp:TextBox>
        </p>
        <p>
            Customer Id<asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 45px" Width="144px"></asp:TextBox>
        </p>
        <p>
            Address<asp:TextBox ID="TextBox2" runat="server" Height="16px" style="margin-left: 71px" Width="144px"></asp:TextBox>
        </p>
        <p>
            Email<asp:TextBox ID="TextBox3" runat="server" Height="16px" style="margin-left: 88px" Width="144px"></asp:TextBox>
        </p>
        <p>
            Date Of Birth<asp:TextBox ID="TextBox4" runat="server" Height="16px" style="margin-left: 41px" Width="144px"></asp:TextBox>
        </p>
        <p>
            Date Created
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" style="margin-left: 39px" Width="144px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="OK" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
