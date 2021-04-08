using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data;
using System.Data.SqlClient;

namespace FissalDA
{
    public class CategoriaCIEDA
    {
        static SqlCommand cmd;

        public CategoriaCIEDA()
        {
            cmd = new SqlCommand();
        }
        
        //OBTIENE LISTA DIAGNOSTICOS CON COBERTURA
        public DataTable GetCategoriasCobertura()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetCategoriasCobertura";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //OBTIENE LISTA DIAGNOSTICOS X DESCRIPCION O  CATEGORIA_ID
        public DataTable GetDiagnosticosCoberturaPorIdDescripcion(string diagnostico)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetDiagnosticosCoberturaPorIdDescripcion";
                cmd.Parameters.AddWithValue("@Diagnostico", diagnostico);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }


        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        //OBTIENE LISTA ESTABLECIMIENTOS - DROPDOWNLIST - WEB
        public DataTable Categoria_ListaCombo(string FechaActual, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_Categoria_Listar]";
            cmd.Parameters.AddWithValue("@FechaActual", FechaActual);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
