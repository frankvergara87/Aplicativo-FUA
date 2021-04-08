using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FissalSWSExternos.Fuas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "FuaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione FuaService.svc o FuaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class FuaService : IFuaService
    {

        public string EnviarMovimientoPaciente(CredencialServicio credencial, byte[] archivo, int establecimientoId)
        {
            string respuesta = "";
            if (UtilService.ValidarCredencial(credencial, out respuesta))
            {
                try
                {
                    string rutaDescarga = ConfigurationManager.AppSettings["rutaDescargaEnviosFua"] + "\\" + establecimientoId.ToString();
                    FisalUtil.Util.GuardarArchivo(rutaDescarga, "MovPac.zip", archivo);
                    respuesta = "Enviado con exito...!";
                }
                catch (Exception ex) { respuesta = ex.Message; }
            }
            return respuesta;
        }

        public string EnviarMovimientoPacienteDetalle(CredencialServicio credencial, byte[] archivo, int establecimientoId)
        {
            string respuesta = "";
            if (UtilService.ValidarCredencial(credencial, out respuesta))
            {
                try
                {
                    string rutaDescarga = ConfigurationManager.AppSettings["rutaDescargaEnviosFua"] + "\\" + establecimientoId.ToString();
                    FisalUtil.Util.GuardarArchivo(rutaDescarga, "MovPacDet.zip", archivo);
                    respuesta = "Enviado con exito...!";
                }
                catch (Exception ex) { respuesta = ex.Message; }
            }
            return respuesta;
        }

        public string EnviarMovimientoProcedimiento(CredencialServicio credencial, byte[] archivo, int establecimientoId)
        {
            string respuesta = "";
            if (UtilService.ValidarCredencial(credencial, out respuesta))
            {
                try
                {
                    string rutaDescarga = ConfigurationManager.AppSettings["rutaDescargaEnviosFua"] + "\\" + establecimientoId.ToString();
                    FisalUtil.Util.GuardarArchivo(rutaDescarga, "MovProc.zip", archivo);
                    respuesta = "Enviado con exito...!";
                }
                catch (Exception ex) { respuesta = ex.Message; }
            }
            return respuesta;
        }

        public string EnviarMovimientoMedicamento(CredencialServicio credencial, byte[] archivo, int establecimientoId)
        {
            string respuesta = "";
            if (UtilService.ValidarCredencial(credencial, out respuesta))
            {
                try
                {
                    string rutaDescarga = ConfigurationManager.AppSettings["rutaDescargaEnviosFua"] + "\\" + establecimientoId.ToString();
                    FisalUtil.Util.GuardarArchivo(rutaDescarga, "MovMed.zip", archivo);
                    respuesta = "Enviado con exito...!";
                }
                catch (Exception ex) { respuesta = ex.Message; }
            }
            return respuesta;
        }
    }
}
