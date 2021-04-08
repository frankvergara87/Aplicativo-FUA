using FissalBE;
using FissalDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalBL
{
    public partial class ReportesBL
    {
        private ReportesDA odaReportes = null;

        public ReportesBL() {
            odaReportes = new ReportesDA();
        }
        public List<ReporteAtendidosRegion> ReporteAtendidosRegion(int anio) 
        {
            return odaReportes.ReporteAtendidosRegion(anio);
        }
        public List<Comun> ObetenerFechasAtendidosRegion()
        {
            return odaReportes.ObetenerFechasAtendidosRegion();
        }

      

        public List<ReporteConciliacion> ReporteConciliacion(int anio)
        {
            return odaReportes.ReporteConciliacion(anio);
        }

        public List<ReporteConciliacionChart> ReporteConciliacionChart(String numconc, String ipress, String cadena)
        {
            return odaReportes.ReporteConciliacionChart(numconc,ipress,cadena);
        }
        public List<ChartaAbono> ObtenerReporChartabodeb() 
        {
            return odaReportes.ObtenerReporChartabodeb();
        }

        public List<ReporteAtenciones> ObtenerReporChartAtenidos(String idipres, String numconc)
        {
            return odaReportes.ObtenerReporAtenciones(idipres,numconc);
        }


        public List<MantCombo> ObtenerCombos(int op)
        {
            return odaReportes.ObtenerCombos(op);
        }
      
    }
}
