//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FissalBE
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Tarifario
    {
        public int TarifarioId { get; set; }
        public int EstablecimientoId { get; set; }
        public Nullable<short> ultimaversion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string EstadoEnvio { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
    }
}
