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
    public class TipoDocumentoDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA TIPO TIPODOCUMENTO

        public DataTable TipoDocumento_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_TipoDocumento_Listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Documento_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_SolicitudAutorizacion_Listar_Documento";
            return Datos.ObtenerDatosProcedure(cmd);
        } 
    }
}
