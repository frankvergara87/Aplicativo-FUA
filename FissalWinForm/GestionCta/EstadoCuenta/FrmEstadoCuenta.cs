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


/*ELABORADO POR: DANILO RAMIREZ*/

namespace FissalWinForm
{
    public partial class FrmEstadoCuenta : Form
    {
        EstadoCuentaConciliacion objEstadoCuentaConciliacion = null;
        struct Estado { public string clave { get; set; } public string valor { get; set; } }

        public FrmEstadoCuenta()
        {
            InitializeComponent();
            this.CenterToParent();
            txtCuentaCadenaId.ReadOnly = true;
            txtCuentaEstablecimientoId.ReadOnly = true;
            txtCuentaPacienteId.ReadOnly = true;
            cboPacienteVivo.Enabled = false;
            cboPacienteActivoFissal.Enabled = false;
        }

        public FrmEstadoCuenta(EstadoCuentaConciliacion objEstadoCuentaConciliacion) :this()
        {
            this.objEstadoCuentaConciliacion = objEstadoCuentaConciliacion;
        }

        private List<Estado> CargarEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            Estado objEstado1 = new Estado();
            objEstado1.clave = "Pendiente";
            objEstado1.valor = "Pendiente";
            Estado objEstado2 = new Estado();
            objEstado2.clave = "Si";
            objEstado2.valor = "Si";
            Estado objEstado3 = new Estado();
            objEstado3.clave = "No";
            objEstado3.valor = "No";
            listaEstados.Add(objEstado1);
            listaEstados.Add(objEstado2);
            listaEstados.Add(objEstado3);
            return listaEstados;
        }

        private void CargarCbosEstados(ComboBox cbo)
        {
            cbo.DataSource = CargarEstados();
            cbo.ValueMember = "clave";
            cbo.DisplayMember = "valor";    
        }

        private void FrmEstadoCuenta_Load(object sender, EventArgs e)
        {
            CargarCbosEstados(cboPacienteVivo);
            CargarCbosEstados(cboPacienteActivoSis);
            CargarCbosEstados(cboPacienteActivoFissal);
            CargarDatosCuenta();
        }

        private void CargarDatosCuenta()
        {
            txtCuentaCadenaId.Text = objEstadoCuentaConciliacion.CadenaId.ToString();
            txtCuentaEstablecimientoId.Text = objEstadoCuentaConciliacion.EstablecimientoId.ToString();
            txtCuentaPacienteId.Text = objEstadoCuentaConciliacion.PacienteId.ToString();
            cboPacienteActivoFissal.SelectedValue = objEstadoCuentaConciliacion.ActivoFissal;
            cboPacienteActivoSis.SelectedValue = objEstadoCuentaConciliacion.ActivoSis;
            cboPacienteVivo.SelectedValue = objEstadoCuentaConciliacion.NoFallecido;
        }

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
                EstadoCuentaConciliacionBL objEstadoCuentaConciliacionBL = new EstadoCuentaConciliacionBL();
                string pacienteId = txtCuentaPacienteId.Text.Trim();
                string activoSis = string.Empty;
                if(cboPacienteActivoSis.SelectedValue.Equals("Si"))
                    activoSis = "1";
                else
                    activoSis = "0";
                int codigoConciliacion = objEstadoCuentaConciliacion.CodigoConciliacion;
                int result = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoSIS(pacienteId,activoSis,codigoConciliacion);
                if (result > 0)
                {
                    MessageBox.Show("Se actualizo el estado Activo SIS", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Salir();
                }
                else
                    MessageBox.Show("No se actualizo el estado Activo SIS", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Hay datos no válidos en el formulario", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cboPacienteActivoSis_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboPacienteActivoSis, errorProvider1);
        }

        private void FrmEstadoCuenta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboPacienteActivoSis, string.Empty);
        }

        private void Salir()
        {
            this.Dispose();
            this.Close();
        }

        private void tsBtnCancelar_Click(object sender, EventArgs e)
        {
            Salir();
        }

    }
}
