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
    public partial class FrmConsumoValorizado : Form
    {
        public FrmConsumoValorizado()
        {
            InitializeComponent();
        }

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        DataTable dt, dt2, dt3;

        private void FrmConsumoValorizado_Load(object sender, EventArgs e)
        {
            MovimientoPaciente_ValorizacionGlobal();
        }

        void MovimientoPaciente_ValorizacionGlobal()
        {
            try
            {
                dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionGlobal();
                if (dt.Rows.Count > 0)
                {                    
                    dgvEstablecimiento.DataSource = dt;
                    dgvEstablecimiento_CellFormatting();
                    lblConsumoGlobal.Text = Convert.ToDouble(dt.Compute("SUM(ConsumoGlobal)", "")).ToString("###,##0.000");
                    lblMensaje.Text = "Resultado : " + dt.Rows.Count + " Registros";
                }
                else
                {
                    MessageBox.Show("¡No hay Data a Mostrar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void MovimientoPaciente_ValorizacionxEstablecimiento()
        {
            try
            {                
                dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionxEstablecimiento(int.Parse(dgvEstablecimiento.CurrentRow.Cells[0].Value.ToString()));
                if (dt2.Rows.Count > 0)
                {
                    dgvFua.DataSource = null;
                    grb03.Text = "";
                    lblMensaje03.Text = ""; 
                    dgvPaciente.DataSource = dt2;                
                    dgvPaciente_CellFormatting();
                    grb02.Text = "Pacientes del " + dgvEstablecimiento.CurrentRow.Cells[1].Value.ToString();
                    lblMensaje02.Text = "Resultado : " + dt2.Rows.Count + " Registros";                
                }
                else
                {
                    MessageBox.Show("¡No hay Data a Mostrar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void MovimientoPaciente_ValorizacionxPaciente()
        {
            try
            {                
                dt3 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionxPaciente(dgvPaciente.CurrentRow.Cells[0].Value.ToString());
                if (dt3.Rows.Count > 0)
                {
                    dgvFua.DataSource = dt3;
                    dgvFua_CellFormatting();
                    grb03.Text = "FUAS del Paciente " + dgvPaciente.CurrentRow.Cells[1].Value.ToString();
                    lblMensaje03.Text = "Resultado : " + dt3.Rows.Count + " Registros"; 
                }
                else
                {
                    MessageBox.Show("¡No hay Data a Mostrar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private void dgvEstablecimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            MovimientoPaciente_ValorizacionxEstablecimiento();
        }        

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MovimientoPaciente_ValorizacionxPaciente();
        }        
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }                

        void dgvEstablecimiento_CellFormatting()
        {
            dgvEstablecimiento.Columns["EstablecimientoId"].Width = 100;
            dgvEstablecimiento.Columns["ConsumoGlobal"].Width = 150;
            dgvEstablecimiento.Columns["ConsumoGlobal"].DefaultCellStyle.Format = "###,##0.000";
            dgvEstablecimiento.Columns["ConsumoGlobal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        void dgvPaciente_CellFormatting()
        {
            dgvPaciente.Columns["DNIPaciente"].Width = 100;
            dgvPaciente.Columns["Fuas"].Width = 50;
            dgvPaciente.Columns["ConsumoGlobal"].Width = 150;
            dgvPaciente.Columns["ConsumoGlobal"].DefaultCellStyle.Format = "###,##0.000";
            dgvPaciente.Columns["ConsumoGlobal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        void dgvFua_CellFormatting()
        {            
            dgvFua.Columns["MontoMedicamento"].DefaultCellStyle.Format = "###,##0.000";
            dgvFua.Columns["MontoProcedimiento"].DefaultCellStyle.Format = "###,##0.000";
            dgvFua.Columns["MontoFua"].DefaultCellStyle.Format = "###,##0.000";
            dgvFua.Columns["MontoMedicamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFua.Columns["MontoProcedimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFua.Columns["MontoFua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }        

        private void dgvFua_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFua.RowCount > 0)
            {
                VariablesGlobales.NroX = 1;
                VariablesGlobales.NroFuaX = int.Parse(dgvFua.CurrentRow.Cells[0].Value.ToString());
                FrmFuaDetalle objFrmFuaDet = new FrmFuaDetalle();
                objFrmFuaDet.ShowDialog();
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvEstablecimiento.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt, progressBar);
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar02_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt2, progressBar);
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar03_Click(object sender, EventArgs e)
        {
            if (dgvFua.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt3, progressBar);
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                                      
    }
}
