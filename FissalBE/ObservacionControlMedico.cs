using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalBE
{
    public class ObservacionControlMedico
    {
        public string DescripcionDetalle { get; set; }
        public Nullable<int> CantidadDetalle { get; set; }
        public Nullable<int> TipoObservacion { get; set; }
        public Nullable<int> CantidadObservada { get; set; }
        public string DescripcionObservacion { get; set; }
    }
}
