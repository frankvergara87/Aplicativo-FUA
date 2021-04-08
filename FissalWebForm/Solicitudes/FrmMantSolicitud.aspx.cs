using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FissalBE;
using FissalBL;
using FissalWeb;
using FissalWebForm;

namespace FissalWebForm.Solicitudes
{
    public partial class FrmMantSolicitud : System.Web.UI.Page
    {
        SolicitudAutorizacionBL objSolicitudAutorizacionBL = new SolicitudAutorizacionBL();
        SolicitudAutorizacion objSolicitudAutorizacion = new SolicitudAutorizacion();
        AutorizacionBL objAutorizacionBL = new AutorizacionBL();

        Paciente ObjListPaciente = new Paciente();
        
        List<Autorizacion> objListAutorizaciones = new List<Autorizacion>();
        SolicitudAutorizacion objListSolicitudAutorizacion = new SolicitudAutorizacion();
        //vw2_SolicitudAutorizacionDetalle objListSolicitudAutorizacionDetalle = new vw2_SolicitudAutorizacionDetalle();

        List<vw2_SolicitudAutorizacionDetalle> objListSolicitudAutorizacionDetalle = new List<vw2_SolicitudAutorizacionDetalle>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Codigo"] = null;
            Session["Est"] = null;

            //int Estado = Convert.ToInt32(Request.QueryString["val"]);
            int Estado = 0;
            Estado = 1;//Convert.ToInt32(HttpContext.Current.Session["Val"]);            

            if (Session["login"] == null & Session["password"] == null)
            {
                Response.Redirect("~/FrmLogin.aspx");
            }
            else
            {               

                if (!IsPostBack)
                {
                    FuncionesBasesWeb.CargarComboTipoDocumento(ddlTipoDocumento);

                    lblUsuario.Text = Session["login"].ToString();
                    lblEstablecimiento.Text = Session["Descripcion"].ToString();

                    if (ddlTipoDocumento.SelectedValue.ToString() == "0")
                    {
                        txtPaciente.ReadOnly = true;
                    }
                    else { txtPaciente.ReadOnly = false; }

                    if (Estado == 1)
                    {
                        chkEnviado.Checked = true;
                        CargarSolicitud();
                        HideColumns(gvListaSolicitudes);
                    }
                    else
                    {
                        CargarSolicitud();
                        HideColumns(gvListaSolicitudes);
                    }
                }
            }

        }

        #region 'VARIABLES'

        private string _Codigo;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }


        private string _Est;

        public string Est
        {
            get { return _Est; }
            set { _Est = value; }
        }

        #endregion

        #region Botones

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarSolicitud();
            HideColumns(gvListaSolicitudes);
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            FuncionesBasesWeb.CargarComboTipoDocumento(ddlTipoDocumento);
            txtPaciente.Text = String.Empty;
            txtNomPaciente.Text = String.Empty;
            txtApePatPaciente.Text = String.Empty;
            txtApeMatPaciente.Text = String.Empty;
            txtFechaSolicitud.Text = String.Empty;
            //chkEnviado.Checked = false;
        }

        #endregion

        #region Metodos
        private void CargarSolicitud() 
        {
            objSolicitudAutorizacion.TipoDocumentoId = Convert.ToByte(ddlTipoDocumento.SelectedValue);//txtNumSolicitud.Text;
            objSolicitudAutorizacion.EstablecimientoId = Convert.ToInt32(Session["EstablecimientoId"]);
            if (ddlTipoDocumento.SelectedValue == "3")
            {
                objSolicitudAutorizacion.PacienteId = txtPaciente.Text.Substring(1, 8);
            }
            else { objSolicitudAutorizacion.PacienteId = txtPaciente.Text; }            
            
            objSolicitudAutorizacion.Nombres = txtNomPaciente.Text;
            objSolicitudAutorizacion.ApellidoPaterno = txtApePatPaciente.Text;
            objSolicitudAutorizacion.ApellidoMaterno = txtApeMatPaciente.Text;
            objSolicitudAutorizacion.Enviado = Convert.ToByte(chkEnviado.Checked);
            string Fecha;
            if (txtFechaSolicitud.Text.Length > 0)
            {
                Fecha = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime((txtFechaSolicitud.Text.Substring(6, 4) + "/" + txtFechaSolicitud.Text.Substring(3, 2) + "/" + txtFechaSolicitud.Text.Substring(0, 2))));
            }
            else { Fecha = String.Empty; }

            gvListaSolicitudes.DataSource = objSolicitudAutorizacionBL.SolicitudAutorizacion_ListarGrilla(objSolicitudAutorizacion, Fecha);
            gvListaSolicitudes.DataBind();
        }

        #endregion

        #region Eventos
        protected void gvListaSolicitudes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
            gvListaSolicitudes.PageIndex = e.NewPageIndex;
            CargarSolicitud();
            HideColumns(gvListaSolicitudes);

        }

        protected void gvListaSolicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "ImgEnviar")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = gvListaSolicitudes.Rows[index];

                    string Nro_Solicitud   = Server.HtmlDecode(row.Cells[0].Text.Trim());

                    /**************************************************************************/
                    // La solicitud pasa a Enviado = 1

                    int result = objSolicitudAutorizacionBL.SolicitudAutorizacion_Actualizar(Nro_Solicitud);
                    string rpta = String.Empty;
                    if (result == 1) { rpta = "Ok"; } else if (result == -1) { rpta = "ERROR"; }

                    /**************************************************************************/

                    #region 'Obtenemos Datos'

                    objListSolicitudAutorizacion = objAutorizacionBL.ObtenerSolicitudAutorizacion(Nro_Solicitud);                
                
                    #endregion

                    if (objListSolicitudAutorizacion.ValidadoSIS == true)  // Si ValidadoSiS = True 
                    {
                        #region 'Cargamos Datos Pacientes'
                        ObjListPaciente.PacienteId = objListSolicitudAutorizacion.PacienteId;
                        ObjListPaciente.EstablecimientoIdOrigen = objListSolicitudAutorizacion.EstablecimientoId;
                        ObjListPaciente.Estado = true;
                        ObjListPaciente.UsuarioCreacion = VariablesGlobales.Login;
                        ObjListPaciente.NumeroDocumento = objListSolicitudAutorizacion.NumeroDocumento;
                        ObjListPaciente.TipoDocumentoId = objListSolicitudAutorizacion.TipoDocumentoId;
                        ObjListPaciente.ApellidoMaterno = objListSolicitudAutorizacion.ApellidoMaterno;
                        ObjListPaciente.ApellidoPaterno = objListSolicitudAutorizacion.ApellidoPaterno;
                        ObjListPaciente.fecha_defuncion = objListSolicitudAutorizacion.fecha_defuncion;
                        ObjListPaciente.Historia = objListSolicitudAutorizacion.Historia;
                        ObjListPaciente.Nacimiento = objListSolicitudAutorizacion.Nacimiento;
                        ObjListPaciente.Nombres = objListSolicitudAutorizacion.Nombres;
                        ObjListPaciente.OtrosNombres = objListSolicitudAutorizacion.OtrosNombres;
                        ObjListPaciente.SexoId = objListSolicitudAutorizacion.SexoId;
                        ObjListPaciente.TipoRegimenId = Convert.ToByte(objListSolicitudAutorizacion.TipoRegimenId);
                        ObjListPaciente.Validado = true;
                        #endregion

                        #region 'Cargamos Datos Autorizacion'

                        List<SolicitudAutorizacion> objSolicitudAutorizacionDetalle;
                        objSolicitudAutorizacionDetalle = objAutorizacionBL.ObtenerSolicitudAutorizacionListDetalle(Nro_Solicitud);

                        foreach (SolicitudAutorizacion Lista in objSolicitudAutorizacionDetalle)
                        {
                            Autorizacion objListAutorizacion = new Autorizacion();
                            objListAutorizacion.Adicional = false;
                            objListAutorizacion.Anulado = false;
                            objListAutorizacion.ControlaCantidad = false;
                            objListAutorizacion.Descripcion = String.Empty;
                            if (Lista.CategoriaId == "ZZZ")
                            {
                                objListAutorizacion.DiagnosticoAsociado = true; // Si Categoria = 'ZZZ' true | false
                            }
                            else
                            {
                                objListAutorizacion.DiagnosticoAsociado = false;
                            }

                            objListAutorizacion.EstablecimientoId = objListSolicitudAutorizacion.EstablecimientoId;
                            objListAutorizacion.Estado = "A";
                            objListAutorizacion.Fecha = objListSolicitudAutorizacion.Fecha_Solicitud;
                            objListAutorizacion.FechaSolicitud = objListSolicitudAutorizacion.Fecha_Solicitud;

                            objListAutorizacion.TipoAutorizacionId = Convert.ToByte(Lista.TipoAutorizacionId);
                            objListAutorizacion.TratamiendoId = Lista.TratamientoId;

                            /******/
                            Tratamiento ObjListTratamiento = objAutorizacionBL.ObtenerDetalleTratamiento(Lista.TratamientoId);

                            if (ObjListTratamiento.SoloRetrospectivo == true)
                            {
                                objListAutorizacion.Modalidad = "R";
                                objListAutorizacion.Monto = ObjListTratamiento.Monto;
                            }
                            else
                            {
                                objListAutorizacion.Modalidad = "S";
                                objListAutorizacion.Monto = 0;
                            }
                            
                            objListAutorizacion.Version = ObjListTratamiento.Version;
                            objListAutorizacion.Vigencia = objListAutorizacion.Fecha.AddMonths(Convert.ToInt32(Lista.Vigencia));
                            /******/

                            objListAutorizacion.Nro_Solicitud = objListSolicitudAutorizacion.Nro_Solicitud;
                            objListAutorizacion.observacion = String.Empty;
                            objListAutorizacion.Tipo = "P";
                            objListAutorizacion.UsuarioCreacion = objListSolicitudAutorizacion.Usuario_Solicitante;

                            objListSolicitudAutorizacion.Usuario_Procesa = objListSolicitudAutorizacion.Usuario_Solicitante;
                            objListSolicitudAutorizacion.fechaSolicitud = objSolicitudAutorizacion.Fecha_Solicitud;

                            objAutorizacionBL.RegistrarAutorizacionSolicitud(ObjListPaciente, objListAutorizacion, objListSolicitudAutorizacion, Lista);

                        }

                        #endregion

                    }
                    
                    /**************************************************************************/
                    CargarSolicitud();
                    HideColumns(gvListaSolicitudes);
            }
            else if (e.CommandName == "ImgVer") 
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = gvListaSolicitudes.Rows[index];

                Session["Codigo"] = Server.HtmlDecode(row.Cells[0].Text.Trim());
                Session["Est"] = "Editar";

                //Codigo = Server.HtmlDecode(row.Cells[0].Text.Trim());
                //Est = "Editar";

                Server.Transfer("~/Solicitudes/FrmRegistroSolicitud.aspx");
                //Response.Redirect(string.Format("~/Solicitudes/FrmRegistroSolicitud.aspx?NroSolicitud=" + Nro_Solicitud + "&Proceso=" + Proceso));
                
            }
            else if (e.CommandName == "ImgProcesado")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = gvListaSolicitudes.Rows[index];

                //string Nro_Solicitud = Server.HtmlDecode(row.Cells[0].Text.Trim());
                //string Proceso = "Ver";

                Codigo = Server.HtmlDecode(row.Cells[0].Text.Trim());
                Est = "Ver";

                Server.Transfer("~/Solicitudes/FrmSolicitudDetalle.aspx");
                //Response.Redirect(string.Format("~/Solicitudes/FrmSolicitudDetalle.aspx?NroSolicitud=" + Nro_Solicitud + "&Proceso=" + Proceso));

            }
            else if (e.CommandName == "ImgEliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = gvListaSolicitudes.Rows[index];
                string Nro_Solicitud = Server.HtmlDecode(row.Cells[0].Text.Trim());

                /**************************************************************************/
                // Eliminamos Solicitud Seleccionada.

                int result = objSolicitudAutorizacionBL.SolicitudAutorizacion_Eliminar_Todo(Nro_Solicitud);

                /**************************************************************************/

                CargarSolicitud();
                HideColumns(gvListaSolicitudes);

            }


        }

        protected void gvListaSolicitudes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[10].Text == "True")                // CAMPO[09]: ENVIADO 
                {
                    ImageButton imgBtn1 = new ImageButton();
                    imgBtn1.ImageUrl = "~/Images/Mantenimiento/Edit2.ico";
                    imgBtn1.Width = 23;
                    imgBtn1.Height = 23;

                    ImageButton imgBtn2 = new ImageButton();
                    imgBtn2.ImageUrl = "~/Images/Mantenimiento/Ok.ico";
                    imgBtn2.Width = 23;
                    imgBtn2.Height = 23;

                    e.Row.Cells[13].Enabled = false;
                    e.Row.Cells[13].Controls.Clear();
                    e.Row.Cells[13].Controls.Add(imgBtn1);

                    e.Row.Cells[12].Controls.Clear();
                    e.Row.Cells[12].Enabled = false;
                    e.Row.Cells[12].Controls.Add(imgBtn2);                   

                }

                if (e.Row.Cells[11].Text == "True")               // CAMPO[10]: PROCESADO
                {
                    ImageButton img = e.Row.FindControl("ImgProcesado") as ImageButton;
                    img.ImageUrl = "~/Images/Mantenimiento/Ok.ico";
                }
                else if (e.Row.Cells[11].Text == "False")  
                {
                    ImageButton img = e.Row.FindControl("ImgProcesado") as ImageButton;
                    img.ImageUrl = "~/Images/Mantenimiento/NoProcesado.ico";
                }


                //int d = 0;
                //int.TryParse(e.Row.Cells[5].Text, out d);
                //e.Row.Cells[5].Text = d.ToString("N0");
            }


        }

        private void HideColumns(GridView gv)
        {

            if (gv.Rows.Count != 0)
            {
                if (chkEnviado.Checked != true)            // SI ENVIADO ES NO, ENTONCES CELDA = PROCESO (OCULTA)
                {
                    gv.HeaderRow.Cells[14].Visible = false;  //CAMPO[13]: PROCESADO
                    gv.HeaderRow.Cells[13].Visible = true;   //CAMPO[12]: EDITAR
                    gv.HeaderRow.Cells[15].Visible = true;   //CAMPO[14]: ELIMINAR

                    foreach (GridViewRow row in gv.Rows)
                    {
                        row.Cells[14].Visible = false;
                        row.Cells[13].Visible = true;
                        row.Cells[15].Visible = true;
                    }

                }
                else                                       // LO CONTRARIO, ENTONCES CELDA = PROCESO (VISIBLE)
                {
                    gv.HeaderRow.Cells[14].Visible = true;
                    gv.HeaderRow.Cells[13].Visible = false;
                    gv.HeaderRow.Cells[15].Visible = false;

                    foreach (GridViewRow row in gv.Rows)
                    {
                        row.Cells[9].Visible = true;
                        row.Cells[13].Visible = false;
                        row.Cells[15].Visible = false;
                    }

                }


                gv.HeaderRow.Cells[0].Visible = false;    // OCULTAMOS CELDA: NRO_SOLICITUD                
                gv.HeaderRow.Cells[10].Visible = false;    // OCULTAMOS CELDA: ENVIADO
                gv.HeaderRow.Cells[11].Visible = false;    // OCULTAMOS CELDA: PROCESADO

                foreach (GridViewRow row in gv.Rows)
                {
                    row.Cells[0].Visible = false;
                    row.Cells[10].Visible = false;
                    row.Cells[11].Visible = false;
                }

            }
        }

        #endregion

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();
            //dt = objSolicitudAutorizacionBL.SolicitudAutorizacion_Reportes(704,false);

            //FuncionesBasesWeb.ExportarExcel2(dt);
        }

        protected void ddlTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoDocumento.SelectedValue.ToString() == "0")
            {
                txtPaciente.Text = String.Empty;
                txtPaciente.ReadOnly = true;
            }
            else { txtPaciente.ReadOnly = false; }
        }

    }
}