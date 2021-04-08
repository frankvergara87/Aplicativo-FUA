using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace FissalSWSExternos
{
       
    public class PacienteService: IPacienteService
    {

        public PacienteRespuesta ConsultarPaciente(CredencialServicio credencial, int tipoDocumentoId, string numeroDocumento, int establecimientoId)
        {
            PacienteRespuesta objPacienteRespuesta = new PacienteRespuesta();
            Paciente objPaciente = new Paciente();
            Autorizacion objAutorizacion = null;
            string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            string respuesta = "";
            if (!UtilService.ValidarCredencial(credencial, out respuesta))
            {
                objPacienteRespuesta.Codigo = 4;
                objPacienteRespuesta.Mensaje = respuesta;
                return objPacienteRespuesta;
            }
            try
            {
                using (SqlConnection conex = new SqlConnection(cadena))
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("UspWSObtenerPaciente", conex))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.AddWithValue("@TipoDocumentoId", tipoDocumentoId);
                        cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                        cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                if (dr.HasRows)
                                {
                                    dr.Read();
                                    objPaciente.PacienteId = dr["PacienteId"].ToString();
                                    objPaciente.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                                    objPaciente.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                                    objPaciente.Nombres = dr["Nombres"].ToString();
                                    objPaciente.OtrosNombres = dr["OtrosNombres"].ToString();
                                    objPaciente.Historia = dr["Historia"].ToString();
                                    objPaciente.SexoId = Convert.ToByte(dr["SexoId"].ToString());
                                    objPaciente.TipoRegimenId = Convert.ToByte(dr["TipoRegimenId"].ToString());
                                    objPaciente.TipoDocumentoId = Convert.ToByte(dr["TipoDocumentoId"].ToString());
                                    objPaciente.NumeroDocumento = dr["NumeroDocumento"].ToString();
                                    objPaciente.Nacimiento = Convert.ToDateTime(dr["Nacimiento"].ToString());
                                    objPaciente.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                                    if (dr["fecha_defuncion"] != DBNull.Value) objPaciente.fecha_defuncion = Convert.ToDateTime(dr["fecha_defuncion"].ToString());
                                    if (dr["EstablecimientoIdOrigen"] != DBNull.Value) objPaciente.EstablecimientoIdOrigen = Convert.ToInt32(dr["EstablecimientoIdOrigen"].ToString());
                                    objPaciente.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
                                    objPaciente.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"].ToString());
                                    objPaciente.Validado = Convert.ToBoolean(dr["Validado"]);
                                    objPaciente.nro_contrato = dr["nro_contrato"].ToString();
                                    objPaciente.Ubigeo_Residencia = dr["Ubigeo_Residencia"].ToString();
                                    objPaciente.Ubigeo_Adscripcion = dr["Ubigeo_Adscripcion"].ToString();
                                    dr.NextResult();
                                    while (dr.Read())
                                    {
                                        objAutorizacion = new Autorizacion();

                                        objAutorizacion.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"]);
                                        objAutorizacion.Fecha = Convert.ToDateTime(dr["Fecha"]);
                                        objAutorizacion.Estado = dr["Estado"].ToString();
                                        objAutorizacion.CodigoAutorizacion = dr["CodigoAutorizacion"].ToString();
                                        objAutorizacion.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
                                        if (dr["Monto"] != DBNull.Value) objAutorizacion.Monto = Convert.ToDecimal(dr["Monto"]);
                                        objAutorizacion.Descripcion = dr["Descripcion"].ToString();
                                        if (dr["FechaInicio"] != DBNull.Value) objAutorizacion.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                                        objAutorizacion.Vigencia = Convert.ToDateTime(dr["Vigencia"]);
                                        objAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
                                        objAutorizacion.PacienteId = Convert.ToString(dr["PacienteId"]);
                                        objAutorizacion.TratamiendoId = Convert.ToInt32(dr["TratamiendoId"]);
                                        objAutorizacion.Version = Convert.ToInt32(dr["Version"]);
                                        objAutorizacion.Observacion = dr["observacion"].ToString();
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
                                        if (dr["Nro_Solicitud"] != DBNull.Value) objAutorizacion.Nro_Solicitud = dr["Nro_Solicitud"].ToString();
                                        //objAutorizacion.Enviado = Convert.ToBoolean(dr["Enviado"]);
                                        //objAutorizacion.PreAutorizado = Convert.ToBoolean(dr["PreAutorizado"]);
                                        objPaciente.Autorizaciones.Add(objAutorizacion);
                                    }

                                    if (objPaciente.Autorizaciones.Count == 0)
                                    {
                                        objPacienteRespuesta.Codigo = 5;
                                        objPacienteRespuesta.Mensaje = "El paciente no tiene autorizaciones";
                                    }
                                    else
                                    {
                                        objPacienteRespuesta.Codigo = 3;
                                        objPacienteRespuesta.Mensaje = "Se encontró el paciente ";

                                    }
                                    objPacienteRespuesta.Paciente = objPaciente;
                                }
                                else
                                {
                                    objPacienteRespuesta.Codigo = 2;
                                    objPacienteRespuesta.Mensaje = "No se encontró al paciente";
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                objPacienteRespuesta.Codigo = 1;
                objPacienteRespuesta.Mensaje = "ocurrió un error al consultar";
            }

            return objPacienteRespuesta;
        }

        public PacienteRespuesta ObtenerPacientes(CredencialServicio credencial, int establecimientoId)
        {
            PacienteRespuesta objPacienteRespuesta = new PacienteRespuesta();
            List<PacienteWS> objPacientes = new List<PacienteWS>();
            PacienteWS objPaciente = new PacienteWS();
            Autorizacion objAutorizacion = null;
            string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            string respuesta = "";
            if (!UtilService.ValidarCredencial(credencial, out respuesta))
            {
                objPacienteRespuesta.Codigo = 4;
                objPacienteRespuesta.Mensaje = respuesta;
                return objPacienteRespuesta;
            }
            try
            {
                using (SqlConnection conex = new SqlConnection(cadena))
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("UspWSObtenerPacientes", conex))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        //cmd.Parameters.AddWithValue("@TipoDocumentoId", tipoDocumentoId);
                        //cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                        cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                if (dr.HasRows)
                                {
                                    //dr.Read();

                                    while (dr.Read())
                                    {

                                        objPaciente = new PacienteWS();


                                        objPaciente.PacienteId = dr["PacienteId"].ToString();
                                        objPaciente.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                                        objPaciente.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                                        objPaciente.Nombres = dr["Nombres"].ToString();
                                        objPaciente.OtrosNombres = dr["OtrosNombres"].ToString();
                                        objPaciente.Historia = dr["Historia"].ToString();
                                        objPaciente.SexoId = Convert.ToByte(dr["SexoId"].ToString());
                                        objPaciente.TipoRegimenId = Convert.ToByte(dr["TipoRegimenId"].ToString());
                                        objPaciente.TipoDocumentoId = Convert.ToByte(dr["TipoDocumentoId"].ToString());
                                        objPaciente.NumeroDocumento = dr["NumeroDocumento"].ToString();
                                        objPaciente.Nacimiento = Convert.ToDateTime(dr["Nacimiento"].ToString());
                                        objPaciente.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                                        //if (dr["fecha_defuncion"] != DBNull.Value) objPaciente.fecha_defuncion = Convert.ToDateTime(dr["fecha_defuncion"].ToString());
                                        //if (dr["EstablecimientoIdOrigen"] != DBNull.Value) objPaciente.EstablecimientoIdOrigen = Convert.ToInt32(dr["EstablecimientoIdOrigen"].ToString());
                                        //objPaciente.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
                                        //objPaciente.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"].ToString());
                                        //objPaciente.Validado = Convert.ToBoolean(dr["Validado"]);
                                        //objPaciente.nro_contrato = dr["nro_contrato"].ToString();
                                        //objPaciente.Ubigeo_Residencia = dr["Ubigeo_Residencia"].ToString();
                                        //objPaciente.Ubigeo_Adscripcion = dr["Ubigeo_Adscripcion"].ToString();
                                    //dr.NextResult();
                                    //while (dr.Read())
                                    //{
                                        //objAutorizacion = new Autorizacion();

                                        //objAutorizacion.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"]);
                                        //objAutorizacion.Fecha = Convert.ToDateTime(dr["Fecha"]);
                                        //objAutorizacion.Estado = dr["Estado"].ToString();
                                        //objAutorizacion.CodigoAutorizacion = dr["CodigoAutorizacion"].ToString();
                                        //objAutorizacion.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
                                        //if (dr["Monto"] != DBNull.Value) objAutorizacion.Monto = Convert.ToDecimal(dr["Monto"]);
                                        //objAutorizacion.Descripcion = dr["Descripcion"].ToString();
                                        //if (dr["FechaInicio"] != DBNull.Value) objAutorizacion.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                                        //objAutorizacion.Vigencia = Convert.ToDateTime(dr["Vigencia"]);
                                        //objAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
                                        //objAutorizacion.PacienteId = Convert.ToString(dr["PacienteId"]);
                                        //objAutorizacion.TratamiendoId = Convert.ToInt32(dr["TratamiendoId"]);
                                        //objAutorizacion.Version = Convert.ToInt32(dr["Version"]);
                                        //objAutorizacion.Observacion = dr["observacion"].ToString();
                                        //objAutorizacion.Adicional = Convert.ToBoolean(dr["Adicional"]);
                                        //objAutorizacion.Modalidad = Convert.ToString(dr["Modalidad"]);
                                        //objAutorizacion.ControlaCantidad = Convert.ToBoolean(dr["ControlaCantidad"]);
                                        //objAutorizacion.DiagnosticoAsociado = Convert.ToBoolean(dr["DiagnosticoAsociado"]);
                                        //objAutorizacion.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
                                        //objAutorizacion.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                                        //if (dr["FechaInformeMedico"] != DBNull.Value)
                                        //    objAutorizacion.FechaInformeMedico = Convert.ToDateTime(dr["FechaInformeMedico"]);
                                        //if (dr["FechaSolicitud"] != DBNull.Value)
                                        //    objAutorizacion.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"]);
                                        //if (dr["FechaRespuesta"] != DBNull.Value)
                                        //    objAutorizacion.FechaRespuesta = Convert.ToDateTime(dr["FechaRespuesta"]);
                                        //objAutorizacion.Tipo = Convert.ToString(dr["Tipo"]);
                                        //objAutorizacion.Anulado = Convert.ToBoolean(dr["Anulado"]);
                                        //if (dr["Nro_Solicitud"] != DBNull.Value) objAutorizacion.Nro_Solicitud = dr["Nro_Solicitud"].ToString();
                                        //objAutorizacion.Enviado = Convert.ToBoolean(dr["Enviado"]);
                                        //objAutorizacion.PreAutorizado = Convert.ToBoolean(dr["PreAutorizado"]);

                                        objPacientes.Add(objPaciente);
                                     }

                                    objPacienteRespuesta.Pacientes = objPacientes;

                                    }

                                    //if (objPaciente.Autorizaciones.Count == 0)
                                    //{
                                    //    objPacienteRespuesta.Codigo = 5;
                                    //    objPacienteRespuesta.Mensaje = "El paciente no tiene autorizaciones";
                                    //}
                                    //else
                                    //{
                                    //    objPacienteRespuesta.Codigo = 3;
                                    //    objPacienteRespuesta.Mensaje = "Se encontró el paciente ";
                                       
                                    //}
                                    //objPacienteRespuesta.Paciente = objPaciente;
                                //}
                                //else 
                                //{
                                //    objPacienteRespuesta.Codigo = 2;
                                //    objPacienteRespuesta.Mensaje = "No se encontró al paciente";
                                //}
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                objPacienteRespuesta.Codigo = 1;
                objPacienteRespuesta.Mensaje = "ocurrió un error al consultar";
            }
          
            return objPacienteRespuesta;
        }

        public string ActualizarAutorizaciones(CredencialServicio credencial, List<int> autorizaciones)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
           
            int intFilas=0;
            string respuesta="";
            if (!UtilService.ValidarCredencial(credencial,out respuesta))  return respuesta;
            
            try
            {
                
                using (SqlConnection conex = new SqlConnection(cadenaConexion))
                {
                    conex.Open();
                    using ( SqlTransaction trans=conex.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("UspWSActualizarAutorizacion", conex, trans))
                            {
                                foreach (int item in autorizaciones)
                                {
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@AutorizacionId", item);
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.CommandTimeout = 0;                                   
                                    intFilas = cmd.ExecuteNonQuery();

                                }
                            }
                            trans.Commit();
                        }
                        catch { trans.Rollback(); respuesta = "ocurrio un error al actualizar"; }
                        
                    }             
                    
                                       
                }
                
            }
            catch (Exception ex)
            {               
                respuesta = ex.Message;               
            }
            return respuesta;
            
        }

        public PacienteRespuesta ObtenerAutorizaciones(CredencialServicio credencial, int establecimientoId)
        {
            PacienteRespuesta objPacienteRespuesta = new PacienteRespuesta();
            List<AutorizacionWS> objAutorizaciones = new List<AutorizacionWS>();
            AutorizacionWS objAutorizacion = new AutorizacionWS();
            //Autorizacion objAutorizacion = null;
            string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            string respuesta = "";
            if (!UtilService.ValidarCredencial(credencial, out respuesta))
            {
                objPacienteRespuesta.Codigo = 4;
                objPacienteRespuesta.Mensaje = respuesta;
                return objPacienteRespuesta;
            }
            try
            {
                using (SqlConnection conex = new SqlConnection(cadena))
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("UspWSObtenerAutorizaciones", conex))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandTimeout = 200;
                        //cmd.Parameters.AddWithValue("@TipoDocumentoId", tipoDocumentoId);
                        //cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                        cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                if (dr.HasRows)
                                {
                                    //dr.Read();
                                    while (dr.Read()){

                                        //dr.NextResult();
                                    //while (dr.Read())
                                    //{
                                        objAutorizacion = new AutorizacionWS();

                                        objAutorizacion.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"]);
                                        objAutorizacion.Fecha = Convert.ToDateTime(dr["Fecha"]);
                                        objAutorizacion.Estado = dr["Estado"].ToString();
                                        objAutorizacion.CodigoAutorizacion = dr["CodigoAutorizacion"].ToString();
                                        objAutorizacion.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
                                        if (dr["Monto"] != DBNull.Value) objAutorizacion.Monto = Convert.ToDecimal(dr["Monto"]);
                                        objAutorizacion.Descripcion = dr["Descripcion"].ToString();
                                        if (dr["FechaInicio"] != DBNull.Value) objAutorizacion.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                                        objAutorizacion.Vigencia = Convert.ToDateTime(dr["Vigencia"]);
                                        objAutorizacion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
                                        objAutorizacion.PacienteId = Convert.ToString(dr["PacienteId"]);
                                        objAutorizacion.TratamiendoId = Convert.ToInt32(dr["TratamiendoId"]);
                                        objAutorizacion.Version = Convert.ToInt32(dr["Version"]);
                                        //objAutorizacion.Observacion = dr["observacion"].ToString();
                                        objAutorizacion.Adicional = Convert.ToBoolean(dr["Adicional"]);
                                        objAutorizacion.Modalidad = Convert.ToString(dr["Modalidad"]);
                                        objAutorizacion.ControlaCantidad = Convert.ToBoolean(dr["ControlaCantidad"]);
                                        objAutorizacion.DiagnosticoAsociado = Convert.ToBoolean(dr["DiagnosticoAsociado"]);
                                        objAutorizacion.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
                                        objAutorizacion.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);

                                        if (dr["FechaSolicitud"] != DBNull.Value) objAutorizacion.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"]);
                                        
                                        objAutorizacion.Tipo = Convert.ToString(dr["Tipo"]);
                                        objAutorizacion.Anulado = Convert.ToBoolean(dr["Anulado"]);
                                        objAutorizacion.Nro_Solicitud = Convert.ToString(dr["Nro_Solicitud"]);
                                        objAutorizacion.PreAutorizado = Convert.ToBoolean(dr["PreAutorizado"]);

                                        objAutorizaciones.Add(objAutorizacion);

                                        //if (dr["FechaInformeMedico"] != DBNull.Value)
                                            //objAutorizacion.FechaInformeMedico = Convert.ToDateTime(dr["FechaInformeMedico"]);
                                        //if (dr["FechaSolicitud"] != DBNull.Value)
                                            //objAutorizacion.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"]);
                                        //if (dr["FechaRespuesta"] != DBNull.Value)
                                            //objAutorizacion.FechaRespuesta = Convert.ToDateTime(dr["FechaRespuesta"]);
                                        //objAutorizacion.Tipo = Convert.ToString(dr["Tipo"]);
                                        //objAutorizacion.Anulado = Convert.ToBoolean(dr["Anulado"]);
                                        //if (dr["Nro_Solicitud"] != DBNull.Value) objAutorizacion.Nro_Solicitud = dr["Nro_Solicitud"].ToString();
                                        //objAutorizacion.Enviado = Convert.ToBoolean(dr["Enviado"]);
                                        //objAutorizacion.PreAutorizado = Convert.ToBoolean(dr["PreAutorizado"]);
                                        //objPaciente.Autorizaciones.Add(objAutorizacion);
                                    //}

                                    //if (objPacientes.Autorizaciones.Count == 0)
                                    //{
                                        //objPacienteRespuesta.Codigo = 5;
                                        //objPacienteRespuesta.Mensaje = "El paciente no tiene autorizaciones";
                                    //}
                                    //else
                                    //{
                                        //objPacienteRespuesta.Codigo = 3;
                                        //objPacienteRespuesta.Mensaje = "Se encontró el paciente ";

                                    //}
                                    //objPacienteRespuesta.Paciente = objPaciente;
                                    }

                                    objPacienteRespuesta.Autorizacion = objAutorizaciones;
                                }
                                else
                                {
                                    objPacienteRespuesta.Codigo = 2;
                                    objPacienteRespuesta.Mensaje = "No existen autorizaciones nuevas a procesar";
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                objPacienteRespuesta.Codigo = 1;
                objPacienteRespuesta.Mensaje = "ocurrió un error al consultar";
            }

            return objPacienteRespuesta;
        }

    }
}
