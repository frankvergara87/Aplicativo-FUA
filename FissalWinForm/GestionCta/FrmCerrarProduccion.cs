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
    public partial class FrmCerrarProduccion : Form
    {
        public FrmCerrarProduccion()
        {
            InitializeComponent();
        }

        Produccion objProduccion = new Produccion();
        ProduccionBL objProduccionBL = new ProduccionBL();

        SaldoCuentaConciliacion objSaldoCuentaConciliacion = new SaldoCuentaConciliacion();
        SaldoCuentaConciliacionBL objSaldoCuentaConciliacionBL = new SaldoCuentaConciliacionBL();

        private void FrmCerrarProduccion_Load(object sender, EventArgs e)
        {
            if (VariablesGlobales.NroX == 1)
            {
                txtProduccionId.Text = VariablesGlobales.ProduccionIdX.ToString();
                txtCodigo.Text = VariablesGlobales.CodigoProd;
                txtPeriodo.Text = VariablesGlobales.PeriodoProd;
                txtMes.Text = VariablesGlobales.MesProd;
                txtFecInicio.Text = VariablesGlobales.FecIncioProd;
                txtFecCierre.Text = VariablesGlobales.FecCierreProd;

                objProduccion.ProduccionId = int.Parse(txtProduccionId.Text);
                dgvCierreProduccion.DataSource = objProduccionBL.ProduccionEstablecimiento_Listar(objProduccion);
            } 
        }

        private void tsBtnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtFecCierre.Text.Length > 0)
            {
                MessageBox.Show("¡Cierre de Produccion " + txtProduccionId.Text + "solo como Consulta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ValidarCierreProduccion() == true) return;
                objProduccion.ProduccionId = int.Parse(txtProduccionId.Text);
                objProduccionBL.Produccion_UpdateFechaCierre(objProduccion);
                MessageBox.Show("¡Cierre de Produccion Concluido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.NroX = 1;
                this.Close();
            }            
        }

        public bool ValidarCierreProduccion()
        {
            bool error;
            error = false;

            //Recorrer dgvCierreProduccion
            foreach (DataGridViewRow reg in dgvCierreProduccion.Rows)
            {
                if (Boolean.Parse(reg.Cells["Conciliada"].Value.ToString()) == false)
                {
                    MessageBox.Show("¡Cierre de Produccion Denegado!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                    break;                    
                }
            }            

            return error;
        }

        private void tsBtnVerReporte_Click(object sender, EventArgs e)
        {
            if (txtFecCierre.Text.Length > 0)
            {
                //objSaldoCuentaConciliacion.CodigoConciliacion = int.Parse(dgvCierreProduccion.CurrentRow.Cells[5].Value.ToString());
                //dgvCierreProduccion.DataSource = objSaldoCuentaConciliacionBL.SaldoCuentaConciliacion_ListarxPaciente(objSaldoCuentaConciliacion);

                VariablesGlobales.CodigoConciliacionX = int.Parse(dgvCierreProduccion.CurrentRow.Cells[5].Value.ToString());
                FrmResumenConciliacion FrmRC = new FrmResumenConciliacion();
                FrmRC.ShowDialog();
            }
            else
            {
                MessageBox.Show("¡Produccion No Conciliada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        } 
    }
}
