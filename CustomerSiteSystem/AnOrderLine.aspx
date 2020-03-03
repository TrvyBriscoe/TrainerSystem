<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 448px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label_OrderLine" runat="server" Text="Order Line Number"></asp:Label>
        <asp:TextBox ID="TextBox_Find" runat="server"></asp:TextBox>
        <asp:Button ID="Button_Find" runat="server" Text="Find" />
        <asp:Label ID="Label_OrderLONumber" runat="server" Text="Order Number"></asp:Label>
        <asp:TextBox ID="TextBox_OrderLONumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label_OrderLQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="TextBox_OrderLQuantity" runat="server" OnTextChanged="TextBox_OrderLQuantity_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="ShoeID"></asp:Label>
        <asp:TextBox ID="TextBox_ShoeID" runat="server"></asp:TextBox>
        <asp:Label ID="Label_OrderLError" runat="server" Text="Error"></asp:Label>
        <asp:Button ID="Button_OrderLOK" runat="server" OnClick="Button_OrderLOK_Click" Text="OK" />
        <asp:Button ID="Button_OrderLCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
