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
    public class PacienteDA
    {
        SqlCommand cmd;
        static SqlConnection cn = AccesoBD.getConnnection();
        public PacienteDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA PACIENTES X DOCUMENTO ID 
        public DataTable Paciente_PacienteXDocumentoId(Paciente ObjPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_paciente_PacienteXDocumentoId";
            cmd.Parameters.AddWithValue("@TipoDocumentoId", ObjPaciente.TipoDocumentoId);
            cmd.Parameters.AddWithValue("@DocumentoId", ObjPaciente.NumeroDocumento);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE AUTORIZACION POR ID
        public Paciente GetPacientePorId(string pacienteId)
        {
            string sql = "sp2_GetPacientePorId";
            Paciente objPaciente = null;
            using (SqlConnection cn = AccesoBD.getConnnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objPaciente = CargarPaciente(dr);
                        }
                    }
                    return objPaciente;
                }
            }
        }

        public Paciente GetPacientePorTipoNumeroDocumento(byte tipoDocumentoId, string numeroDocumento)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetPacientePorTipoNumeroDocumento";
                using(SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    Paciente objPaciente = null;
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", tipoDocumentoId);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objPaciente = CargarPaciente(dr);
                        }
                    }
                    return objPaciente;
                }
            }   
        }

        public Paciente GetPacientePorNumeroDocumento(string numeroDocumento)
        {
            using (SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetPacientePorNumeroDocumento";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    Paciente objPaciente = null;
                    cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objPaciente = CargarPaciente(dr);
                        }
                    }
                    return objPaciente;
                }
            }
        }

        public Paciente CargarPaciente(IDataReader dr)
        {
            Paciente objPaciente = new Paciente();
            objPaciente.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
            objPaciente.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
            if (dr["EstablecimientoIdOrigen"] != DBNull.Value)
                objPaciente.EstablecimientoIdOrigen = Convert.ToInt32(dr["EstablecimientoIdOrigen"]);
            objPaciente.Estado = Convert.ToBoolean(dr["Estado"]);
            if (dr["fecha_defuncion"] != DBNull.Value)
                objPaciente.fecha_defuncion = Convert.ToDateTime(dr["fecha_defuncion"]);
            objPaciente.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
            objPaciente.Historia = dr["Historia"].ToString();
            if (dr["Nacimiento"] != DBNull.Value)
                objPaciente.Nacimiento = Convert.ToDateTime(dr["Nacimiento"]);
            objPaciente.Nombres = dr["Nombres"].ToString();
            objPaciente.NumeroDocumento = dr["NumeroDocumento"].ToString();
            objPaciente.OtrosNombres = dr["OtrosNombres"].ToString();
            objPaciente.PacienteId = dr["PacienteId"].ToString();
            objPaciente.SexoId = Convert.ToByte(dr["SexoId"]);
            if (dr["TipoDocumentoId"] != DBNull.Value)
                objPaciente.TipoDocumentoId = Convert.ToByte(dr["TipoDocumentoId"]);
            objPaciente.TipoRegimenId = Convert.ToByte(dr["TipoRegimenId"]);
            objPaciente.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
            objPaciente.Validado = Convert.ToBoolean(dr["Validado"]);
            return objPaciente;
        }

        public Paciente Paciente_PacientexId(string pacienteId, int TipoDocumento, int EstablecimientoId)
        {
            Paciente objPaciente = null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Paciente_PacientexId";
            cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumento);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objPaciente = new Paciente();
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
                }
            }
            return objPaciente;
        }

        public Paciente Paciente_PacientexHistoria(string Historia, int TipoDocumento, int EstablecimientoId)
        {
            Paciente objPaciente = null;
            cmd.Parameters.Clear();
            cmd.CommandText = "sp2_Solicitud_Paciente_PacientexHistoria";
            cmd.Parameters.AddWithValue("@Historia", Historia);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumento);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
            {
                while (dr.Read())
                {
                    objPaciente = new Paciente();
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
                }
            }
            return objPaciente;
        }

        public bool ExistePaciente(string pacienteId)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_ExistePaciente";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (pacienteId != null)
                        cmd.Parameters.AddWithValue("@PacienteId", pacienteId);
                    else
                        cmd.Parameters.AddWithValue("@PacienteId", DBNull.Value);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public bool ExisteDocumentoPaciente(Paciente objPaciente)
        {
            int nrorecord = 0;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_ExisteDocumentoPaciente";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NumeroDocumento", objPaciente.NumeroDocumento);
                    if (objPaciente.TipoDocumentoId != 3)
                    {
                        cmd.Parameters.AddWithValue("@TipoDocumentoId", objPaciente.TipoDocumentoId);
                    }
                    else { cmd.Parameters.AddWithValue("@TipoDocumentoId", 2); }

                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        public Paciente ActualizarPaciente(Paciente objPaciente)
        {
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ActualizarPaciente";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    if (objPaciente.ApellidoMaterno != null)
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", objPaciente.ApellidoMaterno);
                    else
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", objPaciente.ApellidoPaterno);
                    if (objPaciente.fecha_defuncion != null)
                        cmd.Parameters.AddWithValue("@fecha_defuncion", objPaciente.fecha_defuncion);
                    else
                        cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Historia", objPaciente.Historia);
                    cmd.Parameters.AddWithValue("@Nacimiento", objPaciente.Nacimiento);
                    cmd.Parameters.AddWithValue("@Nombres", objPaciente.Nombres);
                    if (objPaciente.OtrosNombres != null)
                        cmd.Parameters.AddWithValue("@OtrosNombres", objPaciente.OtrosNombres);
                    else
                        cmd.Parameters.AddWithValue("@OtrosNombres", DBNull.Value);
                    cmd.Parameters.AddWithValue("@PacienteId", objPaciente.PacienteId);
                    cmd.Parameters.AddWithValue("@SexoId", objPaciente.SexoId);
                    cmd.Parameters.AddWithValue("@TipoRegimenId", objPaciente.TipoRegimenId);
                    cmd.Parameters.AddWithValue("@Validado", objPaciente.Validado);
                    cmd.ExecuteNonQuery();
                }
            }
            return objPaciente;
        }

        public Paciente ActualizarPacienteWeb(Paciente objPaciente)
        {
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ActualizarPaciente2";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    if (objPaciente.ApellidoMaterno != null)
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", objPaciente.ApellidoMaterno);
                    else
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", objPaciente.ApellidoPaterno);
                    if (objPaciente.fecha_defuncion != null)
                        cmd.Parameters.AddWithValue("@fecha_defuncion", objPaciente.fecha_defuncion);
                    else
                        cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Historia", objPaciente.Historia);
                    cmd.Parameters.AddWithValue("@Nacimiento", objPaciente.Nacimiento);
                    cmd.Parameters.AddWithValue("@Nombres", objPaciente.Nombres);
                    if (objPaciente.OtrosNombres != null)
                        cmd.Parameters.AddWithValue("@OtrosNombres", objPaciente.OtrosNombres);
                    else
                        cmd.Parameters.AddWithValue("@OtrosNombres", DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", objPaciente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", objPaciente.TipoDocumentoId);

                    cmd.Parameters.AddWithValue("@SexoId", objPaciente.SexoId);
                    cmd.Parameters.AddWithValue("@TipoRegimenId", objPaciente.TipoRegimenId);
                    cmd.Parameters.AddWithValue("@Validado", objPaciente.Validado);
                    cmd.ExecuteNonQuery();
                }
            }
            return objPaciente;
        }

        public Paciente RegistrarPaciente(Paciente objPaciente)
        {
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_RegistrarPaciente3";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;

                    cmd.Parameters.AddWithValue("@PacienteId", objPaciente.PacienteId);
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", objPaciente.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", objPaciente.ApellidoPaterno);
                    if (objPaciente.ApellidoMaterno != null)
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", objPaciente.ApellidoMaterno);
                    else
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", DBNull.Value);                    
                    cmd.Parameters.AddWithValue("@Nombres", objPaciente.Nombres);
                    if (objPaciente.OtrosNombres != null)
                        cmd.Parameters.AddWithValue("@OtrosNombres", objPaciente.OtrosNombres);
                    else
                        cmd.Parameters.AddWithValue("@OtrosNombres", DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", objPaciente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@TipoRegimenId", objPaciente.TipoRegimenId);
                    cmd.Parameters.AddWithValue("@Nacimiento", objPaciente.Nacimiento); 
                    cmd.Parameters.AddWithValue("@SexoId", objPaciente.SexoId);  
                    cmd.Parameters.AddWithValue("@Historia", objPaciente.Historia);                  
                    cmd.Parameters.AddWithValue("@Estado", objPaciente.Estado);
                    if (objPaciente.fecha_defuncion != null)
                        cmd.Parameters.AddWithValue("@fecha_defuncion", objPaciente.fecha_defuncion);
                    else
                        cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaCreacion", objPaciente.FechaCreacion);
                    objPaciente.PacienteId = objPaciente.NumeroDocumento; 
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", objPaciente.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@Validado", objPaciente.Validado);
                    cmd.ExecuteNonQuery();
                }
            }
            return objPaciente;
        }

        public Paciente RegistrarPacienteWeb(Paciente objPaciente)
        {
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_RegistrarPaciente3";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;

                    cmd.Parameters.AddWithValue("@Paciente", objPaciente.PacienteId);
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", objPaciente.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", objPaciente.ApellidoPaterno);
                    if (objPaciente.ApellidoMaterno != null)
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", objPaciente.ApellidoMaterno);
                    else
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nombres", objPaciente.Nombres);
                    if (objPaciente.OtrosNombres != null)
                        cmd.Parameters.AddWithValue("@OtrosNombres", objPaciente.OtrosNombres);
                    else
                        cmd.Parameters.AddWithValue("@OtrosNombres", DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", objPaciente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@TipoRegimenId", objPaciente.TipoRegimenId);
                    cmd.Parameters.AddWithValue("@Nacimiento", objPaciente.Nacimiento);
                    cmd.Parameters.AddWithValue("@SexoId", objPaciente.SexoId);
                    cmd.Parameters.AddWithValue("@Historia", objPaciente.Historia);
                    cmd.Parameters.AddWithValue("@Estado", objPaciente.Estado);
                    if (objPaciente.fecha_defuncion != null)
                        cmd.Parameters.AddWithValue("@fecha_defuncion", objPaciente.fecha_defuncion);
                    else
                        cmd.Parameters.AddWithValue("@fecha_defuncion", DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaCreacion", objPaciente.FechaCreacion);
                    objPaciente.PacienteId = objPaciente.NumeroDocumento;
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", objPaciente.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@Validado", objPaciente.Validado);
                    objPaciente.PacienteId = objPaciente.NumeroDocumento;

                    cmd.ExecuteNonQuery();

                }
            }
            return objPaciente;
        }



        public DataTable Paciente_ValidadoOff()
        {
            DataTable dt = new DataTable();
            string sql = @"select distinct top 100 PacienteId, Nombres+', '+ApellidoPaterno+' '+ ApellidoMaterno Nombres from Paciente";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt); 
            
            return dt;
        }


        public DataTable GetPacientesBuscadorSelectorPacientes(Paciente objPaciente)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                string sql = "sp2_GetPacientesBuscadorSelectorPacientes";
                using(SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    if(objPaciente.TipoDocumentoId == null)
                        cmd.Parameters.AddWithValue("@TipoDocumentoId",DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@TipoDocumentoId", objPaciente.TipoDocumentoId);
                    if(string.IsNullOrEmpty(objPaciente.NumeroDocumento))
                        cmd.Parameters.AddWithValue("@NumeroDocumento", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NumeroDocumento", objPaciente.NumeroDocumento);
                    if(string.IsNullOrEmpty(objPaciente.ApellidoPaterno))
                        cmd.Parameters.AddWithValue("@ApellidoPaterno", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ApellidoPaterno", objPaciente.ApellidoPaterno);

                    if (string.IsNullOrEmpty(objPaciente.ApellidoMaterno))
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", objPaciente.ApellidoMaterno);
                    if(string.IsNullOrEmpty(objPaciente.Nombres))
                        cmd.Parameters.AddWithValue("@Nombres", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Nombres", objPaciente.Nombres);
                    DataTable dt = new DataTable();
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(dt);
                    return dt;
                }
            }
        }

        public List<int> RegistrarDesdeWS(Paciente bePaciente) 
        {
            List<int> lista =  new List<int>();
           
            using (SqlConnection conex = AccesoBD.getConnnection())
            {
                conex.Open();
                using ( SqlTransaction trans = conex.BeginTransaction())
                {              
               
                try
                {
                    using (SqlCommand cmd = new SqlCommand("UspPacienteInsertar", conex,trans))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;                       
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.AddWithValue("@PacienteId", bePaciente.PacienteId);
                        cmd.Parameters.AddWithValue("@ApellidoMaterno ", bePaciente.ApellidoMaterno);
                        cmd.Parameters.AddWithValue("@ApellidoPaterno ", bePaciente.ApellidoPaterno);
                        cmd.Parameters.AddWithValue("@Nombres ", bePaciente.Nombres);
                        cmd.Parameters.AddWithValue("@OtrosNombres ", bePaciente.OtrosNombres);
                        cmd.Parameters.AddWithValue("@Historia ", bePaciente.Historia);
                        cmd.Parameters.AddWithValue("@SexoId ", bePaciente.SexoId);
                        cmd.Parameters.AddWithValue("@TipoRegimenId ", bePaciente.TipoRegimenId);
                        cmd.Parameters.AddWithValue("@TipoDocumentoId ", bePaciente.TipoDocumentoId);
                        cmd.Parameters.AddWithValue("@NumeroDocumento ", bePaciente.NumeroDocumento);
                        cmd.Parameters.AddWithValue("@Nacimiento ", bePaciente.Nacimiento);
                        cmd.Parameters.AddWithValue("@Estado ", bePaciente.Estado);
                        cmd.Parameters.AddWithValue("@fecha_defuncion ",  bePaciente.fecha_defuncion);
                        cmd.Parameters.AddWithValue("@EstablecimientoIdOrigen ", bePaciente.EstablecimientoIdOrigen);
                        cmd.Parameters.AddWithValue("@UsuarioCreacion ", bePaciente.UsuarioCreacion);
                        cmd.Parameters.AddWithValue("@FechaCreacion ", bePaciente.FechaCreacion);
                        cmd.Parameters.AddWithValue("@Validado ", bePaciente.Validado);
                        cmd.Parameters.AddWithValue("@nro_contrato ", bePaciente.nro_contrato);
                        cmd.Parameters.AddWithValue("@Ubigeo_Residencia ", bePaciente.Ubigeo_Residencia);
                        cmd.Parameters.AddWithValue("@Ubigeo_Adscripcion ", bePaciente.Ubigeo_Adscripcion);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            using(SqlCommand cmdx = new SqlCommand("UspAutorizacionRegistrar", conex,trans))
	                        {                                  
                                foreach (var beAutorizacion in bePaciente.Autorizacion)
                                {
                                    cmdx.Parameters.Clear();
                                    cmdx.CommandType = System.Data.CommandType.StoredProcedure;                               
                                    cmdx.CommandTimeout = 0;
                                    cmdx.Parameters.AddWithValue("@AutorizacionId ", beAutorizacion.AutorizacionId);
                                    cmdx.Parameters.AddWithValue("@Fecha ", beAutorizacion.Fecha);
                                    cmdx.Parameters.AddWithValue("@Estado ", beAutorizacion.Estado);
                                    cmdx.Parameters.AddWithValue("@CodigoAutorizacion ", beAutorizacion.CodigoAutorizacion);
                                    cmdx.Parameters.AddWithValue("@TipoAutorizacionId ", beAutorizacion.TipoAutorizacionId);
                                    cmdx.Parameters.AddWithValue("@Monto ", beAutorizacion.Monto);
                                    cmdx.Parameters.AddWithValue("@Descripcion ", beAutorizacion.Descripcion);
                                    cmdx.Parameters.AddWithValue("@FechaInicio ", beAutorizacion.FechaInicio);
                                    cmdx.Parameters.AddWithValue("@Vigencia ", beAutorizacion.Vigencia);
                                    cmdx.Parameters.AddWithValue("@EstablecimientoId ", beAutorizacion.EstablecimientoId);
                                    cmdx.Parameters.AddWithValue("@PacienteId ", beAutorizacion.PacienteId);
                                    cmdx.Parameters.AddWithValue("@TratamiendoId ", beAutorizacion.TratamiendoId);
                                    cmdx.Parameters.AddWithValue("@Version ", beAutorizacion.Version);
                                    cmdx.Parameters.AddWithValue("@observacion ", beAutorizacion.observacion);
                                    cmdx.Parameters.AddWithValue("@Adicional ", beAutorizacion.Adicional);
                                    cmdx.Parameters.AddWithValue("@Modalidad ", beAutorizacion.Modalidad);
                                    cmdx.Parameters.AddWithValue("@ControlaCantidad ", beAutorizacion.ControlaCantidad);
                                    cmdx.Parameters.AddWithValue("@DiagnosticoAsociado ", beAutorizacion.DiagnosticoAsociado);
                                    cmdx.Parameters.AddWithValue("@UsuarioCreacion ", beAutorizacion.UsuarioCreacion);
                                    cmdx.Parameters.AddWithValue("@FechaCreacion ", beAutorizacion.FechaCreacion);
                                    cmdx.Parameters.AddWithValue("@FechaInformeMedico ", beAutorizacion.FechaInformeMedico);
                                    cmdx.Parameters.AddWithValue("@FechaSolicitud ", beAutorizacion.FechaSolicitud);
                                    cmdx.Parameters.AddWithValue("@FechaRespuesta ", beAutorizacion.FechaRespuesta);
                                    cmdx.Parameters.AddWithValue("@Tipo ", beAutorizacion.Tipo);
                                    cmdx.Parameters.AddWithValue("@Anulado ", beAutorizacion.Anulado);
                                    cmdx.Parameters.AddWithValue("@Nro_Solicitud ", beAutorizacion.Nro_Solicitud);
                                    //cmdx.Parameters.AddWithValue("@Enviado ", beAutorizacion.Enviado);
                                    //cmdx.Parameters.AddWithValue("@PreAutorizado ", beAutorizacion.PreAutorizado);
                                    filas = cmdx.ExecuteNonQuery();
                                    if (filas > 0) lista.Add(beAutorizacion.AutorizacionId);
                                }
                            }

                        }

                    }
                    trans.Commit();
                }
                catch { trans.Rollback(); lista.Clear(); }
              }      
           }
            return lista;
         }
        
    }
}
