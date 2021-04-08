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
    public partial class FrmBuscarAtencion : Form
    {
        public FrmBuscarAtencion()
        {
            InitializeComponent();
        }

        MovimientoPaciente objMovimientoPaciente = new MovimientoPaciente();
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        int n;

        private void FrmBuscarAtencion_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarComboTipoDoc(cboTipoDoc);

            if (objMovimientoPacienteBL.HabilitarEdicionFua().Rows[0][0].ToString() == "0")
            {
                DataTable dt = objMovimientoPacienteBL.MovimientoPaciente_GetFechaServidor();
                DateTime FechaServidor = DateTime.Parse(dt.Rows[0][0].ToString());

                if (int.Parse(FechaServidor.Day.ToString()) >= 8)
                {
                    dtpFechaInicio.MinDate = DateTime.Parse(FechaServidor.Year.ToString() + "-" + FechaServidor.Month.ToString() + "-01");
                    dtpFechaInicio.MaxDate = FechaServidor;
                    dtpFechaFin.MinDate = DateTime.Parse(FechaServidor.Year.ToString() + "-" + FechaServidor.Month.ToString() + "-01");
                    dtpFechaFin.MaxDate = FechaServidor;
                }
                else
                {
                    dtpFechaInicio.MinDate = DateTime.Parse(FechaServidor.Year.ToString() + "-" + FechaServidor.AddDays(-7).Month.ToString() + "-01");
                    dtpFechaInicio.MaxDate = FechaServidor;
                    dtpFechaFin.MinDate = DateTime.Parse(FechaServidor.Year.ToString() + "-" + FechaServidor.AddDays(-7).Month.ToString() + "-01");
                    dtpFechaFin.MaxDate = FechaServidor;
                }

                

            }
            
            //cboTipoDoc.SelectedValue = 1;
            //txtNumCorrelativo.Text = txtNumCorrelativo.Text.PadLeft(8, '0').Trim();
        }        

        public bool ValidarRangoFechas()
        {
            bool error;
            error = false;

            DateTime FechaInicio = DateTime.Parse(dtpFechaInicio.Text);
            DateTime FechaFin = DateTime.Parse(dtpFechaFin.Text);
            TimeSpan ts = FechaInicio - FechaFin;
            int Resul = ts.Days;
            if (Resul > 0)
            {
                MessageBox.Show("¡Fecha Fin no debe ser Menor a la Fecha Inicio!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                error = true;
            }

            return error;
            
        }

        public void MovimientoPaciente_Filtrar()
        {
            try            
            {
                DataTable dt;
                int TipoDocumentoId;

                if (this.cboTipoDoc.SelectedIndex == 0)
                {
                    TipoDocumentoId = 0;
                }
                else
                {
                    TipoDocumentoId = int.Parse(cboTipoDoc.SelectedValue.ToString()); 
                }

                if (opc01.Checked == true)
                {
                    if (ValidarRangoFechas() == true) return;
                    dt = objMovimientoPacienteBL.MovimientoPaciente_Filtrar(1, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text), VariablesGlobales.EstablecimientoId);
                    dgvAtencion.DataSource = dt;
                    dgvAtencion.Focus();
                }
                else
                {
                    if (opc02.Checked == true && opcFec01.Checked == true)
                    {
                        if (ValidarRangoFechas() == true) return;
                        dt = objMovimientoPacienteBL.MovimientoPaciente_Filtrar(2, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text), VariablesGlobales.EstablecimientoId);
                        dgvAtencion.DataSource = dt;
                        dgvAtencion.Focus();
                    }
                    else
                    {
                        if (opc03.Checked == true && opcFec01.Checked == true)
                        {
                            if (ValidarRangoFechas() == true) return;
                            dt = objMovimientoPacienteBL.MovimientoPaciente_Filtrar(3, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text), VariablesGlobales.EstablecimientoId);
                            dgvAtencion.DataSource = dt;
                            dgvAtencion.Focus();
                        }
                        else
                        {
                            if (opc02.Checked == true && opcFec02.Checked == true)
                            {
                                if (ValidarRangoFechas() == true) return;
                                dt = objMovimientoPacienteBL.MovimientoPaciente_Filtrar(4, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text), VariablesGlobales.EstablecimientoId);
                                dgvAtencion.DataSource = dt;
                                dgvAtencion.Focus();
                            }
                            else
                            {
                                if (opc03.Checked == true && opcFec02.Checked == true)
                                {
                                    if (ValidarRangoFechas() == true) return;
                                    dt = objMovimientoPacienteBL.MovimientoPaciente_Filtrar(5, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text), VariablesGlobales.EstablecimientoId);                                    
                                    dgvAtencion.DataSource = dt;
                                    dgvAtencion.Focus();
                                }
                            }
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MovimientoPaciente_FiltrarxAdministrador()
        {
            try
            {
                DataTable dt;
                int TipoDocumentoId;

                if (this.cboTipoDoc.SelectedIndex == 0)
                {
                    TipoDocumentoId = 0;
                }
                else
                {
                    TipoDocumentoId = int.Parse(cboTipoDoc.SelectedValue.ToString());
                }

                if (opc01.Checked == true)
                {
                    if (ValidarRangoFechas() == true) return;
                    dt = objMovimientoPacienteBL.MovimientoPaciente_FiltrarxAdministrador(1, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                    dgvAtencion.DataSource = dt;
                    dgvAtencion.Focus();
                }
                else
                {
                    if (opc02.Checked == true && opcFec01.Checked == true)
                    {
                        if (ValidarRangoFechas() == true) return;
                        dt = objMovimientoPacienteBL.MovimientoPaciente_FiltrarxAdministrador(2, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                        dgvAtencion.DataSource = dt;
                        dgvAtencion.Focus();
                    }
                    else
                    {
                        if (opc03.Checked == true && opcFec01.Checked == true)
                        {
                            if (ValidarRangoFechas() == true) return;
                            dt = objMovimientoPacienteBL.MovimientoPaciente_FiltrarxAdministrador(3, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                            dgvAtencion.DataSource = dt;
                            dgvAtencion.Focus();
                        }
                        else
                        {
                            if (opc02.Checked == true && opcFec02.Checked == true)
                            {
                                if (ValidarRangoFechas() == true) return;
                                dt = objMovimientoPacienteBL.MovimientoPaciente_FiltrarxAdministrador(4, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                                dgvAtencion.DataSource = dt;
                                dgvAtencion.Focus();
                            }
                            else
                            {
                                if (opc03.Checked == true && opcFec02.Checked == true)
                                {
                                    if (ValidarRangoFechas() == true) return;
                                    dt = objMovimientoPacienteBL.MovimientoPaciente_FiltrarxAdministrador(5, txtNumLote.Text, txtNumCorrelativo.Text, TipoDocumentoId, txtDNI.Text, txtPaciente.Text, DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                                    dgvAtencion.DataSource = dt;
                                    dgvAtencion.Focus();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!((tecla >= 48 && tecla <= 57) || (tecla == 8)))
            {
                e.Handled = true;
            }
        }

        private void opc01_CheckedChanged(object sender, EventArgs e)
        {
            if (opc01.Checked == true)
            {
                opc02.Checked = false;
                opc03.Checked = false;
                opcFec01.Checked = false;
                opcFec02.Checked = false;
                opcFec01.Enabled = false;
                opcFec02.Enabled = false;
                txtNumLote.Clear();
                txtNumCorrelativo.Clear();
                txtDNI.Clear();
                txtPaciente.Clear();                
                dgvAtencion.DataSource = null;
                txtNumLote.Enabled = true;
                txtNumCorrelativo.Enabled = true;
                cboTipoDoc.SelectedIndex = 1;
                cboTipoDoc.Enabled = false;
                txtDNI.Enabled = false;
                txtPaciente.Enabled = false;
                grpFecha.Enabled = false;                
                
                cboTipoDoc.SelectedValue = 1;
                txtNumCorrelativo.Text = txtNumCorrelativo.Text.PadLeft(8, '0').Trim();
                txtNumLote.Focus();
            }
        }

        private void opc02_CheckedChanged(object sender, EventArgs e)
        {
            if (opc02.Checked == true)
            {
                opc01.Checked = false;
                opc03.Checked = false;
                opcFec01.Enabled = true;
                opcFec02.Enabled = true;
                opcFec02.Checked = true;
                txtNumLote.Clear();
                txtNumCorrelativo.Clear();
                txtNumCorrelativo.Text = String.Empty;
                txtDNI.Clear();
                txtPaciente.Clear();
                dgvAtencion.DataSource = null;
                txtNumLote.Enabled = false;
                txtNumCorrelativo.Enabled = false;
                cboTipoDoc.SelectedIndex = 0;
                cboTipoDoc.Enabled = true;
                txtDNI.Enabled = true;
                txtPaciente.Enabled = false;
                grpFecha.Enabled = true;                
                txtDNI.Focus();

                cboTipoDoc.SelectedValue = 1;
                //txtNumCorrelativo.Text = txtNumCorrelativo.Text.PadLeft(8, '0').Trim();
            }
        }

        private void opc03_CheckedChanged(object sender, EventArgs e)
        {
            if (opc03.Checked == true)
            {
                opc01.Checked = false;
                opc02.Checked = false;
                opcFec01.Enabled = true;
                opcFec02.Enabled = true;
                opcFec02.Checked = true;
                txtNumLote.Clear();
                txtNumCorrelativo.Clear();
                txtNumCorrelativo.Text = String.Empty;
                txtDNI.Clear();
                txtPaciente.Clear();
                dgvAtencion.DataSource = null;
                txtNumLote.Enabled = false;
                txtNumCorrelativo.Enabled = false;
                cboTipoDoc.SelectedIndex = 0;
                cboTipoDoc.Enabled = false;
                cboTipoDoc.SelectedValue = 1;
                //txtNumCorrelativo.Text = txtNumCorrelativo.Text.PadLeft(8, '0').Trim();
                txtDNI.Enabled = false;
                txtPaciente.Enabled = true;
                grpFecha.Enabled = true;                
                txtPaciente.Focus();


            }
        }

        void EnviarData()
        {
            if (dgvAtencion.RowCount > 0)
            {
                VariablesGlobales.NroX = 1;
                VariablesGlobales.NroFuaX = int.Parse(dgvAtencion.CurrentRow.Cells[0].Value.ToString());
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                VariablesGlobales.NroX = 0;
            }
        }

        private void dgvAtencion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarData();
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    opc01.Checked = true;
                }
                else
                {
                    if (e.KeyCode == Keys.F4)
                    {
                        opc02.Checked = true;
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F6)
                        {
                            opc03.Checked = true;
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
            }
        }

        private void FiltrarAtencion(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtNumLote.TextLength != 0)
                {
                    if (Convert.ToInt32(txtNumCorrelativo.Text.ToString()) != 0)
                    {
                        if (VariablesGlobales.EstablecimientoId == 0)
                        {
                            lblLoading.Visible = true;
                            Application.DoEvents();
                            MovimientoPaciente_FiltrarxAdministrador();
                            lblLoading.Visible = false;
                        }
                        else
                        {
                            lblLoading.Visible = true;
                            Application.DoEvents();
                            MovimientoPaciente_Filtrar();
                            lblLoading.Visible = false;
                        }
                    }
                    else 
                    {
                        MessageBox.Show("¡Ingrese un Correlativo correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumCorrelativo.Focus(); txtNumCorrelativo.SelectAll(); 
                    }
                }
                else 
                {
                    MessageBox.Show("¡Ingrese un Lote!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumLote.Focus(); txtNumLote.SelectAll(); 
                }
               
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    opc01.Checked = true;
                }
                else
                {
                    if (e.KeyCode == Keys.F4)
                    {
                        opc02.Checked = true;
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F6)
                        {
                            opc03.Checked = true;
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
            }
        }

        private void FiltrarAtencion2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtDNI.Text != String.Empty))
                {
                    if (txtDNI.TextLength > 0) 
                    {
                        if (VariablesGlobales.EstablecimientoId == 0)
                        {
                            lblLoading.Visible = true;
                            Application.DoEvents();
                            MovimientoPaciente_FiltrarxAdministrador();
                            lblLoading.Visible = false;
                        }
                        else
                        {
                            lblLoading.Visible = true;
                            Application.DoEvents();
                            MovimientoPaciente_Filtrar();
                            lblLoading.Visible = false;
                        }                    
                    }
                    else 
                    {
                       MessageBox.Show("¡Ingrese su Número Documento correctamente!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       txtNumLote.Focus(); txtNumLote.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("¡Ingrese Número Documento!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumLote.Focus(); txtNumLote.SelectAll();
                }

            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    opc01.Checked = true;
                }
                else
                {
                    if (e.KeyCode == Keys.F4)
                    {
                        opc02.Checked = true;
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F6)
                        {
                            opc03.Checked = true;
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
            }
        }

        private void FiltrarAtencion3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VariablesGlobales.EstablecimientoId == 0)
                {
                    lblLoading.Visible = true;
                    Application.DoEvents();
                    MovimientoPaciente_FiltrarxAdministrador();
                    lblLoading.Visible = false;
                }
                else
                {
                    lblLoading.Visible = true;
                    Application.DoEvents();
                    MovimientoPaciente_Filtrar();
                    lblLoading.Visible = false;
                }

            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    opc01.Checked = true;
                }
                else
                {
                    if (e.KeyCode == Keys.F4)
                    {
                        opc02.Checked = true;
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F6)
                        {
                            opc03.Checked = true;
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
            }
        }


        private void dgvAtencion_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDoc.SelectedIndex == 0)
            {
                label4.Visible = false;
                txtDNI.Enabled = false;
                txtDNI.Clear();
            }
            else
            {
                if (cboTipoDoc.SelectedIndex == 2)
                {
                    label4.Visible = true;
                }
                else { label4.Visible = false; }

                txtDNI.Enabled = true;
                txtDNI.Clear();
                txtDNI.Focus();
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

        private void txtNumCorrelativo_Leave(object sender, EventArgs e)
        {
            txtNumCorrelativo.Text = txtNumCorrelativo.Text.PadLeft(8, '0').Trim();
        }

        private void txtNumLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtNumCorrelativo.Focus();
                txtNumCorrelativo.SelectAll();
            }
        }

        private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaInicio = DateTime.Parse(dtpFechaInicio.Text);
            DateTime FechaFin = DateTime.Parse(dtpFechaFin.Text);
            DateTime FechaServidor = DateTime.Today;

            if (FechaInicio > FechaFin)
            {
                MessageBox.Show("¡La Fecha de Inicio debe ser Menor a la Fecha Fin!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFechaInicio.Text = FechaServidor.ToString();
                dtpFechaInicio.Focus();

            }
            else
            {
                dtpFechaFin.Focus();
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaInicio = DateTime.Parse(dtpFechaInicio.Text);
            DateTime FechaFin = DateTime.Parse(dtpFechaFin.Text);
            DateTime FechaServidor = DateTime.Today;

            if (FechaFin < FechaInicio)
            {
                MessageBox.Show("¡Fecha de Fin debe ser Mayor a la Fecha de Inicio!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFechaFin.Text = FechaServidor.ToString();
                dtpFechaFin.Focus();

            }
            else
            {
                dtpFechaInicio.Focus();
            }
        }
    }
}
