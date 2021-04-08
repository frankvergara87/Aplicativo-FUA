using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class EstadioDA
    {
        SqlCommand cmd;

        public EstadioDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA TOTAL ESTADIOS

        public DataTable GetAllEstadios()
        {
            cmd.CommandText = "sp2_GetAllEstadios";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        //OBTIENE LISTA ESTADIO - DROPDOWNLIST - WEB
        public DataTable Estadio_ListaCombo(string CategoriaId, string FechaActual, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_Estadio_Listar]";
            cmd.Parameters.AddWithValue("@CategoriaId", CategoriaId);
            cmd.Parameters.AddWithValue("@FechaActual", FechaActual);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);           
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
