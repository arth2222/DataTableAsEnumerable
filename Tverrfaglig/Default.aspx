<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tverrfaglig.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="ArlyText" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Admin" runat="server" Text="Admin" OnClick="Admin_Click" />
        <br />
        <br />
        <br />
        <asp:LoginStatus ID="LoginAndLogout" runat="server" LoginText="Logg inn" LogoutText="Logg ut" /> 
    </form>
</body>
</html>
