<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntexStuff.Default" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>GoFundMe Predictor</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Content/myStyles.css" rel="stylesheet" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
</head>
<body class="centerBody">
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand">GoFundMe Predictor | Coronavirus</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                </ul>
            </div>
        </div>
    </div>
    <div class="centerBody">
    <form id="form1" runat="server">

        <div>
            <h1>Prediction of Current Amount</h1>
            <a href="/" class="btn btn-primary">Home</a>
        </div>
        <hr />
        <div class="centerBody">
        <table class="center">
             <tr>
                <td><strong>Campaign ID:</strong></td>
                <td><asp:TextBox ID="txtCampID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><strong>Auto FB Post Mode:</strong></td>
                <td><asp:RadioButtonList ID="rblFBpost" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td><strong>Category ID:</strong></td>
                <td><asp:TextBox ID="txtCatID" runat="server"></asp:TextBox></td>
            </tr>
           
            <tr>
                <td><strong>Goal:</strong></td>
                <td><asp:TextBox ID="txtGoal" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><strong>Title:</strong></td>
                <td><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><strong>Description:</strong></td>
                <td><asp:TextBox ID="txtDes" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><strong>Has Beneficiary:</strong></td>
                <td><asp:RadioButtonList ID="rblbeneficiary" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td><strong>Country(two letters):</strong></td>
                <td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><strong>Is Charity:</strong></td>
                <td><asp:RadioButtonList ID="rblcharity" runat="server">
                    <asp:ListItem Value="1">True</asp:ListItem>
                    <asp:ListItem Value="0">False</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:LinkButton ID="lbPredict" runat="server" OnClick="lbPredict_Click" CssClass="btn btn-warning">Predict</asp:LinkButton></td>
            </tr>
        </table>
        </div>
    
    <p>This campaign is predicted to reach $</p><asp:Label ID="lblResults" runat="server" Font-Size="Large"></asp:Label>
    </form>
    </div>
    <div class="container body-content">
        <hr />
        <footer>
            <p>&copy;2020 - STOP THE SPREAD</p>
        </footer>
    </div>

    <script src="~/Scripts/jquery-1.10.2.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</body>
</html>



<%-- ORIGINAL DOC --%>



