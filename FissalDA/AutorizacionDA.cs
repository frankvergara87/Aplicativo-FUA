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
    public class AutorizacionDA
    {
        static SqlCommand cmd;

        public AutorizacionDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA AUTORIZACIONES X PACIENTE ID Y ESTABLECIMIENTO ID

        public DataTable Autorizacion_PacienteIdxEstablecimientoId(Autorizacion ObjAutorizacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Autorizacion_PacienteIdxEstablecimientoId";
            //cmd.Parameters.AddWithValue("@TipoDocumentoId", ObjAutorizacion.TipoDocumentoId);
            cmd.Parameters.AddWithValue("@PacienteId", ObjAutorizacion.PacienteId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", ObjAutorizacion.EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecAtencion", ObjAutorizacion.Fecha);   
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public static DataTable Autorizacion_ListarxAutorizacionId(Autorizacion ObjAutorizacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_autorizacion_ListarxAutorizacionId";
            cmd.Parameters.AddWithValue("@AutorizacionId", ObjAutorizacion.AutorizacionId);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // OBTIENE AUTORIZACIONES POR CONSULTA SQL
        public DataTable GetAllAutorizacionPorConsultaSql(string consultaSql)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = consultaSql;
            return Datos.ObtenerDatosSql(cmd);
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR AÑO
        public DataTable GetCantidadMontoAutorizacionesPorAño()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_GetCantidadMontoAutorizacionesPorAño";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR AÑO Y MES
        public DataTable GetCantidadMontoAutorizacionesPorAñoMes()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_GetCantidadMontoAutorizacionesPorAñoMes";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR IPRESS
        public DataTable GetCantidadMontoAutorizacionesPorIPRESS()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_GetCantidadMontoAutorizacionesPorIPRESS";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR PACIENTE
        public DataTable GetCantidadMontoAutorizacionesPorPaciente()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_GetCantidadMontoAutorizacionesPorPaciente";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE AUTORIZACION POR ID
        public Autorizacion GetAutorizacionPorId(int autorizacionId)
        {
            Autorizacion objAutorizacion=null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_GetAutorizacionPorId";
            cmd.Parameters.AddWithValue("@AutorizacionId", autorizacionId);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objAutorizacion = new Autorizacion();
                    objAutorizacion.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"]);
                    objAutorizacion.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    objAutorizacion.Estado = dr["Estado"].ToString();
                    objAutorizacion.CodigoAutorizacion = dr["CodigoAutorizacion"].ToString();
                    objAutorizacion.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
                    if (dr["Monto"] != DBNull.Value)
                        objAutorizacion.Monto = Convert.ToDecimal(dr["Monto"]);
                    objAutorizacion.Descripcion = dr["Descripcion"].ToString();
                    objAutorizacion.Vigencia = Convert.ToDateTime(dr["Vigencia"]);
                    objAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
                    objAutorizacion.PacienteId = Convert.ToString(dr["PacienteId"]);
                    objAutorizacion.TratamiendoId = Convert.ToInt32(dr["TratamiendoId"]);
                    objAutorizacion.Version = Convert.ToInt32(dr["Version"]);
                    objAutorizacion.observacion = dr["observacion"].ToString();
                    objAutorizacion.Adicional = Convert.ToBoolean(dr["Adicional"]);
                    objAutorizacion.Modalidad = Convert.ToString(dr["Modalidad"]);
                    objAutorizacion.ControlaCantidad = Convert.ToBoolean(dr["ControlaCantidad"]);
                    objAutorizacion.DiagnosticoAsociado = Convert.ToBoolean(dr["DiagnosticoAsociado"]);
                    objAutorizacion.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
                    objAutorizacion.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    if (dr["FechaInformeMedico"] != DBNull.Value)
                        objAutorizacion.FechaInformeMedico = Convert.ToDateTime(dr["FechaInformeMedico"]);
                    if (dr["FechaSolicitud"] != DBNull.Value)
                        objAutorizacion.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"]);
                    if (dr["FechaRespuesta"] != DBNull.Value)
                        objAutorizacion.FechaRespuesta = Convert.ToDateTime(dr["FechaRespuesta"]);
                    objAutorizacion.Tipo = Convert.ToString(dr["Tipo"]);
                    objAutorizacion.Anulado = Convert.ToBoolean(dr["Anulado"]);
                }
            }
            return objAutorizacion;
        }

        //ANULA AUTORIZACION POR ID
        public int AnularAutorizacionPorId(int autorizacionId)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_AnularAutorizacionPorId";
            cmd.Parameters.AddWithValue("@AutorizacionId", autorizacionId);
            return Datos.Mantenimiento(cmd);
        }

        //REGISTRA AUTORIZACION
        public Autorizacion RegistrarAutorizacion(Autorizacion objAutorizacion)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_RegistrarAutorizacion";
                objAutorizacion.AutorizacionId = GetMaxIdAutorizacion() + 1;
                cmd.Parameters.AddWithValue("@AutorizacionId", objAutorizacion.AutorizacionId);
                cmd.Parameters.AddWithValue("@Fecha", objAutorizacion.Fecha);
                cmd.Parameters.AddWithValue("@Estado", objAutorizacion.Estado);
                cmd.Parameters.AddWithValue("@TipoAutorizacionId", objAutorizacion.TipoAutorizacionId);
                if (objAutorizacion.Monto != null)
                    cmd.Parameters.AddWithValue("@Monto", objAutorizacion.Monto);
                else
                    cmd.Parameters.AddWithValue("@Monto", DBNull.Value);
                if (!string.IsNullOrEmpty(objAutorizacion.Descripcion))
                    cmd.Parameters.AddWithValue("@Descripcion", objAutorizacion.Descripcion);
                else
                    cmd.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                if (objAutorizacion.FechaInicio != null)
                    cmd.Parameters.AddWithValue("@FechaInicio", objAutorizacion.FechaInicio);
                else
                    cmd.Parameters.AddWithValue("@FechaInicio", DBNull.Value);
                cmd.Parameters.AddWithValue("@Vigencia", objAutorizacion.Vigencia);
                cmd.Parameters.AddWithValue("@EstablecimientoId", objAutorizacion.EstablecimientoId);
                cmd.Parameters.AddWithValue("@PacienteId", objAutorizacion.PacienteId);
                cmd.Parameters.AddWithValue("@TratamiendoId", objAutorizacion.TratamiendoId);
                cmd.Parameters.AddWithValue("@Version", objAutorizacion.Version);
                if (!string.IsNullOrEmpty(objAutorizacion.observacion))
                    cmd.Parameters.AddWithValue("@observacion", objAutorizacion.observacion);
                else
                    cmd.Parameters.AddWithValue("@observacion", DBNull.Value);
                cmd.Parameters.AddWithValue("@Adicional", objAutorizacion.Adicional);
                cmd.Parameters.AddWithValue("@Modalidad", objAutorizacion.Modalidad);
                cmd.Parameters.AddWithValue("@ControlaCantidad", objAutorizacion.ControlaCantidad);
                cmd.Parameters.AddWithValue("@DiagnosticoAsociado", objAutorizacion.DiagnosticoAsociado);
                if (!string.IsNullOrEmpty(objAutorizacion.UsuarioCreacion))
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", objAutorizacion.UsuarioCreacion);
                else
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", DBNull.Value);
                if (objAutorizacion.FechaInformeMedico != null)
                    cmd.Parameters.AddWithValue("@FechaInformeMedico", objAutorizacion.FechaInformeMedico);
                else
                    cmd.Parameters.AddWithValue("@FechaInformeMedico", DBNull.Value);
                if (objAutorizacion.FechaSolicitud != null)
                    cmd.Parameters.AddWithValue("@FechaSolicitud", objAutorizacion.FechaSolicitud);
                else
                    cmd.Parameters.AddWithValue("@FechaSolicitud", DBNull.Value);
                if (objAutorizacion.FechaRespuesta != null)
                    cmd.Parameters.AddWithValue("@FechaRespuesta", objAutorizacion.FechaRespuesta);
                else
                    cmd.Parameters.AddWithValue("@FechaRespuesta", DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo", objAutorizacion.Tipo);
                cmd.Parameters.AddWithValue("@Anulado", objAutorizacion.Anulado);
                if (!string.IsNullOrEmpty(objAutorizacion.Nro_Solicitud))
                    cmd.Parameters.AddWithValue("@Nro_Solicitud", objAutorizacion.Nro_Solicitud);
                else
                    cmd.Parameters.AddWithValue("@Nro_Solicitud", DBNull.Value);
                Datos.Mantenimiento(cmd);
                return objAutorizacion;
            }
        }

        public int GetMaxIdAutorizacion()
        {
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_GetMaxIdAutorizacion";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    object id = cmd.ExecuteScalar();
                    if (id != DBNull.Value)
                        return Convert.ToInt32(id);
                    else
                        return 0;
                }
            }
        }

        //LISTA AUTORIZACIONES - PACIENTE | ESTABLECIMIENTO
        public DataTable ListaAutorizacionesxIdPacientexSoloEstablecimiento(string PacienteId, int TipoDocumentoId, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_ListarxPacientexEstablecimiento";
            cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumentoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //LISTA AUTORIZACIONES - PACIENTE | ESTABLECIMIENTO - OTROS ESTABLECIMIENTOS
        public DataTable ListaAutorizacionesxIdPacientexOtroEstablecimiento(string PacienteId, int TipoDocumentoId, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Autorizacion_ListarxPacienteOtroEstablecimiento";
            cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumentoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public bool ExisteAutorizacion(int? cadenaId, int faseId, int establecimientoId, string pacienteId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ExisteAutorizacion";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    if(cadenaId==null)
                        cmd.Parameters.AddWithValue("@CadenaId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@CadenaId", cadenaId);
                    cmd.Parameters.AddWithValue("@FaseId", faseId);
                    cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public bool ExisteDiagnosticoAsociado(int tratamientoId, int establecimientoId, string pacienteId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ExisteDiagnosticoAsociado";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@TratamientoId", tratamientoId);
                    cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }



        public SolicitudAutorizacion ObtenerSolicitudAutorizacion(string Nro_Solicitud)
        {
            using (SqlCommand cmd = new SqlCommand())
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
                        objSolicitudAutorizacion.TipoRegimenId = Convert.ToByte(dr["TipoRegimenId"].ToString());

                        objSolicitudAutorizacion.Fecha_Solicitud = Convert.ToDateTime(dr["Fecha_Solicitud"].ToString());
                        objSolicitudAutorizacion.ValidadoFISSAL = Convert.ToBoolean(dr["ValidadoFISSAL"].ToString());
                        objSolicitudAutorizacion.ValidadoSIS = Convert.ToBoolean(dr["ValidadoSIS"].ToString());
                        objSolicitudAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"].ToString());
                        objSolicitudAutorizacion.Descripcion = dr["Descripcion"].ToString();
                        objSolicitudAutorizacion.Usuario_Solicitante = dr["Usuario_Solicitante"].ToString();

                    }
                }
                return objSolicitudAutorizacion;
            }
        }


        public List<SolicitudAutorizacion> ObtenerSolicitudAutorizacionListDetalle(string Nro_Solicitud)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_Solicitud_Autorizacion_Detalle_Listar";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", Nro_Solicitud);
                List<SolicitudAutorizacion> listaPacientes = new List<SolicitudAutorizacion>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        SolicitudAutorizacion ListItem = new SolicitudAutorizacion();
                        ListItem.CategoriaId = dr["CategoriaId"].ToString();
                        ListItem.EstadioId = Convert.ToByte(dr["EstadioId"].ToString());
                        ListItem.FaseId = Convert.ToInt32(dr["FaseId"].ToString());
                        ListItem.TratamientoId = Convert.ToInt32(dr["TratamientoId"].ToString());
                        ListItem.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"].ToString());

                        //ListItem.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"].ToString());
                        ListItem.Nro_Solicitud = Convert.ToString(dr["Nro_Solicitud"].ToString());
                        ListItem.DetalleId = Convert.ToInt32(dr["DetalleId"].ToString());
                        ListItem.Vigencia = Convert.ToInt32(dr["Vigencia"].ToString());
                        
                        listaPacientes.Add(ListItem);
                    }
                }
                return listaPacientes;
            }
        }


        public Tratamiento ObtenerDetalleTratamiento(int TratamientoId)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_Solicitud_Autorizacion_Obtener_DetTratamiento";
                using (SqlCommand cmd = new SqlCommand(sql,conexion))
                {
                    Tratamiento objTratamiento = null;
                    cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objTratamiento = new Tratamiento();
                            objTratamiento.TratamientoId = Convert.ToInt32(dr["TratamientoId"].ToString());
                            objTratamiento.SoloRetrospectivo = Convert.ToBoolean(dr["SoloRetrospectivo"].ToString());
                            objTratamiento.Monto = Convert.ToDecimal(dr["Monto"].ToString());
                            objTratamiento.Version = Convert.ToInt32(dr["Version"].ToString());
                            objTratamiento.Vigencia = Convert.ToInt32(dr["Vigencia"].ToString());
                            objTratamiento.FechaFin = Convert.ToDateTime(dr["FechaFin"].ToString());
                        }
                    }
                    return objTratamiento;
                }
            }
        }


        public DataTable GetAllPreAutorizacion()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAllPreAutorizacion";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public int ActualizarPacienteVivoPreAutorizaciones(string usuarioEvaluacionReniec)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarPacienteVivoPreAutorizaciones";
                cmd.Parameters.AddWithValue("@UsuarioEvaluacionReniec", usuarioEvaluacionReniec);
                return Datos.Mantenimiento(cmd);
            }
        }

        public int ActualizarPacienteVivoPreAutorizacionesPorEstablecimiento(string usuarioEvaluacionReniec, int establecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarPacienteVivoPreAutorizacionesPorEstablecimiento";
                cmd.Parameters.AddWithValue("@UsuarioEvaluacionReniec", usuarioEvaluacionReniec);
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                return Datos.Mantenimiento(cmd);
            }
        }

        public int ActualizarSinAutorizacionesPreAutorizacionesPorEstablecimiento(string usuarioEvaluacionReniec, int establecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarSinAutorizacionesPreAutorizacionesPorEstablecimiento";
                cmd.Parameters.AddWithValue("@UsuarioEvaluacionReniec", usuarioEvaluacionReniec);
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                return Datos.Mantenimiento(cmd);
            }
        }

        public List<string> GetAllPacienteIdActivoSisPendiente()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAllPacienteIdActivoSisPendiente";
                List<string> listaPacientes = new List<string>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaPacientes.Add(dr["PacienteId"].ToString());
                    }
                }
                return listaPacientes;
            }
        }

        public int ActualizarActivoSisPreAutorizaciones(string pacienteId, string activoSis, byte? tipoRegimen ,string usuarioEvaluacionSis)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarActivoSisPreAutorizaciones";
                cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                cmd.Parameters.AddWithValue("@ActivoSis", activoSis);
                if(tipoRegimen == null)
                    cmd.Parameters.AddWithValue("@PacienteTipoRegimenSis", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PacienteTipoRegimenSis", tipoRegimen);
                cmd.Parameters.AddWithValue("@UsuarioEvaluacionSis", usuarioEvaluacionSis);
                return Datos.Mantenimiento(cmd);
            }
        }

        public int ActualizarActivoSisPreAutorizacionesPorEstablecimiento(string pacienteId, string activoSis, byte? tipoRegimen,string usuarioEvaluacionSis, int establecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarActivoSisPreAutorizacionesPorEstablecimiento";
                cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                cmd.Parameters.AddWithValue("@ActivoSis", activoSis);
                if(tipoRegimen==null)
                    cmd.Parameters.AddWithValue("@PacienteTipoRegimenSis", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PacienteTipoRegimenSis", tipoRegimen);
                cmd.Parameters.AddWithValue("@UsuarioEvaluacionSis", usuarioEvaluacionSis);
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                return Datos.Mantenimiento(cmd);
            }
        }

        public List<string> GetPacienteIdActivoSisPendientePorEstablecimiento(int establecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetPacienteIdActivoSisPendientePorEstablecimiento";
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                List<string> listaPacientes = new List<string>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaPacientes.Add(dr["PacienteId"].ToString());
                    }
                }
                return listaPacientes;
            }
        }

        public bool PacienteTieneAutorizacionesPrevias(string pacienteId, string categoriaId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_PacienteTieneAutorizacionesPrevias";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }


        public int ActualizarModalidadAutorizacion(string modalidad, decimal? monto, int autorizacionId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarModalidadAutorizacion";
                cmd.Parameters.AddWithValue("@Modalidad", modalidad);
                if(monto==null)
                    cmd.Parameters.AddWithValue("@Monto", 0);
                else
                    cmd.Parameters.AddWithValue("@Monto", monto);
                cmd.Parameters.AddWithValue("@AutorizacionId", autorizacionId);
                return Datos.Mantenimiento(cmd);
            }
        }

        public int ActualizarPreAutorizacion(string usuarioAutorizacionDefinitiva, string numeroSolicitud, string pacienteSinAutorizacionPrevia, string pacienteTodosRetrospectivos, string pacienteTodosDiferenteFase, string observacionesAutorizacionDefinitiva, int detalleId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarPreAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", numeroSolicitud);
                cmd.Parameters.AddWithValue("@DetalleId", detalleId);
                cmd.Parameters.AddWithValue("@PacienteSinAutorizacionPrevia", pacienteSinAutorizacionPrevia);
                cmd.Parameters.AddWithValue("@PacienteTodosRetrospectivos", pacienteTodosRetrospectivos);
                cmd.Parameters.AddWithValue("@PacienteTodosDiferenteFase", pacienteTodosDiferenteFase);
                if (string.IsNullOrEmpty(observacionesAutorizacionDefinitiva))
                    cmd.Parameters.AddWithValue("@ObservacionesAutorizacionDefinitiva", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@ObservacionesAutorizacionDefinitiva", observacionesAutorizacionDefinitiva);
                cmd.Parameters.AddWithValue("@UsuarioAutorizacionDefinitiva", usuarioAutorizacionDefinitiva);
                return Datos.Mantenimiento(cmd);
            }
        }

        public bool PacienteTieneAutorizacionesPreviasProspectivas(string pacienteId, string categoriaId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_PacienteTieneAutorizacionesPreviasProspectivas";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public bool ExistenPendientesPacienteActivoSis(int? establecimientoId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ExistenPendientesPacienteActivoSis";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    if(establecimientoId==null)
                        cmd.Parameters.AddWithValue("@EstablecimientoId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public bool ExistenPendientesPacienteVivo(int? establecimientoId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ExistenPendientesPacienteVivo";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    if (establecimientoId == null)
                        cmd.Parameters.AddWithValue("@EstablecimientoId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public int ActualizarEvaluacionFissalPreAutorizacion(string numeroSolicitud, int detalleId, string pacienteSinAutorizacionPrevia, string pacienteTodosRetrospectivos, string usuarioEvaluacionFissal)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_ActualizarEvaluacionFissalPreAutorizacion";
                cmd.Parameters.AddWithValue("@Nro_Solicitud", numeroSolicitud);
                cmd.Parameters.AddWithValue("@DetalleId", detalleId);
                cmd.Parameters.AddWithValue("@PacienteSinAutorizacionPrevia", pacienteSinAutorizacionPrevia);
                cmd.Parameters.AddWithValue("@PacienteTodosRetrospectivos", pacienteTodosRetrospectivos);
                cmd.Parameters.AddWithValue("@UsuarioEvaluacionFissal", usuarioEvaluacionFissal);
                return Datos.Mantenimiento(cmd);
            }
        }

        public DataTable GetVwAutorizacionPorId(int autorizacionId)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetVwAutorizacionPorId";
                cmd.Parameters.AddWithValue("@AutorizacionId", autorizacionId);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetAutorizacionesPreviasPorPacienteCategoria(string pacienteId, string categoriaId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAutorizacionesPreviasPorPacienteCategoria";
                cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public bool PacienteTieneAutorizacionesPreviasVigentes(string pacienteId, string categoriaId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_PacienteTieneAutorizacionesPreviasVigentes";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public bool PacienteTieneAutorizacionesPreviasProspectivasVigentes(string pacienteId, string categoriaId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_PacienteTieneAutorizacionesPreviasProspectivasVigentes";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public bool PacienteTieneAutorizacionesPreviasMismaFase(string pacienteId, string categoriaId, int faseId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_PacienteTieneAutorizacionesPreviasMismaFase";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    cmd.Parameters.AddWithValue("@FaseId", faseId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public DataTable MovimientoAutorizacion_AutorizacionWS(DataTable dt)
        {
            SqlConnection cn = AccesoBD.getConnnection();
            cn.Open();
            using (var cmdws = new SqlCommand("CREATE TABLE TEMPAUTORIZACION" +
                                            "(" +
                                            "Adicional	bit," +
                                            "Anulado	bit	," +
                                            "AutorizacionId	int," + 
                                            "CodigoAutorizacion char(20)," +
                                            "ControlaCantidad	bit," +
                                            "Descripcion	varchar(250)," +
                                            "DiagnosticoAsociado	bit," +
                                            "EstablecimientoId	int," +
                                            "Estado	char(1)," +
                                            "Fecha	smalldatetime," +
                                            "FechaCreacion	smalldatetime," +
                                            "FechaInicio	smalldatetime," +
                                            "FechaSolicitud	date," +
                                            "Modalidad	chaR(1)," +
                                            "Monto	decimal	(9,2)," +
                                            "Nro_Solicitud	char(11)," +
                                            "PacienteId	chaR(8)," +
                                            "PreAutorizado bit," +
                                            "Tipo	char(1)," +
                                            "TipoAutorizacionId	tinyint," +
                                            "TratamiendoId	int," +
                                            "UsuarioCreacion	varchar(10)," +
                                            "Version	int," +
                                            "Vigencia	smalldatetime" +
                                            ")", cn))
            {
                cmdws.ExecuteNonQuery();
            }


            using (var bcp = new SqlBulkCopy(cn, SqlBulkCopyOptions.TableLock, null))
            {
                bcp.DestinationTableName = "TEMPAUTORIZACION";
                bcp.WriteToServer(dt);

            }
            
            cmd = new SqlCommand();
            cmd.CommandText = "UspWSInsertarAutorizaciones";
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
