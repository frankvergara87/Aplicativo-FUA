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
    
    public partial class vw_SolicitudPendiente
    {
        public string Nro_Solicitud { get; set; }
        public string Establecimiento { get; set; }
        public string diagnostico { get; set; }
        public string PacienteId { get; set; }
        public string paciente { get; set; }
        public System.DateTime fechaSolicitud { get; set; }
        public byte TipoAutorizacionId_solicita { get; set; }
        public string TipoAutorizacionSolicitada { get; set; }
        public byte EstadioId { get; set; }
        public int FaseId { get; set; }
        public string EstadoAprobacion { get; set; }
        public int EstablecimientoId { get; set; }
    }
}
