<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label6" runat="server" Text="Show ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server" MaxLength="1" ReadOnly="True"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Find" />
            <br />


            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
            <br />

            <asp:Label ID="Label2" runat="server" Text="Release Date"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="16px"></asp:TextBox>
            <br />

            <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="16px"></asp:TextBox>
            <br />

            <asp:Label ID="Label5" runat="server" Text="Size"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
                <asp:ListItem Value="6"></asp:ListItem>
                <asp:ListItem Value="7"></asp:ListItem>
                <asp:ListItem Value="8"></asp:ListItem>
                <asp:ListItem Value="9"></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
