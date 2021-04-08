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
using FissalBE;
using CrystalDecisions.Shared;

namespace FissalWinForm
{
    public partial class frmReporteAutorizacion : Form
    {        
        

        public frmReporteAutorizacion()
        {
            InitializeComponent();
        }

        int establecimiento;
        EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();
        private void frmReporteAutorizacion_Load(object sender, EventArgs e)
        {

            cboEstablecimiento.DataSource = objEstablecimientoBL.Establecimiento_listarxconvenio();
            cboEstablecimiento.DisplayMember = "Descripcion";
            cboEstablecimiento.ValueMember = "EstablecimientoId";
            
            establecimiento = VariablesGlobales.EstablecimientoId;
            if (establecimiento != 0)
            {
                cboEstablecimiento.Enabled = false;
                cboEstablecimiento.SelectedValue = establecimiento;
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtAutorizacionPorFechaCreacion.Checked == true)
            {
                AutorizacionPorFechaCreacion();
            }
            else if (rbtAutorizacionPorPaciente.Checked == true)
            {
                AutorizacionPorPaciente();
            }
            else if (rbtAutorizacionPorCIE.Checked == true)
            {
                AutorizacionPorCIE();
            }
        }

        private void AutorizacionPorFechaCreacion()
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterField parameterField = new ParameterField();
            ParameterFields parameterFields = new ParameterFields();

            parameterField.Name = "@establecimientoid";
            parameterDiscreteValue.Value = cboEstablecimiento.SelectedValue;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterFields.Add(parameterField);           

            crvAutorizaciones.ParameterFieldInfo = parameterFields;
            MDAutorizacion.Reportes.rptAutorizacionesPorFechaDeCreacion Reporte = new MDAutorizacion.Reportes.rptAutorizacionesPorFechaDeCreacion();
            crvAutorizaciones.ReportSource = Reporte;

        }

        private void AutorizacionPorPaciente()
        {


        }

        private void AutorizacionPorCIE()
        {


        }
    }
}
