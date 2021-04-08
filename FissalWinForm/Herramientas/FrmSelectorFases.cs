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
    public partial class FrmSelectorFases : Form
    {

        #region 'VARIABLES Y CONSTANTES'

        DataTable dtFase;
        DataView dvFase;
        FaseBL objFaseBL = new FaseBL();

        #endregion

        #region 'CONSTRUCTORES'

        public FrmSelectorFases()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        #endregion

        #region 'METODOS DE CONFIGURACION'

        private void InicializarComponentes()
        {
            this.CenterToParent();
            dgvFases.AutoGenerateColumns = Convert.ToBoolean(bool.FalseString);
            this.KeyPreview = Convert.ToBoolean(bool.TrueString);
        }

        #endregion

        #region 'METODOS CARGA DE DATOS'

        private void CargarDgvFases()
        {
            dtFase = objFaseBL.GetAllFases();
            dvFase = dtFase.DefaultView;
            dgvFases.DataSource = dvFase;
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void AgregarFases()
        {
            if (!(dgvFases.RowCount > 0))
                return;
            DataGridViewRow row = dgvFases.CurrentRow;
            dgvFasesSeleccionadas.Rows.Add(new object[] { row.Cells["FaseId"].Value, row.Cells["Descripcion"].Value });
            dgvFases.Rows.Remove(row);
        }

        private void QuitarFases()
        {
            if (!(dgvFasesSeleccionadas.Rows.Count>0))
                return;
            DataGridViewRow row = dgvFasesSeleccionadas.CurrentRow;
            DataRow datarow = dtFase.NewRow();
            datarow["FaseId"] = Convert.ToString(row.Cells["FaseIdSeleccionado"].Value);
            datarow["Descripcion"] = Convert.ToString(row.Cells["DescripcionSeleccionada"].Value);
            dtFase.Rows.Add(datarow);
            dgvFasesSeleccionadas.Rows.Remove(row);
            dgvFases.DataSource = dtFase;
        }

        private void Buscar()
        {
            dvFase.RowFilter = string.Empty;
            string fase = txtFase.Text.Trim();
            if (!string.Equals(fase, string.Empty))
            {
                dvFase.RowFilter = string.Format("Convert(FaseId,'System.String') like '%{0}%' or Descripcion like '%{0}%'", fase);
                if(dvFase.Count>0)
                    dgvFases.Focus();
            }
        }

        private void Aceptar()
        {
            if (dgvFasesSeleccionadas.RowCount > 0)
            {
                string[] lista = new string[dgvFasesSeleccionadas.RowCount];
                for (int i = 0; i < dgvFasesSeleccionadas.RowCount; i++)
                {
                    lista[i] = dgvFasesSeleccionadas.Rows[i].Cells["FaseIdSeleccionado"].Value.ToString();
                }
                string listaSeparadaPorComas = String.Join(",", lista);
                IFrmSelectorFases iFrmSelectorFases = this.Owner as IFrmSelectorFases;
                if (iFrmSelectorFases != null)
                    iFrmSelectorFases.ObtenerFases(listaSeparadaPorComas);
                Salir();
            }
            else
                MessageBox.Show("Seleccione por lo menos una Fase", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void FrmSelectorFases_Load(object sender, EventArgs e)
        {
            CargarDgvFases();
        }

        private void FrmSelectorFases_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtFase.Focus();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtFase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    
                    break;
            }
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

        private void dgvFases_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarFases();
                    dgvFasesSeleccionadas.Focus();
                    break;
                case Keys.Back:
                    txtFase.Focus();
                    break;
            }
        }

        private void dgvFases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarFases();
        }

        private void dgvFases_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvFases.IsCurrentCellDirty)
                dgvFases.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvFasesSeleccionadas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvFases.Focus();
                    break;
                case Keys.Delete:
                    QuitarFases();
                    break;
            }
        }

        private void dgvFasesSeleccionadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarFases();
        }

        private void dgvFasesSeleccionadas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvFasesSeleccionadas.IsCurrentCellDirty)
                dgvFasesSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

    }
}
