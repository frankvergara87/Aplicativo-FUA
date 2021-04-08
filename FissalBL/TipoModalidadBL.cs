using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class TipoModalidadBL
    {
        private TipoModalidadDA objTipoModalidadDA;
        
        // constructor
        public TipoModalidadBL()
        {
            objTipoModalidadDA = new TipoModalidadDA();
        }

         //OBTIENE LISTA TOTAL TIPO MODALIDAD
        public DataTable GetAllTiposModalidad()
        {
            return objTipoModalidadDA.GetAllTiposModalidad();
        }
    }
}
