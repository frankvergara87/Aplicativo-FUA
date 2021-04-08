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
    public partial class FrmControlCalidad : Form, IFrmSelectorEstablecimientos
    {
        public FrmControlCalidad()
        {
            InitializeComponent();
        }

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

        DataTable dt, dt2, dt3, dt4;

        private void FrmControlCalidad_Load(object sender, EventArgs e)
        {
            this.Text = "Control de Calidad " + " | Establecimiento: " + VariablesGlobales.EstablecimientoDescripcion.Trim();

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
                MessageBox.Show("¡Fecha Inicio no debe ser Mayor a la Fecha Fin!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            return error;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarRangoFechas() == true) return;
            if (txtEESS.Text.Length == 0)
            {
                dt = objMovimientoPacienteBL.MovimientoPaciente_SinDiagnosticoxAdm(DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                dt2 = objMovimientoPacienteBL.MovimientoPaciente_SinConsumoxAdm(DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                dt3 = objMovimientoPacienteBL.MovimientoPaciente_DuplicadoxAdm(DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                dt4 = objMovimientoPacienteBL.MovimientoPaciente_FechaAtencionErroneaxAdm(DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
            }
            else
            {
                if (txtEESS.Text.Length > 0)
                {
                    dt = objMovimientoPacienteBL.MovimientoPaciente_SinDiagnostico(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                    dt2 = objMovimientoPacienteBL.MovimientoPaciente_SinConsumo(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                    dt3 = objMovimientoPacienteBL.MovimientoPaciente_Duplicado(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                    dt4 = objMovimientoPacienteBL.MovimientoPaciente_FechaAtencionErronea(txtEESS.Text.Trim(), DateTime.Parse(dtpFechaInicio.Text), DateTime.Parse(dtpFechaFin.Text));
                }
            }            

            lstDataSD.DataSource = dt;
            lstDataSD.DisplayMember = "Cadena";
            lstDataSD.ValueMember = "Cadena";

            lstDataSC.DataSource = dt2;
            lstDataSC.DisplayMember = "Cadena";
            lstDataSC.ValueMember = "Cadena";

            lstDataFD.DataSource = dt3;
            lstDataFD.DisplayMember = "Cadena";
            lstDataFD.ValueMember = "Cadena";

            lstDataFAE.DataSource = dt4;
            lstDataFAE.DisplayMember = "Cadena";
            lstDataFAE.ValueMember = "Cadena";
        }

        private void btnBuscarEESS_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos objFrmSE = new FrmSelectorEstablecimientos();
            objFrmSE.Owner = this;
            objFrmSE.ShowDialog();
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
    }
}
