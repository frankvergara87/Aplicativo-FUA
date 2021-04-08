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
    public class TipoIngresoDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA TIPO INGRESO

        public DataTable TipoIngreso_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "SP2_atenciones_TipoIngreso_listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }  
    }
}
