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
    public partial class FrmSelectorCategorias : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        CategoriaCIEBL oCategoriaCIEBL = new CategoriaCIEBL();
        DataTable dtCategoriaCIE;

        #endregion

        #region 'CONSTRUCTORES'

        public FrmSelectorCategorias()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        #endregion

        #region 'CONFIGURACION'

        private void CargarConfiguracion()
        {
            this.CenterToParent();
            dgvCategorias.AutoGenerateColumns = Convert.ToBoolean(bool.FalseString);
            this.KeyPreview = Convert.ToBoolean(bool.TrueString);
            toolStrip1.TabStop = Convert.ToBoolean(bool.TrueString);
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void AgregarDiagnosticos()
        {
            if (!(dgvCategorias.RowCount > 0))
                return;
            DataGridViewRow row = dgvCategorias.CurrentRow;
            int length = dgvCategoriasSeleccionadas.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                DataGridViewRow row2 = dgvCategoriasSeleccionadas.Rows[i];
                if (row.Cells["CategoriaId"].Value.Equals(row2.Cells["CategoriaId_seleccionada"].Value))
                {
                    MessageBox.Show("La categoria ya ha sido seleccionada", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvCategoriasSeleccionadas.Rows.Add(new object[] { row.Cells["CategoriaId"].Value, row.Cells["DescripcionCategoria"].Value });
            dgvCategorias.Rows.Remove(row);
            dgvCategoriasSeleccionadas.Focus();
        }

        private void QuitarDiagnosticos()
        {
            if (!(dgvCategoriasSeleccionadas.RowCount > 0))
                return;
            DataGridViewRow row = dgvCategoriasSeleccionadas.CurrentRow;
            DataRow datarow = dtCategoriaCIE.NewRow();
            datarow["CategoriaId"] = Convert.ToString(row.Cells["CategoriaId_seleccionada"].Value);
            datarow["Descripcion"] = Convert.ToString(row.Cells["DescripcionCategoria_seleccionada"].Value);
            dtCategoriaCIE.Rows.Add(datarow);
            dgvCategoriasSeleccionadas.Rows.Remove(row);
            dgvCategorias.DataSource = dtCategoriaCIE;
        }
        
        private void Buscar()
        {
            string categoria = txtCategoria.Text.Trim();
            if (!string.Equals(categoria, string.Empty))
            {
                dtCategoriaCIE = oCategoriaCIEBL.GetDiagnosticosCoberturaPorIdDescripcion(categoria);
                dgvCategorias.DataSource = dtCategoriaCIE;
                if (dtCategoriaCIE.Rows.Count>0)
                    dgvCategorias.Focus();
            }
        }

        private void Aceptar()  
        {
            if (dgvCategoriasSeleccionadas.RowCount > 0)
            {
                string[] lista = new string[dgvCategoriasSeleccionadas.RowCount];
                for (int i = 0; i < dgvCategoriasSeleccionadas.RowCount; i++)
                {
                    lista[i] = dgvCategoriasSeleccionadas.Rows[i].Cells["CategoriaId_seleccionada"].Value.ToString();
                }
                string listaSeparadaPorComas = String.Join(",", lista);
                IFrmSelectorCategorias iFrmSelectorCategorias = this.Owner as IFrmSelectorCategorias;
                if (iFrmSelectorCategorias != null)
                    iFrmSelectorCategorias.ObtenerCategorias(listaSeparadaPorComas);
                Salir();
            }
            else
                MessageBox.Show("Seleccione por lo menos una Categoria", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmBuscadorDiagnosticos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtCategoria.Focus();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarDiagnosticos();
                    break;
                case Keys.Back:
                    txtCategoria.Focus();
                    break;
            }
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarDiagnosticos();
        }

        private void dgvCategorias_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.IsCurrentCellDirty)
                dgvCategorias.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvCategoriasSeleccionadas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvCategorias.Focus();
                    break;
                case Keys.Delete:
                    QuitarDiagnosticos();
                    break;
            }
        }

        private void dgvCategoriasSeleccionadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarDiagnosticos();
        }

        private void dgvCategoriasSeleccionadas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCategoriasSeleccionadas.IsCurrentCellDirty)
                dgvCategoriasSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

    }
}
