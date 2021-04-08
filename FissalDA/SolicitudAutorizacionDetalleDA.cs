using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data.Common;
using System.Data;

namespace FissalDA
{
    public class SolicitudAutorizacionDetalleDA
    {
        SqlCommand cmd;

        public SolicitudAutorizacionDetalleDA()
        {
            cmd = new SqlCommand();
        }

        public List<vw2_SolicitudAutorizacionDetalle> GetDetallesSolicitudPorNumeroSolicitud(string numeroSolicitud)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetDetallesSolicitudPorNumeroSolicitud";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", numeroSolicitud);
                List<vw2_SolicitudAutorizacionDetalle> listaSolicitudAutorizacionDetalle = new List<vw2_SolicitudAutorizacionDetalle>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaSolicitudAutorizacionDetalle.Add(CargarDetalleSolicitud(dr));
                    }
                }
                return listaSolicitudAutorizacionDetalle;
            }
        }

        public vw2_SolicitudAutorizacionDetalle CargarDetalleSolicitud(IDataReader dr)
        {
            vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle = new vw2_SolicitudAutorizacionDetalle();
            if (dr["Adicional"] != DBNull.Value)
                objSolicitudAutorizacionDetalle.Adicional = Convert.ToBoolean(dr["Adicional"]);
            if (dr["Aprobado"] != DBNull.Value)
                objSolicitudAutorizacionDetalle.Aprobado = Convert.ToBoolean(dr["Aprobado"]);
            if (dr["AutorizacionId"] != DBNull.Value)
                objSolicitudAutorizacionDetalle.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"]);
            objSolicitudAutorizacionDetalle.CategoriaId = dr["CategoriaId"].ToString();
            objSolicitudAutorizacionDetalle.DetalleId = Convert.ToInt32(dr["DetalleId"]);
            objSolicitudAutorizacionDetalle.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
            objSolicitudAutorizacionDetalle.EstadioId = Convert.ToByte(dr["EstadioId"]);
            objSolicitudAutorizacionDetalle.FaseId = Convert.ToInt32(dr["FaseId"]);
            if (dr["Fecha_Procesado"] != DBNull.Value)
                objSolicitudAutorizacionDetalle.Fecha_Procesado = Convert.ToDateTime(dr["Fecha_Procesado"]);
            objSolicitudAutorizacionDetalle.Modalidad = dr["Modalidad"].ToString();
            objSolicitudAutorizacionDetalle.Nro_Solicitud = dr["Nro_Solicitud"].ToString();
            objSolicitudAutorizacionDetalle.Observaciones = dr["Observaciones"].ToString();
            if (dr["Procesado"] != DBNull.Value)
                objSolicitudAutorizacionDetalle.Procesado = Convert.ToBoolean(dr["Procesado"]);
            objSolicitudAutorizacionDetalle.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
            objSolicitudAutorizacionDetalle.TratamientoId = Convert.ToInt32(dr["TratamientoId"]);
            objSolicitudAutorizacionDetalle.Version = Convert.ToInt16(dr["Version"]);
            objSolicitudAutorizacionDetalle.Vigencia = Convert.ToByte(dr["Vigencia"]);

            #region 'CAMPOS VISTA'

            objSolicitudAutorizacionDetalle.DescripcionTipoAutorizacion = dr["DescripcionTipoAutorizacion"].ToString();
            objSolicitudAutorizacionDetalle.DescripcionEstablecimiento = dr["DescripcionEstablecimiento"].ToString();
            objSolicitudAutorizacionDetalle.DescripcionCategoria = dr["DescripcionCategoria"].ToString();
            objSolicitudAutorizacionDetalle.DescripcionEstadio = dr["DescripcionEstadio"].ToString();
            objSolicitudAutorizacionDetalle.DescripcionFase = dr["DescripcionFase"].ToString();

            #endregion

            return objSolicitudAutorizacionDetalle;
        }

        public int RechazarDetalleSolicitudAutorizacion(vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_RechazarDetalleSolicitudAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacionDetalle.Nro_Solicitud);
                cmd.Parameters.AddWithValue("@DetalleId", objSolicitudAutorizacionDetalle.DetalleId);
                cmd.Parameters.AddWithValue("@Observaciones", objSolicitudAutorizacionDetalle.Observaciones);
                return Datos.Mantenimiento(cmd);
            }
        }

        public bool SeProcesaronTodos(string numeroSolicitud)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_GetCantidadDetallesNoProcesadosPorNroSolicitud";
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@Nro_Solicitud", numeroSolicitud);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord == 0;
        }

        public int AprobarDetalleSolicitudAutorizacion(vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_AprobarDetalleSolicitudAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacionDetalle.Nro_Solicitud);
                cmd.Parameters.AddWithValue("@DetalleId", objSolicitudAutorizacionDetalle.DetalleId);
                cmd.Parameters.AddWithValue("@AutorizacionId", objSolicitudAutorizacionDetalle.AutorizacionId);
                return Datos.Mantenimiento(cmd);
            }
        }

        public int AprobarDetalleSolicitudAutorizacionWeb(SolicitudAutorizacion objSolicitudAutorizacionDetalle)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_AprobarDetalleSolicitudAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacionDetalle.Nro_Solicitud);
                cmd.Parameters.AddWithValue("@DetalleId", objSolicitudAutorizacionDetalle.DetalleId);
                cmd.Parameters.AddWithValue("@AutorizacionId", objSolicitudAutorizacionDetalle.AutorizacionId);
                return Datos.Mantenimiento(cmd);
            }
        }


        public vw2_SolicitudAutorizacionDetalle GetDetalleSolicitudPorNumeroSolicitudId(string numeroSolicitud, int detalleId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetDetalleSolicitudPorNumeroSolicitudId";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", numeroSolicitud);
                cmd.Parameters.AddWithValue("@DetalleId", detalleId);
                vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle = null;
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        objSolicitudAutorizacionDetalle = CargarDetalleSolicitud(dr);
                    }
                }
                return objSolicitudAutorizacionDetalle;
            }
        }
    }
}
