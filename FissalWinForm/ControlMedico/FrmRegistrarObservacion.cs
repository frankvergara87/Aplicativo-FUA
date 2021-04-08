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

namespace FissalWinForm
{
    public partial class FrmRegistrarObservacion : Form
    {
        #region 'CATEGORIA OBSERVACION'

        const int categoriaSinCategoria = 0;
        const int categoriaCabecera = 1;
        const int categoriaDiagnosticos = 2;
        const int categoriaProcedimientos = 3;
        const int categoriaMedicamentos = 4;

        #endregion

        ObservacionControlMedico objObservacionControlMedico;
        bool registrarCantidad = true;
        bool quitarObservacion = true;
        int categoriaObservacion = categoriaSinCategoria;


        public FrmRegistrarObservacion()
        {
            InitializeComponent();
        }

        public FrmRegistrarObservacion(bool registrarCantidad, bool quitarObservacion, int categoriaObservacion, ObservacionControlMedico objObservacionControlMedico)
            : this()
        {
            this.registrarCantidad = registrarCantidad;
            this.quitarObservacion = quitarObservacion;
            this.categoriaObservacion = categoriaObservacion;
            this.objObservacionControlMedico = objObservacionControlMedico;
        }

        private void CargarConfiguracion()
        {
            switch (categoriaObservacion)
            {
                case categoriaSinCategoria:
                    FuncionesBases.CargarCboTipoObservacion(cboTipoObservacion);
                    break;
                case categoriaDiagnosticos:
                    FuncionesBases.CargarCboTipoObservacionDetalleAtencion(cboTipoObservacion);
                    break;
                case categoriaProcedimientos:
                    FuncionesBases.CargarCboTipoObservacionProcedimientoAtencion(cboTipoObservacion);
                    break;
                case categoriaMedicamentos:
                    FuncionesBases.CargarCboTipoObservacionMedicamentoAtencion(cboTipoObservacion);
                    break;
            }
            CargarDatosObservacion();
            if (!registrarCantidad)
                txtCantidadObservada.Enabled = Convert.ToBoolean(bool.FalseString);
            if (!quitarObservacion)
            {
                tsBtnQuitarObservacion.Enabled = false;
                txtCantidadObservada.Enabled = false;
            }
            txtDescripcionDetalle.Enabled = Convert.ToBoolean(bool.FalseString);
            txtCantidadDetalle.Enabled = Convert.ToBoolean(bool.FalseString);
            this.CenterToParent();
            toolStrip1.TabStop = Convert.ToBoolean(bool.TrueString);
            this.KeyPreview = Convert.ToBoolean(bool.TrueString);
            this.AutoValidate = AutoValidate.Disable;
        }

        private void CargarDatosObservacion()
        {
            if (objObservacionControlMedico != null)
            {
                txtDescripcionDetalle.Text = objObservacionControlMedico.DescripcionDetalle;
                txtCantidadDetalle.Text = objObservacionControlMedico.CantidadDetalle.ToString();
                cboTipoObservacion.SelectedValue = objObservacionControlMedico.TipoObservacion;
                if (cboTipoObservacion.SelectedValue == null)
                    cboTipoObservacion.SelectedIndex = 0;
                txtCantidadObservada.Text = objObservacionControlMedico.CantidadObservada.ToString();
                txtDescripcionObservacion.Text = objObservacionControlMedico.DescripcionObservacion;
            }
        }

        private void FrmRegistrarObservaciones_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        private void Observar()
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                ObservacionControlMedico objObservacionControlMedico = new ObservacionControlMedico();
                objObservacionControlMedico.TipoObservacion = Convert.ToInt32(cboTipoObservacion.SelectedValue);
                if (!string.Equals(txtCantidadObservada.Text, string.Empty))
                    objObservacionControlMedico.CantidadObservada = Convert.ToInt32(txtCantidadObservada.Text.Trim());
                objObservacionControlMedico.DescripcionObservacion = txtDescripcionObservacion.Text.Trim();
                IFrmRegistrarObservacion iFrmRegistrarObservacion = this.Owner as IFrmRegistrarObservacion;
                if (iFrmRegistrarObservacion != null)
                {
                    iFrmRegistrarObservacion.ObtenerObservacion(objObservacionControlMedico);
                    this.DialogResult = DialogResult.OK;
                }
                Salir();
            }
            else
                MessageBox.Show("Hay datos no válidos en el formulario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsBtnAceptar_Click(object sender, EventArgs e)
        {
            Observar();
        }

        private void FrmRegistrarObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        private void cboTipoObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (txtCantidadObservada.Enabled)
                        txtCantidadObservada.Focus();
                    else
                        txtDescripcionObservacion.Focus();
                    break;
            }
        }

        private void txtCantidadObservada_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtDescripcionObservacion.Focus();
                    break;
            }
        }

        private void txtCantidadObservada_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtDescripcionObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Observar();
                    break;
            }
        }

        private void cboTipoObservacion_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboTipoObservacion, errorProvider1);
        }

        private void cboTipoObservacion_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboTipoObservacion, string.Empty);
        }

        private void txtCantidadObservada_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = EsCantidadObservadaNoValida();
        }

        private void txtCantidadObservada_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCantidadObservada, string.Empty);
        }

        private bool EsCantidadObservadaNoValida()
        {
            bool cancel = false;
            if (FuncionesBases.EsTextBoxVacio(txtCantidadObservada, errorProvider1))
                cancel = true;
            else
            {
                int cantidad = Convert.ToInt32(txtCantidadObservada.Text.Trim());
                if (cantidad == 0)
                {
                    errorProvider1.SetError(txtCantidadObservada, "Debe ser mayor que 0");
                    cancel = true;
                }
                if (cantidad > objObservacionControlMedico.CantidadDetalle)
                {
                    errorProvider1.SetError(txtCantidadObservada, "No puede ser mayor que la cantidad");
                    cancel = true;
                }
            }

            return cancel;
        }

        private bool EsDescripcionNoValida()
        {
            bool cancel = Convert.ToBoolean(bool.FalseString);
            string descripcion = txtDescripcionObservacion.Text.Trim();
            if (descripcion.Length>200)
            {
                errorProvider1.SetError(txtDescripcionObservacion, "Debe tener menos de 200 caracteres");
                cancel = Convert.ToBoolean(bool.TrueString);
            }
            return cancel;
        }

        private void txtDescripcionObservacion_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = EsDescripcionNoValida();
        }

        private void txtDescripcionObservacion_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDescripcionObservacion, string.Empty);
        }

        private void tsBtnQuitarObservacion_Click(object sender, EventArgs e)
        {
            QuitarObservacion();
        }

        private void QuitarObservacion()
        {
            ObservacionControlMedico objObservacionControlMedico = new ObservacionControlMedico();
            objObservacionControlMedico.TipoObservacion = 0;
            objObservacionControlMedico.CantidadObservada = 0;
            objObservacionControlMedico.DescripcionObservacion = string.Empty;
            IFrmRegistrarObservacion iFrmRegistrarObservacion = this.Owner as IFrmRegistrarObservacion;
            if (iFrmRegistrarObservacion != null)
            {
                iFrmRegistrarObservacion.ObtenerObservacion(objObservacionControlMedico);
                this.DialogResult = DialogResult.OK;
            }
            Salir();
        }
    }
}
