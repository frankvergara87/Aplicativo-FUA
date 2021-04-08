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
using System.Transactions;

namespace FissalWinForm
{
    public partial class FrmSolicitudAutorizacion : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        SolicitudAutorizacionCabeceraBL objSolicitudAutorizacionCabeceraBL = new SolicitudAutorizacionCabeceraBL();
        vw2_SolicitudAutorizacion objSolicitudAutorizacion;
        SolicitudAutorizacionDetalleBL objSolicitudAutorizacionDetalleBL = new SolicitudAutorizacionDetalleBL();
        List<vw2_SolicitudAutorizacionDetalle> listaSolicitudAutorizacionDetalle;

        #endregion

        #region 'CONSTRUCTORES'

        public FrmSolicitudAutorizacion()
        {
            InitializeComponent();
            
        }

        public FrmSolicitudAutorizacion(vw2_SolicitudAutorizacion objSolicitudAutorizacion)
            : this()
        {
            this.objSolicitudAutorizacion = objSolicitudAutorizacion;
        }

        #endregion

        #region 'CONFIGURACION'

        private void CargarConfiguracionInicial()
        {
            dgvDetallesSolicitudes.AutoGenerateColumns = false;
            this.CenterToParent();
            this.KeyPreview = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            txtPacienteFechaDefuncion.ReadOnly = true;
            txtPacienteFechaNacimiento.ReadOnly = true;
            if (objSolicitudAutorizacion != null)
            {
                if (Convert.ToBoolean(objSolicitudAutorizacion.Recibido) && VariablesGlobales.Login != objSolicitudAutorizacion.Usuario_Procesa)
                    FuncionesBases.ActivaControles(this, false);
                else
                {
                    FuncionesBases.ActivaControles(grpBoxDatosSolicitud, false);
                    if (Convert.ToBoolean(objSolicitudAutorizacion.ValidadoSIS) || Convert.ToBoolean(objSolicitudAutorizacion.ValidadoFISSAL))
                    {
                        FuncionesBases.ActivaControles(grpBoxPaciente, false);
                        txtPacienteFechaDefuncion.Enabled = true;
                        dtpPacienteFechaDefuncion.Enabled = true;
                        btnLimpiarFechaDefuncion.Enabled = true;
                    }
                    else
                    {
                        chkValidadoSis.Enabled = false;
                        chkValidadoFissal.Enabled = false;
                    }
                }
            }
        }

        #endregion

        #region 'LOGICA DEL PROCESO'



        #endregion

        #region 'METODOS CONTROLES'

        private void Guardar()
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!(Convert.ToBoolean(objSolicitudAutorizacion.ValidadoSIS) || Convert.ToBoolean(objSolicitudAutorizacion.ValidadoFISSAL)))
                {
                    objSolicitudAutorizacion.SexoId = Convert.ToByte(cboPacienteSexo.SelectedValue);
                    objSolicitudAutorizacion.TipoDocumentoId = Convert.ToByte(cboPacienteTipoDocumento.SelectedValue);
                    objSolicitudAutorizacion.TipoRegimenId = Convert.ToByte(cboPacienteTipoRegimen.SelectedValue);
                    objSolicitudAutorizacion.ApellidoMaterno = txtPacienteApellidoMaterno.Text.Trim();
                    objSolicitudAutorizacion.ApellidoPaterno = txtPacienteApellidoPaterno.Text.Trim();
                    objSolicitudAutorizacion.Nacimiento = Convert.ToDateTime(txtPacienteFechaNacimiento.Text);
                    objSolicitudAutorizacion.Historia = txtPacienteHistoria.Text.Trim();
                    objSolicitudAutorizacion.Nombres = txtPacienteNombres.Text.Trim();
                    objSolicitudAutorizacion.NumeroDocumento = txtPacienteNumeroDocumento.Text.Trim();
                    objSolicitudAutorizacion.OtrosNombres = txtPacienteOtrosNombres.Text.Trim();
                    objSolicitudAutorizacion.Asegurado = chkAsegurado.Checked;
                    objSolicitudAutorizacion.Activo = chkActivo.Checked;
                }
                if (!string.Equals(txtPacienteFechaDefuncion.Text, string.Empty))
                    objSolicitudAutorizacion.fecha_defuncion = Convert.ToDateTime(txtPacienteFechaDefuncion.Text);
                else
                    objSolicitudAutorizacion.fecha_defuncion = null;
                objSolicitudAutorizacion.Recibido = true;
                objSolicitudAutorizacion.Usuario_Procesa = VariablesGlobales.Login;
                try
                {
                    int result = objSolicitudAutorizacionCabeceraBL.Actualizar(objSolicitudAutorizacion);
                    if (result > 0)
                    {
                        MessageBox.Show("Solicitud actualizada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        Salir();
                    }
                    else
                        throw new Exception();
                }
                catch
                {
                    MessageBox.Show("No se actualizo la solicitud", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay datos no validos en el formulario", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnviarDetalleSolicitud()
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                if (dgvDetallesSolicitudes.CurrentRow == null)
                    return;
                vw2_SolicitudAutorizacionDetalle obj = dgvDetallesSolicitudes.CurrentRow.DataBoundItem as vw2_SolicitudAutorizacionDetalle;
                vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle = objSolicitudAutorizacionDetalleBL.GetDetalleSolicitudPorNumeroSolicitudId(obj.Nro_Solicitud, obj.DetalleId);
                if (Convert.ToBoolean(objSolicitudAutorizacionDetalle.Procesado))
                    return;
                if (!(Convert.ToBoolean(objSolicitudAutorizacion.ValidadoSIS) || Convert.ToBoolean(objSolicitudAutorizacion.ValidadoFISSAL)))
                {
                    objSolicitudAutorizacion.SexoId = Convert.ToByte(cboPacienteSexo.SelectedValue);
                    objSolicitudAutorizacion.TipoDocumentoId = Convert.ToByte(cboPacienteTipoDocumento.SelectedValue);
                    objSolicitudAutorizacion.TipoRegimenId = Convert.ToByte(cboPacienteTipoRegimen.SelectedValue);
                    objSolicitudAutorizacion.ApellidoMaterno = txtPacienteApellidoMaterno.Text.Trim();
                    objSolicitudAutorizacion.ApellidoPaterno = txtPacienteApellidoPaterno.Text.Trim();
                    objSolicitudAutorizacion.Nacimiento = Convert.ToDateTime(txtPacienteFechaNacimiento.Text);
                    objSolicitudAutorizacion.Historia = txtPacienteHistoria.Text.Trim();
                    objSolicitudAutorizacion.Nombres = txtPacienteNombres.Text.Trim();
                    objSolicitudAutorizacion.NumeroDocumento = txtPacienteNumeroDocumento.Text.Trim();
                    objSolicitudAutorizacion.OtrosNombres = txtPacienteOtrosNombres.Text.Trim();
                    objSolicitudAutorizacion.Asegurado = chkAsegurado.Checked;
                    objSolicitudAutorizacion.Activo = chkActivo.Checked;
                }
                if (!txtPacienteFechaDefuncion.Text.Equals(string.Empty))
                    objSolicitudAutorizacion.fecha_defuncion = Convert.ToDateTime(txtPacienteFechaDefuncion.Text);
                else
                    objSolicitudAutorizacion.fecha_defuncion = null;
                objSolicitudAutorizacion.Recibido = true;
                objSolicitudAutorizacion.Usuario_Procesa = VariablesGlobales.Login;
                FrmGestionarAutorizaciones objFrmGestionarAutorizaciones = new FrmGestionarAutorizaciones(objSolicitudAutorizacion, objSolicitudAutorizacionDetalle);
                DialogResult dialogResult = objFrmGestionarAutorizaciones.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Solicitud Procesada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Salir();
                }
                if (dialogResult == DialogResult.Yes)
                    CargarDetallesSolicitudAutorizacion();
            }
            else
                MessageBox.Show("Hay datos no validos en el formulario", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Rechazar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de rechazar la solicitud?", "FISSAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    string observaciones = FuncionesBases.ShowDialogInputBox("Observacion", "FISSAL", string.Empty);
                    try
                    {
                        objSolicitudAutorizacionCabeceraBL.Rechazar(objSolicitudAutorizacion, listaSolicitudAutorizacionDetalle, observaciones);
                        MessageBox.Show("Solicitud rechazada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
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

        private void Salir()
        {
            this.Close();
            this.Dispose();
        }

        #endregion

        #region 'CARGA DE DATOS'

        private void CargarDatosSolicitudAutorizacion()
        {
            if (objSolicitudAutorizacion != null)
            {
                cboEstablecimiento.SelectedValue = objSolicitudAutorizacion.EstablecimientoId;
                cboPacienteSexo.SelectedValue = objSolicitudAutorizacion.SexoId;
                cboPacienteTipoDocumento.SelectedValue = objSolicitudAutorizacion.TipoDocumentoId;
                cboPacienteTipoRegimen.SelectedValue = objSolicitudAutorizacion.TipoRegimenId;
                txtDescripcion.Text = objSolicitudAutorizacion.Descripcion;
                txtFechaSolicitud.Text = Convert.ToDateTime(objSolicitudAutorizacion.Fecha_Solicitud).ToShortDateString();
                txtNumeroSolicitud.Text = objSolicitudAutorizacion.Nro_Solicitud;
                txtPacienteApellidoMaterno.Text = objSolicitudAutorizacion.ApellidoMaterno;
                txtPacienteApellidoPaterno.Text = objSolicitudAutorizacion.ApellidoPaterno;
                txtPacienteFechaDefuncion.Text = objSolicitudAutorizacion.fecha_defuncion.ToString();
                txtPacienteFechaNacimiento.Text = Convert.ToDateTime(objSolicitudAutorizacion.Nacimiento).ToShortDateString();
                txtPacienteHistoria.Text = objSolicitudAutorizacion.Historia;
                txtPacienteNombres.Text = objSolicitudAutorizacion.Nombres;
                txtPacienteNumeroDocumento.Text = objSolicitudAutorizacion.NumeroDocumento;
                txtPacienteOtrosNombres.Text = objSolicitudAutorizacion.OtrosNombres;
                txtUsuarioProcesa.Text = objSolicitudAutorizacion.Usuario_Procesa;
                txtUsuarioSolicitante.Text = objSolicitudAutorizacion.Usuario_Solicitante;
                chkActivo.Checked = Convert.ToBoolean(objSolicitudAutorizacion.Activo);
                chkAsegurado.Checked = Convert.ToBoolean(objSolicitudAutorizacion.Asegurado);
                chkValidadoFissal.Checked = Convert.ToBoolean(objSolicitudAutorizacion.ValidadoFISSAL);
                chkValidadoSis.Checked = Convert.ToBoolean(objSolicitudAutorizacion.ValidadoSIS);
                CargarDetallesSolicitudAutorizacion();
            }
            else
                MessageBox.Show("No ha cargado datos de la Solicitud de autorizacion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CargarDetallesSolicitudAutorizacion()
        {
            listaSolicitudAutorizacionDetalle = objSolicitudAutorizacionDetalleBL.GetDetallesSolicitudPorNumeroSolicitud(objSolicitudAutorizacion.Nro_Solicitud);
            dgvDetallesSolicitudes.DataSource = listaSolicitudAutorizacionDetalle;
            if (!(listaSolicitudAutorizacionDetalle.Count > 0))
                dgvDetallesSolicitudes.Visible = false;
        }

        #endregion

        #region 'VALIDACIONES'

        private bool EsNumeroDocumentoValido()
        {
            bool cancel = false;
            if (FuncionesBases.EsTextBoxVacio(txtPacienteNumeroDocumento, errorProvider1))
                cancel = true;
            else
            {
                string numeroDocumento = txtPacienteNumeroDocumento.Text.Trim();
                if (numeroDocumento.Length != 8 && cboPacienteTipoDocumento.SelectedValue.Equals(1))
                {
                    errorProvider1.SetError(txtPacienteNumeroDocumento, "Debe tener 8 caracteres");
                    cancel = true;
                }
            }
            return cancel;
        }

        private bool EsFechaNacimientoValida()
        {
            bool cancel = false;
            if (FuncionesBases.EsTextBoxVacio(txtPacienteFechaNacimiento, errorProvider1))
                cancel = true;
            if (FuncionesBases.ValidarFechaFin(txtPacienteFechaNacimiento, errorProvider1))
                cancel = true;
            return cancel;
        }

        #endregion

        #region 'EVENTOS FRM'

        private void FrmSolicitudAutorizacion_Load(object sender, EventArgs e)
        {
            CargarConfiguracionInicial();
            FuncionesBases.CargarCboEstablecimientoConConvenio(cboEstablecimiento);
            FuncionesBases.CargarComboTipoDoc(cboPacienteTipoDocumento);
            FuncionesBases.CargarComboRegimen(cboPacienteTipoRegimen);
            FuncionesBases.CargarCboSexo(cboPacienteSexo);
            CargarDatosSolicitudAutorizacion();
        }

        private void FrmSolicitudAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS CHK'

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
                chkAsegurado.Checked = true;
        }

        private void chkAsegurado_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsCheckBoxSinSeleccion(chkAsegurado, errorProvider1);
        }

        private void chkAsegurado_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(chkAsegurado, string.Empty);
        }

        #endregion

        #region 'EVENTOS BTN'

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tsBtnRechazar_Click(object sender, EventArgs e)
        {
            Rechazar();
        }

        private void btnLimpiarFechaNacimiento_Click(object sender, EventArgs e)
        {
            dtpPacienteFechaNacimiento.Value = DateTime.Now;
            txtPacienteFechaNacimiento.Clear();
        }

        private void btnLimpiarFechaDefuncion_Click(object sender, EventArgs e)
        {
            dtpPacienteFechaDefuncion.Value = DateTime.Now;
            txtPacienteFechaDefuncion.Clear();
        }

        #endregion

        #region 'EVENTOS DTP'

        private void dtpPacienteFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtPacienteFechaNacimiento.Text = dtpPacienteFechaNacimiento.Value.ToShortDateString();
        }

        private void dtpPacienteFechaDefuncion_ValueChanged(object sender, EventArgs e)
        {
            txtPacienteFechaDefuncion.Text = dtpPacienteFechaDefuncion.Value.ToShortDateString();
        }

        #endregion

        #region 'EVENTOS DGV'

        private void dgvDetallesSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarDetalleSolicitud();
        }

        private void dgvDetallesSolicitudes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarDetalleSolicitud();
                    break;
                case Keys.Back:
                    //
                    break;
            }
        }

        #endregion

        #region 'EVENTOS CBO'

        private void cboPacienteTipoDocumento_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboPacienteTipoDocumento, errorProvider1);
        }

        private void cboPacienteTipoDocumento_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboPacienteTipoDocumento, string.Empty);
        }

        private void cboPacienteSexo_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboPacienteSexo, errorProvider1);
        }

        private void cboPacienteSexo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboPacienteSexo, string.Empty);
        }

        private void cboPacienteTipoRegimen_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboPacienteTipoRegimen, errorProvider1);
        }

        private void cboPacienteTipoRegimen_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboPacienteTipoRegimen, string.Empty);
        }

        #endregion

        #region 'EVENTOS TXT'

        private void txtPacienteNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = EsNumeroDocumentoValido();
        }

        private void txtPacienteNumeroDocumento_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteNumeroDocumento, string.Empty);
        }

        private void txtPacienteFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = EsFechaNacimientoValida();
        }

        private void txtPacienteFechaNacimiento_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteFechaNacimiento, string.Empty);
        }

        private void txtPacienteApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtPacienteApellidoPaterno, errorProvider1);
        }

        private void txtPacienteApellidoPaterno_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteApellidoPaterno, string.Empty);
        }

        private void txtPacienteApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtPacienteApellidoMaterno, errorProvider1);
        }

        private void txtPacienteApellidoMaterno_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteApellidoMaterno, string.Empty);
        }

        private void txtPacienteNombres_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtPacienteNombres, errorProvider1);
        }

        private void txtPacienteNombres_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteNombres, string.Empty);
        }

        private void txtPacienteFechaDefuncion_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaFin(txtPacienteFechaDefuncion, errorProvider1);
        }

        private void txtPacienteFechaDefuncion_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteFechaDefuncion, string.Empty);
        }

        private void txtPacienteHistoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtPacienteNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtPacienteOtrosNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void txtPacienteNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void txtPacienteApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void txtPacienteApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void txtPacienteHistoria_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtPacienteHistoria, errorProvider1);
        }

        private void txtPacienteHistoria_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPacienteHistoria, string.Empty);
        }

        #endregion

    }
}
