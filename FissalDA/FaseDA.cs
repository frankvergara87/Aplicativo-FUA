using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalDA
{
    public class FaseDA
    {
        SqlCommand cmd;

        public FaseDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA TOTAL FASES
        public DataTable GetAllFases()
        {
            cmd.CommandText = "sp2_GetAllFases";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        //OBTIENE LISTA FASE - DROPDOWNLIST - WEB

        public DataTable Fase_ListaCombo(string CategoriaId, int Estadio, string FechaActual, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_Fase_Listar]";
            cmd.Parameters.AddWithValue("@CategoriaId", CategoriaId);
            cmd.Parameters.AddWithValue("@Estadio", Estadio);
            cmd.Parameters.AddWithValue("@FechaActual", FechaActual);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);               
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
