<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="KullaniciMetot1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Burası WebForm2 sayfasıdır.<br />
            <asp:Label ID="Label1" runat="server" Text="WebForm1 Sayfasından Gelen Sonuç="></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">WebForm1&#39;e Git</asp:HyperLink>
        </div>
    </form>
</body>
</html>
