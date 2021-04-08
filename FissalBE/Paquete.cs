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
    
    public partial class Paquete
    {
        public Paquete()
        {
            this.Tratamiento = new HashSet<Tratamiento>();
        }
    
        public int TratamientoId { get; set; }
        public int EstablecimientoId { get; set; }
        public int FaseId { get; set; }
        public string CategoriaId { get; set; }
        public byte EstadioId { get; set; }
        public byte TipoAutorizacionId { get; set; }
        public Nullable<short> ultimaversion { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
    
        public virtual Establecimiento Establecimiento { get; set; }
        public virtual Establecimiento Establecimiento1 { get; set; }
        public virtual Estadio Estadio { get; set; }
        public virtual TipoAutorizacion TipoAutorizacion { get; set; }
        public virtual ICollection<Tratamiento> Tratamiento { get; set; }
    }
}