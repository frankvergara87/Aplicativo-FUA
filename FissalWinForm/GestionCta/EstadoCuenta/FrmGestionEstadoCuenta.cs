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
using FissalWinForm.ServiceReference1;

using System.Globalization;

namespace FissalWinForm
{
    public partial class FrmGestionEstadoCuenta : Form
    {
        public struct PacienteExp
        {
            public string NumeroDocumento { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string Nombres { get; set; }
            //public Nullable<System.DateTime> Nacimiento { get; set; }
            public string Nacimiento { get; set; }
            public byte SexoId { get; set; }
            public string PacienteId { get; set; }
            public string Historia { get; set; }
        }


        public FrmGestionEstadoCuenta()
        {
            InitializeComponent();
            tsslMensajePgsBarBuscador.Visible = false;
            tsPgsBarBuscador.Visible = false;
        }

        EstadoCuentaConciliacion objEstadoCuentaConciliacion = new EstadoCuentaConciliacion();
        EstadoCuentaConciliacionBL objEstadoCuentaConciliacionBL = new EstadoCuentaConciliacionBL();
        PacienteBL objPacienteBL = new PacienteBL();


        siswsSoapClient ws = new siswsSoapClient();

        DataTable dt;
        DataView dwEstadoCuentaConciliacion;

        private void tsBtnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void Anular()
        {
            try
            {
                objEstadoCuentaConciliacion.CodigoConciliacion = VariablesGlobales.CodigoConciliacionX;

                if (int.Parse(objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_VerificarPendiente(objEstadoCuentaConciliacion).Rows[0][0].ToString()) > 0)
                {
                    MessageBox.Show("¡Proceso Denegado, Estado de Cuentas Pendientes!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dgvEstadoCuenta.Rows)
                    {
                        DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                            rowSelected.Add(row);
                    }

                    if (rowSelected.Count > 0)
                    {
                        if (MessageBox.Show("¿Iniciar Proceso de Anulacion?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow row in rowSelected)
                            {
                                objEstadoCuentaConciliacion.EstadoCuentaConciliacionId = int.Parse(row.Cells["EstadoCuentaConciliacionId"].Value.ToString());
                                objEstadoCuentaConciliacion.EstablecimientoId = int.Parse(row.Cells["EstablecimientoId"].Value.ToString());
                                objEstadoCuentaConciliacion.PacienteId = row.Cells["PacienteId"].Value.ToString();
                                objEstadoCuentaConciliacion.CadenaId = int.Parse(row.Cells["CadenaId"].Value.ToString());
                                objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_Anular(objEstadoCuentaConciliacion);
                                objEstadoCuentaConciliacionBL.Autorizacion_Anular(objEstadoCuentaConciliacion);
                            }

                            CargarData();
                            MessageBox.Show("¡Proceso Fissal Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Seleccionar una Cuenta!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmGestionEstadoCuenta_Load(object sender, EventArgs e)
        {
            CargarData();
        }

        private void dgvEstadoCuenta_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEstadoCuenta.IsCurrentCellDirty)
                dgvEstadoCuenta.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void tsBtnConsultaFissal_Click(object sender, EventArgs e)
        {
            try
            {
                //////Nueba Logica
                dwEstadoCuentaConciliacion = dt.DefaultView;
                DataTable dtEstadoCuentaConciliacion = dwEstadoCuentaConciliacion.ToTable(true, "Conciliacion","EstablecimientoId");
                int codigoConciliacion;
                int establecimientoId;
                foreach (DataRow dataRow in dtEstadoCuentaConciliacion.Rows)
                {
                    codigoConciliacion = Convert.ToInt32(dataRow["Conciliacion"]);
                    establecimientoId = Convert.ToInt32(dataRow["EstablecimientoId"]);
                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(codigoConciliacion,establecimientoId);
                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(codigoConciliacion,establecimientoId);
                }
                ///////////////////
                
                //objEstadoCuentaConciliacion.CodigoConciliacion = VariablesGlobales.CodigoConciliacionX;
                //if (dt.Rows.Count > 0)
                //{
                //    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(objEstadoCuentaConciliacion);
                //    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(objEstadoCuentaConciliacion);
                //}

                CargarData();
                MessageBox.Show("¡Proceso Fissal Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void CargarData()
        {
            objEstadoCuentaConciliacion.CodigoConciliacion = VariablesGlobales.CodigoConciliacionX;
            dt = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_Listar(objEstadoCuentaConciliacion);
            dgvEstadoCuenta.DataSource = dt;
        }

        private void tsBtnConsultarSis_Click(object sender, EventArgs e)
        {
            CredencialWS Clave = new CredencialWS();
            siswsSoapClient ws = new siswsSoapClient();
            string Trama = string.Empty;
            string[] Campos;
            string FechaVigencia;
            string Componente;
            /***********************CREDENCIALES WS.*/
            Clave.Usuario = "fissal";
            Clave.Clave = "uhy2c32zlk";

            /***********************/

            /*************CONSULTAMOS DATA SIS - WS**/

            int codigoConciliacion = VariablesGlobales.CodigoConciliacionX;
            List<string> listaPacientes = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ListarPaciente(codigoConciliacion);
            int filasPacientes = listaPacientes.Count;
            string pacienteId;
            tsPgsBarBuscador.Minimum = 0;
            tsPgsBarBuscador.Maximum = filasPacientes;
            //tsslMensajePgsBarBuscador.Text = "Procesando consulta SIS...";
            tsslMensajePgsBarBuscador.Visible = true;
            tsPgsBarBuscador.Visible = true;
            for (int i = 0; i < filasPacientes; i++)
            {
                Trama = string.Empty;
                pacienteId = listaPacientes[i];
                Paciente ObjPaciente = objPacienteBL.GetPacientePorId(pacienteId);
                /****************************************************************/
                if (ObjPaciente.TipoDocumentoId == 1)
                {
                    Trama = ws.BuscarAseguradosDocIdent(Clave, "00006210", "1", ObjPaciente.NumeroDocumento);
                    if (!string.Equals(Trama, string.Empty))
                    {
                        Campos = Trama.Split('|');
                        FechaVigencia = Campos[16];
                        Componente = Campos[13];

                        /****** AGREGAR VALIDACION VIGENCIA *******************/

                        if (Componente == "1") // SUBSIDIADO = ACTIVO
                        {
                            objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoSIS(pacienteId, "1", codigoConciliacion);
                        }
                        else if (Componente == "2") // NRUSS
                        {
                            if (FechaVigencia != "")
                            {
                                string FVigencia = FechaVigencia.ToString();
                                string Eval = FVigencia.Substring(6, 2) + '/' + FVigencia.Substring(4, 2) + '/' + FVigencia.Substring(0, 4);

                                DateTime FEval = Convert.ToDateTime(Eval);
                                DateTime FHoy = DatosBL.GetDate();

                                if (FEval.Date >= FHoy.Date)
                                {
                                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoSIS(pacienteId, "1", codigoConciliacion);
                                }
                                else
                                {
                                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoSIS(pacienteId, "0", codigoConciliacion);
                                }

                            }
                            else
                                objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoSIS(pacienteId, "1", codigoConciliacion);
                        }
                        /******************************************************/
                    }
                    else
                        objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateActivoSIS(pacienteId, "0", codigoConciliacion);
                }

                /****************************************************************/

                tsPgsBarBuscador.Value = i;
                tsslMensajePgsBarBuscador.Text = "N° Registros consultados = " + tsPgsBarBuscador.Value.ToString();
            }
            tsslMensajePgsBarBuscador.Visible = false;
            tsslMensajePgsBarBuscador.Text = string.Empty;
            tsPgsBarBuscador.Visible = false;
            tsPgsBarBuscador.Value = tsPgsBarBuscador.Minimum;
            CargarData();
            MessageBox.Show("¡Proceso SIS Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        private void dgvEstadoCuenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvEstadoCuenta, tsslTotalRegistros);
        }

        private void tsBtnExportarPacientes_Click(object sender, EventArgs e)
        {
            List<PacienteExp> ListadoPaciente = new List<PacienteExp>();
            ListadoPaciente = Listado();
            DataTable dtListado = new DataTable();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dtListado = converter.ToDataTable(ListadoPaciente);
            FuncionesBases.ExpCsv(dtListado);
        }

        private List<PacienteExp> Listado()
        {
            List<PacienteExp> ListExp = new List<PacienteExp>();
            Paciente ObjPacBusc = new Paciente();
            string dniPaciente;
            int codigoConciliacion = VariablesGlobales.CodigoConciliacionX;
            List<string> ListaP = new List<string>();


            ListaP = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ListarPaciente(codigoConciliacion);


            for (int i = 0; i < ListaP.Count; i++)
            {
                dniPaciente = ListaP[i];

                ObjPacBusc = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ListarPacientexDni(dniPaciente);

                PacienteExp ObjPacExp = new PacienteExp();
                ObjPacExp.NumeroDocumento = ObjPacBusc.NumeroDocumento;
                ObjPacExp.ApellidoPaterno = ObjPacBusc.ApellidoPaterno;
                ObjPacExp.ApellidoMaterno = ObjPacBusc.ApellidoMaterno;
                ObjPacExp.Nombres = ObjPacBusc.Nombres;
                ObjPacExp.Nacimiento = ObjPacBusc.OtrosNombres; //FEcha
                ObjPacExp.SexoId = ObjPacBusc.SexoId;
                ObjPacExp.PacienteId = ObjPacBusc.PacienteId;
                ObjPacExp.Historia = ObjPacBusc.Historia;

                ListExp.Add(ObjPacExp);
            }
            return ListExp;
        }

        private void tsBtnImportarPacientes_Click(object sender, EventArgs e)
        {
            Importar3();
        }

        private void tsBtnObtenerEstados_Click(object sender, EventArgs e)
        {
            try
            {
                objEstadoCuentaConciliacion.CodigoConciliacion = VariablesGlobales.CodigoConciliacionX;

                if (int.Parse(objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_VerificarPendiente(objEstadoCuentaConciliacion).Rows[0][0].ToString()) > 0)
                {
                    MessageBox.Show("¡Proceso Denegado, Estado de Cuentas Pendientes!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Generar Estado de Cuentas?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateEstado(objEstadoCuentaConciliacion);
                        CargarData();
                        MessageBox.Show("¡Proceso Fissal Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void Importar() 
        //{
        //    DataTable dtListas = new DataTable();

        //    string fileName = String.Empty;
        //    //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
        //    //solo los archivos excel
        //    dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana
        //    dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

        //    //si al seleccionar el archivo damos Ok
        //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        fileName = dialog.FileName;

        //        /********************************************OBTENEMOS EXCEL - DATATABLE*/
        //        dtListas = FuncionesBases.ImportExcel(fileName);

        //        int filas = dtListas.Rows.Count;
        //        tsPgsBarBuscador.Minimum = 0;
        //        tsPgsBarBuscador.Maximum = filas;
        //        tsslMensajePgsBarBuscador.Visible = true;
        //        tsPgsBarBuscador.Visible = true;
        //        /*****************************************************/

        //        foreach (DataRow row in dtListas.Rows)
        //        {
        //            string Documento = row[2].ToString();
        //            string Estado = row[8].ToString();

        //            if (Estado == "FALLECIMIENTO")
        //            {
        //                objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateReniec(Documento, "0");
        //            }
        //            else if (Estado != "FALLECIMIENTO")
        //            {
        //                objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateReniec(Documento, "1");
        //            }

        //            tsPgsBarBuscador.Value++;
        //            tsslMensajePgsBarBuscador.Text = "N° Registros consultados = " + tsPgsBarBuscador.Value.ToString();

        //        }
        //        tsslMensajePgsBarBuscador.Visible = false;
        //        tsslMensajePgsBarBuscador.Text = string.Empty;
        //        tsPgsBarBuscador.Visible = false;
        //        tsPgsBarBuscador.Value = tsPgsBarBuscador.Minimum;
        //        MessageBox.Show("¡Proceso RENIEC Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        CargarData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("¡Se cancelo la [Importacion] del Archivo Excel!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }        
        
        //}

        //private void Importar2() 
        //{
        //    DataTable dtListas = new DataTable();
        //    dtListas = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ListadoReniec();

        //    int filas = dtListas.Rows.Count;
        //    tsPgsBarBuscador.Minimum = 0;
        //    tsPgsBarBuscador.Maximum = filas;
        //    tsslMensajePgsBarBuscador.Visible = true;
        //    tsPgsBarBuscador.Visible = true;
        //    /*****************************************************/

        //    foreach (DataRow row in dtListas.Rows)
        //    {
        //        string Documento = row[2].ToString();
        //        bool Estado = Convert.ToBoolean(row[8]);

        //        if (Estado == true) // Fallecido
        //        {
        //            objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateReniec(Documento, "0");
        //        }
        //        else if (Estado != true) //vivo
        //        {
        //            objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateReniec(Documento, "1");
        //        }

        //        tsPgsBarBuscador.Value++;
        //        tsslMensajePgsBarBuscador.Text = "N° Registros consultados = " + tsPgsBarBuscador.Value.ToString();

        //    }
        //    tsslMensajePgsBarBuscador.Visible = false;
        //    tsslMensajePgsBarBuscador.Text = string.Empty;
        //    tsPgsBarBuscador.Visible = false;
        //    tsPgsBarBuscador.Value = tsPgsBarBuscador.Minimum;
        //    MessageBox.Show("¡Proceso RENIEC Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    CargarData();
        
        //}

        private void Importar3() 
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_UpdateReniec(VariablesGlobales.CodigoConciliacionX);
                    CargarData();
                    MessageBox.Show("¡Proceso Reniec Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("¡No hay datos a verificar..!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvEstadoCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dgvEstadoCuenta.CurrentRow;
            string estado = Convert.ToString(row.Cells["Estado"].Value);
            if (!string.Equals("Pendiente", estado))
                return;
            EstadoCuentaConciliacion objEstadoCuentaConciliacion = new EstadoCuentaConciliacion();
            objEstadoCuentaConciliacion.ActivoFissal = Convert.ToString(row.Cells["ActivoFissal"].Value);
            objEstadoCuentaConciliacion.ActivoSis = Convert.ToString(row.Cells["ActivoSis"].Value);
            objEstadoCuentaConciliacion.CadenaId = Convert.ToInt32(row.Cells["CadenaId"].Value);
            objEstadoCuentaConciliacion.CodigoConciliacion = Convert.ToInt32(row.Cells["Conciliacion"].Value);
            objEstadoCuentaConciliacion.EstablecimientoId = Convert.ToInt32(row.Cells["EstablecimientoId"].Value);
            objEstadoCuentaConciliacion.Estado = estado;
            objEstadoCuentaConciliacion.EstadoCuentaConciliacionId = Convert.ToInt32(row.Cells["EstadoCuentaConciliacionId"].Value);
            objEstadoCuentaConciliacion.NoFallecido = Convert.ToString(row.Cells["NoFallecido"].Value);
            objEstadoCuentaConciliacion.PacienteId = Convert.ToString(row.Cells["PacienteId"].Value);
            FrmEstadoCuenta objFrmEstadoCuenta = new FrmEstadoCuenta(objEstadoCuentaConciliacion);
            DialogResult result = objFrmEstadoCuenta.ShowDialog();
            if (result == DialogResult.OK)
                CargarData();
        }

    }
}
