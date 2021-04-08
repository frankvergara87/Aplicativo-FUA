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
    public class ResponsableAtencionBL
    {
        ResponsableAtencionDA ObjResponsableAtencionDA = new ResponsableAtencionDA();

        public DataTable ResponsableAtencion_listar()
        {
            return ObjResponsableAtencionDA.ResponsableAtencion_listar();
        }

    }
}
