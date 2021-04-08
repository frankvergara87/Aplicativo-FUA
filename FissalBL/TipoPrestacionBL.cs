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
    public class TipoPrestacionBL
    {
        TipoPrestacionDA ObjTipoPrestacionDA = new TipoPrestacionDA();        

        public DataTable TipoPrestacion_listar()
        {
            return ObjTipoPrestacionDA.TipoPrestacion_listar();
        }

    }
}
