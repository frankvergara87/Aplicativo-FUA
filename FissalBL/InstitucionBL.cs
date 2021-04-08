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
    public class InstitucionBL
    {
        InstitucionDA ObjInstitucionDA = new InstitucionDA();

        public DataTable Instituciones_listar()
        {
            return ObjInstitucionDA.Instituciones_listar();
        }

    }
}
