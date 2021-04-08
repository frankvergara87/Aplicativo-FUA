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
    public partial class FrmEstadisticasAtenciones : Form
    {
        public FrmEstadisticasAtenciones()
        {
            InitializeComponent();
        }

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        DataTable dt;
        int n;

        private void FrmEstadisticasAtenciones_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            n++;
            if (n == 1)
            {
                lblLoading.ForeColor = Color.Blue;
            }
            else
            {
                if (n == 2)
                {
                    lblLoading.ForeColor = Color.Red;
                }
                else
                {
                    if (n == 3)
                    {
                        lblLoading.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (n == 4)
                        {
                            n = 0;
                        }
                    }
                }
            }
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            Application.DoEvents();
            dt = objMovimientoPacienteBL.Atencion_AtendidosxEstadio(DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
            dgvData.DataSource = dt;
            lblLoading.Visible = false;
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
        }

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt, progressBar);
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }              
    }
}
