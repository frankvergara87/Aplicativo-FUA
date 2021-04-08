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
using System.Configuration;

namespace FissalWinForm
{
    public partial class FrmFua2 : Form
    {
        public FrmFua2()
        {
            InitializeComponent();
        }

        public DataTable DTA = new DataTable("Temp_Autorizacion");
        public DataRow RWA;        

        private string CategoriaElegida;
        private string CategoriaDx;
        private int Fua;
        private int EstadioId, FaseId;
        private int IdAutorizacion;                
        private string DesMedicamento;
        private string DesProcedimiento;
        private bool proceso=false, procesoFec;
        private int ProcedimientoId_SisId;
        private int ProcAnterior, ProcNuevo;

        FissalBE.Autorizacion objAutorizacion = new FissalBE.Autorizacion();
        Enfermedad objEnfermedad = new Enfermedad();
        Paciente objPaciente = new Paciente();
        Medicamento objMedicamento = new Medicamento();
        Procedimiento objProcedimiento = new Procedimiento();
        Establecimiento objEstablecimiento = new Establecimiento();
        Medico objMedico = new Medico();
        MovimientoPaciente objMovimientoPaciente = new MovimientoPaciente();
        MovimientoPacienteDetalle objMovimientoPacienteDetalle = new MovimientoPacienteDetalle();
        MovimientoMedicamento objMovimientoMedicamento = new MovimientoMedicamento();
        MovimientoProcedimiento objMovimientoProcedimiento = new MovimientoProcedimiento();        

        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        EnfermedadBL objEnfermedadBL = new EnfermedadBL();
        PacienteBL objPacienteBL = new PacienteBL();
        MedicamentoBL objMedicamentoBL = new MedicamentoBL();
        ProcedimientoBL objProcedimientoBL = new ProcedimientoBL();
        EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();
        MedicoBL objMedicoBL = new MedicoBL();
        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        MovimientoPacienteDetalleBL objMovimientoPacienteDetalleBL = new MovimientoPacienteDetalleBL();
        MovimientoMedicamentoBL objMovimientoMedicamentoBL = new MovimientoMedicamentoBL();
        MovimientoProcedimientoBL objMovimientoProcedimientoBL = new MovimientoProcedimientoBL();

        private void FrmFua2_Load(object sender, EventArgs e)
        {            
            dtpFechaAtencion_ValueChanged(sender, e);
            //EstadoControles(true);
            //EstadoBotones(true);            
            this.lblFechaRegistro.Text = DateTime.Today.ToShortDateString();
            Temp_Autorizacion();            
            FuncionesBases.CargarComboTipoDoc(cboTipoDoc);
            FuncionesBases.CargarComboRegimen(cboRegimen);
            FuncionesBases.CargarComboInstitucion(cboInstitucion);
            FuncionesBases.CargarComboTipoIngreso(cboTipoIngreso);
            FuncionesBases.CargarComboLugarAtencion(cboLugarAtencion);
            FuncionesBases.CargarComboPersonalAtiende(cboPersonalAtencion);
            FuncionesBases.CargarComboTipoPrestacion(cboTipoPrestacion);
            FuncionesBases.CargarComboResponsableAtencion(cboResponsable);
            FuncionesBases.CargarComboDestinoAsegurado(cboDestinoAsegurado);
            LimpiarControles();

            if (VariablesGlobales.NroFrmX == 2) 
            {
                EdicionFuaPostConsistencia();
            }
            EstadoControles(false);
            EstadoBotones(false);
            txtNumLote.Text = dtpFechaAtencion.Text.ToString().Substring(8, 2);
            cboTipoDoc.SelectedValue = 1;
            txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();

            dtpFechaAtencion.Enabled = true;
            cboTipoDoc.Enabled = true;
            txtNumDoc.Enabled = true;
            txtNumFua.Enabled = true;          

            tbcDetalleFua.SelectTab(0);
            this.tbcDetalleFua.Enabled = false;
            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;

            cboEsquema.SelectedValue = -1;

 

       }

        void Temp_Autorizacion()
        {
            DTA.Columns.Add("Nro", System.Type.GetType("System.Int32"));
            DTA.Columns.Add("AutorizacionId", System.Type.GetType("System.Int32"));
            DTA.Columns.Add("descripcionlarga", System.Type.GetType("System.String"));
            DTA.Columns.Add("CategoriaId", System.Type.GetType("System.String"));
            DTA.Columns.Add("DiagnosticoAsociado", System.Type.GetType("System.Int32"));
            DTA.Columns.Add("Vigencia", System.Type.GetType("System.String"));
            DTA.Columns.Add("Observacion", System.Type.GetType("System.String"));
            dgvAutorizacion.DataSource = DTA;            
        }

        # region Validaciones
        
        private void EstadoControles(Boolean valor)
        {
            this.txtNumFua.Enabled = valor;
            this.txtNumDoc.Enabled = valor;
            //this.txtCodSeguro.Enabled = valor;
            //this.txtEESSAsegurado.Enabled = valor;
            this.txtEESSReferencia.Enabled = valor;
            this.txtHojaReferencia.Enabled = valor;
            this.txtDniResponsable.Enabled = valor;
            //this.txtHojaRefCont.Enabled = valor;
            //this.txtNumAfiliacion.Enabled = valor;
            this.txtHC.Enabled = valor;
            this.txtFechaIngreso.Enabled = valor;
            this.txtFechaAlta.Enabled = valor;

            this.dtpFechaAtencion.Enabled = valor;
            this.dtpFechaAlta.Enabled = valor;
            this.dtpFechaIngreso.Enabled = valor;

            this.cboTipoDoc.Enabled = valor;
            this.cboInstitucion.Enabled = valor;
            this.cboRegimen.Enabled = valor;
            this.cboPersonalAtencion.Enabled = valor;
            this.cboResponsable.Enabled = valor;
            this.cboTipoIngreso.Enabled = valor;
            this.cboTipoPrestacion.Enabled = valor;
            this.cboDestinoAsegurado.Enabled = valor;
            this.cboLugarAtencion.Enabled = valor;

            this.btnBuscarEESSReferencia.Enabled = valor;
            //this.btnBuscarEESSAsegurado.Enabled = valor;
            this.btnBuscarResponsable.Enabled = valor;            

            tbcDetalleFua.SelectTab(0);
            this.tbcDetalleFua.Enabled = !valor;            
        }

        private void EstadoBotones(Boolean valor)
        {   
            this.btnGrabar.Enabled = valor;
            this.btnEditar.Enabled = !valor;
            this.btnEliminar.Enabled = !valor;
            //this.btnBuscar.Enabled = !valor;
        }

        private void LimpiarControles()
        {
            this.lblFechaRegistro.Text = DateTime.Today.ToShortDateString();
            this.dtpFechaAtencion.Text = DateTime.Today.ToShortDateString();
            this.dtpFechaIngreso.Text = DateTime.Today.ToShortDateString();
            this.dtpFechaAlta.Text = DateTime.Today.ToShortDateString();

            this.txtNumFua.Clear();
            this.txtNumDoc.Clear();
            this.txtNumLote.Clear();
            this.txtCodSeguro.Clear();
            this.txtEESSAsegurado.Clear();
            this.txtEESSReferencia.Clear();
            this.txtHojaReferencia.Clear();
            this.txtDniResponsable.Clear();
            this.txtHojaRefCont.Clear();
            this.txtNumAfiliacion.Clear();
            this.txtHC.Clear();
            this.txtFechaIngreso.Clear();
            this.txtFechaAlta.Clear();
            this.txtNumDX.Clear();
            this.txtDxIngreso.Clear();
            this.txtDxEgreso.Clear();
            this.txtNumDXMed.Clear();
            this.txtCodMedicamento.Clear();
            this.txtCodMedicamento.Clear();
            this.txtCantPreMed.Clear();
            this.txtCantEntMed.Clear();
            this.txtNumDXProc.Clear();
            this.txtCodProcedimiento.Clear();
            this.txtCantPreProc.Clear();
            this.txtCantEntProc.Clear();                
            
            this.lblNroFua.Text = "";
            this.lblEstablecimientoId.Text = "";
            this.lblApePaterno.Text = "";
            this.lblApeMaterno.Text = "";
            this.lblNombres.Text = "";
            this.lblCMP.Text = "";
            this.lblResponsable.Text = "";
            this.lblEspecialidad.Text = "";
            this.lblEESSReferencia.Text = "";
            this.lblEESSAsegurado.Text = "";            
            this.lblMensaje.Text = "";

            this.cboTipoDoc.SelectedIndex = 0;
            this.cboInstitucion.SelectedIndex = 0;
            this.cboRegimen.SelectedIndex = 0;
            this.cboPersonalAtencion.SelectedIndex = 0;
            this.cboResponsable.SelectedIndex = 0;
            this.cboTipoIngreso.SelectedIndex = 0;
            this.cboTipoPrestacion.SelectedIndex = 0;            
            this.cboDestinoAsegurado.SelectedIndex = 0;
            this.cboLugarAtencion.SelectedIndex = 0;
            cboEsquema.DataSource = null;

            this.dgvDiagnostico.DataSource = null;
            this.dgvDiagnosticoB.DataSource = null;
            this.dgvDiagnosticoC.DataSource = null;
            this.dgvMedicamento.DataSource = null;
            this.dgvProcedimiento.DataSource = null;            

            Fua = 0;
            EstadioId = 0;
            IdAutorizacion = 0;            
            CategoriaElegida = "";
            CategoriaDx = "";
            DesMedicamento = "";
            DesProcedimiento = "";
            //proceso = true;
            procesoFec = false;

            DTA.Clear();
            dtpFechaAtencion.Focus();
        }

        void LimpiarControlesDiagnostico()
        {
            lblProcesoDx.Text = "Agregar Diagnostico";
            lblProcesoDx.BackColor = Color.RoyalBlue;
            btnAgregarAutorizacion.Visible = true;
            btnEditarAutorizacion.Visible = false;
            btnEliminarAutorizacion.Visible = false;
            txtNumDX.Clear();
            txtDxIngreso.Clear();
            txtDxEgreso.Clear();
            txtNumDX.Enabled = true;
            txtNumDX.Focus();
            txtNumDX.SelectAll();
        }

        void LimpiarControlesMedicamento()
        {
            txtNumDXMed.Enabled = true;
            txtNumDXMed.Text = "";
            txtCodMedicamento.Enabled = true;            
            txtCodMedicamento.Clear();
            lblCodMedicamento.Text = "";
            lblDesMedicamento.Text = "";
            cboEsquema.DataSource = null;
            txtCantPreMed.Clear();
            txtCantEntMed.Clear();
        }

        void LimpiarControlesProcedimiento()
        {
            txtNumDXProc.Enabled = true;
            txtCodProcedimiento.Enabled = true;
            txtNumDXProc.Clear();
            txtCodProcedimiento.Clear();
            lblCodProcedimiento.Text = "";
            lblDesProcedimiento.Text = "";
            txtCantPreProc.Clear();
            txtCantEntProc.Clear();
            opcTercero.Checked = false;
            txtTercero.Clear();            
            txtNumDXProc.Focus();
            txtNumDXProc.SelectAll();
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!((tecla >= 48 && tecla <= 57) || (tecla == 8)))
            {
                e.Handled = true;
            }
        }

        private string ValidarIsNull(object obj)
        {
            if (obj == null)
                return null;
            else
                return obj.ToString().Trim();
        }

        public bool VerificarCierreId()
        {
            bool error;
            error = false;

            if (objMovimientoPacienteBL.MovimientoPaciente_VerificarCierreId(Fua).Rows[0][0].ToString() != String.Empty)
            {
                MessageBox.Show("¡Error..., Fua ya Cerrada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            //if (objMovimientoPacienteBL.MovimientoPaciente_VerificarCierreId(Fua).Rows.Count > 0) 
            //{
            //    MessageBox.Show("¡Error..., Fua ya Cerrada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    error = true;
            //}

            return error;
        }
        
        public bool ValidarDatosMovimientoPaciente()
        {
            bool error;
            error = false;

            if (procesoFec != true)
            {
                DataTable dt;
                objMovimientoPaciente.anno = txtNumLote.Text.Trim();
                objMovimientoPaciente.correlativo = txtNumFua.Text.Trim();
                dt = objMovimientoPacienteBL.MovimientoPaciente_Verificar(objMovimientoPaciente);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("¡Año: " + txtNumLote.Text.Trim() + " - Número de Fua: " + txtNumFua.Text.Trim() + " Existente!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumFua.Clear();
                    txtNumFua.Focus();
                    txtNumFua.SelectAll();
                    error = true;
                    return error;
                }
            }

            if (txtNumDoc.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar Numero DNI!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumDoc.Focus();
                txtNumDoc.SelectAll();
                error = true;
            }
            else
            {
                if (txtNumFua.Text.Length == 0)
                {
                    MessageBox.Show("¡Debe Ingresar Numero Correlativo!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumFua.Focus();
                    txtNumFua.SelectAll();
                    error = true;
                }
                else
                {
                    if (lblApePaterno.Text.Length == 0 && lblApeMaterno.Text.Length == 0)
                    {
                        MessageBox.Show("¡Buscar Paciente!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumDoc.Focus();
                        txtNumDoc.SelectAll();
                        error = true;
                    }
                    else
                    {

                                if (cboTipoDoc.SelectedValue.ToString() == String.Empty)
                                {
                                    MessageBox.Show("¡Seleccionar Tipo de Documento!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cboTipoDoc.Focus();
                                    cboTipoDoc.SelectAll();
                                    error = true;
                                }
                                else
                                {
                                    if (cboTipoIngreso.SelectedValue.ToString() == String.Empty)
                                    {
                                        MessageBox.Show("¡Seleccionar Tipo de Ingreso!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cboTipoIngreso.Focus();
                                        cboTipoIngreso.SelectAll();
                                        error = true;
                                    }
                                    else
                                    {

                                        if (cboPersonalAtencion.SelectedValue.ToString() == String.Empty)
                                        {
                                            MessageBox.Show("¡Seleccionar Personal de Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cboPersonalAtencion.Focus();
                                            cboPersonalAtencion.SelectAll();
                                            error = true;
                                        }
                                        else
                                        {
                                            if (txtHC.Text.Length == 0)
                                            {
                                                MessageBox.Show("¡Ingresar Historia Clínica!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txtHC.Focus();
                                                error = true;
                                            }
                                            else
                                            {

                                                if (cboLugarAtencion.SelectedValue.ToString() == String.Empty)
                                                {
                                                    MessageBox.Show("¡Seleccionar Lugar de Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    cboLugarAtencion.Focus();
                                                    cboLugarAtencion.SelectAll();
                                                    error = true;
                                                }
                                                else
                                                {
                                                    if (cboTipoPrestacion.SelectedValue.ToString() == String.Empty)
                                                    {
                                                        MessageBox.Show("¡Seleccionar Tipo de Prestacion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        cboTipoPrestacion.Focus();
                                                        cboTipoPrestacion.SelectAll();
                                                        error = true;
                                                    }
                                                    else
                                                    {
                                                        if (txtDniResponsable.Text.Length == 0)
                                                        {
                                                            MessageBox.Show("¡Buscar Medico!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtDniResponsable.Focus();
                                                            txtDniResponsable.SelectAll();
                                                            error = true;
                                                        }
                                                        else
                                                        {
                                                            if (lblResponsable.Text.Length == 0)
                                                            {
                                                                MessageBox.Show("¡Buscar Medico!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                txtDniResponsable.Focus();
                                                                txtDniResponsable.SelectAll();
                                                                error = true;
                                                            }
                                                            else
                                                            {

                                                        if (cboResponsable.SelectedValue.ToString() == String.Empty)
                                                        {
                                                            MessageBox.Show("¡Seleccionar Responsable de la Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            cboResponsable.Focus();
                                                            cboResponsable.SelectAll();
                                                            error = true;
                                                        }
                                                        else
                                                        {
                                                            if (procesoFec == true)
                                                            {
                                                                DataTable dtp;
                                                                objMovimientoPaciente.Fua = Fua;
                                                                dtp = objMovimientoPacienteBL.MovimientoPaciente_GetFechaRegistroServidor(objMovimientoPaciente);
                                                                DateTime FechaAtencion = DateTime.Parse(dtpFechaAtencion.Text);
                                                                DateTime FechaRegistro = DateTime.Parse(dtp.Rows[0][0].ToString());
                                                                DateTime FechaServidor = DateTime.Parse(dtp.Rows[0][1].ToString());
                                                                TimeSpan ts = FechaAtencion - FechaServidor;
                                                                int Resul = ts.Days;
                                                                if (Resul > 0)
                                                                {
                                                                    MessageBox.Show("¡Fecha de Atencion no debe ser Mayor a la Fecha Actual!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    dtpFechaAtencion.Focus();
                                                                    error = true;
                                                                }
                                                                else
                                                                {
                                                                    //if (objMovimientoPacienteBL.HabilitarEdicionFua().Rows[0][0].ToString() == "1")
                                                                    //{
                                                                    //    if (FechaRegistro.Month.ToString() != FechaServidor.Month.ToString())
                                                                    //    {
                                                                    //        if (FechaRegistro.Month.ToString() != FechaServidor.AddDays(-7).Month.ToString())
                                                                    //        {
                                                                    //            MessageBox.Show("¡Edicion y/o Eliminacion Denegada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    //            error = true;
                                                                    //        }
                                                                    //    } 
                                                                    //}                                                                
                                                                }
                                                            }
                                                            else
                                                            {
                                                                DateTime FechaAtencion = DateTime.Parse(dtpFechaAtencion.Text);
                                                                DateTime FechaRegistro = DateTime.Today;
                                                                DateTime FechaServidor = DateTime.Today;
                                                                TimeSpan ts = FechaAtencion - FechaServidor;
                                                                int Resul = ts.Days;
                                                                if (Resul > 0)
                                                                {
                                                                    MessageBox.Show("¡Fecha de Atencion no debe ser Mayor a la Fecha Actual!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    dtpFechaAtencion.Focus();
                                                                    error = true;
                                                                }
                                                            }

                                                            if (txtFechaIngreso.Text.Length > 0 && txtFechaAlta.Text.Length > 0)
                                                            {
                                                                DateTime FechaAtencion = DateTime.Parse(dtpFechaAtencion.Text);
                                                                DateTime FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
                                                                DateTime FechaAlta = DateTime.Parse(txtFechaAlta.Text);

                                                                TimeSpan ts = FechaIngreso - FechaAtencion;
                                                                int Resul = ts.Days;
                                                                if (Resul > 0)
                                                                {
                                                                    MessageBox.Show("¡Fecha de Ingreso no debe ser Mayor a Fecha de Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    txtFechaIngreso.Focus();
                                                                    error = true;
                                                                    return error;
                                                                }

                                                                TimeSpan ts2 = FechaAlta - FechaAtencion;
                                                                int Resul2 = ts2.Days;
                                                                if (Resul2 > 0)
                                                                {
                                                                    MessageBox.Show("¡ Fecha de Alta no debe ser Mayor a Fecha de Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    txtFechaAlta.Focus();
                                                                    error = true;
                                                                    return error;
                                                                }

                                                                TimeSpan ts3 = FechaIngreso - FechaAlta;
                                                                int Resul3 = ts3.Days;
                                                                if (Resul3 > 0)
                                                                {
                                                                    MessageBox.Show("¡Fecha de Ingreso no debe ser Mayor a Fecha de Alta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    txtFechaIngreso.Focus();
                                                                    error = true;
                                                                    return error;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (txtFechaIngreso.Text.Length > 0 && txtFechaAlta.Text.Length == 0)
                                                                {
                                                                    MessageBox.Show("¡Ingresar Fecha de Alta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    txtFechaAlta.Focus();
                                                                    error = true;
                                                                }
                                                                else
                                                                {
                                                                    if (txtFechaAlta.Text.Length > 0 && txtFechaIngreso.Text.Length == 0)
                                                                    {
                                                                        MessageBox.Show("¡Ingresar Fecha de Ingreso!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        txtFechaIngreso.Focus();
                                                                        error = true;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 6 || int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 7 || int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 8 || int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 9)
                                                                        {
                                                                            if (txtFechaIngreso.Text.Length == 0 && txtFechaAlta.Text.Length == 0)
                                                                            {
                                                                                MessageBox.Show("¡Ingresar Fecha de Ingreso / Alta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                txtFechaIngreso.Focus();
                                                                                error = true;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return error;
        }

        public bool ValidarDatosConsumo()
        {
            bool error;
            error = false;

            if (objMovimientoPacienteBL.HabilitarEdicionFua().Rows[0][0].ToString() == "0")
            {
                if (procesoFec == true)
                {
                    DataTable dt;
                    objMovimientoPaciente.Fua = Fua;
                    dt = objMovimientoPacienteBL.MovimientoPaciente_GetFechaRegistroServidor(objMovimientoPaciente);
                    DateTime FechaRegistro = DateTime.Parse(dt.Rows[0][0].ToString());
                    DateTime FechaServidor = DateTime.Parse(dt.Rows[0][1].ToString());
                    if (FechaRegistro.Month.ToString() != FechaServidor.Month.ToString())
                    {
                        if (FechaRegistro.Month.ToString() != FechaServidor.AddDays(-7).Month.ToString())
                        {
                            MessageBox.Show("¡Edicion y/o Eliminacion Denegada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            error = true;
                        }
                    }
                }
            }           

            return error;
        }

        public bool ValidarAgregarAutorizacion()
        {
            bool error;
            error = false;

            if (txtNumDX.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Seleccionar una Autorizacion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumDX.Focus();
                txtNumDX.SelectAll();
                error = true;
            }

            return error;
        }

        public bool ValidarEditarDiagnostico()
        {
            bool error;
            error = false;

            if (txtNumDX.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Seleccionar un Diagnostico!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumDX.Focus();
                txtNumDX.SelectAll();
                error = true;
            }

            return error;
        }

        public bool ValidarDxMedicamento()
        {
            bool error;
            error = false;
            IdAutorizacion = 0;

            if (txtNumDXMed.Text.Length == 0)
            {
                MessageBox.Show("¡Ingrese un Diagnostico Correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumDXMed.Focus();
                txtNumDXMed.SelectAll();
                error = true;
            }
            else
            {
                foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == int.Parse(txtNumDXMed.Text.Trim()))
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        break;
                    }
                }

                if (IdAutorizacion > 0)
                {
                    error = false;
                }
                else
                {
                    cboEsquema.DataSource = null;
                    MessageBox.Show("¡Ingrese un Diagnostico correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    txtNumDXMed.Focus();
                    txtNumDXMed.SelectAll();
                    error = true;
                }                  
            }

            return error;
        }        

        public bool ValidarIdMedicamento()
        {
            bool error;
            error = false;

            if (txtCodMedicamento.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar un Medicamento!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodMedicamento.Focus();
                txtCodMedicamento.SelectAll();
                error = true;
            }
            else
            {
                objMedicamento.DigemidId = txtCodMedicamento.Text.Trim();
                if (objMedicamentoBL.Medicamento_Verificar(objMedicamento).Rows.Count > 0)
                {
                    lblCodMedicamento.Text = objMedicamentoBL.Medicamento_Verificar(objMedicamento).Rows[0][0].ToString();
                    lblDesMedicamento.Text = objMedicamentoBL.Medicamento_Verificar(objMedicamento).Rows[0][1].ToString();
                    error = false;
                }
                else
                {
                    MessageBox.Show("¡Medicamento No Existente!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCodMedicamento.Text = "";
                    lblDesMedicamento.Text = "";
                    txtCodMedicamento.Focus();
                    txtCodMedicamento.SelectAll();
                    error = true;
                }
            }            

            return error;
        }

        public bool ValidarDxProcedimiento()
        {
            bool error;
            error = false;
            IdAutorizacion = 0;

            if (txtNumDXProc.Text.Length == 0)
            {
                MessageBox.Show("¡Ingre un Diagnostico Correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumDXProc.Focus();
                txtNumDXProc.SelectAll();
                error = true;
            }
            else
            {
                //Recorrer dgvDiagnostico
                foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == int.Parse(txtNumDXProc.Text.Trim()))
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        break;
                    }
                }

                if (IdAutorizacion > 0)
                {
                    error = false;
                }
                else
                {
                    MessageBox.Show("¡Debe Seleccionar un Diagnostico!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumDXProc.Focus();
                    txtNumDXProc.SelectAll();
                    error = true;
                }
            }

            return error;            
        }

        public bool ValidarIdProcedimiento()
        {
            bool error;
            error = false;

            if (txtCodProcedimiento.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar un Procedimiento!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProcedimiento.Focus();
                txtCodProcedimiento.SelectAll();
                error = true;
            }
            else
            {                
                string SisId = txtCodProcedimiento.Text.Trim();
                DateTime FecAtencion = DateTime.Parse(dtpFechaAtencion.Text);                

                if (VariablesGlobales.EstablecimientoId == 0)
                {
                    if (objProcedimientoBL.Procedimiento_VerificarSisId(int.Parse(lblEstablecimientoId.Text), SisId, FecAtencion).Rows.Count > 0)
                    {
                        lblCodProcedimiento.Text = objProcedimientoBL.Procedimiento_VerificarSisId(int.Parse(lblEstablecimientoId.Text), SisId, FecAtencion).Rows[0][0].ToString();
                        lblDesProcedimiento.Text = objProcedimientoBL.Procedimiento_VerificarSisId(int.Parse(lblEstablecimientoId.Text), SisId, FecAtencion).Rows[0][1].ToString();
                        ProcedimientoId_SisId = Convert.ToInt32(objProcedimientoBL.Procedimiento_VerificarSisId(int.Parse(lblEstablecimientoId.Text), SisId, FecAtencion).Rows[0][2].ToString());
                        //DesProcedimiento = objProcedimientoBL.Procedimiento_Verificar(objProcedimiento).Rows[0][1].ToString();
                        error = false;
                    }
                    else
                    {
                        MessageBox.Show("¡Procedimiento Incorrecto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCodProcedimiento.Text = "";
                        lblDesProcedimiento.Text = "";
                        txtCodProcedimiento.Focus();
                        txtCodProcedimiento.SelectAll();
                        error = true;
                    }
                }
                else
                {
                    if (objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, SisId, FecAtencion).Rows.Count > 0)
                    {
                        lblCodProcedimiento.Text = objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, SisId, FecAtencion).Rows[0][0].ToString();
                        lblDesProcedimiento.Text = objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, SisId, FecAtencion).Rows[0][1].ToString();
                        ProcedimientoId_SisId = Convert.ToInt32(objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, SisId, FecAtencion).Rows[0][2].ToString());
                        //DesProcedimiento = objProcedimientoBL.Procedimiento_Verificar(objProcedimiento).Rows[0][1].ToString();
                        error = false;
                    }
                    else
                    {
                        MessageBox.Show("¡Procedimiento Incorrecto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCodProcedimiento.Text = "";
                        lblDesProcedimiento.Text = "";
                        txtCodProcedimiento.Focus();
                        txtCodProcedimiento.SelectAll();
                        error = true;
                    }
                }  
            } 

            return error;
        }

        public bool ValidarIPRESSProcedimiento()
        {
            bool error;
            error = false;

            if (opcTercero.Checked == true && txtTercero.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar Codigo IPRESS!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTercero.Focus();
                error = true;
            }                      

            return error;
        }
        
        public bool ValidarAgregarDxIngreso()
        {
            bool error;
            error = false;

            if (txtDxIngreso.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar una Enfermedad de Ingreso!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDxIngreso.Focus();
                txtDxIngreso.SelectAll();
                error = true;
            }
            else
            {
                objEnfermedad.CategoriaId = CategoriaElegida;
                objEnfermedad.EnfermedadId = txtDxIngreso.Text.Trim();
                if (objEnfermedadBL.Enfermedad_Verificar(objEnfermedad).Rows.Count > 0)
                {
                    error = false;
                }
                else
                {                    
                    MessageBox.Show("¡Enfermedad de Ingreso Incorrecto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDxIngreso.Focus();
                    txtDxIngreso.SelectAll();
                    error = true; 
                }
            }

            return error;
        }

        public bool ValidarAgregarDxEgreso()
        {
            bool error;
            error = false;

            if (txtDxEgreso.Text.Length > 0)
            {
                objEnfermedad.CategoriaId = CategoriaElegida;
                objEnfermedad.EnfermedadId = txtDxEgreso.Text.Trim();
                if (objEnfermedadBL.Enfermedad_Verificar(objEnfermedad).Rows.Count > 0)
                {
                    error = false;
                }
                else
                {
                    MessageBox.Show("¡Enfermedad de Egreso Incorrecto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDxEgreso.Focus();
                    txtDxEgreso.SelectAll();
                    error = true;
                }                
            }            

            return error;
        }

        public bool ValidarCantPrescritaMed()
        {
            bool error;
            error = false;

            if (txtCantPreMed.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar Cantidad Prescrita!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantPreMed.Focus();
                txtCantPreMed.SelectAll();
                error = true;
            }
            else
            {
                if (int.Parse(txtCantPreMed.Text) < 1)
                {
                    MessageBox.Show("¡Debe Ingresar Cantidad Prescrita Mayor a 0!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantPreMed.Focus();
                    txtCantPreMed.SelectAll();
                    error = true;
                }
            }

            return error;
        }

        public bool ValidarCantEntregadaMed()
        {
            bool error;
            error = false;

            if (txtCantEntMed.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar Cantidad Entregada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantEntMed.Focus();
                txtCantEntMed.SelectAll();
                error = true;
            }
            else
            {
                if (int.Parse(txtCantEntMed.Text) < 1)
                {
                    MessageBox.Show("¡Debe Ingresar Cantidad Entregada Mayor a 0!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantEntMed.Focus();
                    txtCantEntMed.SelectAll();
                    error = true;
                }
                else
                {
                    if (int.Parse(txtCantEntMed.Text) > int.Parse(txtCantPreMed.Text))
                    {
                        MessageBox.Show("¡Cantidad Entregada no debe exceder a Cantidad Prescrita!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantEntMed.Focus();
                        txtCantEntMed.SelectAll();
                        error = true;
                    }
                }                
            }

            return error;
        }

        public bool ValidarCantPrescritaProc()
        {
            bool error;
            error = false;

            if (txtCantPreProc.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar Cantidad Prescrita!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantPreProc.Focus();
                txtCantPreProc.SelectAll();
                error = true;
            }
            else
            {
                if (int.Parse(txtCantPreProc.Text) < 1)
                {
                    MessageBox.Show("¡Debe Ingresar Cantidad Prescrita Mayor a 0!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantPreProc.Focus();
                    txtCantPreProc.SelectAll();
                    error = true;
                }
            }

            return error;
        }

        public bool ValidarCantEntregadaProc()
        {
            bool error;
            error = false;

            if (txtCantEntProc.Text.Length == 0)
            {
                MessageBox.Show("¡Debe Ingresar Cantidad Entregada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantEntProc.Focus();
                txtCantEntProc.SelectAll();
                error = true;
            }
            else
            {
                if (int.Parse(txtCantEntProc.Text) < 1)
                {
                    MessageBox.Show("¡Debe Ingresar Cantidad Entregada Mayor a 0!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantEntProc.Focus();
                    txtCantEntProc.SelectAll();
                    error = true;
                }
                else
                {
                    if (int.Parse(txtCantEntProc.Text) > int.Parse(txtCantPreProc.Text))
                    {
                        MessageBox.Show("¡Cantidad Entregada no debe exceder a Cantidad Prescrita!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantEntProc.Focus();
                        txtCantEntProc.SelectAll();
                        error = true;
                    }
                }                
            }

            return error;
        }

        public bool ValidarDuplicidadAutorizacion()
        {
            bool error;
            error = false;

            foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
            {
                if (int.Parse(reg.Cells["AutorizacionId"].Value.ToString()) == IdAutorizacion && reg.Cells["CategoriaId"].Value.ToString() != "ZZZ")
                {                    
                    MessageBox.Show("¡La Autorización ya fue elegida!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumDX.Focus();
                    txtNumDX.SelectAll();
                    txtDxIngreso.Text = String.Empty;
                    txtDxEgreso.Text = String.Empty;
                    txtDxIngreso.Enabled = false;
                    txtDxEgreso.Enabled = false;
                    error = true;
                    break;
                }
            }           

            return error;
        }

        public bool ValidarDuplicidadDxAsociado()
        {
            bool error;
            error = false;

            foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
            {
                if (reg.Cells["Dx. Ingreso"].Value.ToString().Trim() == txtDxIngreso.Text.Trim() && int.Parse(reg.Cells["AutorizacionId"].Value.ToString()) == IdAutorizacion && reg.Cells["CategoriaId"].Value.ToString() == "ZZZ")
                {
                    MessageBox.Show("¡Diagnostico Asociado ya fue elegido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDxIngreso.Focus();
                    txtDxIngreso.SelectAll();
                    error = true;
                    break;
                }
            }

            return error;
        }

        public bool ValidarDuplicidadMedicamento()
        {
            bool error;
            error = false;

            int NumDxMed;
            string  NumIdMed;
            NumDxMed = int.Parse(txtNumDXMed.Text);            
            NumIdMed = txtCodMedicamento.Text.Trim(); 

            foreach (DataGridViewRow reg in dgvMedicamento.Rows)
            {                
                //if (int.Parse(reg.Cells["Dx"].Value.ToString()) == NumDxMed && (reg.Cells["Id"].Value.ToString()) == NumIdMed)
                if ((reg.Cells["Id"].Value.ToString()) == NumIdMed)
                {
                    MessageBox.Show("¡El Medicamento ya fue elegido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodMedicamento.Clear();
                    txtCodMedicamento.Focus();
                    txtCodMedicamento.SelectAll();
                    txtCodMedicamento.Clear();
                    txtCantPreMed.Clear();
                    txtCantEntMed.Clear();

                    //cboEsquema.Enabled = false;
                    //txtCodMedicamento.Enabled = false;
                    txtCantPreMed.Enabled = false;
                    txtCantEntMed.Enabled = false;
                    error = true;
                    break;
                }
            }

            return error;
        }


        public bool ValidarDuplicidadMedicamentoEditar()
        {
            bool error;
            error = false;

            int NumDxMed;
            string NumIdMed;
            NumDxMed = int.Parse(txtNumDXMed.Text);
            NumIdMed = txtCodMedicamento.Text.Trim();

            foreach (DataGridViewRow reg in dgvMedicamento.Rows)
            {
                if ((reg.Cells["Id"].Value.ToString()) == NumIdMed)
                {
                    MessageBox.Show("¡El Medicamento ya fue elegido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodMedicamento.Focus();
                    txtCodMedicamento.SelectAll();

                    error = true;
                    break;
                }
            }

            return error;
        }

        public bool ValidarDuplicidadMedicamentoEditar2()
        {
            bool error;
            error = false;

            int NumDxMed;
            string NumIdMed;
            NumDxMed = int.Parse(txtNumDXMed.Text);
            NumIdMed = txtCodMedicamento.Text.Trim();

            foreach (DataGridViewRow reg in dgvMedicamento.Rows)
            {
                if ((reg.Cells["Id"].Value.ToString()) == NumIdMed && (int.Parse(reg.Cells["Dx"].Value.ToString()) != NumDxMed))
                {
                    MessageBox.Show("¡El Medicamento ya fue elegido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodMedicamento.Clear();
                    txtCodMedicamento.Focus();
                    txtCodMedicamento.SelectAll();
                    txtCodMedicamento.Clear();
                    txtCantPreMed.Clear();
                    txtCantEntMed.Clear();

                    //cboEsquema.Enabled = false;
                    //txtCodMedicamento.Enabled = false;
                    txtCantPreMed.Enabled = false;
                    txtCantEntMed.Enabled = false;

                    error = true;
                    break;
                }
            }

            return error;
        }

        public bool ValidarDuplicidadProcedimiento()
        {
            bool error;
            error = false;

            int NumDxProc;
            string NumIdProc;
            NumDxProc = int.Parse(txtNumDXProc.Text);
            NumIdProc = txtCodProcedimiento.Text.Trim();

            foreach (DataGridViewRow reg in dgvProcedimiento.Rows)
            {
                //if (int.Parse(reg.Cells["Dx"].Value.ToString()) == NumDxProc && (reg.Cells["Id"].Value.ToString()) == NumIdProc)
                if ((reg.Cells["Id"].Value.ToString()) == NumIdProc)
                {
                    MessageBox.Show("¡El Procedimiento ya fue elegido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodProcedimiento.Clear();
                    txtCantPreProc.Clear();
                    txtCantEntProc.Clear();
                    txtCodProcedimiento.Focus();
                    txtCodProcedimiento.SelectAll();

                    txtCantPreProc.Enabled = false;
                    txtCantEntProc.Enabled = false;

                    error = true;
                    break;
                }
            }
            return error;
        }

        public bool ValidarDuplicidadProcedimiento2()
        {
            bool error;
            error = false;

            int NumDxProc;
            string NumIdProc;
            NumDxProc = int.Parse(txtNumDXProc.Text);
            NumIdProc = txtCodProcedimiento.Text.Trim();

            foreach (DataGridViewRow reg in dgvProcedimiento.Rows)
            {
                //if (int.Parse(reg.Cells["Dx"].Value.ToString()) == NumDxProc && (reg.Cells["Id"].Value.ToString()) == NumIdProc)
                if ((reg.Cells["Id"].Value.ToString()) == NumIdProc && (int.Parse(reg.Cells["Dx"].Value.ToString()) != NumDxProc))
                {
                    MessageBox.Show("¡El Procedimiento ya fue elegido!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodProcedimiento.Clear();
                    txtCantPreProc.Clear();
                    txtCantEntProc.Clear();
                    txtCodProcedimiento.Focus();
                    txtCodProcedimiento.SelectAll();

                    txtCantPreProc.Enabled = false;
                    txtCantEntProc.Enabled = false;

                    error = true;
                    break;
                }
            }
            return error;
        }


        public bool ValidarEstablecimientoRefiere()
        {
            bool error;
            error = false;

            if (txtEESSReferencia.Text.Length > 0)
            {
                objEstablecimiento.Renaes = txtEESSReferencia.Text.Trim();
                if (objEstablecimientoBL.Establecimiento_BuscarxRenaesSIS(objEstablecimiento).Rows.Count > 0)
                {
                    lblEESSReferencia.Text = objEstablecimientoBL.Establecimiento_BuscarxRenaesSIS(objEstablecimiento).Rows[0][1].ToString();
                    error = false;
                }
                else
                {
                    //MessageBox.Show("¡Establecimiento No Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtEESSReferencia.Focus();
                    //txtEESSReferencia.SelectAll();
                    error = true;
                }
            }           

            return error;
        }

        public bool ValidarEstablecimientoContraRefiere()
        {
            bool error;
            error = false;

            if (txtEESSAsegurado.Text.Length > 0)
            {
                objEstablecimiento.Renaes = txtEESSAsegurado.Text.Trim();
                if (objEstablecimientoBL.Establecimiento_BuscarxRenaesSIS(objEstablecimiento).Rows.Count > 0)
                {
                    lblEESSAsegurado.Text = objEstablecimientoBL.Establecimiento_BuscarxRenaesSIS(objEstablecimiento).Rows[0][1].ToString();
                    error = false;
                }
                else
                {
                    MessageBox.Show("¡Establecimiento No Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEESSAsegurado.Focus();
                    txtEESSAsegurado.SelectAll();
                    error = true;
                }
            }

            return error;
        }

        public bool ValidarMedico()
        {
            bool error;
            error = false;

            if (txtDniResponsable.Text.Length > 0)
            {
                objMedico.DniDoctor = txtDniResponsable.Text.Trim();
                if (objMedicoBL.Medico_BuscarxDNI(objMedico).Rows.Count > 0)
                {
                    lblResponsable.Text = objMedicoBL.Medico_BuscarxDNI(objMedico).Rows[0][0].ToString();
                    lblCMP.Text = objMedicoBL.Medico_BuscarxDNI(objMedico).Rows[0][1].ToString();
                    lblEspecialidad.Text = objMedicoBL.Medico_BuscarxDNI(objMedico).Rows[0][2].ToString();
                    error = false;
                }
                else
                {
                    MessageBox.Show("¡Medico No Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDniResponsable.Focus();
                    txtDniResponsable.SelectAll();
                    error = true;
                }
            }

            return error;
        }

        #endregion

        # region KeyDown
        private void txtNumFua_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();


            if (txtNumFua.Text.ToString() == String.Empty)
            {
                txtNumFua.Focus();
                txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
                txtNumFua.SelectAll();
            }

            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if (txtNumDoc.TextLength != 0)
                {
                    if (ValidarAutorizacion(txtNumDoc.Text, VariablesGlobales.EstablecimientoId, DateTime.Parse(dtpFechaAtencion.Text)) != true) return;

                    if (LeerPacienteXDocumentoId(txtNumDoc.Text) != true)
                    {
                        if (ValidaLote() != true)
                        {
                            txtNumLote.Focus();
                            txtNumLote.SelectAll();
                            MessageBox.Show("¡Ingrese un Año correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (Convert.ToInt32(txtNumFua.Text.ToString()) != 0)
                            {
                                if (proceso == true) // Editar
                                {
                                    if (ValidarCorrelativo2(int.Parse(lblNroFua.Text)) == false)
                                    {
                                        DataTable dt = new DataTable();
                                        dt = objMovimientoPacienteBL.MovimientoPaciente_ListarxFua(objMovimientoPaciente);
                                        string correlativo = txtNumFua.Text;
                                        txtNumFua.Text = dt.Rows[0][2].ToString().Trim();
                                        txtNumFua.Focus();
                                        txtNumFua.SelectAll();
                                        MessageBox.Show("¡Año: " + txtNumLote.Text.Trim() + " - Número de Fua: " + correlativo + " Existente!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        EstadoControles(true);
                                        EstadoBotones(true);
                                        dtpFechaAtencion.Enabled = false;
                                        cboTipoDoc.Enabled = false;
                                        txtNumDoc.Enabled = false;
                                        txtNumFua.Enabled = false;
                                        txtNumLote.Enabled = false;
                                        cboResponsable.Enabled = false;

                                        txtFechaIngreso.Enabled = false;
                                        txtFechaAlta.Enabled = false;
                                        dtpFechaIngreso.Enabled = false;
                                        dtpFechaAlta.Enabled = false;

                                        cboRegimen.Focus();
                                        cboRegimen.SelectAll();

                                        btnGrabar.Enabled = false;
                                        btnEditar.Enabled = true;
                                    }
                                }
                                else
                                {
                                    if (ValidarCorrelativo() == false)
                                    {
                                        MessageBox.Show("¡Año: " + txtNumLote.Text.Trim() + " - Número de Fua: " + txtNumFua.Text.Trim() + " Existente!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        txtNumFua.Clear();
                                        txtNumFua.Focus();
                                        txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
                                        txtNumFua.SelectAll();
                                    }
                                    else
                                    {
                                        EstadoControles(true);
                                        EstadoBotones(true);
                                        dtpFechaAtencion.Enabled = false;
                                        cboTipoDoc.Enabled = false;
                                        txtNumDoc.Enabled = false;
                                        txtNumFua.Enabled = false;
                                        txtNumLote.Enabled = false;
                                        cboResponsable.Enabled = false;

                                        txtFechaIngreso.Enabled = false;
                                        txtFechaAlta.Enabled = false;
                                        dtpFechaIngreso.Enabled = false;
                                        dtpFechaAlta.Enabled = false;

                                        cboRegimen.Focus();
                                        cboRegimen.SelectAll();
                                    }

                                }

                            }
                            else { MessageBox.Show("Ingresar un Número de Fua válido", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumFua.Focus(); ; txtNumFua.SelectAll(); }
                        }
                    }
                } else { MessageBox.Show("Ingresar un Número de Documento", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumDoc.Focus(); ; txtNumDoc.SelectAll(); }
            }
        }

        public bool ValidarCorrelativo()
        {
            bool error;
            error = false;

            txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
            DataTable dt;
            objMovimientoPaciente.anno = txtNumLote.Text.Trim();
            objMovimientoPaciente.correlativo = txtNumFua.Text.Trim();
            dt = objMovimientoPacienteBL.MovimientoPaciente_Verificar(objMovimientoPaciente);

            if (dt.Rows.Count > 0) { error = false; } else { error = true;}

            return error;
        }

        public bool ValidarCorrelativo2(int Fua)
        {
            bool error;
            error = false;

            txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
            DataTable dt;
            objMovimientoPaciente.anno = txtNumLote.Text.Trim();
            objMovimientoPaciente.correlativo = txtNumFua.Text.Trim();
            dt = objMovimientoPacienteBL.MovimientoPaciente_Verificar2(objMovimientoPaciente);

            if (dt.Rows.Count > 0) { error = false; } else { error = true; }

            return error;
        }

        private void dtpFechaAtencion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) 
            {
                MovimientoPacienteBL ObjetoMovimientoPacienteBL = new MovimientoPacienteBL();
                DataTable dtFechaTarifario = new DataTable();

                if (VariablesGlobales.EstablecimientoId == 0)
                {
                    dtFechaTarifario = ObjetoMovimientoPacienteBL.MovimientoPaciente_FechaConvenio(int.Parse(lblEstablecimientoId.Text));
                }
                else
                {
                    dtFechaTarifario = ObjetoMovimientoPacienteBL.MovimientoPaciente_FechaConvenio(VariablesGlobales.EstablecimientoId);
                }

                DateTime FechaConvenio = Convert.ToDateTime(dtFechaTarifario.Rows[0][3].ToString());
                DateTime FechaAtencion = DateTime.Parse(dtpFechaAtencion.Text);
                DateTime FechaRegistro = DateTime.Today;
                DateTime FechaServidor = DateTime.Today;

                if (FechaAtencion >= FechaConvenio)
                {
                    if (FechaAtencion <= FechaServidor)
                    {
                        txtNumLote.Text = dtpFechaAtencion.Text.ToString().Substring(8, 2); cboTipoDoc.Focus();
                    }
                    else 
                    {
                        dtpFechaAtencion.Value = FechaServidor;                        
                        MessageBox.Show("¡Fecha de Atencion debe ser Menor o igual a la Fecha Actual!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                else
                {
                    dtpFechaAtencion.Value = FechaServidor;
                    MessageBox.Show("¡Fecha de Atencion debe ser Mayor o igual a la Fecha Convenio! - Fecha Convenio: " + FechaConvenio.ToString("D"), "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cboTipoDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) 
            {
                txtNumDoc.Focus();
            }
        }

        private void txtNumDoc_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (VariablesGlobales.EstablecimientoId != 0)
                {
                    try { ObtenerPacienteViaWS(VariablesGlobales.EstablecimientoId); }
                    catch { }
                }
                if (LeerPacienteXDocumentoId(txtNumDoc.Text) == true) return;
                LeerAutorizacion(txtNumDoc.Text, VariablesGlobales.EstablecimientoId, DateTime.Parse(dtpFechaAtencion.Text));
            }
            
        }

        private void cboRegimen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (cboRegimen.SelectedIndex == 0)
                {
                    cboInstitucion.Focus();
                    cboInstitucion.SelectAll();
                }
                else
                {
                    txtNumAfiliacion.Focus();
                }                
            }
        }

        private void txtNumAfiliacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cboInstitucion.Focus();
                cboInstitucion.SelectAll();
            }
        }

        private void cboInstitucion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (cboInstitucion.SelectedIndex == 0)
                {
                    cboTipoIngreso.Focus();
                    cboTipoIngreso.SelectAll();
                }
                else
                {
                    txtCodSeguro.Focus();
                }                
            }
        }

        private void txtCodSeguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cboTipoIngreso.Focus();
                cboTipoIngreso.SelectAll();
            }
        }

        private void cboTipoIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cboLugarAtencion.Focus();
                cboLugarAtencion.SelectAll();
            }
        }

        private void cboLugarAtencion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cboPersonalAtencion.Focus();
                cboPersonalAtencion.SelectAll();
            }
        }

        private void cboPersonalAtencion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtHC.Focus();
            }
        }

        private void txtHC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (cboTipoIngreso.SelectedIndex == 0)
                {
                    cboTipoPrestacion.Focus();
                    cboTipoPrestacion.SelectAll();
                }
                else
                {
                    if (cboTipoIngreso.SelectedIndex == 1)
                    {
                        cboTipoPrestacion.Focus();
                        cboTipoPrestacion.SelectAll();
                    }
                    else
                    {
                        if (cboTipoIngreso.SelectedIndex == 2)
                        {
                            cboTipoPrestacion.Focus();
                            cboTipoPrestacion.SelectAll();
                        }
                        else
                        {
                            if (cboTipoIngreso.SelectedIndex == 3)
                            {
                                if (txtFechaIngreso.Enabled == false)
                                {
                                    cboDestinoAsegurado.Focus();
                                    cboDestinoAsegurado.SelectAll();
                                }
                                else
                                {
                                    txtFechaIngreso.Focus();
                                }   
                            }
                        }
                    }
                }                
            }
        }

        private void cboTipoPrestacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtEESSReferencia.Focus();
            }
        }

        private void txtEESSReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarEstablecimientoRefiere() == true) return;
                txtHojaReferencia.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarEESSReferencia_Click(sender, e);
                }
            }
        }

        private void txtHojaReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtFechaIngreso.Enabled == false)
                {
                    cboDestinoAsegurado.Focus();
                    cboDestinoAsegurado.SelectAll();
                }
                else
                {
                    txtFechaIngreso.Focus();
                }                
            }
        }

        private void txtFechaIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtFechaAlta.Focus();
            }
        }

        private void txtFechaAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cboDestinoAsegurado.Focus();
                cboDestinoAsegurado.SelectAll();
            }
        } 

        private void cboDestinoAsegurado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (cboDestinoAsegurado.SelectedIndex == 0)
                {
                    txtDniResponsable.Focus();
                }
                else
                {
                    txtEESSAsegurado.Focus();
                }                
            }
        }

        private void txtEESSAsegurado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarEstablecimientoContraRefiere() == true) return;
                txtHojaRefCont.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarEESSAsegurado_Click(sender, e);
                }
            }
        }        

        private void txtHojaRefCont_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtDniResponsable.Focus();
            }
        }

        private void txtDniResponsable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarMedico() == true) return;
                cboResponsable.Focus();
                cboResponsable.SelectAll();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarResponsable_Click(sender, e);
                }
            }
        }

        private void cboResponsable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {                
                btnGrabar.Focus();
            }            
        }

        private void txtNumDX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter  || e.KeyCode == Keys.Tab)
            {
                if (txtNumDX.Text != "")
                {
                    if (dgvDiagnostico.RowCount > 0)
                    {
                        if (ValidarDuplicidadAutorizacion() == true) return;
                    }

                    if (dgvDiagnostico.RowCount > 0)
                    {
                        if (ValidarDuplicidadDxAsociado() == true) return;
                    }

                    int valor = int.Parse(txtNumDX.Text);
                    IdAutorizacion = 0;

                    foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                    {
                        if (int.Parse(reg.Cells["Nro"].Value.ToString()) == valor)
                        {
                            IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                            CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();

                            if ((CategoriaElegida == "ZZZ"))
                            {
                                if (ValidarEnfermedadPrincipal() != true)
                                {
                                    txtNumDX.Focus(); txtNumDX.SelectAll();
                                    txtDxIngreso.Text = String.Empty;
                                    txtDxEgreso.Text = String.Empty;
                                    txtDxIngreso.Enabled = false;
                                    txtDxEgreso.Enabled = false;
                                    MessageBox.Show("¡Ingrese un Diagnostico Principal Previamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                { txtDxIngreso.Text = String.Empty; txtDxIngreso.Enabled = true; txtDxIngreso.Focus(); txtDxIngreso.SelectAll(); }
                            }
                            else { txtDxIngreso.Text = String.Empty; txtDxIngreso.Enabled = true; txtDxIngreso.Focus(); txtDxIngreso.SelectAll(); }
                            break;
                        }
                    }

                    if (IdAutorizacion == 0)
                    {
                        txtNumDX.Focus();
                        txtNumDX.SelectAll();
                        txtDxIngreso.Text = String.Empty;
                        txtDxEgreso.Text = String.Empty;
                        txtDxIngreso.Enabled = false;
                        txtDxEgreso.Enabled = false;
                        MessageBox.Show("¡Debe ingresar una Autorizacion Valida!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("¡Ingrese una Autorizacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumDX.Focus(); txtNumDX.SelectAll(); }
            }
        }


        public bool ValidarEnfermedadPrincipal()
        {
            bool Valor;
            DataTable dt = new DataTable();
            dt = objMovimientoPacienteBL.MovimientoPaciente_ValidarEnfermedadPrincipal(Fua);

            if (dt.Rows.Count > 0)
            {
                Valor = true;
            }
            else
            {
                Valor = false;
            }
            return Valor;
        }

        private void txtDxIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if (ValidarAgregarDxIngreso() != true) 
                {
                   txtDxEgreso.Enabled = true;
                   txtDxEgreso.Focus();
                }
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarDxIngreso_Click(sender, e);
                }
            }
        }


        private void txtDxEgreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btnAgregarAutorizacion.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarDxEgreso_Click(sender, e);
                }
            }
        }

        private void btnAgregarAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtNumDX.Focus();
            }
        }

        private void txtNumDXMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                if (ValidarDxMedicamento() != true)
                {                    
                    ObtenerEsquemaPorCategoria();
                    cboEsquema.Enabled = true;
                    cboEsquema.Focus();
                    cboEsquema.SelectAll();
                    txtCodMedicamento.Enabled = true;
                }
            }
        }

        private void cboEsquema_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtCodMedicamento.Focus();
            }
        }

        private void txtCodMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarIdMedicamento() == true) return;
                //if (ValidarDuplicidadMedicamentoEditar2() == true) return;
                txtCantPreMed.Enabled = true;
                txtCantPreMed.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarMedicamento_Click(sender, e);
                }
            }
        }

        private void txtCantPreMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtCantEntMed.Enabled = true;
                txtCantEntMed.Text = txtCantPreMed.Text;
                txtCantEntMed.Focus();
            }
        }

        private void txtCantEntMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarCantPrescritaMed() == true) return;
                if (ValidarCantEntregadaMed() == true) return;
                btnAgregarMedicamento.Focus();
            }
        }

        private void btnAgregarMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtNumDXMed.Focus();
            }
        }

        private void txtNumDXProc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarDxProcedimiento() != true)
                {
                    txtCodProcedimiento.Enabled = true;
                    txtCodProcedimiento.Focus();
                }
            }
        }

        private void txtCodProcedimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarIdProcedimiento() == true) return;
                //if (ValidarDuplicidadProcedimiento2() == true) return;
                txtCantPreProc.Enabled = true;
                txtCantPreProc.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.F7)
                {
                    btnBuscarProcedimiento_Click(sender, e);
                }
            }
        }

        private void txtCantPreProc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtCantEntProc.Enabled = true;
                txtCantEntProc.Text = txtCantPreProc.Text;
                txtCantEntProc.Focus();
            }
        }

        private void txtCantEntProc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ValidarCantPrescritaProc() == true) return;
                if (ValidarCantEntregadaProc() == true) return;
                opcTercero.Focus();
            }
        }

        private void btnAgregarProcedimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtNumDXProc.Focus();
            }
        }

        private void opcTercero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (opcTercero.Checked == true)
                {                    
                    txtTercero.Focus();
                }
                else
                {
                    if (opcTercero.Checked == false)
                    {
                        btnAgregarProcedimiento.Focus();
                    }
                }                
            }
        }

        private void txtTercero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btnAgregarProcedimiento.Focus();
            }
        } 

        #endregion

        # region Click

        private void tbpDiagnostico_Click(object sender, EventArgs e)
        {
            txtNumDX.Focus();
        }

        private void tbpMedicamento_Click(object sender, EventArgs e)
        {
            txtNumDXMed.Focus();
        }

        private void tbpProcedimiento_Click(object sender, EventArgs e)
        {
            txtNumDXProc.Focus();
        }

        #endregion

        protected void LeerAutorizacion(string Documento, int establecimiento,DateTime fecha)
        {
            DataTable dt = new DataTable();
            objAutorizacion.PacienteId = Documento;
            //objAutorizacion.TipoDocumentoId = TipoDocumentoId;
            objAutorizacion.EstablecimientoId = establecimiento;
            objAutorizacion.Fecha = fecha;            
            dt = objAutorizacionBL.Autorizacion_PacienteIdxEstablecimientoId(objAutorizacion);          
            try
            {
                if (dt.Rows.Count > 0)
                {
                    DTA.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        RWA = DTA.NewRow();
                        RWA[0] = i + 1;
                        RWA[1] = int.Parse(dt.Rows[i][0].ToString());
                        RWA[2] = dt.Rows[i][1].ToString();
                        RWA[3] = dt.Rows[i][2].ToString();
                        RWA[4] = int.Parse(dt.Rows[i][3].ToString());
                        RWA[5] = dt.Rows[i][4].ToString();
                        RWA[6] = dt.Rows[i][5].ToString();
                        DTA.Rows.Add(RWA);
                    }
                    dgvAutorizacion.DataSource = DTA;
                    NoOrderColumns(1);
                    foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                    {
                        if (reg.Cells["Observacion"].Value.ToString() == "Solicitar Autorizacion")
                        {
                            reg.DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        }
                    }

                    //txtNumFua.Focus(); 
                    txtNumLote.Focus();
                }
                else
                {
                    DTA.Clear();
                    //LimpiarControles();
                    dtpFechaAtencion.Enabled = true;
                    cboTipoDoc.Enabled = true;
                    txtNumDoc.Enabled = true;
                    txtNumDoc.Focus();
                    txtNumDoc.SelectAll();
                    MessageBox.Show("¡Paciente no tiene autorizaciones activas!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public bool ValidarAutorizacion(string Documento, int establecimiento, DateTime fecha)
        {
            bool valor;
            valor = false;

            DataTable dt = new DataTable();
            objAutorizacion.PacienteId = Documento;
            objAutorizacion.EstablecimientoId = establecimiento;
            objAutorizacion.Fecha = fecha;
            dt = objAutorizacionBL.Autorizacion_PacienteIdxEstablecimientoId(objAutorizacion);

                if (dt.Rows.Count > 0)
                {
                    DTA.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        RWA = DTA.NewRow();
                        RWA[0] = i + 1;
                        RWA[1] = int.Parse(dt.Rows[i][0].ToString());
                        RWA[2] = dt.Rows[i][1].ToString();
                        RWA[3] = dt.Rows[i][2].ToString();
                        RWA[4] = int.Parse(dt.Rows[i][3].ToString());
                        RWA[5] = dt.Rows[i][4].ToString();
                        RWA[6] = dt.Rows[i][5].ToString();
                        DTA.Rows.Add(RWA);
                    }
                    dgvAutorizacion.DataSource = DTA;
                    NoOrderColumns(1);
                    foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                    {
                        if (reg.Cells["Observacion"].Value.ToString() == "Solicitar Autorizacion")
                        {
                            reg.DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        }
                    }

                    //txtNumFua.Focus(); 
                    txtNumLote.Focus();
                    valor = true;
                }
                else
                {
                    DTA.Clear();
                    //LimpiarControles();
                    dtpFechaAtencion.Enabled = true;
                    cboTipoDoc.Enabled = true;
                    txtNumDoc.Enabled = true;
                    txtNumDoc.Focus();
                    txtNumDoc.SelectAll();
                    valor = false;
                    MessageBox.Show("¡Paciente no tiene autorizaciones activas!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            return valor;
        }

        
        public bool LeerPacienteXDocumentoId(string dni)
        {
            bool error;
            error = false;

            DataTable dt = new DataTable();
            objPaciente.TipoDocumentoId = byte.Parse(cboTipoDoc.SelectedValue.ToString());
            objPaciente.NumeroDocumento = dni;
            dt = objPacienteBL.Paciente_PacienteXDocumentoId(objPaciente);
            try
            {
                if(txtNumDoc.Text!=String.Empty)
                {
                    if (dt.Rows.Count > 0)
                    {
                        lblApePaterno.Text = dt.Rows[0][1].ToString();
                        lblApeMaterno.Text = dt.Rows[0][2].ToString();                    
                        lblNombres.Text = dt.Rows[0][3].ToString();
                        txtNumFua.Focus();
                        txtNumFua.Focus();
                        txtNumFua.SelectAll();

                        dtpFechaAtencion.Enabled = false;
                        cboTipoDoc.Enabled = false;
                        txtNumDoc.Enabled = false;

                        txtFechaIngreso.Enabled = false;
                        txtFechaAlta.Enabled = false;
                    }
                    else
                    {
                        error = true;
                        MessageBox.Show("¡Paciente no Existe!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DTA.Clear();
                        cboTipoDoc.SelectedIndex = 0;
                        lblApeMaterno.Text = "";
                        lblApePaterno.Text = "";
                        lblNombres.Text = "";
                        //txtNumFua.Text = "";
                        txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
                        cboTipoDoc.SelectedValue = 1;
                        cboResponsable.Enabled = false;
                        txtNumDoc.Enabled = true;
                        txtNumDoc.Clear();
                        txtNumDoc.Focus();
                        txtNumDoc.SelectAll();
                    }

                }
                else
                {
                    error = true;
                    txtNumDoc.Focus();
                    txtNumDoc.SelectAll();
                    MessageBox.Show("¡Ingrese Numero de Documento!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

                return error;
            }
            catch (Exception ex)
            {
                throw ex;
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

                string val = dt.Rows[0][2].ToString().Trim();
                txtNumFua.Text = val.PadLeft(8, '0').Trim();

                lblEstablecimientoId.Text = dt.Rows[0][3].ToString();
                cboTipoIngreso.SelectedValue = dt.Rows[0][4].ToString();
                dtpFechaAtencion.Text = dt.Rows[0][5].ToString();
                cboLugarAtencion.SelectedValue = dt.Rows[0][6].ToString();
                txtHC.Text = dt.Rows[0][7].ToString();
                cboTipoPrestacion.SelectedValue = dt.Rows[0][8].ToString();
                cboPersonalAtencion.SelectedValue = dt.Rows[0][9].ToString();
                txtHojaReferencia.Text = dt.Rows[0][10].ToString();
                txtEESSReferencia.Text = dt.Rows[0][11].ToString();
                //if (ValidarEstablecimientoRefiere() == true) return;

                if (dt.Rows[0][12].ToString() == String.Empty)
                {
                    cboDestinoAsegurado.SelectedIndex = 0;
                }
                else
                {
                    cboDestinoAsegurado.SelectedValue = dt.Rows[0][12].ToString();
                }

                txtEESSAsegurado.Text = dt.Rows[0][13].ToString();
                //if (ValidarEstablecimientoContraRefiere() == true) return;
                txtHojaRefCont.Text = dt.Rows[0][14].ToString();
                txtFechaIngreso.Text = dt.Rows[0][15].ToString();
                txtFechaAlta.Text = dt.Rows[0][16].ToString();
                txtDniResponsable.Text = dt.Rows[0][17].ToString();
                lblCMP.Text = dt.Rows[0][18].ToString();
                lblResponsable.Text = dt.Rows[0][19].ToString();
                lblEspecialidad.Text = dt.Rows[0][20].ToString();

                if (dt.Rows[0][21].ToString() == String.Empty)
                {
                    cboInstitucion.SelectedIndex = 0;
                }
                else
                {
                    cboInstitucion.SelectedValue = dt.Rows[0][21].ToString();
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
                //dtpFechaAtencion.Enabled = false;
                cboTipoDoc.Enabled = false;
                txtNumDoc.Enabled = false;
                txtCodMedicamento.Enabled = false;
            }
        }

        private void btnAgregarAutorizacion_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;


            if (Fua > 0)
            {
                if (ValidarAgregarAutorizacion() == true) return;

                int NumDx;
                NumDx = int.Parse(txtNumDX.Text);
                IdAutorizacion = 0;
                CategoriaElegida = "";

                //Recorrer dgvAutorizacion
                foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == NumDx)
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();

                        if ((CategoriaElegida == "ZZZ"))
                        {
                            if (ValidarEnfermedadPrincipal() != true)
                            { MessageBox.Show("¡Ingrese un Diagnostico Principal Previamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumDX.Focus(); txtNumDX.SelectAll(); }
                            else { txtDxIngreso.Focus(); txtDxIngreso.SelectAll(); }
                        }
                        else { txtDxIngreso.Focus(); txtDxIngreso.SelectAll(); }
                        break;

                    }
                }             

                if (IdAutorizacion > 0)
                {
                    if (dgvDiagnostico.RowCount > 0)
                    {
                        if (ValidarDuplicidadAutorizacion() == true) return;
                    }

                    if (dgvDiagnostico.RowCount > 0)
                    {
                        if (ValidarDuplicidadDxAsociado() == true) return;
                    }

                    if (ValidarAgregarDxIngreso() == true) return;
                    if (ValidarAgregarDxEgreso() == true) return;

                    DataTable dt = new DataTable();
                    objAutorizacion.AutorizacionId = IdAutorizacion;
                    dt = objAutorizacionBL.Autorizacion_ListarxAutorizacionId(objAutorizacion);
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            objMovimientoPacienteDetalle.Fua = Fua;                            
                            objMovimientoPacienteDetalle.DetalleId = int.Parse(objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_NuevoDetalleId(objMovimientoPacienteDetalle).Rows[0][0].ToString());
                            objMovimientoPacienteDetalle.AutorizacionId = int.Parse(dt.Rows[0]["AutorizacionId"].ToString());
                            objMovimientoPacienteDetalle.EnfermedadIngresoId = txtDxIngreso.Text;
                            objMovimientoPacienteDetalle.TipoDiagnosticoIngresoId = "D";
                            objMovimientoPacienteDetalle.EstadioId = short.Parse(dt.Rows[0]["EstadioId"].ToString());
                            objMovimientoPacienteDetalle.FaseId = int.Parse(dt.Rows[0]["FaseId"].ToString());

                            if (this.txtDxEgreso.Text.Length == 0)
                                objMovimientoPacienteDetalle.EnfermedadEgresoId = String.Empty;
                            else
                                objMovimientoPacienteDetalle.EnfermedadEgresoId = txtDxEgreso.Text;
                            
                            objMovimientoPacienteDetalle.TipoDiagnosticoEgresoId = "D";
                            objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_Insertar(objMovimientoPacienteDetalle);
                            dgvDiagnostico.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                            dgvDiagnosticoB.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                            NoOrderColumns(2);
                            dgvDiagnosticoC.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                            NoOrderColumns(3);
                        }
                        else
                        {
                            MessageBox.Show("¡Paciente no tiene autorizaciones activas!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumDoc.Clear();
                            txtNumDoc.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    LimpiarControlesDiagnostico();
                    txtDxIngreso.Text = String.Empty;
                    txtDxEgreso.Text = String.Empty;
                    txtDxIngreso.Enabled = false;
                    txtDxEgreso.Enabled = false;
                }
                else
                {
                    MessageBox.Show("¡Debe Seleccionar una Autorizacion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumDX.Focus();
                    txtNumDX.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("¡Debe Registrar Datos Basicos de Fua!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }            
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;          
            if (ValidarDxMedicamento() == true) return;
            if (cboEsquema.SelectedIndex == -1) {MessageBox.Show("!Seleccione un esquema¡", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (ValidarIdMedicamento() == true) return;            

            if (dgvMedicamento.RowCount > 0)
            {
                if (ValidarDuplicidadMedicamento() == true) return;
            }

            if (ValidarCantPrescritaMed() == true) return;
            if (ValidarCantEntregadaMed() == true) return;

            DataTable dt = new DataTable();

            string FecAtencion = dtpFechaAtencion.Text;
            FecAtencion = FecAtencion.Substring(0, 2) + FecAtencion.Substring(3, 2) + FecAtencion.Substring(6, 4);

            if (VariablesGlobales.EstablecimientoId == 0)
            {
                dt = objMedicamentoBL.Medicamento_CostoMedicamento(int.Parse(lblCodMedicamento.Text), int.Parse(lblEstablecimientoId.Text), IdAutorizacion, FecAtencion);
            }
            else
            {
                dt = objMedicamentoBL.Medicamento_CostoMedicamento(int.Parse(lblCodMedicamento.Text), VariablesGlobales.EstablecimientoId, IdAutorizacion, FecAtencion);
            } 

            try
            {
                if (dt.Rows.Count > 0)
                {                    
                    objMovimientoMedicamento.Fua = Fua;
                    objMovimientoMedicamento.DetalleId = int.Parse(txtNumDXMed.Text);
                    objMovimientoMedicamento.MedicamentoId = int.Parse(lblCodMedicamento.Text);
                    objMovimientoMedicamento.EsquemaId = short.Parse(cboEsquema.SelectedValue.ToString());
                    objMovimientoMedicamento.Cantidad = int.Parse(txtCantEntMed.Text);
                    //objMovimientoMedicamento.Monto = decimal.Parse(dt.Rows[0]["monto"].ToString());
                    objMovimientoMedicamento.Monto = 0;
                    objMovimientoMedicamento.Prescrito = int.Parse(txtCantPreMed.Text);
                    objMovimientoMedicamento.Consumo = 0;
                    objMovimientoMedicamento.Convenio = 0;
                    objMovimientoMedicamento.obs = "";
                    objMovimientoMedicamento.paquete = bool.Parse(dt.Rows[0]["paquete"].ToString());
                    objMovimientoMedicamentoBL.MovimientoMedicamento_Insertar(objMovimientoMedicamento);
                    dgvMedicamento.DataSource = objMovimientoMedicamentoBL.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
                    dgvMedicamento.Columns["Paquete"].Visible = false;                                        
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
                        
            dt.Clear();
            LimpiarControlesMedicamento();
            txtNumDXMed.Focus();
            txtNumDXMed.SelectAll();
        }

        private void btnAgregarProcedimiento_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;
            if (ValidarDxProcedimiento() == true) return;
            if (ValidarIdProcedimiento() == true) return;
            if (ValidarIPRESSProcedimiento() == true) return;

            if (dgvProcedimiento.RowCount > 0)
            {
                if (ValidarDuplicidadProcedimiento() == true) return;
            }

            if (ValidarCantPrescritaProc() == true) return;
            if (ValidarCantEntregadaProc() == true) return;

            DataTable dt = new DataTable();

            string FecAtencion = dtpFechaAtencion.Text;
            FecAtencion = FecAtencion.Substring(0, 2) + FecAtencion.Substring(3, 2) + FecAtencion.Substring(6, 4);

            if (VariablesGlobales.EstablecimientoId == 0)
            {
                //dt = objProcedimientoBL.Procedimiento_CostoProcedimiento(lblCodProcedimiento.Text, int.Parse(lblEstablecimientoId.Text), IdAutorizacion, FecAtencion);
                dt = objProcedimientoBL.Procedimiento_CostoProcedimiento(ProcedimientoId_SisId, int.Parse(lblEstablecimientoId.Text), IdAutorizacion, FecAtencion);
            }
            else
            {
                //dt = objProcedimientoBL.Procedimiento_CostoProcedimiento(lblCodProcedimiento.Text, VariablesGlobales.EstablecimientoId, IdAutorizacion, FecAtencion);
                dt = objProcedimientoBL.Procedimiento_CostoProcedimiento(ProcedimientoId_SisId, VariablesGlobales.EstablecimientoId, IdAutorizacion, FecAtencion);
            }

            try
            {
                if (dt.Rows.Count > 0)
                {                 
                    objMovimientoProcedimiento.Fua = Fua;
                    objMovimientoProcedimiento.DetalleId = int.Parse(txtNumDXProc.Text);
                    objMovimientoProcedimiento.ProcedimientoId = ProcedimientoId_SisId;//int.Parse(lblCodProcedimiento.Text);
                    objMovimientoProcedimiento.Cantidad = int.Parse(txtCantEntProc.Text);
                    //objMovimientoProcedimiento.Monto = decimal.Parse(dt.Rows[0]["monto"].ToString());
                    objMovimientoProcedimiento.Monto = 0;
                    objMovimientoProcedimiento.Prescrito = int.Parse(txtCantPreProc.Text);
                    objMovimientoProcedimiento.Consumo = 0;
                    objMovimientoProcedimiento.Convenio = 0;
                    objMovimientoProcedimiento.obs = "";
                    objMovimientoProcedimiento.paquete = bool.Parse(dt.Rows[0]["paquete"].ToString());
                    if (opcTercero.Checked == true)
                    {
                        objMovimientoProcedimiento.ProveedorTercero = true;
                    }
                    else
                    {
                        objMovimientoProcedimiento.ProveedorTercero = false; 
                    }                    
                    objMovimientoProcedimiento.ProveedorCodigo = txtTercero.Text;
                    objMovimientoProcedimientoBL.MovimientoProcedimiento_Insertar(objMovimientoProcedimiento);
                    dgvProcedimiento.DataSource = objMovimientoProcedimientoBL.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
                    dgvProcedimiento.Columns["Paquete"].Visible = false;                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            dt.Clear();
            LimpiarControlesProcedimiento();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (LeerPacienteXDocumentoId(txtNumDoc.Text) != true) 
            {

            if (ValidaLote() != true)
            {
                txtNumLote.Focus();
                txtNumLote.SelectAll();
                MessageBox.Show("¡Ingrese un Año correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else { 
                    if (txtNumDoc.TextLength > 0 || txtNumDoc.Text != String.Empty) 
                    {
                      if(ValidarAutorizacion(txtNumDoc.Text, VariablesGlobales.EstablecimientoId, DateTime.Parse(dtpFechaAtencion.Text))!=true) return;

                        if (Convert.ToInt32(txtNumFua.Text.ToString()) != 0)
                        {
                            if (ValidarDatosMovimientoPaciente()==true) {return; }

                            Fua = int.Parse(objMovimientoPacienteBL.MovimientoPaciente_Nuevo().Rows[0][0].ToString());
                            lblNroFua.Text = Fua.ToString();
                            objMovimientoPaciente.Fua = Fua;
                            objMovimientoPaciente.anno = this.txtNumLote.Text.Trim();
                            txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
                            objMovimientoPaciente.correlativo = this.txtNumFua.Text.Trim();
                            objMovimientoPaciente.EstablecimientoId = VariablesGlobales.EstablecimientoId;
                            objMovimientoPaciente.TipoIngresoId = byte.Parse(this.cboTipoIngreso.SelectedValue.ToString());
                            objMovimientoPaciente.FechaAtencion = DateTime.Parse(ValidarIsNull(dtpFechaAtencion.Text));
                            objMovimientoPaciente.LugarAtencionId = byte.Parse(this.cboLugarAtencion.SelectedValue.ToString());
                            objMovimientoPaciente.NumeroHistoria = this.txtHC.Text.Trim();
                            objMovimientoPaciente.TipoPrestacionId = int.Parse(this.cboTipoPrestacion.SelectedValue.ToString());
                            objMovimientoPaciente.PersonalAtiendeId = byte.Parse(this.cboPersonalAtencion.SelectedValue.ToString());
                            objMovimientoPaciente.NumeroHojaRefiere = this.txtHojaReferencia.Text.Trim();
                            objMovimientoPaciente.EstablecimientoRefiereId = this.txtEESSReferencia.Text.Trim();

                            if (this.cboDestinoAsegurado.SelectedIndex == 0)
                                objMovimientoPaciente.DestinoAseguradoId = null;
                            else
                                objMovimientoPaciente.DestinoAseguradoId = byte.Parse(this.cboDestinoAsegurado.SelectedValue.ToString());

                            objMovimientoPaciente.EstablecimientoContraRefiereId = this.txtEESSAsegurado.Text.Trim();
                            objMovimientoPaciente.NumeroHojaContraRefiere = this.txtHojaRefCont.Text.Trim();

                            if (this.txtFechaIngreso.Text.Length == 0)
                                objMovimientoPaciente.FechaIngreso = null;
                            else
                                objMovimientoPaciente.FechaIngreso = DateTime.Parse(ValidarIsNull(txtFechaIngreso.Text));

                            if (this.txtFechaAlta.Text.Length == 0)
                                objMovimientoPaciente.FechaAlta = null;
                            else
                                objMovimientoPaciente.FechaAlta = DateTime.Parse(ValidarIsNull(txtFechaAlta.Text));

                            objMovimientoPaciente.DNIResponsable = this.txtDniResponsable.Text.Trim();
                            objMovimientoPaciente.Colegiatura = this.lblCMP.Text.Trim();
                            objMovimientoPaciente.NombresResponsable = this.lblResponsable.Text;
                            objMovimientoPaciente.Especialidad = this.lblEspecialidad.Text.Trim();

                            if (this.cboInstitucion.SelectedIndex == 0)
                                objMovimientoPaciente.InstitucionId = null;
                            else
                                objMovimientoPaciente.InstitucionId = byte.Parse(this.cboInstitucion.SelectedValue.ToString());

                            objMovimientoPaciente.NumeroSeguro = this.txtCodSeguro.Text.Trim();
                            objMovimientoPaciente.ResponsableAtencionId = byte.Parse(this.cboResponsable.SelectedValue.ToString());
                            objMovimientoPaciente.PacienteId = this.txtNumDoc.Text.Trim();
                            objMovimientoPaciente.login = VariablesGlobales.Login;

                            if (this.cboRegimen.SelectedIndex == 0)
                                objMovimientoPaciente.TipoRegimenId = null;
                            else
                                objMovimientoPaciente.TipoRegimenId = byte.Parse(this.cboRegimen.SelectedValue.ToString());

                            objMovimientoPaciente.Afiliacion = this.txtNumAfiliacion.Text.Trim();

                            //if (this.cboTipoDoc.SelectedIndex == 0)
                            //    objMovimientoPaciente.TipoDocumentoId = null;
                            //else
                            //    objMovimientoPaciente.TipoDocumentoId = byte.Parse(this.cboTipoDoc.SelectedValue.ToString());

                            objMovimientoPacienteBL.MovimientoPaciente_Insertar(objMovimientoPaciente);
                            EstadoControles(false);
                            EstadoBotones(false);
                            LimpiarControlesDiagnostico();
                            LimpiarControlesMedicamento();
                            LimpiarControlesProcedimiento();
                            tbcDetalleFua.Enabled = true;
                            txtEESSAsegurado.Enabled = false;
                            txtHojaRefCont.Enabled = false;

                            lblMensaje.Text = "Se Registro Fua N° " + Fua + ", Resgistrar Detalle";
                            MessageBox.Show("Fua Registrado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { MessageBox.Show("Ingresar un Número de Fua válido", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumFua.Focus(); ; txtNumFua.SelectAll(); }

                    }
                    else { MessageBox.Show("Ingresar N° de Documento", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumDoc.Focus(); txtNumDoc.SelectAll(); }

            }
        }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaAtencion_ValueChanged(sender, e);
            EstadoControles(true);
            EstadoBotones(true);
            LimpiarControles();
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaIngreso = DateTime.Parse(dtpFechaIngreso.Text);
            DateTime FechaAlta = DateTime.Parse(dtpFechaAlta.Text);
            DateTime FechaServidor = DateTime.Today;

            if (FechaIngreso > FechaAlta)
            {
                MessageBox.Show("¡La Fecha de Ingreso debe ser Menor a la Fecha de Alta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFechaIngreso.Text = FechaServidor.ToString();
                dtpFechaIngreso.Focus();

            }
            else
            {
                txtFechaIngreso.Text = dtpFechaIngreso.Value.Date.ToShortDateString();
                dtpFechaAlta.Focus();
            }
        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaIngreso = DateTime.Parse(dtpFechaIngreso.Text);
            DateTime FechaAlta = DateTime.Parse(dtpFechaAlta.Text);
            DateTime FechaServidor = DateTime.Today;

            if (FechaAlta < FechaIngreso)
            {
                MessageBox.Show("¡La Fecha de Alta debe ser Mayor a la Fecha de Ingreso!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFechaAlta.Text = FechaServidor.ToString();
                dtpFechaAlta.Focus();

            }
            else
            {
                txtFechaAlta.Text = dtpFechaAlta.Value.Date.ToShortDateString();
                cboDestinoAsegurado.Focus();
                cboDestinoAsegurado.SelectAll();
            }
        }

        private void dtpFechaAtencion_ValueChanged(object sender, EventArgs e)
        {
            //MovimientoPacienteBL ObjetoMovimientoPacienteBL = new MovimientoPacienteBL();
            //DataTable dtFechaTarifario = new DataTable();

            //if (VariablesGlobales.EstablecimientoId == 0)
            //{
            //    dtFechaTarifario = ObjetoMovimientoPacienteBL.MovimientoPaciente_FechaConvenio(int.Parse(lblEstablecimientoId.Text));
            //}
            //else
            //{
            //    dtFechaTarifario = ObjetoMovimientoPacienteBL.MovimientoPaciente_FechaConvenio(VariablesGlobales.EstablecimientoId);
            //}

            //DateTime FechaConvenio = Convert.ToDateTime(dtFechaTarifario.Rows[0][3].ToString());
            //DateTime FechaAtencion = DateTime.Parse(dtpFechaAtencion.Text);
            //DateTime FechaRegistro = DateTime.Today;
            //DateTime FechaServidor = DateTime.Today;

            //if (FechaAtencion >= FechaConvenio)
            //{
            //    if (FechaAtencion <= FechaServidor)
            //    {
            //        txtNumLote.Text = dtpFechaAtencion.Text.ToString().Substring(8, 2); cboTipoDoc.Focus();
            //    }
            //    else 
            //    {
            //        dtpFechaAtencion.Value = FechaServidor;
            //        MessageBox.Show("¡Fecha de Atencion debe ser Menor o igual a la Fecha Actual!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            //    }
            //}
            //else
            //{
            //    dtpFechaAtencion.Value = FechaServidor;
            //    MessageBox.Show("¡Fecha de Atencion debe ser Mayor o igual a la Fecha Convenio! - Fecha Convenio: " + FechaConvenio.ToString("D"), "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();            
        }

        private void btnBuscarEESSReferencia_Click(object sender, EventArgs e)
        {            
            FrmBuscarEESS objFrmBE = new FrmBuscarEESS();
            objFrmBE.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                txtEESSReferencia.Text = VariablesGlobales.EstablecimientoIdSIS;
                lblEESSReferencia.Text = VariablesGlobales.EstablecimientoDescripcion;                
            }
            else
            {
                txtEESSReferencia.Clear();
                lblEESSReferencia.Text = "";
            }           
        }

        private void btnBuscarEESSAsegurado_Click(object sender, EventArgs e)
        {            
            FrmBuscarEESS objFrmBE = new FrmBuscarEESS();
            objFrmBE.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                txtEESSAsegurado.Text = VariablesGlobales.EstablecimientoIdSIS;
                lblEESSAsegurado.Text = VariablesGlobales.EstablecimientoDescripcion;
            }
            else
            {
                txtEESSAsegurado.Clear();
                lblEESSAsegurado.Text = "";
            }
        }

        private void btnBuscarResponsable_Click(object sender, EventArgs e)
        {
            FrmBuscarProfesional objFrmBP = new FrmBuscarProfesional();
            objFrmBP.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                txtDniResponsable.Text = VariablesGlobales.DniDoctorX;
                lblResponsable.Text = VariablesGlobales.NombreDoctorX;
                lblCMP.Text = VariablesGlobales.CmpX;
                lblEspecialidad.Text = VariablesGlobales.EspecialidadX;
            }
            else
            {
                txtDniResponsable.Clear();
                lblResponsable.Text = "";
                lblCMP.Text = "";
                lblEspecialidad.Text = "";
            }
        }

        private void btnBuscarDxIngreso_Click(object sender, EventArgs e)
        {
            if (ValidarAgregarAutorizacion() == true) return;
            IdAutorizacion = 0;
            CategoriaElegida = "";
            if (lblProcesoDx.Text == "Agregar Diagnostico")
            {
                //Recorrer dgvAutorizacion
                foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == int.Parse(txtNumDX.Text))
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();
                        break;
                    }
                }

                if (IdAutorizacion > 0)
                {
                    VariablesGlobales.TipoDxX = "I";
                    VariablesGlobales.CategoriaIdX = CategoriaElegida;
                    FrmBuscarEnfermedad objFrmBEnf = new FrmBuscarEnfermedad();
                    objFrmBEnf.ShowDialog();
                    if (VariablesGlobales.NroX == 1)
                    {
                        txtDxIngreso.Text = VariablesGlobales.DxIngresoX;
                    }
                    else
                    {
                        txtDxIngreso.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe Seleccionar una Autorizacion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumDX.Focus();
                    txtNumDX.SelectAll();
                }
            }
            else
            {
                if (lblProcesoDx.Text == "Editar Diagnostico")
                {
                    //Recorrer dgvDiagnostico
                    foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                    {
                        if (int.Parse(reg.Cells["Nro"].Value.ToString()) == int.Parse(txtNumDX.Text))
                        {
                            CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();
                            break;
                        }
                    }

                    VariablesGlobales.TipoDxX = "I";
                    VariablesGlobales.CategoriaIdX = CategoriaElegida;
                    FrmBuscarEnfermedad objFrmBEnf = new FrmBuscarEnfermedad();
                    objFrmBEnf.ShowDialog();
                    if (VariablesGlobales.NroX == 1)
                    {
                        txtDxIngreso.Text = VariablesGlobales.DxIngresoX;
                    }
                    else
                    {
                        txtDxIngreso.Clear();
                    }
                } 
            }            
        }

        private void btnBuscarDxEgreso_Click(object sender, EventArgs e)
        {
            if (ValidarAgregarAutorizacion() == true) return;
            if (lblProcesoDx.Text == "Agregar Diagnostico")
            {
                //Recorrer dgvAutorizacion
                foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == int.Parse(txtNumDX.Text))
                    {
                        CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();
                        break;
                    }
                }

                VariablesGlobales.TipoDxX = "E";
                VariablesGlobales.CategoriaIdX = CategoriaElegida;
                FrmBuscarEnfermedad objFrmBEnf = new FrmBuscarEnfermedad();
                objFrmBEnf.ShowDialog();
                if (VariablesGlobales.NroX == 1)
                {
                    txtDxEgreso.Text = VariablesGlobales.DxEgresoX;
                }
                else
                {
                    txtDxEgreso.Clear();
                }
            }
            else
            {
                if (lblProcesoDx.Text == "Editar Diagnostico")
                {
                    //Recorrer dgvDiagnostico
                    foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                    {
                        if (int.Parse(reg.Cells["Nro"].Value.ToString()) == int.Parse(txtNumDX.Text))
                        {
                            CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();
                            break;
                        }
                    }

                    VariablesGlobales.TipoDxX = "E";
                    VariablesGlobales.CategoriaIdX = CategoriaElegida;
                    FrmBuscarEnfermedad objFrmBEnf = new FrmBuscarEnfermedad();
                    objFrmBEnf.ShowDialog();
                    if (VariablesGlobales.NroX == 1)
                    {
                        txtDxEgreso.Text = VariablesGlobales.DxEgresoX;
                    }
                    else
                    {
                        txtDxEgreso.Clear();
                    }
                }
            }                       
        }

        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            FrmBuscarMedicamento objFrmBMed = new FrmBuscarMedicamento();
            objFrmBMed.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                txtCodMedicamento.Text = VariablesGlobales.DigemidIdX.ToString();
                lblDesMedicamento.Text = VariablesGlobales.DesMedicamentoX.ToString();                
            }
            else
            {
                txtCodMedicamento.Clear();
                lblDesMedicamento.Text = "";
            }
        }

        private void btnBuscarProcedimiento_Click(object sender, EventArgs e)
        {            
            VariablesGlobales.FecAtencionX = DateTime.Parse(dtpFechaAtencion.Text);
            FrmBuscarProcedimiento objFrmBProc = new FrmBuscarProcedimiento();
            objFrmBProc.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                txtCodProcedimiento.Text = VariablesGlobales.SisIdX.ToString();
                lblDesProcedimiento.Text = VariablesGlobales.DesProcedimientoX.ToString();                
                ProcedimientoId_SisId = Convert.ToInt32(VariablesGlobales.ProcedimientoId.ToString());  
            }
            else
            {
                txtCodProcedimiento.Clear();
                lblDesProcedimiento.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarAtencion objFrmBAte = new FrmBuscarAtencion();
            if (objFrmBAte.ShowDialog() == DialogResult.OK)
            {

                btnEditar.Enabled = true;
                btnGrabar.Enabled = false;
                

                if (VariablesGlobales.NroX == 1)
                {
                    EstadoControles(true);
                    EstadoBotones(false);
                    LimpiarControlesDiagnostico();
                    LimpiarControlesMedicamento();
                    LimpiarControlesProcedimiento();
                    LimpiarControles();
                    tbcDetalleFua.Enabled = true;
                    lblNroFua.Text = VariablesGlobales.NroFuaX.ToString();
                    Fua = int.Parse(lblNroFua.Text);
                    objMovimientoPacienteDetalle.Fua = Fua;
                    objMovimientoMedicamento.Fua = Fua;
                    objMovimientoProcedimiento.Fua = Fua;
                    MovimientoPaciente_ListarxFua(Fua);
                    if (VariablesGlobales.EstablecimientoId == 0)
                    {
                        try { ObtenerPacienteViaWS(int.Parse(lblEstablecimientoId.Text)); }
                        catch { }
                        LeerAutorizacion(txtNumDoc.Text, int.Parse(lblEstablecimientoId.Text), DateTime.Parse(dtpFechaAtencion.Text));
                    }
                    else
                    {
                        try { ObtenerPacienteViaWS(VariablesGlobales.EstablecimientoId); }
                        catch { }
                        LeerAutorizacion(txtNumDoc.Text, VariablesGlobales.EstablecimientoId, DateTime.Parse(dtpFechaAtencion.Text));
                    }
                    dgvDiagnostico.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                    
                    dgvDiagnosticoB.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                    NoOrderColumns(2);
                    dgvDiagnosticoC.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                    NoOrderColumns(3);
                    dgvMedicamento.DataSource = objMovimientoMedicamentoBL.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
                    dgvProcedimiento.DataSource = objMovimientoProcedimientoBL.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
                    dgvMedicamento.Columns["Paquete"].Visible = false;
                    dgvProcedimiento.Columns["Paquete"].Visible = false;
                    txtCodProcedimiento.Enabled = false;
                    proceso = true;
                    procesoFec = true;
                }
                else
                {
                    //EstadoControles(false);
                    EstadoBotones(true);
                    tbcDetalleFua.Enabled = false;
                    LimpiarControlesDiagnostico();
                    LimpiarControlesMedicamento();
                    LimpiarControlesProcedimiento();
                    LimpiarControles();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFechaAtencion_ValueChanged(sender, e);
            //EstadoControles(true);
            //EstadoBotones(true);
            //tbcDetalleFua.Enabled = false;  

            EstadoControles(false);
            EstadoBotones(false);

            dtpFechaAtencion.Enabled = true;
            cboTipoDoc.Enabled = true;
            txtNumDoc.Enabled = true;
            txtNumFua.Enabled = true;
            txtNumLote.Enabled = true;

            LimpiarControlesDiagnostico();
            LimpiarControlesMedicamento();
            LimpiarControlesProcedimiento();
            cboTipoPrestacion_SelectedIndexChanged(sender, e);
            LimpiarControles();
            txtNumLote.Text = dtpFechaAtencion.Text.ToString().Substring(8, 2);
            cboTipoDoc.SelectedValue = 1;
            txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();

            txtNumDoc.Focus();
            txtNumDoc.SelectAll();

            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;
            proceso = false;

            tbcDetalleFua.SelectTab(0);
            this.tbcDetalleFua.Enabled = false;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (proceso == true)
            {
                if (VariablesGlobales.Id_Perfil == 3)
                {
                    if (VerificarCierreId() == true) return;
                    if (ValidarDatosMovimientoPaciente() == true) return;

                    if (ValidaLote() != true)
                    {
                        txtNumLote.Focus();
                        txtNumLote.SelectAll();
                        MessageBox.Show("¡Ingrese un Periodo correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else { 
                            if (txtNumDoc.TextLength > 0 || txtNumDoc.Text != String.Empty)
                            {
                                if (Convert.ToInt32(txtNumFua.Text.ToString()) != 0)
                                {
                                    if (ValidarCorrelativo2(int.Parse(lblNroFua.Text)) != false)
                                    {
                    
                                Fua = int.Parse(lblNroFua.Text);
                                objMovimientoPaciente.Fua = Fua;
                                objMovimientoPaciente.anno = this.txtNumLote.Text.Trim();
                                objMovimientoPaciente.correlativo = this.txtNumFua.Text.Trim();

                                if (VariablesGlobales.EstablecimientoId == 0)
                                {
                                    objMovimientoPaciente.EstablecimientoId = int.Parse(lblEstablecimientoId.Text);
                                }
                                else
                                {
                                    objMovimientoPaciente.EstablecimientoId = VariablesGlobales.EstablecimientoId;
                                }


                                objMovimientoPaciente.TipoIngresoId = byte.Parse(this.cboTipoIngreso.SelectedValue.ToString());
                                objMovimientoPaciente.FechaAtencion = DateTime.Parse(ValidarIsNull(dtpFechaAtencion.Text));
                                objMovimientoPaciente.LugarAtencionId = byte.Parse(this.cboLugarAtencion.SelectedValue.ToString());
                                objMovimientoPaciente.NumeroHistoria = this.txtHC.Text.Trim();
                                objMovimientoPaciente.TipoPrestacionId = int.Parse(this.cboTipoPrestacion.SelectedValue.ToString());
                                objMovimientoPaciente.PersonalAtiendeId = byte.Parse(this.cboPersonalAtencion.SelectedValue.ToString());
                                objMovimientoPaciente.NumeroHojaRefiere = this.txtHojaReferencia.Text.Trim();
                                objMovimientoPaciente.EstablecimientoRefiereId = this.txtEESSReferencia.Text.Trim();

                                if (this.cboDestinoAsegurado.SelectedIndex == 0)
                                    objMovimientoPaciente.DestinoAseguradoId = null;
                                else
                                    objMovimientoPaciente.DestinoAseguradoId = byte.Parse(this.cboDestinoAsegurado.SelectedValue.ToString());

                                objMovimientoPaciente.EstablecimientoContraRefiereId = this.txtEESSAsegurado.Text.Trim();
                                objMovimientoPaciente.NumeroHojaContraRefiere = this.txtHojaRefCont.Text.Trim();

                                if (this.txtFechaIngreso.Text.Length == 0)
                                    objMovimientoPaciente.FechaIngreso = null;
                                else
                                    objMovimientoPaciente.FechaIngreso = DateTime.Parse(ValidarIsNull(txtFechaIngreso.Text));

                                if (this.txtFechaAlta.Text.Length == 0)
                                    objMovimientoPaciente.FechaAlta = null;
                                else
                                    objMovimientoPaciente.FechaAlta = DateTime.Parse(ValidarIsNull(txtFechaAlta.Text));

                                objMovimientoPaciente.DNIResponsable = this.txtDniResponsable.Text.Trim();
                                objMovimientoPaciente.Colegiatura = this.lblCMP.Text.Trim();
                                objMovimientoPaciente.NombresResponsable = this.lblResponsable.Text;
                                objMovimientoPaciente.Especialidad = this.lblEspecialidad.Text.Trim();

                                if (this.cboInstitucion.SelectedIndex == 0)
                                    objMovimientoPaciente.InstitucionId = null;
                                else
                                    objMovimientoPaciente.InstitucionId = byte.Parse(this.cboInstitucion.SelectedValue.ToString());

                                objMovimientoPaciente.NumeroSeguro = this.txtCodSeguro.Text.Trim();
                                objMovimientoPaciente.ResponsableAtencionId = byte.Parse(this.cboResponsable.SelectedValue.ToString());
                                objMovimientoPaciente.PacienteId = this.txtNumDoc.Text.Trim();

                                if (this.cboRegimen.SelectedIndex == 0)
                                    objMovimientoPaciente.TipoRegimenId = null;
                                else
                                    objMovimientoPaciente.TipoRegimenId = byte.Parse(this.cboRegimen.SelectedValue.ToString());

                                objMovimientoPaciente.Afiliacion = this.txtNumAfiliacion.Text.Trim();

                                //if (this.cboTipoDoc.SelectedIndex == 0)
                                //    objMovimientoPaciente.TipoDocumentoId = null;
                                //else
                                //    objMovimientoPaciente.TipoDocumentoId = byte.Parse(this.cboTipoDoc.SelectedValue.ToString());

                                objMovimientoPacienteBL.MovimientoPaciente_Actualizar(objMovimientoPaciente);
                                //LimpiarControles();
                                EstadoControles(false);
                                LimpiarControlesDiagnostico();
                                LimpiarControlesMedicamento();
                                LimpiarControlesProcedimiento();
                                tbcDetalleFua.Enabled = true;
                                txtEESSAsegurado.Enabled = false;
                                txtHojaRefCont.Enabled = false;
                                lblMensaje.Text = "Se Edito Fua N° " + Fua;
                                MessageBox.Show("Fua Editado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                proceso = false;

                                }else
                                    {
                                        DataTable dt = new DataTable();
                                        dt = objMovimientoPacienteBL.MovimientoPaciente_ListarxFua(objMovimientoPaciente);
                                        string correlativo = txtNumFua.Text;
                                        txtNumFua.Text = dt.Rows[0][2].ToString().Trim();
                                        txtNumFua.Focus();
                                        txtNumFua.SelectAll();
                                        MessageBox.Show("¡Nro de Fua: " + correlativo + " ya Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                                else { MessageBox.Show("Ingresar un correlativo válido", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumFua.Focus(); ; txtNumFua.SelectAll(); }

                            }
                            else { MessageBox.Show("Ingresar N° de Documento", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumDoc.Focus(); txtNumDoc.SelectAll(); }

                }
            }

                else
                {
                    MessageBox.Show("¡Permiso Denegado, Usuario no Digitador!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                 
            }
            else
            {
                MessageBox.Show("¡Buscar Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }             
        }

        private void SeleccionarDiagnostico(object sender, DataGridViewCellEventArgs e)
        {
            if (proceso == true)
            {
                lblProcesoDx.Text = "Editar Diagnostico";
                lblProcesoDx.BackColor = Color.Green;
                btnAgregarAutorizacion.Visible = false;
                btnEditarAutorizacion.Visible = true;
                btnEliminarAutorizacion.Visible = true;
                txtNumDX.Text = dgvDiagnostico.CurrentRow.Cells[0].Value.ToString();
                txtNumDX.Enabled = false;
                txtDxIngreso.Enabled = true;
                txtDxIngreso.Focus();
                txtDxIngreso.Text = dgvDiagnostico.CurrentRow.Cells[6].Value.ToString();
                txtDxEgreso.Text = dgvDiagnostico.CurrentRow.Cells[7].Value.ToString(); 
               


            }  
        }

        private void SeleccionarMedicamento(object sender, DataGridViewCellEventArgs e)
        {
            if (proceso == true)
            {
                txtNumDXMed.Enabled = false;
                txtCodMedicamento.Enabled = false;
                txtNumDXMed.Text = dgvMedicamento.CurrentRow.Cells[0].Value.ToString();
                
                int NumDxMed;
                NumDxMed = int.Parse(txtNumDXMed.Text);
                IdAutorizacion = 0;

                //Recorrer dgvDiagnostico
                foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == NumDxMed)
                    {
                        CategoriaDx = reg.Cells["CategoriaId"].Value.ToString();
                        EstadioId = int.Parse(reg.Cells["Estadio"].Value.ToString());
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        break;
                    }
                }

                if (IdAutorizacion > 0)
                {
                    FuncionesBases.CargarComboEsquemaCategoria(cboEsquema, CategoriaDx, EstadioId);                    
                }
                else
                {
                    cboEsquema.DataSource = null;
                }
                
                cboEsquema.Text = dgvMedicamento.CurrentRow.Cells[3].Value.ToString();
                txtCodMedicamento.Text = dgvMedicamento.CurrentRow.Cells[1].Value.ToString();
                lblDesMedicamento.Text = dgvMedicamento.CurrentRow.Cells[2].Value.ToString();
                txtCantPreMed.Text = dgvMedicamento.CurrentRow.Cells[4].Value.ToString();
                txtCantEntMed.Text = dgvMedicamento.CurrentRow.Cells[5].Value.ToString();

                btnEditarMedicamento.Visible = true;
                btnEliminarMedicamento.Visible = true;
                btnAgregarMedicamento.Visible = false;

                txtCodMedicamento.Enabled = true;
                txtCodMedicamento.Focus();
                txtCodMedicamento.SelectAll();

            }  
        }

        private void SeleccionarProcedimiento(object sender, DataGridViewCellEventArgs e)
        {
            if (proceso == true)
            {
                txtNumDXProc.Enabled = false;
                txtCodProcedimiento.Enabled = false;
                txtNumDXProc.Text = dgvProcedimiento.CurrentRow.Cells[0].Value.ToString();
                txtCodProcedimiento.Text = dgvProcedimiento.CurrentRow.Cells[1].Value.ToString();
                lblDesProcedimiento.Text = dgvProcedimiento.CurrentRow.Cells[2].Value.ToString();
                txtCantPreProc.Text = dgvProcedimiento.CurrentRow.Cells[3].Value.ToString();
                txtCantEntProc.Text = dgvProcedimiento.CurrentRow.Cells[4].Value.ToString();
                if (int.Parse(dgvProcedimiento.CurrentRow.Cells[6].Value.ToString()) == 1)
                {
                    opcTercero.Checked = true;
                    txtTercero.Text = dgvProcedimiento.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    opcTercero.Checked = false;
                    txtTercero.Text = dgvProcedimiento.CurrentRow.Cells[7].Value.ToString();
                }

                btnEditarProcedimiento.Visible = true;
                btnEliminarProcedimiento.Visible = true;
                btnAgregarProcedimiento.Visible = false;

                txtNumDXProc.Enabled = false;
                txtCodProcedimiento.Enabled = true;
                txtCodProcedimiento.Focus();
                txtCodProcedimiento.SelectAll();
            }
        }       

        private void btnEditarAutorizacion_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;

            if (Fua > 0)
            {
                if (ValidarEditarDiagnostico() == true) return;

                int NumDx;
                NumDx = int.Parse(txtNumDX.Text);
                IdAutorizacion = 0;
                CategoriaElegida = "";

                //Recorrer dgvDiagnostico
                foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == NumDx)
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();
                        break;
                    }
                }

                if (IdAutorizacion > 0)
                {
                    if (ValidarAgregarDxIngreso() == true) return;
                    if (ValidarAgregarDxEgreso() == true) return;                   

                    DataTable dt = new DataTable();
                    objAutorizacion.AutorizacionId = IdAutorizacion;
                    dt = objAutorizacionBL.Autorizacion_ListarxAutorizacionId(objAutorizacion);
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            objMovimientoPacienteDetalle.Fua = Fua;
                            objMovimientoPacienteDetalle.DetalleId = NumDx;
                            objMovimientoPacienteDetalle.AutorizacionId = IdAutorizacion;
                            objMovimientoPacienteDetalle.EnfermedadIngresoId = txtDxIngreso.Text;
                            objMovimientoPacienteDetalle.TipoDiagnosticoIngresoId = "D";
                            objMovimientoPacienteDetalle.EstadioId = short.Parse(dt.Rows[0]["EstadioId"].ToString());
                            objMovimientoPacienteDetalle.FaseId = int.Parse(dt.Rows[0]["FaseId"].ToString());

                            if (this.txtDxEgreso.Text.Length == 0)
                                objMovimientoPacienteDetalle.EnfermedadEgresoId = String.Empty;
                            else
                                objMovimientoPacienteDetalle.EnfermedadEgresoId = txtDxEgreso.Text;

                            objMovimientoPacienteDetalle.TipoDiagnosticoEgresoId = "D";
                            objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_Actualizar(objMovimientoPacienteDetalle);
                            dgvDiagnostico.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                            dgvDiagnosticoB.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                            NoOrderColumns(2);
                            dgvDiagnosticoC.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                            NoOrderColumns(3);
                        }
                        else
                        {
                            MessageBox.Show("¡Paciente no tiene autorizaciones activas!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumDoc.Clear();
                            txtNumDoc.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    LimpiarControlesDiagnostico();
                }
                else
                {
                    MessageBox.Show("¡Debe Seleccionar un Diagnostico!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumDX.Focus();
                    txtNumDX.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("¡Debe Registrar Datos Basicos de Fua!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarMedicamento_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;
            if (ValidarDxMedicamento() == true) return;
            if (ValidarIdMedicamento() == true) return;
            if (ValidarCantPrescritaMed() == true) return;
            if (ValidarCantEntregadaMed() == true) return;
            if (ValidarDuplicidadMedicamentoEditar2() == true) return;
            DataTable dt = new DataTable();

            string FecAtencion = dtpFechaAtencion.Text;
            FecAtencion = FecAtencion.Substring(0, 2) + FecAtencion.Substring(3, 2) + FecAtencion.Substring(6, 4);

            if (VariablesGlobales.EstablecimientoId == 0)
            {                
                dt = objMedicamentoBL.Medicamento_CostoMedicamento(int.Parse(lblCodMedicamento.Text), int.Parse(lblEstablecimientoId.Text), IdAutorizacion, FecAtencion);
            }
            else
            {
                dt = objMedicamentoBL.Medicamento_CostoMedicamento(int.Parse(lblCodMedicamento.Text), VariablesGlobales.EstablecimientoId, IdAutorizacion, FecAtencion);
            }            

            try
            {
                if (dt.Rows.Count > 0)
                {
                    objMovimientoMedicamento.Fua = Fua;
                    objMovimientoMedicamento.DetalleId = int.Parse(txtNumDXMed.Text);
                    objMovimientoMedicamento.MedicamentoId = Convert.ToInt32(dgvMedicamento.CurrentRow.Cells[1].Value.ToString()); //int.Parse(lblCodMedicamento.Text);
                    objMovimientoMedicamento.EsquemaId = short.Parse(cboEsquema.SelectedValue.ToString());
                    objMovimientoMedicamento.Cantidad = int.Parse(txtCantEntMed.Text);
                    objMovimientoMedicamento.MedicamentoIdNuevo = int.Parse(lblCodMedicamento.Text);
                    //objMovimientoMedicamento.Monto = decimal.Parse(dt.Rows[0]["monto"].ToString());
                    objMovimientoMedicamento.Monto = 0;
                    objMovimientoMedicamento.Prescrito = int.Parse(txtCantPreMed.Text);
                    objMovimientoMedicamento.Consumo = 0;
                    objMovimientoMedicamento.Convenio = 0;
                    objMovimientoMedicamento.obs = "";
                    objMovimientoMedicamento.paquete = bool.Parse(dt.Rows[0]["paquete"].ToString());
                    objMovimientoMedicamentoBL.MovimientoMedicamento_Actualizar(objMovimientoMedicamento);
                    dgvMedicamento.DataSource = objMovimientoMedicamentoBL.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
                    dgvMedicamento.Columns["Paquete"].Visible = false;                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            dt.Clear();
            LimpiarControlesMedicamento();                                
        }

        private void btnEditarProcedimiento_Click(object sender, EventArgs e)
        {            
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;
            if (ValidarDxProcedimiento() == true) return;
            if (ValidarIdProcedimiento() == true) return;
            if (ValidarCantPrescritaProc() == true) return;
            if (ValidarCantEntregadaProc() == true) return;
            if (ValidarIPRESSProcedimiento() == true) return;


            if (dgvProcedimiento.RowCount > 0)
            {

                DateTime FecAtencion = DateTime.Parse(dtpFechaAtencion.Text);  

                if (ValidarDuplicidadProcedimiento2() == true) return;
                /******************************************************/

                //Antes
                DataTable dtAntes = new DataTable();
                dtAntes = objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, dgvProcedimiento.CurrentRow.Cells[1].Value.ToString(), FecAtencion);
                ProcAnterior = Convert.ToInt32(dtAntes.Rows[0][2].ToString());

                //Nuevo
                DataTable dtDespues = new DataTable();
                dtDespues = objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, txtCodProcedimiento.Text.Trim(), FecAtencion);
                ProcNuevo = Convert.ToInt32(dtDespues.Rows[0][2].ToString());
                /*****************************************************/
            }


            DataTable dt = new DataTable();
            string FechaAtencion = dtpFechaAtencion.Text;
            FechaAtencion = FechaAtencion.Substring(0, 2) + FechaAtencion.Substring(3, 2) + FechaAtencion.Substring(6, 4);

            if (VariablesGlobales.EstablecimientoId == 0)
            {
                dt = objProcedimientoBL.Procedimiento_CostoProcedimiento(ProcNuevo, int.Parse(lblEstablecimientoId.Text), IdAutorizacion, FechaAtencion);
            }
            else
            {
                dt = objProcedimientoBL.Procedimiento_CostoProcedimiento(ProcNuevo, VariablesGlobales.EstablecimientoId, IdAutorizacion, FechaAtencion);
            }             

            try
            {
                //if (dt.Rows.Count > 0)
                //{
                    objMovimientoProcedimiento.Fua = Fua;
                    objMovimientoProcedimiento.DetalleId = int.Parse(txtNumDXProc.Text);
                    objMovimientoProcedimiento.ProcedimientoId = ProcAnterior;//int.Parse(lblCodProcedimiento.Text);
                    objMovimientoProcedimiento.Cantidad = int.Parse(txtCantEntProc.Text);
                    objMovimientoProcedimiento.ProcedimientoIdNuevo = ProcNuevo;
                    //objMovimientoProcedimiento.Monto = decimal.Parse(dt.Rows[0]["monto"].ToString());
                    objMovimientoProcedimiento.Monto = 0;
                    objMovimientoProcedimiento.Prescrito = int.Parse(txtCantPreProc.Text);
                    objMovimientoProcedimiento.Consumo = 0;
                    objMovimientoProcedimiento.Convenio = 0;
                    objMovimientoProcedimiento.obs = "";
                    objMovimientoProcedimiento.paquete = bool.Parse(dt.Rows[0]["paquete"].ToString());
                    if (opcTercero.Checked == true)
                    {
                        objMovimientoProcedimiento.ProveedorTercero = true;
                    }
                    else
                    {
                        objMovimientoProcedimiento.ProveedorTercero = false;
                    }
                    objMovimientoProcedimiento.ProveedorCodigo = txtTercero.Text;
                    objMovimientoProcedimientoBL.MovimientoProcedimiento_Actualizar(objMovimientoProcedimiento);
                    dgvProcedimiento.DataSource = objMovimientoProcedimientoBL.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
                    dgvProcedimiento.Columns["Paquete"].Visible = false;                    
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

            dt.Clear();
            LimpiarControlesProcedimiento();
        }

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;
            if (ValidarDxMedicamento() == true) return;
            if (ValidarIdMedicamento() == true) return;

            if (MessageBox.Show("¿Desea Eliminar Medicamento Nro " + txtCodMedicamento.Text + "?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                try
                {
                    objMovimientoMedicamento.Fua = Fua;
                    objMovimientoMedicamento.DetalleId = int.Parse(txtNumDXMed.Text);
                    objMovimientoMedicamento.MedicamentoId = int.Parse(lblCodMedicamento.Text);
                    objMovimientoMedicamentoBL.MovimientoMedicamento_Eliminar(objMovimientoMedicamento);
                    dgvMedicamento.DataSource = objMovimientoMedicamentoBL.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
                    dgvMedicamento.Columns["Paquete"].Visible = false;                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
                LimpiarControlesMedicamento();

                btnAgregarMedicamento.Visible = true;
                btnEditarMedicamento.Visible = false;
                btnEliminarMedicamento.Visible = false;
                txtCodMedicamento.Enabled = false;
                txtNumDXMed.Focus();
                txtNumDXMed.SelectAll();


            }            
        }

        private void btnEliminarProcedimiento_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;
            if (ValidarDxProcedimiento() == true) return;
            if (ValidarIdProcedimiento() == true) return;

            //Antes
            DateTime FecAtencion = DateTime.Parse(dtpFechaAtencion.Text);  
            DataTable dtAntes = new DataTable();
            dtAntes = objProcedimientoBL.Procedimiento_VerificarSisId(VariablesGlobales.EstablecimientoId, dgvProcedimiento.CurrentRow.Cells[1].Value.ToString(), FecAtencion);
            ProcAnterior = Convert.ToInt32(dtAntes.Rows[0][2].ToString());


            if (MessageBox.Show("¿Desea Eliminar Procedimiento Nro " + txtCodProcedimiento.Text + "?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objMovimientoProcedimiento.Fua = Fua;
                    objMovimientoProcedimiento.DetalleId = int.Parse(txtNumDXProc.Text);
                    objMovimientoProcedimiento.ProcedimientoId = ProcAnterior;
                    objMovimientoProcedimientoBL.MovimientoProcedimiento_Eliminar(objMovimientoProcedimiento);
                    dgvProcedimiento.DataSource = objMovimientoProcedimientoBL.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
                    dgvProcedimiento.Columns["Paquete"].Visible = false;                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
                LimpiarControlesProcedimiento();
                btnAgregarProcedimiento.Visible = true;
                btnEditarProcedimiento.Visible = false;
                btnEliminarProcedimiento.Visible = false;
                txtCodProcedimiento.Enabled = false;
                txtNumDXProc.Focus();
                txtNumDXProc.SelectAll();

            }            
        }

        private void dgvAutorizacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {                
                // Indica de cual columna deseo dar formato de celda
                if (dgvAutorizacion.Columns[e.ColumnIndex].Name.Equals("Nro"))
                {
                    e.CellStyle.BackColor = Color.RoyalBlue;
                    e.CellStyle.ForeColor = Color.White;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDiagnostico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Indica de cual columna deseo dar formato de celda
                if (dgvDiagnostico.Columns[e.ColumnIndex].Name.Equals("Nro"))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDiagnosticoB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Indica de cual columna deseo dar formato de celda
                if (dgvDiagnosticoB.Columns[e.ColumnIndex].Name.Equals("Nro"))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDiagnosticoC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Indica de cual columna deseo dar formato de celda
                if (dgvDiagnosticoC.Columns[e.ColumnIndex].Name.Equals("Nro"))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LimpiarControlesDiagnostico();
        }

        private void btnEliminarAutorizacion_Click(object sender, EventArgs e)
        {
            if (VerificarCierreId() == true) return;
            if (ValidarDatosConsumo() == true) return;

            if (MessageBox.Show("¿Desea Eliminar Diagnostico Nro " + txtNumDX.Text + "?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                int NumDx;
                NumDx = int.Parse(txtNumDX.Text);
                IdAutorizacion = 0;
                CategoriaElegida = "";

                //Recorrer dgvDiagnostico
                foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == NumDx)
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();
                        break;
                    }
                }

                if (ValidarAgregarDxIngreso() == true) return;
                if (ValidarAgregarDxEgreso() == true) return;

                try
                {
                    objMovimientoPacienteDetalle.Fua = Fua;
                    objMovimientoMedicamento.Fua = Fua;
                    objMovimientoProcedimiento.Fua = Fua;
                    objMovimientoPacienteDetalle.DetalleId = NumDx;
                    objMovimientoPacienteDetalle.AutorizacionId = IdAutorizacion;
                    objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_Eliminar(objMovimientoPacienteDetalle);
                    dgvDiagnostico.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                    dgvDiagnosticoB.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                    NoOrderColumns(2);
                    dgvDiagnosticoC.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                    NoOrderColumns(3);
                    dgvMedicamento.DataSource = objMovimientoMedicamentoBL.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
                    dgvProcedimiento.DataSource = objMovimientoProcedimientoBL.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
                    dgvMedicamento.Columns["Paquete"].Visible = false;
                    dgvProcedimiento.Columns["Paquete"].Visible = false;                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                LimpiarControlesDiagnostico();
            }            
        }        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;

            if (proceso == true)
            {
                if (VariablesGlobales.Id_Perfil == 3)
                {
                    if (VerificarCierreId() == true) return;
                    procesoFec = true;
                    if (ValidarDatosMovimientoPaciente() == true) return;
                    if (MessageBox.Show("¿Desea Eliminar Fua Nro " + lblNroFua.Text + "?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Fua = int.Parse(lblNroFua.Text);
                        objMovimientoPaciente.Fua = Fua;
                        objMovimientoPacienteBL.MovimientoPaciente_Eliminar(objMovimientoPaciente);
                        EstadoControles(true);
                        EstadoBotones(true);
                        tbcDetalleFua.Enabled = false;
                        LimpiarControlesDiagnostico();
                        LimpiarControlesMedicamento();
                        LimpiarControlesProcedimiento();
                        cboTipoPrestacion_SelectedIndexChanged(sender, e);
                        LimpiarControles();            

                        MessageBox.Show("Fua Eliminado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
                else
                {
                    MessageBox.Show("¡Permiso Denegado, Usuario no Digitador!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                                 
            }
            else
            {
                MessageBox.Show("¡Buscar Atencion!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void cboInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboInstitucion.SelectedIndex == 0)
            {
                txtCodSeguro.Enabled = false;
                txtCodSeguro.Clear();                
            }
            else
            {
                txtCodSeguro.Enabled = true;
                txtCodSeguro.Focus();
            }
        }

        private void cboRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRegimen.SelectedIndex == 0)
            {
                txtNumAfiliacion.Enabled = false;
                txtNumAfiliacion.Clear();                
            }
            else
            {
                if (cboRegimen.SelectedIndex == 1)
                {
                    txtNumAfiliacion.Enabled = true;
                    txtNumAfiliacion.Text = "2-" + txtNumDoc.Text;
                }
                else
                {
                    txtNumAfiliacion.Enabled = true;
                    txtNumAfiliacion.Focus();
                }                
            }
        }

        private void opcTercero_CheckedChanged(object sender, EventArgs e)
        {
            if (opcTercero.Checked == true)
            {
                txtTercero.Enabled = true;
                txtTercero.Clear();
                txtTercero.Focus();
            }
            else
            {
                if (opcTercero.Checked == false)
                {
                    txtTercero.Clear();
                    txtTercero.Enabled = false;                    
                }
            }
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDoc.SelectedIndex == 0)
            {
                txtNumDoc.Enabled = false;
                label100.Visible = false;
                label101.Visible = false;
                label102.Visible = false;
                txtNumDoc.Clear();                
            }
            else
            {
                if (cboTipoDoc.SelectedIndex == 2)
                {
                    label100.Visible = true;
                    label101.Visible = true;
                    label102.Visible = true;
                }
                else
                {
                    label100.Visible = false; 
                    label101.Visible = false;
                    label102.Visible = false;
                }

                txtNumDoc.Enabled = true;
                //txtNumDoc.Clear(); 
                txtNumDoc.Focus();
            }
        }

        private void cboDestinoAsegurado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDestinoAsegurado.SelectedIndex == 0)
            {
                txtEESSAsegurado.Enabled = false;
                txtHojaRefCont.Enabled = false;
                btnBuscarEESSAsegurado.Enabled = false;
                lblEESSAsegurado.Text = "";
                txtEESSAsegurado.Clear();
                txtHojaRefCont.Clear();                
            }
            else
            {
                txtEESSAsegurado.Enabled = true;
                txtHojaRefCont.Enabled = true;
                btnBuscarEESSAsegurado.Enabled = true;
                txtEESSAsegurado.Focus();
            }
        }

        private void cboTipoPrestacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPrestacion.SelectedIndex == 0)
            {
                txtFechaIngreso.Clear();
                txtFechaAlta.Clear();
                dtpFechaIngreso.Enabled = false;
                dtpFechaAlta.Enabled = false;
                txtFechaIngreso.Enabled = false;
                txtFechaAlta.Enabled = false;
            }
            else
            {
                if (int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 6 || int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 7 || int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 8 || int.Parse(cboTipoPrestacion.SelectedValue.ToString()) == 9)
                {
                    dtpFechaIngreso.Enabled = true;
                    dtpFechaAlta.Enabled = true;
                    txtFechaIngreso.Enabled = true;
                    txtFechaAlta.Enabled = true;


                    DateTime FechaServidor = DateTime.Today.Date;
                    txtFechaIngreso.Text = FechaServidor.ToString();
                    txtFechaAlta.Text = FechaServidor.ToString();
                }
                else
                {
                    txtFechaIngreso.Clear();
                    txtFechaAlta.Clear();
                    dtpFechaIngreso.Enabled = false;
                    dtpFechaAlta.Enabled = false;
                    txtFechaIngreso.Enabled = false;
                    txtFechaAlta.Enabled = false;
                }            
            }            
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (btnPosicion.Text == "X")
                {                    
                    tbcDetalleFua.Location = new Point(12, 124);                    
                    btnPosicion.Text = "Y";
                }
                else
                {
                    if (btnPosicion.Text == "Y")
                    {                        
                        tbcDetalleFua.Location = new Point(12, 402);                        
                        btnPosicion.Text = "X";
                    }
                }                
            }            
            else
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    if (btnPosicion.Text == "X")
                    {
                        tbcDetalleFua.Height = 600;
                        tbcDetalleFua.Location = new Point(12, 124);                        
                        btnPosicion.Text = "Y";
                    }
                    else
                    {
                        if (btnPosicion.Text == "Y")
                        {
                            tbcDetalleFua.Height = 322;
                            tbcDetalleFua.Location = new Point(12, 402);                            
                            btnPosicion.Text = "X";
                        }
                    }                    
                }
            }               
        }

        private void FrmFua2_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {                
                tbcDetalleFua.Location = new Point(12, 402);
                btnPosicion.Text = "X";
                btnPosicion.Visible = false;
            }

            else
            {
                if (this.WindowState == FormWindowState.Normal)
                {                    
                    tbcDetalleFua.Location = new Point(12, 402);
                    btnPosicion.Text = "X";
                    btnPosicion.Visible = true;
                }
            }      
        }

        private void cboTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoIngreso.SelectedIndex == 0)
            {
                txtEESSReferencia.Clear();
                lblEESSReferencia.Text = "";
                txtHojaReferencia.Clear();
                grpReferencia.Enabled = true;
            }
            else
            {
                if (cboTipoIngreso.SelectedIndex == 1)
                {
                    txtEESSReferencia.Clear();
                    lblEESSReferencia.Text = "";
                    txtHojaReferencia.Clear();
                    grpReferencia.Enabled = true;
                }
                else
                {
                    if (cboTipoIngreso.SelectedIndex == 2)
                    {
                        txtEESSReferencia.Clear();
                        lblEESSReferencia.Text = "";
                        txtHojaReferencia.Clear();
                        grpReferencia.Enabled = true;
                    }
                    else
                    {
                        if (cboTipoIngreso.SelectedIndex == 3)
                        {
                            txtEESSReferencia.Clear();
                            lblEESSReferencia.Text = "";
                            txtHojaReferencia.Clear();
                            grpReferencia.Enabled = false;
                        }
                    }
                }
            }
        }

        private void ObtenerPacienteViaWS(int establecimientoId) 
        {
            string consulta = ConfigurationManager.AppSettings["WSPaciente"];
            if (consulta.Equals("1"))
            {
                Fissal.WSExternos.PacienteServiceClient wsPaciente = new Fissal.WSExternos.PacienteServiceClient();
                Fissal.WSExternos.CredencialServicio credencial = new Fissal.WSExternos.CredencialServicio();
                credencial.UserName = "fissal";
                credencial.Password = "fissal2015";
                Fissal.WSExternos.PacienteRespuesta objPacienteRpta = wsPaciente.ConsultarPaciente(credencial, int.Parse(cboTipoDoc.SelectedValue.ToString()), txtNumDoc.Text, establecimientoId);
                if (objPacienteRpta != null)
                {
                    if (objPacienteRpta.Paciente != null)
                    {
                        Fissal.WSExternos.Paciente objPaciente = objPacienteRpta.Paciente;
                        PacienteBL oblPaciente = new PacienteBL();
                        Paciente obePaciente = new Paciente();
                        Autorizacion obeAutorizacion = null;

                        obePaciente.PacienteId = objPaciente.PacienteId;
                        obePaciente.ApellidoMaterno = objPaciente.ApellidoMaterno;
                        obePaciente.ApellidoPaterno = objPaciente.ApellidoPaterno;
                        obePaciente.Nombres = objPaciente.Nombres;
                        obePaciente.OtrosNombres = objPaciente.OtrosNombres;
                        obePaciente.Historia = objPaciente.Historia;
                        obePaciente.SexoId = objPaciente.SexoId;
                        obePaciente.TipoRegimenId = objPaciente.TipoRegimenId;
                        obePaciente.TipoDocumentoId = objPaciente.TipoDocumentoId;
                        obePaciente.NumeroDocumento = objPaciente.NumeroDocumento;
                        obePaciente.Nacimiento = objPaciente.Nacimiento;
                        obePaciente.Estado = objPaciente.Estado;
                        obePaciente.fecha_defuncion = objPaciente.fecha_defuncion;
                        obePaciente.EstablecimientoIdOrigen = objPaciente.EstablecimientoIdOrigen;
                        obePaciente.UsuarioCreacion = objPaciente.UsuarioCreacion;
                        obePaciente.FechaCreacion = objPaciente.FechaCreacion;
                        obePaciente.Validado = objPaciente.Validado;
                        obePaciente.nro_contrato = objPaciente.nro_contrato;
                        obePaciente.Ubigeo_Residencia = objPaciente.Ubigeo_Residencia;
                        obePaciente.Ubigeo_Adscripcion = objPaciente.Ubigeo_Adscripcion;

                        foreach (var objAutorizacion in objPaciente.Autorizaciones)
                        {
                            obeAutorizacion = new Autorizacion();
                            obeAutorizacion.AutorizacionId = objAutorizacion.AutorizacionId;
                            obeAutorizacion.Fecha = objAutorizacion.Fecha;
                            obeAutorizacion.Estado = objAutorizacion.Estado;
                            obeAutorizacion.CodigoAutorizacion = objAutorizacion.CodigoAutorizacion;
                            obeAutorizacion.TipoAutorizacionId = objAutorizacion.TipoAutorizacionId;
                            obeAutorizacion.Monto = objAutorizacion.Monto;
                            obeAutorizacion.Descripcion = objAutorizacion.Descripcion;
                            obeAutorizacion.FechaInicio = objAutorizacion.FechaInicio;
                            obeAutorizacion.Vigencia = objAutorizacion.Vigencia;
                            obeAutorizacion.EstablecimientoId = objAutorizacion.EstablecimientoId;
                            obeAutorizacion.PacienteId = objAutorizacion.PacienteId;
                            obeAutorizacion.TratamiendoId = objAutorizacion.TratamiendoId;
                            obeAutorizacion.Version = objAutorizacion.Version;
                            obeAutorizacion.observacion = objAutorizacion.Observacion;
                            obeAutorizacion.Adicional = objAutorizacion.Adicional;
                            obeAutorizacion.Modalidad = objAutorizacion.Modalidad;
                            obeAutorizacion.ControlaCantidad = objAutorizacion.ControlaCantidad;
                            obeAutorizacion.DiagnosticoAsociado = objAutorizacion.DiagnosticoAsociado;
                            obeAutorizacion.UsuarioCreacion = objAutorizacion.UsuarioCreacion;
                            obeAutorizacion.FechaCreacion = objAutorizacion.FechaCreacion;
                            obeAutorizacion.FechaInformeMedico = objAutorizacion.FechaInformeMedico;
                            obeAutorizacion.FechaSolicitud = objAutorizacion.FechaSolicitud;
                            obeAutorizacion.FechaRespuesta = objAutorizacion.FechaRespuesta;
                            obeAutorizacion.Tipo = objAutorizacion.Tipo;
                            obeAutorizacion.Anulado = objAutorizacion.Anulado;
                            obeAutorizacion.Nro_Solicitud = objAutorizacion.Nro_Solicitud;
                            //obeAutorizacion.Enviado = objAutorizacion.Enviado;
                            //obeAutorizacion.PreAutorizado = objAutorizacion.PreAutorizado;

                            obePaciente.Autorizacion.Add(obeAutorizacion);
                        }

                        List<int> lista = oblPaciente.RegistrarPacienteDesdeWS(obePaciente);
                        if (lista.Count > 0) { string rpta = wsPaciente.ActualizarAutorizaciones(credencial, lista); }

                    }
                }
            }
                
        }

        private void ObtenerEsquemaPorCategoria() 
        {
            //if (ValidarDxMedicamento() == true) return;
            int NumDxMed;
            NumDxMed = int.Parse(txtNumDXMed.Text);
            IdAutorizacion = 0;

            //Recorrer dgvDiagnostico
            foreach (DataGridViewRow reg in dgvDiagnostico.Rows)
            {
                if (int.Parse(reg.Cells["Nro"].Value.ToString()) == NumDxMed)
                {
                    CategoriaDx = reg.Cells["CategoriaId"].Value.ToString();
                    EstadioId = int.Parse(reg.Cells["Estadio"].Value.ToString());
                    FaseId = int.Parse(reg.Cells["Fase"].Value.ToString());
                    IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                    break;
                }
            }

            if (IdAutorizacion > 0)
            {
                if (!string.Equals(CategoriaDx, "N18") && FaseId == 3)
                {
                    FuncionesBases.CargarComboEsquemaCategoria(cboEsquema, CategoriaDx, EstadioId);
                    cboEsquema.Focus();
                    cboEsquema.SelectAll();
                    cboEsquema.Enabled = true;
                }
                else
                {
                    FuncionesBases.CargarComboEsquemaCategoria2(cboEsquema);
                    txtCodMedicamento.Focus();
                    cboEsquema.Enabled = false;
                }
            }
            else
            {
                cboEsquema.DataSource = null;
            }            
        }

        private void txtNumDXMed_TextChanged(object sender, EventArgs e)
        {
            //if (ValidarDxMedicamento() != true)
            //{
            //    ObtenerEsquemaPorCategoria();
            //    cboEsquema.Enabled = true;
            //    cboEsquema.Focus();
            //    cboEsquema.SelectAll();
            //    txtCodMedicamento.Enabled = true;
            //}
        }

        private void txtNumDX_TextChanged(object sender, EventArgs e)
        {
            if (txtNumDX.Text != "")
            {
                //if (dgvDiagnostico.RowCount > 0)
                //{
                //    if (ValidarDuplicidadAutorizacion() == true) return;
                //}

                //if (dgvDiagnostico.RowCount > 0)
                //{
                //    if (ValidarDuplicidadDxAsociado() == true) return;
                //}

                int valor = int.Parse(txtNumDX.Text);
                IdAutorizacion = 0;

                foreach (DataGridViewRow reg in dgvAutorizacion.Rows)
                {
                    if (int.Parse(reg.Cells["Nro"].Value.ToString()) == valor)
                    {
                        IdAutorizacion = int.Parse(reg.Cells["AutorizacionId"].Value.ToString());
                        CategoriaElegida = reg.Cells["CategoriaId"].Value.ToString();

                        if ((CategoriaElegida == "ZZZ"))
                        {
                            if (ValidarEnfermedadPrincipal() != true)
                            { 
                                txtNumDX.Focus(); txtNumDX.SelectAll(); 
                                txtDxIngreso.Text = String.Empty;
                                txtDxEgreso.Text = String.Empty;
                                txtDxIngreso.Enabled = false;
                                txtDxEgreso.Enabled = false;
                                MessageBox.Show("¡Ingrese un Diagnostico Principal Previamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }
                }

                if (IdAutorizacion == 0)
                {
                    txtNumDX.Focus();
                    txtNumDX.SelectAll(); 
                    txtDxIngreso.Text = String.Empty;
                    txtDxEgreso.Text = String.Empty;
                    txtDxIngreso.Enabled = false;
                    txtDxEgreso.Enabled = false;
                    MessageBox.Show("¡Debe ingresar una Autorizacion Valida!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { txtNumDX.Focus(); txtNumDX.SelectAll(); }

        }

        private void txtNumDXProc_TextChanged(object sender, EventArgs e)
        {

        }

        void EdicionFuaPostConsistencia()
        {
            if (VariablesGlobales.NroX == 1)
            {
                EstadoControles(true);
                EstadoBotones(false);
                LimpiarControlesDiagnostico();
                LimpiarControlesMedicamento();
                LimpiarControlesProcedimiento();
                LimpiarControles();
                tbcDetalleFua.Enabled = true;
                lblNroFua.Text = VariablesGlobales.NroFuaX.ToString();
                Fua = int.Parse(lblNroFua.Text);
                objMovimientoPacienteDetalle.Fua = Fua;
                objMovimientoMedicamento.Fua = Fua;
                objMovimientoProcedimiento.Fua = Fua;
                MovimientoPaciente_ListarxFua(Fua);
                if (VariablesGlobales.EstablecimientoId == 0)
                {
                    try { ObtenerPacienteViaWS(int.Parse(lblEstablecimientoId.Text)); }
                    catch { }
                    LeerAutorizacion(txtNumDoc.Text, int.Parse(lblEstablecimientoId.Text), DateTime.Parse(dtpFechaAtencion.Text));
                }
                else
                {
                    try { ObtenerPacienteViaWS(VariablesGlobales.EstablecimientoId); }
                    catch { }
                    LeerAutorizacion(txtNumDoc.Text, VariablesGlobales.EstablecimientoId, DateTime.Parse(dtpFechaAtencion.Text));
                }
                dgvDiagnostico.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                dgvDiagnosticoB.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                NoOrderColumns(2);
                dgvDiagnosticoC.DataSource = objMovimientoPacienteDetalleBL.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
                NoOrderColumns(3);
                dgvMedicamento.DataSource = objMovimientoMedicamentoBL.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
                dgvProcedimiento.DataSource = objMovimientoProcedimientoBL.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
                dgvMedicamento.Columns["Paquete"].Visible = false;
                dgvProcedimiento.Columns["Paquete"].Visible = false;
                proceso = true;
                procesoFec = true;
                VariablesGlobales.NroFrmX = 0;
            }
            else
            {
                //EstadoControles(false);
                EstadoBotones(true);
                tbcDetalleFua.Enabled = false;
                LimpiarControlesDiagnostico();
                LimpiarControlesMedicamento();
                LimpiarControlesProcedimiento();
                LimpiarControles();
            }            
        }

        private void FrmFua2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;            
        }

        private void txtNumFua_Leave(object sender, EventArgs e)
        {
            txtNumFua.Text = txtNumFua.Text.PadLeft(8, '0').Trim();
        }

        private void txtEESSReferencia_Leave(object sender, EventArgs e)
        {
            if (txtEESSReferencia.Text == String.Empty)
            {
                lblEESSReferencia.Text = String.Empty;
            }
            else 
            {
                if (ValidarEstablecimientoRefiere() == true) 
                {
                    MessageBox.Show("¡El Establecimiento: " + txtEESSReferencia.Text.Trim() + " No Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEESSReferencia.Text = String.Empty;
                    lblEESSReferencia.Text = String.Empty;
                    txtEESSReferencia.Focus();
                    txtEESSReferencia.SelectAll();
                }
            }
        }

        private void txtEESSAsegurado_Leave(object sender, EventArgs e)
        {
            if (txtEESSAsegurado.Text == String.Empty)
            {

                lblEESSAsegurado.Text = String.Empty;
            }
            else
            {
                if (ValidarEstablecimientoRefiere() == true)
                {
                    MessageBox.Show("¡El Establecimiento: " + txtEESSAsegurado.Text.Trim() + " No Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEESSAsegurado.Text = String.Empty;
                    lblEESSAsegurado.Text = String.Empty;
                    txtEESSAsegurado.Focus();
                    txtEESSAsegurado.SelectAll();
                }
            }
        }

        private void txtDniResponsable_Leave(object sender, EventArgs e)
        {

            if (txtDniResponsable.Text != String.Empty)
            {
                if (ValidarMedico() == true) return;
                cboResponsable.Enabled = true;
                cboResponsable.Focus();
                cboResponsable.SelectAll();
            }
            else { cboResponsable.Enabled = false; }
        }

        private void dgvAutorizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumDX.Text = dgvAutorizacion[0, dgvAutorizacion.CurrentCell.RowIndex].Value.ToString();
        }

        private void dgvDiagnosticoB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumDXMed.Text = dgvDiagnosticoB[0, dgvDiagnosticoB.CurrentCell.RowIndex].Value.ToString();
        }

        private void dgvDiagnosticoC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumDXProc.Text = dgvDiagnosticoC[0, dgvDiagnosticoC.CurrentCell.RowIndex].Value.ToString();
        }

        void NoOrderColumns(int val) 
        {
            if (val == 1) 
            {
                dgvAutorizacion.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAutorizacion.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAutorizacion.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAutorizacion.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAutorizacion.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAutorizacion.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAutorizacion.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            }else if (val == 2)
            {
                dgvDiagnosticoB.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvDiagnosticoB.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoB.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            else if (val == 3) 
            {
                dgvDiagnosticoC.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvDiagnosticoC.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDiagnosticoC.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            } 

            
        
        }

        private void dgvAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtNumDX.Text = dgvAutorizacion[0, dgvAutorizacion.CurrentCell.RowIndex].Value.ToString();
                txtNumDX.Focus();
                txtNumDX.SelectAll();
            }
        }

        private void dgvDiagnosticoB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtNumDXMed.Text = dgvDiagnosticoB[0, dgvDiagnosticoB.CurrentCell.RowIndex].Value.ToString();
                txtNumDXMed.Focus();
                txtNumDXMed.SelectAll();
            }
        }

        private void dgvDiagnosticoC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtNumDXProc.Text = dgvDiagnosticoC[0, dgvDiagnosticoC.CurrentCell.RowIndex].Value.ToString();
                txtNumDXProc.Focus();
                txtNumDXProc.SelectAll();
            }
        }

        private void txtNumDoc_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtNumLote_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if (ValidaLote()!=true)
                {
                    MessageBox.Show("¡Ingrese un Año correcto!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    txtNumFua.Focus();
                    txtNumFua.SelectAll();  
                }
            }
        }


        public bool ValidaLote() 
        { 
            bool valor;
            valor=false;

            if (Equals(txtNumLote.Text.ToString().Trim(),"") || txtNumLote.TextLength < 2)
            {
                valor = false;
            }
            else if (Convert.ToInt32(txtNumLote.Text.ToString()) < 12)
            {
                valor = false;
            }
            else
            {
                valor = true;
            }

            return valor;
        }

        private void txtNumLote_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtNumFua_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtNumDX_Click(object sender, EventArgs e)
        {
            txtDxIngreso.Text = String.Empty;
            txtDxEgreso.Text = String.Empty;
            txtDxIngreso.Enabled = false;
            txtDxEgreso.Enabled = false;
        }

        private void txtCantPreMed_TextChanged(object sender, EventArgs e)
        {
            txtCantEntMed.Text = txtCantPreMed.Text;
        }

        private void txtCantEntMed_Leave(object sender, EventArgs e)
        {

        }

        private void txtNumDXMed_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumDXMed.Enabled = true;
            txtNumDXMed.Clear();
            txtNumDXMed.Focus();
            txtNumDXMed.SelectAll();
            cboEsquema.Enabled = false;
            cboEsquema.SelectedValue = -1;
            txtCodMedicamento.Enabled = false;
            txtCodMedicamento.Clear();
            lblDesMedicamento.Text = String.Empty;
            txtCantPreMed.Clear();
            txtCantEntMed.Clear();
            txtCantPreMed.Enabled = false;
            txtCantEntMed.Enabled = false;

            btnEditarMedicamento.Visible = false;
            btnEliminarMedicamento.Visible = false;
            btnAgregarMedicamento.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumDXProc.Enabled = true;
            txtNumDXProc.Clear();
            txtNumDXProc.Focus();
            txtNumDXProc.SelectAll();
            txtCodProcedimiento.Enabled = false;
            txtCodProcedimiento.Clear();
            lblDesProcedimiento.Text = String.Empty;
            txtCantPreProc.Clear();
            txtCantEntProc.Clear();
            txtCantPreProc.Enabled = false;
            txtCantEntProc.Enabled = false;

            btnEditarProcedimiento.Visible = false;
            btnEliminarProcedimiento.Visible = false;
            btnAgregarProcedimiento.Visible = true;
        }

        private void txtCantPreProc_TextChanged(object sender, EventArgs e)
        {
            txtCantEntProc.Text = txtCantPreProc.Text;
        }

        private void dtpFechaAtencion_Leave(object sender, EventArgs e)
        {
            MovimientoPacienteBL ObjetoMovimientoPacienteBL = new MovimientoPacienteBL();
            DataTable dtFechaTarifario = new DataTable();

            if (VariablesGlobales.EstablecimientoId == 0)
            {
                dtFechaTarifario = ObjetoMovimientoPacienteBL.MovimientoPaciente_FechaConvenio(int.Parse(lblEstablecimientoId.Text));
            }
            else
            {
                dtFechaTarifario = ObjetoMovimientoPacienteBL.MovimientoPaciente_FechaConvenio(VariablesGlobales.EstablecimientoId);
            }

            DateTime FechaConvenio = Convert.ToDateTime(dtFechaTarifario.Rows[0][3].ToString());
            DateTime FechaAtencion = DateTime.Parse(dtpFechaAtencion.Text);
            DateTime FechaRegistro = DateTime.Today;
            DateTime FechaServidor = DateTime.Today;

            if (FechaAtencion >= FechaConvenio)
            {
                if (FechaAtencion <= FechaServidor)
                {
                    txtNumLote.Text = dtpFechaAtencion.Text.ToString().Substring(8, 2); cboTipoDoc.Focus();
                }
                else
                {
                    dtpFechaAtencion.Value = FechaServidor;
                    MessageBox.Show("¡Fecha de Atencion debe ser Menor o igual a la Fecha Actual!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                dtpFechaAtencion.Value = FechaServidor;
                MessageBox.Show("¡Fecha de Atencion debe ser Mayor o igual a la Fecha Convenio! - Fecha Convenio: " + FechaConvenio.ToString("D"), "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
