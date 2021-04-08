using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;

namespace FissalDA
{
    public class DestinoAseguradoDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA DESTINO ASEGURADO

        public DataTable DestinoAsegurado_Listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_DestinoAsegurado_Listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
