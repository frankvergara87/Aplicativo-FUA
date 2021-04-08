<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMantUsuario.aspx.cs" Inherits="FissalWebForm.Solicitudes.FrmMantUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <!-- Force Latest IE rendering engine -->
    <title>Login Form</title>
    <meta name="description" content="" />
    <meta name="author" content="" />
    <!--[if lt IE 9]sssss>
		<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
	<![endif]-->

    <!-- Mobile Specific Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

    <!-- Stylesheets -->
    <link rel="stylesheet" href="css2/base.css" />
    <link rel="stylesheet" href="css2/skeleton.css" />
    <link rel="stylesheet" href="css2/layout.css" />

  <%--  <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />--%>

    <link rel="stylesheet" type="text/css" href="~/css/style.css" />
    <link rel="stylesheet" type="text/css" href="~/css/styleFormLogin.css" />


    <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://code.jquery.com/ui/1.10.3/jquery-ui.min.js"></script>
    <script src="https://code.jquery.com/ui/1.10.3/jquery-ui.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />

    <%--MENU--%>
    <link rel="stylesheet" href="css/EstiloMenu.css" />
<%--    <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
    <script src="js2/script.js"></script>
    <%--------%>


    <script>
        $(function () {
            $("#<%= btnActualizar.ClientID%>").button();

            $("#<%= btnRegresar.ClientID%>").button()
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

<%--        <div id='cssmenu' style="width: 100%;">
            <ul>
                <li><a href="#"><span>...</span></a></li>
                <li><a href="#"><span></span></a></li>
            </ul>
        </div>--%>

        <div style="width: 100%; float:left;"> <%-- background-color:#EEEEEE;--%>
            <div class="form-bg" style="padding-top:40px; padding-bottom:25px;">
                <form runat="server">
                    <h2 style="text-align:center;">Cambio clave</h2>
                    <p>
                        <asp:TextBox ID="txtUsuario" runat="server" placeholder="Ingrese usuario" style="text-align: left;"></asp:TextBox>
                    </p>
                    <p>
                        <asp:TextBox ID="txtLogin" runat="server" placeholder="Ingrese antigua contraseña" TextMode="Password" style="text-align: left;" ></asp:TextBox> 
                    </p>
                    <p>
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Ingrese nueva contraseña" TextMode="Password" style="text-align: left;" ></asp:TextBox> 
                    </p>
                    <div>
                        <table width="100%">
                            <tr>
                                <td style="text-align: left; padding-left: 23px;">
                                </td>
                                <td style="text-align: right; padding-right: 23px;">
                                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Width="85px" Height="30px"  />
                                    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" Width="85px" Height="30px"  />
                                </td>
                            </tr>
                        </table>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </form>
            </div>
        </div>

<%--        <div id="footer" >
            <div id="web">
                www.fissal.gob.pe
            <br />
                facebook.com/FISSAL.PERU
            <br />
                E-mail: fissal@sis.gob.pe<br />
                <span id="ucPie1_lblContador">018361</span>
            </div>
            <div id="institucional">
                Fondo Intangible Solidario de Salud
            <br />
                Calle Ugarte y Moscoso Nº 450, Ofic. 501 - San Isidro Lima - Perú
            <br />
                Teléfonos (511) 628-7092  / 628-7093
            <br />
                Nº de RUC 20546736718
            </div>
        </div>--%>

    </div>




</body>
</html>
