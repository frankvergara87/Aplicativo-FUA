using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;
using System.Data.Common;

using System.Globalization;


namespace FissalDA
{
    public class SolicitudAutorizacionDA
    {
        static SqlCommand cmd;
        static SqlConnection cn = AccesoBD.getConnnection();


        public SolicitudAutorizacionDA()
        {
            cmd = new SqlCommand();
        }

        public DataTable SolicitudAutorizacion_Listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Autorizacion_PacienteIdxEstablecimientoId";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        public int SolicitudAutorizacion_Grabar(SolicitudAutorizacion objSolicitudBE)
        {
            int result;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_Solicitud_Autorizacion_Grabar";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudBE.Nro_Solicitud);
                    cmd.Parameters.AddWithValue("@EstablecimientoId", objSolicitudBE.EstablecimientoId);
                    
                    cmd.Parameters.AddWithValue("@PacienteId", objSolicitudBE.PacienteId);

                    cmd.Parameters.Add(new SqlParameter("@respuesta", SqlDbType.VarChar,9));
                    cmd.Parameters["@respuesta"].Direction = ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@ApellidoPaterno", objSolicitudBE.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", objSolicitudBE.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@Nombres", objSolicitudBE.Nombres);
                    cmd.Parameters.AddWithValue("@Usuario_Solicitante", objSolicitudBE.UsuarioSolicita);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", objSolicitudBE.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@ValidadoSIS", objSolicitudBE.ValidadoSIS);
                    cmd.Parameters.AddWithValue("@ValidadoFissal", objSolicitudBE.ValidadoFissal);
                    cmd.Parameters.AddWithValue("@Asegurado", objSolicitudBE.Asegurado);
                    cmd.Parameters.AddWithValue("@Activo", objSolicitudBE.Activo);
                    cmd.Parameters.AddWithValue("@Enviado", objSolicitudBE.Enviado);
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", objSolicitudBE.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@TipoRegimenId", objSolicitudBE.TipoRegimenId);
                    cmd.Parameters.AddWithValue("@Historia", objSolicitudBE.Historia);
                    if (objSolicitudBE.Nacimiento != null)
                        cmd.Parameters.AddWithValue("@Nacimiento", objSolicitudBE.Nacimiento);
                    else
                        cmd.Parameters.AddWithValue("@Nacimiento", DBNull.Value);

                    if (objSolicitudBE.fecha_defuncion != null)
                        cmd.Parameters.AddWithValue("@fecha_defuncion", objSolicitudBE.fecha_defuncion);
                    else
                        cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);

                    cmd.Parameters.AddWithValue("@SexoId", objSolicitudBE.SexoId);                  

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    
                    result = cmd.ExecuteNonQuery();

                    objSolicitudBE.PacienteId = cmd.Parameters["@respuesta"].Value.ToString();

                }
            }
            return result;

        }

        public int SolicitudAutorizacion_Actualizar(SolicitudAutorizacion objSolicitudBE)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_ActualizarCab";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudBE.Nro_Solicitud);
            cmd.Parameters.AddWithValue("@EstablecimientoId", objSolicitudBE.EstablecimientoId);
            cmd.Parameters.AddWithValue("@PacienteId", objSolicitudBE.PacienteId);
            cmd.Parameters.AddWithValue("@Nombres", objSolicitudBE.Nombres);
            cmd.Parameters.AddWithValue("@OtrosNombres", objSolicitudBE.OtrosNombres);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", objSolicitudBE.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", objSolicitudBE.ApellidoMaterno);
            cmd.Parameters.AddWithValue("@SexoId", objSolicitudBE.SexoId);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", objSolicitudBE.TipoDocumentoId);

            if (objSolicitudBE.Nacimiento != null)
                cmd.Parameters.AddWithValue("@Nacimiento", objSolicitudBE.Nacimiento);
            else
                cmd.Parameters.AddWithValue("@Nacimiento", DBNull.Value);

            cmd.Parameters.AddWithValue("@Historia", objSolicitudBE.Historia);
            cmd.Parameters.AddWithValue("@TipoRegimenId", objSolicitudBE.TipoRegimenId);
            cmd.Parameters.AddWithValue("@Enviado", objSolicitudBE.Enviado);
            return Datos.Mantenimiento(cmd);
        }
                

        public int SolicitudAutorizacionDet_Grabar(SolicitudAutorizacion objSolicitudBE)
        {
            int result;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_Solicitud_Autorizacion_Detalle_Grabar";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nro_Solicitud", objSolicitudBE.Nro_Solicitud);
                    cmd.Parameters.AddWithValue("@DetalleId", objSolicitudBE.DetalleId);
                    cmd.Parameters.AddWithValue("@TipoAutorizacionId", objSolicitudBE.TipoAutorizacionId);
                    cmd.Parameters.AddWithValue("@PacienteId", objSolicitudBE.PacienteId);
                    cmd.Parameters.AddWithValue("@EstablecimientoId", objSolicitudBE.EstablecimientoId);
                    cmd.Parameters.AddWithValue("@CategoriaId", objSolicitudBE.CategoriaId);
                    cmd.Parameters.AddWithValue("@EstadioId", objSolicitudBE.EstadioId);
                    cmd.Parameters.AddWithValue("@FaseId", objSolicitudBE.FaseId);
                    cmd.Parameters.AddWithValue("@TratamientoId", objSolicitudBE.TratamientoId);
                    cmd.Parameters.AddWithValue("@Vigencia", objSolicitudBE.Vigencia);
                    cmd.Parameters.AddWithValue("@Adicional", objSolicitudBE.Adicional);
                    cmd.Parameters.AddWithValue("@Version", objSolicitudBE.Version);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

        public int SolicitudAutorizacionDet_Validar(string PacienteId, int TratamientoId, int EstablecimientoId)
        {
            int Valor = 0;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Detalle_Consultar";
            cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
            cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {                    
                    Valor = Convert.ToInt32(dr["Valor"].ToString());
                }
            }
            return Valor;
        }


        public int SolicitudAutorizacionDet_Validar(string PacienteId, int TratamientoId, int EstablecimientoId, int FaseId)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_Solicitud_Autorizacion_Detalle_Consultar";
                using(SqlCommand cmd = new SqlCommand(sql,conexion))
                {
                    int Valor = 0;
                    cmd.Parameters.Add(new SqlParameter("@Rpta", SqlDbType.Int));
                    cmd.Parameters["@Rpta"].Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
                    cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);
                    cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                    cmd.Parameters.AddWithValue("@FaseId", FaseId);
                    cmd.Parameters["@Rpta"].Value = DBNull.Value;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.ExecuteNonQuery();
                    Valor = Convert.ToInt32(cmd.Parameters["@Rpta"].Value);
                    return Valor;
                }
            }
        }


        public int SolicitudAutorizacion_Actualizar(string NroSolicitud)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Actualizar";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", NroSolicitud);
            return Datos.Mantenimiento(cmd);
        }
        

        public int SolicitudAutorizacion_Eliminar(string NroSolicitud) 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Detalle_Eliminar";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", NroSolicitud);
            return Datos.Mantenimiento(cmd);        
        }

        public int SolicitudAutorizacion_Eliminar_Todo(string NroSolicitud) 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Eliminar";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", NroSolicitud);
            return Datos.Mantenimiento(cmd);        
        }  

        


        public DataTable SolicitudAutorizacion_ListarGrilla(SolicitudAutorizacion objSolicitudAutorizacion, string Fecha)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Listar";
            cmd.Parameters.AddWithValue("@TipoDocumento", objSolicitudAutorizacion.TipoDocumentoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", objSolicitudAutorizacion.EstablecimientoId);
            cmd.Parameters.AddWithValue("@PacienteId", objSolicitudAutorizacion.PacienteId);
            cmd.Parameters.AddWithValue("@Nombres", objSolicitudAutorizacion.Nombres);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", objSolicitudAutorizacion.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", objSolicitudAutorizacion.ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Enviado", objSolicitudAutorizacion.Enviado);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable SolicitudAutorizacionDetalle_ListarGrilla(string Nro_Solicitud)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Detalle_Listar";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public SolicitudAutorizacionDetalle SolicitudAutorizacionDetalleListar(string Nro_Solicitud)
        {
            SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle = null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Detalle_Listar";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objSolicitudAutorizacionDetalle = new SolicitudAutorizacionDetalle();
                    objSolicitudAutorizacionDetalle.CategoriaId = dr["CategoriaId"].ToString();
                    objSolicitudAutorizacionDetalle.EstadioId = Convert.ToByte(dr["EstadioId"].ToString());
                    objSolicitudAutorizacionDetalle.FaseId = Convert.ToInt32(dr["FaseId"].ToString());
                }
            }
            return objSolicitudAutorizacionDetalle;
        }

        public SolicitudAutorizacion SolicitudAutorizacion_Cabecera_Listar(string Nro_Solicitud)
        {
            SolicitudAutorizacion objSolicitudAutorizacion = null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Cabecera_Listar";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objSolicitudAutorizacion = new SolicitudAutorizacion();
                    objSolicitudAutorizacion.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                    objSolicitudAutorizacion.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                    objSolicitudAutorizacion.Nombres = dr["Nombres"].ToString();
                    objSolicitudAutorizacion.PacienteId = dr["PacienteId"].ToString();
                    objSolicitudAutorizacion.fechaSolicitud = Convert.ToDateTime(dr["Fecha_Solicitud"].ToString());
                }
            }
            return objSolicitudAutorizacion;
        }        
        

        /* \************************************************ CONTADORES*****/
        public int ObtenerNroSolicitud()
        {
            DataTable dt = new DataTable();
            int Pos = 0;
            string X, sql = @"select Max(convert(int,Nro_Solicitud)) Nro_Solicitud from SolicitudAutorizacion";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt); 
                DataRow row = dt.Rows[0];
                X = row["Nro_Solicitud"].ToString();
                if (X == String.Empty) 
                    { Pos = 0;}
                else 
                    { Pos = Convert.ToInt32(X.ToString());}

                return Pos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ObtenerNroDetalle(string NroSolicitud)
        {
            DataTable dt = new DataTable();
            int Pos = 0;
            string X, sql = @"select max(DetalleId) DetalleId from SolicitudAutorizacionDetalle where Nro_Solicitud = " + NroSolicitud;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);
                DataRow row = dt.Rows[0];
                X = row["DetalleId"].ToString();
                if (X == String.Empty)
                { Pos = 0; }
                else
                { Pos = Convert.ToInt32(X.ToString()); }

                return Pos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public SolicitudAutorizacion Obtener_TipoAutorizacion(int EstablecimientoId, string Categoria, int Estadio, int Fase)
        {
            using (SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_Solicitud_Autorizacion_Obtener_TipoAutorizacion";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    SolicitudAutorizacion objSolicitudAutorizacion = null;
                    cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                    cmd.Parameters.AddWithValue("@CategoriaId", Categoria);
                    cmd.Parameters.AddWithValue("@Estadio", Estadio);
                    cmd.Parameters.AddWithValue("@FaseId", Fase);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objSolicitudAutorizacion = new SolicitudAutorizacion();
                            objSolicitudAutorizacion.TipoAutorizacionId = Convert.ToInt32(dr["TipoAutorizacionId"].ToString());
                            objSolicitudAutorizacion.Vigencia = Convert.ToInt32(dr["Vigencia"].ToString());
                            objSolicitudAutorizacion.TratamientoId = Convert.ToInt32(dr["TratamientoId"].ToString());
                            objSolicitudAutorizacion.Version = Convert.ToInt32(dr["Version"].ToString());
                            objSolicitudAutorizacion.CadenaId = Convert.ToInt32(dr["CadenaId"].ToString());
                            objSolicitudAutorizacion.Monto = Convert.ToDecimal(dr["Monto"].ToString());
                            objSolicitudAutorizacion.SoloRetrospectivo = Convert.ToBoolean(dr["SoloRetrospectivo"].ToString());
                        }
                    }
                    return objSolicitudAutorizacion;
                }
            }
        }

        public SolicitudAutorizacion Obtener_Tratamiento(int TipoAutorizacionId, int EstablecimientoId, string Categoria, int Estadio, int Fase)
        {
            SolicitudAutorizacion objSolicitudAutorizacion = null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Obtener_Tratamiento";
            cmd.Parameters.AddWithValue("@TipoAutorizacionId", TipoAutorizacionId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@CategoriaId", Categoria);
            cmd.Parameters.AddWithValue("@EstadioId", Estadio);
            cmd.Parameters.AddWithValue("@FaseId", Fase);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objSolicitudAutorizacion = new SolicitudAutorizacion();
                    objSolicitudAutorizacion.TratamientoId = Convert.ToInt32(dr["TratamientoId"].ToString());
                    objSolicitudAutorizacion.Version = Convert.ToInt32(dr["ultimaversion"].ToString());
                }
            }
            return objSolicitudAutorizacion;
        }


        public SolicitudAutorizacion SolicitudAutorizacion_Obtener_Completo(string Nro_Solicitud)
        {
            SolicitudAutorizacion objSolicitudAutorizacion = null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Obtener_Completo";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objSolicitudAutorizacion = new SolicitudAutorizacion();
                    objSolicitudAutorizacion.Nro_Solicitud = dr["Nro_Solicitud"].ToString();
                    objSolicitudAutorizacion.PacienteId = dr["PacienteId"].ToString();
                    objSolicitudAutorizacion.Nombres = dr["Nombres"].ToString();
                    objSolicitudAutorizacion.OtrosNombres = dr["OtrosNombres"].ToString();
                    objSolicitudAutorizacion.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                    objSolicitudAutorizacion.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                    objSolicitudAutorizacion.SexoId = Convert.ToByte(dr["SexoId"].ToString());
                    objSolicitudAutorizacion.TipoDocumentoId = Convert.ToByte(dr["TipoDocumentoId"].ToString());
                    objSolicitudAutorizacion.NumeroDocumento = dr["NumeroDocumento"].ToString();
                    objSolicitudAutorizacion.Nacimiento = Convert.ToDateTime(dr["Nacimiento"].ToString());
                    objSolicitudAutorizacion.Historia = dr["Historia"].ToString();
                    objSolicitudAutorizacion.TipoRegimenId = Convert.ToInt32(dr["TipoRegimenId"].ToString());
                    objSolicitudAutorizacion.CategoriaId = dr["CategoriaId"].ToString();
                    objSolicitudAutorizacion.EstadioId = Convert.ToInt32(dr["EstadioId"].ToString());
                    objSolicitudAutorizacion.fechaSolicitud = Convert.ToDateTime(dr["Fecha_Solicitud"].ToString());

                    objSolicitudAutorizacion.ValidadoFissal = Convert.ToBoolean(dr["ValidadoFISSAL"].ToString());
                    objSolicitudAutorizacion.ValidadoSIS = Convert.ToBoolean(dr["ValidadoSIS"].ToString());

                    objSolicitudAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"].ToString());

                    objSolicitudAutorizacion.Descripcion = dr["Descripcion"].ToString();


                }
            }
            return objSolicitudAutorizacion;
        }

        public DataTable SolicitudAutorizacionDet_Obtener_Completo(string Nro_Solicitud, string Categoria, int Estadio)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_AutorizacionDet_Obtener_Completo";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
            cmd.Parameters.AddWithValue("@CategoriaId", Categoria);
            cmd.Parameters.AddWithValue("@EstadioId", Estadio);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        public DataTable SolicitudAutorizacion_Detalle_Completo(string Nro_Solicitud)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Detalle_Completo";
            cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        public DataTable SolicitudAutorizacion_Reportes(int EstablecimientoId,string FechaD, string FechaH)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_Reportes";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FechaD", FechaD);
            cmd.Parameters.AddWithValue("@FechaH", FechaH);
            return Datos.ObtenerDatosProcedure(cmd);
        }

    }
}
