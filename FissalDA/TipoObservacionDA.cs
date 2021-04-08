using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class TipoObservacionDA
    {
        SqlCommand cmd;

        public TipoObservacionDA()
        {
            cmd = new SqlCommand();
        }

        public DataTable GetALLTiposObservacion()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetALLTiposObservacion";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetTiposObservacionAtencion()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetTiposObservacionAtencion";
                return Datos.ObtenerDatosProcedure(cmd);
            }
            
        }

        public DataTable GetTiposObservacionDetalleAtencion()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetTiposObservacionDetalleAtencion";
                return Datos.ObtenerDatosProcedure(cmd);
            }
            
        }

        public DataTable GetTiposObservacionProcedimientoAtencion()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetTiposObservacionProcedimientoAtencion";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetTiposObservacionMedicamentoAtencion()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetTiposObservacionMedicamentoAtencion";
                return Datos.ObtenerDatosProcedure(cmd);
            }
            
        }

    }
}
