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
    public partial class FrmListaFuaNoValorizado : Form, IFrmSelectorEstablecimientos
    {
        public FrmListaFuaNoValorizado()
        {
            InitializeComponent();
        }

        Establecimiento objEstablecimiento = new Establecimiento();

        EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        DataTable dt, dt2;
        int n;

        private void FrmListaFuaNoValorizado_Load(object sender, EventArgs e)
        {

        }

        public void ObtenerEstablecimientos(string texto)
        {
            if (txtEESS.Text != string.Empty)
            {
                txtEESS.Text = txtEESS.Text + string.Format(", {0}", texto);
            }
            else
            {
                txtEESS.Text = texto;
            }
            txtEESS.Focus();
        }

        private void btnBuscarEESS_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos objFrmSE = new FrmSelectorEstablecimientos();
            objFrmSE.Owner = this;
            objFrmSE.ShowDialog();            
        }

        private void txtEESS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                btnBuscar.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarEESS_Click(sender, e);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }               

        private void btnExportarExcel_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {                
                if (opc01.Checked == false && opc02.Checked == false && opc03.Checked == false && opc04.Checked == false)
                {
                    MessageBox.Show("¡Seleccionar Opcion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    if (opc01.Checked == true)
                    {
                        lblLoading.Visible = true;
                        Application.DoEvents();
                        if (txtEESS.Text.Length == 0)
                        {                            
                            dt = objMovimientoPacienteBL.MovimientoPaciente_SinValorizacion(1, txtEESS.Text.Trim());
                            dt2 = objMovimientoPacienteBL.MovimientoPaciente_SinValorizacion(3, txtEESS.Text.Trim());

                        }
                        else
                        {
                            if (txtEESS.Text.Length > 0)
                            {                                
                                dt = objMovimientoPacienteBL.MovimientoPaciente_SinValorizacion(2, txtEESS.Text.Trim());
                                dt2 = objMovimientoPacienteBL.MovimientoPaciente_SinValorizacion(4, txtEESS.Text.Trim());
                            }
                        }                                                
                    }
                    else
                    {
                        if (opc02.Checked == true)
                        {
                            lblLoading.Visible = true;
                            Application.DoEvents();
                            if (txtEESS.Text.Length == 0)
                            {                             
                                dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcial(1, txtEESS.Text.Trim());
                                dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcial(3, txtEESS.Text.Trim());

                            }
                            else
                            {
                                if (txtEESS.Text.Length > 0)
                                {                                    
                                    dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcial(2, txtEESS.Text.Trim());
                                    dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcial(4, txtEESS.Text.Trim());
                                }
                            }                                                        
                        }
                        else
                        {
                            if (opc03.Checked == true)
                            {
                                lblLoading.Visible = true;
                                Application.DoEvents();
                                if (txtEESS.Text.Length == 0)
                                {                                    
                                    dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionTotal(1, txtEESS.Text.Trim());
                                    dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionTotal(3, txtEESS.Text.Trim());

                                }
                                else
                                {
                                    if (txtEESS.Text.Length > 0)
                                    {                                        
                                        dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionTotal(2, txtEESS.Text.Trim());
                                        dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionTotal(4, txtEESS.Text.Trim());
                                    }
                                }                                                                
                            }
                            else
                            {
                                if (opc04.Checked == true)
                                {
                                    lblLoading.Visible = true;
                                    Application.DoEvents();
                                    if (txtEESS.Text.Length == 0)
                                    {                                        
                                        dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcialTotal(1, txtEESS.Text.Trim());
                                        dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcialTotal(3, txtEESS.Text.Trim());

                                    }
                                    else
                                    {
                                        if (txtEESS.Text.Length > 0)
                                        {                                            
                                            dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcialTotal(2, txtEESS.Text.Trim());
                                            dt2 = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionParcialTotal(4, txtEESS.Text.Trim());
                                        }
                                    }                                    
                                }
                            }
                        }
                    }

                    if (dt.Rows.Count > 0)
                    {
                        lblFua.Text = dt2.Rows[0][0].ToString();
                        lblPorcentage.Text = dt2.Rows[0][1].ToString();                                                 
                        lblTotal.Text = dt2.Rows[0][2].ToString();
                        dgvData.DataSource = dt;
                        dgvData_CellFormatting();
                        if (dgvData.RowCount > 0)
                        {
                            lblConsumo.Text = Convert.ToDouble(dt.Compute("SUM(MontoFua)", "")).ToString("###,##0.000");
                        }
                        else
                        {
                            lblConsumo.Text = "0";
                        }
                        lblMensaje.Text = "Resultado : " + dt.Rows.Count + " Registros";
                    }
                    else
                    {
                        LimpiarControles();
                        MessageBox.Show("¡No hay Data a Mostrar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                    lblLoading.Visible = false;
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void dgvData_CellFormatting()
        {
            dgvData.Columns["Fua"].Width = 50;
            dgvData.Columns["F.Atencion"].Width = 50;
            dgvData.Columns["IdEESS"].Width = 50;
            //dgvData.Columns["Establecimiento"].Width = 200;
            dgvData.Columns["MontoMed"].Width = 70;
            dgvData.Columns["MontoProced"].Width = 70;
            dgvData.Columns["MontoFua"].Width = 70;
            dgvData.Columns["MontoMed"].DefaultCellStyle.Format = "###,##0.000";
            dgvData.Columns["MontoProced"].DefaultCellStyle.Format = "###,##0.000";
            dgvData.Columns["MontoFua"].DefaultCellStyle.Format = "###,##0.000";
            dgvData.Columns["MontoMed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns["MontoProced"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns["MontoFua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                VariablesGlobales.NroX = 1;
                VariablesGlobales.NroFuaX = int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString());
                FrmFuaDetalle objFrmFuaDet = new FrmFuaDetalle();
                objFrmFuaDet.ShowDialog();
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        void LimpiarControles()
        {
            lblFua.Text = "";
            lblPorcentage.Text = "";
            lblConsumo.Text = "";
            lblTotal.Text = "";
            lblMensaje.Text = "";
            lblLoading.Visible = false;
            dgvData.DataSource = null;
            btnBuscar.Focus();
        }

        private void opc01_CheckedChanged(object sender, EventArgs e)
        {
            if (opc01.Checked == true) 
            {                
                opc02.Checked = false;
                opc03.Checked = false;
                opc04.Checked = false;
                LimpiarControles();                
            }
        }

        private void opc02_CheckedChanged(object sender, EventArgs e)
        {
            if (opc02.Checked == true)
            {                
                opc01.Checked = false;
                opc03.Checked = false;
                opc04.Checked = false;
                LimpiarControles();     
            }
        }

        private void opc03_CheckedChanged(object sender, EventArgs e)
        {
            if (opc03.Checked == true)
            {                
                opc01.Checked = false;
                opc02.Checked = false;
                opc04.Checked = false;
                LimpiarControles();    
            }
        }

        private void opc04_CheckedChanged(object sender, EventArgs e)
        {
            if (opc04.Checked == true)
            {                
                opc01.Checked = false;
                opc02.Checked = false;
                opc03.Checked = false;
                LimpiarControles();    
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
    }
}
