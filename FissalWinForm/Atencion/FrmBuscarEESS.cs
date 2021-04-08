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
    public partial class FrmBuscarEESS : Form
    {
        public FrmBuscarEESS()
        {
            InitializeComponent();
        }

        Establecimiento objEstablecimiento = new Establecimiento();
        EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();        

        private void FrmBuscarEESS_Load(object sender, EventArgs e)
        {
            FiltrarEESS(sender, e);
        }

        private void FiltrarEESS(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = objEstablecimientoBL.Establecimiento_Filtrar(txtEESS.Text);                    
                dgvEESS.DataSource = dt;                
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
                dgvEESS.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.Down)
                {
                    dgvEESS.Focus();
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
            if (dgvEESS.RowCount > 0)
            {
                if (dgvEESS.CurrentRow.Cells[2].Value.ToString() == string.Empty)
                {
                    VariablesGlobales.NroX = 1;
                    VariablesGlobales.EstablecimientoIdSIS = dgvEESS.CurrentRow.Cells[0].Value.ToString();
                    VariablesGlobales.EstablecimientoDescripcion = dgvEESS.CurrentRow.Cells[1].Value.ToString();
                    this.Close();
                }
                else
                {
                    VariablesGlobales.NroX = 1;
                    VariablesGlobales.EstablecimientoIdSIS = dgvEESS.CurrentRow.Cells[0].Value.ToString();
                    VariablesGlobales.EstablecimientoDescripcion = dgvEESS.CurrentRow.Cells[1].Value.ToString();
                    this.Close();
                }
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void GridEESS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarData();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtEESS.Focus();
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

        private void dgvEESS_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }
    }
}

