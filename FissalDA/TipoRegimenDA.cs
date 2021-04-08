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
    public class TipoRegimenDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA TIPO REGIMEN

        public DataTable TipoRegimen_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "SP2_atenciones_TipoRegimen_listar";
            return Datos.ObtenerDatosProcedure(cmd);
        } 
    }
}
