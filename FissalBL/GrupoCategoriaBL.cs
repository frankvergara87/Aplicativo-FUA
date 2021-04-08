using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;
using System.Data;

namespace FissalBL
{
    public class GrupoCategoriaBL
    {
        private GrupoCategoriaDA objGrupoCategoriaDA;
        
        // constructor
        public GrupoCategoriaBL()
        {
            objGrupoCategoriaDA = new GrupoCategoriaDA();
        }

        public DataTable GetAllGrupoCategoria()
        {
            return objGrupoCategoriaDA.GetAllGrupoCategoria();
        }
    }
}
