<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox_Order" runat="server" Height="168px" Width="269px"></asp:ListBox>
        </div>
        <asp:Button ID="Button_OAdd" runat="server" OnClick="Button_OAdd_Click" Text="Add" />
        <asp:Button ID="Button_ODel" runat="server" OnClick="Button_ODel_Click" Text="Delete" />
        <p>
            <asp:Label ID="Label_OEr" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
