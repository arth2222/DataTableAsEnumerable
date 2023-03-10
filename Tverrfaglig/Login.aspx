<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tverrfaglig.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Tilbake" runat="server" Text="Tilbake" OnClick="Tibake_Click"/>
        <br />
        <br />
        <br />
        Skriv inn passord for admin for å logge inn
        <br />
        <asp:TextBox ID="passwordTextbox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Logg inn" OnClick="LoggInn_Click" />
        <asp:Label ID="WrongPassword" runat="server" Text="Passordet er feil!" Visible="false"></asp:Label>
    </form>
</body>
</html>
