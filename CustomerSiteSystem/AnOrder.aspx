<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 22px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_ONum" runat="server" Text="ONumber"></asp:Label>
            <asp:TextBox ID="TextBox_ONum" runat="server"></asp:TextBox>
            <asp:Button ID="Button_OFind" runat="server" OnClick="Button_OFind_Click" Text="Find" />
        </div>
        <asp:Label ID="Label_CID" runat="server" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="TextBox_CID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label_Notes" runat="server" Text="Notes"></asp:Label>
            <asp:TextBox ID="TextBox_Notes" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label_ODateA" runat="server" Text="Date Added"></asp:Label>
        <asp:TextBox ID="TextBox_DateA" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="CheckBox_OComplete" runat="server" />
        </p>
        <asp:Button ID="Button_OK" runat="server" OnClick="Button_OK_Click" Text="OK" />
        <asp:Button ID="Button_Cancel" runat="server" Text="Cancel" />
        <p>
            <asp:Label ID="Label_OError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
