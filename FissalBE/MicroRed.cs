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
    
    public partial class MicroRed
    {
        public MicroRed()
        {
            this.Establecimiento = new HashSet<Establecimiento>();
        }
    
        public short DisaId { get; set; }
        public short RedId { get; set; }
        public short MicroRedId { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Establecimiento> Establecimiento { get; set; }
        public virtual Red Red { get; set; }
    }
}
