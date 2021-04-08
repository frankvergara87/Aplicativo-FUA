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
    public partial class FrmBuscarMedicamento : Form
    {
        public FrmBuscarMedicamento()
        {
            InitializeComponent();
        }

        Medicamento objMedicamento = new Medicamento();
        MedicamentoBL objMedicamentoBL = new MedicamentoBL();

        private void FrmBuscarMedicamento_Load(object sender, EventArgs e)
        {
            FiltrarMedicamento(sender, e);
        }

        private void FiltrarMedicamento(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                objMedicamento.Descripcion = txtMedicamento.Text;
                dt = objMedicamentoBL.Medicamento_Filtrar(objMedicamento);
                dgvMedicamento.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FocusGrid(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvMedicamento.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.Down)
                {
                    dgvMedicamento.Focus();
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
            if (dgvMedicamento.RowCount > 0)
            {
                VariablesGlobales.NroX = 1;
                VariablesGlobales.DigemidIdX = dgvMedicamento.CurrentRow.Cells[0].Value.ToString();
                VariablesGlobales.DesMedicamentoX = dgvMedicamento.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void dgvMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                EnviarData();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtMedicamento.Focus();
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

        private void dgvMedicamento_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }
    }
}
