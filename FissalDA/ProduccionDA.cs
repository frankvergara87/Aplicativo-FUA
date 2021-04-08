using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class ProduccionDA
    {
        static SqlCommand cmd;

        public ProduccionDA()
        {
            cmd = new SqlCommand();
        }

        //GESTION DE CUENTA
        //GENERAR NUEVO NUMERO DE FUA
        public DataTable Produccion_Nuevo()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_Nuevo";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //LISTA DE PERIODOS DE PRODUCCION (AÑO)
        public DataTable MovimientoPaciente_ListarPeriodoAnio()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_MovimientoPaciente_ListarPeriodoAnio";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //LISTA DE PERIODOS DE PRODUCCION (MES)
        public DataTable MovimientoPaciente_ListarPeriodoMes(int Anio)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_MovimientoPaciente_ListarPeriodoMes";
            cmd.Parameters.AddWithValue("@Anio", Anio);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //LISTA DE CIERRE DE PRODUCCION
        public DataTable Produccion_Listar(string Codigo, bool Cerrada, string FechaInicio, string FechaFin, int Nro)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_Listar";
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Cerrada", Cerrada);
            cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", FechaFin);        
            cmd.Parameters.AddWithValue("@Nro", Nro);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //INSERTAR PRODUCCION (INICIO)
        public int Produccion_Insert(Produccion objProduccion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_Insert";
            cmd.Parameters.AddWithValue("@ProduccionId", objProduccion.ProduccionId);
            cmd.Parameters.AddWithValue("@Codigo", objProduccion.Codigo);
            cmd.Parameters.AddWithValue("@FechaProduccion", objProduccion.FechaProduccion);
            cmd.Parameters.AddWithValue("@FechaInicio", objProduccion.FechaInicio);            
            return Datos.Mantenimiento(cmd);
        }        

        //GESTION DE CUENTA
        //ACTUALIZAR PRODUCCION EN MOVIMIENTO PACIENTE
        public int MovimientoPaciente_UpdateProduccionId(int ProduccionId, string Periodo, string Mes)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_MovimientoPaciente_UpdateProduccionId";
            cmd.Parameters.AddWithValue("@ProduccionId", ProduccionId);
            cmd.Parameters.AddWithValue("@Periodo", Periodo);
            cmd.Parameters.AddWithValue("@Mes", Mes);            
            return Datos.Mantenimiento(cmd);
        }

        //GESTION DE CUENTA
        //VERIFICAR PERIODO EXISTENTE
        public DataTable Produccion_Verificar(string Periodo, string Mes)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_Verificar";
            cmd.Parameters.AddWithValue("@Periodo", Periodo);
            cmd.Parameters.AddWithValue("@Mes", Mes);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //VERIFICAR FUAS EXISTENTES X IPRESS PARA INICIAR PROCESO
        public DataTable MovimientoPaciente_VerificarIpress(string Periodo, string Mes)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_MovimientoPaciente_VerificarIpress";
            cmd.Parameters.AddWithValue("@Periodo", Periodo);
            cmd.Parameters.AddWithValue("@Mes", Mes);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //LISTA DE DETALLE X PRODUCCION
        public DataTable ProduccionEstablecimiento_Listar(Produccion objProduccion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_Listar";
            cmd.Parameters.AddWithValue("@ProduccionId", objProduccion.ProduccionId);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //ACTUALIZAR FECHA CIERRE | ESTADO DE PRODUCCION
        public int Produccion_UpdateFechaCierre(Produccion objProduccion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_UpdateFechaCierre";
            cmd.Parameters.AddWithValue("@ProduccionId", objProduccion.ProduccionId);            
            return Datos.Mantenimiento(cmd);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //LISTA DE PERIODOS DE PRODUCCION
        public DataTable Produccion_ListarPeriodo()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_ListarPeriodo";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //LISTA DE PERIODOS DE PRODUCCION
        public DataTable Produccion_ListarPeriodoConciliacion()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Produccion_ListarPeriodoConciliacion";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //ACTUALIZAR FECHA CIERRE | ESTADO DE PRODUCCION 
        public int ProduccionConciliacion_Cierre(Produccion objProduccion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_ProduccionConciliacion_Cierre";
            cmd.Parameters.AddWithValue("@ProduccionId", objProduccion.ProduccionId);
            return Datos.Mantenimiento(cmd);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //VERIFICAR PERIODOS DE PRODUCCION CONCILIADAS
        public bool FaltaConciliarProducciones(int produccionId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_cta_FaltaConciliarProducciones";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@ProduccionId", produccionId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }
    }
}
