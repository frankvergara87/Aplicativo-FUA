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
    public partial class FrmCierreDigitacion : Form
    {
        public FrmCierreDigitacion()
        {
            InitializeComponent();
        }

        ProduccionCierreDigitacion objProduccionCierreDigitacion = new ProduccionCierreDigitacion();
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        
        int n, EstablecimientoId;
        DateTime FechaCierre;
        DataTable dtExp, dtFechaCierre;

        private void FrmCierreDigitacion_Load(object sender, EventArgs e)
        {
            MovimientoPaciente_IpressParaCierreId();
        }

        void MovimientoPaciente_IpressParaCierreId()
        {
            EstablecimientoId = int.Parse(objMovimientoPacienteBL.MovimientoPaciente_IpressPostConsistencia().Rows[0][0].ToString());
            objProduccionCierreDigitacion.EstablecimientoId = EstablecimientoId;
            this.Text = "Cierre de Digitación - " + objMovimientoPacienteBL.MovimientoPaciente_IpressPostConsistencia().Rows[0][1].ToString();

            FrmPostConsistencia objFPC = new FrmPostConsistencia();
            objFPC.PostConsistencia(EstablecimientoId);

            DataTable dt;
            dt = objMovimientoPacienteBL.MovimientoPaciente_IpressParaCierreId();
            if (dt.Rows.Count > 0)
            {
                lblIpress.Text = Convert.ToString(EstablecimientoId);//dt.Rows[0][0].ToString();
                lblDescripcion.Text = dt.Rows[0][1].ToString();
                lblFuasxCerrar.Text = dt.Rows[0][2].ToString();
                objMovimientoPacienteBL.MovimientoPaciente_UpdateFechaRegistro();

                dtFechaCierre = objMovimientoPacienteBL.ProduccionCierreDigitacion_FechasCierreV2(objProduccionCierreDigitacion);
                lblFechaCierre.Text = dtFechaCierre.Rows[0]["FechaCierre"].ToString().Substring(0,10);
                lblFechaCierreLarga.Text = dtFechaCierre.Rows[0]["Periodo"].ToString();                
            }
            else
            {
                lblDescripcion.Text = objMovimientoPacienteBL.MovimientoPaciente_IpressPostConsistencia().Rows[0][1].ToString();
                dtFechaCierre = objMovimientoPacienteBL.ProduccionCierreDigitacion_FechasCierreV2(objProduccionCierreDigitacion);
                lblFechaCierre.Text = dtFechaCierre.Rows[0]["FechaCierre"].ToString().Substring(0, 10);
                lblFechaCierreLarga.Text = dtFechaCierre.Rows[0]["Periodo"].ToString();
                lblFuasxCerrar.Text = "0";                
            }
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnEjecutar_Click(object sender, EventArgs e)
        {
            objProduccionCierreDigitacion.EstablecimientoId = EstablecimientoId;
            objProduccionCierreDigitacion.FechaCierre = DateTime.Parse(lblFechaCierre.Text);

            if (objMovimientoPacienteBL.ProduccionCierreDigitacion_VerificarCierre(objProduccionCierreDigitacion).Rows.Count == 0)
            {
                if (objMovimientoPacienteBL.MovimientoPaciente_IpressParaCierreId().Rows.Count != 0)
                {
                    lblLoading.Visible = true;
                    Application.DoEvents();
                    objProduccionCierreDigitacion.EstablecimientoId = EstablecimientoId; ;//int.Parse(lblIpress.Text);
                    objProduccionCierreDigitacion.CierreId = int.Parse(objMovimientoPacienteBL.ProduccionCierreDigitacion_Nuevo(objProduccionCierreDigitacion).Rows[0][0].ToString());
                    objProduccionCierreDigitacion.FechaCierre = DateTime.Parse(this.lblFechaCierre.Text);
                    objProduccionCierreDigitacion.UsuarioCierre = VariablesGlobales.Login;
                    objMovimientoPacienteBL.ProduccionCierreDigitacion_Insert(objProduccionCierreDigitacion);
                    objMovimientoPacienteBL.MovimientoPaciente_RegistrarCierreId(objProduccionCierreDigitacion);
                    lblLoading.Visible = false;
                    MessageBox.Show("¡Cierre de Digitación Concluida Hasta " + lblFechaCierre.Text + '!', "Fissal", MessageBoxButtons.OK);
                    MovimientoPaciente_IpressParaCierreId();  
                }
                else { MessageBox.Show("¡No existe Fuas a cerrar!", "Fissal", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("¡Periodo para Cierre de Digitación ya Registrada!", "Fissal", MessageBoxButtons.OK); }        
                      
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

        private void tsBtnExportar_Click(object sender, EventArgs e)
        {            
            EstablecimientoId = int.Parse(objMovimientoPacienteBL.MovimientoPaciente_IpressPostConsistencia().Rows[0][0].ToString());
            dtExp = objMovimientoPacienteBL.MovimientoPacienteCerrados_Listar(EstablecimientoId);

            if (dtExp.Rows.Count > 0)
            {
                progressBar.Visible = true;
                //FuncionesBases.DataTableToXls(dtExp, progressBar);
                FuncionesBases.ExportarExcel3(dtExp);
                progressBar.Visible = false;
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
