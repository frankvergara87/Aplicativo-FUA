<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FissalWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="fresh Gray Bootstrap 3.0 Responsive Theme " />
    <meta name="keywords" content="Template, Theme, web, html5, css3, Bootstrap,Bootstrap 3.0 Responsive Theme" />
    <meta name="author" content="Mindfreakerstuff" />
    <link rel="shortcut icon" href="favicon.png" />

    <title>Fondo Intangible Solidario de Salud </title>
    <!-- Bootstrap core CSS -->
    <link href="./css/bootstrap.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
    <link href="./css/login.css" rel="stylesheet" />
    <link href="./css/animate-custom.css" rel="stylesheet" />


</head>
<body>
    <div class="container" id="login-block">

        <%--PRUEBA--%>
<%--            <div id="iso_fissal" style=" float:left; padding:18px 66px 0 0; width:100%;">
                <a href="http://www.fissal.gob.pe/" target="_blank">
                    <img id="logo1" runat="server" src="~/img/LogoFissal.png" alt="FISSAL" title="FISSAL" />
                </a>
            </div>--%>
        <%--PRUEBA--%>

        <div class="row">
            <div class="col-sm-6 col-md-4 col-sm-offset-3 col-md-offset-4">
                <br />
                <br />
                <div class="login-box clearfix animated flipInY">
                    <div class="login-logo">
                        <a href="#">
                            <img src="img/LogoFissal.png" alt="Company Logo" /></a>
                    </div>
                    <hr />
                    <div class="login-form">
                        <div class="alert alert-error hide">
                            <button type="button" class="close" data-dismiss="alert">&times;</button>
                            <h4>Error!</h4>
                            Your Error Message goes here
                        </div>
                        <form action="#" method="get" runat="server">
                            <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario" required></asp:TextBox>
                            <asp:TextBox ID="txtContraseña" runat="server" placeholder="Contraseña" TextMode="Password" required></asp:TextBox>
                            <asp:Button ID="btnIngresar" runat="server" Text="Entrar" class="btn btn-red" OnClick="btnIngresar_Click" />
                            <div style="text-align:center;">
                                <font color="#CD1D26">
                                <asp:Label ID="lblInformeLogin" runat="server" Text="Mensaje" Font-Size="12px"></asp:Label>
                                </font>
                            </div>
                        </form>
                        <br />
                        <br />
                        <br />

                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- End Login box -->
    <footer class="container">
        <table id="table01" width="100%" style="text-align: center;">
            <tr>
                <td id="footer-text">
                    <small>Fondo Intangible Solidario de Salud </small>
                </td>
            </tr>
            <tr>
                <td id="footer-text">
                    <small>www.fissal.gob.pe</small>
                </td>
            </tr>
        </table>
    </footer>
    <br />
    <br />
    <script src="./js/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="./js/jquery-1.9.1.min.js"><\/script>')</script>
    <script src="./js/bootstrap.min.js"></script>
    <script src="./js/placeholder-shim.min.js"></script>
    <script src="./js/custom.js"></script>
</body>
</html>
