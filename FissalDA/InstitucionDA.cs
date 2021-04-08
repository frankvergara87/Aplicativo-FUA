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
    public class InstitucionDA
    {
        static SqlCommand cmd;

        public InstitucionDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA INSTITUCIONES

        public DataTable Instituciones_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "SP2_atenciones_Institucion_listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }

    }
}
