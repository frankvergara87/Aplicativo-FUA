using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FissalBL;
using FissalWinForm.ServiceReference1;
using FissalBE;

namespace FissalWinForm
{
    public partial class FrmPreautorizaciones : Form
    {
        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        TratamientoBL objTratamientoBL = new TratamientoBL();
        PacienteBL objPacienteBL = new PacienteBL();
        DataTable dtPreAutorizaciones;
        DataView dvPreAutorizaciones;

        public FrmPreautorizaciones()
        {
            InitializeComponent();
            CargarConfiguracionInicial();
        }

        #region 'CONFIGURACION'

        private void CargarConfiguracionInicial()
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.AutoValidate = AutoValidate.Disable;
            toolStrip1.TabStop = true;
            tsPgsBarBuscador.Visible = false;
            dgvPreAutorizaciones.AutoGenerateColumns = false;
        }

        #endregion

        private void FrmPreautorizaciones_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboEstablecimientoConConvenio(cboEstablecimiento);
            CargarDgvPreAutorizaciones();
        }

        private void CargarDgvPreAutorizaciones()
        {
            dtPreAutorizaciones = objAutorizacionBL.GetAllPreAutorizacion();
            dvPreAutorizaciones = dtPreAutorizaciones.DefaultView;
            dgvPreAutorizaciones.DataSource = dvPreAutorizaciones;
        }

        private void dgvPreAutorizaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvPreAutorizaciones, tsslTotalRegistros);
        }

        private void cboEstablecimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            dvPreAutorizaciones.RowFilter = string.Empty;
            string establecimientoId = Convert.ToString(cboEstablecimiento.SelectedValue);
            if(!string.Equals(establecimientoId, string.Empty))
                dvPreAutorizaciones.RowFilter = string.Format("EstablecimientoId = {0}",establecimientoId);
        }

        private void tsBtnConsultaReniec_Click(object sender, EventArgs e)
        {
            ConsultarReniec();
        }

        private void ConsultarReniec()
        {
            if (!(dgvPreAutorizaciones.RowCount > 0))
                return;
            int? establecimientoId;
            if (cboEstablecimiento.SelectedIndex != 0 && cboEstablecimiento.SelectedIndex != -1)
                establecimientoId=Convert.ToInt32(cboEstablecimiento.SelectedValue);
            else
                establecimientoId=null;
            if (objAutorizacionBL.ExistenPendientesPacienteVivo(establecimientoId))
            {
                int result;
                if (cboEstablecimiento.SelectedIndex != 0 && cboEstablecimiento.SelectedIndex != -1)
                    result = objAutorizacionBL.ActualizarPacienteVivoPreAutorizacionesPorEstablecimiento(VariablesGlobales.Login, Convert.ToInt32(cboEstablecimiento.SelectedValue));
                else
                    result = objAutorizacionBL.ActualizarPacienteVivoPreAutorizaciones(VariablesGlobales.Login);
                //if (result > 0)
                //{
                //    MessageBox.Show("Actualizacion Reniec Finalizada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    CargarDgvPreAutorizaciones();
                //    Buscar();
                //}
                MessageBox.Show("Actualizacion Reniec Finalizada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDgvPreAutorizaciones();
                Buscar();
            }
            else
                MessageBox.Show("No hay pacientes con consulta RENIEC pendiente", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConsultarFissal()
        {
            if (!(dgvPreAutorizaciones.RowCount > 0))
                return;
            int length = dgvPreAutorizaciones.RowCount;
            DataGridViewRow row;
            string pacienteActivoSis;
            string pacienteRegimenSis;
            string pacienteVivo;
            string pacienteSinAutorizacionPrevia;
            string pacienteTodosRetrospectivos;
            string pacienteTodosDiferenteFase;
            string observacionesAutorizacionDefinitiva;
            string pacienteId;
            string categoriaId;
            int faseId;
            bool diagnosticoEsOncologico;
            bool diagnosticoEsIrc;
            int autorizacionId;
            decimal? monto;
            int tratamientoId;
            int version;
            string modalidad;
            string numeroSolicitud;
            int detalleId;
            string usuarioActivoSistema = VariablesGlobales.Login;
            bool seAutoriza;
            //
            tsslTotalRegistros.Visible = false;
            tsPgsBarBuscador.Minimum = 0;
            tsPgsBarBuscador.Maximum = length;
            tsslMensajePgsBarBuscador.Visible = true;
            tsslMensajePgsBarBuscador.Text = "Procesando...";
            tsPgsBarBuscador.Visible = true;
            //
            for (int i = 0; i < length; i++)
            {
                row = dgvPreAutorizaciones.Rows[i];
                pacienteActivoSis = row.Cells["PacienteActivoSis"].Value.ToString();
                pacienteRegimenSis = row.Cells["PacienteTipoRegimenSis"].Value.ToString();
                pacienteVivo = row.Cells["PacienteVivo"].Value.ToString();
                pacienteSinAutorizacionPrevia = row.Cells["PacienteSinAutorizacionPrevia"].Value.ToString();
                pacienteTodosRetrospectivos = row.Cells["PacienteTodosRetrospectivos"].Value.ToString();
                pacienteTodosDiferenteFase = row.Cells["PacienteTodosDiferenteFase"].Value.ToString();
                observacionesAutorizacionDefinitiva = string.Empty;
                pacienteId = row.Cells["PacienteId"].Value.ToString();
                categoriaId = row.Cells["CategoriaId"].Value.ToString().Substring(0,1);
                faseId = Convert.ToInt32(row.Cells["FaseId"].Value);
                diagnosticoEsOncologico = false;
                diagnosticoEsIrc = false;
                if (string.Equals(categoriaId, "C"))
                {
                    diagnosticoEsOncologico = true;
                }
                else
                {
                    if (string.Equals(categoriaId, "N"))
                        diagnosticoEsIrc = true;
                }
                autorizacionId = Convert.ToInt32(row.Cells["AutorizacionId"].Value);
                monto = null;
                tratamientoId = Convert.ToInt32(row.Cells["TratamiendoId"].Value);
                version = Convert.ToInt32(row.Cells["Version"].Value);
                modalidad = row.Cells["Modalidad"].Value.ToString();
                numeroSolicitud = row.Cells["Nro_SolicitudDetalle"].Value.ToString();
                detalleId = Convert.ToInt32(row.Cells["DetalleId"].Value);
                seAutoriza = false;

                if (!string.Equals(pacienteActivoSis, "3"))//ingresara si ya ha sido procesado sis
                {
                    if (string.Equals(pacienteActivoSis, "0"))//ingresara si es inactivo en el sis
                    {
                        //autorizar modo retrospectivo
                        modalidad = "R";
                        observacionesAutorizacionDefinitiva = "Autorizado con modalidad Retrospectivo por que el paciente esta inactivo en el SIS";
                        seAutoriza = true;
                    }
                    else
                    {
                        if (string.Equals(pacienteActivoSis, "1"))//ingresara si es activo en el sis
                        {
                            if (string.Equals(pacienteRegimenSis, "2"))//ingresara si es NRUS
                            {
                                //autorizar modo retrospectivo
                                modalidad = "R";
                                observacionesAutorizacionDefinitiva = "Autorizado con modalidad Retrospectivo por que el paciente es NRUS";
                                seAutoriza = true;
                            }
                            else
                            {
                                if (string.Equals(pacienteRegimenSis, "1"))//ingresara si es Subsidiado
                                {
                                    #region'ENTRA A VALIDACION RENIEC'

                                    if (!string.Equals(pacienteVivo, "3"))//ingresara si ya ha sido procesado reniec
                                    {
                                        if (string.Equals(pacienteVivo, "0"))//ingresara si ha fallecido
                                        {
                                            //autorizar modo retrospectivo
                                            modalidad = "R";
                                            observacionesAutorizacionDefinitiva = "Autorizado con modalidad Retrospectivo por que el paciente esta fallecido";
                                            seAutoriza = true;
                                        }
                                        else
                                        {
                                            if (string.Equals(pacienteVivo, "1"))//ingresara si esta vivo
                                            {
                                                if (diagnosticoEsIrc)
                                                {
                                                    #region 'EVALUACION DE AUTORIZACIONES PREVIAS IRC'

                                                    if (objAutorizacionBL.PacienteTieneAutorizacionesPreviasVigentes(pacienteId, categoriaId))//ingresara si tiene autorizaciones previas vigentes
                                                    {
                                                        if (objAutorizacionBL.PacienteTieneAutorizacionesPreviasProspectivasVigentes(pacienteId, categoriaId))//ingresara si tiene al menos una autorizacion previa propectiva vigente
                                                        {
                                                            //autorizacion manual
                                                            pacienteSinAutorizacionPrevia = "0";
                                                            pacienteTodosRetrospectivos = "0";
                                                            #region 'ACTUALIZANDO EVALUACION FISSAL SOLICITUD AUTORIZACION DETALLE'
                                                            objAutorizacionBL.ActualizarEvaluacionFissalPreAutorizacion(numeroSolicitud, detalleId, pacienteSinAutorizacionPrevia, pacienteTodosRetrospectivos, usuarioActivoSistema);
                                                            #endregion
                                                            seAutoriza = false;
                                                        }
                                                        else //ingresara si todas sus autorizaciones previas vigentes son retrospectivas
                                                        {
                                                            //autorizar modo prospectivo
                                                            modalidad = "P";
                                                            monto = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, version).Monto;
                                                            pacienteSinAutorizacionPrevia = "0";
                                                            pacienteTodosRetrospectivos = "1";
                                                            observacionesAutorizacionDefinitiva = "Autorizado con modalidad Prospectivo por que el paciente esta activo en el SIS, esta vivo y todas sus autorizaciones previas vigentes son retrospectivas";
                                                            seAutoriza = true;
                                                        }
                                                    }
                                                    else //ingresara si no tiene autorizaciones previas vigentes
                                                    {
                                                        //autorizar modo prospectivo
                                                        modalidad = "P";
                                                        monto = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, version).Monto;
                                                        pacienteSinAutorizacionPrevia = "1";
                                                        observacionesAutorizacionDefinitiva = "Autorizado con modalidad Prospectivo por que el paciente esta activo en el SIS, esta vivo y no tiene autorizaciones previas vigentes";
                                                        seAutoriza = true;
                                                    }

                                                    #endregion
                                                }
                                                else
                                                {
                                                    if (diagnosticoEsOncologico)
                                                    {
                                                        #region 'EVALUACION DE AUTORIZACIONES PREVIAS ONCOLOGICAS'

                                                        if (objAutorizacionBL.PacienteTieneAutorizacionesPrevias(pacienteId, categoriaId))//ingresara si tiene autorizaciones previas
                                                        {
                                                            if (objAutorizacionBL.PacienteTieneAutorizacionesPreviasProspectivas(pacienteId, categoriaId))//ingresara si tiene al menos una autorizacion previa propectiva
                                                            {
                                                                if (objAutorizacionBL.PacienteTieneAutorizacionesPreviasMismaFase(pacienteId, categoriaId, faseId))//ingresara si tiene al menos una autorizacion previa con la misma fase
                                                                {
                                                                    //autorizar modo retrospectivo
                                                                    modalidad = "R";
                                                                    pacienteSinAutorizacionPrevia = "0";
                                                                    pacienteTodosRetrospectivos = "0";
                                                                    pacienteTodosDiferenteFase = "0";
                                                                    observacionesAutorizacionDefinitiva = "Autorizado con modalidad Retrospectivo por que el paciente esta activo en el SIS, esta vivo,tiene autorizaciones previas prospectivas y tiene autorizaciones previas de la misma fase";
                                                                    seAutoriza = true;
                                                                }
                                                                else//ingresara si todas sus autorizaciones previas son de diferente Fase
                                                                {
                                                                    //autorizar modo prospectivo
                                                                    modalidad = "P";
                                                                    monto = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, version).Monto;
                                                                    pacienteSinAutorizacionPrevia = "0";
                                                                    pacienteTodosRetrospectivos = "0";
                                                                    pacienteTodosDiferenteFase = "1";
                                                                    observacionesAutorizacionDefinitiva = "Autorizado con modalidad Prospectivo por que el paciente esta activo en el SIS, esta vivo,tiene autorizaciones prospectivas y todas sus autorizaciones previas son de diferente fase";
                                                                    seAutoriza = true;

                                                                }
                                                            }
                                                            else //ingresara si todas sus autorizaciones previas son retrospectivas
                                                            {
                                                                //autorizar modo prospectivo
                                                                modalidad = "P";
                                                                monto = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, version).Monto;
                                                                pacienteSinAutorizacionPrevia = "0";
                                                                pacienteTodosRetrospectivos = "1";
                                                                observacionesAutorizacionDefinitiva = "Autorizado con modalidad Prospectivo por que el paciente esta activo en el SIS, esta vivo y todas sus autorizaciones previas son retrospectivas";
                                                                seAutoriza = true;
                                                            }
                                                        }
                                                        else //ingresara si no tiene autorizaciones previas
                                                        {
                                                            //autorizar modo prospectivo
                                                            modalidad = "P";
                                                            monto = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, version).Monto;
                                                            pacienteSinAutorizacionPrevia = "1";
                                                            observacionesAutorizacionDefinitiva = "Autorizado con modalidad Prospectivo por que el paciente esta activo en el SIS, esta vivo y no tiene autorizaciones previas";
                                                            seAutoriza = true;
                                                        }

                                                        #endregion
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    #endregion
                                }
                            }
                            
                            
                        }
                    }
                }
                else
                {
                    if (!string.Equals(pacienteVivo, "3"))//ingresara si ya ha sido procesado reniec
                    {
                        if (string.Equals(pacienteVivo, "0"))//ingresara si ha fallecido
                        {
                            //autorizar modo retrospectivo
                            modalidad = "R";
                            observacionesAutorizacionDefinitiva = "Autorizado con modalidad Retrospectivo por que el paciente esta fallecido";
                            seAutoriza = true;
                        }
                    }
                }
                if (seAutoriza)
                {
                    #region 'ACTUALIZANDO AUTORIZACION'
                    objAutorizacionBL.ActualizarModalidadAutorizacion(modalidad, monto, autorizacionId);
                    #endregion

                    #region 'ACTUALIZANDO PRE AUTORIZACION SOLICITUD AUTORIZACION DETALLE'
                    objAutorizacionBL.ActualizarPreAutorizacion(usuarioActivoSistema, numeroSolicitud, pacienteSinAutorizacionPrevia, pacienteTodosRetrospectivos, pacienteTodosDiferenteFase,observacionesAutorizacionDefinitiva, detalleId);
                    #endregion
                }
                tsPgsBarBuscador.Value = i;
                tsslMensajePgsBarBuscador.Text = string.Format("Procesando {0} de {1}", Convert.ToString(i + 1), length.ToString());
            }
            tsPgsBarBuscador.Visible = false;
            tsPgsBarBuscador.Value = tsPgsBarBuscador.Minimum;
            tsslMensajePgsBarBuscador.Visible = false;
            tsslMensajePgsBarBuscador.Text = string.Empty;
            tsslTotalRegistros.Visible = true;
            CargarDgvPreAutorizaciones();
            Buscar();
            MessageBox.Show("Proceso de Autorizacion Finalizado", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsBtnConsultarSis_Click(object sender, EventArgs e)
        {
            ConsultarSis();
        }

        private void ConsultarSis()
        {
            if (!(dgvPreAutorizaciones.RowCount > 0))
                return;
            int? establecimientoId;
            if (cboEstablecimiento.SelectedIndex != 0 && cboEstablecimiento.SelectedIndex != -1)
                establecimientoId=Convert.ToInt32(cboEstablecimiento.SelectedValue);
            else
                establecimientoId=null;
            if (objAutorizacionBL.ExistenPendientesPacienteActivoSis(establecimientoId))
            {
                CredencialWS Clave = new CredencialWS();
                siswsSoapClient ws = new siswsSoapClient();
                string Trama = string.Empty;
                string[] Campos;
                string FechaVigencia;
                string Componente;
                byte? tipoRegimen;
                string activoSis = string.Empty;
                /***********************CREDENCIALES WS.*/
                Clave.Usuario = "fissal";
                Clave.Clave = "uhy2c32zlk";

                /***********************/
                /*************CONSULTAMOS DATA SIS - WS**/
                List<string> listaPacientes;
                if (cboEstablecimiento.SelectedIndex != 0 && cboEstablecimiento.SelectedIndex != -1)
                    listaPacientes = objAutorizacionBL.GetPacienteIdActivoSisPendientePorEstablecimiento(Convert.ToInt32(cboEstablecimiento.SelectedValue));
                else
                    listaPacientes = objAutorizacionBL.GetAllPacienteIdActivoSisPendiente();

                int filasPacientes = listaPacientes.Count;
                string pacienteId;
                tsPgsBarBuscador.Minimum = 0;
                tsPgsBarBuscador.Maximum = filasPacientes;
                tsslTotalRegistros.Visible = false;
                tsslMensajePgsBarBuscador.Text = "Procesando...";
                tsslMensajePgsBarBuscador.Visible = true;
                tsPgsBarBuscador.Visible = true;

                for (int i = 0; i < filasPacientes; i++)
                {
                    Trama = string.Empty;
                    pacienteId = listaPacientes[i];

                    Paciente ObjPaciente = objPacienteBL.GetPacientePorId(pacienteId);
                    /****************************************************************/
                    if (ObjPaciente.TipoDocumentoId == 1)
                    {
                        Trama = ws.BuscarAseguradosDocIdent(Clave, "00006210", "1", ObjPaciente.NumeroDocumento);

                        if (!string.Equals(Trama, string.Empty))
                        {
                            Campos = Trama.Split('|');
                            FechaVigencia = Campos[16];
                            Componente = Campos[13];
                            /****** AGREGAR VALIDACION VIGENCIA *******************/
                            if (Componente == "1") // SUBSIDIADO = ACTIVO
                            {
                                activoSis = "1";
                            }
                            else if (Componente == "2") // NRUSS
                            {
                                if (!string.Equals(FechaVigencia, string.Empty))
                                {
                                    string FVigencia = FechaVigencia.ToString();
                                    string Eval = FVigencia.Substring(6, 2) + '/' + FVigencia.Substring(4, 2) + '/' + FVigencia.Substring(0, 4);
                                    DateTime FEval = Convert.ToDateTime(Eval);
                                    DateTime FHoy = DatosBL.GetDate();
                                    if (FEval.Date >= FHoy.Date)
                                        activoSis = "1";
                                    else
                                        activoSis = "0";
                                }
                                else
                                    activoSis = "1";
                            }
                            /******************************************************/
                            tipoRegimen = Convert.ToByte(Componente);
                        }
                        else
                        {
                            activoSis = "0";
                            tipoRegimen = null;
                        }

                        if (cboEstablecimiento.SelectedIndex != 0 && cboEstablecimiento.SelectedIndex != -1)
                            objAutorizacionBL.ActualizarActivoSisPreAutorizacionesPorEstablecimiento(pacienteId, activoSis, tipoRegimen, VariablesGlobales.Login, Convert.ToInt32(cboEstablecimiento.SelectedValue));
                        else
                            objAutorizacionBL.ActualizarActivoSisPreAutorizaciones(pacienteId, activoSis, tipoRegimen, VariablesGlobales.Login);
                    }
                    
                    /****************************************************************/

                    tsPgsBarBuscador.Value = i;
                    tsslMensajePgsBarBuscador.Text = string.Format("Procesando {0} de {1}", Convert.ToString(i + 1), filasPacientes.ToString());
                }
                tsslMensajePgsBarBuscador.Visible = false;
                tsslMensajePgsBarBuscador.Text = string.Empty;
                tsPgsBarBuscador.Visible = false;
                tsslTotalRegistros.Visible = true;
                tsPgsBarBuscador.Value = tsPgsBarBuscador.Minimum;
                CargarDgvPreAutorizaciones();
                Buscar();
                MessageBox.Show("Consulta SIS Concluida", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No hay pacientes con consulta SIS pendiente", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsBtnObtenerModalidad_Click(object sender, EventArgs e)
        {
            ConsultarFissal();
        }

        private void dgvPreAutorizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarPreAutorizacion();
        }

        private void EnviarPreAutorizacion()
        {
            if(!(dgvPreAutorizaciones.RowCount>0))
                return;
            DataGridViewRow row = dgvPreAutorizaciones.CurrentRow;
            int autorizacionId = Convert.ToInt32(row.Cells["AutorizacionId"].Value);
            string numeroSolicitud = row.Cells["Nro_SolicitudDetalle"].Value.ToString();
            int detalleId = Convert.ToInt32(row.Cells["DetalleId"].Value);
            string pacienteActivoSis = row.Cells["PacienteActivoSis"].Value.ToString();
            string pacienteRegimenSis = row.Cells["PacienteTipoRegimenSis"].Value.ToString();
            string pacienteVivo = row.Cells["PacienteVivo"].Value.ToString();
            string pacienteId = row.Cells["PacienteId"].Value.ToString();
            string categoriaId = row.Cells["CategoriaId"].Value.ToString().Substring(0,1);
            FrmPreAutorizacion objFrmPreAutorizacion = new FrmPreAutorizacion(autorizacionId,numeroSolicitud,detalleId,pacienteActivoSis,pacienteRegimenSis,pacienteVivo,pacienteId,categoriaId);
            objFrmPreAutorizacion.ShowDialog();
        }
    }

}