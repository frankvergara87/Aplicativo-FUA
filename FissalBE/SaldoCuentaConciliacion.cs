//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FissalBE
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaldoCuentaConciliacion
    {
        public int SaldoCuentaConciliacionId { get; set; }
        public int EstablecimientoId { get; set; }
        public string PacienteId { get; set; }
        public int CadenaId { get; set; }
        public string Estado { get; set; }
        public decimal Abono { get; set; }
        public decimal Debito { get; set; }
        public decimal Saldo { get; set; }
        public Nullable<decimal> ReasignacionPositiva { get; set; }
        public Nullable<decimal> ReasignacionNegativa { get; set; }
        public Nullable<decimal> SaldoFinal { get; set; }
        public Nullable<int> CodigoConciliacion { get; set; }
    }
}
