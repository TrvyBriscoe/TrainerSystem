<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrderline.aspx.cs" Inherits="DeleteOrderline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_Words" runat="server" Text="Would you like to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="ButtonYes" runat="server" OnClick="ButtonYes_Click" Text="Yes" />
        <asp:Button ID="ButtonNo" runat="server" Text="No" />
    </form>
</body>
</html>
