<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntexStuff.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>INTEX</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Prediction of Current Amount</h1>
        </div>
        <table>
             <tr>
                <td>Campaign ID:</td>
                <td><asp:TextBox ID="txtCampID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Auto FB Post Mode:</td>
                <td><asp:RadioButtonList ID="rblFBpost" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>Category ID:</td>
                <td><asp:TextBox ID="txtCatID" runat="server"></asp:TextBox></td>
            </tr>
           
            <tr>
                <td>Goal:</td>
                <td><asp:TextBox ID="txtGoal" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Title:</td>
                <td><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description:</td>
                <td><asp:TextBox ID="txtDes" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Has Beneficiary:</td>
                <td><asp:RadioButtonList ID="rblbeneficiary" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>Country(two letters):</td>
                <td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Is Charity:</td>
                <td><asp:RadioButtonList ID="rblcharity" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
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
