<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Tverrfaglig.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Tilbake" runat="server" Text="Tilbake"  OnClick="Tilbake_Click" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="EditArlyText" runat="server" TextMode="MultiLine" Height="500px" Width="500px"></asp:TextBox>
        <br />
        <asp:Button ID="EditArlyTextButton" runat="server" Text="OK" OnClick="EditArlyTextButton_Click" />
        <br />
        <br />
        <br />
        <asp:LoginStatus ID="Logout" runat="server" LogoutText="Logg ut" />
    </form>
</body>
</html>
