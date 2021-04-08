using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class TarifarioDA
    {
        static SqlCommand cmd;

        public TarifarioDA()
        {
            cmd = new SqlCommand();
        }

        public DataTable Establecimiento_Listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Establecimiento_Listar";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Tarifario_ListarxEstablecimientoId(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Tarifario_ListarxEstablecimientoId";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable TarifarioMedicamento_ListarxEstablecimientoId(int EstablecimientoId, int Version, string Cadena)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_TarifarioMedicamento_ListarxEstablecimientoId";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@Version", Version);
            cmd.Parameters.AddWithValue("@Cadena", Cadena);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable TarifarioProcedimiento_ListarxEstablecimientoId(int EstablecimientoId, int Version, string Cadena)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_TarifarioProcedimiento_ListarxEstablecimientoId";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@Version", Version);
            cmd.Parameters.AddWithValue("@Cadena", Cadena);
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
