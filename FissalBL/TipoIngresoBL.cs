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
    public class TipoIngresoBL
    {
        TipoIngresoDA ObjTipoIngresoDA = new TipoIngresoDA();

        public DataTable TipoIngreso_listar()
        {
            return ObjTipoIngresoDA.TipoIngreso_listar();
        }

    }
}
