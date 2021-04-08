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
    public class LugarAtencionBL
    {
        LugarAtencionDA ObjLugarAtencionDA = new LugarAtencionDA();

        public DataTable LugarAtencion_listar()
        {
            return ObjLugarAtencionDA.LugarAtencion_listar();
        }

    }
}
