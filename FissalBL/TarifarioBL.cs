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
    public class TarifarioBL
    {
        TarifarioDA objTarifarioDA = new TarifarioDA();

        public DataTable Establecimiento_Listar()
        {
            return objTarifarioDA.Establecimiento_Listar();
        }

        public DataTable Tarifario_ListarxEstablecimientoId(int EstablecimientoId)
        {
            return objTarifarioDA.Tarifario_ListarxEstablecimientoId(EstablecimientoId);
        }

        public DataTable TarifarioMedicamento_ListarxEstablecimientoId(int EstablecimientoId, int Version, string Cadena)
        {
            return objTarifarioDA.TarifarioMedicamento_ListarxEstablecimientoId(EstablecimientoId, Version, Cadena);
        }

        public DataTable TarifarioProcedimiento_ListarxEstablecimientoId(int EstablecimientoId, int Version, string Cadena)
        {
            return objTarifarioDA.TarifarioProcedimiento_ListarxEstablecimientoId(EstablecimientoId, Version, Cadena);
        }
    }
}
