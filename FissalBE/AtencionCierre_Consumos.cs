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
    
    public partial class AtencionCierre_Consumos
    {
        public string TipoConsumo { get; set; }
        public int IdNUmReg { get; set; }
        public int IdNumRegAte { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<double> CantidadAprobada { get; set; }
        public Nullable<decimal> PrecioAplicado { get; set; }
        public string TipoPrecio { get; set; }
        public Nullable<decimal> PrecioAplicado_Repos { get; set; }
        public Nullable<int> numregPra_Repos { get; set; }
        public string tipoprecio_Repos { get; set; }
        public string EsFissal { get; set; }
        public string tipoprecio_ant { get; set; }
        public string tipo_pago { get; set; }
        public string estado_observacion { get; set; }
        public string ate_ue { get; set; }
        public string mesProd_consumo { get; set; }
    }
}
