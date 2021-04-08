using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class AccesoBD
    {
        public static SqlConnection conexion;

        public static SqlConnection getConnnection()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return cn;
        }

        public static SqlConnection AbrirConexion()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool CerrarConexion()
        {
            conexion.Dispose();
            return true;
        }
    }
}
