using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FissalSWSExternos
{
    [DataContract]
    public class Autorizacion
    {
        [DataMember]
        public int AutorizacionId { get; set; }
        [DataMember]
        public System.DateTime Fecha { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string CodigoAutorizacion { get; set; }
        [DataMember]
        public byte TipoAutorizacionId { get; set; }
        [DataMember]
        public Nullable<decimal> Monto { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FechaInicio { get; set; }
        [DataMember]
        public System.DateTime Vigencia { get; set; }
        [DataMember]
        public int EstablecimientoId { get; set; }
        [DataMember]
        public string PacienteId { get; set; }
        [DataMember]
        public int TratamiendoId { get; set; }
        [DataMember]
        public int Version { get; set; }
        [DataMember]
        public string Observacion { get; set; }
        [DataMember]
        public bool Adicional { get; set; }
        [DataMember]
        public string Modalidad { get; set; }
        [DataMember]
        public bool ControlaCantidad { get; set; }
        [DataMember]
        public bool DiagnosticoAsociado { get; set; }
        [DataMember]
        public string UsuarioCreacion { get; set; }
        [DataMember]
        public System.DateTime FechaCreacion { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FechaInformeMedico { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FechaRespuesta { get; set; }
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public bool Anulado { get; set; }
        [DataMember]
        public string Nro_Solicitud { get; set; }
        [DataMember]
        public bool Enviado { get; set; }
        [DataMember]
        public bool PreAutorizado { get; set; }
    }
}