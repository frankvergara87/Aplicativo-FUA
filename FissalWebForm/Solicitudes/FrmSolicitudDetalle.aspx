<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmSolicitudDetalle.aspx.cs" Inherits="FissalWebForm.Solicitudes.FrmSolicitudDetalle" %>
<%@ PreviousPageType VirtualPath="~/Solicitudes/FrmMantSolicitud.aspx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../css/Formularios.css"  rel="stylesheet"/>
        <script type="text/javascript">
            function pageLoad()
            {
               $("#<%= btnRetornar.ClientID%>").button();
            }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering ="true" >
</asp:ScriptManager>
<br />
<fieldset style="background-color:#EEEEEE; border:1px solid #9A99A8"> 
<legend style="text-align:left;">Solicitud Detalle:</legend>
<table id="PContenido" width="100%">
    <tr><td class="Estilo2"></td></tr>
    <tr>
        <td class="Estilo2">N° Solicitud:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtNumSolicitud" runat="server" Width="128px"  placeholder="Nro Solicitud" ReadOnly="true"></asp:TextBox>
        </td>
        <td class="Estilo2">Renaes:</td>
        <td class="Estilo1" colspan="3">
<%--            <asp:TextBox ID="txtEstablecimiento" runat="server" Width="500px"  placeholder="Nro Solicitud" ReadOnly="true"></asp:TextBox>--%>
            <asp:Label ID="lblEstablecimiento" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="Estilo2">Paciente:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtPaciente" runat="server" Width="128px"  placeholder="Codigo Paciente" ReadOnly="true"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="Estilo2">Nombres:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtNomPaciente" runat="server" Width="180px"  placeholder="Nombres Paciente" ReadOnly="true"></asp:TextBox>
        </td>
        <td class="Estilo2">Apellido Paterno:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtApePatPaciente" runat="server" Width="180px"  placeholder="Apellido Paciente" ReadOnly="true"></asp:TextBox>
        </td>
        <td class="Estilo2"></td>
        <td class="Estilo2"></td>
    </tr>
    <tr>
        <td class="Estilo2">Apellido Materno:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtApeMatPaciente" runat="server" Width="180px"  placeholder="Apellido Paciente" ReadOnly="true"></asp:TextBox>
        </td>
        <td class="Estilo2">Fecha Solicitud:</td>
        <td class="Estilo1">
            <asp:TextBox ID="txtFechaSolicitud" runat="server" Width="128px"  placeholder="Fecha Solicitud" ReadOnly="true"></asp:TextBox>
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
        <asp:Button ID="btnRetornar" runat="server" Text="Retornar" Width="95px" OnClick="btnRetornar_Click" CssClass="BotonEstilo" OnClientClick="return true" />&nbsp                   
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
            <asp:Image ID="imgLeyendaPendiente"   runat="server" ImageUrl="~/Images/Mantenimiento/NoProcesado.ico"   Width="17px" Height="17px" style="position:relative;top:5px; left: 0px;"/>&nbsp;
            <asp:Label ID="lblLeyendaPendiente" runat="server" Text="Pendiente"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="imgLeyendaEnviado"   runat="server" ImageUrl="~/Images/Mantenimiento/aproved.ico"   Width="20px" Height="20px" style="position:relative;top:5px; left: 0px;"/>&nbsp;
            <asp:Label ID="lblLeyendaAprobado" runat="server" Text="Aprobado"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="imgLeyendaAprobado" runat="server" ImageUrl="~/Images/Mantenimiento/denied.ico" Width="20px" Height="20px" style="position:relative;top:5px; left: 0px;"/>&nbsp;
            <asp:Label ID="lblLeyendaEnviado"   runat="server" Text="Rechazado"></asp:Label>
        </div>
    </td>
</tr>
<tr>
    <td>
        <div>
            <HR  width=31% align="right">
        </div>
    </td>
</tr>
<tr>
<td>
        <asp:GridView ID="gvListaDetalleSolicitudes" runat="server" EmptyDataText="La Solicitud no contiene Detalles" Width="100%"
        AllowPaging="True"
        PageSize="5"
        OnPageIndexChanging="gvListaDetalleSolicitudes_PageIndexChanging"
        AutoGenerateColumns="False"
        BorderWidth="1px" BackColor="#FFFFBB" 
        CellPadding="3" CellSpacing="2" BorderStyle="None" 
        BorderColor="#DEBA84" OnRowDataBound="gvListaDetalleSolicitudes_RowDataBound">
        <FooterStyle ForeColor="#293955" BackColor="#FFFFE1"></FooterStyle>
        <PagerStyle ForeColor="#293955"  HorizontalAlign="Center"></PagerStyle>
        <HeaderStyle ForeColor="White" Font-Bold="True" BackColor="#CD1D26"></HeaderStyle>

        <Columns>
            <asp:BoundField HeaderText="Fecha Solicitud" 
            DataField="Fecha_Solicitud" DataFormatString="{0:dd/MM/yyyy}"
            SortExpression="Fecha_Solicitud">
            <ItemStyle Width="40px" HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Categoria" 
            DataField="Categoria" 
            SortExpression="Categoria">
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="270px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Estadio" 
            DataField="Estadio" 
            SortExpression="Estadio">
            <ItemStyle Width="80px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Fase" 
            DataField="Fase" 
            SortExpression="Fase">
            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"  Width="120px"/>
            </asp:BoundField>

            <asp:BoundField HeaderText="Aprobado"
            DataField="Aprobado" 
            SortExpression="Aprobado">
            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" Width="30px" />
            </asp:BoundField>

            <asp:BoundField HeaderText="Procesado"
            DataField="Procesado" 
            SortExpression="Procesado">
            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" Width="30px" />
            </asp:BoundField>

            <asp:TemplateField HeaderText="Estado" >
                <ItemTemplate>
                    <asp:ImageButton ID="ImgEstado" runat="server" ImageAlign="Middle" Width="25px" Height="25px" Enabled="true"
                        ImageUrl="~/Images/Mantenimiento/NoProcesado.ico" />
                </ItemTemplate>
                <ItemStyle Width="30px" HorizontalAlign="Center" />
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
</table>
</fieldset>


</asp:Content>
