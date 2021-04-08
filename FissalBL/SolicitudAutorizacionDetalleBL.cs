using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalDA;
using System.Transactions;

namespace FissalBL
{
    public class SolicitudAutorizacionDetalleBL
    {
        private SolicitudAutorizacionDetalleDA objSolicitudAutorizacionDetalleDA;
        
        // constructor
        public SolicitudAutorizacionDetalleBL()
        {
            objSolicitudAutorizacionDetalleDA = new SolicitudAutorizacionDetalleDA();
        }

         //OBTIENE LISTA SOLICITUDES DE AUTORIZACION PENDIENTES POR IPRESS
        public List<vw2_SolicitudAutorizacionDetalle> GetDetallesSolicitudPorNumeroSolicitud(string numeroSolicitud)
        {
            return objSolicitudAutorizacionDetalleDA.GetDetallesSolicitudPorNumeroSolicitud(numeroSolicitud);
        }

        public bool RechazarDetalleSolicitudAutorizacion(vw2_SolicitudAutorizacion objSolicitudAutorizacion, vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle)
        {
            bool seProcesaronTodos;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                objSolicitudAutorizacionDetalleDA.RechazarDetalleSolicitudAutorizacion(objSolicitudAutorizacionDetalle);
                SolicitudAutorizacionCabeceraDA objSolicitudAutorizacionCabeceraDA = new SolicitudAutorizacionCabeceraDA();
                seProcesaronTodos = objSolicitudAutorizacionDetalleDA.SeProcesaronTodos(objSolicitudAutorizacion.Nro_Solicitud);
                if (seProcesaronTodos)
                {
                    objSolicitudAutorizacion.Fecha_Procesado = DateTime.Today;
                    objSolicitudAutorizacion.Procesado = true;
                }
                objSolicitudAutorizacionCabeceraDA.Actualizar(objSolicitudAutorizacion);
                transactionScope.Complete();
            }
            return seProcesaronTodos;
        }


        public vw2_SolicitudAutorizacionDetalle GetDetalleSolicitudPorNumeroSolicitudId(string numeroSolicitud, int detalleId)
        {
            return objSolicitudAutorizacionDetalleDA.GetDetalleSolicitudPorNumeroSolicitudId(numeroSolicitud, detalleId);
        }
    }
}
