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
    public partial class FrmEstadisticasAtendidosSis : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        AtencionCierreBL objAtencionCierreBL = new AtencionCierreBL();
        DataTable dtEstadisticas;

        public struct Opcion
        {
            public string clave { get; set; }
            public string valor { get; set; }
        }

        #endregion

        #region 'CONSTRUCTORES'

        public FrmEstadisticasAtendidosSis()
        {
            InitializeComponent();
            tsPgsBarBuscador.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            this.AutoValidate = AutoValidate.Disable;
            txtFechaProduccionDesde.ReadOnly = true;
            txtFechaProduccionHasta.ReadOnly = true;
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
            opcion1.valor = "ATENDIDOS POR REGION";
            Opcion opcion2 = new Opcion();
            opcion2.clave = "2";
            opcion2.valor = "ATENDIDOS POR CATEGORIA";
            Opcion opcion3 = new Opcion();
            opcion3.clave = "3";
            opcion3.valor = "ATENDIDOS POR REGION/CATEGORIA";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            lista.Add(opcion3);
            cboTipoEstadistica.DataSource = lista;
            cboTipoEstadistica.ValueMember = "clave";
            cboTipoEstadistica.DisplayMember = "valor";
        }

        private void CargarCboMecanismoFinanciamiento()
        {
            List<Opcion> lista = new List<Opcion>(4);
            Opcion opcion0 = new Opcion();
            opcion0.clave = string.Empty;
            opcion0.valor = "--SELECCIONE--";
            Opcion opcion1 = new Opcion();
            opcion1.clave = "P";
            opcion1.valor = "PROSPECTIVO";
            Opcion opcion2 = new Opcion();
            opcion2.clave = "R";
            opcion2.valor = "RETROSPECTIVO";
            Opcion opcion3 = new Opcion();
            opcion3.clave = "H";
            opcion3.valor = "PROSPECTIVO/RETROSPECTIVO";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            lista.Add(opcion3);
            cboMecanismoFinanciamiento.DataSource = lista;
            cboMecanismoFinanciamiento.ValueMember = "clave";
            cboMecanismoFinanciamiento.DisplayMember = "valor";
        }

        #endregion

        #region 'LOGICA DEL PROCESO'
        #endregion

        #region 'METODOS CONTROLES'

        private void Buscar()
        {
            if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
                dgvEstadisticas.DataSource = null;
                string tipoEstadistica = string.Empty;
                string region;
                int? categoria = null;
                string mecanismoFinanciamiento;
                DateTime? fechaProduccionDesde = null;
                DateTime? fechaProduccionHasta = null;
                bool omitir;
                tipoEstadistica = Convert.ToString(cboTipoEstadistica.SelectedValue);
                region = Convert.ToString(cboRegion.SelectedValue);
                if (!cboCategoria.SelectedIndex.Equals(-1) && !cboCategoria.SelectedIndex.Equals(0))
                    categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                mecanismoFinanciamiento = Convert.ToString(cboMecanismoFinanciamiento.SelectedValue);
                if(!string.Equals(txtFechaProduccionDesde.Text.Trim(), string.Empty))
                    fechaProduccionDesde = Convert.ToDateTime(txtFechaProduccionDesde.Text.Trim());
                if (!string.Equals(txtFechaProduccionHasta.Text.Trim(), string.Empty))
                    fechaProduccionHasta = Convert.ToDateTime(txtFechaProduccionHasta.Text.Trim());
                omitir = chkOmitir.Checked;
                switch (tipoEstadistica)
                {
                    case "1":
                        dtEstadisticas = objAtencionCierreBL.GetCantidadAtendidosPorRegion(region, mecanismoFinanciamiento, fechaProduccionDesde, fechaProduccionHasta, omitir);
                        break;
                    case "2":
                        dtEstadisticas = objAtencionCierreBL.GetCantidadAtendidosPorCategoria(categoria, mecanismoFinanciamiento, fechaProduccionDesde, fechaProduccionHasta, omitir);
                        break;
                    case "3":
                        dtEstadisticas = objAtencionCierreBL.GetCantidadAtendidosPorRegionCategoria(region, categoria, mecanismoFinanciamiento, fechaProduccionDesde, fechaProduccionHasta, omitir);
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
            dtpFechaProduccionDesde.Value = DateTime.Now;
            dtpFechaProduccionHasta.Value = DateTime.Now;
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

        private void cboTipoEstadistica_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cboTipoEstadistica.SelectedValue).Equals("1"))
            {
                cboRegion.Enabled = true;
                cboCategoria.SelectedIndex = 0;
                cboCategoria.Enabled = false;
            }
            if (Convert.ToString(cboTipoEstadistica.SelectedValue).Equals("2"))
            {
                cboCategoria.Enabled = true;
                cboRegion.SelectedIndex = 0;
                cboRegion.Enabled = false;
            }
            if (Convert.ToString(cboTipoEstadistica.SelectedValue).Equals("3"))
            {
                cboRegion.Enabled = true;
                cboCategoria.Enabled = true;
            }
            if (Convert.ToString(cboTipoEstadistica.SelectedValue).Equals(string.Empty))
            {
                cboRegion.SelectedIndex = 0;
                cboCategoria.SelectedIndex = 0;
                cboRegion.Enabled = false;
                cboCategoria.Enabled = false;
            }
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmEstadisticasAtencionesSis_Load(object sender, EventArgs e)
        {
            CargarCboTipoEstadistica();
            FuncionesBases.CargarCboRegion(cboRegion);
            FuncionesBases.CargarCboGrupoCategoria(cboCategoria);
            CargarCboMecanismoFinanciamiento();
            cboRegion.Enabled = false;
            cboCategoria.Enabled = false;
            dtpFechaProduccionDesde.Enabled = false;
            dtpFechaProduccionHasta.Enabled = false;
            btnLimpiarFechaProduccionDesde.Enabled = false;
            btnLimpiarFechaProduccionHasta.Enabled = false;
            this.cboTipoEstadistica.SelectedValueChanged += new System.EventHandler(this.cboTipoEstadistica_SelectedValueChanged);
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtFechaProduccionDesde_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaInicio(txtFechaProduccionDesde, txtFechaProduccionHasta, errorProvider1);
        }

        private void txtFechaProduccionDesde_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaProduccionDesde, string.Empty);
        }

        private void txtFechaProduccionHasta_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaFin(txtFechaProduccionHasta, errorProvider1);
        }

        private void txtFechaProduccionHasta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaProduccionHasta, string.Empty);
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

        private void btnLimpiarFechaProduccionDesde_Click(object sender, EventArgs e)
        {
            dtpFechaProduccionDesde.Value = DateTime.Now;
            txtFechaProduccionDesde.Clear();
        }

        private void btnLimpiarFechaProduccionHasta_Click(object sender, EventArgs e)
        {
            dtpFechaProduccionHasta.Value = DateTime.Now;
            txtFechaProduccionHasta.Clear();
        }
        
        #endregion

        #region 'EVENTOS dgv'

        private void dgvEstadisticas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvEstadisticas, tsslTotalRegistros);
        }

        #endregion

        #region 'EVENTOS DTP'

        private void dtpFechaProduccionDesde_ValueChanged(object sender, EventArgs e)
        {
            txtFechaProduccionDesde.Text = dtpFechaProduccionDesde.Value.ToShortDateString();
        }

        private void dtpFechaProduccionHasta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaProduccionHasta.Text = dtpFechaProduccionHasta.Value.ToShortDateString();
        }

        #endregion

    }
}
