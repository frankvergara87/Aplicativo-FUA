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
    
    public partial class EsquemaEstablecimiento
    {
        public short EsquemaId { get; set; }
        public string CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public int EstablecimientoId { get; set; }
        public bool habitual { get; set; }
        public bool opcional { get; set; }
        public bool alternativo { get; set; }
        public Nullable<byte> EstadioId { get; set; }
        public bool Activo { get; set; }
        public Nullable<short> id { get; set; }
    
        public virtual CategoriaCIE CategoriaCIE { get; set; }
        public virtual Establecimiento Establecimiento { get; set; }
    }
}
