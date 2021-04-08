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
    public class DestinoAseguradoBL
    {
        DestinoAseguradoDA objDestinoAseguradoDA = new DestinoAseguradoDA();

        public DataTable DestinoAsegurado_Listar()
        {
            return objDestinoAseguradoDA.DestinoAsegurado_Listar();
        }
    }
}
