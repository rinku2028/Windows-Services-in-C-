<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Windowsservice.aspx.cs" Inherits="Windows_Service.Windowsservice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnstart" Text="Start" runat="server" OnClick="btnstart_Click" />
            <asp:Label ID="lblmessage" Text="" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
