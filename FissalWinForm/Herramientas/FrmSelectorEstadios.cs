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
    public partial class FrmSelectorEstadios : Form
    {
        EstadioBL objEstadioBL = new EstadioBL();
        DataTable dtEstadio;
        DataView dvEstadio;

        public FrmSelectorEstadios()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        #region 'METODOS DE CONFIGURACION'

        private void InicializarComponentes()
        {
            this.CenterToParent();
            dgvEstadios.AutoGenerateColumns = Convert.ToBoolean(bool.FalseString);
            this.KeyPreview = Convert.ToBoolean(bool.TrueString);
        }

        #endregion

        private void CargaDgvEstadios()
        {
            dtEstadio = objEstadioBL.GetAllEstadios();
            dvEstadio = dtEstadio.DefaultView;
            dgvEstadios.DataSource = dvEstadio;
        }

        private void FrmSelectorEstadios_Load(object sender, EventArgs e)
        {
            CargaDgvEstadios();
        }

        private void AgregarEstadios()
        {
            if (!(dgvEstadios.RowCount > 0))
                return;
            DataGridViewRow row = dgvEstadios.CurrentRow;
            dgvEstadiosSeleccionados.Rows.Add(new object[] { row.Cells["EstadioId"].Value, row.Cells["Descripcion"].Value });
            dgvEstadios.Rows.Remove(row);
            dgvEstadiosSeleccionados.Focus();
        }

        private void QuitarEstadios()
        {
            if (!(dgvEstadiosSeleccionados.RowCount > 0))
                return;
            DataGridViewRow row = dgvEstadiosSeleccionados.CurrentRow;
            DataRow datarow = dtEstadio.NewRow();
            datarow["EstadioId"] = Convert.ToString(row.Cells["EstadioIdSeleccionado"].Value);
            datarow["Descripcion"] = Convert.ToString(row.Cells["DescripcionSeleccionada"].Value);
            dtEstadio.Rows.Add(datarow);
            dgvEstadiosSeleccionados.Rows.Remove(row);
            dgvEstadios.DataSource = dtEstadio;
        }

        private void Buscar()
        {
            dvEstadio.RowFilter = string.Empty;
            string estadio = txtEstadio.Text.Trim();
            if (!string.Equals(estadio,string.Empty))
            {
                dvEstadio.RowFilter = string.Format("Convert(EstadioId,'System.String') like '%{0}%' or Descripcion like '%{0}%'", estadio);
                if(dvEstadio.Count>0)
                    dgvEstadios.Focus();
            }
        }

        private void Aceptar()
        {
            if (dgvEstadiosSeleccionados.RowCount > 0)
            {
                string[] lista = new string[dgvEstadiosSeleccionados.RowCount];
                for (int i = 0; i < dgvEstadiosSeleccionados.RowCount; i++)
                {
                    lista[i] = dgvEstadiosSeleccionados.Rows[i].Cells["EstadioIdSeleccionado"].Value.ToString();
                }
                string listaSeparadaPorComas = String.Join(",", lista);
                IFrmSelectorEstadios iFrmSelectorEstadios = this.Owner as IFrmSelectorEstadios;
                if (iFrmSelectorEstadios != null)
                    iFrmSelectorEstadios.ObtenerEstadios(listaSeparadaPorComas);
                Salir();
            }
            else
                MessageBox.Show("Seleccione por lo menos un Estadio","FISSAL",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        private void txtEstadio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void dgvEstadios_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarEstadios();
                    break;
                case Keys.Back:
                    txtEstadio.Focus();
                    break;
            }
        }

        private void dgvEstadios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarEstadios();
        }

        private void dgvEstadios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgvEstadios.IsCurrentCellDirty)
            {
                dgvEstadios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvEstadiosSeleccionados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvEstadios.Focus();
                    break;
                case Keys.Delete:
                    QuitarEstadios();
                    break;
            }
        }

        private void dgvEstadiosSeleccionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarEstadios();
        }

        private void dgvEstadiosSeleccionados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgvEstadiosSeleccionados.IsCurrentCellDirty)
            {
                dgvEstadiosSeleccionados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

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

        private void Limpiar()
        {
            FuncionesBases.LimpiarTextBox(this);
        }

        private void FrmSelectorEstadios_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtEstadio.Focus();
                    break;
            }
        }

    }
}
