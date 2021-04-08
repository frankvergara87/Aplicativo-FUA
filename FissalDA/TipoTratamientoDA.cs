using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class TipoTratamientoDA
    {
        SqlCommand cmd;

        public TipoTratamientoDA()
        {
            cmd = new SqlCommand();
        }

        public DataTable TipoTratamiento_Listar()
        {
            cmd.CommandText = "sp2_Solicitud_TipoTratamiento_Listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }

    }
}
