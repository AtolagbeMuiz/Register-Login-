<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Register_LoginExcercise.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 131px;
        }
        .auto-style2 {
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td id="lblfullname" class="auto-style1">Full Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtfullname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td id="lblemail" class="auto-style1">Email</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td id="lblpassword" class="auto-style1">Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblerrormessage" runat="server" Text="lblerror"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;<asp:Button ID="Button1" runat="server" Text="Register" OnClick="RegButton_Click" />
                    &nbsp;</td>
                <td>
                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Login.aspx" runat="server">Login</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblsuccessmessage" runat="server" Text="lblsuccess"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
