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
using System.Collections;

namespace FissalWinForm
{
    public partial class FrmBuscadorAtenciones : Form, IFrmSelectorCategorias, IFrmSelectorProcedimientos, IFrmSelectorMedicamentos, IFrmSelectorEstablecimientos, IFrmSelectorControlesMedicos
    {
        #region 'VARIABLES Y CONSTANTES'

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        StringBuilder filtroBusquedaAtenciones = new StringBuilder();
        StringBuilder filtroDetallesAtenciones = new StringBuilder();
        StringBuilder filtroMovimientoPacienteDetalle = new StringBuilder();
        StringBuilder filtroMovimientoPacienteProcedimiento = new StringBuilder();
        StringBuilder filtroMovimientoPacienteProcedimientoFP = new StringBuilder();
        StringBuilder filtroMovimientoPacienteMedicamento = new StringBuilder();
        StringBuilder filtroMovimientoPacienteMedicamentoFP = new StringBuilder();
        StringBuilder filtroMovimientoPacienteMontoTotal = new StringBuilder();
        DataTable dtMovimientoPaciente;
        string codigoControlMedico;
        string produccionId;
        string correlativoAtencion;
        string tipoDocumentoPaciente;
        string establecimiento;
        string annoAtencion;
        string numeroDocumentoPaciente;
        string dniResponsableAtencion;
        string fechaAtencionDesde;
        string fechaAtencionHasta;
        string fechaDigitacionDesde;
        string fechaDigitacionHasta;
        string cmSi;
        string cmNo;
        string cmObsSi;
        string cmObsNo;
        string cmPcppSi;
        string cmPcppNo;
        string cmReconsideradoSi;
        string cmReconsideradoNo;
        string procedimiento_fp_si;
        string procedimiento_fp_no;
        string medicamento_fp_si;
        string medicamento_fp_no;
        string monto_total_fua_desde;
        string monto_total_fua_hasta;
        string diagnosticos;
        string procedimientos;
        string medicamentos;
        string datosIngresados;
        string datosIngresadosDetalles;
        public struct CantidadSupervision
        {
            public string clave {get; set;}
            public string valor { get; set; }
        }
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

        #endregion

        #region 'CONSTRUCTORES'

        public FrmBuscadorAtenciones()
        {
            InitializeComponent();
            CargarConfiguracionInicial();
        }

        #endregion

        #region 'CARGA DE DATOS'

        public void CargarCboCantidadSupervision()
        {
            List<CantidadSupervision> lista = new List<CantidadSupervision>(3);
            CantidadSupervision objCantidadSupervision1 = new CantidadSupervision();
            objCantidadSupervision1.clave = "20";
            objCantidadSupervision1.valor = "20";
            CantidadSupervision objCantidadSupervision2 = new CantidadSupervision();
            objCantidadSupervision2.clave = "50";
            objCantidadSupervision2.valor = "50";
            CantidadSupervision objCantidadSupervision3 = new CantidadSupervision();
            objCantidadSupervision3.clave = "100";
            objCantidadSupervision3.valor = "100";
            lista.Add(objCantidadSupervision1);
            lista.Add(objCantidadSupervision2);
            lista.Add(objCantidadSupervision3);
            cboCantidadSupervision.DataSource = lista;
            cboCantidadSupervision.ValueMember = "clave";
            cboCantidadSupervision.DisplayMember = "valor";
        }

        private void CargarCboProduccion()
        {
            string codigoControlMedico = txtCodigoControlMedico.Text.Trim();
            DataTable dtProduccion = objProduccionEstablecimientoBL.GetCodigoProduccionControlPorControlMedico(codigoControlMedico);
            /*INSERTAR NUEVA FILA*/
            DataRow row = dtProduccion.NewRow();
            row["ProduccionId"] = DBNull.Value;
            row["Codigo"] = "-Seleccione-";
            dtProduccion.Rows.InsertAt(row, 0);
            cboProduccion.DataSource = dtProduccion;
            cboProduccion.ValueMember = "ProduccionId";
            cboProduccion.DisplayMember = "Codigo";
        }

        #endregion

        #region 'CONFIGURACION'

        private void CargarConfiguracionInicial()
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.AutoValidate = AutoValidate.Disable;
            toolStrip1.TabStop = true;
            txtFechaAtencionDesde.ReadOnly = true;
            txtFechaAtencionHasta.ReadOnly = true;
            txtFechaDigitacionDesde.ReadOnly = true;
            txtFechaDigitacionHasta.ReadOnly = true;
            dgvMovimientoPaciente.AutoGenerateColumns = false;
            tsPgsBarBuscador.Visible = false;
        }

        #endregion

        #region 'LOGICA DE PROCESO'

        private bool IngresaronDatosBuscador()
        {
            codigoControlMedico = txtCodigoControlMedico.Text.Trim();
            produccionId = cboProduccion.SelectedValue.ToString();
            correlativoAtencion = txtCorrelativo.Text.Trim();
            tipoDocumentoPaciente = cboTipoDocPaciente.SelectedValue.ToString();
            establecimiento = txtEstablecimiento.Text.Trim();
            annoAtencion = txtAnno.Text.Trim();
            numeroDocumentoPaciente = txtNumeroDocPaciente.Text.Trim();
            dniResponsableAtencion = txtDniResponsableAtencion.Text.Trim();
            fechaAtencionDesde = txtFechaAtencionDesde.Text.Trim();
            fechaAtencionHasta = txtFechaAtencionHasta.Text.Trim();
            fechaDigitacionDesde = txtFechaDigitacionDesde.Text.Trim();
            fechaDigitacionHasta = txtFechaDigitacionHasta.Text.Trim();
            if (!chkCmSi.Checked)
                cmSi = string.Empty;
            else
                cmSi = chkCmSi.Checked.ToString();
            if (!chkCmNo.Checked)
                cmNo = string.Empty;
            else
                cmNo = chkCmNo.Checked.ToString();
            if (!chkCmObsSi.Checked)
                cmObsSi = string.Empty;
            else
                cmObsSi = chkCmObsSi.Checked.ToString();
            if (!chkCmObsNo.Checked)
                cmObsNo = string.Empty;
            else
                cmObsNo = chkCmObsNo.Checked.ToString();
            if (!chkCmPcppSi.Checked)
                cmPcppSi = string.Empty;
            else
                cmPcppSi = chkCmPcppSi.Checked.ToString();
            if (!chkCmPcppNo.Checked)
                cmPcppNo = string.Empty;
            else
                cmPcppNo = chkCmPcppNo.Checked.ToString();
            if (!chkCmReconsideradosSi.Checked)
                cmReconsideradoSi = string.Empty;
            else
                cmReconsideradoSi = chkCmReconsideradosSi.Checked.ToString();
            if (!chkCmReconsideradosNo.Checked)
                cmReconsideradoNo = string.Empty;
            else
                cmReconsideradoNo = chkCmReconsideradosNo.Checked.ToString();
            if (!chkProcedimientoFpSi.Checked)
                procedimiento_fp_si = string.Empty;
            else
                procedimiento_fp_si = chkProcedimientoFpSi.Checked.ToString();
            if (!chkProcedimientoFpNo.Checked)
                procedimiento_fp_no = string.Empty;
            else
                procedimiento_fp_no = chkProcedimientoFpNo.Checked.ToString();
            if (!chkMedicamentoFpSi.Checked)
                medicamento_fp_si = string.Empty;
            else
                medicamento_fp_si = chkMedicamentoFpSi.Checked.ToString();
            if (!chkMedicamentoFpNo.Checked)
                medicamento_fp_no = string.Empty;
            else
                medicamento_fp_no = chkMedicamentoFpNo.Checked.ToString();
            monto_total_fua_desde = txtMontoTotalFuaDesde.Text.Trim();
            monto_total_fua_hasta = txtMontoTotalFuaHasta.Text.Trim();
            diagnosticos = txtDiagnosticos.Text.Trim();
            procedimientos = txtProcedimientos.Text.Trim();
            medicamentos = txtMedicamentos.Text.Trim();
            datosIngresados = string.Concat(codigoControlMedico, produccionId, correlativoAtencion, tipoDocumentoPaciente, establecimiento, annoAtencion, numeroDocumentoPaciente, dniResponsableAtencion, fechaAtencionDesde, fechaAtencionHasta, fechaDigitacionDesde, fechaDigitacionHasta, cmSi, cmNo, cmObsSi, cmObsNo, cmPcppSi, cmPcppNo, cmReconsideradoSi, cmReconsideradoNo);
            datosIngresadosDetalles = string.Concat(procedimiento_fp_si, procedimiento_fp_no, medicamento_fp_si, medicamento_fp_no, monto_total_fua_desde, monto_total_fua_hasta, diagnosticos, procedimientos, medicamentos);
            bool respuesta = false;
            if (datosIngresados != string.Empty || datosIngresadosDetalles != string.Empty)
                respuesta = true;
            return respuesta;
        }

        private string FormarFiltroBusqueda()
        {
            filtroBusquedaAtenciones.Clear();
            filtroDetallesAtenciones.Clear();
            filtroMovimientoPacienteProcedimientoFP.Clear();
            filtroMovimientoPacienteMedicamentoFP.Clear();
            filtroMovimientoPacienteMontoTotal.Clear();
            filtroMovimientoPacienteDetalle.Clear();
            filtroMovimientoPacienteProcedimiento.Clear();
            filtroMovimientoPacienteMedicamento.Clear();
            if (datosIngresadosDetalles != string.Empty)
            {
                if (procedimiento_fp_si != string.Empty)
                {
                    filtroMovimientoPacienteProcedimientoFP.AppendFormat("select fua from MovimientoProcedimiento where paquete = {0} group by fua", 0);
                    filtroDetallesAtenciones.AppendFormat("{0}", filtroMovimientoPacienteProcedimientoFP.ToString());
                }
                if (medicamento_fp_si != string.Empty)
                {
                    filtroMovimientoPacienteMedicamentoFP.AppendFormat("select fua from MovimientoMedicamento where paquete = {0} group by fua", 0);
                    if (filtroDetallesAtenciones.ToString() != string.Empty)
                        filtroDetallesAtenciones.AppendFormat(" intersect {0}", filtroMovimientoPacienteMedicamentoFP.ToString());
                    else
                        filtroDetallesAtenciones.AppendFormat("{0}", filtroMovimientoPacienteMedicamentoFP.ToString());
                }
                if (diagnosticos != string.Empty)
                {
                    string source = diagnosticos;
                    string[] result = source.Split(',');
                    foreach (string categoriaId in result)
                    {
                        if (categoriaId.Trim() != string.Empty)
                        {
                            if (filtroMovimientoPacienteDetalle.ToString() == string.Empty)
                                filtroMovimientoPacienteDetalle.AppendFormat("select fua from vw_MovimientoPacienteDetalle where CategoriaId = '{0}'", categoriaId.Trim());
                            else
                                filtroMovimientoPacienteDetalle.AppendFormat(" or CategoriaId = '{0}'", categoriaId.Trim());
                        }
                    }
                    if (filtroMovimientoPacienteDetalle.ToString() != string.Empty)
                    {
                        filtroMovimientoPacienteDetalle.AppendFormat(" group by fua");
                        if (filtroDetallesAtenciones.ToString() != string.Empty)
                            filtroDetallesAtenciones.AppendFormat(" intersect {0}", filtroMovimientoPacienteDetalle.ToString());
                        else
                            filtroDetallesAtenciones.AppendFormat("{0}", filtroMovimientoPacienteDetalle.ToString());
                    }
                }
                if (procedimientos != string.Empty)
                {
                    string source = procedimientos;
                    string[] result = source.Split(',');
                    foreach (string procedimientoId in result)
                    {
                        if (procedimientoId.Trim() != string.Empty)
                        {
                            if (filtroMovimientoPacienteProcedimiento.ToString() == string.Empty)
                                filtroMovimientoPacienteProcedimiento.AppendFormat("select fua from MovimientoProcedimiento where ProcedimientoId = {0}", procedimientoId.Trim());
                            else
                                filtroMovimientoPacienteProcedimiento.AppendFormat(" or ProcedimientoId = {0}", procedimientoId.Trim());
                        }
                    }
                    if (filtroMovimientoPacienteProcedimiento.ToString() != string.Empty)
                    {
                        filtroMovimientoPacienteProcedimiento.AppendFormat(" group by fua");
                        if (filtroDetallesAtenciones.ToString() != string.Empty)
                            filtroDetallesAtenciones.AppendFormat(" intersect {0}", filtroMovimientoPacienteProcedimiento.ToString());
                        else
                            filtroDetallesAtenciones.AppendFormat("{0}", filtroMovimientoPacienteProcedimiento.ToString());
                    }
                }
                if (medicamentos != string.Empty)
                {
                    string source = medicamentos;
                    string[] result = source.Split(',');
                    foreach (string medicamentoId in result)
                    {
                        if (medicamentoId.Trim() != string.Empty)
                        {
                            if (filtroMovimientoPacienteMedicamento.ToString() == string.Empty)
                                filtroMovimientoPacienteMedicamento.AppendFormat("select fua from MovimientoMedicamento where MedicamentoId = {0}", medicamentoId.Trim());
                            else
                                filtroMovimientoPacienteMedicamento.AppendFormat(" or MedicamentoId = {0}", medicamentoId.Trim());
                        }
                    }
                    if (filtroMovimientoPacienteMedicamento.ToString() != string.Empty)
                    {
                        filtroMovimientoPacienteMedicamento.AppendFormat(" group by fua");
                        if (filtroDetallesAtenciones.ToString() != string.Empty)
                            filtroDetallesAtenciones.AppendFormat(" intersect {0}", filtroMovimientoPacienteMedicamento.ToString());
                        else
                            filtroDetallesAtenciones.AppendFormat("{0}", filtroMovimientoPacienteMedicamento.ToString());
                    }
                }
                if (!filtroDetallesAtenciones.ToString().Equals(string.Empty))
                    filtroBusquedaAtenciones.AppendFormat("fua in ({0})", filtroDetallesAtenciones.ToString());
                
            }
            if (codigoControlMedico != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and CodigoControlMedico = '{0}'", codigoControlMedico);
                else
                    filtroBusquedaAtenciones.AppendFormat("CodigoControlMedico = '{0}'", codigoControlMedico);
            }
            if (produccionId != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and ProduccionId = '{0}'", produccionId);
                else
                    filtroBusquedaAtenciones.AppendFormat("ProduccionId = '{0}'", produccionId);
            }
            if (correlativoAtencion != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and correlativo like '%{0}%'", correlativoAtencion);
                else
                    filtroBusquedaAtenciones.AppendFormat("correlativo like '%{0}%'", correlativoAtencion);
            }
            if (tipoDocumentoPaciente != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and TipoDocumentoId = '{0}'", tipoDocumentoPaciente);
                else
                    filtroBusquedaAtenciones.AppendFormat("TipoDocumentoId = '{0}'", tipoDocumentoPaciente); 
            }

            if (establecimiento != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and EstablecimientoId = '{0}'", establecimiento);
                else
                    filtroBusquedaAtenciones.AppendFormat("EstablecimientoId = '{0}'", establecimiento);
            }

            if (annoAtencion != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and anno = '{0}'", annoAtencion);
                else
                    filtroBusquedaAtenciones.AppendFormat("anno = '{0}'", annoAtencion);
            }

            if (numeroDocumentoPaciente != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and NumeroDocumento like '%{0}%'", numeroDocumentoPaciente);
                else
                    filtroBusquedaAtenciones.AppendFormat("NumeroDocumento like '%{0}%'", numeroDocumentoPaciente);
            }

            if (dniResponsableAtencion != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and DNIResponsable like '%{0}%'", dniResponsableAtencion);
                else
                    filtroBusquedaAtenciones.AppendFormat("DNIResponsable like '%{0}%'", dniResponsableAtencion);
            }
            if (cmSi != string.Empty || cmNo != string.Empty)
            {
                if (cmSi != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and CM = {0}", 1);
                    else
                        filtroBusquedaAtenciones.AppendFormat("CM = {0}", 1);
                }
                else
                {
                    if (cmNo != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and (CM = {0} or CM is null)", 0);
                        else
                            filtroBusquedaAtenciones.AppendFormat("(CM = {0} or CM is null)", 0);
                    }
                }
            }
            if (cmObsSi != string.Empty || cmObsNo != string.Empty)
            {
                if (cmObsSi != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and CMObs = {0}", 1);
                    else
                        filtroBusquedaAtenciones.AppendFormat("CMObs = {0}", 1);
                }
                else
                {
                    if (cmObsNo != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and CMObs = {0}", 0);
                        else
                            filtroBusquedaAtenciones.AppendFormat("CMObs = {0}", 0);
                    }
                }
            }
            if (cmPcppSi != string.Empty || cmPcppNo != string.Empty)
            {
                if (cmPcppSi != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and CMPcpp = {0}", 1);
                    else
                        filtroBusquedaAtenciones.AppendFormat("CMPcpp = {0}", 1);
                }
                else
                {
                    if (cmPcppNo != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and (CMPcpp = {0} or CMPcpp is null)", 0);
                        else
                            filtroBusquedaAtenciones.AppendFormat("(CMPcpp = {0} or CMPcpp is null)", 0);
                    }
                }
            }
            if (cmReconsideradoSi != string.Empty || cmReconsideradoNo != string.Empty)
            {
                if (cmReconsideradoSi != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and CMReconsiderado = {0}", 1);
                    else
                        filtroBusquedaAtenciones.AppendFormat("CMReconsiderado = {0}", 1);
                }
                else
                {
                    if (cmReconsideradoNo != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and (CMReconsiderado = {0} or CMReconsiderado is null)", 0);
                        else
                            filtroBusquedaAtenciones.AppendFormat("(CMReconsiderado = {0} or CMReconsiderado is null)", 0);
                    }
                }
            }
            if (monto_total_fua_desde != string.Empty || monto_total_fua_hasta != string.Empty)
            {
                if (monto_total_fua_desde != string.Empty && monto_total_fua_hasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and MontoFua >= {0} and MontoFua <= {1}", monto_total_fua_desde, monto_total_fua_hasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("MontoFua >= {0} and MontoFua <= {1}", monto_total_fua_desde, monto_total_fua_hasta);
                }
                else
                {
                    if (monto_total_fua_desde != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and MontoFua >= {0}", monto_total_fua_desde);
                        else
                            filtroBusquedaAtenciones.AppendFormat("MontoFua >= {0}", monto_total_fua_desde);
                    }
                    else
                    {
                        if (monto_total_fua_hasta != string.Empty)
                        {
                            if (filtroBusquedaAtenciones.ToString() != string.Empty)
                                filtroBusquedaAtenciones.AppendFormat(" and MontoFua <= {0}", monto_total_fua_hasta);
                            else
                                filtroBusquedaAtenciones.AppendFormat("MontoFua <= {0}", monto_total_fua_hasta);
                        }
                    }
                }
            }
            if (fechaAtencionDesde != string.Empty || fechaAtencionHasta != string.Empty)
            {
                if (fechaAtencionDesde != string.Empty && fechaAtencionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaAtencion) >= convert(date,'{0}',103) and convert(date, FechaAtencion) <= convert(date,'{1}',103)", fechaAtencionDesde, fechaAtencionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("convert(date, FechaAtencion) >= convert(date,'{0}',103) and convert(date, FechaAtencion) <= convert(date,'{1}',103)", fechaAtencionDesde, fechaAtencionHasta);
                }
                else
                {
                    if (fechaAtencionDesde != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaAtencion) >= convert(date,'{0}',103)", fechaAtencionDesde);
                        else
                            filtroBusquedaAtenciones.AppendFormat("convert(date, FechaAtencion) >= convert(date,'{0}',103)", fechaAtencionDesde);
                    }
                    else
                    {
                        if (fechaAtencionHasta != string.Empty)
                        {
                            if (filtroBusquedaAtenciones.ToString() != string.Empty)
                                filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaAtencion) <= convert(date,'{0}',103)", fechaAtencionHasta);
                            else
                                filtroBusquedaAtenciones.AppendFormat("convert(date, FechaAtencion) <= convert(date,'{0}',103)", fechaAtencionHasta);
                        }
                    }
                }
            }
            //else
            //{
            //    if (filtroBusquedaAtenciones.ToString() != string.Empty)
            //        filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaAtencion) <= convert(date,'{0}',103)", objMovimientoPacienteBL.GetFechaMaximaValorizacion().ToShortDateString());
            //    else
            //        filtroBusquedaAtenciones.AppendFormat("convert(date, FechaAtencion) <= convert(date,'{0}',103)", objMovimientoPacienteBL.GetFechaMaximaValorizacion().ToShortDateString());
            //}
            if (fechaDigitacionDesde != string.Empty || fechaDigitacionHasta != string.Empty)
            {
                if (fechaDigitacionDesde != string.Empty && fechaDigitacionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaRegistro) >= convert(date,'{0}',103) and convert(date, FechaRegistro) <= convert(date,'{1}',103)", fechaDigitacionDesde, fechaDigitacionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("convert(date, FechaRegistro) >= convert(date,'{0}',103) and convert(date, FechaRegistro) <= convert(date,'{1}',103)", fechaDigitacionDesde, fechaDigitacionHasta);
                }
                else
                {
                    if (fechaDigitacionDesde != string.Empty)
                    {
                        if (filtroBusquedaAtenciones.ToString() != string.Empty)
                            filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaRegistro) >= convert(date,'{0}',103)", fechaDigitacionDesde);
                        else
                            filtroBusquedaAtenciones.AppendFormat("convert(date, FechaRegistro) >= convert(date,'{0}',103)", fechaDigitacionDesde);
                    }
                    else
                    {
                        if (fechaDigitacionHasta != string.Empty)
                        {
                            if (filtroBusquedaAtenciones.ToString() != string.Empty)
                                filtroBusquedaAtenciones.AppendFormat(" and convert(date, FechaRegistro) <= convert(date,'{0}',103)", fechaDigitacionHasta);
                            else
                                filtroBusquedaAtenciones.AppendFormat("convert(date, FechaRegistro) <= convert(date,'{0}',103)", fechaDigitacionHasta);
                        }
                    }
                }
            }
            return filtroBusquedaAtenciones.ToString();
        }

        #endregion

        #region 'VALIDACIONES'

        private bool EsFechaAtencionHastaValida()
        {
            bool cancel = false;
            if (FuncionesBases.ValidarFechaFin(txtFechaAtencionHasta, errorProvider1))
                cancel = true;
            if (!string.Equals(txtFechaAtencionHasta.Text.Trim(), string.Empty))
            {
                DateTime fechaInicio = Convert.ToDateTime(txtFechaAtencionHasta.Text);
                DateTime fechaFin = objMovimientoPacienteBL.GetFechaMaximaValorizacion();
                if (FuncionesBases.ObtenerDiasEntreDosFechas(fechaFin, fechaInicio) < 0)
                {
                    errorProvider1.SetError(txtFechaAtencionHasta, string.Format("No puede ser mayor que el {0}", fechaFin.ToShortDateString()));
                    cancel = true;
                }
            }
            return cancel;
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void Buscar()
        {
            if (IngresaronDatosBuscador())
            {
                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                    string top = Convert.ToString(cboCantidadSupervision.SelectedValue);
                    string campos = string.Format("Fua, EstablecimientoId, anno, correlativo, Descripcion, FechaAtencion, FechaRegistro, DescripcionTipoDocumento, NumeroDocumento, NombrePaciente, DNIResponsable, NombreDoctor, Especialidad, MontoFua");
                    string tabla = "vw2_MovimientoPacienteControlMedico";
                    string filtro = FormarFiltroBusqueda();
                    string order = "FechaAtencion";
                    string consultaSql = string.Format("select Top {0} {1} from {2} where {3} order by {4}", top, campos, tabla, filtro, order);
                    if (filtro != string.Empty)
                    {
                        dtMovimientoPaciente = objMovimientoPacienteBL.ListarMovimientoPacienteBuscadorCM(consultaSql);
                        dgvMovimientoPaciente.DataSource = dtMovimientoPaciente;
                        if (!(dtMovimientoPaciente.Rows.Count > 0))
                            MessageBox.Show("No se han encontrado resultados para tu busqueda", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                            dgvMovimientoPaciente.Focus();
                    }
                    else
                        MessageBox.Show("Ingrese datos validos", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Hay datos no válidos en el formulario.", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese al menos un dato de busqueda", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Limpiar()
        {
            dtpFechaAtencionDesde.Value = DateTime.Now;
            dtpFechaAtencionHasta.Value = DateTime.Now;
            dtpFechaDigitacionDesde.Value = DateTime.Now;
            dtpFechaDigitacionHasta.Value = DateTime.Now;
            FuncionesBases.LimpiarControles(this);
            errorProvider1.Clear();
            if (dtMovimientoPaciente != null)
            {
                dtMovimientoPaciente.Clear();
                dgvMovimientoPaciente.DataSource = dtMovimientoPaciente;
            }
            txtEstablecimiento.Focus();
        }

        private void EnviarFuas()
        {
            int rowCount = dgvMovimientoPaciente.RowCount;
            Int64[] listaIdAtenciones = new Int64[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                listaIdAtenciones[i] = Convert.ToInt64(dgvMovimientoPaciente.Rows[i].Cells["Fua"].Value);
            }
            FrmFua frmFua = new FrmFua(listaIdAtenciones, dgvMovimientoPaciente.CurrentRow.Index);
            frmFua.ShowDialog();
        }

        #endregion

        #region 'EVENTOS frm'

        private void Frm_buscador_fuas_Load(object sender, EventArgs e)
        {
            CargarCboCantidadSupervision();
            FuncionesBases.CargarComboTipoDoc(cboTipoDocPaciente);
            CargarCboProduccion();
            lblNota.Text = string.Format("{0} {1}", lblNota.Text, objMovimientoPacienteBL.GetFechaMaximaValorizacion().ToShortDateString());
        }
        #endregion
        
        #region 'EVENTOS txt'

        private void txtFechaAtencionDesde_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaInicio(txtFechaAtencionDesde, txtFechaAtencionHasta, errorProvider1);
        }

        private void txtFechaAtencionDesde_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaAtencionDesde, string.Empty);
        }

        private void txtFechaAtencionHasta_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = EsFechaAtencionHastaValida();
        }

        private void txtFechaAtencionHasta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaAtencionHasta, string.Empty);
        }

        private void txtFechaDigitacionDesde_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaInicio(txtFechaDigitacionDesde, txtFechaDigitacionHasta, errorProvider1);
        }

        private void txtFechaDigitacionDesde_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaDigitacionDesde, string.Empty);
        }

        private void txtFechaDigitacionHasta_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaFin(txtFechaDigitacionHasta, errorProvider1);
        }

        private void txtFechaDigitacionHasta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaDigitacionHasta, string.Empty);
        }

        private void txtProcedimientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumerosConComa(e);
        }

        private void txtMedicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumerosConComa(e);
        }

        private void txtbx_numero_doc_paciente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_dni_responsable_atencion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_diagnosticos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_procedimientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_medicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_totalfua_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtbx_totalfua_desde_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_totalfua_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtbx_totalfua_hasta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_establecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtbx_establecimiento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_anno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtbx_anno_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_correlativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtbx_correlativo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtbx_numero_doc_paciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtbx_dni_responsable_atencion_keyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtFechaAtencionDesde_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaAtencionHasta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaDigitacionDesde_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaDigitacionHasta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtCodigoControlMedico_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.EsTextBoxVacio(txtCodigoControlMedico, errorProvider1);
        }

        private void txtCodigoControlMedico_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCodigoControlMedico, string.Empty);
        }

        #endregion

        #region 'EVENTOS dtp'

        private void dtpckr_fecha_atencion_desde_ValueChanged(object sender, EventArgs e)
        {
            txtFechaAtencionDesde.Text = dtpFechaAtencionDesde.Value.ToShortDateString();
        }

        private void dtpckr_fecha_atencion_hasta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaAtencionHasta.Text = dtpFechaAtencionHasta.Value.ToShortDateString();
        }

        private void dtpckr_fecha_digitacion_desde_ValueChanged(object sender, EventArgs e)
        {
            txtFechaDigitacionDesde.Text = dtpFechaDigitacionDesde.Value.ToShortDateString();
        }

        private void dtpckr_fecha_digitacion_hasta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaDigitacionHasta.Text = dtpFechaDigitacionHasta.Value.ToShortDateString();
        }

        #endregion

        #region 'EVENTOS chk'

        private void chkProcedimientoFpSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkProcedimientoFpSi.Checked)
                        chkProcedimientoFpSi.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkProcedimientoFpSi.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkMedicamentoFpSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkMedicamentoFpSi.Checked)
                        chkMedicamentoFpSi.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkMedicamentoFpSi.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkCmSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmSi.Checked)
                        chkCmSi.Checked = false;
                    else
                        chkCmSi.Checked = true;
                    break;
            }
        }

        private void chkCmNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmNo.Checked)
                        chkCmNo.Checked = false;
                    else
                        chkCmNo.Checked = true;
                    break;
            }
        }

        private void chkCmObsSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmObsSi.Checked)
                        chkCmObsSi.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkCmObsSi.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkCmObsNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmObsNo.Checked)
                        chkCmObsNo.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkCmObsNo.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkCmPcppSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmPcppSi.Checked)
                        chkCmPcppSi.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkCmPcppSi.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkCmPcppNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmPcppNo.Checked)
                        chkCmPcppNo.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkCmPcppNo.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkCmReconsideradosSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmReconsideradosSi.Checked)
                        chkCmReconsideradosSi.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkCmReconsideradosSi.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chkCmReconsideradosNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkCmReconsideradosNo.Checked)
                        chkCmReconsideradosNo.Checked = Convert.ToBoolean(bool.FalseString);
                    else
                        chkCmReconsideradosNo.Checked = Convert.ToBoolean(bool.TrueString);
                    break;
            }
        }

        private void chckbx_cm_si_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmSi.Checked)
                chkCmNo.Checked = false;
        }

        private void chckbx_cm_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmNo.Checked)
                chkCmSi.Checked = false;
        }

        private void chckbx_cm_obs_si_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmObsSi.Checked)
                chkCmObsNo.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_cm_obs_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmObsNo.Checked)
                chkCmObsSi.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_cm_pcpp_si_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmPcppSi.Checked)
                chkCmPcppNo.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_cm_pcpp_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmPcppNo.Checked)
                chkCmPcppSi.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_cm_reconsiderados_si_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmReconsideradosSi.Checked)
                chkCmReconsideradosNo.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_cm_reconsiderados_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCmReconsideradosNo.Checked)
                chkCmReconsideradosSi.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_procedimiento_fp_si_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcedimientoFpSi.Checked)
                chkProcedimientoFpNo.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_procedimiento_fp_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcedimientoFpNo.Checked)
                chkProcedimientoFpSi.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_medicamento_fp_si_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMedicamentoFpSi.Checked)
                chkMedicamentoFpNo.Checked = Convert.ToBoolean(bool.FalseString);
        }

        private void chckbx_medicamento_fp_no_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMedicamentoFpNo.Checked)
                chkMedicamentoFpSi.Checked = Convert.ToBoolean(bool.FalseString);
        }

        #endregion

        #region 'EVENTOS cbo'

        private void cmbbx_tipo_doc_paciente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS btn'

        private void btn_buscar_diagnosticos_Click(object sender, EventArgs e)
        {
            FrmSelectorCategorias oFrmSelectorCategorias = new FrmSelectorCategorias();
            oFrmSelectorCategorias.Owner = this;
            oFrmSelectorCategorias.ShowDialog();
        }

        private void btn_buscar_procedimientos_Click(object sender, EventArgs e)
        {
            FrmSelectorProcedimientos oFrmBuscadorProcedimientos = new FrmSelectorProcedimientos();
            oFrmBuscadorProcedimientos.Owner = this;
            oFrmBuscadorProcedimientos.ShowDialog();
        }

        private void btn_buscarmedicamentos_Click(object sender, EventArgs e)
        {
            FrmSelectorMedicamentos oFrmBuscadorMedicamentos = new FrmSelectorMedicamentos();
            oFrmBuscadorMedicamentos.Owner = this;
            oFrmBuscadorMedicamentos.ShowDialog();
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        
        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            FuncionesBases.ExportarExcel(dtMovimientoPaciente, tsPgsBarBuscador, tsslMensajePgsBarBuscador);
        }

        private void btnSeleccionarControlMedico_Click(object sender, EventArgs e)
        {
            FrmSelectorControlesMedicos frmSelectorControlesMedicos = new FrmSelectorControlesMedicos();
            frmSelectorControlesMedicos.Owner = this;
            frmSelectorControlesMedicos.ShowDialog();
        }

        private void btnBuscarEstablecimiento_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos frmSelectorEstablecimientos = new FrmSelectorEstablecimientos(Convert.ToBoolean(bool.TrueString), Convert.ToBoolean(bool.FalseString), Convert.ToBoolean(bool.FalseString));
            frmSelectorEstablecimientos.Owner = this;
            frmSelectorEstablecimientos.ShowDialog();
        }

        #endregion

        #region 'EVENTOS dgv'

        private void dgvMovimientoPaciente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvMovimientoPaciente, tsslTotalRegistros);
        }

        private void dgvMovimientoPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            EnviarFuas();
        }

        private void dgvMovimientoPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarFuas();
                    break;
                case Keys.Back:
                    txtEstablecimiento.Focus();
                    break;
            }
        }

        #endregion

        #region 'IMPLEMENTACION DE MIEMBROS DE INTERFACES'

        #region 'IFrmSelectorCategorias MEMBERS'

        public void ObtenerCategorias(string texto)
        {
            if (txtDiagnosticos.Text != string.Empty)
            {
                txtDiagnosticos.Text = string.Format("{0}, {1}", txtDiagnosticos.Text, texto);
            }
            else
            {
                txtDiagnosticos.Text = texto;
            }
            txtDiagnosticos.Focus();
        }

        #endregion

        #region 'IFrmSelectorProcedimientos MEMBERS'

        public void ObtenerProcedimientos(string texto)
        {
            if (txtProcedimientos.Text != string.Empty)
            {
                txtProcedimientos.Text = string.Format("{0}, {1}", txtProcedimientos.Text, texto);
            }
            else
            {
                txtProcedimientos.Text = texto;
            }
            txtProcedimientos.Focus();
        }

        #endregion

        #region 'IFrmSelectorMedicamentos MEMBERS'

        public void ObtenerMedicamentos(string texto)
        {
            if (txtMedicamentos.Text != string.Empty)
            {
                txtMedicamentos.Text = string.Format("{0}, {1}", txtMedicamentos.Text, texto);
            }
            else
            {
                txtMedicamentos.Text = texto;
            }
            txtMedicamentos.Focus();
        }

        #endregion

        #region 'IFrmSelectorEstablecimientos MEMBERS'

        public void ObtenerEstablecimientos(string texto)
        {
            txtEstablecimiento.Text = texto;
            txtEstablecimiento.Focus();
        }

        #endregion

        #region 'IFrmSelectorControlesMedicos MEMBERS'

        public void ObtenerControlesMedicos(string codigoControlMedico, string fechaInicioControlMedico, string fechaFinControlMedico)
        {
            txtCodigoControlMedico.Text = codigoControlMedico;
            txtFechaInicioControlMedico.Text = fechaInicioControlMedico;
            txtFechaFinControlMedico.Text = fechaFinControlMedico;
            txtEstablecimiento.Focus();
        }

        #endregion

        private void txtCodigoControlMedico_TextChanged(object sender, EventArgs e)
        {
            CargarCboProduccion();
        }

        #endregion

    }
}
