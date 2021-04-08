<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FrmReservas.aspx.cs" Inherits="FissalReservas.Páginas.FrmReservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="../css/Formularios.css"  rel="stylesheet"/>
<link href="../css/estiloscontroles.css"  rel="stylesheet"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<fieldset style="background-color:#EEEEEE; border:1px solid #9A99A8">
<legend style="text-align:left;">Búsqueda de Solicitud:</legend>
<table id="PContenido" width="100%">
    <tr><td class="Estilo2"></td></tr>
    <tr>
        <td class="Estilo2">Tipo Documento:</td>
        <td class="Estilo1" colspan="2">
            <asp:DropDownList ID="ddlTipoDocumento" runat="server" Width="90" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoDocumento_SelectedIndexChanged"></asp:DropDownList>
            <asp:TextBox ID="txtPaciente" runat="server" Width="126px"  placeholder="Documento" MaxLength="9" onkeydown = "return validarNumeros(event);"></asp:TextBox>  <%--return (event.keyCode!=13);--%>
        </td>
        <td class="Estilo2"></td>
        <td class="Estilo1">
            <asp:CheckBox ID="chkEnviado" runat="server" onkeydown = "return (event.keyCode!=13);" Visible="False"/>
        </td>
    </tr>


    <tr>
        <td class="Estilo2">Nombres:</td>
        <td class="Estilo1" colspan="2">
            <asp:TextBox ID="txtNomPaciente" runat="server" Width="220px"  placeholder="Nombres Paciente" onkeydown="return validarLetras(event);"></asp:TextBox>  <%--"return (event.keyCode!=13);"--%>
        </td>
        <td class="Estilo2">Apellido Paterno:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtApePatPaciente" runat="server" Width="220px"  placeholder="Apellido Paciente" onkeydown = "return validarLetras(event);" ></asp:TextBox>
        </td>
        <td class="Estilo2"></td>
        <td class="Estilo2"></td>
    </tr>
    <tr>
        <td class="Estilo2">Apellido Materno:</td>
        <td class="Estilo1" colspan="2">
            <asp:TextBox ID="txtApeMatPaciente" runat="server" Width="220px"  placeholder="Apellido Paciente" onkeydown = "return validarLetras(event);" ></asp:TextBox>
        </td>
        <td class="Estilo2">Fecha Solicitud:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtFechaSolicitud" runat="server" Width="128px"  placeholder="Fecha Solicitud" onkeypress="validateDate(this);" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
        </td>
        <td class="Estilo2"></td>
        <td class="Estilo2"></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
    </tr>
</table>
</fieldset>

</asp:Content>
