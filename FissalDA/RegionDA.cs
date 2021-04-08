using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class RegionDA
    {

        public DataTable GetAllRegiones()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAllRegiones";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }
    }
}
