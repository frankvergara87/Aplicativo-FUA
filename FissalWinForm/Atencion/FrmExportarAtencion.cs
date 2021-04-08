using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FissalBL;

namespace FissalWinForm
{
    public partial class FrmExportarAtencion : Form, IFrmSelectorEstablecimientos
    {
        public FrmExportarAtencion()
        {
            InitializeComponent();
        }
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        DataTable dt, dt2, dt3, dt4;

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

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEESS.Text.Length == 0)
                {
                    MessageBox.Show("¡Selecionar EESS!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtEESS.Text.Length > 0)
                    {
                        dt = objMovimientoPacienteBL.MovimientoPaciente_Exportar(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                        dt2 = objMovimientoPacienteBL.MovimientoPacienteDetalle_Exportar(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                        dt3 = objMovimientoPacienteBL.MovimientoMedicamento_Exportar(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                        dt4 = objMovimientoPacienteBL.MovimientoProcedimiento_Exportar(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    FuncionesBases.DataTableToXls(dt, progressBar);
                }

                if (dt2.Rows.Count > 0)
                {
                    FuncionesBases.DataTableToXls(dt2, progressBar);
                }

                if (dt3.Rows.Count > 0)
                {
                    FuncionesBases.DataTableToXls(dt3, progressBar);
                }

                if (dt4.Rows.Count > 0)
                {
                    FuncionesBases.DataTableToXls(dt4, progressBar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmExportarAtencion_Load(object sender, EventArgs e)
        {
            if (VariablesGlobales.EstablecimientoId == 0)
            {
                txtEESS.Enabled = true;
                btnBuscarEESS.Enabled = true;
                txtEESS.Clear();
            }
            else
            {
                txtEESS.Enabled = false;
                btnBuscarEESS.Enabled = false;
                txtEESS.Text = VariablesGlobales.EstablecimientoId.ToString();
            }

        }

        private void btnBuscarEESS_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos objFrmSE = new FrmSelectorEstablecimientos();
            objFrmSE.Owner = this;
            objFrmSE.ShowDialog();
        }        
    }
}
