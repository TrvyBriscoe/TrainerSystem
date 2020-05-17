<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderlineList.aspx.cs" Inherits="OrderlineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 180px">
            <asp:ListBox ID="ListBox_OL" runat="server" Height="183px" Width="315px" OnSelectedIndexChanged="ListBox_OL_SelectedIndexChanged"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="Button_Add" runat="server" OnClick="Button_Add_Click" Text="Add" />
            <asp:Button ID="Button_Edit" runat="server" OnClick="Button_Edit_Click" Text="Edit" />
            <asp:Button ID="ButtonDel" runat="server" OnClick="ButtonDel_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label_Er" runat="server" Text="-"></asp:Label>
        </p>
    </form>
</body>
</html>
