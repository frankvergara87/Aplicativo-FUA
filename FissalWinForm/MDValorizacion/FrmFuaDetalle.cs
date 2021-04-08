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
    public partial class FrmFuaDetalle : Form
    {
        public FrmFuaDetalle()
        {
            InitializeComponent();
        }

        MovimientoPaciente objMovimientoPaciente = new MovimientoPaciente();
        MovimientoPacienteDetalle objMovimientoPacienteDetalle = new MovimientoPacienteDetalle();
        MovimientoMedicamento objMovimientoMedicamento = new MovimientoMedicamento();
        MovimientoProcedimiento objMovimientoProcedimiento = new MovimientoProcedimiento();
        
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        MovimientoPacienteDetalleBL objMovimientoPacienteDetalleBL = new MovimientoPacienteDetalleBL();
        MovimientoMedicamentoBL objMovimientoMedicamentoBL = new MovimientoMedicamentoBL();
        MovimientoProcedimientoBL objMovimientoProcedimientoBL = new MovimientoProcedimientoBL();

        private int Fua;

        private void FrmFuaDetalle_Load(object sender, EventArgs e)
        {   
            FuncionesBases.CargarComboTipoDoc(cboTipoDoc);
            FuncionesBases.CargarComboRegimen(cboRegimen);
            FuncionesBases.CargarComboInstitucion(cboInstitucion);
            FuncionesBases.CargarComboTipoIngreso(cboTipoIngreso);
            FuncionesBases.CargarComboLugarAtencion(cboLugarAtencion);
            FuncionesBases.CargarComboPersonalAtiende(cboPersonalAtencion);
            FuncionesBases.CargarComboTipoPrestacion(cboTipoPrestacion);
            FuncionesBases.CargarComboResponsableAtencion(cboResponsable);
            FuncionesBases.CargarComboDestinoAsegurado(cboDestinoAsegurado);

            if (VariablesGlobales.NroX == 1)
            {                
                lblNroFua.Text = VariablesGlobales.NroFuaX.ToString();
                Fua = int.Parse(lblNroFua.Text);
                this.Text = "Fua Nro " + lblNroFua.Text;
                objMovimientoPacienteDetalle.Fua = Fua;
                objMovimientoMedicamento.Fua = Fua;
                objMovimientoProcedimiento.Fua = Fua;
                MovimientoPaciente_ListarxFua(Fua);                
                dgvDiagnostico.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                dgvConsumo.DataSource = objMovimientoPacienteBL.MovimientoMedicamentoProcedimiento_ListarxFua(Fua);
                dgvDiagnostico.ClearSelection();
                dgvConsumo.ClearSelection();
            }
        }

        void MovimientoPaciente_ListarxFua(int Fua)
        {
            DataTable dt = new DataTable();
            objMovimientoPaciente.Fua = Fua;
            dt = objMovimientoPacienteBL.MovimientoPaciente_ListarxFua(objMovimientoPaciente);
            if (dt.Rows.Count > 0)
            {
                txtNumLote.Text = dt.Rows[0][1].ToString();
                txtNumFua.Text = dt.Rows[0][2].ToString();
                cboTipoIngreso.SelectedValue = dt.Rows[0][4].ToString();
                dtpFechaAtencion.Text = dt.Rows[0][5].ToString();
                cboLugarAtencion.SelectedValue = dt.Rows[0][6].ToString();
                txtHC.Text = dt.Rows[0][7].ToString();
                cboTipoPrestacion.SelectedValue = dt.Rows[0][8].ToString();
                cboPersonalAtencion.SelectedValue = dt.Rows[0][9].ToString();
                txtHojaReferencia.Text = dt.Rows[0][10].ToString();
                txtEESSReferencia.Text = dt.Rows[0][11].ToString();                

                if (dt.Rows[0][12].ToString() == String.Empty)
                {
                    cboDestinoAsegurado.SelectedValue = 0;
                }

                txtEESSAsegurado.Text = dt.Rows[0][13].ToString();                
                txtHojaRefCont.Text = dt.Rows[0][14].ToString();
                txtFechaIngreso.Text = dt.Rows[0][15].ToString();
                txtFechaAlta.Text = dt.Rows[0][16].ToString();
                txtDniResponsable.Text = dt.Rows[0][17].ToString();
                lblCMP.Text = dt.Rows[0][18].ToString();
                lblResponsable.Text = dt.Rows[0][19].ToString();
                lblEspecialidad.Text = dt.Rows[0][20].ToString();

                if (dt.Rows[0][21].ToString() == String.Empty)
                {
                    cboInstitucion.SelectedValue = 0;
                }

                txtCodSeguro.Text = dt.Rows[0][22].ToString();
                cboResponsable.SelectedValue = dt.Rows[0][23].ToString();
                txtNumDoc.Text = dt.Rows[0][24].ToString();
                lblApePaterno.Text = dt.Rows[0][25].ToString();
                lblApeMaterno.Text = dt.Rows[0][26].ToString();
                lblNombres.Text = dt.Rows[0][27].ToString();
                lblFechaRegistro.Text = dt.Rows[0][28].ToString();

                if (dt.Rows[0][29].ToString() == String.Empty)
                {
                    cboRegimen.SelectedIndex = 0;
                }
                else
                {
                    cboRegimen.SelectedValue = dt.Rows[0][29].ToString();
                }

                txtNumAfiliacion.Text = dt.Rows[0][30].ToString();

                if (dt.Rows[0][31].ToString() == String.Empty)
                {
                    cboTipoDoc.SelectedIndex = 0;
                }
                else
                {
                    cboTipoDoc.SelectedValue = dt.Rows[0][31].ToString();
                }
            }
        }
    }
}
