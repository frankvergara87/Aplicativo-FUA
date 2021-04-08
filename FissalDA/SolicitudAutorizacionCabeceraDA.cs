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
    public class SolicitudAutorizacionCabeceraDA
    {
        SqlCommand cmd;

        public SolicitudAutorizacionCabeceraDA()
        {
            cmd = new SqlCommand();
        }

        public List<vw2_SolicitudAutorizacion> GetAllSolicitudesAutorizacion()
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetAllSolicitudesAutorizacion";
                using(SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.CommandTimeout = 1024;
                    cmd.CommandType = CommandType.StoredProcedure;
                    List<vw2_SolicitudAutorizacion> listaSolicitudAutorizacion = new List<vw2_SolicitudAutorizacion>();
                    using(DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaSolicitudAutorizacion.Add(CargarSolicitudAutorizacion(dr));
                        }
                    }
                    return listaSolicitudAutorizacion;
                }
            }
        }

        public List<vw2_SolicitudAutorizacion> GetSolicitudesAutorizacionPorIpress(int establecimientoId)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetSolicitudesAutorizacionPorIpress";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    cmd.CommandTimeout = 1024;
                    cmd.CommandType = CommandType.StoredProcedure;
                    List<vw2_SolicitudAutorizacion> listaSolicitudAutorizacion = new List<vw2_SolicitudAutorizacion>();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaSolicitudAutorizacion.Add(CargarSolicitudAutorizacion(dr));
                        }
                    }
                    return listaSolicitudAutorizacion;
                }
            }
        }

        public int Rechazar(vw2_SolicitudAutorizacion objSolicitudAutorizacion)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_RechazarSolicitudAutorizacion";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacion.Nro_Solicitud);
            cmd.Parameters.AddWithValue("@Usuario_Procesa", objSolicitudAutorizacion.Usuario_Procesa);
            return Datos.Mantenimiento(cmd);
        }

        public vw2_SolicitudAutorizacion CargarSolicitudAutorizacion(IDataReader dr)
        {
            vw2_SolicitudAutorizacion objSolicitudAutorizacion = new vw2_SolicitudAutorizacion();
            if (dr["Activo"] != DBNull.Value)
                objSolicitudAutorizacion.Activo = Convert.ToBoolean(dr["Activo"]);
            objSolicitudAutorizacion.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
            objSolicitudAutorizacion.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
            if (dr["Asegurado"] != DBNull.Value)
                objSolicitudAutorizacion.Asegurado = Convert.ToBoolean(dr["Asegurado"]);
            objSolicitudAutorizacion.Descripcion = dr["Descripcion"].ToString();
            objSolicitudAutorizacion.Enviado = Convert.ToBoolean(dr["Enviado"]);
            objSolicitudAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
            if (dr["fecha_defuncion"] != DBNull.Value)
                objSolicitudAutorizacion.fecha_defuncion = Convert.ToDateTime(dr["fecha_defuncion"]);
            if (dr["Fecha_Procesado"] != DBNull.Value)
                objSolicitudAutorizacion.Fecha_Procesado = Convert.ToDateTime(dr["Fecha_Procesado"]);
            objSolicitudAutorizacion.Fecha_Solicitud = Convert.ToDateTime(dr["Fecha_Solicitud"]);
            objSolicitudAutorizacion.Historia = dr["Historia"].ToString();
            if (dr["Nacimiento"] != DBNull.Value)
                objSolicitudAutorizacion.Nacimiento = Convert.ToDateTime(dr["Nacimiento"]);
            objSolicitudAutorizacion.Nombres = dr["Nombres"].ToString();
            objSolicitudAutorizacion.Nro_Solicitud = dr["Nro_Solicitud"].ToString();
            objSolicitudAutorizacion.NumeroDocumento = dr["NumeroDocumento"].ToString();
            objSolicitudAutorizacion.OtrosNombres = dr["OtrosNombres"].ToString();
            objSolicitudAutorizacion.PacienteId = dr["PacienteId"].ToString();
            if (dr["Procesado"] != DBNull.Value)
                objSolicitudAutorizacion.Procesado = Convert.ToBoolean(dr["Procesado"]);
            if (dr["Recibido"] != DBNull.Value)
                objSolicitudAutorizacion.Recibido = Convert.ToBoolean(dr["Recibido"]);
            objSolicitudAutorizacion.SexoId = Convert.ToByte(dr["SexoId"]);
            if (dr["TipoDocumentoId"] != DBNull.Value)
                objSolicitudAutorizacion.TipoDocumentoId = Convert.ToByte(dr["TipoDocumentoId"]);
            objSolicitudAutorizacion.TipoRegimenId = Convert.ToByte(dr["TipoRegimenId"]);
            objSolicitudAutorizacion.Usuario_Procesa = dr["Usuario_Procesa"].ToString();
            objSolicitudAutorizacion.Usuario_Solicitante = dr["Usuario_Solicitante"].ToString();
            if (dr["ValidadoFISSAL"] != DBNull.Value)
                objSolicitudAutorizacion.ValidadoFISSAL = Convert.ToBoolean(dr["ValidadoFISSAL"]);
            if (dr["ValidadoRENIEC"] != DBNull.Value)
                objSolicitudAutorizacion.ValidadoRENIEC = Convert.ToBoolean(dr["ValidadoRENIEC"]);
            if (dr["ValidadoSIS"] != DBNull.Value)
                objSolicitudAutorizacion.ValidadoSIS = Convert.ToBoolean(dr["ValidadoSIS"]);

            #region 'CAMPOS VISTA'

            objSolicitudAutorizacion.DescripcionEstablecimiento = dr["DescripcionEstablecimiento"].ToString();
            objSolicitudAutorizacion.DescripcionPaciente = dr["DescripcionPaciente"].ToString();
            objSolicitudAutorizacion.DescripcionSexo = dr["DescripcionSexo"].ToString();
            objSolicitudAutorizacion.DescripcionTipoDocumento = dr["DescripcionTipoDocumento"].ToString();
            objSolicitudAutorizacion.DescripcionTipoRegimen = dr["DescripcionTipoRegimen"].ToString();

            #endregion
            return objSolicitudAutorizacion;
        }


        public int Actualizar(vw2_SolicitudAutorizacion objSolicitudAutorizacion)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarSolicitudAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacion.Nro_Solicitud);

                if (objSolicitudAutorizacion.Activo != null)
                    cmd.Parameters.AddWithValue("@Activo", objSolicitudAutorizacion.Activo);
                else
                    cmd.Parameters.AddWithValue("@Activo", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", objSolicitudAutorizacion.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", objSolicitudAutorizacion.ApellidoPaterno);
                if (objSolicitudAutorizacion.Asegurado != null)
                    cmd.Parameters.AddWithValue("@Asegurado", objSolicitudAutorizacion.Asegurado);
                else
                    cmd.Parameters.AddWithValue("@Asegurado", DBNull.Value);
                if (objSolicitudAutorizacion.fecha_defuncion != null)
                    cmd.Parameters.AddWithValue("@fecha_defuncion", objSolicitudAutorizacion.fecha_defuncion);
                else
                    cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                if (objSolicitudAutorizacion.Fecha_Procesado != null)
                    cmd.Parameters.AddWithValue("@Fecha_Procesado", objSolicitudAutorizacion.Fecha_Procesado);
                else
                    cmd.Parameters.AddWithValue("@Fecha_Procesado", DBNull.Value);
                cmd.Parameters.AddWithValue("@Historia", objSolicitudAutorizacion.Historia);
                cmd.Parameters.AddWithValue("@Nacimiento", objSolicitudAutorizacion.Nacimiento);
                cmd.Parameters.AddWithValue("@Nombres", objSolicitudAutorizacion.Nombres);
                cmd.Parameters.AddWithValue("@NumeroDocumento", objSolicitudAutorizacion.NumeroDocumento);
                cmd.Parameters.AddWithValue("@OtrosNombres", objSolicitudAutorizacion.OtrosNombres);
                if (objSolicitudAutorizacion.Procesado != null)
                    cmd.Parameters.AddWithValue("@Procesado", objSolicitudAutorizacion.Procesado);
                else
                    cmd.Parameters.AddWithValue("@Procesado", DBNull.Value);
                if (objSolicitudAutorizacion.Recibido != null)
                    cmd.Parameters.AddWithValue("@Recibido", objSolicitudAutorizacion.Recibido);
                else
                    cmd.Parameters.AddWithValue("@Recibido", DBNull.Value);
                cmd.Parameters.AddWithValue("@SexoId", objSolicitudAutorizacion.SexoId);
                cmd.Parameters.AddWithValue("@TipoDocumentoId", objSolicitudAutorizacion.TipoDocumentoId);
                cmd.Parameters.AddWithValue("@TipoRegimenId", objSolicitudAutorizacion.TipoRegimenId);
                cmd.Parameters.AddWithValue("@Usuario_Procesa", objSolicitudAutorizacion.Usuario_Procesa);
                if(objSolicitudAutorizacion.ValidadoRENIEC != null)
                    cmd.Parameters.AddWithValue("@ValidadoRENIEC", objSolicitudAutorizacion.ValidadoRENIEC);
                else
                    cmd.Parameters.AddWithValue("@ValidadoRENIEC", DBNull.Value);
                return Datos.Mantenimiento(cmd);
            }
        }
        public int ActualizarWeb(SolicitudAutorizacion objSolicitudAutorizacion)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarSolicitudAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacion.Nro_Solicitud);

                if (objSolicitudAutorizacion.Activo != null)
                    cmd.Parameters.AddWithValue("@Activo", objSolicitudAutorizacion.Activo);
                else
                    cmd.Parameters.AddWithValue("@Activo", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", objSolicitudAutorizacion.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", objSolicitudAutorizacion.ApellidoPaterno);
                if (objSolicitudAutorizacion.Asegurado != null)
                    cmd.Parameters.AddWithValue("@Asegurado", objSolicitudAutorizacion.Asegurado);
                else
                    cmd.Parameters.AddWithValue("@Asegurado", DBNull.Value);
                if (objSolicitudAutorizacion.fecha_defuncion != null)
                    cmd.Parameters.AddWithValue("@fecha_defuncion", objSolicitudAutorizacion.fecha_defuncion);
                else
                    cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                if (objSolicitudAutorizacion.Fecha_Procesado != null)
                    cmd.Parameters.AddWithValue("@Fecha_Procesado", objSolicitudAutorizacion.Fecha_Procesado);
                else
                    cmd.Parameters.AddWithValue("@Fecha_Procesado", DBNull.Value);
                cmd.Parameters.AddWithValue("@Historia", objSolicitudAutorizacion.Historia);
                cmd.Parameters.AddWithValue("@Nacimiento", objSolicitudAutorizacion.Nacimiento);
                cmd.Parameters.AddWithValue("@Nombres", objSolicitudAutorizacion.Nombres);
                cmd.Parameters.AddWithValue("@NumeroDocumento", objSolicitudAutorizacion.NumeroDocumento);
                if (objSolicitudAutorizacion.OtrosNombres != null)
                    cmd.Parameters.AddWithValue("@OtrosNombres", objSolicitudAutorizacion.OtrosNombres);
                else
                    cmd.Parameters.AddWithValue("@OtrosNombres", DBNull.Value);
                if (objSolicitudAutorizacion.Procesado != null)
                    cmd.Parameters.AddWithValue("@Procesado", objSolicitudAutorizacion.Procesado);
                else
                    cmd.Parameters.AddWithValue("@Procesado", DBNull.Value);
                if (objSolicitudAutorizacion.recibido != null)
                    cmd.Parameters.AddWithValue("@Recibido", objSolicitudAutorizacion.recibido);
                else
                    cmd.Parameters.AddWithValue("@Recibido", DBNull.Value);
                cmd.Parameters.AddWithValue("@SexoId", objSolicitudAutorizacion.SexoId);
                cmd.Parameters.AddWithValue("@TipoDocumentoId", objSolicitudAutorizacion.TipoDocumentoId);
                cmd.Parameters.AddWithValue("@TipoRegimenId", objSolicitudAutorizacion.TipoRegimenId);
                cmd.Parameters.AddWithValue("@Usuario_Procesa", objSolicitudAutorizacion.Usuario_Procesa);
                if (objSolicitudAutorizacion.ValidadoRENIEC != null)
                    cmd.Parameters.AddWithValue("@ValidadoRENIEC", objSolicitudAutorizacion.ValidadoRENIEC);
                else
                    cmd.Parameters.AddWithValue("@ValidadoRENIEC", DBNull.Value);
                return Datos.Mantenimiento(cmd);
            }
        }

        public int ActualizarCabeceraWeb(SolicitudAutorizacion objSolicitudAutorizacion)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_SolicitudAutorizacion_ActualizarAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudAutorizacion.Nro_Solicitud);

                cmd.Parameters.AddWithValue("@ApellidoMaterno", objSolicitudAutorizacion.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", objSolicitudAutorizacion.ApellidoPaterno);

                if (objSolicitudAutorizacion.fecha_defuncion != null)
                    cmd.Parameters.AddWithValue("@fecha_defuncion", objSolicitudAutorizacion.fecha_defuncion);
                else
                    cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                if (objSolicitudAutorizacion.Fecha_Procesado != null)
                    cmd.Parameters.AddWithValue("@Fecha_Procesado", objSolicitudAutorizacion.Fecha_Procesado);
                else
                    cmd.Parameters.AddWithValue("@Fecha_Procesado", DBNull.Value);
                cmd.Parameters.AddWithValue("@Historia", objSolicitudAutorizacion.Historia);
                cmd.Parameters.AddWithValue("@Nacimiento", objSolicitudAutorizacion.Nacimiento);
                cmd.Parameters.AddWithValue("@Nombres", objSolicitudAutorizacion.Nombres);
                cmd.Parameters.AddWithValue("@NumeroDocumento", objSolicitudAutorizacion.NumeroDocumento);
                if (objSolicitudAutorizacion.OtrosNombres != null)
                    cmd.Parameters.AddWithValue("@OtrosNombres", objSolicitudAutorizacion.OtrosNombres);
                else
                    cmd.Parameters.AddWithValue("@OtrosNombres", DBNull.Value);
                if (objSolicitudAutorizacion.Procesado != null)
                    cmd.Parameters.AddWithValue("@Procesado", objSolicitudAutorizacion.Procesado);
                else
                    cmd.Parameters.AddWithValue("@Procesado", DBNull.Value);
                if (objSolicitudAutorizacion.recibido != null)
                    cmd.Parameters.AddWithValue("@Recibido", objSolicitudAutorizacion.recibido);
                else
                    cmd.Parameters.AddWithValue("@Recibido", DBNull.Value);
                cmd.Parameters.AddWithValue("@SexoId", objSolicitudAutorizacion.SexoId);
                cmd.Parameters.AddWithValue("@TipoDocumentoId", objSolicitudAutorizacion.TipoDocumentoId);
                cmd.Parameters.AddWithValue("@TipoRegimenId", objSolicitudAutorizacion.TipoRegimenId);
                cmd.Parameters.AddWithValue("@Usuario_Procesa", objSolicitudAutorizacion.Usuario_Procesa);
                if (objSolicitudAutorizacion.ValidadoRENIEC != null)
                    cmd.Parameters.AddWithValue("@ValidadoRENIEC", objSolicitudAutorizacion.ValidadoRENIEC);
                else
                    cmd.Parameters.AddWithValue("@ValidadoRENIEC", DBNull.Value);
                return Datos.Mantenimiento(cmd);
            }
        }

        public vw2_SolicitudAutorizacion GetSolicitudAutorizacionPorId(string numeroSolicitud)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetSolicitudAutorizacionPorId";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", numeroSolicitud);
                vw2_SolicitudAutorizacion objSolicitudAutorizacion = null;
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        objSolicitudAutorizacion = CargarSolicitudAutorizacion(dr);
                    }
                }
                return objSolicitudAutorizacion;
            }
        }
    }
}
