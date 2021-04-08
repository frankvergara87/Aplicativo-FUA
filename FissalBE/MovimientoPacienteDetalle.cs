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
    
    public partial class MovimientoPacienteDetalle
    {
        public MovimientoPacienteDetalle()
        {
            this.MovimientoMedicamento = new HashSet<MovimientoMedicamento>();
            this.MovimientoProcedimiento = new HashSet<MovimientoProcedimiento>();
        }
    
        public long Fua { get; set; }
        public int DetalleId { get; set; }
        public Nullable<int> AutorizacionId { get; set; }
        public string EnfermedadIngresoId { get; set; }
        public string TipoDiagnosticoIngresoId { get; set; }
        public Nullable<short> EstadioId { get; set; }
        public Nullable<int> FaseId { get; set; }
        public string EnfermedadEgresoId { get; set; }
        public string TipoDiagnosticoEgresoId { get; set; }
        public Nullable<bool> CMObs { get; set; }
        public Nullable<int> CMTipoObservacionId { get; set; }
        public string CMObsDesc { get; set; }
    
        public virtual Autorizacion Autorizacion { get; set; }
        public virtual Enfermedad Enfermedad { get; set; }
        public virtual Enfermedad Enfermedad1 { get; set; }
        public virtual ICollection<MovimientoMedicamento> MovimientoMedicamento { get; set; }
        public virtual MovimientoPaciente MovimientoPaciente { get; set; }
        public virtual ICollection<MovimientoProcedimiento> MovimientoProcedimiento { get; set; }
        public virtual TipoDiagnostico TipoDiagnostico { get; set; }
        public virtual TipoDiagnostico TipoDiagnostico1 { get; set; }
    }
}