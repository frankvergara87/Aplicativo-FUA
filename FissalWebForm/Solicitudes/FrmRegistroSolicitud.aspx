<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmRegistroSolicitud.aspx.cs" Inherits="FissalWebForm.Solicitudes.FrmSolicitudes" %>
<%@ PreviousPageType VirtualPath="~/Solicitudes/FrmMantSolicitud.aspx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../css/Formularios.css" rel="stylesheet" />



    <script type="text/javascript">

        function pageLoad() {

            //CODIGOS QUE SE INICIALIZAN AL MOMENTO DE CARGAR ESTE FORMULARIO    
            //ESTILOS PARA BOTONES Y OTROS CONTROLES

            $("#<%= btnGuardar.ClientID%>").button();
            $("#<%= btnGuardarEnviar.ClientID%>").button();
            $("#<%= btnRegresar.ClientID%>").button();
            $("#<%= btnNuevo.ClientID%>").button();
            $("#<%= btnListaAutorizaciones.ClientID%>").button();

            $("#tabs").tabs();


            $("#<%= txtPFechNac.ClientID%>").keyup(function () {
                this.value = (this.value + '').replace(/[^a-zA-Z]/g, '');
            });

            $("#<%= txtPFechNac.ClientID%>").datepicker(
              {
                  dateFormat: 'dd/mm/yy',
                  //minDate: '+0D',
                  //maxDate: '+1Y',
                  maxDate: -1,
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

            //FIN CARGA DE FORMULARIO Y EVENTOS



            $(document).ready(function () {

                //VALIDACIONES PARA ENTRADAS EN CAJAS DE TEXTO

<%--            $("#<%= txtPaciente.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^0-9]/g, '');
                });

                $("#<%= txtPNombres.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^a-zA-ZñÑ ]/g, '');
                });

                $("#<%= txtPOtrosNomb.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^a-zA-ZñÑ ]/g, '');
                });

                $("#<%= txtPApePaterno.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^a-zA-ZñÑ ]/g, '');
                });

                $("#<%= txtPApeMaterno.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^a-zA-ZñÑ ]/g, '');
                });--%>

<%--            $("#<%= txtPNumDocumento.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^0-9]/g, '');
                });

                $("#<%= txtPPacienteId.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^0-9]/g, '');
                });

                $("#<%= txtPHistoria.ClientID%>").keyup(function () {
                    this.value = (this.value + '').replace(/[^0-9]/g, '');
                });--%>


               // $("#<%= imgPaciente.ClientID%>").tooltip();

                $("#<%= imgPaciente.ClientID%>").click(function () {

                    var BusPaciente = document.getElementById('<%=txtPaciente.ClientID%>').value;  // > 0 
                    var TipoDocumento = document.getElementById('<%=ddlDni.ClientID%>').value;

                    if (TipoDocumento > 0)
                    { 
                        /**************************/
                        if (BusPaciente.length > 0) {

                            if (TipoDocumento == 1)
                            {
                                if ((BusPaciente.length < 8) || (BusPaciente.length > 8)) {
                                    Dialog('Por favor verifique [08 digitos - Dni] ..!!');
                                    return false;
                                } else { return true;}

                            } else if (TipoDocumento == 2)
                            {
                                if (BusPaciente.length < 9) {
                                    Dialog('Por favor verifique [09 digitos - Carné Extranjeria] ..!!');
                                    return false;
                                } else { return true; }

                            } 
                            
                        } else {
                            Dialog('Por favor ingrese un [Numero de Documento]..!!');
                            return false;
                        }

                        /**************************/
                    }
                    else { 
                    Dialog('Por favor seleccione un [Tipo de Documento]..!!');
                    return false;}
                });

                //VALIDACIONES GUARDAR UN REGISTRO DE SOLICITUD


                $("#<%= btnGuardar.ClientID%>").click(function () {

                    var CodPaciente = document.getElementById('<%=txtPPacienteId.ClientID%>').value;  // > 0 
                    var NomPaciente = document.getElementById('<%=txtPNombres.ClientID%>').value;  // > 0 
                    var APatPaciente = document.getElementById('<%=txtPApePaterno.ClientID%>').value;  // > 0 
                    var AMatPaciente = document.getElementById('<%=txtPApeMaterno.ClientID%>').value;  // > 0 
                    var TipoDocumento = document.getElementById('<%=ddlTipoDocumento.ClientID%>').value;   // != 0
                    var NumDocumento = document.getElementById('<%=txtPNumDocumento.ClientID%>').value;  // > 0 
                    var FechNac = document.getElementById('<%=txtPFechNac.ClientID%>').value;  // > 0 
                    var Historia = document.getElementById('<%=txtPHistoria.ClientID%>').value;  // > 0 
                    var TipoRegimen = document.getElementById('<%=ddlTipoRegimen.ClientID%>').value;  // != 0

                    var Establecimiento = document.getElementById('<%=ddlFiltroEstablecimiento.ClientID%>').value;  // != 0
                    var Categoria = document.getElementById('<%=ddlCategoria.ClientID%>').value;  // != 0

                    var Est = document.getElementById('<%=ddlEstadio.ClientID%>');     // != 0 // != "-Seleccione-"
                    var Estadio = Est.options[Est.selectedIndex].text;

                    var Fase = $("[id$=ChkListBox]").find("input:checked").length;  // > 0 


                    var SexMas = $("[id$=SexMas]").prop('checked');   // == true
                    var SexFem = $("[id$=SexFem]").prop('checked');  // == true

                    if (Establecimiento != 0) {

                        if (CodPaciente.length > 0) {

                            if (NomPaciente.length > 0) {

                                if (APatPaciente.length > 0) {

                                    //if (AMatPaciente.length > 0) {

                                        if ((SexMas == true) | (SexFem == true)) {

                                            if (TipoDocumento != 0) {

                                                if (NumDocumento.length > 0) {

                                                    if (FechNac.length > 0) {

                                                        if (Historia.length > 0) {

                                                            if (TipoRegimen != 0) {

                                                                if (Categoria != 0) {

                                                                    if (Estadio != "-Seleccione-") {

                                                                        if (Fase > 0) {
                                                                            return true;
                                                                        } else {
                                                                            Dialog('Seleccione al menos una [Fase]..!!');
                                                                            return false;
                                                                        }

                                                                    } else {
                                                                        Dialog('Ningun [Estadio] seleccionado..!!');
                                                                        return false;
                                                                    }

                                                                } else {
                                                                    Dialog('Ninguna [Categoria] seleccionada..!!');
                                                                    return false;
                                                                }

                                                            } else {
                                                                Dialog('Ningun [Tipo de Regimen] seleccionado..!!');
                                                                return false;
                                                            }

                                                        } else {
                                                            Dialog('Ninguna [Historia] ingresada..!!');
                                                            return false;
                                                        }

                                                    } else {
                                                        Dialog('Ninguna [Fech.Nacimiento] ingresada..!!');
                                                        return false;
                                                    }

                                                } else {
                                                    Dialog('Ningun [Numero de Documento] ingresado..!!');
                                                    return false;
                                                }

                                            } else {
                                                Dialog('Ningun [Tipo de Documento] seleccionado..!!');
                                                return false;
                                            }

                                        } else {
                                            Dialog('Ningun [Sexo] seleccionado..!!');
                                            return false;
                                        }

                                    //} else {
                                    //    Dialog('Ningun [Apellido Materno] ingresado..!!');
                                    //    return false;
                                    //}

                                } else {
                                    Dialog('Ningun [Apellido Paterno] ingresado..!!');
                                    return false;
                                }

                            } else {
                                Dialog('Ningun [Nombre de Paciente] ingresado..!!');
                                return false;
                            }

                        } else {
                            Dialog('Ningun [Codigo de Paciente] ingresado..!!');
                            return false;
                        }

                    } else {
                        Dialog('Seleccione un [Codigo de Establecimiento]..!!');
                        return false;
                    }

                });


                //VALIDACIONES GUARDAR/ENVIAR UN REGISTRO DE SOLICITUD

                $("#<%= btnGuardarEnviar.ClientID%>").click(function () {

                    //var CodPaciente = document.getElementById('<%=txtPPacienteId.ClientID%>').value;  // > 0 
                    var NomPaciente = document.getElementById('<%=txtPNombres.ClientID%>').value;  // > 0 
                    var APatPaciente = document.getElementById('<%=txtPApePaterno.ClientID%>').value;  // > 0 
                    var AMatPaciente = document.getElementById('<%=txtPApeMaterno.ClientID%>').value;  // > 0 
                    var TipoDocumento = document.getElementById('<%=ddlTipoDocumento.ClientID%>').value;   // != 0
                    var NumDocumento = document.getElementById('<%=txtPNumDocumento.ClientID%>').value;  // > 0 
                    var FechNac = document.getElementById('<%=txtPFechNac.ClientID%>').value;  // > 0 
                    var Historia = document.getElementById('<%=txtPHistoria.ClientID%>').value;  // > 0 
                    var TipoRegimen = document.getElementById('<%=ddlTipoRegimen.ClientID%>').value;  // != 0

                    var Establecimiento = document.getElementById('<%=ddlFiltroEstablecimiento.ClientID%>').value;  // != 0
                    var Categoria = document.getElementById('<%=ddlCategoria.ClientID%>').value;  // != 0

                    var Est = document.getElementById('<%=ddlEstadio.ClientID%>');     // != 0 // != "-Seleccione-"
                    var Estadio = Est.options[Est.selectedIndex].text;

                    var Fase = $("[id$=ChkListBox]").find("input:checked").length;  // > 0 


                    var SexMas = $("[id$=SexMas]").prop('checked');   // == true
                    var SexFem = $("[id$=SexFem]").prop('checked');  // == true

                    if (Establecimiento != 0) {

                        //if (CodPaciente.length > 0) {

                        if (NomPaciente.length > 0) {

                            if (APatPaciente.length > 0) {

                                //if (AMatPaciente.length > 0) {

                                if ((SexMas == true) | (SexFem == true)) {

                                    if (TipoDocumento != 0) {

                                        if (NumDocumento.length > 0) {

                                            if (FechNac.length > 0) {

                                                if (Historia.length > 0) {

                                                    if (TipoRegimen != 0) {

                                                        if (Categoria != 0) {

                                                            if (Estadio != "-Seleccione-") {

                                                                if (Fase > 0) {
                                                                    return true;
                                                                } else {
                                                                    Dialog('Seleccione al menos una [Fase]..!!');
                                                                    return false;
                                                                }

                                                            } else {
                                                                Dialog('Ningun [Estadio] seleccionado..!!');
                                                                return false;
                                                            }

                                                        } else {
                                                            Dialog('Ninguna [Categoria] seleccionada..!!');
                                                            return false;
                                                        }

                                                    } else {
                                                        Dialog('Ningun [Tipo de Regimen] seleccionado..!!');
                                                        return false;
                                                    }

                                                } else {
                                                    Dialog('Ninguna [Historia] ingresada..!!');
                                                    return false;
                                                }

                                            } else {
                                                Dialog('Ninguna [Fecha de Nacimiento] ingresada..!!');
                                                return false;
                                            }

                                        } else {
                                            Dialog('Ningun [Numero de Documento] ingresado..!!');
                                            return false;
                                        }

                                    } else {
                                        Dialog('Ningun [Tipo de Documento] seleccionado..!!');
                                        return false;
                                    }

                                } else {
                                    Dialog('Ningun [Sexo] seleccionado..!!');
                                    return false;
                                }

                                //} else {
                                //    Dialog('Ningun [Apellido Materno] ingresado..!!');
                                //    return false;
                                //}

                            } else {
                                Dialog('Ningun [Apellido Paterno] ingresado..!!');
                                return false;
                            }

                        } else {
                            Dialog('Ningun [Nombre de Paciente] ingresado..!!');
                            return false;
                        }

                        //} else {
                        //    Dialog('Ningun [Codigo de Paciente] ingresado..!!');
                        //    return false;
                        //}

                    } else {
                        Dialog('Seleccione un [Codigo de Establecimiento]..!!');
                        return false;
                    }
                });

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


        function Confirm(Var) {
            $("#PopUp_Confirm").text(Var);
            $("#PopUp_Confirm").dialog({
                title: "Mensaje: Fissal",
                position: { my: 'top', at: 'top+580' },
                modal: true,
                resizable: false,
                width: 220,
                height: 90,
                show: { effect: 'fade', duration: 470 },
                hide: { effect: 'fade', duration: 200 },

                open: function (event, ui) {
                    setTimeout("$('#PopUp_Confirm').dialog('close')", 1800);
                }
            });
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
            if (tecla == 97) return false; //  
            if (tecla == 98) return false; //  
            if (tecla == 99) return false; //  
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




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
    </asp:ScriptManager>

    <div style="text-align: left; border: 1px solid #9A99A8">
        <div id="titulo_pagina">REGISTRO DE SOLICITUD DE AUTORIZACIÓN</div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

        <div class="resoluciones">
            ESTABLECIMIENTO : 
    <asp:DropDownList ID="ddlFiltroEstablecimiento" runat="server" OnSelectedIndexChanged="ddlFiltroEstablecimiento_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br>
            </br>
            USUARIO :
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <br>
            </br> 
        </div>

        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlFiltroEstablecimiento"
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>






    </div>

    <div>

        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <fieldset id="Buscador" runat="server" style="background-color: #EEEEEE; border: 1px solid #9A99A8">
        <legend style="text-align: left;">Busqueda Paciente</legend>
        <table id="PContenido1" width="100%">
            <tr>
                <td>&nbsp;
                </td>
            </tr>            
            <tr>
                <td class="Estilo2">Paciente:</td>
                <td style="position: relative; text-align: left;">
                    <asp:DropDownList ID="ddlDni" runat="server" Width="90px" OnSelectedIndexChanged="ddlDni_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    <asp:TextBox ID="txtPaciente" runat="server" MaxLength="9" OnTextChanged="txtPaciente_TextChanged"  onkeydown = "return validarNumeros(event);" placeholder="Nro Documento"></asp:TextBox>                    
                    <asp:ImageButton ID="imgPaciente" runat="server"  Width="19" ImageUrl="../Images/male_user_search-128.png" Style="position: relative; top: 5px; left: 0px;" OnClick="imgPaciente_Click"/>
                </td>
                <td>
                    <div style="width: 235px; display: block;">
                        <fieldset style="background-color: #EEEEEE;">
                            <legend style="text-align: left;">Origen Paciente</legend>
                            <div style="width: 230px;">
                                <asp:CheckBox ID="chkSIS" runat="server" Text="Paciente SIS" TextAlign="Left" Enabled="false" />
                                <asp:CheckBox ID="chkFISSAL" runat="server" Text="Paciente FISSAL" TextAlign="Left" Enabled="false" />
                            </div>
                        </fieldset>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="3">  
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel2" >
                    <ProgressTemplate>
                        <div style="left:0;top:0;background-color:rgba(0,0,0,0.7);height:100%;width:100%;position:absolute;z-index:1001">
                            <div style="background-color:#fff;left:40%;top:45%;width:320px;height:60px;position:relative;z-index:1002;text-align: center;padding-top:10px;">
                                 <img alt="" src="../Images/espera.gif" style="vertical-align: middle" /><span style="color: #31456b; padding-left: 5px; font-size: 14px; font-weight: bold">Validando Paciente...</span>
                            </div>                            
                        </div>
                    
                    </ProgressTemplate>
                    </asp:UpdateProgress>
                </td>
            </tr>
        </table>
    </fieldset>
               
            </ContentTemplate>
        </asp:UpdatePanel>
      

    </div>
     
  
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
    
              
    <div id="frmValidacion" runat="server" style="font-size: 10px; border: solid 1px #FF0000; background-color: #f5eeee; margin: 10px 0 10px 0; padding-left: 15px; padding-top: 15px; padding-bottom: 15px; padding-right: 15px;">

        <div style="text-align: left;">
            <asp:Label ID="lblPacienteSIS" runat="server" Text=""></asp:Label>
        </div>
        <div style="text-align: left;">
            <asp:Label ID="lblPacienteFissal" runat="server" Text=""></asp:Label>
        </div>

        <div class="sub_titulo_form">
            <asp:Label ID="lblAutorizacionEnEsteEstablecimiento" runat="server" Text="Autorizaciones en este Establecimientos :"></asp:Label>&nbsp;
        </div>

        <asp:GridView ID="gvAutorizaciones" runat="server" AutoGenerateColumns="False" Font-Size="XX-Small">
            <Columns>
                <asp:BoundField DataField="pacientenombre" HeaderText="Paciente">
                    <ItemStyle Width="280px" />
                </asp:BoundField>
                <asp:BoundField DataField="CodigoAutorizacion" HeaderText="CodAutorización" Visible="False">
                    <ItemStyle Width="120px" />
                </asp:BoundField>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:d}">
                    <ItemStyle Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Hospital" Visible="False" />
                <asp:BoundField DataField="descripcionlarga" HeaderText="Descripcion">
                    <ItemStyle Width="430px" HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="DescripcionAutorizacion" HeaderText="TipoAutorizacion">
                    <ItemStyle Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="Estado" HeaderText="Estado">
                    <ItemStyle Width="30px" />
                </asp:BoundField>
                <asp:BoundField DataField="Vigencia" HeaderText="Vigencia" DataFormatString="{0:d}">
                    <ItemStyle Width="80px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>

        <div class="sub_titulo_form">
            <asp:Label ID="lblAutorizacionesOtrosEstablecimientos" runat="server" Text="Autorizaciones en Otros Establecimientos :"></asp:Label>
        </div>

        <asp:GridView ID="gvAutorizacionesOtrosEstablecimiento" runat="server" AutoGenerateColumns="False" ShowHeader="False" Font-Size="XX-Small">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion">
                    <ItemStyle Width="450px" HorizontalAlign="Left" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>


        </ContentTemplate>       
    </asp:UpdatePanel>


    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>

    <fieldset style="background-color: #EEEEEE; border: 1px solid #9A99A8">
        <legend style="text-align: left;">Datos Paciente</legend>
        <table id="PContenido2" width="100%">
            <tr>
                <td></td>
                <td></td>
                <td class="Estilo2"></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td class="Estilo2"></td>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPPacienteId" runat="server" Width="120px" MaxLength="12" ReadOnly="true"  onkeydown = "return validarNumeros(event);" placeholder="Codigo Paciente" Visible ="false"></asp:TextBox>
                </td>
                <td class="Estilo2"></td>
            </tr>
            <tr>
                <td class="Estilo2">Nombres*:</td>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPNombres" runat="server" Width="190px" ReadOnly="true" placeholder="Nombre Paciente" onkeydown="return validarLetras(event);"></asp:TextBox>
                </td>
                <td class="Estilo2"></td> <%--Otro Nombres--%>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPOtrosNomb" runat="server" Width="190px" ReadOnly="true" placeholder="Nombre Paciente" Visible="false"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="Estilo2">A.Paterno*:</td>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPApePaterno" runat="server" Width="190px" ReadOnly="true" placeholder="Apellido Paciente" onkeydown="return validarLetras(event);"></asp:TextBox>
                </td>

                <td class="Estilo2">A.Materno:</td>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPApeMaterno" runat="server" Width="190px" ReadOnly="true" placeholder="Apellido Paciente" onkeydown="return validarLetras(event);"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="Estilo2">Sexo*:</td>
                <td class="Estilo1">
                    <asp:RadioButton ID="SexMas" runat="server" GroupName="Valor" Text="Masculino" Enabled="false" />
                    <asp:RadioButton ID="SexFem" runat="server" GroupName="Valor" Text="Femenino" Enabled="false" />
                </td>
                <td class="Estilo2">Tip.Doc.*:<td class="Estilo1" style="position: relative;">
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server" Width="75px" Enabled="false"></asp:DropDownList>&nbsp;Doc.:
                <asp:TextBox ID="txtPNumDocumento" runat="server" MaxLength="9" Width="70px" ValidationGroup="ValidForm" ReadOnly="true"  onkeydown = "return validarNumeros(event);" placeholder="Documento"></asp:TextBox>
                </td>

                </td>
                <td></td>
            </tr>
            <tr>
                <td class="Estilo2">Fech.Nacimiento*:</td>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPFechNac" runat="server" placeholder="Fecha Nacimiento" Enabled="False"></asp:TextBox>
                </td>
                <td class="Estilo2">Historia*:</td>
                <td class="Estilo1">
                    <asp:TextBox ID="txtPHistoria" runat="server" Width="190px" MaxLength="15" ReadOnly="true" onkeydown = "return validarNumeros(event);" placeholder="Nro Historia"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="Estilo2">Tip.Regimen*</td>
                <td class="Estilo1">
                    <asp:DropDownList ID="ddlTipoRegimen" runat="server" Width="196px" Enabled="false"></asp:DropDownList>
                </td>
                <td class="Estilo2"></td>
                <td class="Estilo1">
                    <asp:HiddenField ID="hfFechVigencia" runat="server" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:HiddenField ID="hdfEstado" runat="server" />
                    &nbsp;               
                </td>
            </tr>
        </table>
    </fieldset>


           </ContentTemplate>
    </asp:UpdatePanel>



    <tr>
        <td>&nbsp;</td>
    </tr>

    <asp:UpdatePanel ID="upSetSession" runat="server">
        <ContentTemplate>

            <fieldset style="background-color: #EEEEEE; border: 1px solid #9A99A8">
                <legend style="text-align: left;">Seleccion Tratamiento</legend>
                <table id="PContenido3" width="100%">
                    <tr>
                        <td>&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="Estilo2">Categoria:</td>
                        <td class="Estilo1">
                            <asp:DropDownList ID="ddlCategoria" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged" Enabled="false"></asp:DropDownList>
                        </td>
                        <td class="Estilo2">Estadio:</td>
                        <td class="Estilo1">
                            <asp:DropDownList ID="ddlEstadio" runat="server" Width="137px" AutoPostBack="True" OnSelectedIndexChanged="ddlEstadio_SelectedIndexChanged" Enabled="false"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="Estilo2">Fase:</td>
                        <td colspan="3" rowspan="4">
                            <div style="width: 300px; height: 100px; overflow-y: auto; border: solid; border-width: 1px; text-align: left; background-color: white;">
                                <asp:CheckBoxList runat="server" ID="ChkListBox" Enabled="false">
                                    <asp:ListItem Text="opt1" Value="opt1" />
                                    <asp:ListItem Text="opt2" Value="opt2" />
                                    <asp:ListItem Text="opt3" Value="opt3" />
                                </asp:CheckBoxList>
                            </div>
                        </td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>

                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>

                </table>
            </fieldset>

        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlCategoria"
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>

    <tr>
        <td>&nbsp;</td>
    </tr>

    <div id="frmValidacion3" runat="server" style="border: solid 1px #FF0000; /*font-size: 10px; */
                                              background-color: #f5eeee; margin: 10px 0 10px 0; padding-left: 15px; padding-top: 15px; padding-bottom: 15px; padding-right: 15px;">

        <div style="border: solid 1px #B5C3E5; background-color: #C9D3E4; height: 20px;">
            <table id="tb" runat="server" width="100%" >
                <tr>
                    <td style="text-align: left; width: 100%;">RESULTADOS:
                    </td>
                    <td style="text-align: right; width: 50%;">
                        <asp:ImageButton ID="ImageButton1" runat="server" Style="text-align: right;" Height="16px" ImageUrl="~/Images/Mantenimiento/delete.ico" Width="16px" />
                    </td>
                </tr>
            </table>
        </div>

        <div id="tabs">
          <ul>
            <li><a href="#tabs-1">
                <asp:Label ID="Label4" runat="server" Text="Solicitudes Registradas"></asp:Label>
                <font style="font-weight:bold;">
                <asp:Label ID="lblResultRegistrados" runat="server"></asp:Label>
                </font>
                </a>
            </li>

            <li><a href="#tabs-2">
                <asp:Label ID="Label2" runat="server" Text="Solicitudes Observadas"></asp:Label>
                <font style="font-weight:bold;">
                <asp:Label ID="lblResultSolicitados" runat="server"></asp:Label>
                </font>
                </a>
            </li>

            <li><a href="#tabs-3">
                <asp:Label ID="Label3" runat="server" Text="Solicitudes Existentes"></asp:Label>
                <font style="font-weight:bold;">
                <asp:Label ID="lblResultObservados" runat="server"></asp:Label>
                </font>
                </a>
            </li>
          </ul>
          <div id="tabs-1">
            <div width="100%" style="padding-left:10px; text-align:left;">
                <asp:Label ID="Label1" runat="server" Font-Size="11px">
                    Listado de Tratamientos Guardados:
                </asp:Label>
            </div>
            <div width="100%" style="height: 140px; padding-left:10px;">
                <asp:GridView ID="dgvListaTratamientosAprob" runat="server" AutoGenerateColumns="False" Font-Size="XX-Small"
                    EmptyDataText="Ningun Tratamiento Aprobado"
                    BorderWidth="1px" BackColor="#E8E8EC"
                    CellPadding="3" CellSpacing="2" BorderStyle="None"
                    BorderColor="#DEBA84">
                    <FooterStyle ForeColor="#293955" BackColor="#E8E8EC"></FooterStyle>
                    <PagerStyle ForeColor="#293955" HorizontalAlign="Center"></PagerStyle>
                    <HeaderStyle ForeColor="#515151" Font-Bold="True" BackColor="#A6B7D2"></HeaderStyle>

                    <Columns>
                        <asp:BoundField DataField="CategoriaId" HeaderText="CategoriaId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="EstadioId" HeaderText="EstadioId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FaseId" HeaderText="FaseId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Observaciones" HeaderText="Observaciones">
                            <ItemStyle Width="120px" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </div>
          </div>
          <div id="tabs-2">
            <div width="100%" style="padding-left:10px; text-align:left;">
                <asp:Label ID="Label5" runat="server" Font-Size="11px">
                    Listado de Tratamientos Observados:
                </asp:Label>
            </div>
            <div width="100%" style="height: 140px; padding-left:10px;">
                <asp:GridView ID="dgvListaTratamientosObserv" runat="server" AutoGenerateColumns="False" Font-Size="XX-Small"
                    EmptyDataText="Ningun Tratamiento con Autorizaciones Vigentes"
                    BorderWidth="1px" BackColor="#E8E8EC"
                    CellPadding="3" CellSpacing="2" BorderStyle="None"
                    BorderColor="#DEBA84">
                    <FooterStyle ForeColor="#293955" BackColor="#E8E8EC"></FooterStyle>
                    <PagerStyle ForeColor="#293955" HorizontalAlign="Center"></PagerStyle>
                    <HeaderStyle ForeColor="#515151" Font-Bold="True" BackColor="#A6B7D2"></HeaderStyle>
                    <Columns>
                        <asp:BoundField DataField="CategoriaId" HeaderText="CategoriaId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="EstadioId" HeaderText="EstadioId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FaseId" HeaderText="FaseId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Observaciones" HeaderText="Observaciones">
                            <ItemStyle Width="120px" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </div>
          </div>
          <div id="tabs-3">
            <div width="100%" style="padding-left:10px; text-align:left;">
                <asp:Label ID="Label6" runat="server" Font-Size="11px">
                    Listado de Tratamientos Existentes en una misma Cadena:
                </asp:Label>
            </div>
            <div width="100%" style="padding-left:10px; text-align:left;">
                <asp:Label ID="lblMensCad" runat="server" Font-Size="11px">
                   Esta Categoría pertenece a una Cadena [Registrada] anteriormente,<br>
                   seleccione otra Categoría que pertenezca a otra Cadena.
                </asp:Label>
            </div>
              <br />
            <div width="100%" style="height: 140px; padding-left:10px;">
                <asp:GridView ID="dgvListaTratamientosExistentes" runat="server" AutoGenerateColumns="False" Font-Size="XX-Small"
                    EmptyDataText="Ningun Tratamiento Solicitado"
                    BorderWidth="1px" BackColor="#E8E8EC"
                    CellPadding="3" CellSpacing="2" BorderStyle="None"
                    BorderColor="#DEBA84">
                    <FooterStyle ForeColor="#293955" BackColor="#E8E8EC"></FooterStyle>
                    <PagerStyle ForeColor="#293955" HorizontalAlign="Center"></PagerStyle>
                    <HeaderStyle ForeColor="#515151" Font-Bold="True" BackColor="#A6B7D2"></HeaderStyle>
                    <Columns>
                        <asp:BoundField DataField="CategoriaId" HeaderText="CategoriaId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="EstadioId" HeaderText="EstadioId" Visible="false">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FaseId" HeaderText="FaseId" Visible="false">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CadenaId" HeaderText="CadenaId">
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Observaciones" HeaderText="Observaciones">
                            <ItemStyle Width="120px" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>          
            </div>
          </div>
        </div>
    </div>


    <fieldset style="background-color: #EEEEEE; border: 1px solid #9A99A8">
        <table id="Botones" width="100%">
            <tr>
                <td></td>
                <td></td>
                <td style="padding-left: 50px; text-align: right; width: 500px; padding-right: 10px;">
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" Width="95px" OnClick="btnNuevo_Click" CssClass="BotonEstilo" OnClientClick="return true" />


                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="95px" OnClick="btnGuardar_Click" CssClass="BotonEstilo" OnClientClick="return true" Visible="False" />
                    <asp:Button ID="btnGuardarEnviar" runat="server" Text="Guardar" Width="95px" OnClick="btnGuardarEnviar_Click" CssClass="BotonEstilo" OnClientClick="return true" />

                    <asp:Button ID="btnListaAutorizaciones" runat="server" Text="List.Autoriz." Width="95px" OnClick="btnListaAutorizaciones_Click" CssClass="BotonEstilo" OnClientClick="return true" />

                    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" Width="95px" OnClick="btnRegresar_Click" CssClass="BotonEstilo" OnClientClick="return true" />
                </td>
            </tr>
        </table>
    </fieldset>

    <tr>
        <td>&nbsp;</td>
    </tr>

    <div id="PopUp_Dialog" style="display: none;">
    </div>

    <div id="PopUp_Confirm" style="display: none;">
    </div>

    
    </div>

    
    </div>

    
    </div>

    
</asp:Content>

