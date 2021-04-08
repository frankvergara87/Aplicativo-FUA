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
using FissalBE;
using FissalWinForm.MDAutorizacion;
using System.Transactions;

namespace FissalWinForm
{
    public partial class FrmGestionarAutorizaciones : Form, IFormSelectorTratamientos, IFrmSelectorPacientes
    {
        #region 'VARIABLES Y CONSTANTES'

        PacienteBL objPacienteBL = new PacienteBL();
        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        TratamientoBL objTratamientoBL = new TratamientoBL();
        PaqueteBL objPaqueteBL = new PaqueteBL();
        SolicitudAutorizacionDetalleBL objSolicitudAutorizacionDetalleBL = new SolicitudAutorizacionDetalleBL();
        Paciente objPaciente;
        Autorizacion objAutorizacion;
        Tratamiento objTratamiento;
        vw_paquete objPaquete;
        vw2_SolicitudAutorizacion objSolicitudAutorizacion;
        vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle;

        #endregion

        #region 'CONSTRUCTORES'

        public FrmGestionarAutorizaciones()
        {
            InitializeComponent();
        }

        public FrmGestionarAutorizaciones(vw2_SolicitudAutorizacion objSolicitudAutorizacion, vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle)
            : this()
        {
            this.objSolicitudAutorizacion = objSolicitudAutorizacion;
            this.objSolicitudAutorizacionDetalle = objSolicitudAutorizacionDetalle;
        }

        #endregion

        #region 'CONFIGURACION'

        private void CargarConfiguracion()
        {
            this.KeyPreview = true;
            this.AutoValidate = AutoValidate.Disable;
            this.CenterToScreen();
            toolStrip1.TabStop = true;
            txtAutorizacionFecha.ReadOnly = true;
            txtAutorizacionFechaSolicitud.ReadOnly = true;
            if (objSolicitudAutorizacion != null && objSolicitudAutorizacionDetalle != null)
            {
                FuncionesBases.ActivaControles(grpPaciente, false);
                FuncionesBases.ActivaControles(grpAutorizacion, false);
                txtAutorizacionDescripcion.Enabled = true;
                txtAutorizacionObservacion.Enabled = true;
                FuncionesBases.ActivaControles(grpTratamiento, false);
                tsBtnAnular.Visible = false;
                tsBtnLimpiar.Visible = false;
                
            }
            else
            {
                FuncionesBases.ActivaControles(grpPaciente, false);
                txtPacienteId.Enabled = true;
                txtPacienteId.ReadOnly = true;
                btnAbrirSelectorPaciente.Enabled = true;
                FuncionesBases.ActivaControles(grpAutorizacion, false);
                cboAutorizacionEstablecimiento.Enabled = true;
                cboAutorizacionModalidad.Enabled = true;
                txtAutorizacionDescripcion.Enabled = true;
                txtAutorizacionFecha.Enabled = true;
                txtAutorizacionFechaVigencia.Enabled = true;
                txtAutorizacionFechaVigencia.ReadOnly = true;
                txtAutorizacionFechaSolicitud.Enabled = true;
                txtAutorizacionObservacion.Enabled = true;
                dtpAutorizacionFecha.Enabled = true;
                dtpAutorizacionFechaSolicitud.Enabled = true;
                btnAutorizacionLimpiarFecha.Enabled = true;
                btnAutorizacionLimpiarFechaSolicitud.Enabled = true;
                FuncionesBases.ActivaControles(grpTratamiento, false);
                txtTratamientoId.Enabled = true;
                txtTratamientoId.ReadOnly = true;
                btnAbrirSelectorTratamiento.Enabled = true;
                tsBtnAnular.Visible = false;
                toolStripSeparator3.Visible = false;
                tsBtnRechazar.Visible = false;
            }
        }

        #endregion

        #region 'CARGA DE DATOS'

        private void CargarDatosIniciales()
        {
            if (objSolicitudAutorizacion != null && objSolicitudAutorizacionDetalle != null)
                dtpAutorizacionFecha.Value = DatosBL.GetDate();
            txtAutorizacionFechaCreacion.Text = DatosBL.GetDate().ToShortDateString();
            txtAutorizacionUsuarioCreacion.Text = VariablesGlobales.Login;
            chkAutorizacionEstado.Checked = true;
        }

        private void CargarDatosAutorizacion()
        {
            if (objSolicitudAutorizacion != null && objSolicitudAutorizacionDetalle != null)
            {
                #region 'CARGA DE DATOS PACIENTE'

                objPaciente = objPacienteBL.GetPacientePorTipoNumeroDocumento((byte)objSolicitudAutorizacion.TipoDocumentoId, objSolicitudAutorizacion.NumeroDocumento);
                txtPacienteNombres.Text = objSolicitudAutorizacion.DescripcionPaciente;
                if(objPaciente != null)
                    txtPacienteId.Text = objPaciente.PacienteId;

                #endregion

                #region 'CARGA DE DATOS AUTORIZACION'

                txtAutorizacionFechaSolicitud.Text = Convert.ToDateTime(objSolicitudAutorizacion.Fecha_Solicitud).ToShortDateString();
                txtAutorizacionNumeroSolicitud.Text = objSolicitudAutorizacion.Nro_Solicitud;
                cboAutorizacionEstablecimiento.SelectedValue = objSolicitudAutorizacion.EstablecimientoId;
                chkAutorizacionAdicional.Checked = Convert.ToBoolean(objSolicitudAutorizacionDetalle.Adicional);
                
                #endregion

                #region 'CARGA DE DATOS PAQUETE'

                objTratamiento = objTratamientoBL.GetTratamientoPorIdVersion(objSolicitudAutorizacionDetalle.TratamientoId, objSolicitudAutorizacion.Fecha_Solicitud);
                txtTratamientoId.Text = objTratamiento.TratamientoId.ToString();
                cboTratamientoCategoria.SelectedValue = objSolicitudAutorizacionDetalle.CategoriaId;
                cboTratamientoEstadio.SelectedValue = objSolicitudAutorizacionDetalle.EstadioId;
                cboTratamientoFase.SelectedValue = objSolicitudAutorizacionDetalle.FaseId;
                cboTratamientoTipo.SelectedValue = objTratamiento.TipoAutorizacionId;
                txtTratamientoVersion.Text = objTratamiento.Version.ToString();
                txtTratamientoVigencia.Text = objTratamiento.Vigencia.ToString();
                txtTratamientoMonto.Text = objTratamiento.Monto.ToString();
                if (Convert.ToBoolean(objTratamiento.SoloRetrospectivo))
                {
                    cboAutorizacionModalidad.SelectedValue = "R";
                    cboAutorizacionModalidad.Enabled = false;
                }
                #endregion
            }
        }

        #endregion

        #region 'LOGICA DEL PROCESO'

        private void ObtenerDatosPaciente()
        {
            if (FuncionesBases.EsTextBoxVacio(txtPacienteId, errorProvider1))
                return;
            objPaciente = objPacienteBL.GetPacientePorId(txtPacienteId.Text.Trim());
            if (objPaciente != null)
            {
                txtPacienteId.Text = objPaciente.PacienteId;
                txtPacienteNombres.Text = string.Concat(objPaciente.ApellidoPaterno, " ", objPaciente.ApellidoMaterno, " ", objPaciente.Nombres);
            }
            else
                MessageBox.Show("No se encontro paciente", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ObtenerDatosTratamiento()
        {
            if (FuncionesBases.EsTextBoxVacio(txtTratamientoId, errorProvider1))
                return;
            objTratamiento = objTratamientoBL.GetTratamientoPorIdVersion(Convert.ToInt32(txtTratamientoId.Text.Trim()), DatosBL.GetDate());
            objPaquete = objPaqueteBL.GetVWPaquetePorId(Convert.ToInt32(txtTratamientoId.Text.Trim()));
            txtTratamientoId.Text = objTratamiento.TratamientoId.ToString();
            cboTratamientoCategoria.SelectedValue = objPaquete.CategoriaId;
            cboTratamientoEstadio.SelectedValue = objPaquete.EstadioId;
            cboTratamientoFase.SelectedValue = objPaquete.FaseId;
            cboTratamientoTipo.SelectedValue = objTratamiento.TipoAutorizacionId;
            txtTratamientoVersion.Text = objTratamiento.Version.ToString();
            txtTratamientoVigencia.Text = objTratamiento.Vigencia.ToString();
            txtTratamientoMonto.Text = objTratamiento.Monto.ToString();
            if (Convert.ToBoolean(objTratamiento.SoloRetrospectivo))
            {
                cboAutorizacionModalidad.SelectedValue = "R";
                cboAutorizacionModalidad.Enabled = false;
            }
        }

        #endregion

        #region 'VALIDACIONES'

        private bool ValidarAutorizacionFecha()
        {
            bool cancel = false;
            if (FuncionesBases.EsTextBoxVacio(txtAutorizacionFecha, errorProvider1))
                cancel = true;
            if (FuncionesBases.ValidarFechaFin(txtAutorizacionFecha, errorProvider1))
                cancel = true;
            return cancel;
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void Anular()
        {
            if (objAutorizacion != null)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de anular la autorizacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        int respuesta = objAutorizacionBL.AnularAutorizacionPorId(objAutorizacion.AutorizacionId);
                        if (respuesta > 0)
                        {
                            MessageBox.Show("La autorizacion fue anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                            MessageBox.Show("No se anulo la autorizacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DialogResult.No: break;
                }   
            }
            else
            {
                //MessageBox.Show("No ha cargado informacion de autorizacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Guardar()
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                if (objSolicitudAutorizacion != null && objSolicitudAutorizacionDetalle != null)
                {
                    if (objPaciente == null)
                    {
                        objPaciente = new Paciente();
                        objPaciente.EstablecimientoIdOrigen = objSolicitudAutorizacion.EstablecimientoId;
                        objPaciente.Estado = true;
                        objPaciente.UsuarioCreacion = VariablesGlobales.Login;
                        objPaciente.NumeroDocumento = objSolicitudAutorizacion.NumeroDocumento;
                        objPaciente.TipoDocumentoId = objSolicitudAutorizacion.TipoDocumentoId;
                    }
                    objPaciente.ApellidoMaterno = objSolicitudAutorizacion.ApellidoMaterno;
                    objPaciente.ApellidoPaterno = objSolicitudAutorizacion.ApellidoPaterno;
                    objPaciente.fecha_defuncion = objSolicitudAutorizacion.fecha_defuncion;
                    objPaciente.Historia = objSolicitudAutorizacion.Historia;
                    objPaciente.Nacimiento = objSolicitudAutorizacion.Nacimiento;
                    objPaciente.Nombres = objSolicitudAutorizacion.Nombres;
                    objPaciente.OtrosNombres = objSolicitudAutorizacion.OtrosNombres;
                    objPaciente.SexoId = objSolicitudAutorizacion.SexoId;
                    objPaciente.TipoRegimenId = objSolicitudAutorizacion.TipoRegimenId;
                    objPaciente.Validado = true;

                    objAutorizacion = new Autorizacion();
                    objAutorizacion.Adicional = chkAutorizacionAdicional.Checked;
                    objAutorizacion.Anulado = chkAutorizacionAnulado.Checked;
                    objAutorizacion.ControlaCantidad = chkAutorizacionControlaCantidad.Checked;
                    objAutorizacion.Descripcion = txtAutorizacionDescripcion.Text;
                    objAutorizacion.DiagnosticoAsociado = chkAutorizacionDxAsociado.Checked;
                    objAutorizacion.EstablecimientoId = Convert.ToInt32(cboAutorizacionEstablecimiento.SelectedValue);
                    objAutorizacion.Estado = "A";
                    objAutorizacion.Fecha = Convert.ToDateTime(txtAutorizacionFecha.Text);
                    objAutorizacion.FechaSolicitud = Convert.ToDateTime(txtAutorizacionFechaSolicitud.Text);
                    if (cboAutorizacionModalidad.SelectedValue.Equals("R"))
                        objAutorizacion.Modalidad = cboAutorizacionModalidad.SelectedValue.ToString();
                    else
                        objAutorizacion.Modalidad = "S";
                    if (string.Equals(objAutorizacion.Modalidad, "R") || string.Equals(objAutorizacion.Modalidad, "S"))
                        objAutorizacion.Monto = 0;
                    else
                        objAutorizacion.Monto = Convert.ToDecimal(txtTratamientoMonto.Text);
                    objAutorizacion.Nro_Solicitud = txtAutorizacionNumeroSolicitud.Text;
                    objAutorizacion.observacion = txtAutorizacionObservacion.Text;
                    objAutorizacion.Tipo = "P";
                    objAutorizacion.TipoAutorizacionId = Convert.ToByte(cboTratamientoTipo.SelectedValue);
                    objAutorizacion.TratamiendoId = Convert.ToInt32(txtTratamientoId.Text);
                    objAutorizacion.UsuarioCreacion = txtAutorizacionUsuarioCreacion.Text;
                    objAutorizacion.Version = Convert.ToInt32(txtTratamientoVersion.Text);
                    objAutorizacion.Vigencia = Convert.ToDateTime(txtAutorizacionFechaVigencia.Text);
                    try
                    {
                        bool seProcesaronTodos = objAutorizacionBL.RegistrarAutorizacion(objPaciente, objAutorizacion, objSolicitudAutorizacion, objSolicitudAutorizacionDetalle);
                        if (seProcesaronTodos)
                            this.DialogResult = DialogResult.OK;
                        else
                            this.DialogResult = DialogResult.Yes;
                        MessageBox.Show("Solicitud autorizada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salir();
                    }
                    catch (TransactionException tex)
                    {
                        MessageBox.Show("No se autorizo la solicitud", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    objAutorizacion = new Autorizacion();
                    objAutorizacion.Adicional = chkAutorizacionAdicional.Checked;
                    objAutorizacion.Anulado = chkAutorizacionAnulado.Checked;
                    objAutorizacion.ControlaCantidad = chkAutorizacionControlaCantidad.Checked;
                    objAutorizacion.Descripcion = txtAutorizacionDescripcion.Text.Trim();
                    objAutorizacion.DiagnosticoAsociado = chkAutorizacionDxAsociado.Checked;
                    objAutorizacion.EstablecimientoId = Convert.ToInt32(cboAutorizacionEstablecimiento.SelectedValue);
                    objAutorizacion.Estado = "A";
                    objAutorizacion.Fecha = Convert.ToDateTime(txtAutorizacionFecha.Text);
                    if (!string.Equals(txtAutorizacionFechaSolicitud.Text, string.Empty))
                        objAutorizacion.FechaSolicitud = Convert.ToDateTime(txtAutorizacionFechaSolicitud.Text);
                    objAutorizacion.Modalidad = cboAutorizacionModalidad.SelectedValue.ToString();
                    if(cboAutorizacionModalidad.SelectedValue.Equals("R"))
                        objAutorizacion.Monto = 0;
                    else
                        objAutorizacion.Monto = Convert.ToDecimal(txtTratamientoMonto.Text);
                    objAutorizacion.observacion = txtAutorizacionObservacion.Text.Trim();
                    objAutorizacion.PacienteId = txtPacienteId.Text;
                    objAutorizacion.Tipo = "P";
                    objAutorizacion.TipoAutorizacionId = Convert.ToByte(cboTratamientoTipo.SelectedValue);
                    objAutorizacion.TratamiendoId = Convert.ToInt32(txtTratamientoId.Text);
                    objAutorizacion.UsuarioCreacion = txtAutorizacionUsuarioCreacion.Text;
                    objAutorizacion.Version = Convert.ToInt32(txtTratamientoVersion.Text);
                    objAutorizacion.Vigencia = Convert.ToDateTime(txtAutorizacionFechaVigencia.Text);
                    try
                    {
                        objAutorizacionBL.RegistrarAutorizacion(objAutorizacion, objTratamiento, objPaquete);
                        MessageBox.Show("Autorizacion Registrada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (TransactionException tex)
                    {
                        MessageBox.Show("No se registro la autorizacion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Hay datos no válidos en el formulario", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            dtpAutorizacionFecha.Value = DatosBL.GetDate();
            FuncionesBases.LimpiarControles(this);
            errorProvider1.Clear();
            CargarDatosIniciales();
            
        }

        private void Salir()
        {
            this.Dispose();
            this.Close();
        }

        private void Rechazar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de rechazar la solicitud?", "FISSAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    string observaciones = FuncionesBases.ShowDialogInputBox("Observacion", "FISSAL", string.Empty);
                    objSolicitudAutorizacionDetalle.Observaciones = observaciones;
                    try
                    {
                        bool seProcesaronTodos= objSolicitudAutorizacionDetalleBL.RechazarDetalleSolicitudAutorizacion(objSolicitudAutorizacion, objSolicitudAutorizacionDetalle);
                        if (seProcesaronTodos)
                            this.DialogResult = DialogResult.OK;
                        else
                            this.DialogResult = DialogResult.Yes;
                        MessageBox.Show("Solicitud rechazada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salir();    
                    }
                    catch(TransactionException tex)
                    {
                        MessageBox.Show("No se rechazo la solicitud", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case DialogResult.No: break;
            }
        }

        #endregion

        #region 'EVENTOS FRM'

        private void FrmGestionarAutorizaciones_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
            FuncionesBases.CargarCboEstablecimientoConConvenio(cboAutorizacionEstablecimiento);
            FuncionesBases.CargarCboModalidadAutorizacion(cboAutorizacionModalidad);
            FuncionesBases.CargarCboTipoAutorizacion(cboTratamientoTipo);
            FuncionesBases.CargarCboCategoria(cboTratamientoCategoria);
            FuncionesBases.CargarCboEstadio(cboTratamientoEstadio);
            FuncionesBases.CargarCboFase(cboTratamientoFase);
            CargarDatosAutorizacion();
            CargarDatosIniciales();
            
        }

        private void FrmGestionarAutorizaciones_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS BTN'

        private void tsBtnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tsBtnRechazar_Click(object sender, EventArgs e)
        {
            Rechazar();
        }

        private void btnLimpiarAutorizacionFecha_Click(object sender, EventArgs e)
        {
            dtpAutorizacionFecha.Value = DateTime.Now;
            txtAutorizacionFecha.Clear();
        }

        private void btnAutorizacionLimpiarFechaSolicitud_Click(object sender, EventArgs e)
        {
            dtpAutorizacionFechaSolicitud.Value = DateTime.Now;
            txtAutorizacionFechaSolicitud.Clear();
        }

        private void btnAbrirSelectorTratamiento_Click(object sender, EventArgs e)
        {
            if (FuncionesBases.EsComboBoxSinSeleccion(cboAutorizacionEstablecimiento, errorProvider1))
                return;
            FormSelectorTratamientos objFormSelectorTratamientos = new FormSelectorTratamientos(Convert.ToInt32(cboAutorizacionEstablecimiento.SelectedValue));
            objFormSelectorTratamientos.Owner = this;
            DialogResult result = objFormSelectorTratamientos.ShowDialog();
            if (result == DialogResult.OK)
                ObtenerDatosTratamiento();
        }

        private void btnAbrirSelectorPaciente_Click(object sender, EventArgs e)
        {
            FrmSelectorPacientes objFrmSelectorPacientes = new FrmSelectorPacientes();
            objFrmSelectorPacientes.Owner = this;
            DialogResult result = objFrmSelectorPacientes.ShowDialog();
            if (result == DialogResult.OK)
                ObtenerDatosPaciente();
        }

        #endregion

        #region 'EVENTOS TXT'

        private void txtPacienteNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtPacienteId, errorProvider1);
        }

        private void txtPacienteNumeroDocumento_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteId, string.Empty);
        }

        private void txtAutorizacionFecha_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = ValidarAutorizacionFecha();
        }

        private void txtAutorizacionFecha_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAutorizacionFecha, string.Empty);
        }

        private void txtAutorizacionFechaVigencia_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtAutorizacionFechaVigencia, errorProvider1);
        }

        private void txtAutorizacionFechaVigencia_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAutorizacionFechaVigencia, string.Empty);
        }

        private void txtTratamientoId_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtTratamientoId, errorProvider1);
        }

        private void txtTratamientoId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTratamientoId, string.Empty);
        }

        private void txtTratamientoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtPacienteNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtTratamientoId_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ObtenerDatosTratamiento();
                    break;
            }
        }

        private void txtPacienteId_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ObtenerDatosPaciente();
                    break;
            }
        }

        private void txtAutorizacionFecha_TextChanged(object sender, EventArgs e)
        {
            if (!string.Equals(txtAutorizacionFecha.Text, string.Empty) && !string.Equals(txtTratamientoVigencia.Text, string.Empty))
                txtAutorizacionFechaVigencia.Text = Convert.ToDateTime(txtAutorizacionFecha.Text.Trim()).AddMonths(Convert.ToInt32(txtTratamientoVigencia.Text)).ToShortDateString();
            if (string.Equals(txtAutorizacionFecha.Text.Trim(), string.Empty))
                txtAutorizacionFechaVigencia.Clear();
        }

        private void txtAutorizacionFechaSolicitud_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaFin(txtAutorizacionFechaSolicitud, errorProvider1);
        }

        private void txtAutorizacionFechaSolicitud_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAutorizacionFechaSolicitud, string.Empty);
        }

        #endregion

        #region 'EVENTOS CBO'

        private void cboAutorizacionModalidad_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboAutorizacionModalidad, errorProvider1);
        }

        private void cboAutorizacionModalidad_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboAutorizacionModalidad, string.Empty);
        }

        private void cboAutorizacionEstablecimiento_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboAutorizacionEstablecimiento, errorProvider1);
        }

        private void cboAutorizacionEstablecimiento_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboAutorizacionEstablecimiento, string.Empty);
        }

        private void cboTratamientoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTratamientoCategoria.SelectedValue.Equals("ZZZ"))
                chkAutorizacionDxAsociado.Checked = true;
            else
                chkAutorizacionDxAsociado.Checked = false;
        }

        private void cboTratamientoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTratamientoTipo.SelectedValue.ToString().Equals("1"))
                chkAutorizacionControlaCantidad.Checked = true;
            else
                chkAutorizacionControlaCantidad.Checked = false;
        }

        private void cboAutorizacionEstablecimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FuncionesBases.LimpiarControles(grpTratamiento);
        }

        #endregion

        #region 'EVENTOS DTP'

        private void dtpAutorizacionFecha_ValueChanged(object sender, EventArgs e)
        {
            txtAutorizacionFecha.Text = dtpAutorizacionFecha.Value.ToShortDateString();
            if (!string.Equals(txtAutorizacionFecha.Text, string.Empty) && !string.Equals(txtTratamientoVigencia.Text, string.Empty))
                txtAutorizacionFechaVigencia.Text = Convert.ToDateTime(txtAutorizacionFecha.Text.Trim()).AddMonths(Convert.ToInt32(txtTratamientoVigencia.Text)).ToShortDateString();
        }

        private void dtpAutorizacionFechaSolicitud_ValueChanged(object sender, EventArgs e)
        {
            txtAutorizacionFechaSolicitud.Text = dtpAutorizacionFechaSolicitud.Value.ToShortDateString();
        }

        #endregion

        #region 'IMPLEMENTACION DE MIEMBROS DE INTERFACES'

        #region 'IFormSelectorTratamientos MEMBERS'

        public void ObtenerTratamiento(string tratamientoId)
        {
            txtTratamientoId.Text = tratamientoId;
            txtTratamientoId.Focus();
        }

        #endregion

        #region 'IFrmSelectorPacientes MEMBERS'

        public void ObtenerPacienteId(string pacienteId)
        {
            txtPacienteId.Text = pacienteId;
            txtPacienteId.Focus();
        }

        #endregion

        private void txtTratamientoVigencia_TextChanged(object sender, EventArgs e)
        {
            if (!string.Equals(txtAutorizacionFecha.Text, string.Empty) && !string.Equals(txtTratamientoVigencia.Text, string.Empty))
                txtAutorizacionFechaVigencia.Text = Convert.ToDateTime(txtAutorizacionFecha.Text.Trim()).AddMonths(Convert.ToInt32(txtTratamientoVigencia.Text)).ToShortDateString();
            if (string.Equals(txtTratamientoVigencia.Text.Trim(), string.Empty))
                txtAutorizacionFechaVigencia.Clear();
        }

        #endregion

    }
}
