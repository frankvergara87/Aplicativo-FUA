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
    public partial class FrmListaMedProcNoValorizado : Form, IFrmSelectorEstablecimientos
    {
        public FrmListaMedProcNoValorizado()
        {
            InitializeComponent();
        }

        Establecimiento objEstablecimiento = new Establecimiento();
        
        EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        DataTable dt, dt2, dt3, dt4, dt5, dt6, dtG;
        int n;

        private void FrmListaMedProcNoValorizado_Load(object sender, EventArgs e)
        {
            try
            {                
                dtG = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxMes();
                dgvData.DataSource = dtG;
                lblMensaje.Text = "Resultado : " + dtG.Rows.Count + " Registros";                
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public static Boolean IsDate(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidarFechaIngreso()
        {
            bool error;
            error = false;

            if (txtFechaInicio.Text.Length > 0)
            {
                if (IsDate(txtFechaInicio.Text.Trim()) == false)
                {
                    MessageBox.Show("¡Fecha Incorrecta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFechaInicio.Focus();                    
                    error = true;
                }
            }

            return error;
        }

        public bool ValidarFechaFin()
        {
            bool error;
            error = false;

            if (txtFechaFin.Text.Length > 0)
            {
                if (IsDate(txtFechaFin.Text.Trim()) == false)
                {
                    MessageBox.Show("¡Fecha Incorrecta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFechaFin.Focus();
                    error = true;
                }
            }

            return error;
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!((tecla >= 48 && tecla <= 57) || (tecla == 8)))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFechaInicio.Text.Length > 0)
                {
                    if (ValidarFechaIngreso() == true) return;
                    if (txtFechaFin.Text.Length == 0)
                    {
                        MessageBox.Show("¡Ingresar Fecha Fin!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (ValidarFechaFin() == true) return;
                        lblLoading.Visible = true;
                        Application.DoEvents();
                        if (txtEESS.Text.Length == 0)
                        {
                            dt = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(1, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                            dt2 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(5, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                            dt3 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(3, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                            dt4 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(7, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                            dt5 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(9, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                            dt6 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(11, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));                            
                        }
                        else
                        {
                            if (txtEESS.Text.Length > 0)
                            {
                                dt = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(2, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                                dt2 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(6, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                                dt3 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(4, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                                dt4 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(8, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                                dt5 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(10, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));
                                dt6 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacionxFecha(12, txtEESS.Text.Trim(), DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text));                                
                            }
                        }

                        dgvMedicamento.DataSource = dt;
                        dgvProcedimiento.DataSource = dt2;
                        dgvMedGroup.DataSource = dt5;
                        dgvProcGroup.DataSource = dt6;
                        lblMedNoVal.Text = dt3.Rows[0][0].ToString();
                        lblPgMedNoVal.Text = dt3.Rows[0][1].ToString();
                        lblProcNoVal.Text = dt4.Rows[0][0].ToString();
                        lblPgProcNoVal.Text = dt4.Rows[0][1].ToString();
                        lblMsjMed.Text = "Resultado : " + dt.Rows.Count + " Registros";
                        lblMsjProc.Text = "Resultado : " + dt2.Rows.Count + " Registros";
                        lblMsjMedGroup.Text = "Resultado : " + dt5.Rows.Count + " Registros";
                        lblMsjProcGroup.Text = "Resultado : " + dt6.Rows.Count + " Registros";
                        int RegNoVal = int.Parse(dt3.Rows[0][0].ToString()) + int.Parse(dt4.Rows[0][0].ToString());
                        double PgRegNoVal = double.Parse(dt3.Rows[0][1].ToString()) + double.Parse(dt4.Rows[0][1].ToString());
                        lblRegNoVal.Text = RegNoVal.ToString();
                        lblPgRegNoVal.Text = PgRegNoVal.ToString();
                        dgvMedicamento_CellFormatting();
                        dgvProcedimiento_CellFormatting();
                        lblLoading.Visible = false;
                    }
                }
                else
                {
                    lblLoading.Visible = true;
                    Application.DoEvents();
                    if (txtEESS.Text.Length == 0)
                    {
                        dt = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(1, txtEESS.Text.Trim());
                        dt2 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(5, txtEESS.Text.Trim());
                        dt3 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(3, txtEESS.Text.Trim());
                        dt4 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(7, txtEESS.Text.Trim());
                        dt5 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(9, txtEESS.Text.Trim());
                        dt6 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(11, txtEESS.Text.Trim());                        
                    }
                    else
                    {
                        if (txtEESS.Text.Length > 0)
                        {
                            dt = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(2, txtEESS.Text.Trim());
                            dt2 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(6, txtEESS.Text.Trim());
                            dt3 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(4, txtEESS.Text.Trim());
                            dt4 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(8, txtEESS.Text.Trim());
                            dt5 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(10, txtEESS.Text.Trim());
                            dt6 = objMovimientoPacienteBL.MedicamentoProcedimiento_SinValorizacion(12, txtEESS.Text.Trim());                            
                        }
                    }

                    dgvMedicamento.DataSource = dt;
                    dgvProcedimiento.DataSource = dt2;
                    dgvMedGroup.DataSource = dt5;
                    dgvProcGroup.DataSource = dt6;
                    lblMedNoVal.Text = dt3.Rows[0][0].ToString();
                    lblPgMedNoVal.Text = dt3.Rows[0][1].ToString();
                    lblProcNoVal.Text = dt4.Rows[0][0].ToString();
                    lblPgProcNoVal.Text = dt4.Rows[0][1].ToString();
                    lblMsjMed.Text = "Resultado : " + dt.Rows.Count + " Registros";
                    lblMsjProc.Text = "Resultado : " + dt2.Rows.Count + " Registros";
                    lblMsjMedGroup.Text = "Resultado : " + dt5.Rows.Count + " Registros";
                    lblMsjProcGroup.Text = "Resultado : " + dt6.Rows.Count + " Registros";
                    int RegNoVal = int.Parse(dt3.Rows[0][0].ToString()) + int.Parse(dt4.Rows[0][0].ToString());
                    double PgRegNoVal = double.Parse(dt3.Rows[0][1].ToString()) + double.Parse(dt4.Rows[0][1].ToString());
                    lblRegNoVal.Text = RegNoVal.ToString();
                    lblPgRegNoVal.Text = PgRegNoVal.ToString();
                    dgvMedicamento_CellFormatting();
                    dgvProcedimiento_CellFormatting();
                    lblLoading.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        void dgvMedicamento_CellFormatting()
        {
            dgvMedicamento.Columns["Fua"].Width = 70;
            dgvMedicamento.Columns["F.Atencion"].Width = 70;
            dgvMedicamento.Columns["IdEESS"].Width = 50;
            dgvMedicamento.Columns["Establecimiento"].Width = 400;
            dgvMedicamento.Columns["Id"].Width = 50;
            dgvMedicamento.Columns["DigemidId"].Width = 50;
            dgvMedicamento.Columns["Medicamento"].Width = 200;
            dgvMedicamento.Columns["Cantidad"].Width = 60;
        }

        void dgvProcedimiento_CellFormatting()
        {
            dgvProcedimiento.Columns["Fua"].Width = 70;
            dgvProcedimiento.Columns["F.Atencion"].Width = 70;
            dgvProcedimiento.Columns["IdEESS"].Width = 50;
            dgvProcedimiento.Columns["Establecimiento"].Width = 400;
            dgvProcedimiento.Columns["Id"].Width = 50;
            dgvProcedimiento.Columns["SisId"].Width = 50;
            dgvProcedimiento.Columns["Procedimiento"].Width = 200;
            dgvProcedimiento.Columns["Cantidad"].Width = 60;            
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            txtFechaInicio.Text = dtpFechaInicio.Value.Date.ToShortDateString();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            txtFechaFin.Text = dtpFechaFin.Value.Date.ToShortDateString();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvMedicamento.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt, progressBar);
            }

            if (dgvProcedimiento.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt2, progressBar);
            }

            if (dgvMedGroup.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt5, progressBar);
            }

            if (dgvProcGroup.RowCount > 0)
            {
                FuncionesBases.DataTableToXls(dt6, progressBar);
            }

            if (dgvMedicamento.RowCount == 0 && dgvProcedimiento.RowCount == 0 && dgvMedGroup.RowCount == 0 && dgvProcGroup.RowCount == 0)
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMsjMed.Text = "";
                lblMsjProc.Text = "";
                lblMsjMedGroup.Text = "";
                lblMsjProcGroup.Text = "";
            }
        }

        private void btnBuscarEESS_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos objFrmSE = new FrmSelectorEstablecimientos();
            objFrmSE.Owner = this;
            objFrmSE.ShowDialog();
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
