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
    public class TipoPrestacionDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA TIPO PRESTACION

        public DataTable TipoPrestacion_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_atenciones_TipoPrestacion_listar";
            return Datos.ObtenerDatosProcedure(cmd);
        } 
    }
}
