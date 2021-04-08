using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace FissalDA
{
    public class TratamientoDA
    {

        public Tratamiento GetTratamientoPorIdVersion(int tratamientoId, DateTime fechaSolicitud)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetTratamientoPorIdVersion";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    Tratamiento objTratamiento = null;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@TratamientoId", tratamientoId);
                    cmd.Parameters.AddWithValue("@Fecha_Solicitud", fechaSolicitud);
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objTratamiento = CargarTratamiento(dr);
                        }
                    }
                    return objTratamiento;
                }
            }
        }

        public Tratamiento GetTratamientoPorIdVersion(int tratamientoId, int version)
        {
            using (SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetTratamientoPorIdVersion2";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    Tratamiento objTratamiento = null;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@TratamientoId", tratamientoId);
                    cmd.Parameters.AddWithValue("@Version", version);
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objTratamiento = CargarTratamiento(dr);
                        }
                    }
                    return objTratamiento;
                }
            }
        }

        public Tratamiento CargarTratamiento(IDataReader dr)
        {
            Tratamiento objTratamiento = new Tratamiento();
            if (dr["CadenaId"] != DBNull.Value)
                objTratamiento.CadenaId = Convert.ToInt32(dr["CadenaId"]);
            if (dr["Estado"] != DBNull.Value)
                objTratamiento.Estado = Convert.ToBoolean(dr["Estado"]);
            objTratamiento.EstadoEnvio = dr["EstadoEnvio"].ToString();
            objTratamiento.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
            if (dr["FechaEnvio"] != DBNull.Value)
                objTratamiento.FechaEnvio = Convert.ToDateTime(dr["FechaEnvio"]);
            if (dr["FechaFin"] != DBNull.Value)
                objTratamiento.FechaFin = Convert.ToDateTime(dr["FechaFin"]);
            if (dr["FechaInicio"] != DBNull.Value)
                objTratamiento.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
            if (dr["Monto"] != DBNull.Value)
                objTratamiento.Monto = Convert.ToDecimal(dr["Monto"]);
            if (dr["SoloRetrospectivo"] != DBNull.Value)
                objTratamiento.SoloRetrospectivo = Convert.ToBoolean(dr["SoloRetrospectivo"]);
            if (dr["TipoAutorizacionId"] != DBNull.Value)
                objTratamiento.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
            objTratamiento.TratamientoId = Convert.ToInt32(dr["TratamientoId"]);
            objTratamiento.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
            objTratamiento.Version = Convert.ToInt32(dr["Version"]);
            if (dr["Vigencia"] != DBNull.Value)
                objTratamiento.Vigencia = Convert.ToInt32(dr["Vigencia"]);
            return objTratamiento;
        }

    }
}
