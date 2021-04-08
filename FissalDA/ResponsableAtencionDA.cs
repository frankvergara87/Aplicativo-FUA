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
    public class ResponsableAtencionDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA TIPO RESPONSABLE ATENCION

        public DataTable ResponsableAtencion_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_atenciones_ResponsableAtencion_listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
