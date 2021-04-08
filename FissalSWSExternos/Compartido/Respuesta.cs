using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FissalSWSExternos
{
    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public int Codigo { get; set; }
       [DataMember]
        public string Mensaje { get; set; }
    }
}