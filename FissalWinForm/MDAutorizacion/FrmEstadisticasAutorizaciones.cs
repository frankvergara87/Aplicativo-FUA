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
    public partial class FrmEstadisticasAutorizaciones : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        DataTable dtEstadisticas;
        DataView dvEstadisticas;

        public struct Opcion
        {
            public string clave { get; set; }
            public string valor { get; set; }
        }

        #endregion

        #region 'CONSTRUCTORES'

        public FrmEstadisticasAutorizaciones()
        {
            InitializeComponent();
            tsPgsBarBuscador.Visible = Convert.ToBoolean(bool.FalseString);
            txtFiltroEstadistica.Enabled = Convert.ToBoolean(bool.FalseString);
            tsBtnBuscar.Enabled = Convert.ToBoolean(bool.FalseString);
            this.CenterToScreen();
        }

        #endregion
        
        #region 'METODOS CARGA DE DATOS'

        private void CargarCboTipoEstadistica()
        {
            List<Opcion> lista = new List<Opcion>(5);
            Opcion opcion0 = new Opcion();
            opcion0.clave = string.Empty;
            opcion0.valor = "--SELECCIONE--";
            Opcion opcion1 = new Opcion();
            opcion1.clave = "1";
            opcion1.valor = "AUTORIZACIONES POR AÑO";
            Opcion opcion2 = new Opcion();
            opcion2.clave = "2";
            opcion2.valor = "AUTORIZACIONES POR AÑO/MES";
            Opcion opcion3 = new Opcion();
            opcion3.clave = "3";
            opcion3.valor = "AUTORIZACIONES POR IPRESS";
            Opcion opcion4 = new Opcion();
            opcion4.clave = "4";
            opcion4.valor = "AUTORIZACIONES POR PACIENTE";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            lista.Add(opcion3);
            lista.Add(opcion4);
            cboTipoEstadistica.DataSource = lista;
            cboTipoEstadistica.ValueMember = "clave";
            cboTipoEstadistica.DisplayMember = "valor";
        }

        private void CargarDgvEstadisticas(string opcion)
        {
            dgvEstadisticas.DataSource = null;
            switch (opcion)
            {
                case "":
                    txtFiltroEstadistica.Clear();
                    txtFiltroEstadistica.Enabled = Convert.ToBoolean(bool.FalseString);
                    tsBtnBuscar.Enabled = Convert.ToBoolean(bool.FalseString);
                    return;
                case "1":
                    dtEstadisticas = objAutorizacionBL.GetCantidadMontoAutorizacionesPorAño();
                    break;
                case "2":
                    dtEstadisticas = objAutorizacionBL.GetCantidadMontoAutorizacionesPorAñoMes();
                    break;
                case "3":
                    dtEstadisticas = objAutorizacionBL.GetCantidadMontoAutorizacionesPorIPRESS();
                    break;
                case "4":
                    dtEstadisticas = objAutorizacionBL.GetCantidadMontoAutorizacionesPorPaciente();
                    break;
            }
            txtFiltroEstadistica.Enabled = Convert.ToBoolean(bool.TrueString);
            tsBtnBuscar.Enabled = Convert.ToBoolean(bool.TrueString);
            dvEstadisticas = dtEstadisticas.DefaultView;
            dgvEstadisticas.DataSource = dvEstadisticas;
        }

        #endregion

        #region 'METODOS BL'
        #endregion

        #region 'METODOS CONTROLES'

        private void Buscar()
        {
            dvEstadisticas.RowFilter = string.Empty;
            string filtro = string.Empty;
            int opcion = Convert.ToInt32(cboTipoEstadistica.SelectedValue);
            string datoFiltro = txtFiltroEstadistica.Text.Trim();
            switch (opcion)
            {
                case 1:
                    filtro = string.Format("Convert(Año,'System.String') like '%{0}%'", datoFiltro);
                    break;
                case 2:
                    filtro = string.Format("Convert(Año,'System.String') like '%{0}%' or Mes like '%{0}%'", datoFiltro);
                    break;
                case 3:
                    filtro = string.Format("Convert(CodigoIPRESS, 'System.String') like '%{0}%' or IPRESS like '%{0}%'", datoFiltro);
                    break;
                case 4:
                    filtro = string.Format("DocumentoPaciente like '%{0}%' or Paciente like '%{0}%'", datoFiltro);
                    break;
            }
            dvEstadisticas.RowFilter = filtro;
        }

        private void Salir()
        {
            this.Close();
            this.Dispose();
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarTextBox(this);
            FuncionesBases.LimpiarComboBox(this);
        }

        #endregion

        #region 'EVENTOS cbo'

        private void cboTipoEstadistica_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgvEstadisticas(cboTipoEstadistica.SelectedValue.ToString());
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmEstadisticasAutorizaciones_Load(object sender, EventArgs e)
        {
            CargarCboTipoEstadistica();
            this.cboTipoEstadistica.SelectedValueChanged += new System.EventHandler(this.cboTipoEstadistica_SelectedValueChanged);
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtFiltroEstadistica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        #endregion

        #region 'EVENTOS btn'

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            FuncionesBases.ExportarExcel(dgvEstadisticas, tsPgsBarBuscador, tsslMensajePgsBarBuscador);
        }

        #endregion

        #region 'EVENTOS dgv'

        private void dgvEstadisticas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvEstadisticas, tsslTotalRegistros);
        }

        #endregion

    }
}
