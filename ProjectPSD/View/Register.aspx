<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectPSD.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> <br />
            <asp:TextBox ID="usernametxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label> <br />
            <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label> <br />
            <asp:TextBox ID="gendertxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label> <br />
            <asp:TextBox ID="passtxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label5" runat="server" Text="Confirmation Password"></asp:Label> <br />
            <asp:TextBox ID="conpasstxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Errtxt" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="RegistBtn" runat="server" Text="Regist" OnClick="RegistBtn_Click" />
        </div>
    </form>
</body>
</html>
