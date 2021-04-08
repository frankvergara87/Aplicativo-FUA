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
    public partial class FrmPostConsistencia : Form
    {
        public FrmPostConsistencia()
        {
            InitializeComponent();
        }

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        int n, Nro, EstablecimientoId;
        DataTable dtExp;

        private void FrmPostConsistencia_Load(object sender, EventArgs e)
        {
            EstablecimientoId = int.Parse(objMovimientoPacienteBL.MovimientoPaciente_IpressPostConsistencia().Rows[0][0].ToString());
            this.Text = "Validacion de Atenciones - " + objMovimientoPacienteBL.MovimientoPaciente_IpressPostConsistencia().Rows[0][1].ToString();
        }

        void AtencionesObservadas_Listar()
        {
            DataTable dt;            
            dt = objMovimientoPacienteBL.AtencionesObservadas_Listar(EstablecimientoId);
            if (dt.Rows.Count > 0)
            {
                dgvFuas.DataSource = dt;
                dgvFuas.Columns["Tipo"].Visible = false;
                AtencionesObservadas_Detalle();
            }
        }

        void AtencionesObservadas_Detalle()
        {
            if (dgvFuas.RowCount > 0)
            {
                //Nro = int.Parse(dgvFuas.CurrentRow.Cells[2].Value.ToString());
                DataTable dt2;
                dt2 = objMovimientoPacienteBL.AtencionesObservadas_Detalle();
                if (dt2.Rows.Count > 0)
                {
                    dgvDetalleFuas.DataSource = dt2;
                    dgvDetalleFuas.Columns["Fua"].Visible = false;
                    dgvDetalleFuas.Columns["Ipress"].Visible = false;
                    lblFuasObs.Text = dt2.Rows.Count.ToString();
                }
            } 
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnValidar_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            Application.DoEvents();
            PostConsistencia(EstablecimientoId);
            lblLoading.Visible = false;
            AtencionesObservadas_Listar();
            AtencionesObservadas_Detalle();
        }

        public void PostConsistencia(int EstablecimientoId)
        {
            objMovimientoPacienteBL.AtencionesObservadas_Reestablecer(EstablecimientoId);
            objMovimientoPacienteBL.MovimientoPaciente_UpdateObservado(EstablecimientoId);
            objMovimientoPacienteBL.AtencionObsConsistencia_Insert(EstablecimientoId);
        }

        private void dgvFuas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            //AtencionesObservadas_Detalle();                                   
        }

        private void dgvFuas_CurrentCellChanged(object sender, EventArgs e)
        {
            //AtencionesObservadas_Detalle();                                   
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

        private void dgvDetalleFuas_DoubleClick(object sender, EventArgs e)
        {
            VariablesGlobales.NroFuaX = int.Parse(dgvDetalleFuas.CurrentRow.Cells[0].Value.ToString());
            VariablesGlobales.EstablecimientoId = int.Parse(dgvDetalleFuas.CurrentRow.Cells[7].Value.ToString());
            VariablesGlobales.NroX = 1;
            VariablesGlobales.NroFrmX = 2;            
            FrmFua2 objFrm = new FrmFua2();
            DialogResult result = objFrm.ShowDialog();
            if (result == DialogResult.OK)
            {
                tsBtnValidar_Click(sender, e);
            }            
        }

        private void tsBtnExportar_Click(object sender, EventArgs e)
        {            
            dtExp = objMovimientoPacienteBL.MovimientoPacienteObservados_Listar(EstablecimientoId);

            if (dtExp.Rows.Count > 0)
            {
                progressBar.Visible = true;
                //FuncionesBases.DataTableToXls(dtExp, progressBar);
                FuncionesBases.ExportarExcel4(dtExp);
                progressBar.Visible = false;
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
