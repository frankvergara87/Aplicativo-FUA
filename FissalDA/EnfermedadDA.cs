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
    public class EnfermedadDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA ENFERMEDADES X CATEGORIA
        public DataTable Enfermedad_listar(Enfermedad ObjEnfermedad)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_enfermedad_EnfermedadXCategoria";
            cmd.Parameters.AddWithValue("@CategoriaId",ObjEnfermedad.CategoriaId);
            cmd.Parameters.AddWithValue("@Descripcion",ObjEnfermedad.Descripcion);
            return Datos.ObtenerDatosProcedure(cmd);

        }


        //OBTIENE LISTA ENFERMEDADES EnfermedadId | CategoriaId | Descripcion
        public DataTable Enfermedad_Verificar(Enfermedad ObjEnfermedad)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Enfermedad_Verificar";
            cmd.Parameters.AddWithValue("@CategoriaId", ObjEnfermedad.CategoriaId);
            cmd.Parameters.AddWithValue("@EnfermedadId", ObjEnfermedad.EnfermedadId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA ENFERMEDADES EnfermedadId | Descripcion | CategoriaId
        public DataTable Enfermedad_FiltrarxCategoriaIdDescripcion(CategoriaCIE objCategoriaCIE)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Enfermedad_FiltrarxCategoriaIdDescripcion";
            cmd.Parameters.AddWithValue("@CategoriaId", objCategoriaCIE.CategoriaId);
            cmd.Parameters.AddWithValue("@Descripcion", objCategoriaCIE.Descripcion);
            return Datos.ObtenerDatosProcedure(cmd);
        }
    }
}
