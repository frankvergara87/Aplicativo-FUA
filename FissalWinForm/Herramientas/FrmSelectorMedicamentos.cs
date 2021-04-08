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
using System.Collections;

namespace FissalWinForm
{
    public partial class FrmSelectorMedicamentos : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        DataTable dtMedicamento;
        MedicamentoBL objMedicamentoBL = new MedicamentoBL();

        #endregion

        #region 'CONSTRUCTORES'

        public FrmSelectorMedicamentos()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        #endregion

        #region 'CONFIGURACION'

        private void InicializarComponentes()
        {
            this.CenterToParent();
            dgvMedicamentos.AutoGenerateColumns = false;
            this.KeyPreview = true;
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void AgregarMedicamentos()
        {
            if(!(dgvMedicamentos.RowCount > 0))
                return;
            DataGridViewRow row = dgvMedicamentos.CurrentRow;
            int length = dgvMedicamentosSeleccionados.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                DataGridViewRow row2 = dgvMedicamentosSeleccionados.Rows[i];
                if (row.Cells["MedicamentoId"].Value.Equals(row2.Cells["MedicamentoId_seleccionado"].Value))
                {
                    MessageBox.Show("EL medicamento ya ha sido seleccionado", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvMedicamentosSeleccionados.Rows.Add(new object[] { row.Cells["MedicamentoId"].Value, row.Cells["DigemidId"].Value, row.Cells["DescripcionSiga"].Value });
            dgvMedicamentos.Rows.Remove(row);
            dgvMedicamentosSeleccionados.Focus();
        }

        private void QuitarMedicamentos()
        {
            if(!(dgvMedicamentosSeleccionados.RowCount > 0))
                return;
            DataGridViewRow row = dgvMedicamentosSeleccionados.CurrentRow;
            DataRow datarow = dtMedicamento.NewRow();
            datarow["MedicamentoId"] = Convert.ToInt32(row.Cells["MedicamentoId_seleccionado"].Value);
            datarow["DigemidId"] = Convert.ToString(row.Cells["DigemidIdSeleccionado"].Value);
            datarow["DescripcionSiga"] = Convert.ToString(row.Cells["DescripcionSiga_seleccionado"].Value);
            dtMedicamento.Rows.Add(datarow);
            dgvMedicamentosSeleccionados.Rows.Remove(row);
            dgvMedicamentos.DataSource = dtMedicamento;
        }

        private void Buscar()
        {
            string medicamento = txtMedicamento.Text.Trim();
            if (!string.Equals(medicamento,string.Empty))
            {
                dtMedicamento = objMedicamentoBL.GetMedicamentosPorIdDescripcion(medicamento);
                dgvMedicamentos.DataSource = dtMedicamento;
                if (dtMedicamento.Rows.Count>0)
                    dgvMedicamentos.Focus();
            }
        }

        private void Aceptar()
        {
            if (dgvMedicamentosSeleccionados.RowCount > 0)
            {
                string[] lista = new string[dgvMedicamentosSeleccionados.RowCount];
                for (int i = 0; i < dgvMedicamentosSeleccionados.RowCount; i++)
                {
                    lista[i] = dgvMedicamentosSeleccionados.Rows[i].Cells["MedicamentoId_seleccionado"].Value.ToString();
                }
                string listaSeparadaPorComas = String.Join(",", lista);
                IFrmSelectorMedicamentos iFrmSelectorMedicamentos = this.Owner as IFrmSelectorMedicamentos;
                if(iFrmSelectorMedicamentos != null)
                    iFrmSelectorMedicamentos.ObtenerMedicamentos(listaSeparadaPorComas);
                Salir();
            }
            else
                MessageBox.Show("Seleccione por lo menos un procedimiento","FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarTextBox(this);
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmBuscadorMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtMedicamento.Focus();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtbx_medicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        #endregion

        #region 'EVENTOS btn'

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void tsBtnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #endregion

        #region 'EVENTOS dgv'

        private void dgvMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarMedicamentos();
                    break;
                case Keys.Back:
                    txtMedicamento.Focus();
                    break;
            }
        }

        private void dgvMedicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarMedicamentos();
        }

        private void dgvMedicamentos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMedicamentos.IsCurrentCellDirty)
                dgvMedicamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvMedicamentosSeleccionados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvMedicamentos.Focus();
                    break;
                case Keys.Delete:
                    QuitarMedicamentos();
                    break;
            }
        }

        private void dgvMedicamentosSeleccionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarMedicamentos();
        }

        private void dgvMedicamentosSeleccionados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMedicamentosSeleccionados.IsCurrentCellDirty)
                dgvMedicamentosSeleccionados.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

    }
}
