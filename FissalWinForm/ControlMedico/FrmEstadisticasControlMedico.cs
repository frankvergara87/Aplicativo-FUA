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

namespace FissalWinForm
{
    public partial class FrmEstadisticasControlMedico : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        DataTable dtEstadisticas;

        public struct Opcion
        {
            public string clave { get; set; }
            public string valor { get; set; }
        }

        #endregion

        #region 'CONSTRUCTORES'

        public FrmEstadisticasControlMedico()
        {
            InitializeComponent();
            tsPgsBarBuscador.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            this.AutoValidate = AutoValidate.Disable;
        }

        #endregion

        #region 'CARGA DE DATOS'

        private void CargarCboTipoEstadistica()
        {
            List<Opcion> lista = new List<Opcion>(4);
            Opcion opcion0 = new Opcion();
            opcion0.clave = string.Empty;
            opcion0.valor = "--SELECCIONE--";
            Opcion opcion1 = new Opcion();
            opcion1.clave = "1";
            opcion1.valor = "ATENCIONES SUPERVISADAS";
            Opcion opcion2 = new Opcion();
            opcion2.clave = "2";
            opcion2.valor = "ATENCIONES SUPERVISADAS POR IPRESS";
            Opcion opcion3 = new Opcion();
            opcion3.clave = "3";
            opcion3.valor = "ATENCIONES SUPERVISADAS POR AUDITOR";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            lista.Add(opcion3);
            cboTipoEstadistica.DataSource = lista;
            cboTipoEstadistica.ValueMember = "clave";
            cboTipoEstadistica.DisplayMember = "valor";
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void Buscar()
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                dgvEstadisticas.DataSource = null;
                string tipoEstadistica = Convert.ToString(cboTipoEstadistica.SelectedValue);
                switch (tipoEstadistica)
                {
                    case "1":
                        dtEstadisticas = objMovimientoPacienteBL.GetCantidadAtencionesSupervisadas();
                        break;
                    case "2":
                        dtEstadisticas = objMovimientoPacienteBL.GetCantidadAtencionesSupervisadasPorIPRESS();
                        break;
                    case "3":
                        dtEstadisticas = objMovimientoPacienteBL.GetCantidadAtencionesSupervisadasPorAuditor();
                        break;
                }
                dgvEstadisticas.DataSource = dtEstadisticas;
            }
            else
                MessageBox.Show("Hay datos no válidos en el formulario", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Salir()
        {
            this.Close();
            this.Dispose();
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarControles(this);
            errorProvider1.Clear();
            if (dtEstadisticas != null)
            {
                dtEstadisticas.Clear();
                dgvEstadisticas.DataSource = dtEstadisticas;
            }
        }

        #endregion

        #region 'EVENTOS cbo'

        private void cboTipoEstadistica_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsComboBoxSinSeleccion(cboTipoEstadistica, errorProvider1);
        }

        private void cboTipoEstadistica_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboTipoEstadistica, string.Empty);
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmEstadisticasControlMedico_Load(object sender, EventArgs e)
        {
            CargarCboTipoEstadistica();
        }

        #endregion

        #region 'EVENTOS btn'

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            FuncionesBases.ExportarExcel(dtEstadisticas, tsPgsBarBuscador, tsslMensajePgsBarBuscador);
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        #endregion

        #region 'EVENTOS dgv'

        private void dgvEstadisticas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvEstadisticas, tsslTotalRegistros);
        }

        #endregion

        private void cboTipoEstadistica_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
                case Keys.Back:
                    toolStrip1.Focus();
                    break;
            }
        }

    }
}
