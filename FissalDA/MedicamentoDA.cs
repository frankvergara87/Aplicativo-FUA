using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;

namespace FissalDA
{
    public class MedicamentoDA
    {
        SqlCommand cmd;

        public MedicamentoDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA MEDICAMENTOS X DESCRIPCION O  MEDICAMENTO_ID
        public DataTable GetMedicamentosPorIdDescripcion(string medicamento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetMedicamentosPorIdDescripcion";
                cmd.Parameters.AddWithValue("@medicamento", medicamento);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable Esquema_EsquemaCategoria(string CategoriaId, int EstadioId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Esquema_EsquemaCategoria";
            cmd.Parameters.AddWithValue("@CategoriaId", CategoriaId);
            cmd.Parameters.AddWithValue("@EstadioId", EstadioId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Esquema_EsquemaCategoria2()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Esquema_EsquemaCategoria2";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Medicamento_CostoMedicamento(int MedicamentoId, int EstablecimientoId, int AutorizacionId, string FechaAtencion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medicamento_CostoMedicamento";
            cmd.Parameters.AddWithValue("@medicamentoid", MedicamentoId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@autorizacionid", AutorizacionId);
            cmd.Parameters.AddWithValue("@fecha_atencion", FechaAtencion);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        //OBTIENE MEDICAMENTO - CODIGO | DESCRIPCION
        public DataTable Medicamento_Verificar(Medicamento objMedicamento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medicamento_Verificar";
            cmd.Parameters.AddWithValue("@DigemidId", objMedicamento.DigemidId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA DE MEDICAMENTOS MedicamentoId | Descripcion
        public DataTable Medicamento_Filtrar(Medicamento objMedicamento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medicamento_Filtrar";
            cmd.Parameters.AddWithValue("@cadena", objMedicamento.Descripcion);
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
