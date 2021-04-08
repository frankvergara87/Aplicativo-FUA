using FissalBE;
using FissalBL;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace FissalWinForm
{
    public class FuncionesBases
    {
        #region 'CARGA COMBO TIPO DOCUMENTO'

            public static void CargarComboTipoDoc(ComboBox cbo)
            {
                TipoDocumentoBL ObjTipoDocumentoBL = new TipoDocumentoBL();

                DataTable dtTipoDoc = ObjTipoDocumentoBL.TipoDocumento_listar();

                /*INSERTAR NUEVA FILA*/

                DataRow row = dtTipoDoc.NewRow();
                row["TipoDocumentoId"] = DBNull.Value;
                row["Descripcion"] = "-Seleccione-";
                dtTipoDoc.Rows.InsertAt(row, 0);

                cbo.DataSource = dtTipoDoc;
                cbo.ValueMember = "TipoDocumentoId";
                cbo.DisplayMember = "Descripcion";

            }

        #endregion

        #region 'CARGA COMBO TIPO REGIMEN'

        
            public static void CargarComboRegimen(ComboBox cbo)
            {
                TipoRegimenBL ObjTipoRegimenBL = new TipoRegimenBL();

                DataTable dtRegimen = ObjTipoRegimenBL.TipoRegimen_listar();

                /*INSERTAR NUEVA FILA*/

                DataRow row = dtRegimen.NewRow();
                row["TipoRegimenId"] = DBNull.Value;
                row["Descripcion"] = "-Seleccione-";
                dtRegimen.Rows.InsertAt(row, 0);

                cbo.DataSource = dtRegimen;
                cbo.ValueMember = "TipoRegimenId";
                cbo.DisplayMember = "Descripcion";
            }

        #endregion

        #region 'CARGA COMBO INSTITUCIONES'

            public static void CargarComboInstitucion(ComboBox cbo)
            {
                InstitucionBL ObjInstitucionBL = new InstitucionBL();

                cbo.DataSource = ObjInstitucionBL.Instituciones_listar();
                cbo.ValueMember = "InstitucionId";
                cbo.DisplayMember = "Descripcion";
            }

        #endregion

        #region 'CARGA COMBO TIPO INGRESO'

            public static void CargarComboTipoIngreso(ComboBox cbo)
            {
                TipoIngresoBL ObjTipoIngresoBL = new TipoIngresoBL();

                DataTable dtTipoIngreso = ObjTipoIngresoBL.TipoIngreso_listar();

                /*INSERTAR NUEVA FILA*/

                DataRow row = dtTipoIngreso.NewRow();
                row["TipoIngresoId"] = DBNull.Value;
                row["Descripcion"] = "-Seleccione-";
                dtTipoIngreso.Rows.InsertAt(row, 0);

                cbo.DataSource = dtTipoIngreso;
                cbo.ValueMember = "TipoIngresoId";
                cbo.DisplayMember = "Descripcion";
            }

        #endregion

        #region 'CARGA COMBO LUGAR ATENCIONES'

            public static void CargarComboLugarAtencion(ComboBox cbo)
            {
                LugarAtencionBL ObjLugarAtencionBL = new LugarAtencionBL();

                DataTable dtLugarAtencion = ObjLugarAtencionBL.LugarAtencion_listar();

                /*INSERTAR NUEVA FILA*/

                DataRow row = dtLugarAtencion.NewRow();
                row["LugarAtencionId"] = DBNull.Value;
                row["Descripcion"] = "-Seleccione-";
                dtLugarAtencion.Rows.InsertAt(row, 0);

                cbo.DataSource = dtLugarAtencion;
                cbo.ValueMember = "LugarAtencionId";
                cbo.DisplayMember = "Descripcion";
            }

        #endregion

        #region 'CARGA COMBO PERSONAL ATIENDE'

        public static void CargarComboPersonalAtiende(ComboBox cbo)
        {
            PersonalAtiendeBL ObjPersonalAtiendeBL = new PersonalAtiendeBL();

            DataTable dtPersonalAtiende = ObjPersonalAtiendeBL.PersonalAtiende_listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtPersonalAtiende.NewRow();
            row["PersonalAtiendeId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtPersonalAtiende.Rows.InsertAt(row, 0);

            cbo.DataSource = dtPersonalAtiende;
            cbo.ValueMember = "PersonalAtiendeId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO TIPO PRESTACION'

        public static void CargarComboTipoPrestacion(ComboBox cbo)
        {
            TipoPrestacionBL ObjTipoPrestacionBL = new TipoPrestacionBL();

            DataTable dtTipoPrestacion = ObjTipoPrestacionBL.TipoPrestacion_listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtTipoPrestacion.NewRow();
            row["TipoPrestacionId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtTipoPrestacion.Rows.InsertAt(row, 0);

            cbo.DataSource = dtTipoPrestacion;
            cbo.ValueMember = "TipoPrestacionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO RESPONSABLE ATENCION'

        public static void CargarComboResponsableAtencion(ComboBox cbo)
        {
            ResponsableAtencionBL ObjResponsableAtencionBL = new ResponsableAtencionBL();

            DataTable dtResponsableAtencion = ObjResponsableAtencionBL.ResponsableAtencion_listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtResponsableAtencion.NewRow();
            row["ResponsableAtencionId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtResponsableAtencion.Rows.InsertAt(row, 0);

            cbo.DataSource = dtResponsableAtencion;
            cbo.ValueMember = "ResponsableAtencionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO ESTABLECIMIENTO CON CONVENIO'

        public static void CargarCboEstablecimientoConConvenio(ComboBox cbo)
        {
            EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();

            DataTable dtEstablecimiento = objEstablecimientoBL.GetEstablecimientosConvenio();

            DataRow row = dtEstablecimiento.NewRow();
            row["EstablecimientoId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtEstablecimiento.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEstablecimiento;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO ESTABLECIMIENTO CON CONVENIO PARA CIERRES DE DIGITACION'

        public static void CargarCboEstablecimientoCierreDig(ComboBox cbo)
        {
            EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();

            DataTable dtEstablecimiento = objEstablecimientoBL.GetEstablecimientosCierreDig();

            DataRow row = dtEstablecimiento.NewRow();
            row["EstablecimientoId"] = 0;
            row["Establecimiento"] = "-Seleccione-";
            dtEstablecimiento.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEstablecimiento;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Establecimiento";
        }

        #endregion


        #region 'CARGA COMBO MODALIDAD AUTORIZACION'

        public static void CargarCboModalidadAutorizacion(ComboBox cbo)
        {
            TipoModalidadBL objTipoModalidadBL = new TipoModalidadBL();
            DataTable dtModalidad = objTipoModalidadBL.GetAllTiposModalidad();
            DataRow row = dtModalidad.NewRow();
            row["ModalidadId"] = DBNull.Value;
            row["Descripcion"] = "-SELECCIONE-";
            dtModalidad.Rows.InsertAt(row, 0);
            cbo.DataSource = dtModalidad;
            cbo.ValueMember = "ModalidadId";
            cbo.DisplayMember = "Descripcion";
            cbo.AutoCompleteCustomSource = FuncionesBases.CargarAutoCompletar(dtModalidad);
            cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #endregion

        #region 'CARGA COMBO TIPO AUTORIZACION'

        public static void CargarCboTipoAutorizacion(ComboBox cbo)
        {
            TipoAutorizacionBL objTipoAutorizacionBL = new TipoAutorizacionBL();
            DataTable dtTipoAutorizacion = objTipoAutorizacionBL.GetAllTiposAutorizacion();
            DataRow row = dtTipoAutorizacion.NewRow();
            row["TipoAutorizacionId"] = DBNull.Value;
            row["Descripcion"] = "-SELECCIONE-";
            dtTipoAutorizacion.Rows.InsertAt(row, 0);
            cbo.DataSource = dtTipoAutorizacion;
            cbo.ValueMember = "TipoAutorizacionId";
            cbo.DisplayMember = "Descripcion";
            //cbo.AutoCompleteCustomSource = FuncionesBases.CargarAutoCompletar(dtTipoAutorizacion);
            //cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #endregion

        #region 'OBTIENE DIAS ENTRE DOS FECHAS'
        public static int ObtenerDiasEntreDosFechas(DateTime fecha_mayor, DateTime fecha_menor)
        {
            TimeSpan ts = fecha_mayor - fecha_menor;
            int diferenciaEnDias = ts.Days;
            return diferenciaEnDias;
        }
        #endregion

        #region 'CARGA COMBO ESQUEMA X CATEGORIA'


        public static void CargarComboEsquemaCategoria(ComboBox cbo, string CategoriaId, int EstadioId)
        {
            MedicamentoBL objMedicamentoBL = new MedicamentoBL();

            cbo.DataSource = objMedicamentoBL.Esquema_EsquemaCategoria(CategoriaId, EstadioId);
            cbo.ValueMember = "EsquemaId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO ESQUEMA X CATEGORIA 2'


        public static void CargarComboEsquemaCategoria2(ComboBox cbo)
        {
            MedicamentoBL objMedicamentoBL = new MedicamentoBL();

            cbo.DataSource = objMedicamentoBL.Esquema_EsquemaCategoria2();
            cbo.ValueMember = "EsquemaId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO DESTINO ASEGURADO'

        public static void CargarComboDestinoAsegurado(ComboBox cbo)
        {
            DestinoAseguradoBL objDestinoAseguradoBL = new DestinoAseguradoBL();

            DataTable dtDestinoAsegurado = objDestinoAseguradoBL.DestinoAsegurado_Listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtDestinoAsegurado.NewRow();
            row["DestinoAseguradoId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtDestinoAsegurado.Rows.InsertAt(row, 0);

            cbo.DataSource = dtDestinoAsegurado;
            cbo.ValueMember = "DestinoAseguradoId";
            cbo.DisplayMember = "Descripcion";
        }

        public static void CargarComboMedico_EspecialidadListar(ComboBox cbo)
        {
            MedicoBL objMedicoBL = new MedicoBL();

            DataTable dtEspecialidad = objMedicoBL.Medico_EspecialidadListar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtEspecialidad.NewRow();            
            row["Especialidad"] = "-Seleccione-";
            dtEspecialidad.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEspecialidad;
            cbo.ValueMember = "Especialidad";
            cbo.DisplayMember = "Especialidad";
        }

        #endregion

        #region 'CARGA COMBO ESTABLECIMIENTO CON TARIFARIO'

        public static void CargarCboEstablecimiento_Listar(ComboBox cbo)
        {
            TarifarioBL objTarifarioBL = new TarifarioBL();
            DataTable dtTarifario = objTarifarioBL.Establecimiento_Listar();
            DataRow row = dtTarifario.NewRow();
            row["EstablecimientoId"] = DBNull.Value;
            row["Descripcion"] = "-SELECCIONE-";
            dtTarifario.Rows.InsertAt(row, 0);
            cbo.DataSource = dtTarifario;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Descripcion";
            //cbo.AutoCompleteCustomSource = FuncionesBases.CargarAutoCompletar(dtTarifario);
            //cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #endregion

        #region 'ENUMERA FILAS DATAGRIDVIEW'
        
        public static void EnumerarFilasDataGridView(DataGridView dgv)
        {
            if (dgv != null)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
            }
        }

        #endregion

        #region 'IMPRIME FILAS DATAGRIDVIEW EN TOOLSTRIPSTATUPLABEL'

        public static void ImprimirFilasDataGridView(DataGridView dgv, ToolStripStatusLabel tssl)
        {
            tssl.Text = string.Format("{0} filas", dgv.RowCount);
        }

        #endregion

        #region 'PERMITE SOLO EL INGRESO DE NUMEROS'

        public static void PermitirSoloNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
                e.Handled = Convert.ToBoolean(bool.FalseString);
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                    e.Handled = Convert.ToBoolean(bool.FalseString);
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = Convert.ToBoolean(bool.TrueString);
                    MessageBox.Show("Ingrese solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        #endregion

        #region 'PERMITE SOLO EL INGRESO DE NUMEROS CON COMAS'

        public static void PermitirSoloNumerosConComa(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
                e.Handled = Convert.ToBoolean(bool.FalseString);
            else
                if (Char.IsControl(e.KeyChar)) //permitir tecla retroceso 
                    e.Handled = Convert.ToBoolean(bool.FalseString);
                else
                    if (e.KeyChar == 44) //permitir coma
                        e.Handled = Convert.ToBoolean(bool.FalseString);
                    else
                    {
                        //el resto de teclas pulsadas se desactivan 
                        e.Handled = Convert.ToBoolean(bool.TrueString);
                        MessageBox.Show("Ingrese solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
        }

        #endregion

        #region 'PERMITE SOLO EL INGRESO DE LETRAS'

        public static void PermitirSoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else 
                if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    if (Char.IsSeparator(e.KeyChar))
                        e.Handled = false;
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Ingrese solo letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
        }

        #endregion

        #region 'CARGA COMBO DE PERFILES'

        public static void CargarComboPerfilesFull(ComboBox cbo)
        {

            PerfilBL objPerfilBL = new PerfilBL();

            DataTable dtTipoDoc = objPerfilBL.Listar_PerfilesFull();

            DataRow row = dtTipoDoc.NewRow();
            row["Id_Perfil"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtTipoDoc.Rows.InsertAt(row, 0);

            cbo.DataSource = dtTipoDoc;
            cbo.ValueMember = "Id_Perfil";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO DE PERFILES X ESTABLECIMIENTO'

        public static void CargarComboPerfFullXEstab(ComboBox cbo, int EstablecimientoId)
        {

            PerfilBL objPerfilBL = new PerfilBL();

            DataTable dtTipoDoc = objPerfilBL.Listar_PerfilesFullxEstablecimiento(EstablecimientoId);


            DataRow row = dtTipoDoc.NewRow();
            row["Id_Perfil"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtTipoDoc.Rows.InsertAt(row, 0);

            cbo.DataSource = dtTipoDoc;
            cbo.ValueMember = "Id_Perfil";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO DE PERFILES X ID.PERFIL'

        public static void CargarComboPerfiles(ComboBox cbo, int Id_Perfil)
        {

            PerfilBL objPerfilBL = new PerfilBL();

            DataTable dtTipoDoc = objPerfilBL.Listar_Perfiles(Id_Perfil);

            //DataRow row = dtTipoDoc.NewRow();
            //row["Id_Perfil"] = DBNull.Value;
            //row["Descripcion"] = "-Seleccione-";
            //dtTipoDoc.Rows.InsertAt(row, 0);

            cbo.DataSource = dtTipoDoc;
            cbo.ValueMember = "Id_Perfil";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CONVIERTE LISTA A DATATABLE'

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion

        #region 'CONVIERTE LISTA A AutoCompleteStringCollection'

        public static AutoCompleteStringCollection CargarAutoCompletar<T>(IList<T> lista)
        {
            DataTable dt = ConvertToDataTable(lista);
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Descripcion"]));
            }
            return stringCol;
        }

        #endregion

        #region 'CONVIERTE DataTable A AutoCompleteStringCollection'

        public static AutoCompleteStringCollection CargarAutoCompletar(DataTable dt)
        {
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Descripcion"]));
            }
            return stringCol;
        }

        #endregion

        #region 'CARGA COMBO DE PERFILES X ID.PERFIL'

        public static void CargarComboModulos(ComboBox cbo)
        {

            PerfilBL objPerfilBL = new PerfilBL();

            DataTable dtTipoDoc = objPerfilBL.Listar_Modulos();

            DataRow row = dtTipoDoc.NewRow();
            row["RowNum"] = DBNull.Value;
            row["DescripcionMenu"] = "-Seleccione-";
            dtTipoDoc.Rows.InsertAt(row, 0);

            cbo.DataSource = dtTipoDoc;
            cbo.ValueMember = "RowNum";
            cbo.DisplayMember = "DescripcionMenu";
        }

        #endregion

        #region 'LIMPIA TEXTBOX EXISTENTES EN CONTROL'

        public static void LimpiarTextBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control.Controls.Count > 0)
                    LimpiarTextBox(control);
            }
        }

        #endregion

        #region 'LIMPIA COMBOBOX EXISTENTES EN CONTROL'

        public static void LimpiarComboBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = 0;
                if (control.Controls.Count > 0)
                    LimpiarComboBox(control);
            }
        }

        #endregion

        #region 'LIMPIA CHECKBOX EXISTENTES EN CONTROL'

        public static void LimpiarCheckBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is CheckBox)
                    ((CheckBox)control).Checked = Convert.ToBoolean(bool.FalseString);
                if (control.Controls.Count > 0)
                        LimpiarCheckBox(control);
            }
        }

        #endregion

        #region 'LIMPIA DATAGRIDVIEW EXISTENTES EN CONTROL'

        public static void LimpiarDataGridView(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is DataGridView)
                    ((DataGridView)control).DataSource = null;
                if (control.Controls.Count > 0)
                    LimpiarDataGridView(control);
            }
        }

        #endregion

        #region 'LIMPIA CONTROLES - TEXTBOX, COMBOBOX, CHECKBOX, RADIOBUTTON, DATAGRIDVIEW'

        public static void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = 0;
                if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                if (control is DataGridView)
                    ((DataGridView)control).DataSource = null;
                if (control.Controls.Count > 0)
                    LimpiarControles(control);
            }
        }

        #endregion

        #region 'ACTIVA O DESACTIVA CONTROLES - TEXTBOX, COMBOBOX, CHECKBOX, DATAGRIDVIEW'

        public static void ActivaControles(Control parent, bool enabled)
        {
            foreach (Control control in parent.Controls)
            {
                if ((control is TextBox) || (control is ComboBox) || (control is CheckBox) || (control is RadioButton) || (control is Button) || (control is DateTimePicker) || (control is DataGridView) || (control is ToolStrip))
                    control.Enabled = enabled;
                if (control.Controls.Count > 0)
                    ActivaControles(control,enabled);
            }
        }

        #endregion

        #region 'EXPORTAR EXCEL - NPOI [PROGRESSBAR - LABEL]'

        public static void DataTableToXls(DataTable table, ProgressBar PBar)
        {

            PBar.Minimum = 0;
            PBar.Maximum = table.Rows.Count;

            XSSFWorkbook xlsWorkBook = new XSSFWorkbook();
            ISheet log = xlsWorkBook.CreateSheet("Excel-Tab-Name");

            /*======= Inicio Cabecera =============================================*/
            int indiceColumna = 0;
            IRow Header = log.CreateRow(0);
            foreach (DataColumn columna in table.Columns)
            {
                Header.CreateCell(indiceColumna).SetCellValue(columna.ColumnName);
                indiceColumna++;
            }
            /*======= Fin Cabecera ================================================*/


            /*======= Inicio Contenido ============================================*/
            int RowCount = 1;
            int Cont = 1;
            foreach (DataRow row in table.Rows)
            {
                IRow r = log.CreateRow(RowCount);
                int indiceFila = 0;
                foreach (DataColumn fila in table.Columns)
                {
                    ICell Celda = r.CreateCell(indiceFila);
                    Celda.SetCellValue(row[fila.ColumnName].ToString());
                    indiceFila++;               
                }
                RowCount++;
                
                PBar.Value = Cont++;
            }
            /*======= Fin Contenido ================================================*/


            /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter += "Tipo Archivo|*.xlsx";
            sfd.FilterIndex = 0;
            sfd.DefaultExt = "xlsx";
            sfd.RestoreDirectory = true;
            sfd.CreatePrompt = true;
            sfd.Title = "Exportando a Excel..";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PBar.Value = 0;                

                FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                xlsWorkBook.Write(file);
                file.Close();
            }
            /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/
        }
        
        #endregion
        
        #region 'EXPORTA DGV A EXCEL MOSTRANDO PROGRESSBAR - NPOI'

        public static void ExportarExcel(DataGridView dgv, ToolStripProgressBar pgsBar, ToolStripStatusLabel mensaje)
        {
            if (dgv.Rows.Count > 0)
            {
                pgsBar.Minimum = 0;
                pgsBar.Maximum = dgv.Rows.Count;
                mensaje.Visible = Convert.ToBoolean(bool.TrueString);
                mensaje.Text = "Exportando a Excel...";
                pgsBar.Visible = Convert.ToBoolean(bool.TrueString);
                XSSFWorkbook xlsWorkBook = new XSSFWorkbook();
                ISheet log = xlsWorkBook.CreateSheet("Excel-Tab-Name");

                /*======= Inicio Cabecera =============================================*/
                int indiceColumna = 0;
                IRow Header = log.CreateRow(0);
                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    if (columna.Visible)
                    {
                        Header.CreateCell(indiceColumna).SetCellValue(columna.HeaderText);
                        indiceColumna++;
                    }
                }
                /*======= Fin Cabecera ================================================*/


                /*======= Inicio Contenido ============================================*/
                int indiceFila = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;
                    IRow r = log.CreateRow(indiceFila);
                    foreach (DataGridViewColumn columna in dgv.Columns)
                    {
                        if (columna.Visible)
                        {
                            ICell Celda = r.CreateCell(indiceColumna);
                            Celda.SetCellValue(row.Cells[columna.Name].Value.ToString());
                            indiceColumna++;
                        }
                    }
                    pgsBar.Value = indiceFila;
                }
                mensaje.Text = string.Empty;
                mensaje.Visible = Convert.ToBoolean(bool.FalseString);
                pgsBar.Visible = Convert.ToBoolean(bool.FalseString);
                pgsBar.Value = pgsBar.Minimum;
                /*======= Fin Contenido ================================================*/


                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xlsx";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xlsx";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pgsBar.Value = 0;

                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    xlsWorkBook.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        
        #region 'EXPORTA DATATABLE A EXCEL MOSTRANDO PROGRESSBAR - NPOI'

        public static void ExportarExcel(DataTable dt, ToolStripProgressBar pgsBar, ToolStripStatusLabel mensaje)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                pgsBar.Minimum = 0;
                pgsBar.Maximum = dt.Rows.Count;
                mensaje.Text = "Exportando a Excel...";
                mensaje.Visible = true;
                pgsBar.Visible = true;
                XSSFWorkbook xlsWorkBook = new XSSFWorkbook();
                ISheet log = xlsWorkBook.CreateSheet("Excel-Tab-Name");

                /*======= Inicio Cabecera =============================================*/                
                int indiceColumna = 0;
                IRow Header = log.CreateRow(0);
                foreach (DataColumn columna in dt.Columns)
                {
                    Header.CreateCell(indiceColumna).SetCellValue(columna.ColumnName);
                    indiceColumna++;
                }
                /*======= Fin Cabecera ================================================*/


                /*======= Inicio Contenido ============================================*/
                int indiceFila = 0;
                foreach (DataRow row in dt.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;
                    IRow r = log.CreateRow(indiceFila);
                    foreach (DataColumn columna in dt.Columns)
                    {
                        ICell Celda = r.CreateCell(indiceColumna);
                        Celda.SetCellValue(row[columna.ColumnName].ToString());
                        indiceColumna++;
                    }
                    pgsBar.Value = indiceFila;
                }
                mensaje.Visible = false;
                mensaje.Text = string.Empty;
                pgsBar.Visible = false;
                pgsBar.Value = pgsBar.Minimum;
                /*======= Fin Contenido ================================================*/


                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xlsx";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xlsx";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pgsBar.Value = 0;

                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    xlsWorkBook.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        #endregion

        #region 'VALIDA FECHA INICIO'

        public static bool ValidarFechaInicio(TextBox txtFechaInicio, TextBox txtFechaFin, ErrorProvider errorProvider1)
        {
            bool cancel = false;
            if (!string.Equals(txtFechaInicio.Text.Trim(),string.Empty))
            {
                DateTime fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
                DateTime fechaFin = DatosBL.GetDate().Date;
                if (FuncionesBases.ObtenerDiasEntreDosFechas(fechaFin, fechaInicio) < 0)
                {
                    errorProvider1.SetError(txtFechaInicio, "No puede ser mayor que la fecha actual");
                    cancel = true;
                }
                if (txtFechaFin.Text.Trim() != string.Empty)
                {
                    fechaFin = Convert.ToDateTime(txtFechaFin.Text);
                    if (FuncionesBases.ObtenerDiasEntreDosFechas(fechaFin, fechaInicio) < 0)
                    {
                        errorProvider1.SetError(txtFechaInicio, "No puede ser mayor que la fecha hasta o fin");
                        cancel = true;
                    }
                }
            }
            return cancel;
        }

        #endregion

        #region 'VALIDA FECHA FIN'

        public static bool ValidarFechaFin(TextBox txtFechaFin, ErrorProvider errorProvider1)
        {
            bool cancel = false;
            if (!string.Equals(txtFechaFin.Text.Trim(), string.Empty))
            {
                DateTime fechaInicio = Convert.ToDateTime(txtFechaFin.Text);
                DateTime fechaFin = DatosBL.GetDate().Date;
                if (FuncionesBases.ObtenerDiasEntreDosFechas(fechaFin, fechaInicio) < 0)
                {
                    errorProvider1.SetError(txtFechaFin, "No puede ser mayor que la fecha actual");
                    cancel = true;
                }
            }
            return cancel;
        }

        #endregion

        #region 'VALIDA SI EL TEXTBOX ESTA VACIO - CON ERROR PROVIDER'
        public static bool EsTextBoxVacio(TextBox txt, ErrorProvider errorProvider1)
        {
            bool cancel = false;
            string texto = txt.Text.Trim();
            if (string.Equals(texto, string.Empty))
            {
                errorProvider1.SetError(txt, "Debe ingresar dato");
                cancel = true;
            }
            return cancel;
        }
        
        #endregion

        #region 'VALIDA SI EL TEXTBOX ESTA VACIO'
        public static bool EsTextBoxVacio(TextBox txt)
        {
            bool cancel = Convert.ToBoolean(bool.FalseString);
            string texto = txt.Text.Trim();
            if (string.Equals(texto, string.Empty))
                cancel = Convert.ToBoolean(bool.TrueString);
            return cancel;
        }

        #endregion

        #region 'VALIDA SI EL COMBOBOX NO HA SIDO SELECCIONADO - CON ERROR PROVIDER'
        public static bool EsComboBoxSinSeleccion(ComboBox cbo, ErrorProvider errorProvider1)
        {
            bool cancel = false;
            if (cbo.SelectedIndex.Equals(0))
            {
                errorProvider1.SetError(cbo, "Debe seleccionar una opcion");
                cancel = true;
            }
            return cancel;
        }

        #endregion

        #region 'VALIDA SI EL COMBOBOX NO HA SIDO SELECCIONADO'

        public static bool EsComboBoxSinSeleccion(ComboBox cbo)
        {
            bool cancel = false;
            if (cbo.SelectedIndex.Equals(0))
                cancel = true;
            return cancel;
        }

        #endregion

        #region 'VALIDA SI EL CHECKBOX NO HA SIDO SELECCIONADO - CON ERROR PROVIDER'
        public static bool EsCheckBoxSinSeleccion(CheckBox chk, ErrorProvider errorProvider1)
        {
            bool cancel = false;
            if (!chk.Checked)
            {
                errorProvider1.SetError(chk, "Debe marcar la opcion");
                cancel = true;
            }
            return cancel;
        }

        #endregion

        #region 'CARGA COMBO SEXO

        public static void CargarCboSexo(ComboBox cbo)
        {
            SexoBL objSexoBL = new SexoBL();

            DataTable dtSexo = objSexoBL.GetAllSexos();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtSexo.NewRow();
            row["SexoId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtSexo.Rows.InsertAt(row, 0);

            cbo.DataSource = dtSexo;
            cbo.ValueMember = "SexoId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO FASE

        public static void CargarCboFase(ComboBox cbo)
        {
            FaseBL objFaseBL = new FaseBL();

            DataTable dtFase = objFaseBL.GetAllFases();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtFase.NewRow();
            row["FaseId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtFase.Rows.InsertAt(row, 0);

            cbo.DataSource = dtFase;
            cbo.ValueMember = "FaseId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO ESTADIO

        public static void CargarCboEstadio(ComboBox cbo)
        {
            EstadioBL objEstadioBL = new EstadioBL();

            DataTable dtEstadio = objEstadioBL.GetAllEstadios();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtEstadio.NewRow();
            row["EstadioId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtEstadio.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEstadio;
            cbo.ValueMember = "EstadioId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO CATEGORIA

        public static void CargarCboCategoria(ComboBox cbo)
        {
            CategoriaCIEBL objCategoriaCIEBL = new CategoriaCIEBL();

            DataTable dtCategoria = objCategoriaCIEBL.GetCategoriasCobertura();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtCategoria.NewRow();
            row["CategoriaId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtCategoria.Rows.InsertAt(row, 0);

            cbo.DataSource = dtCategoria;
            cbo.ValueMember = "CategoriaId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO TIPO OBSERVACION'

        public static void CargarCboTipoObservacion(ComboBox cbo)
        {
            TipoObservacionBL objTipoObservacionBL = new TipoObservacionBL();
            DataTable dtTipoObservacion = objTipoObservacionBL.GetALLTiposObservacion();
            cbo.DataSource = dtTipoObservacion;
            cbo.ValueMember = "TipoObservacionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO TIPO OBSERVACION ATENCION'

        public static void CargarCboTipoObservacionAtencion(ComboBox cbo)
        {
            TipoObservacionBL objTipoObservacionBL = new TipoObservacionBL();
            DataTable dtTipoObservacion = objTipoObservacionBL.GetTiposObservacionAtencion();
            cbo.DataSource = dtTipoObservacion;
            cbo.ValueMember = "TipoObservacionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO TIPO OBSERVACION DETALLE ATENCION'

        public static void CargarCboTipoObservacionDetalleAtencion(ComboBox cbo)
        {
            TipoObservacionBL objTipoObservacionBL = new TipoObservacionBL();
            DataTable dtTipoObservacion = objTipoObservacionBL.GetTiposObservacionDetalleAtencion();
            cbo.DataSource = dtTipoObservacion;
            cbo.ValueMember = "TipoObservacionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO TIPO OBSERVACION PROCEDIMIENTO ATENCION'

        public static void CargarCboTipoObservacionProcedimientoAtencion(ComboBox cbo)
        {
            TipoObservacionBL objTipoObservacionBL = new TipoObservacionBL();
            DataTable dtTipoObservacion = objTipoObservacionBL.GetTiposObservacionProcedimientoAtencion();
            cbo.DataSource = dtTipoObservacion;
            cbo.ValueMember = "TipoObservacionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO TIPO OBSERVACION MEDICAMENTO ATENCION'

        public static void CargarCboTipoObservacionMedicamentoAtencion(ComboBox cbo)
        {
            TipoObservacionBL objTipoObservacionBL = new TipoObservacionBL();
            DataTable dtTipoObservacion = objTipoObservacionBL.GetTiposObservacionMedicamentoAtencion();
            cbo.DataSource = dtTipoObservacion;
            cbo.ValueMember = "TipoObservacionId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'QUITA CONTROL DE ORDEN DE TABULACION - GROUPBOX'

        public static void QuitarControlesTabulacion(Control parent, bool tabStop)
        {
            foreach (Control control in parent.Controls)
            {
                control.TabStop = tabStop;
                if (control.Controls.Count > 0)
                    QuitarControlesTabulacion(control, tabStop);
            }
        }

        #endregion

        #region 'MUESTRA UN CUADRO DE DIALOGO CON ENTRADA DE TEXTO'

        public static string ShowDialogInputBox(string mensaje, string titulo, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(mensaje, titulo, defaultValue);
        }

        #endregion

        #region 'CARGA COMBO REGION'

        public static void CargarCboRegion(ComboBox cbo)
        {
            RegionBL objRegionBL = new RegionBL();
            DataTable dtRegion = objRegionBL.GetAllRegiones();
            DataRow row = dtRegion.NewRow();
            row["codigo"] = DBNull.Value;
            row["region"] = "-SELECCIONE-";
            dtRegion.Rows.InsertAt(row, 0);
            cbo.DataSource = dtRegion;
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "region";
        }

        #endregion

        #region 'CARGA COMBO GRUPO CATEGORIA'

        public static void CargarCboGrupoCategoria(ComboBox cbo)
        {
            GrupoCategoriaBL objGrupoCategoriaBL = new GrupoCategoriaBL();
            DataTable dtGrupoCategoriaBL = objGrupoCategoriaBL.GetAllGrupoCategoria();
            DataRow row = dtGrupoCategoriaBL.NewRow();
            row["codigo"] = DBNull.Value;
            row["categoria"] = "-SELECCIONE-";
            dtGrupoCategoriaBL.Rows.InsertAt(row, 0);
            cbo.DataSource = dtGrupoCategoriaBL;
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "categoria";
        }

        #endregion

        #region 'EXPORTAR/IMPORTAR CSV'

        public static void ExpCsv(DataTable dt)
        {

            //DataGridView dgvLista = new DataGridView();

            //dgvLista.DataSource = dt;


           /*======= Inicio Cuadro de Dialogo - Guardar CSV =====================*/
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Fichero CSV (*.txt)|*.txt";
            dlGuardar.FileName = "Datos_sqlite";
            dlGuardar.Title = "Exportar a CSV";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                //for (int i = 0; i < dbTabla.Columns.Count; i++)
                //{
                //    if (i == dbTabla.Columns.Count - 1)
                //    {
                //        csvMemoria.Append(String.Format("{0}" + "",
                //            dbTabla.Columns[i].HeaderText));
                //    }
                //    else
                //    {
                //        csvMemoria.Append(String.Format("{0}" + ",",
                //            dbTabla.Columns[i].HeaderText));
                //    }
                //}
                //csvMemoria.AppendLine();

                for (int m = 0; m < dt.Rows.Count; m++)
                {
                    for (int n = 0; n < dt.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == dt.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("{0}" + "",
                            //dt.Rows[m].Cells[n].Value));
                            dt.Rows[m][n]));
 
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("{0}" + ",",
                            //dt.Rows[m].Cells[n].Value));
                            dt.Rows[m][n]));
                        }
                    }
                    csvMemoria.AppendLine();
                }

                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(dlGuardar.FileName, false,
                       System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }

        }

        public static void ImpCsv(DataTable dt)
        {
            DataGridView Grilla = new DataGridView();
            OpenFileDialog ofd = new OpenFileDialog();

            string ruta = String.Empty;

            ofd.InitialDirectory = "c:\\temp\\";

            ofd.Filter = "CSV files (*.csv)|*.CSV";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ruta = ofd.FileName;
            }

            string TextLine = String.Empty;
            string[] SplitLine;

            if (System.IO.File.Exists(ruta) == true)
            {

                System.IO.StreamReader objReader = new System.IO.StreamReader(ruta);

                while (objReader.Peek() != -1)
                {
                    TextLine = objReader.ReadLine();
                    SplitLine = TextLine.Split(',');
                    Grilla.ColumnCount = SplitLine.Length - 1;
                    Grilla.Rows.Add(SplitLine);
                }

                /***************PASAR DATOS A DATATABLE*/
                foreach(DataGridViewColumn columna in Grilla.Columns)
                {
                    DataColumn col = new DataColumn(columna.Name);
                    dt.Columns.Add(col);
                }
                //Recorrer filas
                foreach (DataGridViewRow fila in Grilla.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = fila.Cells[0].Value.ToString();
                    dr[1] = fila.Cells[1].Value.ToString();
                    dr[2] = fila.Cells[2].Value.ToString();
                    dr[3] = fila.Cells[3].Value.ToString();
                    dr[4] = fila.Cells[4].Value.ToString();
                    dr[5] = fila.Cells[5].Value.ToString();
                    dr[6] = fila.Cells[6].Value.ToString();
                    dt.Rows.Add(dr);
                }

                /**************************/
            }
            else
            {
                MessageBox.Show("Archivo Inexistente", "CSV Inexistente");
            }


        }

        #endregion

        #region 'IMPORTAR EXCEL'
        public static DataTable ImportExcel(string fileName) 
        {
                DataTable table = new DataTable();
                XSSFWorkbook workbook = new XSSFWorkbook(new FileStream(fileName, FileMode.Open, FileAccess.Read));
                ISheet sheet = workbook.GetSheetAt(0);
                IRow headerRow = sheet.GetRow(0);

                int cellCount = headerRow.LastCellNum;
                for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                {
                    DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                    table.Columns.Add(column);
                }

                int rowCount = sheet.LastRowNum;
                for (int i = 2; i < rowCount; i++)
                //for (int i = (sheet.FirstRowNum); i < rowCount; i++)
                {
                    IRow row = sheet.GetRow(i);
                    DataRow dataRow = table.NewRow();
                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        if (row.GetCell(j) != null)
                        {
                            //EXCEPTION GENERATING IN THIS CODE
                            dataRow[j] = row.GetCell(j).ToString();
                            ////////////////////////////
                        }
                    }
                    table.Rows.Add(dataRow);
                }
                workbook = null;
                sheet = null;
                return table;
        }        
        
        #endregion

        #region 'CARGA COMBO ESTABLECIMIENTO - USUARIO'

        public static void CargarCboEstablecimientoUsuario(ComboBox cbo)
        {
            EstablecimientoBL objEstablecimientoBL = new EstablecimientoBL();

            DataTable dtEstablecimiento = objEstablecimientoBL.GetEstablecimientosConvenio();

            DataRow row = dtEstablecimiento.NewRow();
            row["EstablecimientoId"] = 0;
            row["Descripcion"] = "-Seleccione-";
            dtEstablecimiento.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEstablecimiento;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO PRODUCCION CM'

        public static void CargarComboProduccionCM(ComboBox cbo)
        {
            ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

            DataTable dtProduccion = objProduccionEstablecimientoBL.GetProduccionEstablecimiento_ProduccionCM();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtProduccion.NewRow();
            row["ProduccionId"] = DBNull.Value;
            row["Codigo"] = "-Seleccione-";
            dtProduccion.Rows.InsertAt(row, 0);
            cbo.DataSource = dtProduccion;
            cbo.ValueMember = "ProduccionId";
            cbo.DisplayMember = "Codigo";
        }

        #endregion

        #region 'CARGA COMBO ESTABLECIMIENTO CM'

        public static void CargarComboEstablecimientoCM(ComboBox cbo)
        {
            ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

            DataTable dtEstablecimiento = objProduccionEstablecimientoBL.GetProduccionEstablecimiento_EstablecimientoCM();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtEstablecimiento.NewRow();
            row["EstablecimientoId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtEstablecimiento.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEstablecimiento;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'CARGA COMBO PRODUCCION CN'

        public static void CargarComboProduccionCN(ComboBox cbo)
        {
            ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

            DataTable dtProduccion = objProduccionEstablecimientoBL.GetProduccionEstablecimiento_ProduccionCN();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtProduccion.NewRow();
            row["ProduccionId"] = DBNull.Value;
            row["Codigo"] = "-Seleccione-";
            dtProduccion.Rows.InsertAt(row, 0);
            cbo.DataSource = dtProduccion;
            cbo.ValueMember = "ProduccionId";
            cbo.DisplayMember = "Codigo";
        }

        #endregion

        #region 'CARGA COMBO ESTABLECIMIENTO CN'

        public static void CargarComboEstablecimientoCN(ComboBox cbo)
        {
            ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

            DataTable dtEstablecimiento = objProduccionEstablecimientoBL.GetProduccionEstablecimiento_EstablecimientoCN();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtEstablecimiento.NewRow();
            row["EstablecimientoId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtEstablecimiento.Rows.InsertAt(row, 0);

            cbo.DataSource = dtEstablecimiento;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion



        /** FUNCIONES CONTROL MEDICO [DUAS OBSERVADOS] 24-03-2015 *********/

        #region 'COMBO FILTRO [CONTROL MEDICO]'

        public static void Filtro_CboCMedico(ComboBox cbo)
        {
            ControlMedicoLogBL objControlMedicoBL = new ControlMedicoLogBL();

            DataTable dtCMedico = objControlMedicoBL.Filtrar_ControlMedico();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtCMedico.NewRow();
            row["Codigo"] = 0;
            row["Descripcion"] = "-Todos-";
            dtCMedico.Rows.InsertAt(row, 0);

            cbo.DataSource = dtCMedico;
            cbo.ValueMember = "Codigo";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'COMBO FILTRO [CONTROL ESTABLECIMIENTO]'
        
        public static void Filtro_CboEstablecimiento(ComboBox cbo)
        {
            ControlMedicoLogBL objControlMedicoBL = new ControlMedicoLogBL();

            //DataTable dtEstablecimientoId = objControlMedicoBL.Filtrar_Establecimiento();

            ///*INSERTAR NUEVA FILA*/

            //DataRow row = dtEstablecimientoId.NewRow();
            //row["EstablecimientoId"] = 0;
            //row["Descripcion"] = "-Todos-";
            //dtEstablecimientoId.Rows.InsertAt(row, 0);

            //cbo.DataSource = dtEstablecimientoId;
            cbo.ValueMember = "EstablecimientoId";
            cbo.DisplayMember = "Descripcion";
        }

        #endregion

        #region 'EXPORTA DATATABLE A EXCEL'

        public static void ExportarExcel(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                XSSFWorkbook xlsWorkBook = new XSSFWorkbook();
                ISheet log = xlsWorkBook.CreateSheet("Excel-Tab-Name");

                /*======= Inicio Cabecera =============================================*/
                int indiceColumna = 0;
                IRow Header = log.CreateRow(0);
                foreach (DataColumn columna in dt.Columns)
                {
                    Header.CreateCell(indiceColumna).SetCellValue(columna.ColumnName);
                    indiceColumna++;
                }
                /*======= Fin Cabecera ================================================*/


                /*======= Inicio Contenido ============================================*/
                int indiceFila = 0;
                foreach (DataRow row in dt.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;
                    IRow r = log.CreateRow(indiceFila);
                    foreach (DataColumn columna in dt.Columns)
                    {
                        ICell Celda = r.CreateCell(indiceColumna);
                        Celda.SetCellValue(row[columna.ColumnName].ToString());
                        indiceColumna++;
                    }
                }
                /*======= Fin Contenido ================================================*/


                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/
               

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xlsx";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xlsx";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    xlsWorkBook.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 'EXPORTA DGV A EXCEL'

        public static void ExportarExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                XSSFWorkbook xlsWorkBook = new XSSFWorkbook();
                ISheet log = xlsWorkBook.CreateSheet("Excel-Tab-Name");

                /*======= Inicio Cabecera =============================================*/
                int indiceColumna = 0;
                IRow Header = log.CreateRow(0);
                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    if (columna.Visible)
                    {
                        Header.CreateCell(indiceColumna).SetCellValue(columna.HeaderText);
                        indiceColumna++;
                    }
                }
                /*======= Fin Cabecera ================================================*/


                /*======= Inicio Contenido ============================================*/
                int indiceFila = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;
                    IRow r = log.CreateRow(indiceFila);
                    foreach (DataGridViewColumn columna in dgv.Columns)
                    {
                        if (columna.Visible)
                        {
                            ICell Celda = r.CreateCell(indiceColumna);
                            Celda.SetCellValue(row.Cells[columna.Name].Value.ToString());
                            indiceColumna++;
                        }
                    }
                }
                /*======= Fin Contenido ================================================*/


                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xlsx";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xlsx";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    xlsWorkBook.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 'CARGA COMBO FECHAS CIERRE'

        public static void CargarComboFechasCierre(ComboBox cbo,int EstablecimientoId)
        {
            ProduccionCierreDigitacion objProduccionCierreDigitacion = new ProduccionCierreDigitacion();
            MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();

            objProduccionCierreDigitacion.EstablecimientoId = EstablecimientoId;

            DataTable dtFechaCierre = objMovimientoPacienteBL.ProduccionCierreDigitacion_FechasCierreV2(objProduccionCierreDigitacion);

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtFechaCierre.NewRow();
            row["FechaCierre"] = DBNull.Value;
            row["Periodo"] = "-Seleccione-";
            dtFechaCierre.Rows.InsertAt(row, 0);

            cbo.DataSource = dtFechaCierre;
            cbo.ValueMember = "FechaCierre";
            cbo.DisplayMember = "Periodo";
        }

        #endregion

        
        public static void ObtenerArchivoExcel(DataTable dt, string titulo, string nombreHoja, DataTable dtParam, Int32[] lstAnchosColumna)
        {
            HSSFWorkbook oLibro = new HSSFWorkbook();
            HSSFSheet oHoja = (HSSFSheet)oLibro.CreateSheet(nombreHoja);
            HSSFRow oFila = null;
            HSSFCellStyle estiloTitulo = (HSSFCellStyle)oLibro.CreateCellStyle();
            HSSFCellStyle estiloCabecera = (HSSFCellStyle)oLibro.CreateCellStyle();
            HSSFCellStyle estiloFila = (HSSFCellStyle)oLibro.CreateCellStyle();
            HSSFCellStyle estiloParamClave = (HSSFCellStyle)oLibro.CreateCellStyle();
            HSSFCellStyle estiloParamValue = (HSSFCellStyle)oLibro.CreateCellStyle();

            HSSFFont fontTitulo = (HSSFFont)oLibro.CreateFont();
            fontTitulo.Boldweight = (short)FontBoldWeight.Bold;
            fontTitulo.FontHeightInPoints = 16;
            fontTitulo.FontName = "Calibri";
            estiloTitulo.SetFont(fontTitulo);
            estiloTitulo.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

            HSSFFont fontCabecera = (HSSFFont)oLibro.CreateFont();
            fontCabecera.Boldweight = (short)FontBoldWeight.Bold;
            fontCabecera.FontName = "Calibri";
            fontCabecera.Underline = FontUnderlineType.Single;
            estiloCabecera.SetFont(fontCabecera);

            HSSFFont fontFila = (HSSFFont)oLibro.CreateFont();
            fontFila.FontName = "Calibri";
            estiloFila.SetFont(fontFila);

            HSSFFont fontParam = (HSSFFont)oLibro.CreateFont();
            fontParam.Boldweight = (short)FontBoldWeight.Bold;
            fontParam.FontName = "Calibri";
            estiloParamClave.SetFont(fontParam);

            HSSFFont fontParamValue = (HSSFFont)oLibro.CreateFont();
            fontParamValue.FontName = "Calibri";
            estiloParamValue.SetFont(fontParamValue);

            int numFila = 0;


            oFila = (HSSFRow)oHoja.CreateRow(numFila);

            //escribir el titulo
            oFila.CreateCell(0).SetCellValue(titulo);
            oFila.GetCell(0).CellStyle = estiloTitulo;
            oHoja.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, dt.Columns.Count - 1));

            numFila += 2;
            //escribiendo los parametros            
            for (int i = 0; i < dtParam.Rows.Count; i++)
            {
                oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                oFila.CreateCell(0).SetCellValue(dtParam.Rows[i][0].ToString());
                oFila.GetCell(0).CellStyle = estiloParamClave;
                oFila.CreateCell(1).SetCellValue(dtParam.Rows[i][1].ToString());
                oFila.GetCell(1).CellStyle = estiloParamValue;
                numFila++;
            }

            numFila += 1;
            //escribiendo las cabeceras
            oFila = (HSSFRow)oHoja.CreateRow(numFila);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                oFila.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                oFila.GetCell(i).CellStyle = estiloCabecera;
            }

            numFila += 1;

            //escribiendo los achos de las columnas

            if (lstAnchosColumna != null)
            {
                for (int i = 0; i < lstAnchosColumna.Length; i++)
                {
                    oHoja.SetColumnWidth(i, lstAnchosColumna[i] * 30);
                }
                // numFila += 1;
            }


            //escribiendo los datos
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Columns[j].DataType == Type.GetType("System.Int32"))
                        if (dt.Rows[i][j].ToString() == null || dt.Rows[i][j].ToString() == String.Empty)
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                        else
                            oFila.CreateCell(j).SetCellValue(Int32.Parse(dt.Rows[i][j].ToString()));

                    else if (dt.Columns[j].DataType == Type.GetType("System.Decimal"))
                        oFila.CreateCell(j).SetCellValue(Double.Parse(dt.Rows[i][j].ToString()));

                    else if (dt.Columns[j].DataType == Type.GetType("System.String"))
                        oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                    else if (dt.Columns[j].DataType == Type.GetType("System.DateTime"))
                        oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());



                    else if (dt.Columns[j].DataType == Type.GetType("System.Double"))
                        oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                    else if (dt.Columns[j].DataType == Type.GetType("System.Byte"))
                        oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                    else if (dt.Columns[j].DataType == Type.GetType("System.Boolean"))
                        oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                    else if (dt.Columns[j].DataType == Type.GetType("System.Char"))
                        oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                       

                    oFila.GetCell(j).CellStyle = estiloFila;
                }
            }

            /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter += "Tipo Archivo|*.xls";
            sfd.FilterIndex = 0;
            sfd.DefaultExt = "xls";
            sfd.RestoreDirectory = true;
            sfd.CreatePrompt = true;
            sfd.Title = "Exportando a Excel..";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                oLibro.Write(file);
                file.Close();
            }
            /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/
        }

        public static void ObtenerArchivoExcelV2(DataTable dt, string titulo, string nombreHoja, DataTable dtParam, Int32[] lstAnchosColumna)
        {
            HSSFWorkbook oLibro = new HSSFWorkbook();

            if (dt.Rows.Count >= 50000)
            {
                int Total = dt.Rows.Count;
                int Phoja = 50000;
                int SHoja = Phoja - Total;

                HSSFSheet oHoja = (HSSFSheet)oLibro.CreateSheet(nombreHoja);
                HSSFSheet oHoja2 = (HSSFSheet)oLibro.CreateSheet(nombreHoja + "2");

                HSSFRow oFila = null;
                HSSFRow oFila2 = null;

                HSSFCellStyle estiloTitulo = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloCabecera = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloFila = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloParamClave = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloParamValue = (HSSFCellStyle)oLibro.CreateCellStyle();

                HSSFFont fontTitulo = (HSSFFont)oLibro.CreateFont();
                fontTitulo.Boldweight = (short)FontBoldWeight.Bold;
                fontTitulo.FontHeightInPoints = 16;
                fontTitulo.FontName = "Calibri";
                estiloTitulo.SetFont(fontTitulo);
                estiloTitulo.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                HSSFFont fontCabecera = (HSSFFont)oLibro.CreateFont();
                fontCabecera.Boldweight = (short)FontBoldWeight.Bold;
                fontCabecera.FontName = "Calibri";
                fontCabecera.Underline = FontUnderlineType.Single;
                estiloCabecera.SetFont(fontCabecera);

                HSSFFont fontFila = (HSSFFont)oLibro.CreateFont();
                fontFila.FontName = "Calibri";
                estiloFila.SetFont(fontFila);

                HSSFFont fontParam = (HSSFFont)oLibro.CreateFont();
                fontParam.Boldweight = (short)FontBoldWeight.Bold;
                fontParam.FontName = "Calibri";
                estiloParamClave.SetFont(fontParam);

                HSSFFont fontParamValue = (HSSFFont)oLibro.CreateFont();
                fontParamValue.FontName = "Calibri";
                estiloParamValue.SetFont(fontParamValue);


                int numFila = 0;
                int numFila2 = 0;

                oFila = (HSSFRow)oHoja.CreateRow(numFila);
                oFila2 = (HSSFRow)oHoja2.CreateRow(numFila2);

                //escribir el titulo
                oFila.CreateCell(0).SetCellValue(titulo);
                oFila.GetCell(0).CellStyle = estiloTitulo;
                oHoja.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, dt.Columns.Count - 1));
                //escribir el titulo
                oFila2.CreateCell(0).SetCellValue(titulo);
                oFila2.GetCell(0).CellStyle = estiloTitulo;
                oHoja2.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, dt.Columns.Count - 1));



                numFila += 2;
                numFila2 += 2;
                //escribiendo los parametros            
                for (int i = 0; i < dtParam.Rows.Count; i++)
                {
                    oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                    oFila.CreateCell(0).SetCellValue(dtParam.Rows[i][0].ToString());
                    oFila.GetCell(0).CellStyle = estiloParamClave;
                    oFila.CreateCell(1).SetCellValue(dtParam.Rows[i][1].ToString());
                    oFila.GetCell(1).CellStyle = estiloParamValue;

                    oFila2 = (HSSFRow)oHoja2.CreateRow(numFila2 + i);
                    oFila2.CreateCell(0).SetCellValue(dtParam.Rows[i][0].ToString());
                    oFila2.GetCell(0).CellStyle = estiloParamClave;
                    oFila2.CreateCell(1).SetCellValue(dtParam.Rows[i][1].ToString());
                    oFila2.GetCell(1).CellStyle = estiloParamValue;

                    numFila++;
                    numFila2++;
                }

                numFila += 1;
                numFila2 += 1;

                //escribiendo las cabeceras
                oFila = (HSSFRow)oHoja.CreateRow(numFila);
                oFila2 = (HSSFRow)oHoja2.CreateRow(numFila2);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oFila.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                    oFila.GetCell(i).CellStyle = estiloCabecera;

                    oFila2.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                    oFila2.GetCell(i).CellStyle = estiloCabecera;

                }

                numFila += 1;
                numFila2 += 1;

                //escribiendo los achos de las columnas

                if (lstAnchosColumna != null)
                {
                    for (int i = 0; i < lstAnchosColumna.Length; i++)
                    {
                        oHoja.SetColumnWidth(i, lstAnchosColumna[i] * 30);
                        oHoja2.SetColumnWidth(i, lstAnchosColumna[i] * 30);
                    }
                    // numFila += 1;
                }


                //escribiendo los datos   -  primera hoja              
                for (int i = 0; i < 50000; i++)
                {
                    oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Columns[j].DataType == Type.GetType("System.Int32"))
                            if (dt.Rows[i][j].ToString() == null || dt.Rows[i][j].ToString() == String.Empty)
                                oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                            else
                                oFila.CreateCell(j).SetCellValue(Int32.Parse(dt.Rows[i][j].ToString()));

                        else if (dt.Columns[j].DataType == Type.GetType("System.Decimal"))
                            oFila.CreateCell(j).SetCellValue(Double.Parse(dt.Rows[i][j].ToString()));

                        else if (dt.Columns[j].DataType == Type.GetType("System.String"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.DateTime"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());



                        else if (dt.Columns[j].DataType == Type.GetType("System.Double"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Byte"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Boolean"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Char"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());


                        oFila.GetCell(j).CellStyle = estiloFila;
                    }
                }


                var results = (from m in dt.AsEnumerable() where m.Field<string>("Code") == "1-1-12" select m);

                DataTable dt2 = new DataTable();

                //escribiendo los datos   -  segunda hoja              
                for (int i = 50000; i <= 65000; i++)
                {
                    oFila2 = (HSSFRow)oHoja2.CreateRow(numFila2 + i);

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Columns[j].DataType == Type.GetType("System.Int32"))
                            if (dt.Rows[i][j].ToString() == null || dt.Rows[i][j].ToString() == String.Empty)
                                oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                            else
                                oFila2.CreateCell(j).SetCellValue(Int32.Parse(dt.Rows[i][j].ToString()));

                        else if (dt.Columns[j].DataType == Type.GetType("System.Decimal"))
                            oFila2.CreateCell(j).SetCellValue(Double.Parse(dt.Rows[i][j].ToString()));

                        else if (dt.Columns[j].DataType == Type.GetType("System.String"))
                            oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.DateTime"))
                            oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());



                        else if (dt.Columns[j].DataType == Type.GetType("System.Double"))
                            oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Byte"))
                            oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Boolean"))
                            oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Char"))
                            oFila2.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());


                        oFila2.GetCell(j).CellStyle = estiloFila;
                    }
                }




                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xls";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xls";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    oLibro.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/


            }
            else
            { 
                HSSFSheet oHoja = (HSSFSheet)oLibro.CreateSheet(nombreHoja);

                HSSFRow oFila = null;
                HSSFCellStyle estiloTitulo = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloCabecera = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloFila = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloParamClave = (HSSFCellStyle)oLibro.CreateCellStyle();
                HSSFCellStyle estiloParamValue = (HSSFCellStyle)oLibro.CreateCellStyle();

                HSSFFont fontTitulo = (HSSFFont)oLibro.CreateFont();
                fontTitulo.Boldweight = (short)FontBoldWeight.Bold;
                fontTitulo.FontHeightInPoints = 16;
                fontTitulo.FontName = "Calibri";
                estiloTitulo.SetFont(fontTitulo);
                estiloTitulo.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                HSSFFont fontCabecera = (HSSFFont)oLibro.CreateFont();
                fontCabecera.Boldweight = (short)FontBoldWeight.Bold;
                fontCabecera.FontName = "Calibri";
                fontCabecera.Underline = FontUnderlineType.Single;
                estiloCabecera.SetFont(fontCabecera);

                HSSFFont fontFila = (HSSFFont)oLibro.CreateFont();
                fontFila.FontName = "Calibri";
                estiloFila.SetFont(fontFila);

                HSSFFont fontParam = (HSSFFont)oLibro.CreateFont();
                fontParam.Boldweight = (short)FontBoldWeight.Bold;
                fontParam.FontName = "Calibri";
                estiloParamClave.SetFont(fontParam);

                HSSFFont fontParamValue = (HSSFFont)oLibro.CreateFont();
                fontParamValue.FontName = "Calibri";
                estiloParamValue.SetFont(fontParamValue);

                int numFila = 0;

                oFila = (HSSFRow)oHoja.CreateRow(numFila);

                //escribir el titulo
                oFila.CreateCell(0).SetCellValue(titulo);
                oFila.GetCell(0).CellStyle = estiloTitulo;
                oHoja.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, dt.Columns.Count - 1));

                numFila += 2;
                //escribiendo los parametros            
                for (int i = 0; i < dtParam.Rows.Count; i++)
                {
                    oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                    oFila.CreateCell(0).SetCellValue(dtParam.Rows[i][0].ToString());
                    oFila.GetCell(0).CellStyle = estiloParamClave;
                    oFila.CreateCell(1).SetCellValue(dtParam.Rows[i][1].ToString());
                    oFila.GetCell(1).CellStyle = estiloParamValue;
                    numFila++;
                }

                numFila += 1;
                //escribiendo las cabeceras
                oFila = (HSSFRow)oHoja.CreateRow(numFila);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oFila.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                    oFila.GetCell(i).CellStyle = estiloCabecera;
                }

                numFila += 1;

                //escribiendo los achos de las columnas

                if (lstAnchosColumna != null)
                {
                    for (int i = 0; i < lstAnchosColumna.Length; i++)
                    {
                        oHoja.SetColumnWidth(i, lstAnchosColumna[i] * 30);
                    }
                    // numFila += 1;
                }


                //escribiendo los datos
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Columns[j].DataType == Type.GetType("System.Int32"))
                            if (dt.Rows[i][j].ToString() == null || dt.Rows[i][j].ToString() == String.Empty)
                                oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                            else
                                oFila.CreateCell(j).SetCellValue(Int32.Parse(dt.Rows[i][j].ToString()));

                        else if (dt.Columns[j].DataType == Type.GetType("System.Decimal"))
                            oFila.CreateCell(j).SetCellValue(Double.Parse(dt.Rows[i][j].ToString()));

                        else if (dt.Columns[j].DataType == Type.GetType("System.String"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.DateTime"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());



                        else if (dt.Columns[j].DataType == Type.GetType("System.Double"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Byte"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Boolean"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                        else if (dt.Columns[j].DataType == Type.GetType("System.Char"))
                            oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());


                        oFila.GetCell(j).CellStyle = estiloFila;
                    }
                }

                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xls";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xls";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    oLibro.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/

            }
            
        }



        public static void CrearArchivoPlano(DataTable dtData, string separador, string directorio, string nombreArchivo)
        {

            directorio = "C:\\";
            nombreArchivo = "Prueba";
            separador = ",";

            if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
            using (StreamWriter sw = new StreamWriter(directorio + "\\" + nombreArchivo + ".txt", true, Encoding.UTF8))
            {
                string linea = "";
                foreach (DataRow fila in dtData.Rows)
                {
                    linea = "";
                    foreach (DataColumn columna in dtData.Columns)
                    {
                        linea += fila[columna] + "" + separador;
                    }
                    if (linea.Length > 0) linea = linea.Substring(0, linea.Length - 1);
                    sw.WriteLine(linea);
                }
            }

        }

        public static void ExportarCSV(DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public static void ExportarExcel3(DataTable dt)
        {
            //Create new Excel Workbook
            var workbook = new HSSFWorkbook();

            if (dt.Rows.Count > 0)
            {
                var sheet = workbook.CreateSheet();

                //(Optional) set the width of the columns
                sheet.SetColumnWidth(0, 20 * 50);//Id
                sheet.SetColumnWidth(1, 20 * 60);//Periodo
                sheet.SetColumnWidth(2, 20 * 150);//Correlativo
                sheet.SetColumnWidth(3, 20 * 180);//Fecha_Registro
                sheet.SetColumnWidth(4, 20 * 180);//Fecha_Atencion
                sheet.SetColumnWidth(5, 20 * 200);//Tipo_Prestacion
                sheet.SetColumnWidth(6, 20 * 180);//Fecha_Ingreso
                sheet.SetColumnWidth(7, 20 * 180);//Fecha_Alta
                sheet.SetColumnWidth(8, 20 * 200);//PacienteId
                sheet.SetColumnWidth(9, 20 * 200);//Dni_Paciente
                sheet.SetColumnWidth(10, 20 * 450);//Nombres_Paciente
                sheet.SetColumnWidth(11, 20 * 350);//Dni_Medico
                sheet.SetColumnWidth(12, 20 * 450);//Nombres_Medico
                sheet.SetColumnWidth(13, 20 * 450);//Especialidad
                sheet.SetColumnWidth(14, 20 * 350);//Ipress/Establecimiento


                //Create a header row
                var headerRow = sheet.CreateRow(0);
                headerRow.CreateCell(0).SetCellValue("Id");
                headerRow.CreateCell(1).SetCellValue("Periodo");
                headerRow.CreateCell(2).SetCellValue("Correlativo");
                headerRow.CreateCell(3).SetCellValue("Fecha_Registro");
                headerRow.CreateCell(4).SetCellValue("Fecha_Atencion");
                headerRow.CreateCell(5).SetCellValue("Tipo_Prestacion");
                headerRow.CreateCell(6).SetCellValue("Fecha_Ingreso");
                headerRow.CreateCell(7).SetCellValue("Fecha_Alta");
                headerRow.CreateCell(8).SetCellValue("PacienteId");
                headerRow.CreateCell(9).SetCellValue("Dni_Paciente");
                headerRow.CreateCell(10).SetCellValue("Nombres_Paciente");
                headerRow.CreateCell(11).SetCellValue("Dni_Medico");
                headerRow.CreateCell(12).SetCellValue("Nombres_Medico");
                headerRow.CreateCell(13).SetCellValue("Especialidad");
                headerRow.CreateCell(14).SetCellValue("Ipress/Establecimiento");



                //(Optional) freeze the header row so it is not scrolled
                sheet.CreateFreezePane(0, 1, 0, 1);


                int rowNumber = 1;
                ////Populate the sheet with values from the grid data

                foreach (DataRow dr in dt.Rows)
                {
                    //Create a new Row
                    var row = sheet.CreateRow(rowNumber++);

                    //Set the Values for Cells
                    row.CreateCell(0).SetCellValue(Convert.ToString(dr[0]));//
                    row.CreateCell(1).SetCellValue(Convert.ToString(dr[1]));//
                    row.CreateCell(2).SetCellValue(Convert.ToString(dr[2]));//
                    row.CreateCell(3).SetCellValue(Convert.ToString(dr[3]));//
                    row.CreateCell(4).SetCellValue(Convert.ToString(dr[4]));//
                    row.CreateCell(5).SetCellValue(Convert.ToString(dr[5]));//
                    row.CreateCell(6).SetCellValue(Convert.ToString(dr[6]));//                
                    row.CreateCell(7).SetCellValue(Convert.ToString(dr[7]));//
                    row.CreateCell(8).SetCellValue(Convert.ToString(dr[8]));//
                    row.CreateCell(9).SetCellValue(Convert.ToString(dr[9]));//
                    row.CreateCell(10).SetCellValue(Convert.ToString(dr[10]));//                
                    row.CreateCell(11).SetCellValue(Convert.ToString(dr[11]));//
                    row.CreateCell(12).SetCellValue(Convert.ToString(dr[12]));//
                    row.CreateCell(13).SetCellValue(Convert.ToString(dr[13]));//                
                    row.CreateCell(14).SetCellValue(Convert.ToString(dr[14]));//
                }

                // Guardar 

                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xls";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xls";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    workbook.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/


            }

        }


        public static void ExportarExcel4(DataTable dt)
        {
            //Create new Excel Workbook
            var workbook = new HSSFWorkbook();

            if (dt.Rows.Count > 0)
            {
                var sheet = workbook.CreateSheet();

                //(Optional) set the width of the columns
                sheet.SetColumnWidth(0, 20 * 50);//Id
                sheet.SetColumnWidth(1, 20 * 60);//Periodo
                sheet.SetColumnWidth(2, 20 * 150);//Correlativo
                sheet.SetColumnWidth(3, 20 * 350);//Ipress/Establecimiento
                sheet.SetColumnWidth(4, 20 * 180);//Fecha_Registro
                sheet.SetColumnWidth(5, 20 * 200);//Tipo_Ingreso
                sheet.SetColumnWidth(6, 20 * 180);//Fecha_Atencion
                sheet.SetColumnWidth(7, 20 * 200);//Lugar_Atencion
                sheet.SetColumnWidth(8, 20 * 200);//Historia
                sheet.SetColumnWidth(9, 20 * 200);//Tipo_Prestacion
                sheet.SetColumnWidth(10, 20 * 180);//FechaIngreso
                sheet.SetColumnWidth(11, 20 * 180);//FechaAlta
                sheet.SetColumnWidth(12, 20 * 200);//PacienteId
                sheet.SetColumnWidth(13, 20 * 200);//Dni_Paciente
                sheet.SetColumnWidth(14, 20 * 450);//Nombres_Paciente
                sheet.SetColumnWidth(15, 20 * 200);//Dni_Medico
                sheet.SetColumnWidth(16, 20 * 450);//Nombres_Medico
                sheet.SetColumnWidth(17, 20 * 450);//Especialidad
                sheet.SetColumnWidth(18, 20 * 350);//Observacion															



                //Create a header row
                var headerRow = sheet.CreateRow(0);
                headerRow.CreateCell(0).SetCellValue("Id");
                headerRow.CreateCell(1).SetCellValue("Periodo");
                headerRow.CreateCell(2).SetCellValue("Correlativo");
                headerRow.CreateCell(3).SetCellValue("Ipress/Establecimiento");
                headerRow.CreateCell(4).SetCellValue("Fecha_Registro");
                headerRow.CreateCell(5).SetCellValue("Tipo_Ingreso");
                headerRow.CreateCell(6).SetCellValue("Fecha_Atencion");
                headerRow.CreateCell(7).SetCellValue("Lugar_Atencion");
                headerRow.CreateCell(8).SetCellValue("Historia");
                headerRow.CreateCell(9).SetCellValue("Tipo_Prestacion");
                headerRow.CreateCell(10).SetCellValue("Fecha_Ingreso");
                headerRow.CreateCell(11).SetCellValue("Fecha_Alta");
                headerRow.CreateCell(12).SetCellValue("PacienteId");
                headerRow.CreateCell(13).SetCellValue("Dni_Paciente");
                headerRow.CreateCell(14).SetCellValue("Nombres_Paciente");
                headerRow.CreateCell(15).SetCellValue("Dni_Medico");
                headerRow.CreateCell(16).SetCellValue("Nombres_Medico");
                headerRow.CreateCell(17).SetCellValue("Especialidad");
                headerRow.CreateCell(18).SetCellValue("Observacion");


                //(Optional) freeze the header row so it is not scrolled
                sheet.CreateFreezePane(0, 1, 0, 1);


                int rowNumber = 1;
                ////Populate the sheet with values from the grid data

                foreach (DataRow dr in dt.Rows)
                {
                    //Create a new Row
                    var row = sheet.CreateRow(rowNumber++);

                    //Set the Values for Cells
                    row.CreateCell(0).SetCellValue(Convert.ToString(dr[0]));//
                    row.CreateCell(1).SetCellValue(Convert.ToString(dr[1]));//
                    row.CreateCell(2).SetCellValue(Convert.ToString(dr[2]));//
                    row.CreateCell(3).SetCellValue(Convert.ToString(dr[3]));//
                    row.CreateCell(4).SetCellValue(Convert.ToString(dr[4]));//
                    row.CreateCell(5).SetCellValue(Convert.ToString(dr[5]));//
                    row.CreateCell(6).SetCellValue(Convert.ToString(dr[6]));//                
                    row.CreateCell(7).SetCellValue(Convert.ToString(dr[7]));//
                    row.CreateCell(8).SetCellValue(Convert.ToString(dr[8]));//
                    row.CreateCell(9).SetCellValue(Convert.ToString(dr[9]));//
                    row.CreateCell(10).SetCellValue(Convert.ToString(dr[10]));//                
                    row.CreateCell(11).SetCellValue(Convert.ToString(dr[11]));//
                    row.CreateCell(12).SetCellValue(Convert.ToString(dr[12]));//
                    row.CreateCell(13).SetCellValue(Convert.ToString(dr[13]));//                
                    row.CreateCell(14).SetCellValue(Convert.ToString(dr[14]));//
                    row.CreateCell(15).SetCellValue(Convert.ToString(dr[15]));//
                    row.CreateCell(16).SetCellValue(Convert.ToString(dr[16]));//
                    row.CreateCell(17).SetCellValue(Convert.ToString(dr[17]));//                
                    row.CreateCell(18).SetCellValue(Convert.ToString(dr[18]));//
                }

                // Guardar 

                /*======= Inicio Cuadro de Dialogo - Guardar Excel =====================*/

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter += "Tipo Archivo|*.xls";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xls";
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                sfd.Title = "Exportando a Excel..";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                    workbook.Write(file);
                    file.Close();
                }
                /*======= Fin Cuadro de Dialogo - Guardar Excel =========================*/


            }

        }



    }
}
