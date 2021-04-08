using FisalUtil;
using FissalBE;
using FissalBL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FissalReportes.Controllers
{
    public class ReportesController : Controller
    {
        //
        // GET: /Reportes/
        private ReportesBL oblReporte = null;


        public ReportesController() { oblReporte = new ReportesBL(); }
        public ActionResult AtendidosPorRegion()
        {
            List<Comun> lstAnios = oblReporte.ObetenerFechasAtendidosRegion();
            if (lstAnios != null) lstAnios.Insert(0, new Comun { Codigo = 0, Descripcion = "Todos" });
            ViewBag.Anios = lstAnios;
            return View();
        }

        public ActionResult Conciliacion()
        {
            List<Comun> lstAnios = oblReporte.ObetenerFechasAtendidosRegion();
            if (lstAnios != null) lstAnios.Insert(0, new Comun { Codigo = 0, Descripcion = "Todos" });
            ViewBag.Anios = lstAnios;
            return View();
        }


        public JsonResult ObtenerReporte(int anio)
        {
            var reporte = oblReporte.ReporteAtendidosRegion(anio);
            return Json(reporte, JsonRequestBehavior.AllowGet);
        }


        public FileResult Exportar()
        {
            int intAnio = int.Parse(Request["ddlAnio"]);
            List<ReporteAtendidosRegion> lstReportes = oblReporte.ReporteAtendidosRegion(intAnio);

            //Paramentros
            DataTable dtParam = new DataTable();
            dtParam.Columns.Add("Clave");
            dtParam.Columns.Add("Valor");
            dtParam.Rows.Add(new object[] { "Año:", intAnio == 0 ? "Todos" : intAnio.ToString() });

            //Datos
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("Año", Type.GetType("System.Int32"));
            dt.Columns.Add("Region", Type.GetType("System.String"));
            dt.Columns.Add("Total Atencion", Type.GetType("System.Int32"));
            dt.Columns.Add("Total Atendidos", Type.GetType("System.Int32"));
            dt.Columns.Add("Total Transferencia", Type.GetType("System.Decimal"));
            dt.Columns.Add("Dentro Atencion", Type.GetType("System.Int32"));
            dt.Columns.Add("Dentro Atendidos", Type.GetType("System.Int32"));
            dt.Columns.Add("Dentro Transferencia", Type.GetType("System.Decimal"));
            dt.Columns.Add("Fuera Atencion", Type.GetType("System.Int32"));
            dt.Columns.Add("Fuera Atendidos", Type.GetType("System.Int32"));
            dt.Columns.Add("Fuera Transferencia", Type.GetType("System.Decimal"));

            foreach (ReporteAtendidosRegion beReporte in lstReportes)
            {
                dr = dt.NewRow();
                dr["Año"] = beReporte.Anio;
                dr["Region"] = beReporte.Region;
                dr["Total Atencion"] = beReporte.TotalAtenciones;
                dr["Total Atendidos"] = beReporte.TotalAtendidos;
                dr["Total Transferencia"] = beReporte.TotalTransferencias;
                dr["Dentro Atencion"] = beReporte.DentroAtenciones;
                dr["Dentro Atendidos"] = beReporte.DentroAtendidos;
                dr["Dentro Transferencia"] = beReporte.DentroTransferencias;
                dr["Fuera Atencion"] = beReporte.FueraAtenciones;
                dr["Fuera Atendidos"] = beReporte.FueraAtendidos;
                dr["Fuera Transferencia"] = beReporte.FueraTransferencias;
                dt.Rows.Add(dr);
            }

            //Anchos Columnas           
            Int32[] anchosColumnas = new Int32[] { 60, 90, 70, 120, 150, 120, 120, 190, 190, 120, 150 };

            MemoryStream ms = Util.ObetenerArchivoExcel(dt, "Reporte Atendidos por Region", "REPORTE", dtParam, anchosColumnas);
            return File(ms.GetBuffer(), "application/vdn.ms-excel", "reporte.xls");
        }


        public FileResult ExportarConcilacion()
        {
            int intAnio = 1;
            List<ReporteConciliacion> lstReportes = oblReporte.ReporteConciliacion(intAnio);

            //Paramentros
            DataTable dtParam = new DataTable();
            dtParam.Columns.Add("Clave");
            dtParam.Columns.Add("Valor");
            //dtParam.Rows.Add(new object[] { "Año:", intAnio == 0 ? "Todos" : intAnio.ToString() });

            //Datos
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("IPRESS", Type.GetType("System.String"));
            dt.Columns.Add("NOMBRE IPRESS", Type.GetType("System.String"));
            dt.Columns.Add("DESCRIPCION", Type.GetType("System.String"));
            dt.Columns.Add("ABONO", Type.GetType("System.Decimal"));
            dt.Columns.Add("DEBITO", Type.GetType("System.Decimal"));
            dt.Columns.Add("SALDO INICIAL", Type.GetType("System.Decimal"));
            dt.Columns.Add("REASIGNACION POSITIVA", Type.GetType("System.Int32"));
            dt.Columns.Add("REASIGNACION NEGATIVA", Type.GetType("System.Decimal"));
            dt.Columns.Add("PENDIENTE", Type.GetType("System.Decimal"));
            dt.Columns.Add("SALDO FINAL", Type.GetType("System.Decimal"));

            int a = 0;
            int cb = 0;
            decimal _abono = 0;
            decimal _debito = 0;
            decimal _sinicial = 0;
            decimal _rpositiva = 0;
            decimal _rnegativa = 0;
            decimal _reasignacion = 0;
            decimal _sfinal = 0;

            decimal _abonoT = 0;
            decimal _debitoT = 0;
            decimal _sinicialT = 0;
            decimal _rpositivaT = 0;
            decimal _rnegativaT = 0;
            decimal _reasignacionT = 0;
            decimal _sfinalT = 0;


            foreach (ReporteConciliacion beReporte in lstReportes)
            {


                if (beReporte.ipress == cb || cb == 0)
                {
                    dr = dt.NewRow();

                    _abono = _abono + beReporte.abono;
                    _debito = _debito + beReporte.debito;
                    _sinicial = _sinicial + beReporte.sinicial;
                    _rpositiva = _rpositiva + beReporte.rpositiva;
                    _rnegativa = _rnegativa + beReporte.rnegativa;
                    _reasignacion = _reasignacion + beReporte.reasignacion;
                    _sfinal = _sfinal + beReporte.sfinal;


                    dr["IPRESS"] = beReporte.ipress;
                    dr["NOMBRE IPRESS"] = beReporte.nombipress;
                    dr["DESCRIPCION"] = beReporte.desccadena;
                    dr["ABONO"] = beReporte.abono;
                    dr["DEBITO"] = beReporte.debito;
                    dr["SALDO INICIAL"] = beReporte.sinicial;
                    dr["REASIGNACION POSITIVA"] = beReporte.rpositiva;
                    dr["REASIGNACION NEGATIVA"] = beReporte.rnegativa;
                    dr["PENDIENTE"] = beReporte.reasignacion;
                    dr["SALDO FINAL"] = beReporte.sfinal;

                    dt.Rows.Add(dr);

                    a++;
                }
                else
                {


                    dr = dt.NewRow();

                    dr["IPRESS"] = "SubTotal";

                    dr["ABONO"] = _abono;
                    dr["DEBITO"] = _debito;
                    dr["SALDO INICIAL"] = _sinicial;
                    dr["REASIGNACION POSITIVA"] = _rpositiva;
                    dr["REASIGNACION NEGATIVA"] = _rnegativa;
                    dr["PENDIENTE"] = _reasignacion;
                    dr["SALDO FINAL"] = _sfinal;
                    dt.Rows.Add(dr);


                    _abonoT = _abonoT + _abono;
                    _debitoT = _debitoT + _debito;
                    _sinicialT = _sinicialT + _sinicial;
                    _rpositivaT = _rpositivaT + _rpositiva;
                    _rnegativaT = _rnegativaT + _rnegativa;
                    _reasignacionT = _reasignacionT + _reasignacion;
                    _sfinalT = _sfinalT + _sfinal;


                    dr = dt.NewRow();
                    dr["IPRESS"] = beReporte.ipress;
                    dr["NOMBRE IPRESS"] = beReporte.nombipress;
                    dr["DESCRIPCION"] = beReporte.desccadena;
                    dr["ABONO"] = beReporte.abono;
                    dr["DEBITO"] = beReporte.debito;
                    dr["SALDO INICIAL"] = beReporte.sinicial;
                    dr["REASIGNACION POSITIVA"] = beReporte.rpositiva;
                    dr["REASIGNACION NEGATIVA"] = beReporte.rnegativa;
                    dr["PENDIENTE"] = beReporte.reasignacion;
                    dr["SALDO FINAL"] = beReporte.sfinal;



                }
            }
        }

    }
}