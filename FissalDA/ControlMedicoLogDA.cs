using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;


using System.Data.Common;

using System.Globalization;

namespace FissalDA
{
    public class ControlMedicoLogDA
    {
        SqlCommand cmd;

        public ControlMedicoLogDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA CONTROL MEDICO POR FUA
        public DataTable GetVwControlMedicoLogPorFua(Int64 fua)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetVwControlMedicoLogPorFua";
                cmd.Parameters.AddWithValue("@Fua", fua);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //INSERTAR CONTROL MEDICO
        public int GuardarControlMedicoLog(ControlMedicoLog ObjControlMedicoLog)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GuardarControlMedicoLog";
                cmd.Parameters.AddWithValue("@Fua", ObjControlMedicoLog.Fua);
                cmd.Parameters.AddWithValue("@TipoControlMedicoId", ObjControlMedicoLog.TipoControlMedicoId);
                cmd.Parameters.AddWithValue("@id_usuario", ObjControlMedicoLog.id_usuario);
                cmd.Parameters.AddWithValue("@TipoObservacionId", ObjControlMedicoLog.TipoObservacionId);
                return Datos.Mantenimiento(cmd);
            }
        }

        public DateTime GetDatePrimerControlFua(long fua)
        {
            DateTime fechaPrimerControl;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_GetDatePrimerControlFua";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fua", fua);
                    fechaPrimerControl = Convert.ToDateTime(cmd.ExecuteScalar());
                }
            }
            return fechaPrimerControl;
        }

        public bool SePuedeEditarControlMedico(long fua)
        {
            int result;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_SePuedeEditarControlMedico";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fua", fua);
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return result > 0;
        }


        /** FUNCIONES CONTROL MEDICO [DUAS OBSERVADOS] 24-03-2015 *********/

        public DataTable Filtrar_ControlMedico()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_CMedico_Filtrar_ControlMedico";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable Filtrar_Establecimiento()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_CMedico_Filtrar_Establecimiento";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable Listado_Fuas(int ControlMedico, int EstablecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_CMedico_ListadoFuas";
                cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoControlMedico", ControlMedico);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

      public int Contador_Fuas(int Valor, int EstablecimientoId, int CodigoCMedico)
      {
            int result;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_CMedico_ContadorFuas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoConsulta", Valor);
                    cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                    cmd.Parameters.AddWithValue("@CodigoControlMedico", CodigoCMedico);
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return result;
      }


      public DataTable Exportar_ListadoFuas(int EstablecimientoId, int CodigoCMedico)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_CMedico_ReporteFuas";
                cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoCMedico", CodigoCMedico);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

      public DataTable Exportar_ListadoTotalFuas(int EstablecimientoId, int CodigoCMedico)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_CMedico_ReporteTotalFuas";
                cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoCMedico", CodigoCMedico);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        /******************************************/


    }

}
