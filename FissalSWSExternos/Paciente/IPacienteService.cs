
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace FissalSWSExternos
{
    [ServiceContract(Namespace="http://fissal.gob.pe/wspaciente/")]
    public interface IPacienteService
    {
        [OperationContract]
        PacienteRespuesta ConsultarPaciente(CredencialServicio credencial, int tipoDocumentoId, string numeroDocumento, int establecimientoId);

        [OperationContract]
        PacienteRespuesta ObtenerPacientes(CredencialServicio credencial,  int establecimientoId);

        [OperationContract]
        string ActualizarAutorizaciones(CredencialServicio credencial, List<int> autorizaciones);

        [OperationContract]
        PacienteRespuesta ObtenerAutorizaciones(CredencialServicio credencial, int establecimientoId);
    }
}
