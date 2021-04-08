using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class PaqueteDA
    {
        SqlCommand cmd;

        public PaqueteDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE VISTA PAQUETE POR ID
        public vw_paquete GetVWPaquetePorId(int tratamientoId)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                conexion.Open();
                string sql = "sp2_GetVWPaquetePorId";
                using(SqlCommand cmd = new SqlCommand(sql,conexion))
                {
                    cmd.Parameters.AddWithValue("@TratamientoId", tratamientoId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    vw_paquete objPaquete = null;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objPaquete = CargarVwPaquete(dr);
                        }
                    }
                    return objPaquete;
                }
            }
        }

        private vw_paquete CargarVwPaquete(IDataReader dr)
        {
            vw_paquete objPaquete = new vw_paquete();
                    objPaquete.CategoriaId = dr["CategoriaId"].ToString();
                    objPaquete.Descripcion = dr["Descripcion"].ToString();
                    objPaquete.DescripcionEstadio = dr["DescripcionEstadio"].ToString();
                    objPaquete.DescripcionFase = dr["DescripcionFase"].ToString();
                    objPaquete.establecimientodescripcion = dr["establecimientodescripcion"].ToString();
                    objPaquete.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
                    objPaquete.EstadioId = Convert.ToByte(dr["EstadioId"]);
                    objPaquete.FaseId = Convert.ToInt32(dr["FaseId"]);
                    objPaquete.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    objPaquete.TipoAutorizacionDescripcion = dr["TipoAutorizacionDescripcion"].ToString();
                    objPaquete.TipoAutorizacionId = Convert.ToByte(dr["TipoAutorizacionId"]);
                    objPaquete.TratamientoId = Convert.ToInt32(dr["TratamientoId"]);
                    if (dr["ultimaversion"] != DBNull.Value)
                        objPaquete.ultimaversion = Convert.ToInt16(dr["ultimaversion"]);
                    objPaquete.UsuarioCreacion = dr["UsuarioCreacion"].ToString();
            return objPaquete;
        }

        public int GetIdDiagnosticoAsociado(int establecimientoId)
        {
            int nrorecord;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_GetIdDiagnosticoAsociado";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord;
        }

        public bool ExisteIdDiagnosticoAsociado(int establecimientoId)
        {
            int nrorecord;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_ExisteIdDiagnosticoAsociado";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nrorecord > 0;
        }

        //MAESTRO PAQUETE

        //LISTA DE PAQUETES X ESTABLECIMIENTO
        public DataTable Paquete_ListarxEstablecimientoId(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_ListarxEstablecimientoId";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //LISTA DE VERSIONES X TRATAMIENTO
        public DataTable Tratamiento_ListarxTratamientoId(int TratamientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Tratamiento_ListarxTratamientoId";
            cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //LISTA DE PAQUETE MEDICAMENTO
        public DataTable Paquete_PaqueteMedicamentos(int TratamientoId, int Version)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_PaqueteMedicamentos";
            cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);
            cmd.Parameters.AddWithValue("@Version", Version);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //LISTA DE PAQUETE PROCEDIMIENTO
        public DataTable Paquete_PaqueteProcedimientos(int TratamientoId, int Version)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_PaqueteProcedimientos";
            cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);
            cmd.Parameters.AddWithValue("@Version", Version);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //LISTA DE PAQUETES X TRATAMIENTO
        public DataTable Paquete_ListarxTratamientoId(int TratamientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_ListarxTratamientoId";
            cmd.Parameters.AddWithValue("@TratamientoId", TratamientoId);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VERIFICAR PAQUETE DUPLICADO
        public DataTable Paquete_VerificarDuplicadoPaquete(Paquete objPaquete)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_VerificarDuplicadoPaquete";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objPaquete.EstablecimientoId);
            cmd.Parameters.AddWithValue("@CategoriaId", objPaquete.CategoriaId);
            cmd.Parameters.AddWithValue("@EstadioId", objPaquete.EstadioId);
            cmd.Parameters.AddWithValue("@FaseId", objPaquete.FaseId);
            cmd.Parameters.AddWithValue("@TipoAutorizacionId", objPaquete.TipoAutorizacionId);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //INSERTAR PAQUETE
        public int Paquete_Insert(Paquete objPaquete)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_Insert";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objPaquete.EstablecimientoId);
            cmd.Parameters.AddWithValue("@FaseId", objPaquete.FaseId);
            cmd.Parameters.AddWithValue("@CategoriaId", objPaquete.CategoriaId);
            cmd.Parameters.AddWithValue("@EstadioId", objPaquete.EstadioId);
            cmd.Parameters.AddWithValue("@TipoAutorizacionId", objPaquete.TipoAutorizacionId);
            cmd.Parameters.AddWithValue("@UsuarioCreacion", objPaquete.UsuarioCreacion);
            return Datos.Mantenimiento(cmd);
        }

        //UPDATE PAQUETE
        public int Paquete_Update(Paquete objPaquete)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_paq_Paquete_Update";
            cmd.Parameters.AddWithValue("@TratamientoId", objPaquete.TratamientoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", objPaquete.EstablecimientoId);
            cmd.Parameters.AddWithValue("@FaseId", objPaquete.FaseId);
            cmd.Parameters.AddWithValue("@CategoriaId", objPaquete.CategoriaId);
            cmd.Parameters.AddWithValue("@EstadioId", objPaquete.EstadioId);
            cmd.Parameters.AddWithValue("@TipoAutorizacionId", objPaquete.TipoAutorizacionId);            
            return Datos.Mantenimiento(cmd);            
        }

        public DataTable GetVWPaquetePorEstablecimientoId(int establecimientoId)
        {
            using(SqlConnection conexion = AccesoBD.getConnnection())
            {
                string sql = "sp2_GetVWPaquetePorEstablecimientoId";
                using(SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.CommandTimeout = 1024;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

    }
}
