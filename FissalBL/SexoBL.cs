using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class SexoBL
    {
        private SexoDA objSexoDA;

        // constructor
        public SexoBL()
        {
            objSexoDA = new SexoDA();
        }

        //OBTIENE LISTA TOTAL SEXOS
        public DataTable GetAllSexos()
        {
            return objSexoDA.GetAllSexos();
        }
    }
}
