using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalBE
{
    public partial class ReporteAtendidosRegion
    {
        public int Anio { get; set; }
        public string Region { get; set; }
        public int TotalAtendidos { get; set; }
        public int TotalAtenciones { get; set; }
        public decimal TotalTransferencias { get; set; }
        public int DentroAtendidos { get; set; }
        public int DentroAtenciones { get; set; }
        public decimal DentroTransferencias { get; set; }
        public int FueraAtendidos { get; set; }
        public int FueraAtenciones { get; set; }
        public decimal FueraTransferencias { get; set; }
    }

    public partial class ReporteConciliacion
    {
        public int ipress { get; set; }
        public string nombipress { get; set; }
        public string desccadena { get; set; }
        public decimal abono { get; set; }
        public decimal debito { get; set; }
        public decimal sinicial { get; set; }
        public decimal rpositiva { get; set; }
        public decimal rnegativa { get; set; }
        public decimal reasignacion { get; set; }
        public decimal sfinal { get; set; }
        public decimal codigoconciliacion { get; set; } 
    }

    public partial class ChartaAbono
    {
        public string ipress { get; set; }
        public decimal abono { get; set; }
        public decimal debito { get; set; }

    }

    public partial class ReporteConciliacionChart
    {
        public string ipress { get; set; }
        public string nombipress { get; set; }
        public decimal abono { get; set; }
        public decimal debito { get; set; }
        public decimal sinicial { get; set; }
        public decimal rpositiva { get; set; }
        public decimal rnegativa { get; set; }
        public decimal reasignacion { get; set; }
        public decimal sfinal { get; set; }
        public int codigoconciliacion { get; set; }
    }

    public partial class ReporteAtenciones
    {
        public string anio { get; set; }
        public decimal atenciones { get; set; }
        public decimal atendidos { get; set; }
    
    }


    public partial class MantCombo
    {
        public string codigo { get; set; }
        public string valor { get; set; }
        

    }
}
