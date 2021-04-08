<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmMantSolicitud.aspx.cs" Inherits="FissalWebForm.Solicitudes.FrmMantSolicitud" %>
<%--<%@ PreviousPageType VirtualPath="~/Solicitudes/FrmSolicitudDetalle.aspx"%>--%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../css/Formularios.css"  rel="stylesheet"/>
     <link href="../css/estiloscontroles.css"  rel="stylesheet"/>

    <script type="text/javascript">
        function pageLoad() {  

<%--            $("#<%= txtPaciente.ClientID%>").keyup(function () {
                this.value = (this.value + '').replace(/[^0-9]/g, '');
            });

            $("#<%= txtNomPaciente.ClientID%>").keyup(function () {
                this.value = (this.value + '').replace(/[^A-Za-zñÑ ]/g, '');
            });

            $("#<%= txtApeMatPaciente.ClientID%>").keyup(function () {
                this.value = (this.value + '').replace(/[^a-zA-ZñÑ ]/g, '');
            });

            $("#<%= txtApePatPaciente.ClientID%>").keyup(function () {
                this.value = (this.value + '').replace(/[^a-zA-ZñÑ ]/g, '');
            });--%>
       

            function validateDate(testdate) {
                var date_regex = /^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$/;
                return date_regex.test(testdate);
            }



            $("#<%= btnBuscar.ClientID%>").button();
            $("#<%= btnLimpiar.ClientID%>").button();  
            

            $("#<%= txtFechaSolicitud.ClientID%>").keyup(function () {
                this.value = (this.value + '').replace(/[^a-zA-Z]/g, '');
            });

            $("#<%= txtFechaSolicitud.ClientID%>").datepicker(
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



            <%--            $("#<%= txtNumSolicitud.ClientID %>").keypress(function (e) {
                if (e.which == 13) {

                    //document.getElementById("btnBuscar").click();
                    //__doPostBack("#<%= btnBuscar.UniqueID %>", "OnClick");

                    $.ajax({
                        type: "POST",
                        url: "FrmMantSolicitud.aspx/btnBuscar_Click",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json"
                    });

                    return false;
                }
            });--%>




        }


        function validarLetras(e) {  
            tecla = (document.all) ? e.keyCode : e.which;
            //tecla = e.keyCode ? e.keyCode : e.which;
            if (tecla == 8) return true;  // backspace
            if (tecla == 13) return false;  // ENTER
            if (tecla == 32) return true; // espacio
            if (tecla == 37) return true; // IzQuierda
            if (tecla == 39) return true; // DereCha
            if (tecla == 46) return true; // SuPrimir

            if (tecla == 190) return false; // punto
            if (tecla == 188) return false; // coma
            if (tecla == 189) return false; // GUION
            if (tecla == 111) return false; // slash

            if (tecla == 106) return false; // +
            if (tecla == 107) return false; // -
            if (tecla == 109) return false; // *

            if (tecla == 219) return false; // 
            if (tecla == 221) return false; // 
            if (tecla == 186) return false; // 
            if (tecla == 106) return false; // 
            if (tecla == 187) return false; // 
            if (tecla == 222) return false; //   
            if (tecla == 191) return false; //   

            if (tecla == 96) return false; // 
            if (tecla == 97) return false;  //  
            if (tecla == 98) return false;  //  
            if (tecla == 99) return false;  //  
            if (tecla == 100) return false; //  
            if (tecla == 101) return false; //  
            if (tecla == 102) return false; //  
            if (tecla == 103) return false; //  
            if (tecla == 104) return false; //  
            if (tecla == 105) return false; //  
            if (tecla == 110) return false; // 
            if (tecla == 220) return false; // 

            if (e.ctrlKey && tecla == 86) { return true; } //Ctrl v
            if (e.ctrlKey && tecla == 67) { return true; } //Ctrl c
            if (e.ctrlKey && tecla == 88) { return true; } //Ctrl x

            if (tecla == 8) return true;
            patron = /^[a-zA-ZñÑ\s\W]/;
            te = String.fromCharCode(tecla);
            return patron.test(te);

        }

        function validarNumeros(e) {
            tecla = (document.all) ? e.keyCode : e.which;
            //tecla = e.keyCode ? e.keyCode : e.which;
            if (tecla == 8) return true;  // backspace
            if (tecla == 13) return false;  // ENTER
            if (tecla == 32) return false; // espacio
            if (tecla == 37) return true; // IzQuierda
            if (tecla == 39) return true; // DereCha
            if (tecla == 46) return true; // SuPrimir

            if (tecla == 190) return false; // punto
            if (tecla == 188) return false; // coma
            if (tecla == 189) return false; // GUION
            if (tecla == 111) return false; // slash

            if (tecla == 106) return false; // +
            if (tecla == 107) return false; // -
            if (tecla == 109) return false; // *

            if (tecla == 219) return false; // 
            if (tecla == 221) return false; // 
            if (tecla == 186) return false; // 
            if (tecla == 106) return false; // 
            if (tecla == 187) return false; // 
            if (tecla == 222) return false; //   
            if (tecla == 191) return false; //   

            if (tecla == 96) return true; // 
            if (tecla == 97) return true;  //  
            if (tecla == 98) return true;  //  
            if (tecla == 99) return true;  //  
            if (tecla == 100) return true; //  
            if (tecla == 101) return true; //  
            if (tecla == 102) return true; //  
            if (tecla == 103) return true; //  
            if (tecla == 104) return true; //  
            if (tecla == 105) return true; // 

            if (tecla == 110) return false; // 
            if (tecla == 220) return false; // 
 

            if (e.ctrlKey && tecla == 86) { return true; } //Ctrl v
            if (e.ctrlKey && tecla == 67) { return true; } //Ctrl c
            if (e.ctrlKey && tecla == 88) { return true; } //Ctrl x

            if (tecla == 8) return true;
            patron = /^[0-9\s\W]/;
            te = String.fromCharCode(tecla);
            return patron.test(te);

        }

    </script>


    <style>
        .HiddenCol{display:none;}                
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering ="true" >
</asp:ScriptManager>
<br />

<div class="resoluciones">
    ESTABLECIMIENTO : 
    <asp:Label ID="lblEstablecimiento" runat="server" Text="Establecimiento"></asp:Label>
    </br>
    USUARIO :
    <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
    </br> 
</div>

<tr>
    <td>&nbsp;</td>
</tr>

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
<%--    <tr>
        <td class="Estilo2"></td>
        <td class="Estilo1">
        </td>
        <td class="Estilo2">Enviado:</td>
        <td class="Estilo1">
        </td>
    </tr>--%>
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
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" Width="95px" OnClick="btnLimpiar_Click" CssClass="BotonEstilo" OnClientClick="return true" />&nbsp                   
        <asp:Button ID="btnBuscar"  runat="server" Text="Buscar"  Width="95px" OnClick="btnBuscar_Click"  CssClass="BotonEstilo" OnClientClick="return true" />    
    </td>
</tr>
</table>
</fieldset>

<tr>
    <td>&nbsp;</td>
</tr>

<tr>
    <td>&nbsp;</td>
</tr>
    
<fieldset style="background-color:#EEEEEE; border:1px solid #9A99A8">
<legend style="text-align:left;">Listado Solicitudes:</legend>
<table id="SContenido" width="100%">

<tr>
    <td>
        <div style ="text-align:right; padding-right:7px; position:relative;">
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Mantenimiento/Ok.ico" Width="22px" Height="22px" style="position:relative;top:7px; left: 0px;"/>&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Procesado"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image4"   runat="server" ImageUrl="~/Images/Mantenimiento/NoProcesado.ico"   Width="18px" Height="18px" style="position:relative;top:6px; left: 0px;"/>&nbsp;
            <asp:Label ID="Label4"   runat="server" Text="No Procesado"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<%--            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Mantenimiento/Edit1.ico" Width="19px" Height="19px" style="position:relative;top:7px; left: 0px;"/>&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Editable"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2"   runat="server" ImageUrl="~/Images/Mantenimiento/Edit2.ico"   Width="19px" Height="19px" style="position:relative;top:7px; left: 0px;"/>&nbsp;
            <asp:Label ID="Label2"   runat="server" Text="No Editable"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="imgLeyendaPendiente" runat="server" ImageUrl="~/Images/Mantenimiento/Send.ico" Width="20px" Height="20px" style="position:relative;top:9px; left: 0px;"/>&nbsp;
            <asp:Label ID="lblLeyendaPendiente" runat="server" Text="Pendiente"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;--%>
            <asp:Image ID="imgLeyendaEnviado"   runat="server" ImageUrl="~/Images/Mantenimiento/Ok.ico"   Width="15px" Height="15px" style="position:relative;top:4px; left: 0px;"/>&nbsp;
            <asp:Label ID="lblLeyendaEnviado"   runat="server" Text="Enviado"></asp:Label>
        </div>
    </td>
</tr>
<tr>
    <td>
        <div>
            <HR  width=35% align="right">
        </div>
    </td>
</tr>
<tr>
<td>

        <asp:GridView ID="gvListaSolicitudes" runat="server" EmptyDataText="La Lista no contiene Datos" Width="100%"
        AllowPaging="True"
        PageSize="10"
        OnPageIndexChanging="gvListaSolicitudes_PageIndexChanging"
        onrowcommand="gvListaSolicitudes_RowCommand" 
        DataKeyNames="Nro_Solicitud"
        AutoGenerateColumns="False"
        BorderWidth="1px" BackColor="#FFFFBB" 
        CellPadding="3" CellSpacing="2" BorderStyle="None" 
        BorderColor="#DEBA84" OnRowDataBound="gvListaSolicitudes_RowDataBound">
        <FooterStyle ForeColor="#293955" BackColor="#FFFFE1"></FooterStyle>
        <PagerStyle ForeColor="#293955"  HorizontalAlign="Center"></PagerStyle>
        <HeaderStyle ForeColor="White" Font-Bold="True" BackColor="#CD1D26"></HeaderStyle>

        <Columns>
            <asp:BoundField HeaderText="Nro Solicitud"
            DataField="Nro_Solicitud"
            SortExpression="Nro_Solicitud">
            <ItemStyle Width="80px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="IPRESS"
            DataField="EstablecimientoId"
            SortExpression="EstablecimientoId">
            <ItemStyle Width="40px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Fecha Solicitud" 
            DataField="Fecha_Solicitud" DataFormatString="{0:dd/MM/yyyy}"
            SortExpression="Fecha_Solicitud">
            <ItemStyle Width="60px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Historia Clínica" 
            DataField="Historia" 
            SortExpression="Historia">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Tipo Documento" 
            DataField="Tipo_Documento" 
            SortExpression="Tipo_Documento">
            <ItemStyle Width="50px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Número Documento" 
            DataField="NumeroDocumento" 
            SortExpression="NumeroDocumento">
            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="80px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Nombres" 
            DataField="Nombres" 
            SortExpression="Nombres">
            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left" Width="300px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Fecha Nacimiento" 
            DataField="Fecha_Nacimiento"  DataFormatString="{0:dd/MM/yyyy}"
            SortExpression="Fecha_Nacimiento">
            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" Width="60px" />
            </asp:BoundField>


            <asp:BoundField HeaderText="Sexo" 
            DataField="Sexo" 
            SortExpression="Sexo">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="40px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Regimen" 
            DataField="Regimen" 
            SortExpression="Regimen">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="75px" />
            </asp:BoundField>


            <asp:BoundField HeaderText="Enviado"
            DataField="Enviado" 
            SortExpression="Enviado">
            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Procesado"
            DataField="Procesado" 
            SortExpression="Procesado">
            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:TemplateField HeaderText="Enviado" >
                <ItemTemplate>
                    <asp:ImageButton ID="ImgEnviar" runat="server" ImageAlign="Middle" Width="25px" Height="25px" Enabled="true"
                        ImageUrl="~/Images/Mantenimiento/Send.ico" CommandName="ImgEnviar"  CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'      
                        OnClientClick="return confirm('¿Desea Enviar esta Solicitud?');"  />
                </ItemTemplate>
                <ItemStyle Width="50px" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Editar" >
                <ItemTemplate>
                    <asp:ImageButton ID="ImgVer" runat="server" ImageAlign="Middle" Width="25px" Height="25px" Enabled="true"
                        ImageUrl="~/Images/Mantenimiento/Edit1.ico" CommandName="ImgVer"  CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'/>
                </ItemTemplate>
                <ItemStyle Width="50px" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Procesado" >
                <ItemTemplate>
                    <asp:ImageButton ID="ImgProcesado" runat="server" ImageAlign="Middle" Width="25px" Height="25px" 
                        ImageUrl="~/Images/Mantenimiento/NoProcesado.ico"
                        CommandName="ImgProcesado"  CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'/>
                </ItemTemplate>
                <ItemStyle Width="50px" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Eliminar" >
                <ItemTemplate>
                    <asp:ImageButton ID="ImgEliminar" runat="server" ImageAlign="Middle" Width="35px" Height="35px" 
                        ImageUrl="~/Images/Mantenimiento/tacho.ico" CommandName="ImgEliminar"  CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'
                        OnClientClick="return confirm('¿Desea Eliminar esta Solicitud?');"  />
                </ItemTemplate>
                <ItemStyle Width="60px" />
            </asp:TemplateField>

        </Columns>

        <SelectedRowStyle ForeColor="White" Font-Bold="True" 
        BackColor="#6C8497"></SelectedRowStyle>
        <RowStyle ForeColor="#293955" 
        BackColor="#FFFFFF"></RowStyle>

        </asp:GridView>        

    <br />
</td>
</tr>

<%--<tr>
    <td>
        <div>
            <HR  width=15% align="right">
        </div>
    </td>
</tr>
<tr>
    <td style="padding-left:50px; text-align:right; padding-right:10px;">
        <asp:Button ID="btnExportarExcel" runat="server" Text="Exportar" Width="95px" OnClick="btnExportarExcel_Click" CssClass="BotonEstilo" OnClientClick="return true" />&nbsp                   
    </td>
</tr>--%>
</table>
</br>
</fieldset>




</asp:Content>
