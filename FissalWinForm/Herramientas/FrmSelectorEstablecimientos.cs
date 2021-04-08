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
    public partial class FrmSelectorEstablecimientos : Form
    {
        EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();
        DataTable dtEstablecimiento;
        DataView dvEstablecimiento;
        bool establecimientosConConvenio = true;
        bool seleccionarMuchos = true;
        bool devolverSisId = false;

        public FrmSelectorEstablecimientos()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        public FrmSelectorEstablecimientos(bool establecimientosConConvenio, bool seleccionarMuchos, bool devolverSisId) : this()
        {
            this.establecimientosConConvenio = establecimientosConConvenio;
            this.seleccionarMuchos = seleccionarMuchos;
            this.devolverSisId = devolverSisId;
        }

        #region 'CONFIGURACION'

        private void CargarConfiguracion()
        {
            this.CenterToParent();
            dgvEstablecimientos.AutoGenerateColumns = false;
            this.KeyPreview = true;
        }

        #endregion
        
        private void CargaDgvEstablecimientos()
        {
            if (establecimientosConConvenio)
            {
                dtEstablecimiento = objEstablecimientoBL.GetEstablecimientosConvenio();
                dvEstablecimiento = dtEstablecimiento.DefaultView;
                dgvEstablecimientos.DataSource = dvEstablecimiento;
            }
            
        }

        private void FrmSelectorEstablecimientos_Load(object sender, EventArgs e)
        {
            if (!seleccionarMuchos)
            {
                grpBoxSeleccionados.Visible = false;
                tsBtnAceptar.Visible = false;
            }
            CargaDgvEstablecimientos();
        }

        private void AgregarEstablecimientos()
        {
            if (!(dgvEstablecimientos.RowCount > 0))
                return;
            DataGridViewRow row = dgvEstablecimientos.CurrentRow;
            int length = dgvEstablecimientosSeleccionados.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                DataGridViewRow row2 = dgvEstablecimientosSeleccionados.Rows[i];
                if (row.Cells["EstablecimientoId"].Value.Equals(row2.Cells["EstablecimientoIdSeleccionado"].Value))
                {
                    MessageBox.Show("El establecimiento ya ha sido seleccionado", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvEstablecimientosSeleccionados.Rows.Add(new object[] { row.Cells["EstablecimientoId"].Value, row.Cells["Descripcion"].Value, row.Cells["SisId"].Value });
            dgvEstablecimientos.Rows.Remove(row);
            dgvEstablecimientosSeleccionados.Focus();
        }

        private void QuitarEstablecimientos()
        {
            if (!(dgvEstablecimientosSeleccionados.RowCount > 0))
                return;
            DataGridViewRow row = dgvEstablecimientosSeleccionados.CurrentRow;
            DataRow datarow = dtEstablecimiento.NewRow();
            datarow["EstablecimientoId"] = row.Cells["EstablecimientoIdSeleccionado"].Value;
            datarow["Descripcion"] = row.Cells["DescripcionSeleccionada"].Value;
            datarow["SisId"] = row.Cells["SisIdSeleccionado"].Value;
            dtEstablecimiento.Rows.Add(datarow);
            dgvEstablecimientosSeleccionados.Rows.Remove(row);
            dgvEstablecimientos.DataSource = dtEstablecimiento;
        }

        private void Buscar()
        {
            string establecimiento = txtEstablecimiento.Text.Trim();
            if (establecimientosConConvenio)
            {
                dvEstablecimiento.RowFilter = string.Empty;
                if (!string.Equals(establecimiento, string.Empty))
                {
                    dvEstablecimiento.RowFilter = string.Format("Convert(EstablecimientoId,'System.String') like '%{0}%' or Descripcion like '%{0}%' or SisId like '%{0}%'", establecimiento);
                    if (dvEstablecimiento.Count>0)
                        dgvEstablecimientos.Focus();
                }
            }
            else
            {
                if (!string.Equals(establecimiento, string.Empty))
                {
                    dtEstablecimiento = objEstablecimientoBL.GetEstablecimientosPorIdDescripcionSisId(establecimiento);
                    dgvEstablecimientos.DataSource = dtEstablecimiento;
                    if (dtEstablecimiento.Rows.Count > 0)
                        dgvEstablecimientos.Focus();
                }
            }
        }

        private void Aceptar()
        {
            if (seleccionarMuchos)
            {
                if (dgvEstablecimientosSeleccionados.RowCount > 0)
                {
                    string[] lista = new string[dgvEstablecimientosSeleccionados.RowCount];
                    string idDevuelto = string.Empty;
                    if (devolverSisId)
                        idDevuelto = "SisIdSeleccionado";
                    else
                        idDevuelto = "EstablecimientoIdSeleccionado";
                    for (int i = 0; i < dgvEstablecimientosSeleccionados.RowCount; i++)
                    {
                        lista[i] = dgvEstablecimientosSeleccionados.Rows[i].Cells[idDevuelto].Value.ToString();
                    }
                    string listaSeparadaPorComas = String.Join(",", lista);
                    IFrmSelectorEstablecimientos iFrmSelectorEstablecimientos = this.Owner as IFrmSelectorEstablecimientos;
                    if (iFrmSelectorEstablecimientos != null)
                        iFrmSelectorEstablecimientos.ObtenerEstablecimientos(listaSeparadaPorComas);
                    Salir();
                }
                else
                    MessageBox.Show("Seleccione por lo menos un Establecimiento", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvEstablecimientos.RowCount > 0)
                {
                    string idDevuelto = string.Empty;
                    if (devolverSisId)
                        idDevuelto = "SisId";
                    else
                        idDevuelto = "EstablecimientoId";
                    string id = id = dgvEstablecimientos.CurrentRow.Cells[idDevuelto].Value.ToString();
                    IFrmSelectorEstablecimientos iFrmSelectorEstablecimientos = this.Owner as IFrmSelectorEstablecimientos;
                    if (iFrmSelectorEstablecimientos != null)
                        iFrmSelectorEstablecimientos.ObtenerEstablecimientos(id);
                    Salir();
                }
                else
                    MessageBox.Show("Seleccione por lo menos un Establecimiento", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        private void txtEstablecimiento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    
                    break;
            }
        }

        private void dgvEstablecimientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (seleccionarMuchos)
                        AgregarEstablecimientos();
                    else
                        Aceptar();
                    break;
                case Keys.Back:
                    txtEstablecimiento.Focus();
                    break;
            }
        }

        private void dgvEstablecimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (seleccionarMuchos)
                AgregarEstablecimientos();
            else
                Aceptar();
        }

        private void dgvEstablecimientos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgvEstablecimientos.IsCurrentCellDirty)
                dgvEstablecimientos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvEstablecimientosSeleccionados_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
                case Keys.Back:
                    dgvEstablecimientos.Focus();
                    break;
                case Keys.Delete:
                    QuitarEstablecimientos();
                    break;
            }
        }

        private void dgvEstablecimientosSeleccionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarEstablecimientos();
        }

        private void dgvEstablecimientosSeleccionados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgvEstablecimientosSeleccionados.IsCurrentCellDirty)
                dgvEstablecimientosSeleccionados.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

        private void FrmSelectorEstablecimientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
                case Keys.F2:
                    txtEstablecimiento.Focus();
                    break;
            }
        }

    }
}
