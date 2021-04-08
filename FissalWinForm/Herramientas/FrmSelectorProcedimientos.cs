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
    public partial class FrmSelectorProcedimientos : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        DataTable dtProcedimiento;
        ProcedimientoBL objProcedimientoBL = new ProcedimientoBL();

        #endregion

        #region 'CONSTRUCTORES'

        public FrmSelectorProcedimientos()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        #endregion

        #region 'CONFIGURACION'

        private void InicializarComponentes()
        {
            this.CenterToParent();
            dgvProcedimientos.AutoGenerateColumns = false;
            this.KeyPreview = true;
        }

        #endregion

        #region 'METODOS CONTROLES'
        private void AgregarProcedimientos()
        {
            if (!(dgvProcedimientos.RowCount > 0))
                return;
            DataGridViewRow row = dgvProcedimientos.CurrentRow;
            int length = dgvProcedimientosSeleccionados.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                DataGridViewRow row2 = dgvProcedimientosSeleccionados.Rows[i];
                if (row.Cells["ProcedimientoId"].Value.Equals(row2.Cells["ProcedimientoId_seleccionado"].Value))
                {
                    MessageBox.Show("EL procedimiento ya ha sido seleccionado", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvProcedimientosSeleccionados.Rows.Add(new object[] { row.Cells["ProcedimientoId"].Value, row.Cells["SisId"].Value, row.Cells["Descripcion"].Value });
            dgvProcedimientos.Rows.Remove(row);
            dgvProcedimientosSeleccionados.Focus();
        }

        private void QuitarProcedimientos()
        {
            if(!(dgvProcedimientosSeleccionados.RowCount > 0))
                return;
            DataGridViewRow row = dgvProcedimientosSeleccionados.CurrentRow;
            DataRow datarow = dtProcedimiento.NewRow();
            datarow["ProcedimientoId"] = Convert.ToInt32(row.Cells["ProcedimientoId_seleccionado"].Value);
            datarow["SisId"] = Convert.ToString(row.Cells["SisIdSeleccionado"].Value);
            datarow["Descripcion"] = Convert.ToString(row.Cells["Descripcion_seleccionado"].Value);
            dtProcedimiento.Rows.Add(datarow);
            dgvProcedimientosSeleccionados.Rows.Remove(row);
            dgvProcedimientos.DataSource = dtProcedimiento;
        }

        private void Aceptar()
        {
            if (dgvProcedimientosSeleccionados.RowCount > 0)
            {
                string[] lista = new string[dgvProcedimientosSeleccionados.RowCount];
                for (int i = 0; i < dgvProcedimientosSeleccionados.RowCount; i++)
                {
                    lista[i] = dgvProcedimientosSeleccionados.Rows[i].Cells["ProcedimientoId_seleccionado"].Value.ToString();
                }
                string listaSeparadaPorComas = String.Join(",", lista);
                IFrmSelectorProcedimientos iFrmSelectorProcedimientos = this.Owner as IFrmSelectorProcedimientos;
                if (iFrmSelectorProcedimientos != null)
                    iFrmSelectorProcedimientos.ObtenerProcedimientos(listaSeparadaPorComas);
                Salir();
            }
            else
                MessageBox.Show("Seleccione por lo menos un procedimiento", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarTextBox(this);
        }

        private void Buscar()
        {
            string procedimiento = txtProcedimiento.Text.Trim();
            if (!string.Equals(procedimiento, string.Empty))
            {
                dtProcedimiento = objProcedimientoBL.GetProcedimientosPorIdDescripcion(procedimiento);
                dgvProcedimientos.DataSource = dtProcedimiento;
                if (dtProcedimiento.Rows.Count>0)
                    dgvProcedimientos.Focus();
            }
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmBuscadorProcedimientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtProcedimiento.Focus();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtbx_procedimiento_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvProcedimientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarProcedimientos();
                    break;
                case Keys.Back:
                    txtProcedimiento.Focus();
                    break;
            }
        }
        
        private void dgvProcedimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarProcedimientos();
        }

        private void dgvProcedimientos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProcedimientos.IsCurrentCellDirty)
                dgvProcedimientos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvProcedimientosSeleccionados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvProcedimientos.Focus();
                    break;
                case Keys.Delete:
                    QuitarProcedimientos();
                    break;
            }
        }

        private void dgvProcedimientosSeleccionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarProcedimientos();
        }

        private void dgvProcedimientosSeleccionados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProcedimientosSeleccionados.IsCurrentCellDirty)
                dgvProcedimientosSeleccionados.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

    }
}
