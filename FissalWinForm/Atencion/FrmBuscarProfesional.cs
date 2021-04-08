using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FissalBE;
using FissalBL;

namespace FissalWinForm
{
    public partial class FrmBuscarProfesional : Form
    {
        public FrmBuscarProfesional()
        {
            InitializeComponent();
        }

        Medico objMedico = new Medico();
        MedicoBL objMedicoBL = new MedicoBL();

        private void FrmBuscarProfesional_Load(object sender, EventArgs e)
        {
            FiltrarProfesional(sender, e);
        }

        private void FiltrarProfesional(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                objMedico.NombreDoctor = txtProfesional.Text;
                dt = objMedicoBL.Medico_Filtrar(objMedico);
                dgvProfesional.DataSource = dt;
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
                dgvProfesional.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.Down)
                {
                    dgvProfesional.Focus();
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
            if (dgvProfesional.RowCount > 0)
            {
                VariablesGlobales.NroX = 1;
                VariablesGlobales.DniDoctorX = dgvProfesional.CurrentRow.Cells[0].Value.ToString();
                VariablesGlobales.NombreDoctorX = dgvProfesional.CurrentRow.Cells[1].Value.ToString();
                VariablesGlobales.CmpX = dgvProfesional.CurrentRow.Cells[2].Value.ToString();
                VariablesGlobales.EspecialidadX = dgvProfesional.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void GridProfesional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarData();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtProfesional.Focus();
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

        private void dgvProfesional_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }
    }
}
