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
    
    public partial class TratamientoMedicamento
    {
        public int TratamientoId { get; set; }
        public int Version { get; set; }
        public int MedicamentoId { get; set; }
        public short EsquemaId { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
    
        public virtual Esquema Esquema { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual Tratamiento Tratamiento { get; set; }
    }
}