using Ionic.Zip;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FisalUtil
{
    public class Util
    {
        public static MemoryStream ObetenerArchivoExcel(DataTable dt,string titulo,string nombreHoja,DataTable dtParam,Int32[] lstAnchosColumna) 
        {
            MemoryStream ms = new MemoryStream();
            HSSFWorkbook oLibro = new HSSFWorkbook();
            HSSFSheet oHoja = (HSSFSheet)oLibro.CreateSheet(nombreHoja);
            HSSFRow oFila=null;
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
            estiloTitulo.Alignment = HorizontalAlignment.Center;

            HSSFFont fontCabecera = (HSSFFont)oLibro.CreateFont();
            fontCabecera.Boldweight = (short)FontBoldWeight.Bold;          
            fontCabecera.FontName = "Calibri";
            //fontCabecera.Underline = FontUnderlineType.Single;            
            estiloCabecera.SetFont(fontCabecera);

             

            //estiloCabecera.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Blue.COLOR_NORMAL;

            estiloCabecera.BorderTop = BorderStyle.Thin;

            estiloCabecera.BorderLeft = BorderStyle.Thin;

            estiloCabecera.BorderBottom = BorderStyle.Thick;

            /*estiloCabecera.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Blue.Index;

            estiloCabecera.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Coral.Index;

            estiloCabecera.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Blue.Index;*/
            
            //estiloCabecera.FillPattern = HSSFCellStyle;
          //  ColorCabecera.FillPattern = HSSFCellStyle.Equals('') ;
      


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


            oFila =(HSSFRow)oHoja.CreateRow(numFila);

            //escribir el titulo
            oFila.CreateCell(0).SetCellValue(titulo);
            oFila.GetCell(0).CellStyle = estiloTitulo;
            oHoja.AddMergedRegion(new CellRangeAddress(0, 0, 0,dt.Columns.Count-1));

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
                    oHoja.SetColumnWidth(i, lstAnchosColumna[i]*30);
                }
               // numFila += 1;
            }
                      
           /* HSSFCellStyle estiloFormato = (HSSFCellStyle)oLibro.CreateCellStyle();
            
            estiloFormato.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Blue.Index;
            estiloFormato.FillPattern =  HSSFConditionalFormatting.Equals  ;*/
            //estiloFormato.FillPattern = HSSFCellStyle.ReferenceEquals("SOLID_FOREGROUND");

            //escribiendo los datos
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                oFila = (HSSFRow)oHoja.CreateRow(numFila + i);
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (dt.Columns[j].DataType == Type.GetType("System.Int32")) oFila.CreateCell(j).SetCellValue(Int32.Parse(dt.Rows[i][j].ToString()));
                    else if (dt.Columns[j].DataType == Type.GetType("System.Decimal")) oFila.CreateCell(j).SetCellValue(Double.Parse(dt.Rows[i][j].ToString()));
                    else if (dt.Columns[j].DataType == Type.GetType("System.String")) oFila.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());

                    

                    if (dt.Rows[i][0].ToString().Equals("SubTotal") || dt.Rows[i][0].ToString().Equals("Total"))
                    {
                         oFila.GetCell(j).CellStyle = estiloCabecera;
                         
                        //oFila.GetCell(j).CellStyle = estiloFormato;
                    }
                    else {
                        
                        oFila.GetCell(j).CellStyle = estiloFila;
                    
                    }
                    
                }
            }
            
            oLibro.Write(ms);
            return ms;
        }

        public static void CrearArchivoPlano(DataTable dtData,string separador,string directorio,string nombreArchivo) 
        {
            if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
            using (StreamWriter sw = new StreamWriter(directorio + "\\" + nombreArchivo + ".txt", true, Encoding.UTF8))
            {
                string linea="";
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
        public static void CrearArchivoZip(string archivoOrigen,string archivoDestino,bool borrarArchivoOrigen=true) 
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.AddFile(archivoOrigen,"");
                zip.Save(archivoDestino);
            }
            if(borrarArchivoOrigen)File.Delete(archivoOrigen);
        }

        public static string ConvertirBase64(string archivoOrigen) 
        {
            byte[] bteArchcivo =File.ReadAllBytes(archivoOrigen);
            string archivo = Convert.ToBase64String(bteArchcivo);
            return archivo;
        }

        public static void GuardarArchivo(string directorioDestino,string archivoDestino,byte[] archivo) 
        {
            string rutaArchivo = Path.Combine(directorioDestino, archivoDestino);
            if (!Directory.Exists(directorioDestino)) Directory.CreateDirectory(directorioDestino);
            if (File.Exists(rutaArchivo)) File.Delete(rutaArchivo);
            File.WriteAllBytes(rutaArchivo, archivo);
        }
       
    }
}
