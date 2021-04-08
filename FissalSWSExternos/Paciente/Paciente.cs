using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FissalSWSExternos
{
    [DataContract]
    public class Paciente
    {
        public Paciente() 
        {
            Autorizaciones = new List<Autorizacion>();
        }

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
        [DataMember]
        public Nullable<DateTime> fecha_defuncion { get; set; }
        [DataMember]
        public Nullable<int> EstablecimientoIdOrigen { get; set; }
        [DataMember]
        public string UsuarioCreacion { get; set; }
        [DataMember]
        public DateTime FechaCreacion { get; set; }
        [DataMember]
        public bool Validado { get; set; }
        [DataMember]
        public string nro_contrato { get; set; }
        [DataMember]
        public string Ubigeo_Residencia { get; set; }
        [DataMember]
        public string Ubigeo_Adscripcion { get; set; }
        [DataMember]
        public List<Autorizacion> Autorizaciones { get; set; }
   
    }
}