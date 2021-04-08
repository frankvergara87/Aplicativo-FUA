using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FissalSWSExternos
{

    [DataContract]
    public class PacienteWS
    {

        [DataMember]
        public string PacienteId { get; set; }
        [DataMember]
        public Nullable<byte> TipoDocumentoId { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string OtrosNombres { get; set; }
        [DataMember]
        public string NumeroDocumento { get; set; }
        [DataMember]
        public byte TipoRegimenId { get; set; }
        [DataMember]
        public Nullable<DateTime> Nacimiento { get; set; }
        [DataMember]
        public byte SexoId { get; set; }
        [DataMember]
        public string Historia { get; set; }
        [DataMember]
        public bool Estado { get; set; }

    }
}