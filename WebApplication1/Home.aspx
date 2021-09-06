<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="133px" ImageUrl="~/TheTwist_EN-US1554358364_1920x1200.jpg" style="margin-top: 0px" Width="240px" />
            <br />
            ปี ค.ศ. เกิด<asp:TextBox ID="txtYears" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="เข้าสู่ระบบ" />
        </div>
    </form>
</body>
</html>
