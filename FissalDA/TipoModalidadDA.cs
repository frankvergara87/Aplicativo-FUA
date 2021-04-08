using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class TipoModalidadDA
    {
        SqlCommand cmd;

        public TipoModalidadDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA TOTAL TIPO MODALIDAD
        public DataTable GetAllTiposModalidad()
        {
            cmd.CommandText = "sp2_GetAllTiposModalidad";
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
