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
    public partial class FrmGestionConciliacion : Form
    {
        public FrmGestionConciliacion()
        {
            InitializeComponent();
        }

        Produccion objProduccion = new Produccion();
        ProduccionBL objProduccionBL = new ProduccionBL();
        SaldoCuentaConciliacion objSaldoCuentaConciliacion = new SaldoCuentaConciliacion();

        ProduccionEstablecimiento objProduccionEstablecimiento = new ProduccionEstablecimiento();
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();
        SaldoCuentaConciliacionBL objSaldoCuentaConciliacionBL = new SaldoCuentaConciliacionBL();

        DataTable dt;
        int n;

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarConciliacion frm = new FrmRegistrarConciliacion();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarData();
            }
        }        

        private void FrmGestionControlMedico_Load(object sender, EventArgs e)
        {
            CargarData();            
        }

        private void dgvControlMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            objProduccionEstablecimiento.CodigoConciliacion = int.Parse(dgvConciliacion.CurrentRow.Cells[0].Value.ToString());
            dt = objProduccionEstablecimientoBL.ProduccionEstablecimiento_ConciliacionDetalle(objProduccionEstablecimiento);
            dgvConciliacionDetalle.DataSource = dt;
        }                

        private void tsBtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConciliacionDetalle.RowCount > 0)
                {
                    for (int f = 0; f < dt.Rows.Count; f++)
                    {
                        objProduccionEstablecimiento.CodigoConciliacion = int.Parse(dgvConciliacion.CurrentRow.Cells[0].Value.ToString());
                        objProduccionEstablecimiento.EstablecimientoId = int.Parse(dt.Rows[f]["Renaes"].ToString());
                        if (objProduccionEstablecimientoBL.EstadoCuentaConciliacion_Verificar(objProduccionEstablecimiento).Rows.Count > 0)
                        {
                            MessageBox.Show("¡No se puede ejecutar la conciliacion, Estado de Cuentas Pendientes!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    int CodigoConciliacion = int.Parse(dgvConciliacion.CurrentRow.Cells[0].Value.ToString());

                    if (MessageBox.Show("¿Ejecutar Proceso de Conciliación Nro " + dgvConciliacion.CurrentRow.Cells[0].Value.ToString() + "?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lblLoading.Visible = true;
                        Application.DoEvents();

                        //Calculo e Inserccion de Saldos por Cuenta
                        objSaldoCuentaConciliacion.CodigoConciliacion = int.Parse(dgvConciliacion.CurrentRow.Cells[0].Value.ToString());
                        objSaldoCuentaConciliacionBL.SaldoCuentaConciliacion_Insert(objSaldoCuentaConciliacion);

                        //Calculo e Inserccion de Reasignaciones por Cuenta
                        objProduccionEstablecimientoBL.MovimientoCuentaConciliacion_InsertReasignacion(objProduccionEstablecimiento);

                        //Inserccion de SaldoFinal por Cuenta
                        objProduccionEstablecimientoBL.MovimientoCuentaConciliacion_InsertSaldoFinal(objProduccionEstablecimiento);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            objProduccionEstablecimiento.ProduccionEstablecimientoId = int.Parse(dt.Rows[i]["ProduccionEstablecimientoId"].ToString());
                            objProduccionEstablecimiento.UsuarioCierraConciliacion = VariablesGlobales.Login;
                            objProduccionEstablecimientoBL.ProduccionEstablecimientoConciliacion_Cierre(objProduccionEstablecimiento);
                        }

                        DataView dvProduccionEstablecimientoConciliacion = dt.DefaultView;
                        DataTable dtProducciones = dvProduccionEstablecimientoConciliacion.ToTable(true, "ProduccionId");
                        for (int j = 0; j < dtProducciones.Rows.Count; j++)
                        {
                            int produccionId = int.Parse(dtProducciones.Rows[j]["ProduccionId"].ToString());
                            if (!objProduccionBL.FaltaConciliarProducciones(produccionId))
                            {
                                //Cierre de Produccion
                                objProduccion.ProduccionId = int.Parse(dtProducciones.Rows[j]["ProduccionId"].ToString());
                                objProduccionBL.ProduccionConciliacion_Cierre(objProduccion);
                            }
                            
                        }

                        CargarData();
                        lblLoading.Visible = false;
                        MessageBox.Show("¡Conciliación Finalizada!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        VariablesGlobales.CodigoConciliacionX = CodigoConciliacion;
                        FrmResumenConciliacion FrmRC = new FrmResumenConciliacion();
                        FrmRC.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No hay conciliaciones en ejecucion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }                                     
        }

        void CargarData()
        {
            dgvConciliacion.DataSource = objProduccionEstablecimientoBL.ProduccionEstablecimiento_CodigoConciliacionListar();            
            if (dgvConciliacion.Rows.Count > 0)
            {                
                objProduccionEstablecimiento.CodigoConciliacion = int.Parse(dgvConciliacion.CurrentRow.Cells[0].Value.ToString());
                dt = objProduccionEstablecimientoBL.ProduccionEstablecimiento_ConciliacionDetalle(objProduccionEstablecimiento);
                dgvConciliacionDetalle.DataSource = dt;
            }
            else
            {
                dgvConciliacionDetalle.DataSource = null;
            }
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

        private void tsBtnCuentas_Click(object sender, EventArgs e)
        {
            if (dgvConciliacion.Rows.Count > 0)
            {
                VariablesGlobales.CodigoConciliacionX = int.Parse(dgvConciliacion.CurrentRow.Cells[0].Value.ToString());
                FrmGestionEstadoCuenta FrmGEC = new FrmGestionEstadoCuenta();
                FrmGEC.ShowDialog();            
            }
            else
            {
                MessageBox.Show("No hay conciliaciones en ejecucion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
    }
}
