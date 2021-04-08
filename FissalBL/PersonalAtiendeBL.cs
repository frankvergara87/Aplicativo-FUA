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
    public class PersonalAtiendeBL
    {
        PersonalAtiendeDA ObjPersonalAtiendeDA = new PersonalAtiendeDA();

        public DataTable PersonalAtiende_listar()
        {
            return ObjPersonalAtiendeDA.PersonalAtiende_listar();
        }

    }
}
