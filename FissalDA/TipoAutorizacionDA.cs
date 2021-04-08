using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class TipoAutorizacionDA
    {
        SqlCommand cmd;

        public TipoAutorizacionDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA TOTAL TIPOS DE AUTORIZACION 
        public DataTable GetAllTiposAutorizacion()
        {
            cmd.CommandText = "sp2_GetAllTiposAutorizacion";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable TipoAutorizacion_Listar()
        {
            cmd.CommandText = "sp2_Solicitud_TipoAutorizacion_Listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }


        
    }
}
