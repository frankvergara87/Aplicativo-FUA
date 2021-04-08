using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace FissalDA
{
    public static class Datos
    {
        static SqlConnection cn = AccesoBD.getConnnection();
        static SqlDataAdapter dap = new SqlDataAdapter();
        static SqlCommand comando;

        public static DataTable ObtenerDatosProcedure(SqlCommand cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                comando = cmd;
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 1024;
                //dap = new SqlDataAdapter(comando);
                dap.SelectCommand=comando;
                dap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObtenerDatosSql(SqlCommand cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                comando = cmd;
                comando.Connection = cn;
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 1024;
                //dap = new SqlDataAdapter(comando);
                dap.SelectCommand = comando;
                dap.Fill(dt);
                return dt;
            }   
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DbDataReader ObtenerDatosDbDataAdapter(SqlCommand cmd)
        {
            try
            {
                DbDataReader dr;
                comando = cmd;
                comando.Connection = AccesoBD.AbrirConexion();
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 1024;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DbDataReader ObtenerDbDataReaderPorProcedure(SqlCommand cmd)
        {
            try
            {
                DbDataReader dr;
                comando = cmd;
                comando.Connection = AccesoBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 1024;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static SqlDataReader ObtenerDatosProcedureSqlAdapter(SqlCommand cmd)
        {
            comando = cmd;
            comando.Connection = cn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 1024;
            try
            {
                cn.Open();
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Mantenimiento(SqlCommand cmd)
        {
            int registro = 0;

            comando = cmd;
            comando.Connection = cn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 1024;
            try
            {
                cn.Open();
                registro = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                {
                    throw ex;
                }

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return registro;
        }

        public static DateTime GetDate()
        {
            DateTime toDay;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                string sql = "sp2_GetDate";
                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1024;
                    toDay = Convert.ToDateTime(cmd.ExecuteScalar());
                }
            }
            return toDay;
        }

    }
}
