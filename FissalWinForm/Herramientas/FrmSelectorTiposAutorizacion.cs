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

namespace FissalWinForm
{
    public partial class FrmSelectorTiposAutorizacion : Form
    {
        #region 'VARIABLES Y CONSTANTES'

        DataTable dtTipoAutorizacion;
        DataView dvTipoAutorizacion;
        TipoAutorizacionBL objTipoAutorizacionBL = new TipoAutorizacionBL();

        #endregion
        
        #region 'CONSTRUCTORES'

        public FrmSelectorTiposAutorizacion()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        #endregion

        #region 'METODOS DE CONFIGURACION'

        private void InicializarComponentes()
        {
            this.CenterToParent();
            dgvTiposAutorizacion.AutoGenerateColumns = Convert.ToBoolean(bool.FalseString);
            this.KeyPreview = Convert.ToBoolean(bool.TrueString);
        }

        #endregion
        
        #region 'METODOS CARGA DE DATOS'

        private void CargarDgvTiposAutorizacion()
        {
            dtTipoAutorizacion = objTipoAutorizacionBL.GetAllTiposAutorizacion();
            dvTipoAutorizacion = dtTipoAutorizacion.DefaultView;
            dgvTiposAutorizacion.DataSource = dvTipoAutorizacion;
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void AgregarTiposAutorizacion()
        {
            if (!(dgvTiposAutorizacion.RowCount > 0))
                return;
            DataGridViewRow row = dgvTiposAutorizacion.CurrentRow;
            dgvTiposAutorizacionSeleccionados.Rows.Add(new object[] { row.Cells["TipoAutorizacionId"].Value, row.Cells["Descripcion"].Value });
            dgvTiposAutorizacion.Rows.Remove(row);
            dgvTiposAutorizacionSeleccionados.Focus();
        }

        private void QuitarTiposAutorizacion()
        {
            if(!(dgvTiposAutorizacionSeleccionados.RowCount > 0))
                return;
            DataGridViewRow row = dgvTiposAutorizacionSeleccionados.CurrentRow;
            DataRow datarow = dtTipoAutorizacion.NewRow();
            datarow["TipoAutorizacionId"] = Convert.ToString(row.Cells["TipoAutorizacionIdSeleccionado"].Value);
            datarow["Descripcion"] = Convert.ToString(row.Cells["DescripcionSeleccionada"].Value);
            dtTipoAutorizacion.Rows.Add(datarow);
            dgvTiposAutorizacionSeleccionados.Rows.Remove(row);
            dgvTiposAutorizacion.DataSource = dtTipoAutorizacion;
        }

        private void Buscar()
        {
            dvTipoAutorizacion.RowFilter = string.Empty;
            string tipoAutorizacion = txtTipoAutorizacion.Text.Trim();
            if (tipoAutorizacion != string.Empty)
            {
                dvTipoAutorizacion.RowFilter = string.Format("Convert(TipoAutorizacionId,'System.String') like '%{0}%' or Descripcion like '%{0}%'", tipoAutorizacion);
                if (dvTipoAutorizacion.Count>0)
                    dgvTiposAutorizacion.Focus();
            }
        }

        private void Aceptar()
        {
            if (dgvTiposAutorizacionSeleccionados.RowCount > 0)
            {
                string[] lista = new string[dgvTiposAutorizacionSeleccionados.RowCount];
                for (int i = 0; i < dgvTiposAutorizacionSeleccionados.RowCount; i++)
                {
                    lista[i] = dgvTiposAutorizacionSeleccionados.Rows[i].Cells["TipoAutorizacionIdSeleccionado"].Value.ToString();
                }
                string listaSeparadaPorComas = String.Join(",", lista);
                IFrmSelectorTiposAutorizacion iFrmSelectorTiposAutorizacion = this.Owner as IFrmSelectorTiposAutorizacion;
                if (iFrmSelectorTiposAutorizacion != null)
                    iFrmSelectorTiposAutorizacion.ObtenerTiposAutorizacion(listaSeparadaPorComas);
                Salir();
            }
            else
                MessageBox.Show("Seleccione por lo menos un Tipo de Autorizacion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmSelectorTiposAutorizacion_Load(object sender, EventArgs e)
        {
            CargarDgvTiposAutorizacion();
        }

        private void FrmSelectorTiposAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtTipoAutorizacion.Focus();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtTipoAutorizacion_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvTiposAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarTiposAutorizacion();
                    
                    break;
                case Keys.Back:
                    txtTipoAutorizacion.Focus();
                    break;
            }
        }

        private void dgvTiposAutorizacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarTiposAutorizacion();
        }

        private void dgvTiposAutorizacion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTiposAutorizacion.IsCurrentCellDirty)
            {
                dgvTiposAutorizacion.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvTiposAutorizacionSeleccionados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvTiposAutorizacion.Focus();
                    break;
                case Keys.Delete:
                    QuitarTiposAutorizacion();
                    break;
            }
        }

        private void dgvTiposAutorizacionSeleccionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvTiposAutorizacionSeleccionados.Rows[e.RowIndex];
            DataGridViewCheckBoxCell chkTipoAutorizacion = row.Cells["chkTipoAutorizacionSeleccionado"] as DataGridViewCheckBoxCell;
            chkTipoAutorizacion.Value = Convert.ToBoolean(bool.TrueString);
            QuitarTiposAutorizacion();
        }

        private void dgvTiposAutorizacionSeleccionados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTiposAutorizacionSeleccionados.IsCurrentCellDirty)
            {
                dgvTiposAutorizacionSeleccionados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        #endregion

    }
}
