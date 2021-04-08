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
    public class TipoAutorizacionBL
    {
        private TipoAutorizacionDA objTipoAutorizacionDA;
        
        // constructor
        public TipoAutorizacionBL()
        {
            objTipoAutorizacionDA = new TipoAutorizacionDA();
        }

         //OBTIENE LISTA TOTAL TIPOS DE AUTORIZACION
        public DataTable GetAllTiposAutorizacion()
        {
            return objTipoAutorizacionDA.GetAllTiposAutorizacion();
        }

        public DataTable TipoAutorizacion_Listar()
        {
            return objTipoAutorizacionDA.TipoAutorizacion_Listar();
        }
    }
}
