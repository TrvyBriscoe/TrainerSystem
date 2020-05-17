<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_Decision" runat="server" Text="Would you like to delete this order?"></asp:Label>
        </div>
        <asp:Button ID="Button_Yes" runat="server" OnClick="Button_Yes_Click" Text="Yes" />
        <asp:Button ID="Button_No" runat="server" Text="No" />
    </form>
</body>
</html>
