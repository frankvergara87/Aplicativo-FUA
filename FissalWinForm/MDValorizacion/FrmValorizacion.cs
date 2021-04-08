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
    public partial class FrmValorizacion : Form
    {
        public FrmValorizacion()
        {
            InitializeComponent();
        }
        
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        DataTable dt, dt2, dt3, dt4;

        private void FrmValorizacion_Load(object sender, EventArgs e)
        {
            dt = objMovimientoPacienteBL.Tarifario_GetFechaMaxima();
            lblConvenioMed.Text = dt.Rows[0][0].ToString();
            lblSISMed.Text = dt.Rows[0][1].ToString();
            lblDigemidMed.Text = dt.Rows[0][2].ToString();
            lblConvenioProc.Text = dt.Rows[0][3].ToString();
            lblSISProc.Text = dt.Rows[0][4].ToString();            
        }

        void ProcesoBar()
        {
            int inicio = 0;         
            int fin = 100000;     

            progressBar.Minimum = inicio;
            progressBar.Maximum = fin;            

            for (int i = inicio; i <= fin; i++)
            {
                this.progressBar.Value = i;
            }            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dt2 = objMovimientoPacienteBL.MovimientoMedicamento_Proceso_Valorizacion();                
                dt3 = objMovimientoPacienteBL.MovimientoProcedimiento_Proceso_Valorizacion();                
                dt4 = objMovimientoPacienteBL.MovimientoPaciente_Proceso_TotalesValorizados();                
                ProcesoBar();
                MessageBox.Show("¡Valorizacion concluida!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
