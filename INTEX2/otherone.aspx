<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="otherone.aspx.cs" Inherits="INTEX2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Fraud or Not</h1>
        </div>
        <table>
            <tr>
                <td>Category:</td>
                <td><asp:TextBox ID="txtCategory" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Visible in Search:</td>
                <td><asp:RadioButtonList ID="rblVisible" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>Status:</td>
                <td><asp:RadioButtonList ID="rblStatus" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>0</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>Deactivated:</td>
                <td><asp:RadioButtonList ID="rblDeactive" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>State:</td>
                <td><asp:RadioButtonList ID="rblState" runat="server">
                    <asp:ListItem>State</asp:ListItem>
                    <asp:ListItem>Campaignlite</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:LinkButton ID="lbPredict" runat="server" OnClick="lbPredict_Click">Predict</asp:LinkButton></td>
            </tr>
        </table>

        <asp:Label ID="lblResults" runat="server" Font-Size="Large"></asp:Label>
    </form>
</body>
</html>
