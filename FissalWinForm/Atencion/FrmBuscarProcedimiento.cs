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
    public partial class FrmBuscarProcedimiento : Form
    {
        public FrmBuscarProcedimiento()
        {
            InitializeComponent();
        }

        Procedimiento objProcedimiento = new Procedimiento();
        ProcedimientoBL objProcedimientoBL = new ProcedimientoBL();

        private void FrmBuscarProcedimiento_Load(object sender, EventArgs e)
        {
            FiltrarProcedimiento(sender, e);
        }

        private void FiltrarProcedimiento(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = objProcedimientoBL.Procedimiento_Filtrar(VariablesGlobales.EstablecimientoId, VariablesGlobales.FecAtencionX, txtProcedimiento.Text);
                dgvProcedimiento.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FocusGrid(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = objProcedimientoBL.Procedimiento_Filtrar(VariablesGlobales.EstablecimientoId, VariablesGlobales.FecAtencionX, txtProcedimiento.Text);
                    dgvProcedimiento.DataSource = dt;
                    
                    dgvProcedimiento.Focus();

                }
                catch (Exception ex)
                {
                    throw ex;
                }



                
            }
            else
            {
                if (e.KeyCode == Keys.Down)
                {
                    dgvProcedimiento.Focus();
                }
                else
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        VariablesGlobales.NroX = 0;
                        this.Close();
                    }
                }                
            }
        }

        void EnviarData()
        {
            if (dgvProcedimiento.RowCount > 0)
            {
                VariablesGlobales.NroX = 1;
                VariablesGlobales.SisIdX = dgvProcedimiento.CurrentRow.Cells[0].Value.ToString();
                VariablesGlobales.DesProcedimientoX = dgvProcedimiento.CurrentRow.Cells[1].Value.ToString();
                VariablesGlobales.ProcedimientoId = Convert.ToInt32(dgvProcedimiento.CurrentRow.Cells[2].Value.ToString()); 

                this.Close();
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void dgvProcedimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                EnviarData();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtProcedimiento.Focus();
                }
                else
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        VariablesGlobales.NroX = 0;
                        this.Close();
                    }
                }
            }
        }

        private void dgvProcedimiento_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }

    }
}
