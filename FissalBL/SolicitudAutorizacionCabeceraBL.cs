using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;
using FissalBE;
using System.Transactions;

namespace FissalBL
{
    public class SolicitudAutorizacionCabeceraBL
    {
        private SolicitudAutorizacionCabeceraDA objSolicitudAutorizacionCabeceraDA;
        
        // constructor
        public SolicitudAutorizacionCabeceraBL()
        {
            objSolicitudAutorizacionCabeceraDA = new SolicitudAutorizacionCabeceraDA();
        }

        //OBTIENE LISTA SOLICITUDES DE AUTORIZACION PENDIENTES POR IPRESS
        public List<vw2_SolicitudAutorizacion> GetAllSolicitudesAutorizacion()
        {
            return objSolicitudAutorizacionCabeceraDA.GetAllSolicitudesAutorizacion();
        }

         //OBTIENE LISTA SOLICITUDES DE AUTORIZACION PENDIENTES POR IPRESS
        public List<vw2_SolicitudAutorizacion> GetSolicitudesAutorizacionPorIpress(int establecimientoId)
        {
            return objSolicitudAutorizacionCabeceraDA.GetSolicitudesAutorizacionPorIpress(establecimientoId);            
        }

        public void Rechazar(vw2_SolicitudAutorizacion objSolicitudAutorizacion, List<vw2_SolicitudAutorizacionDetalle> listaSolicitudAutorizacionDetalle, string observaciones)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                objSolicitudAutorizacion.Usuario_Procesa = VariablesGlobales.Login;
                objSolicitudAutorizacionCabeceraDA.Rechazar(objSolicitudAutorizacion);
                SolicitudAutorizacionDetalleDA objSolicitudAutorizacionDetalleDA = new SolicitudAutorizacionDetalleDA();
                foreach (vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle in listaSolicitudAutorizacionDetalle)
                {
                    objSolicitudAutorizacionDetalle.Observaciones = observaciones;
                    objSolicitudAutorizacionDetalleDA.RechazarDetalleSolicitudAutorizacion(objSolicitudAutorizacionDetalle);
                }
                transactionScope.Complete();
            }
        }

        public int Actualizar(vw2_SolicitudAutorizacion objSolicitudAutorizacion)
        {
            return objSolicitudAutorizacionCabeceraDA.Actualizar(objSolicitudAutorizacion);
        }

        public vw2_SolicitudAutorizacion GetSolicitudAutorizacionPorId(string numeroSolicitud)
        {
            return objSolicitudAutorizacionCabeceraDA.GetSolicitudAutorizacionPorId(numeroSolicitud);
        }
    } 
}
