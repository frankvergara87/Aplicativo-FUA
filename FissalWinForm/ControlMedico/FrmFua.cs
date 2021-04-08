using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FissalBE;
using FissalBL;

namespace FissalWinForm
{
    public partial class FrmFua : Form, IFrmRegistrarObservacion
    {
        #region 'VARIABLES Y CONSTANTES'

        private ControlMedicoLogBL objControlMedicoLogBL = new ControlMedicoLogBL();
        private MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        private MovimientoPacienteDetalleBL objMovimientoPacienteDetalleBL = new MovimientoPacienteDetalleBL();
        private MovimientoProcedimientoBL objMovimientoProcedimientoBL = new MovimientoProcedimientoBL();
        private MovimientoMedicamentoBL objMovimientoMedicamentoBL = new MovimientoMedicamentoBL();
        private vw2_MovimientoPaciente_Listar objvw_MovimientoPacienteFull;
        private List<vw_MovimientoPacienteDetalle> listaDiagnosticos;
        private List<vw_MovimientoPacienteProcedimiento> listaProcedimientos;
        private List<vw_movimientoPacienteMedicamento> listaMedicamentos;
        private ObservacionControlMedico objObservacionControlMedico;
        private Int64[] listaIdAtenciones;
        private int indiceActualListaIdAtenciones;
        private Int64 fua;
        private StringBuilder mensajeAvisos = new StringBuilder();
        private int diasPermitidosEntreRegistroAtencion = 45;
        private int diasEntreRegistroAtencion;
        bool sePuedeEditar = true;

        #region 'TIPO CONTROL MEDICO'

        private int idTipoEventoCMPreliminar = 1;
        private int idTipoEventoCMSeleccionadoPcpp = 2;
        private int idTipoEventoCMPcpp = 3;
        private int idTipoEventoCMSeleccionadoReconsideracion = 4;
        private int idTipoEventoCMReconsideracion = 5;

        #endregion

        #region 'CATEGORIA OBSERVACION'

        private int categoriaSinCategoria = 0;
        private int categoriaCabecera = 1;
        private int categoriaDiagnosticos = 2;
        private int categoriaProcedimientos = 3;
        private int categoriaMedicamentos = 4;

        #endregion

        #region 'TIPO OBSERVACION'

        private int tipoObservacionSinObservacion = 0;
        private int tipoObservacionFechaRegistro = 1;
        private int tipoObservacionResponsable = 2;
        private int tipoObservacionFechaRegistroResponsable = 3;

        #endregion

        #endregion

        #region 'CONSTRUCTORES'

        public FrmFua()
        {
            InitializeComponent();
            dgvSupervisiones.AutoGenerateColumns = false;
            dgvDiagnosticos.AutoGenerateColumns = false;
            dgvProcedimientos.AutoGenerateColumns = false;
            dgvMedicamentos.AutoGenerateColumns = false;
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            FuncionesBases.QuitarControlesTabulacion(this,false);
            FuncionesBases.QuitarControlesTabulacion(grpObservacionAtencion, true);
            FuncionesBases.QuitarControlesTabulacion(grpDiagnosticos, true);
            FuncionesBases.QuitarControlesTabulacion(tabCtlConsumos, true);
            toolStrip1.TabStop = Convert.ToBoolean(bool.TrueString);
            FuncionesBases.QuitarControlesTabulacion(toolStrip1, true);
        }

        public FrmFua(Int64[] listaIdAtenciones, int indiceActualListaIdAtenciones) : this()
        {
            this.listaIdAtenciones = listaIdAtenciones;
            this.indiceActualListaIdAtenciones = indiceActualListaIdAtenciones;
        }

        #endregion

        #region 'CONFIGURACION'

        private void CargarConfiguracion()
        {
            cboTipoObservacionAtencion.Enabled = true;
            tsBtnGuardar.Enabled = true;
            this.Text = string.Format("FISSAL - Supervision de Atenciones - FORMATO UNICO DE ATENCION: {0}", objvw_MovimientoPacienteFull.Descripcion);
            tsLblPaginacion.Text = string.Format("{0} DE {1}", indiceActualListaIdAtenciones+1, listaIdAtenciones.Length);
            if (LaFechaRegistroEstaFueraRango())
            {
                mensajeAvisos.AppendFormat("- Registrado {1} días despues de la fecha de atención.{0}", Environment.NewLine, diasEntreRegistroAtencion);
                txtAvisos.Text = mensajeAvisos.ToString();
            }
            if (Convert.ToBoolean(objvw_MovimientoPacienteFull.CM))
            {
                if (sePuedeEditar)
                {
                    if (Convert.ToBoolean(objvw_MovimientoPacienteFull.CMObs))
                        tsBtnSeleccionarPcpp.Enabled = false;
                    else
                        if (!Convert.ToBoolean(objvw_MovimientoPacienteFull.CMPcpp))
                            tsBtnSeleccionarPcpp.Enabled = true;
                        else
                            tsBtnSeleccionarPcpp.Enabled = false;
                }
                else
                {
                    mensajeAvisos.AppendFormat("- Ya no se puede editar, Control Medico Finalizado.{0}", Environment.NewLine);
                    txtAvisos.Text = mensajeAvisos.ToString();
                    cboTipoObservacionAtencion.Enabled = false;
                    tsBtnSeleccionarPcpp.Enabled = false;
                    tsBtnGuardar.Enabled = false;
                }
            }
            else
            {
                tsBtnSeleccionarPcpp.Enabled = false;
                if (!sePuedeEditar)
                {
                    mensajeAvisos.AppendFormat("- Ya no se puede editar, Control Medico Finalizado.{0}", Environment.NewLine);
                    txtAvisos.Text = mensajeAvisos.ToString();
                    cboTipoObservacionAtencion.Enabled = false;
                    tsBtnSeleccionarPcpp.Enabled = false;
                    tsBtnGuardar.Enabled = false;
                }
            }
            dgvProcedimientos.Focus();
        }

        #endregion
        
        #region 'CARGA DATOS'

        private void CargarCbosTipoObservacion()
        {
            TipoObservacionBL objTipoObservacionBL = new TipoObservacionBL();
            DataTable dtTiposObservacion = objTipoObservacionBL.GetALLTiposObservacion();
            DataGridViewComboBoxColumn cboTipoObservacionDiagnostico = dgvDiagnosticos.Columns["cmb_TipoObservacionDiagnostico"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn cboTipoObservacionProcedimiento = dgvProcedimientos.Columns["cmb_TipoObservacionProcedimiento"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn cboTipoObservacionMedicamento = dgvMedicamentos.Columns["cmb_TipoObservacionMedicamento"] as DataGridViewComboBoxColumn;
            CargarCboTipoObservacion(cboTipoObservacionDiagnostico, dtTiposObservacion);
            CargarCboTipoObservacion(cboTipoObservacionProcedimiento, dtTiposObservacion);
            CargarCboTipoObservacion(cboTipoObservacionMedicamento, dtTiposObservacion);
            FuncionesBases.CargarCboTipoObservacionAtencion(cboTipoObservacionAtencion);
        }

        private void CargarCboTipoObservacion(DataGridViewComboBoxColumn cbo, DataTable dt)
        {
            cbo.DataSource = dt;
            cbo.ValueMember = "TipoObservacionId";
            cbo.DisplayMember = "Descripcion";
        }

        private void CargarDatosAtencion()
        {
            objvw_MovimientoPacienteFull = objMovimientoPacienteBL.GetVwMovimientoPacienteFullPorFua(fua);
            if (objvw_MovimientoPacienteFull != null)
            {
                #region 'CARGAR DATOS ATENCION'

                txtEstablecimiento.Text = objvw_MovimientoPacienteFull.EstablecimientoId.ToString();
                txtAnno.Text = objvw_MovimientoPacienteFull.anno;
                txtCorrelativo.Text = objvw_MovimientoPacienteFull.correlativo;
                txtFechaAtencion.Text = objvw_MovimientoPacienteFull.FechaAtencion.ToString();
                txtTipoIngreso.Text = objvw_MovimientoPacienteFull.TipoIngresoDescripcion;
                txtFechaRegistro.Text = objvw_MovimientoPacienteFull.FechaRegistro.ToString();
                if (Convert.ToBoolean(objvw_MovimientoPacienteFull.CMErrorFechaAtencion) && Convert.ToBoolean(objvw_MovimientoPacienteFull.CMErrorResponsableAtencion))
                    cboTipoObservacionAtencion.SelectedValue = tipoObservacionFechaRegistroResponsable;
                if (Convert.ToBoolean(objvw_MovimientoPacienteFull.CMErrorFechaAtencion) && !Convert.ToBoolean(objvw_MovimientoPacienteFull.CMErrorResponsableAtencion))
                    cboTipoObservacionAtencion.SelectedValue = tipoObservacionFechaRegistro;
                if (!Convert.ToBoolean(objvw_MovimientoPacienteFull.CMErrorFechaAtencion) && Convert.ToBoolean(objvw_MovimientoPacienteFull.CMErrorResponsableAtencion))
                    cboTipoObservacionAtencion.SelectedValue = tipoObservacionResponsable;
                txtLugarAtencion.Text = objvw_MovimientoPacienteFull.LugarAtencionDescripcion;
                txtTipoPrestacion.Text = objvw_MovimientoPacienteFull.TipoPrestacionDescripcion;
                txtPersonalAtencion.Text = objvw_MovimientoPacienteFull.PersonalAtiendeDescripcion;
                txtHistoriaClinicaPaciente.Text = objvw_MovimientoPacienteFull.NumeroHistoria;
                txtNombresPaciente.Text = objvw_MovimientoPacienteFull.DescripcionPaciente;
                txtDniPaciente.Text = objvw_MovimientoPacienteFull.PacienteId;
                txtSexoPaciente.Text = objvw_MovimientoPacienteFull.DescSexo;
                if (Convert.ToBoolean(objvw_MovimientoPacienteFull.Estado))
                    txtEstadoPaciente.Text = "Activo";
                else
                    txtEstadoPaciente.Text = "Inactivo";
                //txtNumeroCuentaPaciente.Text = _ovw_MovimientoPacienteFull
                txtFechaNacimientoPaciente.Text = objvw_MovimientoPacienteFull.Nacimiento.ToString();
                txtFechaDefuncionPaciente.Text = objvw_MovimientoPacienteFull.fecha_defuncion.ToString();
                txtRegimenAfiliacion.Text = objvw_MovimientoPacienteFull.TipoRegimenDesc;
                //txtNumeroAfiliacion.Text = objvw_MovimientoPacienteFull
                txtInstitucionOtroSeguro.Text = objvw_MovimientoPacienteFull.InstitucionDescripcion;
                txtCodigoOtroSeguro.Text = objvw_MovimientoPacienteFull.NumeroSeguro;
                txtNombreResponsable.Text = objvw_MovimientoPacienteFull.NombreDoctor;
                txtDniResponsable.Text = objvw_MovimientoPacienteFull.DNIResponsable;
                txtCmpResponsable.Text = objvw_MovimientoPacienteFull.Cmp;
                txtResponsable.Text = objvw_MovimientoPacienteFull.DescResponsableAtencion;
                txtEspecialidadResponsable.Text = objvw_MovimientoPacienteFull.Especialidad;
                txtEstablecimientoReferencia.Text = objvw_MovimientoPacienteFull.DescEstabRefiere;
                txtNumeroHojaReferencia.Text = objvw_MovimientoPacienteFull.NumeroHojaRefiere;
                txtFechaIngresoPaciente.Text = objvw_MovimientoPacienteFull.FechaIngreso.ToString();
                txtFechaAltaPaciente.Text = objvw_MovimientoPacienteFull.FechaAlta.ToString();
                txtEstablecimientoDestino.Text = objvw_MovimientoPacienteFull.DescEstabContRefiere;
                txtDestinoAsegurado.Text = objvw_MovimientoPacienteFull.DestinoAseguradoDescripcion;
                txtNumeroHojaContra.Text = objvw_MovimientoPacienteFull.NumeroHojaContraRefiere;
                txtCostoProcedimientos.Text = objvw_MovimientoPacienteFull.MontoProcedimiento.ToString();
                txtCostoMedicamentos.Text = objvw_MovimientoPacienteFull.MontoMedicamento.ToString();
                txtCostoAtencion.Text = objvw_MovimientoPacienteFull.MontoFua.ToString();

                #endregion
                CargarDatosDgvDiagnosticos();
                CargarDatosDgvProcedimientos();
                CargarDatosDgvMedicamentos();
                CargarDatosDgvSupervisiones();
            }
            else
            {
                MessageBox.Show("No se pudo cargar atencion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salir();
            }
        }

        private void CargarDatosDgvDiagnosticos()
        {
            listaDiagnosticos = objMovimientoPacienteDetalleBL.GetVwMovimientoPacienteDetallePorFua(objvw_MovimientoPacienteFull.Fua);
            dgvDiagnosticos.DataSource = listaDiagnosticos;
            if (listaDiagnosticos.Count > 0)
            {
                dgvDiagnosticos.Visible = true;
                CargarSeleccionCombosDgvDiagnosticos();
            }
            else
                dgvDiagnosticos.Visible = false;
        }

        private void CargarSeleccionCombosDgvDiagnosticos()
        {
            foreach (DataGridViewRow row in dgvDiagnosticos.Rows)
            {
                DataGridViewComboBoxCell cboTipoObservacion = row.Cells["cmb_TipoObservacionDiagnostico"] as DataGridViewComboBoxCell;
                DataGridViewCell tipoObservacion = row.Cells["TipoObservacionDiagnostico"] as DataGridViewCell;
                if (!string.Equals(Convert.ToString(tipoObservacion.Value), string.Empty))
                    cboTipoObservacion.Value = tipoObservacion.Value;
                else
                {
                    cboTipoObservacion.Value = tipoObservacionSinObservacion;
                    tipoObservacion.Value = tipoObservacionSinObservacion;
                }
            }
        }

        private void CargarDatosDgvProcedimientos()
        {
            listaProcedimientos = objMovimientoProcedimientoBL.GetVwMovimientoPacienteProcedimientoPorFua(objvw_MovimientoPacienteFull.Fua);
            dgvProcedimientos.DataSource = listaProcedimientos;
            if (listaProcedimientos.Count > 0)
            {
                dgvProcedimientos.Visible = true;
                CargarSeleccionCombosDgvProcedimientos();
            }
            else
                dgvProcedimientos.Visible = false;
        }

        private void CargarSeleccionCombosDgvProcedimientos()
        {
            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                DataGridViewComboBoxCell cboTipoObservacionProcedimiento = row.Cells["cmb_TipoObservacionProcedimiento"] as DataGridViewComboBoxCell;
                DataGridViewCell tipoObservacionProcedimiento = row.Cells["TipoObservacionProcedimiento"] as DataGridViewCell;
                if (!string.Equals(Convert.ToString(tipoObservacionProcedimiento.Value), string.Empty))
                    cboTipoObservacionProcedimiento.Value = tipoObservacionProcedimiento.Value;
                else
                {
                    cboTipoObservacionProcedimiento.Value = tipoObservacionSinObservacion;
                    tipoObservacionProcedimiento.Value = tipoObservacionSinObservacion;
                }
            }
        }

        private void CargarDatosDgvMedicamentos()
        {
            listaMedicamentos = objMovimientoMedicamentoBL.GetVwMovimientoPacienteMedicamentoPorFua(objvw_MovimientoPacienteFull.Fua);
            dgvMedicamentos.DataSource = listaMedicamentos;
            if (listaMedicamentos.Count > 0)
            {
                dgvMedicamentos.Visible = true;
                CargarSeleccionCombosDgvMedicamentos();
            }
            else
                dgvMedicamentos.Visible = false;
        }

        private void CargarSeleccionCombosDgvMedicamentos()
        {
            foreach (DataGridViewRow row in dgvMedicamentos.Rows)
            {
                DataGridViewComboBoxCell cboTipoObservacionMedicamento = row.Cells["cmb_TipoObservacionMedicamento"] as DataGridViewComboBoxCell;
                DataGridViewCell tipoObservacionMedicamento = row.Cells["TipoObservacionMedicamento"] as DataGridViewCell;
                if (!string.Equals(Convert.ToString(tipoObservacionMedicamento.Value), string.Empty))
                    cboTipoObservacionMedicamento.Value = tipoObservacionMedicamento.Value;
                else
                {
                    cboTipoObservacionMedicamento.Value = tipoObservacionSinObservacion;
                    tipoObservacionMedicamento.Value = tipoObservacionSinObservacion;
                }
            }
        }

        private void CargarDatosDgvSupervisiones()
        {
            DataTable dtSupervisiones = objControlMedicoLogBL.GetVwControlMedicoLogPorFua(objvw_MovimientoPacienteFull.Fua);
            dgvSupervisiones.DataSource = dtSupervisiones;
            if (dtSupervisiones.Rows.Count > 0)
                dgvSupervisiones.Visible = true;
            else
                dgvSupervisiones.Visible = false;
        }

        #endregion

        #region 'LOGICA DEL PROCESO'

        private void IniciarProceso()
        {
            Limpiar();
            CargarDatosIniciales();
            CargarDatosAtencion();
            CargarConfiguracion();
            this.cboTipoObservacionAtencion.SelectedIndexChanged += new System.EventHandler(this.cboTipoObservacion_SelectedIndexChanged);
            this.dgvDiagnosticos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosticos_CellValueChanged);
            this.dgvProcedimientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellValueChanged);
            this.dgvMedicamentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellValueChanged);
        }

        private void CargarDatosIniciales()
        {
            fua = listaIdAtenciones[indiceActualListaIdAtenciones];
            tabCtlConsumos.SelectedTab = tabPagMedicamentos;
            tabCtlConsumos.SelectedTab = tabPagProcedimientos;
            SePuedeEditar();
        }

        private bool LaFechaRegistroEstaFueraRango()
        {
            bool respuesta = false;
            DateTime fechaRegistro = Convert.ToDateTime(objvw_MovimientoPacienteFull.FechaRegistro);
            DateTime fechaAtencion = Convert.ToDateTime(objvw_MovimientoPacienteFull.FechaAtencion);
            diasEntreRegistroAtencion = FuncionesBases.ObtenerDiasEntreDosFechas(fechaRegistro, fechaAtencion);
            if (diasEntreRegistroAtencion > diasPermitidosEntreRegistroAtencion)
                respuesta = true;
            return respuesta;
        }

        private void SePuedeEditar()
        {
            sePuedeEditar = objControlMedicoLogBL.SePuedeEditarControlMedico(fua);
        }

        private void EstablecerSeleccionCombosDgvDiagnosticos(int valorParaCombo)
        {
            foreach (DataGridViewRow row in dgvDiagnosticos.Rows)
            {
                DataGridViewComboBoxCell cboTipoObservacion = row.Cells["cmb_TipoObservacionDiagnostico"] as DataGridViewComboBoxCell;
                cboTipoObservacion.Value = valorParaCombo;
            }
        }

        private void EstablecerSeleccionCombosDgvProcedimientos(int detalleId, int valorParaCombo)
        {
            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                DataGridViewComboBoxCell cboTipoObservacionProcedimiento = row.Cells["cmb_TipoObservacionProcedimiento"] as DataGridViewComboBoxCell;
                DataGridViewCell celdaDetalleId = row.Cells["DetalleIdD"] as DataGridViewCell;
                if (Convert.ToInt32(celdaDetalleId.Value) == detalleId)
                    cboTipoObservacionProcedimiento.Value = valorParaCombo;
            }
        }

        private void EstablecerSeleccionCombosDgvMedicamentos(int detalleId, int valorParaCombo)
        {
            foreach (DataGridViewRow row in dgvMedicamentos.Rows)
            {
                DataGridViewComboBoxCell cboTipoObservacionMedicamento = row.Cells["cmb_TipoObservacionMedicamento"] as DataGridViewComboBoxCell;
                DataGridViewCell celdaDetalleId = row.Cells["DetalleIdM"] as DataGridViewCell;
                if (Convert.ToInt32(celdaDetalleId.Value) == detalleId)
                    cboTipoObservacionMedicamento.Value = valorParaCombo;
            }
        }

        private bool EstablecerObservacionFua()
        {
            bool cmObs = Convert.ToBoolean(bool.FalseString);
            if (!Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(0))
            {
                cmObs = Convert.ToBoolean(bool.TrueString);
                return cmObs;
            }
            foreach (DataGridViewRow row in dgvDiagnosticos.Rows)
            {
                DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObs"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celda_checkbox.Value))
                {
                    cmObs = Convert.ToBoolean(bool.TrueString);
                    return cmObs;
                }
            }
            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObsP"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celda_checkbox.Value))
                {
                    cmObs = Convert.ToBoolean(bool.TrueString);
                    return cmObs;
                }
            }
            foreach (DataGridViewRow row in dgvMedicamentos.Rows)
            {
                DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObsM"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celda_checkbox.Value))
                {
                    cmObs = Convert.ToBoolean(bool.TrueString);
                    return cmObs;
                }
            }
            return cmObs;
        }

        private int EstablecerTipoObservacionFua()
        {
            int cmTipoObservacion = 0;
            if (!Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(0))
            {
                cmTipoObservacion = Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue);
                return cmTipoObservacion;
            }

            foreach (DataGridViewRow row in dgvDiagnosticos.Rows)
            {
                DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObs"] as DataGridViewCheckBoxCell;
                DataGridViewComboBoxCell celda_combo = row.Cells["cmb_TipoObservacionDiagnostico"] as DataGridViewComboBoxCell;
                if (Convert.ToBoolean(celda_checkbox.Value))
                {
                    cmTipoObservacion = Convert.ToInt32(celda_combo.Value);
                    return cmTipoObservacion;
                }
            }

            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObsP"] as DataGridViewCheckBoxCell;
                DataGridViewComboBoxCell celda_combo = row.Cells["cmb_TipoObservacionProcedimiento"] as DataGridViewComboBoxCell;
                if (Convert.ToBoolean(celda_checkbox.Value))
                {
                    cmTipoObservacion = Convert.ToInt32(celda_combo.Value);
                    return cmTipoObservacion;
                }
            }

            foreach (DataGridViewRow row in dgvMedicamentos.Rows)
            {
                DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObsM"] as DataGridViewCheckBoxCell;
                DataGridViewComboBoxCell celda_combo = row.Cells["cmb_TipoObservacionMedicamento"] as DataGridViewComboBoxCell;
                if (Convert.ToBoolean(celda_checkbox.Value))
                {
                    cmTipoObservacion = Convert.ToInt32(celda_combo.Value);
                    return cmTipoObservacion;
                }
            }

            return cmTipoObservacion;
        }

        private void CerrarFormulario()
        {
            this.Close();
            this.Dispose();
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void SeleccionarPcpp()
        {
            if (!sePuedeEditar)
                return;
            DialogResult result = MessageBox.Show("¿Esta seguro de seleccionar el FUA para PCPP?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    MovimientoPaciente objMovimientoPaciente = new MovimientoPaciente();
                    objMovimientoPaciente.Fua = objvw_MovimientoPacienteFull.Fua;
                    objMovimientoPaciente.CMPcpp = Convert.ToBoolean(bool.TrueString);
                    ControlMedicoLog objControlMedicoLog = new ControlMedicoLog();
                    objControlMedicoLog.Fua = objvw_MovimientoPacienteFull.Fua;
                    objControlMedicoLog.TipoControlMedicoId = idTipoEventoCMSeleccionadoPcpp;
                    objControlMedicoLog.id_usuario = VariablesGlobales.UsuarioId;
                    objControlMedicoLog.TipoObservacionId = EstablecerTipoObservacionFua();
                    try
                    {
                        objMovimientoPacienteBL.SeleccionarAtencionParaPcpp(objMovimientoPaciente, objControlMedicoLog);
                        MessageBox.Show("FUA seleccionado para PCPP", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    IniciarProceso();
                    break;
                case DialogResult.No: break;
            }
        }

        private void Guardar()
        {
            if (!sePuedeEditar)
                return;
            DialogResult result = MessageBox.Show("¿Esta seguro de guardar la verificacion del fua?", "FISSAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    MovimientoPaciente objMovimientoPaciente = new MovimientoPaciente();
                    objMovimientoPaciente.Fua = objvw_MovimientoPacienteFull.Fua;
                    objMovimientoPaciente.CM = Convert.ToBoolean(bool.TrueString);
                    objMovimientoPaciente.CMObs = EstablecerObservacionFua();
                    if (Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(tipoObservacionFechaRegistro))
                        objMovimientoPaciente.CMErrorFechaAtencion = Convert.ToBoolean(bool.TrueString);
                    if (Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(tipoObservacionResponsable))
                        objMovimientoPaciente.CMErrorResponsableAtencion = Convert.ToBoolean(bool.TrueString);
                    if (Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(tipoObservacionFechaRegistroResponsable))
                    {
                        objMovimientoPaciente.CMErrorFechaAtencion = Convert.ToBoolean(bool.TrueString);
                        objMovimientoPaciente.CMErrorResponsableAtencion = Convert.ToBoolean(bool.TrueString);
                    }
                    ControlMedicoLog objControlMedicoLog = new ControlMedicoLog();
                    objControlMedicoLog.Fua = objvw_MovimientoPacienteFull.Fua;
                    objControlMedicoLog.id_usuario = VariablesGlobales.UsuarioId;
                    objControlMedicoLog.TipoObservacionId = EstablecerTipoObservacionFua();
                    if (Convert.ToBoolean(objvw_MovimientoPacienteFull.CMPcpp))
                        objControlMedicoLog.TipoControlMedicoId = idTipoEventoCMPcpp;
                    else
                        objControlMedicoLog.TipoControlMedicoId = idTipoEventoCMPreliminar;
                    try
                    {
                        objMovimientoPacienteBL.GuardarControlMedicoAtencion(objMovimientoPaciente, listaDiagnosticos, listaProcedimientos, listaMedicamentos, objControlMedicoLog);
                        MessageBox.Show("Supervision guardada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    IniciarProceso();
                    break;
                case DialogResult.No: break;
            }
        }

        private void Salir()
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de salir de la verificacion del fua?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    CerrarFormulario();
                    break;
                case DialogResult.No: break;
            }
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarControles(this);
            mensajeAvisos.Clear();
            this.cboTipoObservacionAtencion.SelectedIndexChanged -= new System.EventHandler(this.cboTipoObservacion_SelectedIndexChanged);
            this.dgvDiagnosticos.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosticos_CellValueChanged);
            this.dgvProcedimientos.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellValueChanged);
            this.dgvMedicamentos.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellValueChanged);
        }

        private void Primero()
        {
            indiceActualListaIdAtenciones = 0;
            IniciarProceso();
        }

        private void Anterior()
        {
            if (indiceActualListaIdAtenciones > 0)
                indiceActualListaIdAtenciones--;
            IniciarProceso();
        }

        private void Siguiente()
        {
            if (indiceActualListaIdAtenciones < listaIdAtenciones.Length - 1)
                indiceActualListaIdAtenciones++;
            IniciarProceso();
        }

        private void Ultimo()
        {
            indiceActualListaIdAtenciones = listaIdAtenciones.Length - 1;
            IniciarProceso();
        }

        private void EnviarObservacionDiagnostico()
        {
            if (!sePuedeEditar)
                return;
            DataGridViewRow row = dgvDiagnosticos.CurrentRow;
            objObservacionControlMedico = new ObservacionControlMedico();
            objObservacionControlMedico.DescripcionDetalle = Convert.ToString(row.Cells["descripciondiagnostico"].Value);
            objObservacionControlMedico.TipoObservacion = Convert.ToInt32(row.Cells["cmb_TipoObservacionDiagnostico"].Value);
            objObservacionControlMedico.DescripcionObservacion = Convert.ToString(row.Cells["CMObsDescDx"].Value);
            bool quitarObservacion = true;
            if (!Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(0))
                quitarObservacion = false;
            FrmRegistrarObservacion objFrmRegistrarObservacion = new FrmRegistrarObservacion(false, quitarObservacion, categoriaDiagnosticos, objObservacionControlMedico);
            objFrmRegistrarObservacion.Owner = this;
            objFrmRegistrarObservacion.ShowDialog();
            if (objFrmRegistrarObservacion.DialogResult == DialogResult.OK)
            {
                row.Cells["cmb_TipoObservacionDiagnostico"].Value = objObservacionControlMedico.TipoObservacion;
                row.Cells["CMObsDescDx"].Value = objObservacionControlMedico.DescripcionObservacion;
            }
        }

        private void EnviarObservacionProcedimiento()
        {
            if (!sePuedeEditar)
                return;
            DataGridViewRow row = dgvProcedimientos.CurrentRow;
            objObservacionControlMedico = new ObservacionControlMedico();
            objObservacionControlMedico.DescripcionDetalle = Convert.ToString(row.Cells["Descripcion"].Value);
            objObservacionControlMedico.CantidadDetalle = Convert.ToInt32(row.Cells["Cantidad"].Value);
            objObservacionControlMedico.TipoObservacion = Convert.ToInt32(row.Cells["cmb_TipoObservacionProcedimiento"].Value);
            if (row.Cells["CMCantidadObservada"].Value != null && !row.Cells["CMCantidadObservada"].Value.Equals(0))
                objObservacionControlMedico.CantidadObservada = Convert.ToInt32(row.Cells["CMCantidadObservada"].Value);
            else
                objObservacionControlMedico.CantidadObservada = Convert.ToInt32(row.Cells["Cantidad"].Value);
            objObservacionControlMedico.DescripcionObservacion = Convert.ToString(row.Cells["CMObsDescP"].Value);
            bool quitarObservacion = SePuedeQuitarObservacion(Convert.ToInt32(row.Cells["DetalleIdD"].Value));
            FrmRegistrarObservacion objFrmRegistrarObservacion = new FrmRegistrarObservacion(true, quitarObservacion, categoriaProcedimientos, objObservacionControlMedico);
            objFrmRegistrarObservacion.Owner = this;
            objFrmRegistrarObservacion.ShowDialog();
            if (objFrmRegistrarObservacion.DialogResult == DialogResult.OK)
            {
                row.Cells["cmb_TipoObservacionProcedimiento"].Value = objObservacionControlMedico.TipoObservacion;
                row.Cells["CMCantidadObservada"].Value = objObservacionControlMedico.CantidadObservada;
                row.Cells["CMObsDescP"].Value = objObservacionControlMedico.DescripcionObservacion;
            }
        }

        private bool SePuedeQuitarObservacion(int detalleId)
        {
            bool quitarObservacion = true;
            if (!Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue).Equals(0))
            {
                quitarObservacion = false;
                return quitarObservacion;
            }
            foreach (DataGridViewRow row in dgvDiagnosticos.Rows)
            {
                DataGridViewCell detalleIdDiagnostico = row.Cells["DetalleId"] as DataGridViewCell;
                if (detalleId == Convert.ToInt32(detalleIdDiagnostico.Value))
                {
                    DataGridViewCheckBoxCell celda_checkbox = row.Cells["CMObs"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(celda_checkbox.Value))
                    {
                        quitarObservacion = false;
                        return quitarObservacion;
                    }
                }
            }
            return quitarObservacion;
        }

        private void EnviarObservacionMedicamento()
        {
            if (!sePuedeEditar)
                return;
            DataGridViewRow row = dgvMedicamentos.CurrentRow;
            objObservacionControlMedico = new ObservacionControlMedico();
            objObservacionControlMedico.DescripcionDetalle = Convert.ToString(row.Cells["DescripcionSiga"].Value);
            objObservacionControlMedico.CantidadDetalle = Convert.ToInt32(row.Cells["CantidadM"].Value);
            objObservacionControlMedico.TipoObservacion = Convert.ToInt32(row.Cells["cmb_TipoObservacionMedicamento"].Value);
            if (row.Cells["CMCantidadObservadaM"].Value != null && !row.Cells["CMCantidadObservadaM"].Value.Equals(0))
                objObservacionControlMedico.CantidadObservada = Convert.ToInt32(row.Cells["CMCantidadObservadaM"].Value);
            else
                objObservacionControlMedico.CantidadObservada = Convert.ToInt32(row.Cells["CantidadM"].Value);
            objObservacionControlMedico.DescripcionObservacion = Convert.ToString(row.Cells["CMObsDescM"].Value);
            bool quitarObservacion = SePuedeQuitarObservacion(Convert.ToInt32(row.Cells["DetalleIdM"].Value));
            FrmRegistrarObservacion objFrmRegistrarObservacion = new FrmRegistrarObservacion(true, quitarObservacion, categoriaMedicamentos, objObservacionControlMedico);
            objFrmRegistrarObservacion.Owner = this;
            objFrmRegistrarObservacion.ShowDialog();
            if (objFrmRegistrarObservacion.DialogResult == DialogResult.OK)
            {
                row.Cells["cmb_TipoObservacionMedicamento"].Value = objObservacionControlMedico.TipoObservacion;
                row.Cells["CMCantidadObservadaM"].Value = objObservacionControlMedico.CantidadObservada;
                row.Cells["CMObsDescM"].Value = objObservacionControlMedico.DescripcionObservacion;
            }
        }

        #endregion

        #region 'EVENTOS BTN'

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tsBtnSeleccionarPcpp_Click(object sender, EventArgs e)
        {
            SeleccionarPcpp();
        }

        private void tsBtnPrimero_Click(object sender, EventArgs e)
        {
            Primero();
        }

        private void tsBtnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }

        private void tsBtnSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();
        }

        private void tsBtnUltimo_Click(object sender, EventArgs e)
        {
            Ultimo();
        }

        #endregion

        #region 'EVENTOS DGV'

        private void dgvDiagnosticos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiagnosticos.Columns[e.ColumnIndex].Name == "cmb_TipoObservacionDiagnostico")
            {
                DataGridViewRow row = dgvDiagnosticos.Rows[e.RowIndex];
                DataGridViewCell celdaDetalleId = row.Cells["DetalleId"] as DataGridViewCell;
                DataGridViewComboBoxCell cboTipoObservacionDiagnostico = row.Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                DataGridViewCell tipoObservacionDiagnostico = row.Cells["TipoObservacionDiagnostico"] as DataGridViewCell;
                DataGridViewCheckBoxCell celdaCMObs = row.Cells["CMObs"] as DataGridViewCheckBoxCell;
                DataGridViewCell celdaCMObsDescDx = row.Cells["CMObsDescDx"] as DataGridViewCell;
                tipoObservacionDiagnostico.Value = cboTipoObservacionDiagnostico.Value;
                if (Convert.ToInt32(cboTipoObservacionDiagnostico.Value).Equals(0))
                {
                    celdaCMObs.Value = false;
                    celdaCMObsDescDx.Value = string.Empty;
                }
                else
                {
                    celdaCMObs.Value = true;
                    celdaCMObsDescDx.Value = string.Empty;
                }
                
                EstablecerSeleccionCombosDgvProcedimientos(Convert.ToInt32(celdaDetalleId.Value), Convert.ToInt32(cboTipoObservacionDiagnostico.Value));
                EstablecerSeleccionCombosDgvMedicamentos(Convert.ToInt32(celdaDetalleId.Value), Convert.ToInt32(cboTipoObservacionDiagnostico.Value));
            }
        }

        private void dgvDiagnosticos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDiagnosticos.IsCurrentCellDirty)
                dgvDiagnosticos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvDiagnosticos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarObservacionDiagnostico();
        }

        private void dgvDiagnosticos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarObservacionDiagnostico();
                    if (dgvDiagnosticos.CurrentRow.Index == dgvDiagnosticos.RowCount - 1)
                    {
                        tabCtlConsumos.SelectedTab = tabPagProcedimientos;
                        dgvProcedimientos.Focus();
                    }
                    break;
                case Keys.Back:
                    cboTipoObservacionAtencion.Focus();
                    break;
            }
        }

        private void dgvProcedimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProcedimientos.Columns[e.ColumnIndex].Name == "cmb_TipoObservacionProcedimiento")
            {
                DataGridViewRow row = dgvProcedimientos.Rows[e.RowIndex];
                DataGridViewComboBoxCell cboTipoObservacionProcedimiento = row.Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                DataGridViewCell tipoObservacionProcedimiento = row.Cells["TipoObservacionProcedimiento"] as DataGridViewCell;
                DataGridViewCheckBoxCell celdaCMObsP = row.Cells["CMObsP"] as DataGridViewCheckBoxCell;
                DataGridViewCell celdaCMObsDescP = row.Cells["CMObsDescP"] as DataGridViewCell;
                DataGridViewCell celdaCantidad = row.Cells["Cantidad"] as DataGridViewCell;
                DataGridViewCell celdaCMCantidadObservada = row.Cells["CMCantidadObservada"] as DataGridViewCell;
                tipoObservacionProcedimiento.Value = cboTipoObservacionProcedimiento.Value;
                if (Convert.ToInt32(cboTipoObservacionProcedimiento.Value).Equals(0))
                {
                    celdaCMObsP.Value = false;
                    celdaCMObsDescP.Value = string.Empty;
                    celdaCMCantidadObservada.Value = 0;
                }
                else
                {
                    celdaCMObsP.Value = true;
                    celdaCMObsDescP.Value = string.Empty;
                    celdaCMCantidadObservada.Value = celdaCantidad.Value;
                }
            }
        }

        private void dgvProcedimientos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProcedimientos.IsCurrentCellDirty)
                dgvProcedimientos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvProcedimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarObservacionProcedimiento();
        }
        private void dgvProcedimientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarObservacionProcedimiento();
                    if (dgvProcedimientos.CurrentRow.Index == dgvProcedimientos.RowCount - 1)
                    {
                        tabCtlConsumos.SelectedTab = tabPagMedicamentos;
                        dgvMedicamentos.Focus();
                    }
                    break;
                case Keys.Back:
                    dgvDiagnosticos.Focus();
                    break;
                case Keys.Down:
                    if (dgvProcedimientos.CurrentRow.Index == dgvProcedimientos.RowCount - 1)
                    {
                        tabCtlConsumos.SelectedTab = tabPagMedicamentos;
                        dgvMedicamentos.Focus();
                    }
                    break;
            }
        }

        private void dgvMedicamentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedicamentos.Columns[e.ColumnIndex].Name == "cmb_TipoObservacionMedicamento")
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];
                DataGridViewComboBoxCell cboTipoObservacionMedicamento = row.Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                DataGridViewCell tipoObservacionMedicamento = row.Cells["TipoObservacionMedicamento"] as DataGridViewCell;
                DataGridViewCheckBoxCell celdaCMObsM = row.Cells["CMObsM"] as DataGridViewCheckBoxCell;
                DataGridViewCell celdaCMObsDescM = row.Cells["CMObsDescM"] as DataGridViewCell;
                DataGridViewCell celdaCantidadM = row.Cells["CantidadM"] as DataGridViewCell;
                DataGridViewCell celdaCMCantidadObservadaM = row.Cells["CMCantidadObservadaM"] as DataGridViewCell;
                tipoObservacionMedicamento.Value = cboTipoObservacionMedicamento.Value;
                if (Convert.ToInt32(cboTipoObservacionMedicamento.Value).Equals(0))
                {
                    celdaCMObsM.Value = false;
                    celdaCMObsDescM.Value = string.Empty;
                    celdaCMCantidadObservadaM.Value = 0;
                }
                else
                {
                    celdaCMObsM.Value = true;
                    celdaCMObsDescM.Value = string.Empty;
                    celdaCMCantidadObservadaM.Value = celdaCantidadM.Value;
                }
            }
        }

        private void dgvMedicamentos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMedicamentos.IsCurrentCellDirty)
                dgvMedicamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvMedicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarObservacionMedicamento();
        }

        private void dgvMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarObservacionMedicamento();
                    if (dgvMedicamentos.CurrentRow.Index == dgvMedicamentos.RowCount - 1)
                        Guardar();
                    break;
                case Keys.Back:
                    tabCtlConsumos.SelectedTab = tabPagProcedimientos;
                    dgvProcedimientos.Focus();
                    break;
                case Keys.Up:
                    if (dgvMedicamentos.CurrentRow.Index == 0)
                    {
                        tabCtlConsumos.SelectedTab = tabPagProcedimientos;
                        dgvProcedimientos.Focus();
                    }
                    break;
            }
        }

        #endregion

        #region 'EVENTOS FRM'

        private void FrmFua_Load(object sender, EventArgs e)
        {
            CargarCbosTipoObservacion();
            IniciarProceso();
        }

        private void FrmFua_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    if (tabCtlConsumos.SelectedTab == tabPagProcedimientos)
                        tabCtlConsumos.SelectedTab = tabPagMedicamentos;
                    else
                        tabCtlConsumos.SelectedTab = tabPagProcedimientos;
                    break;
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS CBO'

        private void cboTipoObservacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstablecerSeleccionCombosDgvDiagnosticos(Convert.ToInt32(cboTipoObservacionAtencion.SelectedValue));
        }

        private void cboTipoObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    dgvDiagnosticos.Focus();
                    break;
                case Keys.Back:
                    toolStrip1.Focus();
                    break;
            }
        }

        #endregion

        #region 'IMPLEMENTACION DE MIEMBROS DE INTERFACES'

        public void ObtenerObservacion(ObservacionControlMedico objObservacionControlMedico)
        {
            this.objObservacionControlMedico = objObservacionControlMedico;
        }

        #endregion

    }
}