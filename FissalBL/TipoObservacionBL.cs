using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class TipoObservacionBL
    {
        private TipoObservacionDA objTipoObservacionDA;
        public TipoObservacionBL()
        {
            objTipoObservacionDA = new TipoObservacionDA();
        }

        public DataTable GetALLTiposObservacion()
        {
            return objTipoObservacionDA.GetALLTiposObservacion();
        }

        public DataTable GetTiposObservacionAtencion()
        {
            return objTipoObservacionDA.GetTiposObservacionAtencion();
        }

        public DataTable GetTiposObservacionDetalleAtencion()
        {
            return objTipoObservacionDA.GetTiposObservacionDetalleAtencion();
        }

        public DataTable GetTiposObservacionProcedimientoAtencion()
        {
            return objTipoObservacionDA.GetTiposObservacionProcedimientoAtencion();
        }

        public DataTable GetTiposObservacionMedicamentoAtencion()
        {
            return objTipoObservacionDA.GetTiposObservacionMedicamentoAtencion();
        }
    }
}
