using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class AtencionCierreDA
    {

        //
        public DataTable GetCantidadAtendidosPorRegion(string region, string mecanismoFinanciamiento, DateTime? fechaProduccionDesde, DateTime? fechaProduccionHasta, bool omitir)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetCantidadAtendidosPorRegion";
                if (!string.Equals(region, string.Empty))
                    cmd.Parameters.AddWithValue("@region", region);
                else
                    cmd.Parameters.AddWithValue("@region", DBNull.Value);
                if(!string.Equals(mecanismoFinanciamiento, string.Empty))
                    cmd.Parameters.AddWithValue("@MecanismoFinanciamiento", mecanismoFinanciamiento);
                else
                    cmd.Parameters.AddWithValue("@MecanismoFinanciamiento", DBNull.Value);
                if (fechaProduccionDesde != null)
                    cmd.Parameters.AddWithValue("@FechaProduccionDesde", fechaProduccionDesde);
                else
                    cmd.Parameters.AddWithValue("@FechaProduccionDesde", DBNull.Value);
                if (fechaProduccionHasta != null)
                    cmd.Parameters.AddWithValue("@FechaProduccionHasta", fechaProduccionHasta);
                else
                    cmd.Parameters.AddWithValue("@FechaProduccionHasta", DBNull.Value);
                cmd.Parameters.AddWithValue("@omitir", omitir);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetCantidadAtendidosPorCategoria(int? categoria, string mecanismoFinanciamiento, DateTime? fechaProduccionDesde, DateTime? fechaProduccionHasta, bool omitir)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetCantidadAtendidosPorCategoria";
                if (categoria != null)
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                else
                    cmd.Parameters.AddWithValue("@categoria", DBNull.Value);
                if (!string.Equals(mecanismoFinanciamiento, string.Empty))
                    cmd.Parameters.AddWithValue("@MecanismoFinanciamiento", mecanismoFinanciamiento);
                else
                    cmd.Parameters.AddWithValue("@MecanismoFinanciamiento", DBNull.Value);
                if (fechaProduccionDesde != null)
                    cmd.Parameters.AddWithValue("@FechaProduccionDesde", fechaProduccionDesde);
                else
                    cmd.Parameters.AddWithValue("@FechaProduccionDesde", DBNull.Value);
                if (fechaProduccionHasta != null)
                    cmd.Parameters.AddWithValue("@FechaProduccionHasta", fechaProduccionHasta);
                else
                    cmd.Parameters.AddWithValue("@FechaProduccionHasta", DBNull.Value);
                cmd.Parameters.AddWithValue("@omitir", omitir);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetCantidadAtendidosPorRegionCategoria(string region, int? categoria, string mecanismoFinanciamiento, DateTime? fechaProduccionDesde, DateTime? fechaProduccionHasta, bool omitir)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetCantidadAtendidosPorRegionCategoria";
                if (!string.Equals(region, string.Empty))
                    cmd.Parameters.AddWithValue("@region", region);
                else
                    cmd.Parameters.AddWithValue("@region", DBNull.Value);
                if (categoria != null)
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                else
                    cmd.Parameters.AddWithValue("@categoria", DBNull.Value);
                if (!string.Equals(mecanismoFinanciamiento, string.Empty))
                    cmd.Parameters.AddWithValue("@mecanismoFinanciamiento", mecanismoFinanciamiento);
                else
                    cmd.Parameters.AddWithValue("@mecanismoFinanciamiento", DBNull.Value);
                if (fechaProduccionDesde != null)
                    cmd.Parameters.AddWithValue("@fechaProduccionDesde", fechaProduccionDesde);
                else
                    cmd.Parameters.AddWithValue("@fechaProduccionDesde", DBNull.Value);
                if (fechaProduccionHasta != null)
                    cmd.Parameters.AddWithValue("@fechaProduccionHasta", fechaProduccionHasta);
                else
                    cmd.Parameters.AddWithValue("@fechaProduccionHasta", DBNull.Value);
                cmd.Parameters.AddWithValue("@omitir", omitir);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }
    }
}
