<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebUI.aspx.cs" Inherits="Web.WebUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox runat="server" ID="txtnumberOne"></asp:TextBox>
        <asp:TextBox runat="server" ID="txtnumberTwo"></asp:TextBox>
        <asp:button runat="server" ID="btnAction" OnClick="btnAction_Click"></asp:button>
    </form>
</body>
</html>
