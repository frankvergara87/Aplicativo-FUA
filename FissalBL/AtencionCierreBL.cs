using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;
using System.Data;

namespace FissalBL
{
    public class AtencionCierreBL
    {
        private AtencionCierreDA objAtencionCierreDA;
        
        // constructor
        public AtencionCierreBL()
        {
            objAtencionCierreDA = new AtencionCierreDA();
        }

        public DataTable GetCantidadAtendidosPorRegion(string region, string mecanismoFinanciamiento, DateTime? fechaProduccionDesde, DateTime? fechaProduccionHasta, bool omitir)
        {
            return objAtencionCierreDA.GetCantidadAtendidosPorRegion(region, mecanismoFinanciamiento, fechaProduccionDesde, fechaProduccionHasta, omitir);
        }

        public DataTable GetCantidadAtendidosPorCategoria(int? categoria, string mecanismoFinanciamiento, DateTime? fechaProduccionDesde, DateTime? fechaProduccionHasta, bool omitir)
        {
            return objAtencionCierreDA.GetCantidadAtendidosPorCategoria(categoria, mecanismoFinanciamiento, fechaProduccionDesde, fechaProduccionHasta, omitir);
        }

        public DataTable GetCantidadAtendidosPorRegionCategoria(string region, int? categoria, string mecanismoFinanciamiento, DateTime? fechaProduccionDesde, DateTime? fechaProduccionHasta, bool omitir)
        {
            return objAtencionCierreDA.GetCantidadAtendidosPorRegionCategoria(region, categoria, mecanismoFinanciamiento, fechaProduccionDesde, fechaProduccionHasta, omitir);
        }
    }
}
