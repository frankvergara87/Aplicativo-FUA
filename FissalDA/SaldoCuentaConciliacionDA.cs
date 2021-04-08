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
    public class SaldoCuentaConciliacionDA
    {
        static SqlCommand cmd;

        public SaldoCuentaConciliacionDA()
        {
            cmd = new SqlCommand();
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERTAR SALDO CUENTA CONCILIACION
        public int SaldoCuentaConciliacion_Insert(SaldoCuentaConciliacion objSaldoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_SaldoCuentaConciliacion_Insert";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", objSaldoCuentaConciliacion.CodigoConciliacion);            
            return Datos.Mantenimiento(cmd);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR SALDO CUENTA CONCILIACION
        public DataTable SaldoCuentaConciliacion_Listar(int CodigoConciliacion, int EstablecimientoId, int Nro)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_SaldoCuentaConciliacion_Listar";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", CodigoConciliacion);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@Nro", Nro);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR SALDO CUENTA CONCILIACION X PACIENTE
        public DataTable SaldoCuentaConciliacion_ListarxPaciente(int CodigoConciliacion, int? TipoDocumentoId, string NroDocumento, string Nombres)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_SaldoCuentaConciliacion_ListarxPaciente";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", CodigoConciliacion);

            if (TipoDocumentoId == null)
                cmd.Parameters.AddWithValue("@TipoDocumentoId", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumentoId);

            if (string.IsNullOrEmpty(NroDocumento))
                cmd.Parameters.AddWithValue("@NroDocumento", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NroDocumento", NroDocumento);

            if (string.IsNullOrEmpty(Nombres))
                cmd.Parameters.AddWithValue("@Nombres", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Nombres", Nombres);

            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
