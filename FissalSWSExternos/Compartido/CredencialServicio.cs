using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FissalSWSExternos
{
  [DataContract]
    public class CredencialServicio
    {
        [DataMember]
        public string UserName { get; set; }
       [DataMember]
        public string Password { get; set; }
    }
}