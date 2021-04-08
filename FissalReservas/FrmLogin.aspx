<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="FissalWebForm.FrmLogin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />

    <title>Login Form</title>
    <meta name="description" content="" />
    <meta name="author" content="" />

    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

    <link rel="stylesheet" href="css2/base.css" />
    <link rel="stylesheet" href="css2/skeleton.css" />
    <link rel="stylesheet" href="css2/layout.css" />

    <link rel="stylesheet" type="text/css" href="~/css/style.css" />
    <link rel="stylesheet" type="text/css" href="~/css/styleFormLogin.css" />


    <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://code.jquery.com/ui/1.10.3/jquery-ui.min.js"></script>
    <script src="https://code.jquery.com/ui/1.10.3/jquery-ui.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />

    <%--MENU--%>
    <link rel="stylesheet" href="css/EstiloMenu.css" />

    <script>
       $(function () {
           $("#<%= btnIngresar.ClientID%>").button()
        });
    </script>

</head>
<body>

    <div class="container">

        <div id="header">
            <div id="iso_fissal">
                <a href="http://www.fissal.gob.pe/" target="_blank">
                    <img id="logo1" runat="server" src="./Images/fissal_iso.png" alt="FISSAL" title="FISSAL" />
                </a>
            </div>
            <div id="iso_minsa">
                <a href="http://www.minsa.gob.pe" target="_blank">
                    <img id="logo2" runat="server" src="./Images/minsa_iso.png" alt="MINSA" title="MINSA" />
                </a>
            </div>
        </div>


        <div style="width: 100%; float:left;"> 
            <div class="form-bg" style="padding-top:40px; padding-bottom:25px;">
                <form runat="server">
                    <h2 style="text-align:center;">Acceso</h2>
                    <p>
                        <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario" style="text-align: left;"></asp:TextBox>
                    </p>
                    <p>
                        <asp:TextBox ID="txtLogin" runat="server" placeholder="Contraseña" TextMode="Password" style="text-align: left;" ></asp:TextBox> 
                    </p>
                    <div>
                        <table width="100%">
                            <tr>
                                <td style="text-align: left; padding-left: 23px;">
                                    <asp:Label ID="lblInformeLogin" runat="server" Text=""></asp:Label>
                                </td>
                                <td style="text-align: right; padding-right: 23px;">
                                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" Width="85px" Height="30px"  />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div>
                        <table width="100%">
                            <tr>
                                <td style="text-align: left; padding-left: 23px;">
                                </td>
                                <td style="text-align:center;">
                                </td>
                                <td style="text-align: right; padding-right: 23px;">
                                </td>
                            </tr>
                        </table>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </form>
            </div>
        </div>

    </div>

</body>
</html>
