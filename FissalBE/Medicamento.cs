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
    
    public partial class Medicamento
    {
        public Medicamento()
        {
            this.AdionalMedicamento = new HashSet<AdionalMedicamento>();
            this.MovimientoMedicamento = new HashSet<MovimientoMedicamento>();
            this.TarifarioMedicamento = new HashSet<TarifarioMedicamento>();
            this.TratamientoMedicamento = new HashSet<TratamientoMedicamento>();
        }
    
        public int MedicamentoId { get; set; }
        public string Descripcion { get; set; }
        public string Concentracion { get; set; }
        public string Presentacion { get; set; }
        public string Petitorio { get; set; }
        public string DescripcionSiga { get; set; }
        public string SisId { get; set; }
        public string MinsaId { get; set; }
        public string InenId { get; set; }
        public string tipo { get; set; }
        public string DigemidId { get; set; }
    
        public virtual ICollection<AdionalMedicamento> AdionalMedicamento { get; set; }
        public virtual ICollection<MovimientoMedicamento> MovimientoMedicamento { get; set; }
        public virtual ICollection<TarifarioMedicamento> TarifarioMedicamento { get; set; }
        public virtual ICollection<TratamientoMedicamento> TratamientoMedicamento { get; set; }
    }
}
