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
    public class EstablecimientoDA
    {
        SqlCommand cmd;

        public EstablecimientoDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA TOTAL ESTABLECIMIENTOS
        public DataTable GetEstablecimientosPorIdDescripcionSisId(string establecimiento)
        {
            cmd.CommandText = "sp2_GetEstablecimientosPorIdDescripcionSisId";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Establecimiento", establecimiento);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA TOTAL ESTABLECIMIENTOS CON CONVENIO
        public DataTable GetEstablecimientosConvenio()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_GetEstablecimientosConvenio";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable GetEstablecimientosCierreDig()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_ListarEstablecimientosCierresDig";
            return Datos.ObtenerDatosProcedure(cmd);
        }
        
        
        //OBTIENE LISTA ESTABLECIMIENTOS
        public DataTable Establecimientos_listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_establecimiento_Listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Establecimiento_Consulta()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Solicitud_Establecimiento_Consulta";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA ESTABLECIMIENTOS X CONVENIO
        public DataTable Establecimientos_listarxconvenio()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_establecimiento_listarxconvenio";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE RENAES | DESCRIPCION
        public DataTable Establecimiento_BuscarxRenaesSIS(Establecimiento objEstablecimiento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Establecimiento_BuscarxRenaesSIS";
            cmd.Parameters.AddWithValue("@Codigo", objEstablecimiento.Renaes);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA ESTABLECIMIENTOS RENAES | DESCRIPCION | SIS
        public DataTable Establecimiento_Filtrar(string cadena)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Establecimiento_Filtrar";            
            cmd.Parameters.AddWithValue("@cadena", cadena);
            return Datos.ObtenerDatosProcedure(cmd);
        }

    }
}
