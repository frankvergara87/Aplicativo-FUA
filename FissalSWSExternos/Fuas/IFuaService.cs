using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FissalSWSExternos.Fuas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFuaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFuaService
    {
        [OperationContract]
        string EnviarMovimientoPaciente(CredencialServicio credencial, byte[] archivo,int establecimientoId);
        [OperationContract]
        string EnviarMovimientoPacienteDetalle(CredencialServicio credencial, byte[] archivo, int establecimientoId);
        [OperationContract]
        string EnviarMovimientoProcedimiento(CredencialServicio credencial, byte[] archivo, int establecimientoId);
        [OperationContract]
        string EnviarMovimientoMedicamento(CredencialServicio credencial, byte[] archivo, int establecimientoId);
    }
}
