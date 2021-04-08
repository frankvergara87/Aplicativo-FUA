using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;
using FissalBE;

namespace FissalBL
{
    public class TratamientoBL
    {
        private TratamientoDA objTratamientoDA;
        // constructor
        public TratamientoBL()
        {
            objTratamientoDA = new TratamientoDA();
        }

        public Tratamiento GetTratamientoPorIdVersion(int tratamientoId, DateTime fechaSolicitud)
        {
            return objTratamientoDA.GetTratamientoPorIdVersion(tratamientoId, fechaSolicitud);
        }

        public Tratamiento GetTratamientoPorIdVersion(int tratamientoId, int version)
        {
            return objTratamientoDA.GetTratamientoPorIdVersion(tratamientoId, version);
        }
    }
}
