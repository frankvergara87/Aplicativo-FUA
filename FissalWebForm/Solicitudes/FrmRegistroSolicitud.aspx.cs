using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using FissalBE;
using FissalBL;
using FissalWebForm;
using FissalWebForm.ServiceReference1;
using System.Transactions;

namespace FissalWebForm.Solicitudes
{  
    public partial class FrmSolicitudes : System.Web.UI.Page
    {
        SolicitudAutorizacionBL objSolicitudAutorizacionBL = new SolicitudAutorizacionBL();
        PacienteBL objPacienteBL = new PacienteBL();
        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        Paciente objPaciente;
        vw2_SolicitudAutorizacion objListSolicitudAutorizacion = new vw2_SolicitudAutorizacion();
        Paciente ObjListPaciente = new Paciente();
        List<Autorizacion> objListAutorizaciones = new List<Autorizacion>();

        public int Valida, Result, Dato;
        public int ResultGrab = 0, msgsis;
        public string Proceso, NroSolicitud;
        
        siswsSoapClient ws = new siswsSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            /* ESTA VALIDACION SE HIZO EN CASOS DE QUE SE HAYA CERRADO LA SESION ANTERIORMENTE*/
            /* SIEMPRE SE VALIDARA PARA SABER SI EL USUARIO Y/O CLAVE ESTAN EN MEMORIA, CASO */
            /* CONTRARIO NINGUN FORMULARIO DEBERIA ABRIRSE, HASTA INICIA UNA NUEVA SESION */
            /* DE LOGEO  */
            Session["Val"] = null;

            if (Session["login"] == null & Session["password"] == null)
            {
                Response.Redirect("~/FrmLogin.aspx");
            }
            else
            {
                if (!IsPostBack)
                {

                    if (Session["Codigo"] == null & Session["Est"] == null)
                    {
                        NroSolicitud = "";
                        Proceso = "";
                    }
                    else
                    {
                        NroSolicitud = Session["Codigo"].ToString();
                        Proceso = Session["Est"].ToString();
                    }

                    string valor;
                    valor = Session["EstablecimientoId"].ToString();

                    lblUsuario.Text = Session["login"].ToString(); 


                    if (Proceso == "Editar")
                    {                       

                        if (valor == Convert.ToString("0"))
                        {
                            ddlFiltroEstablecimiento.Enabled = true;
                        }
                        else
                        {
                            ddlFiltroEstablecimiento.Enabled = false;
                        }


                        #region 'CARGA DE FILTROS'

                        ChkListBox.Items.Clear();

                        FuncionesBasesWeb.CargarComboTipoDocumento(ddlTipoDocumento);
                        FuncionesBasesWeb.CargarComboTipoDocumento(ddlDni);
                        FuncionesBasesWeb.CargarComboTipoRegimen(ddlTipoRegimen);                   
                        

                        #endregion

                        #region 'CARGA CABECERA'
                        
                        SolicitudAutorizacion ListaSolicitudes = new SolicitudAutorizacion();
                        ListaSolicitudes = objSolicitudAutorizacionBL.SolicitudAutorizacion_Obtener_Completo(NroSolicitud);
                        
                        FuncionesBasesWeb.CargarComboEstablecimiento(ddlFiltroEstablecimiento);
                        ddlFiltroEstablecimiento.SelectedValue = Convert.ToString(ListaSolicitudes.EstablecimientoId);

                        FuncionesBasesWeb.CargarComboCategoria(ddlCategoria, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));


                        
                        ddlFiltroEstablecimiento.SelectedValue = Convert.ToString(ListaSolicitudes.EstablecimientoId);



                        if (ListaSolicitudes.ValidadoFissal == true)
                        {
                            chkFISSAL.Checked = true;
                        }
                        else { chkFISSAL.Checked = false; }

                        if (ListaSolicitudes.ValidadoSIS == true)
                        {
                            chkSIS.Checked = true;
                        }
                        else { chkSIS.Checked = false; }


                        txtPPacienteId.Text = ListaSolicitudes.PacienteId;
                        txtPNombres.Text = ListaSolicitudes.Nombres;
                        txtPOtrosNomb.Text = ListaSolicitudes.OtrosNombres;
                        txtPApePaterno.Text = ListaSolicitudes.ApellidoPaterno;
                        txtPApeMaterno.Text = ListaSolicitudes.ApellidoMaterno;

                      
                        
                        

                        if (ListaSolicitudes.SexoId == 1)
                        {
                            SexMas.Checked = true;
                        }
                        else if (ListaSolicitudes.SexoId == 0)
                        {
                            SexFem.Checked = true;
                        }

                        ddlTipoDocumento.SelectedValue = Convert.ToString(ListaSolicitudes.TipoDocumentoId);
                        txtPNumDocumento.Text = ListaSolicitudes.NumeroDocumento;
                        txtPFechNac.Text = Convert.ToString(ListaSolicitudes.Nacimiento).Substring(0, 10);
                        txtPHistoria.Text = ListaSolicitudes.Historia;
                        ddlTipoRegimen.SelectedValue = Convert.ToString(ListaSolicitudes.TipoRegimenId);

                        ddlCategoria.SelectedValue = ListaSolicitudes.CategoriaId;

                        FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, ddlCategoria.SelectedValue, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));

                        ddlEstadio.SelectedValue = Convert.ToString(ListaSolicitudes.EstadioId);

                        #region 'CARGA DETALLE'

                        FuncionesBasesWeb.CargarListaFase(ChkListBox, ddlCategoria.SelectedValue, Convert.ToInt32(ddlEstadio.SelectedValue.ToString()),  Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));


                        DataTable dt = new DataTable();
                        dt = objSolicitudAutorizacionBL.SolicitudAutorizacionDetalle_ListarGrilla(NroSolicitud);


                        foreach (DataRow drPadre in dt.Rows)
                        {
                            string var = drPadre[4].ToString();

                            foreach (ListItem listItemRoles in ChkListBox.Items)
                            {
                                string var2 = listItemRoles.Value.ToString();

                                if (var == var2)
                                {
                                    listItemRoles.Selected = true;
                                }
                            }
                        }

                        #endregion

                        #endregion

                        ddlDni.SelectedValue = "1";
                        if (txtPHistoria.Text.Length > 0)
                        {
                            txtPHistoria.ReadOnly = true;
                        }
                        else { txtPHistoria.ReadOnly = false; }

                        if (txtPOtrosNomb.Text.Length>0)
                        {
                            txtPOtrosNomb.ReadOnly = true;
                        }
                        else { txtPOtrosNomb.ReadOnly = false; }


                        #region 'SI DATOS NO PERTENECEN AL FISSAL/SIS'

                        if ((ListaSolicitudes.ValidadoFissal == false) & (ListaSolicitudes.ValidadoSIS == false))
                        {
                            //txtPPacienteId.ReadOnly = false;
                            txtPNumDocumento.ReadOnly = false;
                            txtPOtrosNomb.ReadOnly = false;
                            txtPNombres.ReadOnly = false;
                            txtPApePaterno.ReadOnly = false;
                            txtPApeMaterno.ReadOnly = false;
                            SexMas.Enabled = true;
                            SexFem.Enabled = true;
                            ddlTipoDocumento.Enabled = true;
                            txtPFechNac.Enabled = true;
                            txtPHistoria.ReadOnly = false;
                            ddlTipoRegimen.Enabled = true;
                        }

                        #endregion

                        btnNuevo.Visible = false;
                        Buscador.Visible = false;
                        btnRegresar.Visible = true;
                        btnGuardarEnviar.Visible = false;
                        btnListaAutorizaciones.Visible = false;

                        ddlCategoria.Enabled = true;
                        ddlEstadio.Enabled = true;
                        ChkListBox.Enabled = true;

                    }
                    else
                    {
                        ChkListBox.Items.Clear();

                        int resultado = Convert.ToInt32(Session["EstablecimientoId"].ToString());
                        
                        
                        FuncionesBasesWeb.CargarComboEstablecimiento(ddlFiltroEstablecimiento);
                        ddlFiltroEstablecimiento.SelectedValue = Convert.ToString(Session["EstablecimientoId"]);

                        FuncionesBasesWeb.CargarComboCategoria(ddlCategoria, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
                        FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, ddlCategoria.SelectedValue,  Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
                        FuncionesBasesWeb.CargarComboTipoDocumento(ddlTipoDocumento);
                        FuncionesBasesWeb.CargarComboTipoDocumento(ddlDni);
                        FuncionesBasesWeb.CargarComboTipoRegimen(ddlTipoRegimen);
                   

                        ddlDni.SelectedValue = "1";

                        btnRegresar.Visible = false;
                        
                        if (resultado != 0)
                        {
                            ddlFiltroEstablecimiento.Enabled=false;
                            txtPaciente.ReadOnly = false;
                        }
                        else if (resultado == 0)
                        {
                            ddlFiltroEstablecimiento.Enabled = true;
                            txtPaciente.ReadOnly = true;
                        }


                        //if(ddlFiltroEstablecimiento.SelectedValue == "0")
                        //{
                        //    ddlDni.Enabled = false;
                        //}
                        //else{ddlDni.Enabled = true;}
                    }                    
                }

                lblAutorizacionEnEsteEstablecimiento.Visible = false;
                lblAutorizacionesOtrosEstablecimientos.Visible = false;

                frmValidacion.Visible = false;
                frmValidacion3.Visible = false;



               

            }
        }
        
        #region Metodos       

        private void GrabaDatos(int Enviado)
        {
            SolicitudAutorizacion objSolicitudBE;       //CABECERA
            List<SolicitudAutorizacion> objSolicitudListDetBE = new List<SolicitudAutorizacion>(); // LISTADOS DETALLES
            
            if (txtPaciente.Text != String.Empty)
            {
                objSolicitudBE = new SolicitudAutorizacion();

                /*////////////////////// PROCESO CABECERA //////////////////////////*/

                #region 'Cabecera'

                List<SolicitudAutorizacion> ListaAutoriz = new List<SolicitudAutorizacion>();

                objSolicitudBE.EstablecimientoId = (Session["EstablecimientoId"].Equals(0) ? Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue) : Convert.ToInt32(Session["EstablecimientoId"].ToString()));
                if (ddlDni.SelectedValue == "2")
                {
                    objSolicitudBE.PacienteId = txtPaciente.Text.Substring(1, 8);
                    objSolicitudBE.NumeroDocumento = txtPNumDocumento.Text.Substring(1, 8);
                    objSolicitudBE.TipoDocumentoId = 2;
                }
                else { objSolicitudBE.PacienteId = txtPaciente.Text; objSolicitudBE.NumeroDocumento = txtPNumDocumento.Text; objSolicitudBE.TipoDocumentoId = Convert.ToByte(ddlTipoDocumento.SelectedValue); }
                
                
                objSolicitudBE.Nombres = txtPNombres.Text.Trim();
                objSolicitudBE.ApellidoPaterno = txtPApePaterno.Text.Trim();
                objSolicitudBE.ApellidoMaterno = txtPApeMaterno.Text.Trim();
                objSolicitudBE.UsuarioSolicita = Session["login"].ToString();
                objSolicitudBE.Usuario_Procesa = Session["login"].ToString();                
                
                objSolicitudBE.TipoRegimenId = Convert.ToInt32(ddlTipoRegimen.SelectedValue);
                objSolicitudBE.Enviado = Convert.ToByte(Enviado);
                objSolicitudBE.Historia = txtPHistoria.Text.Trim();
                objSolicitudBE.fechaSolicitud = DatosBL.GetDate();

                if (!txtPFechNac.Text.Equals(string.Empty))
                {
                    objSolicitudBE.Nacimiento = Convert.ToDateTime(txtPFechNac.Text);
                }
                

                if (SexMas.Checked == true)
                {
                    objSolicitudBE.SexoId = 1; 
                }
                else if(SexFem.Checked == true) 
                {
                    objSolicitudBE.SexoId = 0; 
                }



                if(chkSIS.Checked == true)
                {
                    objSolicitudBE.ValidadoSIS = true;
                    objSolicitudBE.ValidadoFissal = false;
                    objSolicitudBE.Asegurado = true;
                    if (objSolicitudBE.TipoRegimenId == 1)       //SIS-SUBSIDIADO
                    {
                        objSolicitudBE.Activo = true;
                    }
                    else if (objSolicitudBE.TipoRegimenId == 4)  //SIS-NRUS
                    {
                        /***********************************/
                        if (hfFechVigencia.Value != "")
                        {
                            string FVigencia = hfFechVigencia.Value.ToString();

                            string Eval = FVigencia.Substring(6, 2) + '/' + FVigencia.Substring(4, 2) + '/' + FVigencia.Substring(0, 4);

                            DateTime FEval = Convert.ToDateTime(Eval);

                            DateTime FHoy = DatosBL.GetDate();
                            if (FEval >= FHoy)
                            {
                                objSolicitudBE.Activo = true;
                            }
                            else
                            {
                                objSolicitudBE.Activo = false;
                            }
                        }
                        else { objSolicitudBE.Activo = true; }
                        /***********************************/
                    }


                }
                else if (chkFISSAL.Checked == true)
                {
                    objSolicitudBE.ValidadoSIS = false;
                    objSolicitudBE.ValidadoFissal = true;
                    //objSolicitudBE.Asegurado = true;
                    //objSolicitudBE.Activo = Convert.ToBoolean(hdfEstado.Value);      
                }
                else if (chkSIS.Checked == false & chkFISSAL.Checked == false)
                {
                    objSolicitudBE.ValidadoSIS = false;
                    objSolicitudBE.ValidadoFissal = false;
                    //objSolicitudBE.Asegurado = false;
                    //objSolicitudBE.Activo = false;                
                }


                #endregion

                ListaAutoriz = ValidaDetalles(txtPaciente.Text.Trim());  // Validamos si la Cabecera tiene Detalles

                #region Lleno Grilla Resultados
                //------------------------
                //----------------------

                var query =  ListaAutoriz.Where(A => A.Observaciones == "Guardado");
                List<SolicitudAutorizacion> resultados = new List<SolicitudAutorizacion>();


                foreach (var result in query)
                {
                    resultados.Add(result);
                }

                dgvListaTratamientosAprob.DataSource = resultados;
                dgvListaTratamientosAprob.DataBind();

                if (resultados.Count() != 0)
                {
                    lblResultRegistrados.ForeColor = System.Drawing.Color.Red;
                    lblResultRegistrados.Text = Convert.ToString(resultados.Count());
                }
                else
                {
                    lblResultRegistrados.ForeColor = System.Drawing.Color.Black;
                    lblResultRegistrados.Text = Convert.ToString(resultados.Count());
                }

                //--------------------------
                //----------------------




                //------------------------
                //----------------------

                var query2 = ListaAutoriz.Where(A => A.Observaciones == "Autorizacion Vigente");
                List<SolicitudAutorizacion> NoAutorizados = new List<SolicitudAutorizacion>();
                foreach (var result2 in query2)
                {
                    NoAutorizados.Add(result2);
                }
                dgvListaTratamientosObserv.DataSource = NoAutorizados;
                dgvListaTratamientosObserv.DataBind();


                if (NoAutorizados.Count() != 0)
                {
                    lblResultSolicitados.ForeColor = System.Drawing.Color.Red;
                    lblResultSolicitados.Text = Convert.ToString(NoAutorizados.Count());
                }
                else
                {
                    lblResultSolicitados.ForeColor = System.Drawing.Color.Black;
                    lblResultSolicitados.Text = Convert.ToString(NoAutorizados.Count());
                }


                //--------------------------
                //----------------------


                //------------------------
                //----------------------

                var query3 = ListaAutoriz.Where(A => A.Observaciones == "Solicitado").Take(1);
                List<SolicitudAutorizacion> Existentes = new List<SolicitudAutorizacion>();

                foreach (var result3 in query3)
                {
                    Existentes.Add(result3);
                }

                dgvListaTratamientosExistentes.DataSource = Existentes;
                dgvListaTratamientosExistentes.DataBind();


                if (Existentes.Count() != 0)
                {
                    lblResultObservados.ForeColor = System.Drawing.Color.Red;
                    lblResultObservados.Text = Convert.ToString(Existentes.Count());
                    lblMensCad.Visible = true;
                }
                else
                {
                    lblResultObservados.ForeColor = System.Drawing.Color.Black;
                    lblResultObservados.Text = Convert.ToString(Existentes.Count());
                    lblMensCad.Visible = false;
                }


                //--------------------------
                //----------------------
                #endregion

                frmValidacion3.Visible = true;

                if (resultados.Count() != 0)  // Si Flg = 0 [SI Tratamiento tiene Autorizacion] - Entonces NO se guarda la [Cabecera | Detalle])
                {
                    int Cont = objSolicitudAutorizacionBL.ObtenerNroSolicitud();
                    objSolicitudBE.Nro_Solicitud = Convert.ToString(Cont + 1);                   

                        /*//////////////////////  PROCESO DETALLE  */

                        int ContDet = objSolicitudAutorizacionBL.ObtenerNroDetalle(objSolicitudBE.Nro_Solicitud) + 1;
                    
                        foreach (SolicitudAutorizacion ListAprob in resultados)
                        { 
                            //if (ListAprob.Observaciones == "Guardado")
                            //{
                                SolicitudAutorizacion objSolicitudDetBE = new SolicitudAutorizacion();   
                                objSolicitudDetBE.Nro_Solicitud = objSolicitudBE.Nro_Solicitud; // Grabo con el Id del Maestro Nro Solicitud 
                                objSolicitudDetBE.PacienteId = objSolicitudBE.PacienteId;
                                objSolicitudDetBE.EstablecimientoId = Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue);
                                objSolicitudDetBE.CategoriaId = ddlCategoria.SelectedValue.ToString();
                                objSolicitudDetBE.EstadioId = Convert.ToInt32(ddlEstadio.SelectedValue.ToString());
                                objSolicitudDetBE.FaseId = Convert.ToInt32(ListAprob.FaseId.ToString()); // Valor a repetirse segun seleccion

                                objSolicitudDetBE.Adicional = Convert.ToBoolean(0);

                                SolicitudAutorizacion objTipoAutorizacion = new SolicitudAutorizacion();
                                objTipoAutorizacion = objSolicitudAutorizacionBL.Obtener_TipoAutorizacion(objSolicitudDetBE.EstablecimientoId, objSolicitudDetBE.CategoriaId, objSolicitudDetBE.EstadioId, objSolicitudDetBE.FaseId);
                                objSolicitudDetBE.TipoAutorizacionId = objTipoAutorizacion.TipoAutorizacionId;
                                objSolicitudDetBE.TratamientoId = objTipoAutorizacion.TratamientoId;

                                objSolicitudDetBE.Vigencia = objTipoAutorizacion.Vigencia;
                                objSolicitudDetBE.Version = objTipoAutorizacion.Version;
                                objSolicitudDetBE.Monto = objTipoAutorizacion.Monto;
                                objSolicitudDetBE.SoloRetrospectivo = objTipoAutorizacion.SoloRetrospectivo;

                             
                                objSolicitudDetBE.DetalleId = ContDet++;

                                objSolicitudListDetBE.Add(objSolicitudDetBE);

                            //}
                        }

                        bool seGrabaronSolicitudes = objAutorizacionBL.RegistraSolicitudes(objSolicitudBE, objSolicitudListDetBE);
                        if (seGrabaronSolicitudes)
                        {
                            ddlFiltroEstablecimiento.Enabled = false;
                            ddlDni.Enabled = false;
                        }
                        else { /* ERROR */ }
                }
            }
            else 
            {
                ScriptManager.RegisterStartupScript(this.upSetSession, GetType(), "Mostrar Mensaje", "Dialog('Ingrese un Nro Documento..!!');", true);
            }
        }

        private void ActualizarDatos(int Enviado, string NroSolicitud) 
        {
            SolicitudAutorizacion objSolicitudBE = new SolicitudAutorizacion();       //CABECERA
            List<SolicitudAutorizacion> objSolicitudListDetBE = new List<SolicitudAutorizacion>();    //DETALLES

            #region 'CABECERA'

            List<SolicitudAutorizacion> ListaAutoriz = new List<SolicitudAutorizacion>();
            objSolicitudBE.Nro_Solicitud = NroSolicitud;

            objSolicitudBE.EstablecimientoId = (Session["EstablecimientoId"].Equals(0) ? Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue) : Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            objSolicitudBE.PacienteId = txtPNumDocumento.Text.Trim();
            objSolicitudBE.Nombres = txtPNombres.Text.Trim();
            objSolicitudBE.OtrosNombres = txtPOtrosNomb.Text;
            objSolicitudBE.ApellidoPaterno = txtPApePaterno.Text.Trim();
            objSolicitudBE.ApellidoMaterno = txtPApeMaterno.Text.Trim();
            objSolicitudBE.TipoDocumentoId = Convert.ToByte(ddlTipoDocumento.SelectedValue);
            objSolicitudBE.NumeroDocumento = txtPNumDocumento.Text.Trim();
            objSolicitudBE.TipoRegimenId = Convert.ToInt32(ddlTipoRegimen.SelectedValue);
            objSolicitudBE.Historia = txtPHistoria.Text.Trim();

            if (!txtPFechNac.Text.Equals(string.Empty))
            {
                objSolicitudBE.Nacimiento = Convert.ToDateTime(txtPFechNac.Text);
            }

            if (SexMas.Checked == true)
            {
                objSolicitudBE.SexoId = 1;
            }
            else if (SexFem.Checked == true)
            {
                objSolicitudBE.SexoId = 0;
            }

            objSolicitudBE.Enviado = Convert.ToByte(Enviado);

            #endregion

            ListaAutoriz = ValidaDetalles(objSolicitudBE.Nro_Solicitud);  // Validamos si la Cabecera tiene Detalles

            #region Lleno Grilla Resultados
            //------------------------
            //----------------------

            var query = ListaAutoriz.Where(A => A.Observaciones == "Guardado");
            List<SolicitudAutorizacion> resultados = new List<SolicitudAutorizacion>();


            foreach (var result in query)
            {
                resultados.Add(result);
            }

            dgvListaTratamientosAprob.DataSource = resultados;
            dgvListaTratamientosAprob.DataBind();

            if (resultados.Count() != 0)
            {
                lblResultRegistrados.ForeColor = System.Drawing.Color.Red;
                lblResultRegistrados.Text = Convert.ToString(resultados.Count());
            }
            else
            {
                lblResultRegistrados.ForeColor = System.Drawing.Color.Black;
                lblResultRegistrados.Text = Convert.ToString(resultados.Count());
            }

            //--------------------------
            //----------------------




            //------------------------
            //----------------------

            var query2 = ListaAutoriz.Where(A => A.Observaciones == "Autorizacion Vigente");
            List<SolicitudAutorizacion> NoAutorizados = new List<SolicitudAutorizacion>();
            foreach (var result2 in query2)
            {
                NoAutorizados.Add(result2);
            }
            dgvListaTratamientosObserv.DataSource = NoAutorizados;
            dgvListaTratamientosObserv.DataBind();


            if (NoAutorizados.Count() != 0)
            {
                lblResultSolicitados.ForeColor = System.Drawing.Color.Red;
                lblResultSolicitados.Text = Convert.ToString(NoAutorizados.Count());
            }
            else
            {
                lblResultSolicitados.ForeColor = System.Drawing.Color.Black;
                lblResultSolicitados.Text = Convert.ToString(NoAutorizados.Count());
            }


            //--------------------------
            //----------------------


            //------------------------
            //----------------------

            var query3 = ListaAutoriz.Where(A => A.Observaciones == "Solicitado").Take(1);
            List<SolicitudAutorizacion> Existentes = new List<SolicitudAutorizacion>();
            foreach (var result3 in query3)
            {
                Existentes.Add(result3);
            }
            dgvListaTratamientosExistentes.DataSource = Existentes;
            dgvListaTratamientosExistentes.DataBind();


            if (Existentes.Count() != 0)
            {
                lblResultObservados.ForeColor = System.Drawing.Color.Red;
                lblResultObservados.Text = Convert.ToString(Existentes.Count());
            }
            else
            {
                lblResultObservados.ForeColor = System.Drawing.Color.Black;
                lblResultObservados.Text = Convert.ToString(Existentes.Count());
            }


            //--------------------------
            //----------------------

            frmValidacion3.Visible = true;

            #endregion


            if (resultados.Count() != 0)  // Si Flg = 0 [SI Tratamiento tiene Autorizacion] - Entonces NO se guarda la [Cabecera | Detalle])
            {
                    /*//////////////////////  PROCESO DETALLE  */

                    int ContDet = objSolicitudAutorizacionBL.ObtenerNroDetalle(objSolicitudBE.Nro_Solicitud);

                    foreach (SolicitudAutorizacion ListAprob in resultados)
                    { 
                        if (ListAprob.Observaciones == "Guardado")
                        {
                            SolicitudAutorizacion objSolicitudDetBE = new SolicitudAutorizacion();    //DETALLES
                            objSolicitudDetBE.Nro_Solicitud = objSolicitudBE.Nro_Solicitud; // Grabo con el Id del Maestro Nro Solicitud 
                            objSolicitudDetBE.PacienteId = txtPPacienteId.Text.Trim();
                            objSolicitudDetBE.EstablecimientoId = Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue);
                            objSolicitudDetBE.CategoriaId = ddlCategoria.SelectedValue.ToString();
                            objSolicitudDetBE.EstadioId = Convert.ToInt32(ddlEstadio.SelectedValue.ToString());
                            objSolicitudDetBE.FaseId = Convert.ToInt32(ListAprob.FaseId.ToString()); // Valor a repetirse segun seleccion

                            objSolicitudDetBE.Adicional = Convert.ToBoolean(0);


                            // OBTENGO EL TIPOAUTORIZACIONID

                            SolicitudAutorizacion objTipoAutorizacion = new SolicitudAutorizacion();
                            objTipoAutorizacion = objSolicitudAutorizacionBL.Obtener_TipoAutorizacion(objSolicitudDetBE.EstablecimientoId, objSolicitudDetBE.CategoriaId, objSolicitudDetBE.EstadioId, objSolicitudDetBE.FaseId);
                            objSolicitudDetBE.TipoAutorizacionId = objTipoAutorizacion.TipoAutorizacionId;
                            objSolicitudDetBE.TratamientoId = objTipoAutorizacion.TratamientoId;
                            objSolicitudDetBE.Vigencia = objTipoAutorizacion.Vigencia;
                            objSolicitudDetBE.Version = objTipoAutorizacion.Version;

                            // **************************** /                            
                            objSolicitudDetBE.DetalleId = ContDet++;

                            objSolicitudListDetBE.Add(objSolicitudDetBE);

                        }
                    }

                    bool seActualizaronSolicitudes = objAutorizacionBL.ActualizaSolicitudes(objSolicitudBE, objSolicitudListDetBE);
                    if (seActualizaronSolicitudes)
                    {
                        ddlFiltroEstablecimiento.Enabled = false;
                        ddlDni.Enabled = false;
                        /* Solicitud Registrada */
                    }
                    else { /* ERROR */ }
            }

        
        }

        private List<SolicitudAutorizacion> ValidaDetalles(string NroSolicitud) 
        {
            List<SolicitudAutorizacion> ListaAutorizados = new List<SolicitudAutorizacion>();

            SolicitudAutorizacion objSolicitudDetBE = new SolicitudAutorizacion();
            int Valida = 0;

            foreach (ListItem itemActual in ChkListBox.Items)

            if (itemActual.Selected == true)
            {

                objSolicitudDetBE.PacienteId = txtPPacienteId.Text;
                objSolicitudDetBE.EstablecimientoId = Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString());
                objSolicitudDetBE.CategoriaId = ddlCategoria.SelectedValue.ToString();
                objSolicitudDetBE.EstadioId = Convert.ToInt32(ddlEstadio.SelectedValue.ToString());
                objSolicitudDetBE.FaseId = Convert.ToInt32(itemActual.Value.ToString()); // Valor a repetirse segun seleccion



                // OBTENGO EL TIPOAUTORIZACIONID y TRATAMIENTO

                SolicitudAutorizacion objTipoAutorizacion = new SolicitudAutorizacion();
                objTipoAutorizacion = objSolicitudAutorizacionBL.Obtener_TipoAutorizacion(objSolicitudDetBE.EstablecimientoId, objSolicitudDetBE.CategoriaId, objSolicitudDetBE.EstadioId, objSolicitudDetBE.FaseId);
                
                objSolicitudDetBE.TipoAutorizacionId = objTipoAutorizacion.TipoAutorizacionId;
                objSolicitudDetBE.TratamientoId = objTipoAutorizacion.TratamientoId;
                objSolicitudDetBE.CadenaId = objTipoAutorizacion.CadenaId;


                /* SE DESEA ENVIAR LOS PARAMETROS:  PacienteId / CadenaId / Establecimiento / FaseId */

                Valida = objSolicitudAutorizacionBL.SolicitudAutorizacionDet_Validar(txtPPacienteId.Text.Trim(), objSolicitudDetBE.TratamientoId, objSolicitudDetBE.EstablecimientoId, Convert.ToInt32(objSolicitudDetBE.FaseId));

                /******* COMENTARIO *****************************/

                /*\ SI "VALIDA = 1"    Tratamiento posee Autorizaciones Activas Vigentes 
                
                /*******************/
                SolicitudAutorizacion ObjAutorizados = new SolicitudAutorizacion();
                ObjAutorizados.CategoriaId = objSolicitudDetBE.CategoriaId;
                ObjAutorizados.EstadioId = objSolicitudDetBE.EstadioId;
                ObjAutorizados.FaseId = objSolicitudDetBE.FaseId;
                ObjAutorizados.CadenaId = objSolicitudDetBE.CadenaId;
                

                    if (Valida == 3) 
                    {  
                        // Si Pasa Validacion | "Este" Tratamiento no tiene Autorizaciones vigentes| 
                        ObjAutorizados.Observaciones = "Guardado";
                        ListaAutorizados.Add(ObjAutorizados);
                    }
                    else if ((Valida == 2) || (Valida == 4))
                    {
                        ObjAutorizados.Observaciones = "Solicitado";
                        ObjAutorizados.EstadioId = 0;
                        ObjAutorizados.FaseId = 0;
                        ListaAutorizados.Add(ObjAutorizados);
                    }

                    else if (Valida == 1)
                    {
                        ObjAutorizados.Observaciones = "Autorizacion Vigente";
                        ListaAutorizados.Add(ObjAutorizados);
                    }
            }

            return ListaAutorizados; 
        }

        private void ConsultarAsegurado(string Documento, string TipoDocumento)
        {
           
            msgsis = 0;

            hfFechVigencia.Value = String.Empty;
            frmValidacion.Visible = false;

            lblAutorizacionEnEsteEstablecimiento.Visible = false;
            lblAutorizacionesOtrosEstablecimientos.Visible = false;

            lblPacienteSIS.Text = String.Empty;
            lblPacienteFissal.Text = String.Empty;


            CredencialWS Clave = new CredencialWS();
            siswsSoapClient ws = new siswsSoapClient();

            /***********************CREDENCIALES WS.*/
            Clave.Usuario = "fissal";
            Clave.Clave = "uhy2c32zlk";

            /***********************/
            /*******************/

            #region 'VARIABLES'

            string dni;
            string ApePaterno;
            string ApeMaterno;
            string Nombres;
            string FechaVigencia;
            string Distrito;
            string Identificacion;
            string FechaAfilicion;
            string Nacimiento;
            string Sexo;
            string Direccion;
            string Autorizacion;
            string Componente;
            string FinVigencia;
            string NumAfiliacion;

            string Trama;
            string[] Campos;

            #endregion

                try
                { 
                    /*************CONSULTAMOS DATA SIS - WS**/
                    Trama = ws.BuscarAseguradosDocIdent(Clave, ddlFiltroEstablecimiento.SelectedValue.ToString(), TipoDocumento, Documento);
                }
                catch //(Exception ex)
                {
                    Trama = string.Empty;   
                    msgsis = 1;
                }                   

                if (Trama != string.Empty)
                {
                    LimpiaControles();
                    SeteaControles(2);
                    txtPHistoria.ReadOnly = false;

                    Campos = Trama.Split('|');

                    #region 'CARGAMOS PARAMETROS OBTENIDOS DEL SIS'

                    dni = Campos[1];
                    ApePaterno = Campos[2];
                    ApeMaterno = Campos[3];
                    Nombres = Campos[4];
                    FechaVigencia = Campos[5];
                    Distrito = Campos[6];
                    Identificacion = Campos[7];
                    FechaAfilicion = Campos[8];
                    Nacimiento = Campos[9];
                    Sexo = Campos[10];
                    Direccion = Campos[11];
                    Autorizacion = Campos[12];
                    Componente = Campos[13];
                    FinVigencia = Campos[16];
                    NumAfiliacion = Campos[15];

                    txtPPacienteId.Text = Campos[1];
                    txtPApePaterno.Text = Campos[2];
                    txtPApeMaterno.Text = Campos[3];                    

                    //string[] partes = Campos[4].Split(' ');
                    txtPNombres.Text = Campos[4];
                    //txtPOtrosNomb.Text = partes[1];

                    txtPNumDocumento.Text = Campos[1];


                    /***********************************/

                    if (FechaVigencia.ToString() != "")
                    {
                        hfFechVigencia.Value = Campos[16].ToString();
                    
                    }
                    
                    /***********************************/
                    if (Componente == "1") 
                    {
                        ddlTipoRegimen.SelectedValue = Componente;
                    }
                    else if (Componente == "2") 
                    {
                        ddlTipoRegimen.SelectedValue = Convert.ToString(4);                   
                    }


                    /***********************************/


                    txtPFechNac.Text = Campos[9].Substring(6, 2) + "/" + Campos[9].Substring(4, 2) + "/" + Campos[9].Substring(0, 4);

                    if (txtPFechNac.Text.Length > 0)
                    {
                        txtPFechNac.Enabled = false;
                    }
                    else { txtPFechNac.Enabled = true; }


                    if (Sexo == "0")
                    {
                        SexFem.Checked = true;
                        SexMas.Checked = false;
                    }
                    else if (Sexo == "1")
                    {
                        SexMas.Checked = true;
                        SexFem.Checked = false;
                    }

                    if (txtPNumDocumento.Text.Length == 8)
                    {
                        ddlTipoDocumento.SelectedValue = "1";
                    }


                    if (txtPOtrosNomb.Text.Length > 0)
                    {
                        txtPOtrosNomb.ReadOnly = true;
                    }
                    else { txtPOtrosNomb.ReadOnly = false; }

                    #endregion

                    #region 'CHECK|VALIDACION SIS'

                    chkSIS.Checked = true;
                    chkFISSAL.Checked = false;

                    #endregion

                    #region 'CARGAMOS GRILLA'

                    if (ddlDni.SelectedValue == "3")
                    {
                        Documento = Documento.Substring(1, 8);
                    }

                    gvAutorizaciones.DataSource = objAutorizacionBL.ListaAutorizacionesxIdPacientexSoloEstablecimiento(Documento, Convert.ToInt32(TipoDocumento),Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));
                    gvAutorizaciones.DataBind();

                    gvAutorizacionesOtrosEstablecimiento.DataSource = objAutorizacionBL.ListaAutorizacionesxIdPacientexOtroEstablecimiento(Documento, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));
                    gvAutorizacionesOtrosEstablecimiento.DataBind();

                    if (gvAutorizaciones.Rows.Count > 0)
                    {
                        gvAutorizaciones.Visible = true;
                        lblAutorizacionEnEsteEstablecimiento.Visible = true;
                        frmValidacion.Visible = true;
                    }

                    if (gvAutorizacionesOtrosEstablecimiento.Rows.Count > 0)
                    {
                        gvAutorizacionesOtrosEstablecimiento.Visible = true;
                        lblAutorizacionesOtrosEstablecimientos.Visible = true;
                        frmValidacion.Visible = true;
                    }

                    #endregion

                    ddlTipoDocumento.SelectedValue = ddlDni.SelectedValue;
                    ddlCategoria.Enabled = true;
                    ddlEstadio.Enabled = true;
                    ChkListBox.Enabled = true;
                    
                }
                else
                {

                    DataSet dsDatos = new DataSet(); //esto crea un dataset vacio no 
                    gvAutorizaciones.DataSource = dsDatos;
                    gvAutorizaciones.Visible = false;

                    DataSet dsDatos2 = new DataSet(); //esto crea un dataset vacio no 
                    gvAutorizacionesOtrosEstablecimiento.DataSource = dsDatos2;
                    gvAutorizacionesOtrosEstablecimiento.Visible = false;

                    frmValidacion.Visible = true;

                    if (msgsis == 0)
                    {
                        lblPacienteSIS.Text = "No se encuentra el Paciente Activo en el SIS";
                    }
                    else { lblPacienteSIS.Text = "Problemas de conexion con el SIS.."; }


                    /*************CONSULTAMOS DATA FISSAL******/

                    objPaciente = objPacienteBL.Paciente_PacientexId(Documento, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));

                    if (objPaciente != null)
                    {

                        //LimpiaControles();

                        LimpiaControles();
                        SeteaControles(2);
                        txtPHistoria.ReadOnly = false;

                        #region 'CARGAMOS GRILLA'

                        gvAutorizaciones.DataSource = objAutorizacionBL.ListaAutorizacionesxIdPacientexSoloEstablecimiento(Documento, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));
                        gvAutorizaciones.DataBind();

                        gvAutorizacionesOtrosEstablecimiento.DataSource = objAutorizacionBL.ListaAutorizacionesxIdPacientexOtroEstablecimiento(Documento, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));
                        gvAutorizacionesOtrosEstablecimiento.DataBind();

                        if (gvAutorizaciones.Rows.Count > 0)
                        {
                            gvAutorizaciones.Visible = true;
                            lblAutorizacionEnEsteEstablecimiento.Visible = true;
                        }

                        if (gvAutorizacionesOtrosEstablecimiento.Rows.Count > 0)
                        {
                            gvAutorizacionesOtrosEstablecimiento.Visible = true;
                            lblAutorizacionesOtrosEstablecimientos.Visible = true;
                        }

                        #endregion

                        #region 'CARGAMOS PARAMETROS OBTENIDOS DEL FISSAL'

                        txtPPacienteId.Text = txtPaciente.Text;
                        txtPNombres.Text = objPaciente.Nombres;
                        txtPApePaterno.Text = objPaciente.ApellidoPaterno;
                        txtPApeMaterno.Text = objPaciente.ApellidoMaterno;
                        txtPOtrosNomb.Text = objPaciente.OtrosNombres;
                        txtPHistoria.Text = objPaciente.Historia;

                        if (txtPHistoria.Text.Length > 0)
                        {
                            txtPHistoria.ReadOnly = true;
                        }
                        else { txtPHistoria.ReadOnly = false; }


                        if (objPaciente.SexoId == 0)
                        {
                            SexFem.Checked = true;
                            SexMas.Checked = false;
                        }
                        else if (objPaciente.SexoId == 1)
                        {
                            SexMas.Checked = true;
                            SexFem.Checked = false;
                        }

                        ddlTipoRegimen.SelectedValue = Convert.ToString(objPaciente.TipoRegimenId);
                        ddlTipoDocumento.SelectedValue = Convert.ToString(objPaciente.TipoDocumentoId);
                        txtPNumDocumento.Text = objPaciente.NumeroDocumento;
                        txtPFechNac.Text = (Convert.ToString(objPaciente.Nacimiento)).Substring(0,10);

                        if (txtPFechNac.Text.Length > 0)
                        {
                            txtPFechNac.Enabled = false;
                        }
                        else { txtPFechNac.Enabled = true; }

                        hdfEstado.Value = Convert.ToString(objPaciente.Estado);

                        #endregion

                        #region 'CHECK|VALIDACION FISSAL'

                        chkSIS.Checked = false;
                        chkFISSAL.Checked = true;

                        #endregion

                        ddlTipoDocumento.SelectedValue = ddlDni.SelectedValue;
                        ddlCategoria.Enabled = true;
                        ddlEstadio.Enabled = true;
                        ChkListBox.Enabled = true;    

                    }
                    else
                    {

                        lblPacienteFissal.Text = "No existe Paciente en Fissal";
                        lblAutorizacionEnEsteEstablecimiento.Visible = false;
                        lblAutorizacionesOtrosEstablecimientos.Visible = false;
                        frmValidacion.Visible = true;


                        LimpiaControles();
                        SeteaControles(1);
                        txtPPacienteId.ReadOnly = true;
                        txtPPacienteId.Text = txtPaciente.Text.Trim();
                        txtPNumDocumento.Text = txtPaciente.Text.Trim();
                        ddlTipoDocumento.SelectedValue = ddlDni.SelectedValue;

                        /******************************************************/

                        ddlTipoDocumento.Enabled = false;
                        txtPNumDocumento.ReadOnly = true;

                        ddlCategoria.Enabled=true;
                        ddlEstadio.Enabled = true;
                        ChkListBox.Enabled = true;

                        /******************************************************/
                    }
                }
            //}
            //else { ScriptManager.RegisterStartupScript(this.upSetSession, GetType(), "Mostrar Mensaje", "Dialog('Por favor ingrese un Documento..!!');", true); }

        }

        private void ConsultarAseguradoxHistoriaClinica(string Documento, string TipoDocumento, int Establecimiento) 
        {
            msgsis = 0;

            hfFechVigencia.Value = String.Empty;
            frmValidacion.Visible = false;

            lblAutorizacionEnEsteEstablecimiento.Visible = false;
            lblAutorizacionesOtrosEstablecimientos.Visible = false;

            lblPacienteSIS.Text = String.Empty;
            lblPacienteFissal.Text = String.Empty;

                                /*************CONSULTAMOS DATA FISSAL******/

            objPaciente = objPacienteBL.Paciente_PacientexHistoria(Documento, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));

            if (objPaciente != null)
            {

                //LimpiaControles();

                LimpiaControles();
                SeteaControles(2);
                txtPHistoria.ReadOnly = false;

                #region 'CARGAMOS GRILLA'

                gvAutorizaciones.DataSource = objAutorizacionBL.ListaAutorizacionesxIdPacientexSoloEstablecimiento(objPaciente.PacienteId, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));
                gvAutorizaciones.DataBind();

                gvAutorizacionesOtrosEstablecimiento.DataSource = objAutorizacionBL.ListaAutorizacionesxIdPacientexOtroEstablecimiento(objPaciente.PacienteId, Convert.ToInt32(TipoDocumento), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue.ToString()));
                gvAutorizacionesOtrosEstablecimiento.DataBind();

                if (gvAutorizaciones.Rows.Count > 0)
                {
                    gvAutorizaciones.Visible = true;
                    lblAutorizacionEnEsteEstablecimiento.Visible = true;
                }

                if (gvAutorizacionesOtrosEstablecimiento.Rows.Count > 0)
                {
                    gvAutorizacionesOtrosEstablecimiento.Visible = true;
                    lblAutorizacionesOtrosEstablecimientos.Visible = true;
                }

                #endregion

                #region 'CARGAMOS PARAMETROS OBTENIDOS DEL FISSAL'

                txtPPacienteId.Text = txtPaciente.Text;
                txtPNombres.Text = objPaciente.Nombres;
                txtPApePaterno.Text = objPaciente.ApellidoPaterno;
                txtPApeMaterno.Text = objPaciente.ApellidoMaterno;
                txtPOtrosNomb.Text = objPaciente.OtrosNombres;
                txtPHistoria.Text = objPaciente.Historia;

                if (txtPHistoria.Text.Length > 0)
                {
                    txtPHistoria.ReadOnly = true;
                }
                else { txtPHistoria.ReadOnly = false; }


                if (objPaciente.SexoId == 0)
                {
                    SexFem.Checked = true;
                    SexMas.Checked = false;
                }
                else if (objPaciente.SexoId == 1)
                {
                    SexMas.Checked = true;
                    SexFem.Checked = false;
                }

                ddlTipoRegimen.SelectedValue = Convert.ToString(objPaciente.TipoRegimenId);
                ddlTipoDocumento.SelectedValue = Convert.ToString(objPaciente.TipoDocumentoId);
                txtPNumDocumento.Text = objPaciente.NumeroDocumento;
                txtPFechNac.Text = (Convert.ToString(objPaciente.Nacimiento)).Substring(0,10);

                if (txtPFechNac.Text.Length > 0)
                {
                    txtPFechNac.Enabled = false;
                }
                else { txtPFechNac.Enabled = true; }

                hdfEstado.Value = Convert.ToString(objPaciente.Estado);

                #endregion

                #region 'CHECK|VALIDACION FISSAL'

                chkSIS.Checked = false;
                chkFISSAL.Checked = true;

                #endregion

                ddlTipoDocumento.SelectedValue = ddlDni.SelectedValue;
                ddlCategoria.Enabled = true;
                ddlEstadio.Enabled = true;
                ChkListBox.Enabled = true;    

            }
            else
            {

                lblPacienteFissal.Text = "No existe Paciente en Fissal";
                lblAutorizacionEnEsteEstablecimiento.Visible = false;
                lblAutorizacionesOtrosEstablecimientos.Visible = false;
                frmValidacion.Visible = true;


                LimpiaControles();
                SeteaControles(1);
                txtPPacienteId.ReadOnly = true;
                txtPPacienteId.Text = txtPaciente.Text.Trim();
                txtPNumDocumento.Text = txtPaciente.Text.Trim();
                ddlTipoDocumento.SelectedValue = ddlDni.SelectedValue;

                /******************************************************/

                ddlTipoDocumento.Enabled = false;
                txtPNumDocumento.ReadOnly = true;

                ddlCategoria.Enabled=true;
                ddlEstadio.Enabled = true;
                ChkListBox.Enabled = true;

                /******************************************************/
            }
        }


        #endregion

        #region Metodos Auxiliares
        
        void LimpiaControles() 
        {
            #region 'LIMPIA CONTROLES'

            txtPPacienteId.Text = String.Empty;
            txtPNombres.Text = String.Empty;
            txtPOtrosNomb.Text = String.Empty;
            txtPApePaterno.Text = String.Empty;
            txtPApeMaterno.Text = String.Empty;
            txtPFechNac.Text = String.Empty;
            SexFem.Checked = false;
            SexMas.Checked = false;
            ddlTipoDocumento.SelectedValue = "0";
            ddlTipoRegimen.SelectedValue = "0";
            txtPNumDocumento.Text = String.Empty;
            txtPHistoria.Text = String.Empty;

            chkFISSAL.Checked = false;
            chkSIS.Checked = false;


            FuncionesBasesWeb.CargarComboCategoria(ddlCategoria, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, ddlCategoria.SelectedValue, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            if (ddlCategoria.SelectedValue == String.Empty)
            {
                ChkListBox.Items.Clear();
            }

            if (ddlEstadio.SelectedValue == String.Empty)
            {
                ChkListBox.Items.Clear();
            }
            else { FuncionesBasesWeb.CargarListaFase(ChkListBox, ddlCategoria.SelectedValue, Convert.ToInt32(ddlEstadio.SelectedValue.ToString()), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue)); }

            #endregion        
        }

        void SeteaControles(int var) 
        {
            if( var == 1) // Activa
            {
                #region 'ACTIVA CONTROLES'

                txtPPacienteId.ReadOnly = false;
                txtPNombres.ReadOnly = false;
                txtPOtrosNomb.ReadOnly = false;
                txtPApePaterno.ReadOnly = false;
                txtPApeMaterno.ReadOnly = false;
                txtPFechNac.ReadOnly = false;
                SexFem.Checked = false;
                SexMas.Checked = false;
                ddlTipoDocumento.Enabled = true;
                ddlTipoRegimen.Enabled = true;
                txtPFechNac.Enabled = true;
                txtPNumDocumento.ReadOnly = false;
                txtPHistoria.ReadOnly = false;
                SexMas.Enabled = true;
                SexFem.Enabled = true;

                
                //ddlCategoria.Enabled = true;
                //ddlEstadio.Enabled = true;
                //ChkListBox.Enabled = true;

                //ddlCategoria.Enabled = true;
                //ddlEstadio.Enabled = true;
                //ChkListBox.Enabled = true;

                #endregion        
            }
            else if (var == 2)  // DesActiva
            { 
                #region 'DESACTIVA CONTROLES'

                txtPPacienteId.ReadOnly = true;
                txtPNombres.ReadOnly = true;
                txtPOtrosNomb.ReadOnly = true;
                txtPApePaterno.ReadOnly = true;
                txtPApeMaterno.ReadOnly = true;
                txtPFechNac.Enabled = false;
                SexFem.Checked = true;
                SexMas.Checked = true;

                ddlTipoDocumento.Enabled = false;
                ddlTipoRegimen.Enabled = false;
                txtPFechNac.Enabled = false;

                txtPNumDocumento.ReadOnly = true;
                txtPHistoria.ReadOnly = true;

                SexMas.Enabled = false;
                SexFem.Enabled = false;

                //ddlCategoria.Enabled = false;
                //ddlEstadio.Enabled = false;
                //ChkListBox.Enabled = false;

                //ddlCategoria.Enabled = true;
                //ddlEstadio.Enabled = true;
                //ChkListBox.Enabled = true;
                #endregion        
            }
        }

        private bool Validar(string dato)
        {
            if (dato != "")
                return true;

            else
                return false;
        }

        #endregion

        #region Botones

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            /********************************************/
            /* VALIDAMOS SI SE GUARDARA UNA EDICION O 
            /* UN INGRESO DE NUEVO REGISTRO 
            /****************************************/

            if (Session["Codigo"] == null & Session["Est"] == null)
            {
                NroSolicitud = "";
                Proceso = "";
            }
            else
            {
                NroSolicitud = Session["Codigo"].ToString();
                Proceso = Session["Est"].ToString();
            }


            string script = "Confirm('PROCESO TERMINADO..!!');";

            if ((Proceso != "") & (NroSolicitud != ""))
            {
                ActualizarDatos(0, NroSolicitud);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje: Fissal", script, true);
                btnGuardar.Enabled = false;
                btnGuardarEnviar.Enabled = false;
                Session["Codigo"] = null;
                Session["Est"] = null;
            }
            else
            {
                GrabaDatos(0);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje: Fissal", script, true);
                btnGuardar.Enabled = false;
                btnGuardarEnviar.Enabled = false;
                LimpiaControles();

                if (Session["EstablecimientoId"] == "0")
                {
                    FuncionesBasesWeb.CargarComboEstablecimiento(ddlFiltroEstablecimiento);
                }
                else
                {
                    ddlFiltroEstablecimiento.SelectedValue = Session["EstablecimientoId"].ToString(); 
                }

                
                SeteaControles(1);
                txtPaciente.Text = String.Empty;
                txtPPacienteId.ReadOnly = true;
                txtPaciente.ReadOnly = true;
                txtPNombres.ReadOnly = true;
                txtPApePaterno.ReadOnly = true;
                txtPApeMaterno.ReadOnly = true;
                SexMas.Enabled = false;
                SexFem.Enabled = false;
                ddlTipoDocumento.Enabled = false;
                txtPNumDocumento.ReadOnly = true;
                txtPFechNac.Enabled = false;
                ddlTipoRegimen.Enabled = false;
                ddlCategoria.Enabled = false;
                ddlEstadio.Enabled = false;
                txtPHistoria.ReadOnly = true;
                ChkListBox.Items.Clear();
            }

        }

        protected void btnGuardarEnviar_Click(object sender, EventArgs e)
        {

            /********************************************/
            /* VALIDAMOS SI SE GUARDARA UNA EDICION O 
            /* UN INGRESO DE NUEVO REGISTRO 
            /****************************************/

            //if (Session["Codigo"] == null & Session["Est"] == null)
            //{
            //    NroSolicitud = "";
            //    Proceso = "";
            //}
            //else
            //{
            //    NroSolicitud = Session["Codigo"].ToString();
            //    Proceso = Session["Est"].ToString();
            //}
            
            string script = "Confirm('PROCESO TERMINADO..!!');";

            //if ((Proceso != "") & (NroSolicitud != ""))
            //{
            //    ActualizarDatos(1,NroSolicitud);
            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje: Fissal", script, true);
            //    btnGuardar.Enabled = false;
            //    btnGuardarEnviar.Enabled = false;
            //    Session["Codigo"] = null;
            //    Session["Est"] = null;
            //}
            //else
            //{
                GrabaDatos(1);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje: Fissal", script, true);
                btnGuardar.Enabled = false;
                btnGuardarEnviar.Enabled = false;
                LimpiaControles();
                if (Session["EstablecimientoId"].ToString().Equals("0"))
                {
                    FuncionesBasesWeb.CargarComboEstablecimiento(ddlFiltroEstablecimiento);
                }
                else
                {
                    ddlFiltroEstablecimiento.SelectedValue = Session["EstablecimientoId"].ToString();
                }
                SeteaControles(1);
                txtPaciente.Text = String.Empty;
                txtPPacienteId.ReadOnly = true;
                txtPaciente.ReadOnly = true;
                txtPNombres.ReadOnly = true;
                txtPApePaterno.ReadOnly = true;
                txtPApeMaterno.ReadOnly = true;
                SexMas.Enabled = false;
                SexFem.Enabled = false;
                ddlTipoDocumento.Enabled = false;
                txtPNumDocumento.ReadOnly = true;
                txtPFechNac.Enabled = false;
                ddlTipoRegimen.Enabled = false;
                ddlCategoria.Enabled = false;
                ddlEstadio.Enabled = false;
                txtPHistoria.ReadOnly = true;
                ChkListBox.Items.Clear();
            //}

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            frmValidacion3.Visible = false;

            #region 'LIMPIAMOS RESULTADOS'

            dgvListaTratamientosAprob.DataSourceID = null;
            dgvListaTratamientosAprob.DataSource = null;
            dgvListaTratamientosAprob.DataBind();

            dgvListaTratamientosObserv.DataSourceID = null;
            dgvListaTratamientosObserv.DataSource = null;
            dgvListaTratamientosObserv.DataBind();

            dgvListaTratamientosExistentes.DataSourceID = null;
            dgvListaTratamientosExistentes.DataSource = null;
            dgvListaTratamientosExistentes.DataBind();

            #endregion
            btnGuardar.Enabled = true;
            btnGuardarEnviar.Enabled = true;
            LimpiaControles();
            if (Session["EstablecimientoId"].Equals(0))
            {
                FuncionesBasesWeb.CargarComboEstablecimiento(ddlFiltroEstablecimiento);
                ddlFiltroEstablecimiento.Enabled = true;
            }
            else
            {
                ddlFiltroEstablecimiento.SelectedValue = Session["EstablecimientoId"].ToString();
                ddlFiltroEstablecimiento.Enabled = false;
            }
            SeteaControles(2);
            ddlDni.Enabled = true;
            ddlDni.SelectedValue = "0";
        }

        protected void btnChkBoxList_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Session["Codigo"] = null;
            Session["Est"] = null;

            Response.Redirect("~/Solicitudes/FrmMantSolicitud.aspx");
        }

        protected void btnListaAutorizaciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Solicitudes/FrmMantSolicitud.aspx");
        }

        #endregion

        #region Eventos Grilla

        protected void ImgDelete_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void gvListaSolicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                GridViewRow row = (GridViewRow)(e.CommandSource as ImageButton).Parent.Parent;

                string Nro_Solicitud = row.Cells[0].Text.Trim();    // Obtengo Nro Solicitud
                string Paciente = row.Cells[2].Text.Trim();    // Obtengo Paciente - Dni
                string APaterno = row.Cells[3].Text.Trim();    // Obtengo A.Paterno
                string AMaterno = row.Cells[4].Text.Trim();    // Obtengo A.Materno
                string Nombres = row.Cells[5].Text.Trim();    // Obtengo Nombres

                Response.Redirect("./FrmMantSolicitud.aspx?Nro_Solicitud=" + Nro_Solicitud + "&Paciente=" + Paciente + "&APaterno=" + APaterno + "&AMaterno=" + AMaterno + "&Nombres=" + Nombres);
            }
            else
            {

                if (e.CommandName == "Eliminar")
                {
                    Response.Redirect("/Home/Home.aspx");

                }

            }
        }

        protected void gvListaSolicitudes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //gvListaSolicitudes.PageIndex = e.NewPageIndex;
            //CargaSolicitudes();
        }

        protected void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        protected void imgPaciente_Click(object sender, ImageClickEventArgs e)
        {
            string TipoDocumento;


            if (ddlDni.SelectedValue == "1")       // Dni
            {
                TipoDocumento = "1";
                ConsultarAsegurado(txtPaciente.Text.Trim(), TipoDocumento); //Enviar Parametros
            }
            else if (ddlDni.SelectedValue == "2")  // C.I.
            {
                TipoDocumento = "3";  // Cambiamos a [3] para el SIS
                ConsultarAsegurado(txtPaciente.Text.Trim(), TipoDocumento); //Enviar Parametros
            }
            else if (ddlDni.SelectedValue == "3")  // Historia Clinica
            {
                TipoDocumento = "3";
                ConsultarAseguradoxHistoriaClinica(txtPaciente.Text.Trim(), TipoDocumento, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            }

            
        }   
        
        #endregion

        #region Eventos Formularios

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChkListBox.Items.Clear();
            FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, ddlCategoria.SelectedValue, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));            
            //if (ddlCategoria.SelectedValue == String.Empty)
            //{
            //    ChkListBox.Items.Clear();
            //}
           // else { ChkListBox.Items.Clear(); }

        }

        protected void ddlEstadio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChkListBox.Items.Clear();
            if (ddlEstadio.SelectedValue != String.Empty) FuncionesBasesWeb.CargarListaFase(ChkListBox, ddlCategoria.SelectedValue, Convert.ToInt32(ddlEstadio.SelectedValue.ToString()), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue)); 

            //if (ddlEstadio.SelectedValue == String.Empty)
            //{
            //    ChkListBox.Items.Clear();
            //}
            //else { FuncionesBasesWeb.CargarListaFase(ChkListBox, ddlCategoria.SelectedValue, Convert.ToInt32(ddlEstadio.SelectedValue.ToString()), Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue)); }
        }

        protected void ddlFiltroEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

            FuncionesBasesWeb.CargarComboCategoria(ddlCategoria, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, ddlCategoria.SelectedValue, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));

            if (ddlCategoria.SelectedValue == String.Empty)
            {
                ChkListBox.Items.Clear();
            }
            else { ChkListBox.Items.Clear(); }


            if (ddlFiltroEstablecimiento.SelectedValue != "0")
            {
                txtPaciente.Enabled = true;   

                txtPaciente.ReadOnly = false;
                ddlDni.Enabled = true;
            }
            else
            {             

                txtPaciente.Text = String.Empty;
                txtPaciente.ReadOnly = true;
                txtPPacienteId.ReadOnly = true;
                LimpiaControles();
                SeteaControles(2);
                ddlCategoria.Enabled = false;
                ddlEstadio.Enabled = false;
                ddlTipoRegimen.Enabled = false;
                ddlTipoDocumento.Enabled = false;

                ddlDni.Enabled = false;

            }

        }

        #endregion 

        protected void ddlDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPaciente.Text = String.Empty;
            chkSIS.Checked = false;
            chkFISSAL.Checked = false;
            
            txtPPacienteId.Text = String.Empty;
            txtPNombres.Text = String.Empty;
            txtPApePaterno.Text = String.Empty;
            txtPApeMaterno.Text = String.Empty;
            ddlTipoDocumento.SelectedValue=ddlDni.SelectedValue;
            txtPNumDocumento.Text = txtPaciente.Text;
            txtPFechNac.Text = String.Empty;
            txtPHistoria.Text = String.Empty;
            txtPFechNac.Text = String.Empty;
            FuncionesBasesWeb.CargarComboTipoRegimen(ddlTipoRegimen); 

            FuncionesBasesWeb.CargarComboCategoria(ddlCategoria, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            if (ddlCategoria.SelectedValue != String.Empty)
            {
                FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, ddlCategoria.SelectedValue, Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            }
            else
            {
                FuncionesBasesWeb.CargarComboEstadio(ddlEstadio, "0", Convert.ToInt32(ddlFiltroEstablecimiento.SelectedValue));
            }

            ChkListBox.Items.Clear();


            if (ddlDni.SelectedValue != "0")
            {                
                txtPaciente.ReadOnly = false;
            }
            else
            {                
                txtPaciente.ReadOnly = true;
            }
        }
                
                        
    }

}





