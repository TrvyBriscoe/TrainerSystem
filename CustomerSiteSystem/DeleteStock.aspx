<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="23px" OnClick="Button1_Click" Text="Yes" Width="50px" />
            <asp:Button ID="Button2" runat="server" Height="23px" Text="No" Width="50px" />
        </div>
    </form>
</body>
</html>
