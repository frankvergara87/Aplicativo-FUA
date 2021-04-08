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

namespace FissalWinForm
{
    public partial class FrmSolicitudesAutorizacion : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        SolicitudAutorizacionCabeceraBL objSolicitudAutorizacionCabeceraBL = new SolicitudAutorizacionCabeceraBL();
        List<vw2_SolicitudAutorizacion> listaSolicitudes;

        #endregion

        #region 'CONSTRUCTORES'

        public FrmSolicitudesAutorizacion()
        {
            InitializeComponent();
            CargarConfiguracionInicial();   
        }

        #endregion

        #region 'CONFIGURACION'

        private void CargarConfiguracionInicial()
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.AutoValidate = AutoValidate.Disable;
            toolStrip1.TabStop = true;
            tsPgsBarBuscador.Visible = false;
            dgvSolicitudes.AutoGenerateColumns = false;
        }

        #endregion

        #region 'LOGICA DEL PROCESO'

        private void EnviarSolicitud()
        {
            if (dgvSolicitudes.CurrentRow == null)
                return;
            vw2_SolicitudAutorizacion obj = dgvSolicitudes.CurrentRow.DataBoundItem as vw2_SolicitudAutorizacion;
            vw2_SolicitudAutorizacion objSolicitudAutorizacion = objSolicitudAutorizacionCabeceraBL.GetSolicitudAutorizacionPorId(obj.Nro_Solicitud);
            FrmSolicitudAutorizacion objFrmSolicitudAutorizacion = new FrmSolicitudAutorizacion(objSolicitudAutorizacion);
            DialogResult dialogResult = objFrmSolicitudAutorizacion.ShowDialog();
            if (dialogResult == DialogResult.OK)
                Buscar();
        }

        #endregion

        #region 'VALIDACIONES'
        #endregion

        #region 'CARGA DE DATOS'

        private void CargarDgvSolicitudes()
        {
            listaSolicitudes = objSolicitudAutorizacionCabeceraBL.GetAllSolicitudesAutorizacion();
            dgvSolicitudes.DataSource = listaSolicitudes;
            if (!(listaSolicitudes.Count > 0))
                MessageBox.Show("No hay solicitudes pendientes", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void Buscar()
        {
            if (cboEstablecimiento.SelectedIndex.Equals(0))
                CargarDgvSolicitudes();
            else
            {
                int establecimientoId = Convert.ToInt32(cboEstablecimiento.SelectedValue);
                listaSolicitudes = objSolicitudAutorizacionCabeceraBL.GetSolicitudesAutorizacionPorIpress(establecimientoId);
                dgvSolicitudes.DataSource = listaSolicitudes;
                if (!(listaSolicitudes.Count > 0))
                    MessageBox.Show("No se han encontrado resultados para tu busqueda", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region 'EVENTOS FRM'

        private void FrmSolicitudesAutorizacion_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboEstablecimientoConConvenio(cboEstablecimiento);
            CargarDgvSolicitudes();
        }

        #endregion

        #region 'EVENTOS BTN'

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            FuncionesBases.ExportarExcel(dgvSolicitudes, tsPgsBarBuscador, tsslMensajePgsBarBuscador);
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        #endregion

        #region 'EVENTOS CBO'

        private void cboEstablecimiento_KeyDown(object sender, KeyEventArgs e)
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

        #endregion

        #region 'EVENTOS DGV'

        private void dgvSolicitudes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvSolicitudes, tsslTotalRegistros);
        }

        private void dgvSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarSolicitud();
        }

        private void dgvSolicitudes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarSolicitud();
                    break;
                case Keys.Back:
                    cboEstablecimiento.Focus();
                    break;
            }
        }

        #endregion

    }
}
