using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FissalSWSExternos
{
   [DataContract]
    public class PacienteRespuesta : Respuesta
    {  
       [DataMember]
        public Paciente Paciente { get; set; }

       [DataMember]
       public List<AutorizacionWS> Autorizacion { get; set; }

       [DataMember]
        public List<PacienteWS> Pacientes { get; set; }
    }
}