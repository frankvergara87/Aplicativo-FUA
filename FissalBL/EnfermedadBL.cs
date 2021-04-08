using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FissalDA;
using FissalBE;

namespace FissalBL
{
    public class EnfermedadBL
    {
        EnfermedadDA ObjEnfermedadDA = new EnfermedadDA();

        //OBTIENE LISTA ENFERMEDADES X CATEGORIA
        public DataTable Enfermedad_listar(Enfermedad ObjEnfermedad)
        {
            return ObjEnfermedadDA.Enfermedad_listar(ObjEnfermedad);
        }

        //OBTIENE LISTA ENFERMEDADES EnfermedadId | CategoriaId | Descripcion
        public DataTable Enfermedad_Verificar(Enfermedad ObjEnfermedad)
        {
            return ObjEnfermedadDA.Enfermedad_Verificar(ObjEnfermedad);
        }

        //OBTIENE LISTA ENFERMEDADES EnfermedadId | Descripcion | CategoriaId
        public DataTable Enfermedad_FiltrarxCategoriaIdDescripcion(CategoriaCIE objCategoriaCIE)
        {
            return ObjEnfermedadDA.Enfermedad_FiltrarxCategoriaIdDescripcion(objCategoriaCIE);
        }
    }
}
