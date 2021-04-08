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
    public partial class FrmSelectorControlesMedicos : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        DataTable dtControlMedico;
        ControlMedicoLogBL objControlMedicoLogBL = new ControlMedicoLogBL();
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();
        

        #endregion
        
        #region 'CONSTRUCTORES'

        public FrmSelectorControlesMedicos()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        #endregion

        #region 'CARGA DE DATOS'

        private void CargarDgvControlesMedicos()
        {
            dtControlMedico = objProduccionEstablecimientoBL.ProduccionEstablecimiento_CodigoCtrlMedListar();
            dgvControlesMedicos.DataSource = dtControlMedico;
            if (!(dtControlMedico.Rows.Count > 0))
            {
                dgvControlesMedicos.Visible = false;
                grpBoxProduccionesSupervision.Visible = false;
                lblMensajeControlesMedicos.Visible = true;
            }
        }

        #endregion

        #region 'METODOS DE CONFIGURACION'

        private void CargarConfiguracion()
        {
            this.CenterToParent();
            dgvControlesMedicos.AutoGenerateColumns = false;
            dgvDetalleControlesMedicos.AutoGenerateColumns = false;
            this.KeyPreview = true;
            lblMensajeControlesMedicos.Visible = false;
        }

        #endregion

        #region 'METODOS CONTROLES'
        
        private void Aceptar()
        {
            if (dgvDetalleControlesMedicos.RowCount > 0)
            {
                string codigoControlMedico = dgvControlesMedicos.CurrentRow.Cells[0].Value.ToString();
                string fechaInicioControlMedico = dgvControlesMedicos.CurrentRow.Cells[1].Value.ToString();
                string fechaFinControlMedico = dgvControlesMedicos.CurrentRow.Cells[2].Value.ToString();
                IFrmSelectorControlesMedicos iFrmSelectorControlesMedicos = this.Owner as IFrmSelectorControlesMedicos;
                if (iFrmSelectorControlesMedicos != null)
                    iFrmSelectorControlesMedicos.ObtenerControlesMedicos(codigoControlMedico, fechaInicioControlMedico, fechaFinControlMedico);
                Salir();
            }
            else
                MessageBox.Show("Para aceptar seleccione por lo menos un control medico", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmSelectorControlesMedicos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        private void FrmSelectorControlesMedicos_Load(object sender, EventArgs e)
        {
            CargarDgvControlesMedicos();
        }

        #endregion

        #region 'EVENTOS btn'

        private void tsBtnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        #endregion

        #region 'EVENTOS DGV'

        private void dgvControlesMedicos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
            }
        }

        private void dgvControlesMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            Aceptar();
        }

        private void dgvControlesMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int codigoControlMedico = Convert.ToInt32(dgvControlesMedicos.CurrentRow.Cells[0].Value);
            dgvDetalleControlesMedicos.DataSource = objProduccionEstablecimientoBL.GetProduccionesControlPorControlMedico(codigoControlMedico);
        }
        
        #endregion

    }
}
