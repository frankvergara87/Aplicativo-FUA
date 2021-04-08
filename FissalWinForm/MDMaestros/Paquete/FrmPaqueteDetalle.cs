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
    public partial class FrmPaqueteDetalle : Form
    {
        public FrmPaqueteDetalle()
        {
            InitializeComponent();
        }

        PaqueteBL objPaqueteBL = new PaqueteBL();

        DataTable dt, dt2, dt3;

        private void FrmPaqueteDetalle_Load(object sender, EventArgs e)
        {
            if (VariablesGlobales.NroX == 1)
            {
                tabControl.SelectedTab = tbpProcedimiento;
                tabControl.SelectedTab = tbpMedicamento;
                lblEstablecimiento.Text = VariablesGlobales.EstablecimientoDescripcion;
                lblCategoria.Text = VariablesGlobales.CategoriaIdX;
                lblFase.Text = VariablesGlobales.FaseX;
                lblEstadio.Text = VariablesGlobales.EstadioX;
                lblAutorizacion.Text = VariablesGlobales.AutorizacionX;
                dgvVersion.DataSource = objPaqueteBL.Tratamiento_ListarxTratamientoId(VariablesGlobales.TratamientoIdX);                
            }
        }

        void VerData()
        {
            dt2 = objPaqueteBL.Paquete_PaqueteMedicamentos(VariablesGlobales.TratamientoIdX, int.Parse(dgvVersion.CurrentRow.Cells[0].Value.ToString()));
            if (dt2.Rows.Count > 0)
            {
                dgvMedicamento.DataSource = dt2;
                dgvMedicamento_CellFormatting();
                lblMensaje.Text = "Resultado : " + dt2.Rows.Count + " Registros";
            }

            dt3 = objPaqueteBL.Paquete_PaqueteProcedimientos(VariablesGlobales.TratamientoIdX, int.Parse(dgvVersion.CurrentRow.Cells[0].Value.ToString()));
            if (dt3.Rows.Count > 0)
            {
                dgvProcedimiento.DataSource = dt3;
                dgvProcedimiento_CellFormatting();
                lblMensaje02.Text = "Resultado : " + dt3.Rows.Count + " Registros";
            }
        }

        void dgvMedicamento_CellFormatting()
        {
            dgvMedicamento.Columns["Id"].Width = 50;
            dgvMedicamento.Columns["Digemid"].Width = 50;
            dgvMedicamento.Columns["Cantidad"].Width = 50;
            dgvMedicamento.Columns["Esquema"].Width = 100;
            dgvMedicamento.Columns["Monto"].Width = 100;
            dgvMedicamento.Columns["Monto"].DefaultCellStyle.Format = "###,##0.000";
            dgvMedicamento.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        void dgvProcedimiento_CellFormatting()
        {
            dgvProcedimiento.Columns["Id"].Width = 50;
            dgvProcedimiento.Columns["SisId"].Width = 50;
            dgvProcedimiento.Columns["InenId"].Width = 50;
            dgvProcedimiento.Columns["Cantidad"].Width = 50;
            dgvProcedimiento.Columns["Monto"].Width = 100;
            dgvProcedimiento.Columns["Monto"].DefaultCellStyle.Format = "###,##0.000";
            dgvProcedimiento.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvVersion_Click(object sender, EventArgs e)
        {
            if (dgvVersion.RowCount > 0)
            {
                VerData();
            }
            else
            {
                dgvMedicamento.DataSource = null;
                dgvProcedimiento.DataSource = null;
                lblMensaje.Text = "";
                lblMensaje02.Text = "";
            }
        }     
    }
}
