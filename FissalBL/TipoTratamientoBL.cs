using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalDA;

namespace FissalBL
{
    public class TipoTratamientoBL
    {
        private TipoTratamientoDA objTipoTratamientoDA;
        
        // constructor
        public TipoTratamientoBL()
        {
            objTipoTratamientoDA = new TipoTratamientoDA();
        }

        public DataTable TipoTratamiento_Listar()
        {
            return objTipoTratamientoDA.TipoTratamiento_Listar();
        }
    }
}
