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
    public partial class FrmBuscarEnfermedad : Form
    {
        public FrmBuscarEnfermedad()
        {
            InitializeComponent();
        }

        CategoriaCIE objCategoriaCIE = new CategoriaCIE();
        EnfermedadBL objEnfermedadBL = new EnfermedadBL();

        private void FrmBuscarEnfermedad_Load(object sender, EventArgs e)
        {
            FiltrarEnfermedad(sender, e);
        }

        private void FiltrarEnfermedad(object sender, EventArgs e)
        {
            try
            {
                if (VariablesGlobales.TipoDxX == "I" || VariablesGlobales.TipoDxX == "E")
                {
                    DataTable dt = new DataTable();
                    objCategoriaCIE.CategoriaId = VariablesGlobales.CategoriaIdX.Trim();
                    objCategoriaCIE.Descripcion = txtEnfermedad.Text;
                    dt = objEnfermedadBL.Enfermedad_FiltrarxCategoriaIdDescripcion(objCategoriaCIE);
                    dgvEnfermedad.DataSource = dt;
                }                                
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
                dgvEnfermedad.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.Down)
                {
                    dgvEnfermedad.Focus();
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
            if (dgvEnfermedad.RowCount > 0)
            {
                if (VariablesGlobales.TipoDxX == "I")
                {
                    VariablesGlobales.NroX = 1;
                    VariablesGlobales.DxIngresoX = dgvEnfermedad.CurrentRow.Cells[0].Value.ToString();
                    
                    this.Close();
                }
                else
                {
                    if (VariablesGlobales.TipoDxX == "E")
                    {
                        VariablesGlobales.NroX = 1;
                        VariablesGlobales.DxEgresoX = dgvEnfermedad.CurrentRow.Cells[0].Value.ToString();
                        this.Close();
                    }
                }
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void dgvEnfermedad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarData();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtEnfermedad.Focus();
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

        private void dgvEnfermedad_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }
    }
}
