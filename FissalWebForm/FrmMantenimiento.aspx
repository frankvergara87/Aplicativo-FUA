﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMantenimiento.aspx.cs" Inherits="FissalWebForm.FrmMantenimiento" %>

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

    <link rel="stylesheet" type="text/css" href="~/css/style.css" />
    <link rel="stylesheet" type="text/css" href="~/css/styleFormLogin.css" />


    <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://code.jquery.com/ui/1.10.3/jquery-ui.min.js"></script>
    <script src="https://code.jquery.com/ui/1.10.3/jquery-ui.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />

    <%--MENU--%>
    <link rel="stylesheet" href="css/EstiloMenu.css" />

</head>
<body>

    <div class="container">
        <div style="width: 100%; float:left;"> <%-- background-color:#EEEEEE;--%>
            <div class="form-bg" style="padding-top:100px; padding-bottom:100px;">
                <form runat="server">
                    <h2 style="text-align:center;">&nbsp;</h2>
                    <h2 style="text-align:center;">Estamos trabajando por ofrecerle un mejor servicio</h2>
                   &nbsp;&nbsp;&nbsp;
<%--                    <asp:Label ID="lblUsuariosConectados" runat="server" Text="[lblUsuarioConectado]"></asp:Label>--%>
                </form>
            </div>
        </div>

        <div  >   <%--id="footer"--%>
            <div id="web">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://fissal.gob.pe/">www.fissal.gob.pe</asp:HyperLink>
            <br />                
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://www.facebook.com/FISSAL.PERU?_rdr">facebook.com/FISSAL.PERU</asp:HyperLink>
            <br />
                <asp:HyperLink ID="HyperLink3" runat="server">E-mail: fissal@sis.gob.pe</asp:HyperLink>
                <br />
            </div>
<%--            <div id="institucional">
                Fondo Intangible Solidario de Salud
            <br />
                Av. Elmer Faucett Nº 150 - San Miguel Lima - Perú 
            <br />
                Teléfonos (511) 628-7092  / 628-7093
            <br />
                Nº de RUC 20546736718
            </div>--%>
        </div>

    </div>




</body>
</html>

