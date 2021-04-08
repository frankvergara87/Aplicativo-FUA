using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data.SqlClient;
using System.Data;

namespace FissalDA
{
    public class ProcedimientoDA
    {
        SqlCommand cmd;

        public ProcedimientoDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA PROCEDIMIENTOS X DESCRIPCION O  PROCEDIMIENTO_ID
        public DataTable GetProcedimientosPorIdDescripcion(string procedimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProcedimientosPorIdDescripcion";
                cmd.Parameters.AddWithValue("@procedimiento", procedimiento);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //public DataTable Procedimiento_CostoProcedimiento(string SisId, int EstablecimientoId, int AutorizacionId, string FechaAtencion)
        //{
        //    cmd = new SqlCommand();
        //    cmd.CommandText = "sp2_ate_Procedimiento_CostoProcedimientoV2";
        //    cmd.Parameters.AddWithValue("Sisid", SisId);
        //    cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
        //    cmd.Parameters.AddWithValue("@autorizacionid", AutorizacionId);
        //    cmd.Parameters.AddWithValue("@fecha_atencion", FechaAtencion);
        //    return Datos.ObtenerDatosProcedure(cmd);
        //}

        public DataTable Procedimiento_CostoProcedimiento(int ProcedimientoId, int EstablecimientoId, int AutorizacionId, string FechaAtencion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Procedimiento_CostoProcedimiento";
            cmd.Parameters.AddWithValue("@ProcedimientoId", ProcedimientoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@autorizacionid", AutorizacionId);
            cmd.Parameters.AddWithValue("@fecha_atencion", FechaAtencion);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        //OBTIENE PROCEDIMIENTO - CODIGO | DESCRIPCION
        public DataTable Procedimiento_Verificar(int EstablecimientoId, string SisId, DateTime FechaAtencion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Procedimiento_Verificar";
            cmd.Parameters.AddWithValue("@establecimiento", EstablecimientoId);
            cmd.Parameters.AddWithValue("@SisId", SisId);
            cmd.Parameters.AddWithValue("@fechaAtencion", FechaAtencion);       
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Procedimiento_VerificarSisId(int EstablecimientoId, string SisId, DateTime FechaAtencion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Procedimiento_VerificarSisId";
            cmd.Parameters.AddWithValue("@establecimiento", EstablecimientoId);
            cmd.Parameters.AddWithValue("@fechaAtencion", FechaAtencion);
            cmd.Parameters.AddWithValue("@cadena", SisId); 
            return Datos.ObtenerDatosProcedure(cmd);
        }


        //OBTIENE LISTA DE PROCEDIMIENTOS ProcedimientoId | Descripcion
        public DataTable Procedimiento_Filtrar(int EstablecimientoId, DateTime FechaAtencion, string Descripcion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Procedimiento_Filtrar";
            cmd.Parameters.AddWithValue("@establecimiento", EstablecimientoId);
            cmd.Parameters.AddWithValue("@fechaAtencion", FechaAtencion);       
            cmd.Parameters.AddWithValue("@cadena", Descripcion);            
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
