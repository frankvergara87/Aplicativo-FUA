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
    
    public partial class MovimientoProcedimiento
    {
        public long Fua { get; set; }
        public int DetalleId { get; set; }
        public int ProcedimientoId { get; set; }
        public int ProcedimientoIdNuevo { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public int Prescrito { get; set; }
        public int Consumo { get; set; }
        public int Convenio { get; set; }
        public string obs { get; set; }
        public bool paquete { get; set; }
        public Nullable<bool> CMObs { get; set; }
        public Nullable<int> CMCantidadObservada { get; set; }
        public Nullable<int> CMTipoObservacionId { get; set; }
        public string CMObsDesc { get; set; }
        public Nullable<int> CantidadPagadaSIS { get; set; }
        public virtual MovimientoPacienteDetalle MovimientoPacienteDetalle { get; set; }
        public virtual Procedimiento Procedimiento { get; set; }

        public Nullable<bool> ProveedorTercero { get; set; }
        public string ProveedorCodigo { get; set; }
    }
}
