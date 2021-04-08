using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class SexoDA
    {
        SqlCommand cmd;

        public SexoDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA TOTAL FASES
        public DataTable GetAllSexos()
        {
            cmd.CommandText = "sp2_GetAllSexos";
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
