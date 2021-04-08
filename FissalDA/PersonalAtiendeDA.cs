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
    public class PersonalAtiendeDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA PERSONAL ATIENDE

        public DataTable PersonalAtiende_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "SP2_atenciones_PersonalAtiende_listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }


    }
}
