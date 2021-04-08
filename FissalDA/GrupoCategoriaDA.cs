using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class GrupoCategoriaDA
    {
        public DataTable GetAllGrupoCategoria()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAllGrupoCategoria";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }
    }
}
