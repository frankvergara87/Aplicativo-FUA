<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmReporteSolicitudes.aspx.cs" Inherits="FissalWebForm.Solicitudes.FrmReporteSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Formularios.css"  rel="stylesheet"/>
    <script type="text/javascript">
    function pageLoad() {
        $("#<%= btnExportar.ClientID%>").button();

        <%--        $("#<%= btnExportar.ClientID%>").click(function () {

            var Proc = document.getElementById('<%=ddlReportes.ClientID%>').value; 
            if (Proc != 2) {
                return true;
            } else {
                Dialog('Por favor seleccioneeee..!!');
                return false;
            }

       });-----%>


        $("#<%= txtFechaDesde.ClientID%>").keyup(function () {
            this.value = (this.value + '').replace(/[^a-zA-Z]/g, '');
        });

        $("#<%= txtFechaDesde.ClientID%>").datepicker(
          {
              dateFormat: 'dd/mm/yy',
              //minDate: '+0D',
              //maxDate: '+1Y',
              maxDate: 0,
              changeMonth: true,
              changeYear: true,
              numberOfMonths: 1,
              dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
              monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo',
                  'Junio', 'Julio', 'Agosto', 'Septiembre',
                  'Octubre', 'Noviembre', 'Diciembre'],
              monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr',
                  'May', 'Jun', 'Jul', 'Ago',
                  'Sep', 'Oct', 'Nov', 'Dic']
          });


        $("#<%= txtFechaHasta.ClientID%>").keyup(function () {
            this.value = (this.value + '').replace(/[^a-zA-Z]/g, '');
        });

        $("#<%= txtFechaHasta.ClientID%>").datepicker(
          {
              dateFormat: 'dd/mm/yy',
              //minDate: '+0D',
              //maxDate: '+1Y',
              maxDate: 0,
              changeMonth: true,
              changeYear: true,
              numberOfMonths: 1,
              dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
              monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo',
                  'Junio', 'Julio', 'Agosto', 'Septiembre',
                  'Octubre', 'Noviembre', 'Diciembre'],
              monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr',
                  'May', 'Jun', 'Jul', 'Ago',
                  'Sep', 'Oct', 'Nov', 'Dic']
          });

    }
        function Dialog(Var) {
            $("#PopUp_Dialog").text(Var);

            $("#PopUp_Dialog").dialog({
                title: "Mensaje: Fissal",
                //position: { my: 'top', at: 'top+200' },
                //dialogClass: 'dlgfixed',
                position: "center",
                modal: true,
                resizable: false,
                width: 220,
                height: 90,
                show: { effect: 'fade', duration: 470 },
                hide: { effect: 'fade', duration: 200 },

                open: function (event, ui) {
                    setTimeout("$('#PopUp_Dialog').dialog('close')", 1700);
                }
            });

        }

        //$(".dlgfixed").center(false);


</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering ="true" >
</asp:ScriptManager>

<br />
<fieldset style="background-color:#EEEEEE; border:1px solid #9A99A8"> 
<legend style="text-align:left;">Reportes:</legend>
<table id="PContenido" width="100%">
    <tr><td class="Estilo2"></td></tr>
    <tr><td class="Estilo3" colspan="2">Listado de Solicitudes</td></tr>
    <tr><td class="Estilo3"></td></tr>
    <tr>
        <td class="Estilo3">Fecha Desde:
        </td>
        <td class="Estilo1">
            <asp:TextBox ID="txtFechaDesde" runat="server" Width="110px"  placeholder="Fecha Solicitud" onkeypress="validateDate(this);" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
        </td>
        <td class="Estilo2">Hasta:
        </td>
        <td class="Estilo1">
            <asp:TextBox ID="txtFechaHasta" runat="server" Width="110px"  placeholder="Fecha Solicitud" onkeypress="validateDate(this);" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
        </td>
        <td class="Estilo2">
        </td>
        <td class="Estilo1">
        </td>
        <td class="Estilo2">
        </td>
        <td class="Estilo1">
        </td>
        <td class="Estilo2">
        </td>
        <td class="Estilo1">
        </td>
    </tr>
    <tr>
        <td class="Estilo2"></td>
        <td class="Estilo1">
        </td>
    </tr>
    <tr>
        <td class="Estilo2"></td>
        <td class="Estilo1">
        </td>
        <td class="Estilo2"></td>
        <td class="Estilo1">
        </td>


    </tr>
</table>
<br>
<tr>
    <td>
        <div>
            <HR  width=95% align="center" style="padding-right:15px;padding-left:15px;">
        </div>
    </td>
</tr>

<table id="SContenido2" width="100%">
<tr>
    <td style="padding-left:50px; text-align:right; padding-right:10px;">
        <asp:Button ID="btnExportar" runat="server" Text="Exportar" Width="95px" OnClick="btnExportar_Click" CssClass="BotonEstilo" OnClientClick="return true" />&nbsp                   
    </td>
</tr>
</table>
</fieldset>
</br>
</br>
<div id="PopUp_Dialog">
</div>
</asp:Content>
