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
    
    public partial class Establecimiento
    {
        public Establecimiento()
        {
            this.Autorizacion = new HashSet<Autorizacion>();
            this.EsquemaEstablecimiento = new HashSet<EsquemaEstablecimiento>();
            this.Paquete = new HashSet<Paquete>();
            this.Paquete1 = new HashSet<Paquete>();
            this.TarifarioResumen = new HashSet<TarifarioResumen>();
        }
    
        public int EstablecimientoId { get; set; }
        public Nullable<short> DisaId { get; set; }
        public Nullable<short> RedId { get; set; }
        public Nullable<short> MicroRedId { get; set; }
        public Nullable<short> UnidadEjecutoraId { get; set; }
        public Nullable<short> UbigeoId { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Telefono { get; set; }
        public string RutaServidor { get; set; }
        public bool Convenio { get; set; }
        public string SisId { get; set; }
        public bool Preliquidado { get; set; }
        public bool ProduccionSIS { get; set; }
    
        public virtual ICollection<Autorizacion> Autorizacion { get; set; }
        public virtual ICollection<EsquemaEstablecimiento> EsquemaEstablecimiento { get; set; }
        public virtual MicroRed MicroRed { get; set; }
        public virtual ICollection<Paquete> Paquete { get; set; }
        public virtual ICollection<Paquete> Paquete1 { get; set; }
        public virtual ICollection<TarifarioResumen> TarifarioResumen { get; set; }
        public virtual UnidadEjecutora UnidadEjecutora { get; set; }
        public string Renaes { get; set; }
    }
}
