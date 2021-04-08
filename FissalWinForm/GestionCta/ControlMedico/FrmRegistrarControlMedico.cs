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
    public partial class FrmRegistrarControlMedico : Form
    {
        
        Produccion objProduccion = new Produccion();
        ProduccionBL objProduccionBL = new ProduccionBL();
        ProduccionEstablecimiento objProduccionEstablecimiento = new ProduccionEstablecimiento();
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();
        DataTable dtProducciones;
        DataView dvProducciones;
        StringBuilder filtro = new StringBuilder();

        public FrmRegistrarControlMedico()
        {
            InitializeComponent();
            dgvProducciones.AutoGenerateColumns = false;
            dgvProduccionesSeleccionadas.AutoGenerateColumns = false;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void FrmSeleccionarProduccionIpress_Load(object sender, EventArgs e)
        {
            //dgvProducciones2.DataSource = objProduccionBL.Produccion_ListarPeriodo();
            //if (dgvProducciones.RowCount > 0)
            //{
            //    objProduccionEstablecimiento.ProduccionId = int.Parse(dgvProducciones.CurrentRow.Cells[0].Value.ToString());
                //dgvProduccionesSeleccionadas.DataSource = objProduccionEstablecimientoBL.ProduccionEstablecimientoCtrlMed_Listar(objProduccionEstablecimiento);
            //}
            CargarDgvProducciones();
            FuncionesBases.CargarComboProduccionCM(cboProduccion);
            FuncionesBases.CargarComboEstablecimientoCM(cboEstablecimiento);
            txtFechaInicio.Text = DatosBL.GetDate().Date.ToShortDateString();
        }

        private void CargarDgvProducciones()
        {
            dtProducciones = objProduccionEstablecimientoBL.GetAllProduccionEstablecimiento_CM();
            dvProducciones = dtProducciones.DefaultView;
            dgvProducciones.DataSource = dvProducciones;
        }

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();               
        }

        private void dgvIpressProduccion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProduccionesSeleccionadas.IsCurrentCellDirty)
                dgvProduccionesSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();
            this.Dispose();
        }

        private void Guardar()
        {
            if (MessageBox.Show("¿Iniciar Proceso de Control Medico?", "FISSAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (dgvProduccionesSeleccionadas.RowCount > 0)
                    {
                        int CodigoControlMedico = int.Parse(objProduccionEstablecimientoBL.ProduccionEstablecimientoCtrlMed_Nuevo().Rows[0][0].ToString());
                        foreach (DataGridViewRow row in dgvProduccionesSeleccionadas.Rows)
                        {
                            objProduccionEstablecimiento.ProduccionEstablecimientoId = int.Parse(row.Cells["ProduccionEstablecimientoIdSeleccionada"].Value.ToString());
                            objProduccionEstablecimiento.ProduccionId = int.Parse(row.Cells["ProduccionIdSeleccionada"].Value.ToString());
                            objProduccionEstablecimiento.EstablecimientoId = int.Parse(row.Cells["RenaesSeleccionada"].Value.ToString());
                            objProduccionEstablecimiento.CodigoControlMedico = CodigoControlMedico;
                            objProduccionEstablecimiento.FechaFinControlMedico = DateTime.Parse(txtFechaFin.Text);
                            objProduccionEstablecimiento.UsuarioIniciaControlMedico = VariablesGlobales.Login;
                            objProduccionEstablecimientoBL.ProduccionEstablecimientoCtrlMed_Update(objProduccionEstablecimiento);
                            objProduccionEstablecimientoBL.MovimientoPaciente_UpdateCodigoControlMedico(objProduccionEstablecimiento);
                        }
                        this.DialogResult = DialogResult.OK;
                        Salir();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una produccion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Hay datos no válidos en el formulario", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            filtro.Clear();
            string produccionId = Convert.ToString(cboProduccion.SelectedValue);
            if (!string.Equals(produccionId, string.Empty))
                filtro.AppendFormat(" ProduccionId={0}", produccionId);
            string establecimientoId = Convert.ToString(cboEstablecimiento.SelectedValue);
            if (!string.Equals(establecimientoId, string.Empty))
            {
                if (string.Equals(filtro.ToString(), string.Empty))
                    filtro.AppendFormat(" Renaes={0}",establecimientoId);
                else
                    filtro.AppendFormat(" and Renaes={0}", establecimientoId);
            }
            dvProducciones.RowFilter = filtro.ToString();
        }

        private void dgvProducciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarProducciones();
        }

        private void AgregarProducciones()
        {
            if (!(dgvProducciones.RowCount > 0))
                return;
            DataGridViewRow row = dgvProducciones.CurrentRow;
            dgvProduccionesSeleccionadas.Rows.Add(new object[] { row.Cells["ProduccionEstablecimientoId"].Value, 
                row.Cells["ProduccionId"].Value, row.Cells["Codigo"].Value, row.Cells["Renaes"].Value, row.Cells["Ipress"].Value, row.Cells["AtencionesProduccion"].Value});
            dgvProducciones.Rows.Remove(row);
        }

        private void dgvProducciones_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProducciones.IsCurrentCellDirty)
                dgvProducciones.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvProducciones_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarProducciones();
                    break;
            }
        }

        private void dgvProduccionesSeleccionadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarProducciones();
        }

        private void QuitarProducciones()
        {
            if (!(dgvProduccionesSeleccionadas.Rows.Count > 0))
                return;
            DataGridViewRow row = dgvProduccionesSeleccionadas.CurrentRow;
            DataRow datarow = dtProducciones.NewRow();
            datarow["ProduccionEstablecimientoId"] = Convert.ToString(row.Cells["ProduccionEstablecimientoIdSeleccionada"].Value);
            datarow["ProduccionId"] = Convert.ToString(row.Cells["ProduccionIdSeleccionada"].Value);
            datarow["Codigo"] = Convert.ToString(row.Cells["CodigoSeleccionada"].Value);
            datarow["Renaes"] = Convert.ToString(row.Cells["RenaesSeleccionada"].Value);
            datarow["Ipress"] = Convert.ToString(row.Cells["IpressSeleccionada"].Value);
            datarow["AtencionesProduccion"] = Convert.ToString(row.Cells["AtencionesProduccionSeleccionada"].Value);
            dtProducciones.Rows.Add(datarow);
            dgvProduccionesSeleccionadas.Rows.Remove(row);
            dgvProducciones.DataSource = dtProducciones;
            //dvProducciones.Sort = string.Format("Codigo asc");
        }

        private void dgvProduccionesSeleccionadas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    QuitarProducciones();
                    break;
            }
        }

        private void dgvProducciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvProducciones, tsslTotalRegistros);
        }

        private void cboProduccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cboEstablecimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            txtFechaFin.Text = dtpFechaFin.Value.Date.ToShortDateString();
        }

        private void txtFechaFin_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtFechaFin, errorProvider1);
        }

        private void txtFechaFin_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaFin, string.Empty);
        }

        private void txtFechaInicio_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaInicio, string.Empty);
        }

        private void txtFechaInicio_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaInicio(txtFechaInicio, txtFechaFin, errorProvider1);
        }
    }
}
