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
    public class AutorizacionBL
    {

        private AutorizacionDA objAutorizacionDA;
        
        // constructor
        public AutorizacionBL()
        {
            objAutorizacionDA = new AutorizacionDA();
        }


        public DataTable Autorizacion_PacienteIdxEstablecimientoId(Autorizacion ObjAutorizacion)
        {
            return objAutorizacionDA.Autorizacion_PacienteIdxEstablecimientoId(ObjAutorizacion);
        }

        public DataTable Autorizacion_ListarxAutorizacionId(Autorizacion autorizacion)
        {
            return AutorizacionDA.Autorizacion_ListarxAutorizacionId(autorizacion);
              
        }

        // OBTIENE AUTORIZACIONES POR CONSULTA SQL
        public DataTable GetAllAutorizacionPorConsultaSql(string consultaSql)
        {
            return objAutorizacionDA.GetAllAutorizacionPorConsultaSql(consultaSql);
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR AÑO
        public DataTable GetCantidadMontoAutorizacionesPorAño()
        {
            return objAutorizacionDA.GetCantidadMontoAutorizacionesPorAño();
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR AÑO Y MES
        public DataTable GetCantidadMontoAutorizacionesPorAñoMes()
        {
            return objAutorizacionDA.GetCantidadMontoAutorizacionesPorAñoMes();
        }

        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR IPRESS
        public DataTable GetCantidadMontoAutorizacionesPorIPRESS()
        {
            return objAutorizacionDA.GetCantidadMontoAutorizacionesPorIPRESS();
        }
        
        // OBTIENE CANTIDAD Y MONTO DE AUTORIZACIONES POR PACIENTE
        public DataTable GetCantidadMontoAutorizacionesPorPaciente()
        {
            return objAutorizacionDA.GetCantidadMontoAutorizacionesPorPaciente();
        }

        //OBTIENE AUTORIZACION POR ID
        public Autorizacion GetAutorizacionPorId(int autorizacionId)
        {
            return objAutorizacionDA.GetAutorizacionPorId(autorizacionId);
        }

        //ANULA AUTORIZACION POR ID
        public int AnularAutorizacionPorId(int autorizacionId)
        {
            return objAutorizacionDA.AnularAutorizacionPorId(autorizacionId);
        }

        //LISTA AUTORIZACIONES - PACIENTE | ESTABLECIMIENTO
        public DataTable ListaAutorizacionesxIdPacientexSoloEstablecimiento(string PacienteId, int TipoDocumentoId, int EstablecimientoId)
        {
            return objAutorizacionDA.ListaAutorizacionesxIdPacientexSoloEstablecimiento(PacienteId, TipoDocumentoId, EstablecimientoId);
        }

        //LISTA AUTORIZACIONES - PACIENTE | ESTABLECIMIENTO - OTROS ESTABLECIMIENTOS
        public DataTable ListaAutorizacionesxIdPacientexOtroEstablecimiento(string PacienteId, int TipoDocumentoId, int EstablecimientoId)
        {
            return objAutorizacionDA.ListaAutorizacionesxIdPacientexOtroEstablecimiento(PacienteId, TipoDocumentoId, EstablecimientoId);
        }

        public bool RegistrarAutorizacion(Paciente objPaciente, Autorizacion objAutorizacion, vw2_SolicitudAutorizacion objSolicitudAutorizacion, vw2_SolicitudAutorizacionDetalle objSolicitudAutorizacionDetalle)
        {
            bool seProcesaronTodos;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                #region 'Guardar Paciente'

                PacienteBL objPacienteBL = new PacienteBL();
                objPaciente = objPacienteBL.Guardar(objPaciente);

                #endregion

                #region 'Registrar Autorizacion'

                objAutorizacion.PacienteId = objPaciente.PacienteId;
                objAutorizacion.FechaInicio = objAutorizacion.Fecha;
                TratamientoBL objTratamientoBL = new TratamientoBL();
                Tratamiento objTratamiento2 = objTratamientoBL.GetTratamientoPorIdVersion(objAutorizacion.TratamiendoId, objSolicitudAutorizacion.Fecha_Solicitud);
                if (objAutorizacionDA.ExisteAutorizacion(objTratamiento2.CadenaId, objSolicitudAutorizacionDetalle.FaseId, objAutorizacion.EstablecimientoId, objAutorizacion.PacienteId))
                    throw new Exception("No se registro la autorizacion, paciente ya tiene el tratamiento autorizado");
                else
                    objAutorizacion = objAutorizacionDA.RegistrarAutorizacion(objAutorizacion);

                #endregion

                #region 'Aprobar Detalle Solicitud'

                SolicitudAutorizacionDetalleDA objSolicitudAutorizacionDetalleDA = new SolicitudAutorizacionDetalleDA();
                objSolicitudAutorizacionDetalle.AutorizacionId = objAutorizacion.AutorizacionId;
                objSolicitudAutorizacionDetalleDA.AprobarDetalleSolicitudAutorizacion(objSolicitudAutorizacionDetalle);

                #endregion

                #region 'Actualizar Solicitud'
                
                SolicitudAutorizacionCabeceraDA objSolicitudAutorizacionCabeceraDA = new SolicitudAutorizacionCabeceraDA();
                seProcesaronTodos = objSolicitudAutorizacionDetalleDA.SeProcesaronTodos(objSolicitudAutorizacion.Nro_Solicitud);
                if (seProcesaronTodos)
                {
                    objSolicitudAutorizacion.Fecha_Procesado = DatosBL.GetDate();
                    objSolicitudAutorizacion.Procesado = true;
                }
                objSolicitudAutorizacionCabeceraDA.Actualizar(objSolicitudAutorizacion);

                #endregion

                #region 'Registrar DX Asociado'

                PaqueteBL objPaqueteBL = new PaqueteBL();
                if (objPaqueteBL.ExisteIdDiagnosticoAsociado(objSolicitudAutorizacion.EstablecimientoId))
                {
                    int tratamientoId = objPaqueteBL.GetIdDiagnosticoAsociado(objSolicitudAutorizacion.EstablecimientoId);
                    if (!objAutorizacionDA.ExisteDiagnosticoAsociado(tratamientoId, objSolicitudAutorizacion.EstablecimientoId, objPaciente.PacienteId))
                    {
                        Tratamiento objTratamiento = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, objSolicitudAutorizacion.Fecha_Solicitud);
                        Autorizacion objAutorizacionDxAsociado = new Autorizacion();
                        objAutorizacionDxAsociado.Adicional = false;
                        objAutorizacionDxAsociado.Anulado = false;
                        objAutorizacionDxAsociado.ControlaCantidad = false;
                        objAutorizacionDxAsociado.DiagnosticoAsociado = true;
                        objAutorizacionDxAsociado.EstablecimientoId = objSolicitudAutorizacion.EstablecimientoId;
                        objAutorizacionDxAsociado.Estado = "A";
                        objAutorizacionDxAsociado.Fecha = objAutorizacion.Fecha;
                        objAutorizacionDxAsociado.FechaInicio = objAutorizacionDxAsociado.Fecha;
                        objAutorizacionDxAsociado.Modalidad = "R";
                        objAutorizacionDxAsociado.Monto = objTratamiento.Monto;
                        objAutorizacionDxAsociado.PacienteId = objPaciente.PacienteId;
                        objAutorizacionDxAsociado.Tipo = "P";
                        objAutorizacionDxAsociado.TipoAutorizacionId = Convert.ToByte(objTratamiento.TipoAutorizacionId);
                        objAutorizacionDxAsociado.TratamiendoId = objTratamiento.TratamientoId;
                        objAutorizacionDxAsociado.UsuarioCreacion = objAutorizacion.UsuarioCreacion;
                        objAutorizacionDxAsociado.Version = objTratamiento.Version;
                        objAutorizacionDxAsociado.Nro_Solicitud = objSolicitudAutorizacion.Nro_Solicitud;
                        objAutorizacionDxAsociado.FechaSolicitud = objSolicitudAutorizacion.Fecha_Solicitud;
                        objAutorizacionDxAsociado.Vigencia = Convert.ToDateTime(objAutorizacionDxAsociado.FechaInicio).AddMonths(Convert.ToInt32(objTratamiento.Vigencia));
                        objAutorizacionDA.RegistrarAutorizacion(objAutorizacionDxAsociado);
                    }
                }
                else
                    throw new Exception("No se registro la autorizacion, no existe diagnostico asociado para el establecimiento");

                #endregion

                transactionScope.Complete();
            }
            
            return seProcesaronTodos;
        }

        public void RegistrarAutorizacion(Autorizacion objAutorizacion, Tratamiento t, vw_paquete p)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                #region 'Registrar Autorizacion'

                objAutorizacion.FechaInicio = objAutorizacion.Fecha;
                if (objAutorizacionDA.ExisteAutorizacion(t.CadenaId, p.FaseId, objAutorizacion.EstablecimientoId, objAutorizacion.PacienteId))
                    throw new Exception("No se registro la autorizacion, paciente ya tiene el tratamiento autorizado");
                else
                    objAutorizacion = objAutorizacionDA.RegistrarAutorizacion(objAutorizacion);

                #endregion

                #region 'Registrar DX Asociado'

                PaqueteBL objPaqueteBL = new PaqueteBL();
                if (objPaqueteBL.ExisteIdDiagnosticoAsociado(objAutorizacion.EstablecimientoId))
                {
                    int tratamientoId = objPaqueteBL.GetIdDiagnosticoAsociado(objAutorizacion.EstablecimientoId);
                    if (!objAutorizacionDA.ExisteDiagnosticoAsociado(tratamientoId, objAutorizacion.EstablecimientoId, objAutorizacion.PacienteId))
                    {
                        TratamientoBL objTratamientoBL = new TratamientoBL();
                        Tratamiento objTratamiento = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, DatosBL.GetDate());
                        Autorizacion objAutorizacionDxAsociado = new Autorizacion();
                        objAutorizacionDxAsociado.Adicional = false;
                        objAutorizacionDxAsociado.Anulado = false;
                        objAutorizacionDxAsociado.ControlaCantidad = false;
                        objAutorizacionDxAsociado.DiagnosticoAsociado = true;
                        objAutorizacionDxAsociado.EstablecimientoId = objAutorizacion.EstablecimientoId;
                        objAutorizacionDxAsociado.Estado = "A";
                        objAutorizacionDxAsociado.Fecha = objAutorizacion.Fecha;
                        objAutorizacionDxAsociado.FechaInicio = objAutorizacionDxAsociado.Fecha;
                        objAutorizacionDxAsociado.FechaSolicitud = objAutorizacion.FechaSolicitud;
                        objAutorizacionDxAsociado.Modalidad = "R";
                        objAutorizacionDxAsociado.Monto = objTratamiento.Monto;
                        objAutorizacionDxAsociado.Nro_Solicitud = objAutorizacion.Nro_Solicitud;
                        objAutorizacionDxAsociado.PacienteId = objAutorizacion.PacienteId;
                        objAutorizacionDxAsociado.Tipo = "P";
                        objAutorizacionDxAsociado.TipoAutorizacionId = Convert.ToByte(objTratamiento.TipoAutorizacionId);
                        objAutorizacionDxAsociado.TratamiendoId = objTratamiento.TratamientoId;
                        objAutorizacionDxAsociado.UsuarioCreacion = objAutorizacion.UsuarioCreacion;
                        objAutorizacionDxAsociado.Version = objTratamiento.Version;
                        objAutorizacionDxAsociado.Vigencia = Convert.ToDateTime(objAutorizacionDxAsociado.FechaInicio).AddMonths(Convert.ToInt32(objTratamiento.Vigencia));
                        objAutorizacionDA.RegistrarAutorizacion(objAutorizacionDxAsociado);
                    }
                }
                else
                    throw new Exception("No se registro la autorizacion, no existe diagnostico asociado para el establecimiento");

                #endregion

                transactionScope.Complete();
            }
        }


        /************************************************************************************************************** Mod: FJVV ***/
        
        public bool RegistrarAutorizacionSolicitud(Paciente objPaciente, Autorizacion objAutorizacion, SolicitudAutorizacion objSolicitudAutorizacion, SolicitudAutorizacion objSolicitudAutorizacionDetalle)
        {
            bool seProcesaronTodos;
                #region 'Guardar Paciente'

                PacienteBL objPacienteBL = new PacienteBL();
                objPaciente.UsuarioCreacion = objAutorizacion.UsuarioCreacion;
                objPaciente.FechaCreacion = objAutorizacion.Fecha;
                objPaciente = objPacienteBL.GuardarPaciente(objPaciente);

                #endregion

                #region 'Registrar Autorizacion'

                //objAutorizacion.PacienteId = objPaciente.PacienteId;
                objAutorizacion.FechaInicio = objAutorizacion.Fecha;
                objAutorizacion = objAutorizacionDA.RegistrarAutorizacion(objAutorizacion);

                #endregion

                #region 'Aprobar Detalle Solicitud'

                SolicitudAutorizacionDetalleDA objSolicitudAutorizacionDetalleDA = new SolicitudAutorizacionDetalleDA();
                objSolicitudAutorizacionDetalle.AutorizacionId = objAutorizacion.AutorizacionId;
                objSolicitudAutorizacionDetalleDA.AprobarDetalleSolicitudAutorizacionWeb(objSolicitudAutorizacionDetalle);

                #endregion

                #region 'Actualizar Solicitud'
                
                SolicitudAutorizacionCabeceraDA objSolicitudAutorizacionCabeceraDA = new SolicitudAutorizacionCabeceraDA();
                seProcesaronTodos = objSolicitudAutorizacionDetalleDA.SeProcesaronTodos(objSolicitudAutorizacion.Nro_Solicitud);
                if (seProcesaronTodos)
                {
                    objSolicitudAutorizacion.Fecha_Procesado = DatosBL.GetDate();
                    objSolicitudAutorizacion.Procesado = true;                    
                }
                objSolicitudAutorizacionCabeceraDA.ActualizarCabeceraWeb(objSolicitudAutorizacion);

                #endregion
             
            #region 'Registrar DX Asociado'

            PaqueteBL objPaqueteBL = new PaqueteBL();
            if (objPaqueteBL.ExisteIdDiagnosticoAsociado(objSolicitudAutorizacion.EstablecimientoId))
            {
                int tratamientoId = objPaqueteBL.GetIdDiagnosticoAsociado(objSolicitudAutorizacion.EstablecimientoId);
                if (!objAutorizacionDA.ExisteDiagnosticoAsociado(tratamientoId, objSolicitudAutorizacion.EstablecimientoId, objSolicitudAutorizacion.PacienteId))
                {
                    TratamientoBL objTratamientoBL = new TratamientoBL();

                    if (objSolicitudAutorizacion.Fecha_Solicitud == Convert.ToDateTime("01/01/0001"))
                    {
                        objSolicitudAutorizacion.fechaSolicitud = DatosBL.GetDate();
                    }
                    else
                    { 
                        objSolicitudAutorizacion.fechaSolicitud = objSolicitudAutorizacion.Fecha_Solicitud;
                    }

                    Tratamiento objTratamiento = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, objSolicitudAutorizacion.fechaSolicitud);
                    Autorizacion objAutorizacionDxAsociado = new Autorizacion();
                    objAutorizacionDxAsociado.Adicional = false;
                    objAutorizacionDxAsociado.Anulado = false;
                    objAutorizacionDxAsociado.ControlaCantidad = false;
                    objAutorizacionDxAsociado.DiagnosticoAsociado = true;
                    objAutorizacionDxAsociado.EstablecimientoId = objSolicitudAutorizacion.EstablecimientoId;//consultar
                    objAutorizacionDxAsociado.Estado = "A";
                    objAutorizacionDxAsociado.Fecha = objAutorizacion.Fecha;
                    objAutorizacionDxAsociado.FechaSolicitud = objSolicitudAutorizacion.fechaSolicitud;//
                    objAutorizacionDxAsociado.Nro_Solicitud = objSolicitudAutorizacion.Nro_Solicitud;
                    objAutorizacionDxAsociado.FechaInicio = objAutorizacionDxAsociado.Fecha;
                    objAutorizacionDxAsociado.Modalidad = "R";
                    objAutorizacionDxAsociado.Monto = objTratamiento.Monto;
                    objAutorizacionDxAsociado.PacienteId = objSolicitudAutorizacion.PacienteId;
                    objAutorizacionDxAsociado.Tipo = "P";
                    objAutorizacionDxAsociado.TipoAutorizacionId = Convert.ToByte(objTratamiento.TipoAutorizacionId);
                    objAutorizacionDxAsociado.TratamiendoId = objTratamiento.TratamientoId;
                    objAutorizacionDxAsociado.UsuarioCreacion = objAutorizacion.UsuarioCreacion;
                    objAutorizacionDxAsociado.Version = objTratamiento.Version;
                    objAutorizacionDxAsociado.Vigencia = Convert.ToDateTime(objAutorizacionDxAsociado.FechaInicio).AddMonths(Convert.ToInt32(objTratamiento.Vigencia));
                    objAutorizacionDA.RegistrarAutorizacion(objAutorizacionDxAsociado);
                }
            }
            #endregion
            return seProcesaronTodos;
        }

        public bool RegistrarAutorizaciones(Paciente objPaciente, List<Autorizacion> objAutorizaciones, vw2_SolicitudAutorizacion objSolicitudAutorizacion, List<vw2_SolicitudAutorizacionDetalle> objSolicitudAutorizacionDetalle)
        {
            bool seProcesaronTodos;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                #region 'Guardar Paciente'

                PacienteBL objPacienteBL = new PacienteBL();
                objPaciente.UsuarioCreacion = objSolicitudAutorizacion.Usuario_Solicitante;
                objPaciente = objPacienteBL.Guardar(objPaciente);

                #endregion
                
                #region 'Registrar Autorizacion'

                List<vw2_SolicitudAutorizacionDetalle> List= new List<vw2_SolicitudAutorizacionDetalle>();
                Autorizacion ObjAutorizacion2 = null;

                foreach (Autorizacion ListaAutorz in objAutorizaciones)
                {
                    ListaAutorz.PacienteId = objPaciente.PacienteId;
                    ListaAutorz.FechaInicio = objSolicitudAutorizacion.Fecha_Solicitud;
                    ObjAutorizacion2=objAutorizacionDA.RegistrarAutorizacion(ListaAutorz);
                } 
                
                
                #endregion

                #region 'Aprobar Detalle Solicitud'                

                foreach (vw2_SolicitudAutorizacionDetalle ListaDetalles in objSolicitudAutorizacionDetalle)
                {
                    SolicitudAutorizacionDetalleDA objSolicitudAutorizacionDetalleDA = new SolicitudAutorizacionDetalleDA();
                    objSolicitudAutorizacionDetalleDA.AprobarDetalleSolicitudAutorizacion(ListaDetalles);
                }

                #endregion

                #region 'Actualizar Solicitud'

                SolicitudAutorizacionCabeceraDA objSolicitudAutorizacionCabeceraDA = new SolicitudAutorizacionCabeceraDA();
                objSolicitudAutorizacion.Fecha_Procesado = DatosBL.GetDate();
                objSolicitudAutorizacion.Procesado = true;
                objSolicitudAutorizacion.Usuario_Procesa = objSolicitudAutorizacion.Usuario_Solicitante;

                objSolicitudAutorizacionCabeceraDA.Actualizar(objSolicitudAutorizacion);

                #endregion

                seProcesaronTodos = true;

                transactionScope.Complete();
            }

            #region 'Registrar DX Asociado'

            PaqueteBL objPaqueteBL = new PaqueteBL();
            if (objPaqueteBL.ExisteIdDiagnosticoAsociado(objSolicitudAutorizacion.EstablecimientoId))
            {
                int tratamientoId = objPaqueteBL.GetIdDiagnosticoAsociado(objSolicitudAutorizacion.EstablecimientoId);
                
                if (!objAutorizacionDA.ExisteDiagnosticoAsociado(tratamientoId, objSolicitudAutorizacion.EstablecimientoId, objPaciente.PacienteId))
                {
                    TratamientoBL objTratamientoBL = new TratamientoBL();
                    Tratamiento objTratamiento = objTratamientoBL.GetTratamientoPorIdVersion(tratamientoId, objSolicitudAutorizacion.Fecha_Solicitud);
                    Autorizacion objAutorizacionDxAsociado = new Autorizacion();
                    objAutorizacionDxAsociado.Adicional = false;
                    objAutorizacionDxAsociado.Anulado = false;
                    objAutorizacionDxAsociado.ControlaCantidad = false;
                    objAutorizacionDxAsociado.DiagnosticoAsociado = true;
                    objAutorizacionDxAsociado.EstablecimientoId = objSolicitudAutorizacion.EstablecimientoId;//consultar
                    objAutorizacionDxAsociado.Estado = "A";
                    objAutorizacionDxAsociado.Fecha = objSolicitudAutorizacion.Fecha_Solicitud;
                    objAutorizacionDxAsociado.FechaInicio = objAutorizacionDxAsociado.Fecha;
                    objAutorizacionDxAsociado.Modalidad = "R";
                    objAutorizacionDxAsociado.Monto = objTratamiento.Monto;
                    objAutorizacionDxAsociado.PacienteId = objPaciente.PacienteId;
                    objAutorizacionDxAsociado.Tipo = "P";
                    objAutorizacionDxAsociado.TipoAutorizacionId = Convert.ToByte(objTratamiento.TipoAutorizacionId);
                    objAutorizacionDxAsociado.TratamiendoId = objTratamiento.TratamientoId;
                    objAutorizacionDxAsociado.UsuarioCreacion = objSolicitudAutorizacion.Usuario_Solicitante;
                    objAutorizacionDxAsociado.Version = objTratamiento.Version;
                    objAutorizacionDxAsociado.Vigencia = Convert.ToDateTime(objAutorizacionDxAsociado.FechaInicio).AddMonths(Convert.ToInt32(objTratamiento.Vigencia));
                    objAutorizacionDA.RegistrarAutorizacion(objAutorizacionDxAsociado);
                }
            }
            #endregion

            return seProcesaronTodos;
        }

        public bool RegistraSolicitudes(SolicitudAutorizacion objSolicitudBE, List<SolicitudAutorizacion> objSolicitudDetBE) 
        {
            bool seGrabaronSolicitudes;
            SolicitudAutorizacionDA objAutorizacionDA = new SolicitudAutorizacionDA();

            using (TransactionScope transactionScope = new TransactionScope())
            {
                #region 'Graba Cabecera'

                int valida;

                valida = objAutorizacionDA.SolicitudAutorizacion_Grabar(objSolicitudBE);

                #endregion

                #region 'Graba Detalles'

                if (valida == 1)
                {
                    foreach(SolicitudAutorizacion ListadoDetalles in objSolicitudDetBE)
                    {
                        objAutorizacionDA.SolicitudAutorizacionDet_Grabar(ListadoDetalles);

                        //if (objSolicitudBE.Enviado == 1)
                        //{
                        //    if (objSolicitudBE.ValidadoSIS == true)  // Si esta asegurado 
                        //    {
                                Paciente ListPacientes = new Paciente();

                                #region 'Cargamos Datos Paciente'
                                PacienteBL objPacienteBL = new PacienteBL();
                                Paciente objPaciente = objPacienteBL.GetPacientePorNumeroDocumento(objSolicitudBE.NumeroDocumento);
                                if (objPaciente == null)
                                {
                                    ListPacientes = new Paciente();
                                    ListPacientes.EstablecimientoIdOrigen = objSolicitudBE.EstablecimientoId;
                                    ListPacientes.Estado = true;
                                    ListPacientes.UsuarioCreacion = VariablesGlobales.Login;
                                    ListPacientes.NumeroDocumento = objSolicitudBE.NumeroDocumento;
                                }

                                ListPacientes.ApellidoMaterno = objSolicitudBE.ApellidoMaterno;
                                ListPacientes.ApellidoPaterno = objSolicitudBE.ApellidoPaterno;
                                ListPacientes.fecha_defuncion = objSolicitudBE.fecha_defuncion;
                                ListPacientes.Historia = objSolicitudBE.Historia;
                                ListPacientes.Nacimiento = objSolicitudBE.Nacimiento;
                                ListPacientes.Nombres = objSolicitudBE.Nombres;
                                ListPacientes.OtrosNombres = objSolicitudBE.OtrosNombres;
                                ListPacientes.SexoId = Convert.ToByte(objSolicitudBE.SexoId);
                                ListPacientes.TipoRegimenId = Convert.ToByte(objSolicitudBE.TipoRegimenId);
                                ListPacientes.Validado = true;
                                ListPacientes.TipoDocumentoId = Convert.ToByte(objSolicitudBE.TipoDocumentoId);
                                ListPacientes.NumeroDocumento = objSolicitudBE.NumeroDocumento;
                                ListPacientes.PacienteId = objSolicitudBE.PacienteId;
                                #endregion

                                #region 'Cargamos Datos Autorizacion'

                                    Autorizacion objListAutorizacion = new Autorizacion();

                                    objListAutorizacion.Adicional = false;
                                    objListAutorizacion.Anulado = false;
                                    
                                    objListAutorizacion.Descripcion = String.Empty;
                                    if (ListadoDetalles.CategoriaId == "ZZZ")
                                    {
                                        objListAutorizacion.DiagnosticoAsociado = true; // Si Categoria = 'ZZZ' true | false
                                    }
                                    else
                                    {
                                        objListAutorizacion.DiagnosticoAsociado = false;
                                    }

                                    objListAutorizacion.EstablecimientoId = objSolicitudBE.EstablecimientoId;
                                    objListAutorizacion.Estado = "A";
                                    objListAutorizacion.Fecha = objSolicitudBE.fechaSolicitud;//
                                    //objListAutorizacion.FechaInicio = objListAutorizacion.Fecha;
                                    objListAutorizacion.FechaSolicitud = objSolicitudBE.fechaSolicitud;

                                    objListAutorizacion.TipoAutorizacionId = Convert.ToByte(ListadoDetalles.TipoAutorizacionId);
                                    if (objListAutorizacion.TipoAutorizacionId == 1)
                                        objListAutorizacion.ControlaCantidad = true;
                                    else
                                        objListAutorizacion.ControlaCantidad = false;

                                    objListAutorizacion.TratamiendoId = ListadoDetalles.TratamientoId;
                                    
                                

                                    /******/
                                    //Tratamiento ObjListTratamiento = ObtenerDetalleTratamiento(ListadoDetalles.TratamientoId);

                                    if (ListadoDetalles.SoloRetrospectivo == true)
                                    {
                                        objListAutorizacion.Modalidad = "R";
                                        objListAutorizacion.Monto = ListadoDetalles.Monto;
                                    }
                                    else
                                    {
                                        objListAutorizacion.Modalidad = "S";
                                        objListAutorizacion.Monto = 0;
                                    }

                                    
                                    objListAutorizacion.Version = ListadoDetalles.Version;
                                    objListAutorizacion.Vigencia = objListAutorizacion.Fecha.AddMonths(Convert.ToInt32(ListadoDetalles.Vigencia));
                                    /******/


                                    objListAutorizacion.PacienteId = objSolicitudBE.PacienteId;
                                    objListAutorizacion.Nro_Solicitud = objSolicitudBE.Nro_Solicitud;
                                    objListAutorizacion.observacion = String.Empty;
                                    objListAutorizacion.Tipo = "P";
                                    objListAutorizacion.UsuarioCreacion = objSolicitudBE.UsuarioSolicita;
                                    //objListAutorizaciones.Add(objListAutorizacion);
                                #endregion                                

                                    RegistrarAutorizacionSolicitud(ListPacientes, objListAutorizacion, objSolicitudBE, ListadoDetalles);
                        //    }
                        //}
                    }
                }
                #endregion


                transactionScope.Complete();
                seGrabaronSolicitudes = true;
            }
            return seGrabaronSolicitudes; 
        }

        public bool ActualizaSolicitudes(SolicitudAutorizacion objSolicitudBE, List<SolicitudAutorizacion> objSolicitudDetBE) 
        {
            bool seActualizaronSolicitudes;
            SolicitudAutorizacionDA objAutorizacionDA = new SolicitudAutorizacionDA();

            using (TransactionScope transactionScope = new TransactionScope())
            {
                int Valida;

                #region 'Elimina Detalles'

                objAutorizacionDA.SolicitudAutorizacion_Eliminar(objSolicitudBE.Nro_Solicitud);

                #endregion

                #region 'Actualiza Cabecera'

                Valida = objAutorizacionDA.SolicitudAutorizacion_Actualizar(objSolicitudBE);

                #endregion

                #region 'Registra Detalles'

                if (Valida == 1)
                {
                    foreach (SolicitudAutorizacion ListadoDetalles in objSolicitudDetBE)
                    {
                        objAutorizacionDA.SolicitudAutorizacionDet_Grabar(ListadoDetalles);
                    }
                }

                #endregion                
                
                transactionScope.Complete();
                seActualizaronSolicitudes = true;
            }
            return seActualizaronSolicitudes;

            
        }

        /*****************************************************************************************************************************/




        public SolicitudAutorizacion ObtenerSolicitudAutorizacion(string Nro_Solicitud)
        {
            return objAutorizacionDA.ObtenerSolicitudAutorizacion(Nro_Solicitud);
        }

        public List<SolicitudAutorizacion> ObtenerSolicitudAutorizacionListDetalle(string Nro_Solicitud)
        {
            return objAutorizacionDA.ObtenerSolicitudAutorizacionListDetalle(Nro_Solicitud);
        }

        public Tratamiento ObtenerDetalleTratamiento(int TratamientoId)
        {
            return objAutorizacionDA.ObtenerDetalleTratamiento(TratamientoId);
        }

        public DataTable GetAllPreAutorizacion()
        {
            return objAutorizacionDA.GetAllPreAutorizacion();
        }

        public int ActualizarPacienteVivoPreAutorizaciones(string usuarioEvaluacionReniec)
        {
            return objAutorizacionDA.ActualizarPacienteVivoPreAutorizaciones(usuarioEvaluacionReniec);
        }

        public int ActualizarPacienteVivoPreAutorizacionesPorEstablecimiento(string usuarioEvaluacionReniec, int establecimientoId)
        {
            return objAutorizacionDA.ActualizarPacienteVivoPreAutorizacionesPorEstablecimiento(usuarioEvaluacionReniec, establecimientoId);
        }

        public int ActualizarSinAutorizacionesPreAutorizacionesPorEstablecimiento(string usuarioEvaluacionReniec, int establecimientoId)
        {
            return objAutorizacionDA.ActualizarSinAutorizacionesPreAutorizacionesPorEstablecimiento(usuarioEvaluacionReniec, establecimientoId);
        }

        public List<string> GetAllPacienteIdActivoSisPendiente()
        {
            return objAutorizacionDA.GetAllPacienteIdActivoSisPendiente();
        }

        public int ActualizarActivoSisPreAutorizaciones(string pacienteId, string activoSis, byte? tipoRegimen,string usuarioEvaluacionSis)
        {
            return objAutorizacionDA.ActualizarActivoSisPreAutorizaciones(pacienteId, activoSis, tipoRegimen, usuarioEvaluacionSis);
        }

        public int ActualizarActivoSisPreAutorizacionesPorEstablecimiento(string pacienteId, string activoSis, byte? tipoRegimen, string usuarioEvaluacionSis, int establecimientoId)
        {
            return objAutorizacionDA.ActualizarActivoSisPreAutorizacionesPorEstablecimiento(pacienteId, activoSis, tipoRegimen, usuarioEvaluacionSis, establecimientoId);
        }

        public List<string> GetPacienteIdActivoSisPendientePorEstablecimiento(int establecimientoId)
        {
            return objAutorizacionDA.GetPacienteIdActivoSisPendientePorEstablecimiento(establecimientoId);
        }

        public bool PacienteTieneAutorizacionesPrevias(string pacienteId, string categoriaId)
        {
            return objAutorizacionDA.PacienteTieneAutorizacionesPrevias(pacienteId,categoriaId);
        }


        public int ActualizarModalidadAutorizacion(string modalidad, decimal? monto, int autorizacionId)
        {
            return objAutorizacionDA.ActualizarModalidadAutorizacion(modalidad, monto, autorizacionId);
        }

        public int ActualizarPreAutorizacion(string usuarioAutorizacionDefinitiva, string numeroSolicitud, string pacienteSinAutorizacionPrevia, string pacienteTodosRetrospectivos, string pacienteTodosDiferenteFase ,string observacionesAutorizacionDefinitiva, int detalleId)
        {
            return objAutorizacionDA.ActualizarPreAutorizacion(usuarioAutorizacionDefinitiva, numeroSolicitud, pacienteSinAutorizacionPrevia, pacienteTodosRetrospectivos, pacienteTodosDiferenteFase,observacionesAutorizacionDefinitiva, detalleId);
        }

        public bool PacienteTieneAutorizacionesPreviasProspectivas(string pacienteId, string categoriaId)
        {
            return objAutorizacionDA.PacienteTieneAutorizacionesPreviasProspectivas(pacienteId, categoriaId);
        }

        public bool ExistenPendientesPacienteActivoSis(int? establecimientoId)
        {
            return objAutorizacionDA.ExistenPendientesPacienteActivoSis(establecimientoId);
        }

        public bool ExistenPendientesPacienteVivo(int? establecimientoId)
        {
            return objAutorizacionDA.ExistenPendientesPacienteVivo(establecimientoId);
        }

        public int ActualizarEvaluacionFissalPreAutorizacion(string numeroSolicitud, int detalleId, string pacienteSinAutorizacionPrevia, string pacienteTodosRetrospectivos, string usuarioEvaluacionFissal)
        {
            return objAutorizacionDA.ActualizarEvaluacionFissalPreAutorizacion(numeroSolicitud, detalleId, pacienteSinAutorizacionPrevia, pacienteTodosRetrospectivos, usuarioEvaluacionFissal);
        }

        public DataTable GetVwAutorizacionPorId(int autorizacionId)
        {
            return objAutorizacionDA.GetVwAutorizacionPorId(autorizacionId);
        }

        public DataTable GetAutorizacionesPreviasPorPacienteCategoria(string pacienteId, string categoriaId)
        {
            return objAutorizacionDA.GetAutorizacionesPreviasPorPacienteCategoria(pacienteId, categoriaId);
        }

        public bool PacienteTieneAutorizacionesPreviasVigentes(string pacienteId, string categoriaId)
        {
            return objAutorizacionDA.PacienteTieneAutorizacionesPreviasVigentes(pacienteId, categoriaId);
        }

        public bool PacienteTieneAutorizacionesPreviasProspectivasVigentes(string pacienteId, string categoriaId)
        {
            return objAutorizacionDA.PacienteTieneAutorizacionesPreviasProspectivasVigentes(pacienteId, categoriaId);
        }

        public bool PacienteTieneAutorizacionesPreviasMismaFase(string pacienteId, string categoriaId, int faseId)
        {
            return objAutorizacionDA.PacienteTieneAutorizacionesPreviasMismaFase(pacienteId, categoriaId, faseId);
        }

        public DataTable MovimientoAutorizacion_AutorizacionWS(DataTable dt) 
        {
            return objAutorizacionDA.MovimientoAutorizacion_AutorizacionWS(dt);
        }
    }
}
