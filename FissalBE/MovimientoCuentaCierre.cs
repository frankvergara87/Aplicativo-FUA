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
    
    public partial class MovimientoCuentaCierre
    {
        public long MovimientoCuentaCierreId { get; set; }
        public int EstablecimientoId { get; set; }
        public string PacienteId { get; set; }
        public int CadenaId { get; set; }
        public int TipoMovimientoId { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> CierreProduccionId { get; set; }
    }
}