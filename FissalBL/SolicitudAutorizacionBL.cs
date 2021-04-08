using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FissalDA;
using FissalBE;
using System.Transactions;

namespace FissalBL
{
    public class SolicitudAutorizacionBL
    {
        private SolicitudAutorizacionDA objSolicitudAutorizacionDA;
        
        // constructor
        public SolicitudAutorizacionBL()
        {
            objSolicitudAutorizacionDA = new SolicitudAutorizacionDA();
        }

        public DataTable SolicitudAutorizacion_Listar()
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Listar();
        }

        /* \************************************************ WEB *******/
        /*  \**********************************************************/
        
        public int SolicitudAutorizacion_Grabar(SolicitudAutorizacion objSolicitudBE)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Grabar(objSolicitudBE);
        }

        public int SolicitudAutorizacion_Actualizar(SolicitudAutorizacion objSolicitudBE)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Actualizar(objSolicitudBE);
        }


        public int SolicitudAutorizacionDet_Grabar(SolicitudAutorizacion objSolicitudBE)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacionDet_Grabar(objSolicitudBE);
        }

        //public int SolicitudAutorizacionDet_Validar(string PacienteId, int TratamientoId, int EstablecimientoId)
        //{
        //    return objSolicitudAutorizacionDA.SolicitudAutorizacionDet_Validar(PacienteId, TratamientoId, EstablecimientoId);
        //}


        public int SolicitudAutorizacionDet_Validar(string PacienteId, int TratamientoId, int EstablecimientoId, int FaseId)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacionDet_Validar(PacienteId, TratamientoId, EstablecimientoId, FaseId);
        }

        public int SolicitudAutorizacion_Actualizar(string NroSolicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Actualizar(NroSolicitud);
        }


        public DataTable SolicitudAutorizacion_ListarGrilla(SolicitudAutorizacion objSolicitudAutorizacion, string Fecha)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_ListarGrilla(objSolicitudAutorizacion, Fecha);
        }

        public DataTable SolicitudAutorizacionDetalle_ListarGrilla(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacionDetalle_ListarGrilla(Nro_Solicitud);
        }

        public SolicitudAutorizacion SolicitudAutorizacion_Cabecera_Listar(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Cabecera_Listar(Nro_Solicitud);
        }

        public SolicitudAutorizacionDetalle SolicitudAutorizacionDetalleListar(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacionDetalleListar(Nro_Solicitud);
        }


        // OBTENER VALORES

        public int ObtenerNroSolicitud()
        {
            return objSolicitudAutorizacionDA.ObtenerNroSolicitud();
        }

        public int ObtenerNroDetalle(string NroSolicitud)
        {
            return objSolicitudAutorizacionDA.ObtenerNroDetalle(NroSolicitud);
        }

        public SolicitudAutorizacion Obtener_TipoAutorizacion(int EstablecimientoId, string Categoria, int Estadio, int Fase)
        {
            return objSolicitudAutorizacionDA.Obtener_TipoAutorizacion(EstablecimientoId, Categoria, Estadio, Fase);
        }

        public SolicitudAutorizacion Obtener_Tratamiento(int TipoAutorizacionId, int EstablecimientoId, string Categoria, int Estadio, int Fase)
        {
            return objSolicitudAutorizacionDA.Obtener_Tratamiento(TipoAutorizacionId, EstablecimientoId, Categoria, Estadio, Fase);
        }

        public SolicitudAutorizacion SolicitudAutorizacion_Obtener_Completo(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Obtener_Completo(Nro_Solicitud);
        }


        public DataTable SolicitudAutorizacionDet_Obtener_Completo(string Nro_Solicitud, string Categoria, int Estadio)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacionDet_Obtener_Completo(Nro_Solicitud, Categoria, Estadio);
        }

        public DataTable SolicitudAutorizacion_Detalle_Completo(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Detalle_Completo(Nro_Solicitud);
        }


        public int SolicitudAutorizacion_Eliminar(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Eliminar(Nro_Solicitud);       
        }

        public int SolicitudAutorizacion_Eliminar_Todo(string Nro_Solicitud)
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Eliminar_Todo(Nro_Solicitud);
        }

        public DataTable SolicitudAutorizacion_Reportes(int EstablecimientoId, string FechaD, string FechaH) 
        {
            return objSolicitudAutorizacionDA.SolicitudAutorizacion_Reportes(EstablecimientoId, FechaD, FechaH);
        }



        /***************************************************** VALIDACION TRANSACTION******/

        public void RegistrarSolicitud(List<SolicitudAutorizacion> resultados, SolicitudAutorizacion objSolicitudBE, SolicitudAutorizacion objSolicitudDetBE)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                #region 'Registra Cabecera'

                int Cont = objSolicitudAutorizacionDA.ObtenerNroSolicitud();
                objSolicitudBE.Nro_Solicitud = Convert.ToString(Cont + 1);
                objSolicitudAutorizacionDA.SolicitudAutorizacion_Grabar(objSolicitudBE);

                #endregion

                #region 'Registra Detalles'

                foreach (SolicitudAutorizacion ListAprob in resultados)
                { 
                    if (ListAprob.Observaciones == "Guardado")
                    {
                        objSolicitudDetBE.Nro_Solicitud = objSolicitudBE.Nro_Solicitud; // Grabo con el Id del Maestro Nro Solicitud 
                        objSolicitudDetBE.PacienteId = objSolicitudBE.PacienteId;
                        objSolicitudDetBE.EstablecimientoId = objSolicitudBE.EstablecimientoId;
                        objSolicitudDetBE.CategoriaId = ListAprob.CategoriaId;
                        objSolicitudDetBE.EstadioId = Convert.ToInt32(ListAprob.EstadioId);
                        objSolicitudDetBE.FaseId = Convert.ToInt32(ListAprob.FaseId.ToString()); 
                        objSolicitudDetBE.Adicional = Convert.ToBoolean(0);

                        SolicitudAutorizacion objTipoAutorizacion = new SolicitudAutorizacion();
                        objTipoAutorizacion = objSolicitudAutorizacionDA.Obtener_TipoAutorizacion(objSolicitudDetBE.EstablecimientoId, objSolicitudDetBE.CategoriaId, objSolicitudDetBE.EstadioId, objSolicitudDetBE.FaseId);
                        objSolicitudDetBE.TipoAutorizacionId = objTipoAutorizacion.TipoAutorizacionId;
                        objSolicitudDetBE.TratamientoId = objTipoAutorizacion.TratamientoId;
                        objSolicitudDetBE.Vigencia = objTipoAutorizacion.Vigencia;
                        objSolicitudDetBE.Version = objTipoAutorizacion.Version;


                        int ContDet = objSolicitudAutorizacionDA.ObtenerNroDetalle(objSolicitudBE.Nro_Solicitud);
                        objSolicitudDetBE.DetalleId = ContDet + 1;
                        objSolicitudDetBE.Nro_Solicitud = objSolicitudBE.Nro_Solicitud; 
                        objSolicitudAutorizacionDA.SolicitudAutorizacionDet_Grabar(objSolicitudDetBE);
                    }
                }
                #endregion
               
                transactionScope.Complete();
            }
        }

        public void ActualizarSolicitud(string NroSolicitud,SolicitudAutorizacion objSolicitudBE, SolicitudAutorizacion objSolicitudDetBE) 
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                #region 'Elimino Detalles Anteriores'

                objSolicitudAutorizacionDA.SolicitudAutorizacion_Eliminar(NroSolicitud);

                #endregion

                #region 'Actualiza Cabecera'

                objSolicitudAutorizacionDA.SolicitudAutorizacion_Actualizar(objSolicitudBE);


                #endregion

                #region 'Actualiza Detalle'

                int ContDet = objSolicitudAutorizacionDA.ObtenerNroDetalle(objSolicitudBE.Nro_Solicitud);
                objSolicitudDetBE.DetalleId = ContDet + 1;

                objSolicitudAutorizacionDA.SolicitudAutorizacionDet_Grabar(objSolicitudDetBE);

                #endregion

                transactionScope.Complete();
            }
        }
        
        /***************************************************************/





    }
}
