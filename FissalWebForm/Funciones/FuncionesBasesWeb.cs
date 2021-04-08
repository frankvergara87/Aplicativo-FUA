using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalBL;
using System.IO;
using FissalWebForm.Solicitudes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using FissalWebForm.Funciones;

using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace FissalWebForm
{
    public class FuncionesBasesWeb
    {
        #region 'CARGA COMBO CATEGORIA'

        public static void CargarComboCategoria(DropDownList cbo, int EstablecimientoId)
        {
            string FechaActual = DateTime.Now.ToString("yyyy-MM-dd");

            CategoriaCIEBL ObjCategoriaBL = new CategoriaCIEBL();

            DataTable dtCategoria = ObjCategoriaBL.Categoria_ListaCombo(FechaActual, EstablecimientoId);

            ///*INSERTAR NUEVA FILA*/

            DataRow row = dtCategoria.NewRow();
            row["CategoriaId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtCategoria.Rows.InsertAt(row, 0);

            cbo.DataValueField = "CategoriaId";
            cbo.DataTextField = "Descripcion";

            cbo.DataSource = dtCategoria;
            cbo.DataBind();
        }

        #endregion

        #region 'CARGA COMBO ESTADIO'

        public static void CargarComboEstadio(DropDownList cbo, string CategoriaId, int EstablecimientoId)
        {
            string FechaActual = DateTime.Now.ToString("yyyy-MM-dd");

            EstadioBL ObjEstadioBL = new EstadioBL();

            DataTable dtEstadio = ObjEstadioBL.Estadio_ListaCombo(CategoriaId,FechaActual, EstablecimientoId);

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtEstadio.NewRow();
            row["EstadioId"] = DBNull.Value;
            row["Descripcion"] = "-Seleccione-";
            dtEstadio.Rows.InsertAt(row, 0);

            cbo.DataValueField = "EstadioId";
            cbo.DataTextField = "Descripcion";

            cbo.DataSource = dtEstadio;
            cbo.DataBind();
        }

        #endregion

        //#region 'CARGA COMBO FASE'

        //public static void CargarComboFase(DropDownList cbo, string CategoriaId, int Estadio)
        //{
        //    FaseBL ObjFaseBL = new FaseBL();

        //    DataTable dtFase = ObjFaseBL.Fase_ListaCombo(CategoriaId, Estadio);

        //    /*INSERTAR NUEVA FILA*/

        //    DataRow row = dtFase.NewRow();
        //    row["FaseId"] = DBNull.Value;
        //    row["Descripcion"] = "-Seleccione-";
        //    dtFase.Rows.InsertAt(row, 0);

        //    cbo.DataValueField = "FaseId";
        //    cbo.DataTextField = "Descripcion";

        //    cbo.DataSource = dtFase;
        //    cbo.DataBind();
        //}

        //#endregion

        #region 'CARGA LISTA FASE'

        public static void CargarListaFase(CheckBoxList Chk, string CategoriaId, int Estadio, int EstablecimientoId)
        {

            string FechaActual = DateTime.Now.ToString("yyyy-MM-dd");

            FaseBL ObjFaseBL = new FaseBL();

            DataTable dtFase = ObjFaseBL.Fase_ListaCombo(CategoriaId, Estadio, FechaActual, EstablecimientoId);

            Chk.DataValueField = "FaseId";
            Chk.DataTextField = "Descripcion";

            Chk.DataSource = dtFase;
            Chk.DataBind();
        }

        //public static void CargarListaFase(CheckBoxList Chk)
        //{

        //    string FechaActual = DateTime.Now.ToString("yyyy-MM-dd");

        //    FaseBL ObjFaseBL = new FaseBL();

        //    DataTable dtFase = ObjFaseBL.Fase_ListaCombo(CategoriaId, Estadio);
        //    //
        //    //UTF8Encoding encoding = new UTF8Encoding();
        //    //Encoding
        //    //string imprimir = "&lt;paldo&gt;";
        //    //byte[] bytes = encoding.GetBytes(imprimir);
        //    //imprimir = encoding.GetString(bytes);
        //    //DataTable dtFase = new DataTable();
        //    //dtFase.Columns.Add("FaseId", typeof(string));
        //    //dtFase.Columns.Add("Descripcion", typeof(string));
        //    //DataRow row = dtFase.NewRow();
        //    //row["FaseId"] = "0";
        //    //row["Descripcion"] = imprimir;
        //    //dtFase.Rows.InsertAt(row, 0);
        //    ///


        //    Chk.DataValueField = "FaseId";
        //    Chk.DataTextField = "&lt;Descripcion&gt;";

        //    Chk.DataSource = dtFase;
        //    Chk.DataBind();
        //}

        #endregion

        #region 'CARGA COMBO TIPO AUTORIZACION'

        public static void CargarComboTipoAutorizacion(DropDownList cbo)
        {
            TipoAutorizacionBL ObjTipoAutorizacionBL = new TipoAutorizacionBL();

            DataTable dtTipoAutorizacion = ObjTipoAutorizacionBL.TipoAutorizacion_Listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtTipoAutorizacion.NewRow();
            row["TipoAutorizacionId"] = 0;
            row["Descripcion"] = "-Seleccione-";
            dtTipoAutorizacion.Rows.InsertAt(row, 0);

            cbo.DataValueField = "TipoAutorizacionId";
            cbo.DataTextField  = "Descripcion";

            cbo.DataSource = dtTipoAutorizacion;
            cbo.DataBind();
        }

        #endregion

        #region 'CARGA COMBO TIPO TRATAMIENTO'

        public static void CargarComboTipoTratamiento(DropDownList cbo)
        {
            TipoTratamientoBL ObjTipoTratamientoBL = new TipoTratamientoBL();

            DataTable dtTipoTratamiento = ObjTipoTratamientoBL.TipoTratamiento_Listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtTipoTratamiento.NewRow();
            row["TipoTratamientoId"] = 0;
            row["Descripcion"] = "-Seleccione-";
            dtTipoTratamiento.Rows.InsertAt(row, 0);

            cbo.DataValueField = "TipoTratamientoId";
            cbo.DataTextField = "Descripcion";

            cbo.DataSource = dtTipoTratamiento;
            cbo.DataBind();
        }

        #endregion

        #region 'CARGA COMBO TIPO DOCUMENTO'

        public static void CargarComboTipoDocumento(DropDownList cbo)
        {
            TipoDocumentoBL ObjTipoDocumentoBL = new TipoDocumentoBL();

            DataTable dtTipoDocumento = ObjTipoDocumentoBL.Documento_listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtTipoDocumento.NewRow();
            row["TipoDocumentoId"] = 0;
            row["Descripcion"] = "-Seleccione-";
            dtTipoDocumento.Rows.InsertAt(row, 0);

            cbo.DataValueField = "TipoDocumentoId";
            cbo.DataTextField = "Descripcion";

            cbo.DataSource = dtTipoDocumento;
            cbo.DataBind();
        }

        #endregion

        #region 'CARGA COMBO TIPO REGIMEN'

        public static void CargarComboTipoRegimen(DropDownList cbo)
        {
            TipoRegimenBL ObjTipoRegimenBL = new TipoRegimenBL();

            DataTable dtTipoRegimen = ObjTipoRegimenBL.TipoRegimen_listar();

            /*INSERTAR NUEVA FILA*/

            DataRow row = dtTipoRegimen.NewRow();
            row["TipoRegimenId"] = 0;
            row["Descripcion"] = "-Seleccione-";
            dtTipoRegimen.Rows.InsertAt(row, 0);

            cbo.DataValueField = "TipoRegimenId";
            cbo.DataTextField = "Descripcion";

            cbo.DataSource = dtTipoRegimen;
            cbo.DataBind();
        }

        #endregion


        #region 'CARGA COMBO TIPO ESTABLECIMIENTO'

        public static void CargarComboEstablecimiento(DropDownList cbo)
        {
            EstablecimientoBL ObjEstablecimientoBL = new EstablecimientoBL();

            DataTable dtEstablecimiento = ObjEstablecimientoBL.Establecimiento_Consulta();

            /*INSERTAR NUEVA FILA*/

            //DataRow row = dtEstablecimiento.NewRow();
            //row["EstablecimientoId"] = 0;
            //row["Descripcion"] = "-Seleccione-";
            //dtEstablecimiento.Rows.InsertAt(row, 0);

            cbo.DataValueField = "EstablecimientoId";
            cbo.DataTextField = "Descripcion";

            cbo.DataSource = dtEstablecimiento;
            cbo.DataBind();
        }

        #endregion

        #region 'EXPORTA DGV A EXCEL MOSTRANDO'

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


                /*======= Inicio Creacion Archivo Excel =====================*/
                string filename = "DownloadMobileNoExcel.xls";
                HttpContext.Current.Response.ClearContent();
                HttpContext.Current.Response.AppendHeader("content-disposition", "attachment; filename=" + filename + "");
                HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";

                HttpContext.Current.Response.Write(xlsWorkBook.ToString());
                HttpContext.Current.Response.End();

                //}
                /*======= Fin Creacion Archivo Excel =========================*/
            }
            else
            {
                //MessageBox.Show("No hay datos para exportar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        public static void ExportarExcel2(DataTable dt)
        {
            string attachment = "attachment; filename=Reporte.xls";
            HttpContext.Current.Response.ClearContent();
            HttpContext.Current.Response.AddHeader("content-disposition", attachment);
            HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            HttpContext.Current.Response.Charset = "utf-8";
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.Unicode;

            HttpContext.Current.Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());

            string tab = "";
            foreach (DataColumn dc in dt.Columns)
            {
                HttpContext.Current.Response.Write(tab + dc.ColumnName);
                tab = "\t";
            }
            HttpContext.Current.Response.Write("\n");
            
            foreach (DataRow dr in dt.Rows)
            {
                tab = "";
                foreach (DataColumn columna in dt.Columns)
                {
                    string valorcelda = Convert.ToString(dr[columna.ColumnName]);
                    HttpContext.Current.Response.Write(valorcelda);
                    tab = "\t";
                }
                HttpContext.Current.Response.Write("\n");
            }

            HttpContext.Current.Response.End(); 
        }

        public static void ExportarExcel3(DataTable dt)
        {
            //Create new Excel Workbook
            var workbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = workbook.CreateSheet();


            //(Optional) set the width of the columns
            sheet.SetColumnWidth(0, 20 * 160);//Nro_Solicitud
            sheet.SetColumnWidth(1, 20 * 160);//Fecha_Solicitud
            sheet.SetColumnWidth(2, 20 * 190);//EstablecimientoId
            sheet.SetColumnWidth(3, 20 * 350);//CategoriaId
            sheet.SetColumnWidth(4, 20 * 150);//EstadioId
            sheet.SetColumnWidth(5, 20 * 300);//FaseId
            sheet.SetColumnWidth(6, 20 * 150);//PacienteId
            sheet.SetColumnWidth(7, 20 * 256);//ApellidoPaterno
            sheet.SetColumnWidth(8, 20 * 256);//ApellidoMaterno
            sheet.SetColumnWidth(9, 20 * 256);//Nombres
            sheet.SetColumnWidth(10, 20 * 210);//NumeroDocumento
            sheet.SetColumnWidth(11, 20 * 80);//SexoId


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("Nro.Solicitud");
            headerRow.CreateCell(1).SetCellValue("Fech.Solicitud");
            headerRow.CreateCell(2).SetCellValue("Establecimiento");
            headerRow.CreateCell(3).SetCellValue("Categoria");
            headerRow.CreateCell(4).SetCellValue("Estadio");
            headerRow.CreateCell(5).SetCellValue("Fase");
            headerRow.CreateCell(6).SetCellValue("Cod.Paciente");
            headerRow.CreateCell(7).SetCellValue("ApellidoPaterno");
            headerRow.CreateCell(8).SetCellValue("ApellidoMaterno");
            headerRow.CreateCell(9).SetCellValue("Nombres");
            headerRow.CreateCell(10).SetCellValue("N°.Documento");
            headerRow.CreateCell(11).SetCellValue("Sexo");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);

            int rowNumber = 1;

            //Populate the sheet with values from the grid data

            foreach (DataRow dr in dt.Rows)
            {
                //Create a new Row
                var row = sheet.CreateRow(rowNumber++);

                //Set the Values for Cells
                row.CreateCell(0).SetCellValue(Convert.ToInt32(dr[0]));//Nro_Solicitud
                row.CreateCell(1).SetCellValue(Convert.ToString(dr[1]));//Fecha_Solicitud
                row.CreateCell(2).SetCellValue(Convert.ToInt32(dr[2]));//EstablecimientoId
                row.CreateCell(3).SetCellValue(Convert.ToString(dr[3]));//CategoriaId
                row.CreateCell(4).SetCellValue(Convert.ToString(dr[4]));//EstadioId
                row.CreateCell(5).SetCellValue(Convert.ToString(dr[5]));//FaseId
                row.CreateCell(6).SetCellValue(Convert.ToString(dr[6]));//PacienteId                
                row.CreateCell(7).SetCellValue(Convert.ToString(dr[8]));//ApellidoPaterno
                row.CreateCell(8).SetCellValue(Convert.ToString(dr[9]));//ApellidoMaterno
                row.CreateCell(9).SetCellValue(Convert.ToString(dr[7]));//Nombres
                row.CreateCell(10).SetCellValue(Convert.ToString(dr[10]));//NumeroDocumento
                row.CreateCell(11).SetCellValue(Convert.ToString(dr[11]));//SexoId
            }

            // Guardar 
            using (var output = new MemoryStream())
            {
                workbook.Write(output);

                string saveAsFileName = string.Format("ReporteSolicitudes.xls");

                HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
                HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", saveAsFileName));
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.BinaryWrite(output.GetBuffer());
                HttpContext.Current.Response.End();
            }

        }
    



    }
}