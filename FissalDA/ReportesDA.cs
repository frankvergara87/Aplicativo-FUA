using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using FissalBE;

namespace FissalDA
{
    public partial class ReportesDA
    {
       
        public List<ReporteAtendidosRegion> ReporteAtendidosRegion(int anio)
        {
            List<ReporteAtendidosRegion> lstReporte = null;
            using (SqlConnection cn = AccesoBD.getConnnection()) {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("UspReporteAtendidosRegion",cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout =0;
                    cmd.Parameters.AddWithValue("@Anio", anio);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstReporte = new List<ReporteAtendidosRegion>();
                            ReporteAtendidosRegion obeReporte;
                            while (reader.Read())
                            {
                                obeReporte = new ReporteAtendidosRegion();
                                obeReporte.Anio = int.Parse(reader["T-Año"].ToString());
                                obeReporte.Region = reader["T-Region"].ToString();
                                obeReporte.TotalAtenciones = int.Parse(reader["T-Aten"].ToString());
                                obeReporte.TotalAtendidos = int.Parse(reader["T-Atend"].ToString());
                                obeReporte.TotalTransferencias = decimal.Parse(reader["T-Transf"].ToString());
                                obeReporte.DentroAtenciones = int.Parse(reader["D-Aten"].ToString());
                                obeReporte.DentroAtendidos = int.Parse(reader["D-Atend"].ToString());
                                obeReporte.DentroTransferencias = decimal.Parse(reader["D-Transf"].ToString());
                                obeReporte.FueraAtenciones = int.Parse(reader["F-Aten"].ToString());
                                obeReporte.FueraAtendidos = int.Parse(reader["F-Atend"].ToString());
                                obeReporte.FueraTransferencias = decimal.Parse(reader["F-Transf"].ToString());
                                lstReporte.Add(obeReporte);
                            }
                        }
                    }
                }
               
            }
            return lstReporte;
        }
        public List<Comun> ObetenerFechasAtendidosRegion()
        {
            List<Comun> lstComun = null;
            using (SqlConnection cn = AccesoBD.getConnnection())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("UspObetenerFechasAtendidosRegion", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;                 
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstComun = new List<Comun>();
                            Comun obeComun;
                            while (reader.Read())
                            {
                                obeComun = new Comun();
                                obeComun.Codigo = reader["Anio"];
                                obeComun.Descripcion = reader["Anio"];                               
                                lstComun.Add(obeComun);
                            }
                        }
                    }
                }

            }
            return lstComun;
        }

        public List<ReporteConciliacion> ReporteConciliacion(int numconc)
        {
            List<ReporteConciliacion> lstReporte = null;
            using (SqlConnection cn22 = AccesoBD.getConnnection())
            {
                cn22.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Reporte_Conciliacion", cn22))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@numconciliacion", numconc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstReporte = new List<ReporteConciliacion>();
                            ReporteConciliacion obeReporte;
                            while (reader.Read())
                            {
                                obeReporte = new ReporteConciliacion();
                                obeReporte.ipress = int.Parse(reader["EstablecimientoId"].ToString());
                                obeReporte.nombipress = reader["NombreIpress"].ToString();
                                obeReporte.desccadena = reader["Descripcion"].ToString();
                                obeReporte.abono = decimal.Parse(reader["abono"].ToString());
                                obeReporte.debito = decimal.Parse(reader["debito"].ToString());
                                obeReporte.sinicial = decimal.Parse(reader["Saldo"].ToString());
                                obeReporte.rpositiva = decimal.Parse(reader["ReasignacionPositiva"].ToString());
                                obeReporte.rnegativa = decimal.Parse(reader["ReasignacionNegativa"].ToString());
                                obeReporte.reasignacion = decimal.Parse(reader["pendiente"].ToString());
                                obeReporte.sfinal = decimal.Parse(reader["SaldoFinal"].ToString());
                                obeReporte.codigoconciliacion = int.Parse(reader["CodigoConciliacion"].ToString());
                                lstReporte.Add(obeReporte);
                            }
                        }
                    }
                }

            }
            return lstReporte;
        }


        public List<ReporteConciliacionChart> ReporteConciliacionChart(String numconc, String ipress, String cadena)
        {
            List<ReporteConciliacionChart> lstReporte = null;
            using (SqlConnection cn22 = AccesoBD.getConnnection())
            {
                cn22.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Reporte_ConciliacionChartFiltros", cn22))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@numconciliacion", numconc);
                    cmd.Parameters.AddWithValue("@ipress", ipress);
                    cmd.Parameters.AddWithValue("@cadena", cadena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstReporte = new List<ReporteConciliacionChart>();
                            ReporteConciliacionChart obeReporte;
                            while (reader.Read())
                            {
                                obeReporte = new ReporteConciliacionChart();
                                obeReporte.ipress = reader["EstablecimientoId"].ToString();
                                obeReporte.nombipress = reader["NombreIpress"].ToString();
                                obeReporte.abono = decimal.Parse(reader["abono"].ToString());
                                obeReporte.debito = decimal.Parse(reader["debito"].ToString());
                                obeReporte.sinicial = decimal.Parse(reader["Saldo"].ToString());
                                obeReporte.rpositiva = decimal.Parse(reader["ReasignacionPositiva"].ToString());
                                obeReporte.rnegativa = decimal.Parse(reader["ReasignacionNegativa"].ToString());
                                obeReporte.reasignacion = decimal.Parse(reader["pendiente"].ToString());
                                obeReporte.sfinal = decimal.Parse(reader["SaldoFinal"].ToString());
                                obeReporte.codigoconciliacion = int.Parse(reader["CodigoConciliacion"].ToString());
                                lstReporte.Add(obeReporte);
                            }
                        }
                    }
                }

            }
            return lstReporte;
        }

        public List<ChartaAbono> ObtenerReporChartabodeb()
        {
            List<ChartaAbono> lstReporte = null;
            using (SqlConnection cn22 = AccesoBD.getConnnection())
            {
                cn22.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Reporte_Conciliacion_chart", cn22))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstReporte = new List<ChartaAbono>();
                            ChartaAbono obeReporte;
                            while (reader.Read())
                            {
                                obeReporte = new ChartaAbono();
                                obeReporte.ipress = reader["EstablecimientoId"].ToString();
                                obeReporte.abono = decimal.Parse(reader["abono"].ToString());
                                obeReporte.debito = decimal.Parse(reader["debito"].ToString());
       
                                lstReporte.Add(obeReporte);
                            }
                        }
                    }
                }

            }
            return lstReporte;
        }

        public List<ReporteAtenciones> ObtenerReporAtenciones(String idipres,String numconc) 
        {
            List<ReporteAtenciones> lstReporte = null;
            using (SqlConnection cn22 = AccesoBD.getConnnection())
            {
                cn22.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Reporte_Atendidos", cn22))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@establecimientoId", idipres);
                    cmd.Parameters.AddWithValue("@codigoConciliacion", numconc);

                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstReporte = new List<ReporteAtenciones>();
                            ReporteAtenciones obeReporte;
                            while (reader.Read())
                            {
                                obeReporte = new ReporteAtenciones();
                                obeReporte.anio = reader["Anio"].ToString();
                                obeReporte.atenciones = decimal.Parse(reader["Atenciones"].ToString());
                                obeReporte.atendidos = decimal.Parse(reader["Atendidos"].ToString());

                                lstReporte.Add(obeReporte);
                            }
                        }
                    }
                }

            }
            return lstReporte;
        }


        public List<MantCombo> ObtenerCombos(int op)
        {
            List<MantCombo> lstReporte = null;
            using (SqlConnection cn22 = AccesoBD.getConnnection())
            {
                cn22.Open();
                using (SqlCommand cmd = new SqlCommand("UspObetenerCombos", cn22))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@op", op);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            lstReporte = new List<MantCombo>();
                            MantCombo obeReporte;
                            while (reader.Read())
                            {
                                obeReporte = new MantCombo();
                                obeReporte.codigo = reader["codigo"].ToString();
                                obeReporte.valor = reader["valor"].ToString();


                                lstReporte.Add(obeReporte);
                            }
                        }
                    }
                }

            }
            return lstReporte;
        }
    }
}
