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
    public class TipoRegimenBL
    {
        TipoRegimenDA ObjTipoRegimenDA = new TipoRegimenDA();

        public DataTable TipoRegimen_listar()
        {
            return ObjTipoRegimenDA.TipoRegimen_listar();
        }

    }
}
