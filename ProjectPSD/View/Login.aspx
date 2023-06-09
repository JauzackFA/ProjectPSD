<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectPSD.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Username" runat="server" Text="Username"></asp:Label> <br />
            <asp:TextBox ID="nametxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label> <br />
            <asp:TextBox ID="passtxt" runat="server"></asp:TextBox> <br />
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>

            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />

        </div>
    </form>
</body>
</html>
