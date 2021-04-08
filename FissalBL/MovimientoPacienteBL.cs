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
    public class MovimientoPacienteBL
    {
        MovimientoPacienteDA objMovimientoPacienteDA = new MovimientoPacienteDA();

        public DataTable MovimientoPaciente_Listar()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Listar();
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR BUSCADOR
        public DataTable ListarMovimientoPacienteBuscadorCM(string consulta)
        {
            return objMovimientoPacienteDA.ListarMovimientoPacienteBuscadorCM(consulta);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR FUA
        public DataTable MovimientoPaciente_ListarxFua(MovimientoPaciente objMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ListarxFua(objMovimientoPaciente);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR PARAMETROS
        public DataTable MovimientoPaciente_Filtrar(int NroOpc, string anno, string correlativo, int TipoDocumentoId, string DNI, string Nombre, DateTime FecIni, DateTime FecFin, int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Filtrar(NroOpc, anno, correlativo, TipoDocumentoId, DNI, Nombre, FecIni, FecFin, EstablecimientoId);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR PARAMETROS (ADMINISTRADOR)
        public DataTable MovimientoPaciente_FiltrarxAdministrador(int NroOpc, string anno, string correlativo, int TipoDocumentoId, string DNI, string Nombre, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_FiltrarxAdministrador(NroOpc, anno, correlativo, TipoDocumentoId, DNI, Nombre, FecIni, FecFin);
        }

        //OBTIENE FECHA REGISTRO | FECHA SERVIDOR DE MOVIMIENTO PACIENTE POR FUA
        public DataTable MovimientoPaciente_GetFechaRegistroServidor(MovimientoPaciente objMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_GetFechaRegistroServidor(objMovimientoPaciente);
        }

        //OBTIENE FECHA SERVIDOR
        public DataTable MovimientoPaciente_GetFechaServidor()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_GetFechaServidor();
        }

        //OBTIENE LISTA DE MOVIMIENTO PACIENTE POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoPaciente_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Exportar(EstablecimientoId, FecIni, FecFin);
        }

        //OBTIENE LISTA DE MOVIMIENTO PACIENTE DETALLE POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoPacienteDetalle_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPacienteDetalle_Exportar(EstablecimientoId, FecIni, FecFin);
        }

        //OBTIENE LISTA DE MOVIMIENTO MEDICAMENTO POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoMedicamento_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoMedicamento_Exportar(EstablecimientoId, FecIni, FecFin);
        }

        //OBTIENE LISTA DE MOVIMIENTO PROCEDIMIENTO POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoProcedimiento_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoProcedimiento_Exportar(EstablecimientoId, FecIni, FecFin);
        }

        //HABILITAR EDICION FUA
        public DataTable HabilitarEdicionFua()
        {
            return objMovimientoPacienteDA.HabilitarEdicionFua();
        }

        //VALORIZACION
        //OBTIENE LISTA DE MEDICAMENTOS Y PROCEDIMIENTOS NO VALORIZADOS
        public DataTable MedicamentoProcedimiento_SinValorizacion(int NroOpc, string EstablecimientoId)
        {
            return objMovimientoPacienteDA.MedicamentoProcedimiento_SinValorizacion(NroOpc, EstablecimientoId);
        }

        //VALORIZACION
        //OBTIENE LISTA DE MEDICAMENTOS Y PROCEDIMIENTOS NO VALORIZADOS X FECHA
        public DataTable MedicamentoProcedimiento_SinValorizacionxFecha(int NroOpc, string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MedicamentoProcedimiento_SinValorizacionxFecha(NroOpc, EstablecimientoId, FecIni, FecFin);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS NO VALORIZADOS
        public DataTable MovimientoPaciente_SinValorizacion(int NroOpc, string EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_SinValorizacion(NroOpc, EstablecimientoId);
        }

        public DataTable MovimientoPaciente_ValorizacionParcial(int NroOpc, string EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionParcial(NroOpc, EstablecimientoId);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS VALORIZADOS AL 100%
        public DataTable MovimientoPaciente_ValorizacionTotal(int NroOpc, string EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionTotal(NroOpc, EstablecimientoId);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS VALORIZADOS TOTALES (PARCIAL + AL 100%)
        public DataTable MovimientoPaciente_ValorizacionParcialTotal(int NroOpc, string EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionParcialTotal(NroOpc, EstablecimientoId);
        }

        //VALORIZACION
        //OBTIENE LISTA DE MEDICAMENTOS Y PROCEDIMIENTOS NO VALORIZADOS X MES
        public DataTable MedicamentoProcedimiento_SinValorizacionxMes()
        {
            return objMovimientoPacienteDA.MedicamentoProcedimiento_SinValorizacionxMes();
        }

        //VALORIZACION
        //OBTIENE LISTA DE CONSUMO VALORIZADO X ESTABLECIMIENTOS 
        public DataTable MovimientoPaciente_ValorizacionGlobal()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionGlobal();
        }

        //VALORIZACION
        //OBTIENE LISTA CONSUMO VALORIZADO DE PACIENTES X ESTABLECIMIENTOS 
        public DataTable MovimientoPaciente_ValorizacionxEstablecimiento(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionxEstablecimiento(EstablecimientoId);
        }

        //VALORIZACION
        //OBTIENE LISTA CONSUMO VALORIZADO DE FUAS X PACIENTES
        public DataTable MovimientoPaciente_ValorizacionxPaciente(string PacienteId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionxPaciente(PacienteId);
        }

        //VALORIZACION
        //OBTIENE LISTA CONSUMO MEDICAMENTO | PROCEDIMIENTO X FUA
        public DataTable MovimientoMedicamentoProcedimiento_ListarxFua(int Fua)
        {
            return objMovimientoPacienteDA.MovimientoMedicamentoProcedimiento_ListarxFua(Fua);
        }

        //VALORIZACION
        //OBTIENE FECHAS MAXIMAS DE TARIFARIO CONVENIO | SIS | DIGEMID
        public DataTable Tarifario_GetFechaMaxima()
        {
            return objMovimientoPacienteDA.Tarifario_GetFechaMaxima();
        }

        //VALORIZACION
        //OBTIENE LISTA VALORIZADA DE MEDICAMENTOS
        public DataTable MovimientoMedicamento_Proceso_Valorizacion()
        {
            return objMovimientoPacienteDA.MovimientoMedicamento_Proceso_Valorizacion();
        }

        //VALORIZACION
        //OBTIENE LISTA VALORIZADA DE PROCEDIMIENTOS
        public DataTable MovimientoProcedimiento_Proceso_Valorizacion()
        {
            return objMovimientoPacienteDA.MovimientoProcedimiento_Proceso_Valorizacion();
        }

        //VALORIZACION
        //OBTIENE LISTA VALORIZADA DE FUAS
        public DataTable MovimientoPaciente_Proceso_TotalesValorizados()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Proceso_TotalesValorizados();
        }

        //VALORIZACION
        //VALORIZACION PRELIMINAR
        public DataTable MovimientoPaciente_ValorizacionPreliminar(int? EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValorizacionPreliminar(EstablecimientoId);
        }

        //GESTION DE CUENTA
        //OBTIENE LISTA DE ABONO x PacienteId | EstablecimientoId
        public DataTable GestionCta_AbonoxPacienteIdEstablecimientoId(string PacienteId, int EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.GestionCta_AbonoxPacienteIdEstablecimientoId(PacienteId, EstablecimientoId, FecIni, FecFin);
        }

        //ESTADISTICAS
        //OBTIENE RESUMEN DE ATENDIDOS POR ESTADIO
        public DataTable Atencion_AtendidosxEstadio(DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.Atencion_AtendidosxEstadio(FecIni, FecFin);
        }

        //VERIFICAR NUMERO DUPLICADO DE FUA
        public DataTable MovimientoPaciente_Verificar(MovimientoPaciente objMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Verificar(objMovimientoPaciente);
        }

        public DataTable MovimientoPaciente_Verificar2(MovimientoPaciente objMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Verificar2(objMovimientoPaciente);
        }

        //GENERAR NUEVO NUMERO DE FUA
        public DataTable MovimientoPaciente_Nuevo()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Nuevo();
        }

        // INSERTAR NUEVO MOVIMIENTO PACIENTE
        public int MovimientoPaciente_Insertar(MovimientoPaciente ObjMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Insertar(ObjMovimientoPaciente);
        }

        // ACTUALIZAR MOVIMIENTO PACIENTE
        public int MovimientoPaciente_Actualizar(MovimientoPaciente ObjMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Actualizar(ObjMovimientoPaciente);
        }

        // ACTUALIZAR MOVIMIENTO PACIENTE - CM PRELIMINAR
        public void GuardarControlMedicoAtencion(MovimientoPaciente ObjMovimientoPaciente, List<vw_MovimientoPacienteDetalle> listaDiagnosticos, List<vw_MovimientoPacienteProcedimiento> listaProcedimientos, List<vw_movimientoPacienteMedicamento> listaMedicamentos, ControlMedicoLog objControlMedicoLog)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    objMovimientoPacienteDA.GuardarControlMedicoAtencion(ObjMovimientoPaciente);
                    MovimientoPacienteDetalleBL objMovimientoPacienteDetalleBL = new MovimientoPacienteDetalleBL();
                    foreach (vw_MovimientoPacienteDetalle objMovimientoPacienteDetalle in listaDiagnosticos)
                    {
                        objMovimientoPacienteDetalleBL.GuardarControlMedicoDetalleAtencion(objMovimientoPacienteDetalle);
                    }
                    MovimientoProcedimientoBL objMovimientoProcedimientoBL = new MovimientoProcedimientoBL();
                    foreach (vw_MovimientoPacienteProcedimiento objMovimientoProcedimiento in listaProcedimientos)
                    {
                        objMovimientoProcedimientoBL.GuardarControlMedicoProcedimientoAtencion(objMovimientoProcedimiento);
                    }
                    MovimientoMedicamentoBL objMovimientoMedicamentoBL = new MovimientoMedicamentoBL();
                    foreach (vw_movimientoPacienteMedicamento objMovimientoMedicamento in listaMedicamentos)
                    {
                        objMovimientoMedicamentoBL.GuardarControlMedicoMedicamentoAtencion(objMovimientoMedicamento);
                    }
                    ControlMedicoLogBL objControlMedicoLogBL = new ControlMedicoLogBL();
                    objControlMedicoLogBL.GuardarControlMedicoLog(objControlMedicoLog);
                    transactionScope.Complete();
                }
                catch
                {
                    throw new Exception("No se guardo la supervision");
                }
            }
        }

        // ACTUALIZAR MOVIMIENTO PACIENTE - CMPcpp
        public void SeleccionarAtencionParaPcpp(MovimientoPaciente ObjMovimientoPaciente, ControlMedicoLog objControlMedicoLog)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    objMovimientoPacienteDA.SeleccionarAtencionParaPcpp(ObjMovimientoPaciente);
                    ControlMedicoLogBL objControlMedicoLogBL = new ControlMedicoLogBL();
                    objControlMedicoLogBL.GuardarControlMedicoLog(objControlMedicoLog);
                    transactionScope.Complete();
                }
                catch
                {
                    throw new Exception("No fue seleccionado para PCPP");
                }
                
            }
        }

        //  ELIMINAR MOVIMIENTO PACIENTE
        public int MovimientoPaciente_Eliminar(MovimientoPaciente ObjMovimientoPaciente)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Eliminar(ObjMovimientoPaciente);
        }

        //OBTIENE VISTA MOVIMIENTO PACIENTE FULL POR FUA
        public vw2_MovimientoPaciente_Listar GetVwMovimientoPacienteFullPorFua(Int64 fua)
        {
            return objMovimientoPacienteDA.GetVwMovimientoPacienteFullPorFua(fua);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN DIAGNOSTICO
        public DataTable MovimientoPaciente_SinDiagnostico(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_SinDiagnostico(EstablecimientoId, FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN CONSUMO
        public DataTable MovimientoPaciente_SinConsumo(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_SinConsumo(EstablecimientoId, FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS DUPLICADOS
        public DataTable MovimientoPaciente_Duplicado(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_Duplicado(EstablecimientoId, FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS CON FECHA DE ATENCION ERRONEA
        public DataTable MovimientoPaciente_FechaAtencionErronea(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_FechaAtencionErronea(EstablecimientoId, FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN DIAGNOSTICO (Administrador)
        public DataTable MovimientoPaciente_SinDiagnosticoxAdm(DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_SinDiagnosticoxAdm(FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN CONSUMO (Administrador)
        public DataTable MovimientoPaciente_SinConsumoxAdm(DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_SinConsumoxAdm(FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS DUPLICADOS (Administrador)
        public DataTable MovimientoPaciente_DuplicadoxAdm(DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_DuplicadoxAdm(FecIni, FecFin);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS CON FECHA DE ATENCION ERRONEA (Administrador)
        public DataTable MovimientoPaciente_FechaAtencionErroneaxAdm(DateTime FecIni, DateTime FecFin)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_FechaAtencionErroneaxAdm(FecIni, FecFin);
        }

        public DateTime GetFechaMaximaValorizacion()
        {
            return objMovimientoPacienteDA.GetFechaMaximaValorizacion();
        }

        //CIERRE DE DIGITACION
        //LISTAR IPRESS PARA REGISTRAR FECHAS CIERRE 
        public DataTable MovimientoPaciente_IpressParaCierreId()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_IpressParaCierreId();
        }

        //CIERRE DE DIGITACION
        //ACTUALIZAR FECHA REGISTRO CON FECHA ATENCION EN FUAS SIN FECHA REGISTRO
        public int MovimientoPaciente_UpdateFechaRegistro()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_UpdateFechaRegistro();
        }

        //CIERRE DE DIGITACION
        //LISTAR FECHAS CIERRE POR IPRESS
        public DataTable ProduccionCierreDigitacion_FechasCierre(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            return objMovimientoPacienteDA.ProduccionCierreDigitacion_FechasCierre(objProduccionCierreDigitacion);
        }

        //CIERRE DE DIGITACION
        //LISTAR FECHAS CIERRE POR IPRESS V2
        public DataTable ProduccionCierreDigitacion_FechasCierreV2(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            return objMovimientoPacienteDA.ProduccionCierreDigitacion_FechasCierreV2(objProduccionCierreDigitacion);
        }

        //CIERRE DE DIGITACION
        //GENERAR NUEVO NUMERO DE CIERRE DIGITACION POR IPRESS
        public DataTable ProduccionCierreDigitacion_Nuevo(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            return objMovimientoPacienteDA.ProduccionCierreDigitacion_Nuevo(objProduccionCierreDigitacion);
        }

        //CIERRE DE DIGITACION
        //INSERTAR CIERRE DIGITACION POR IPRESS
        public int ProduccionCierreDigitacion_Insert(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            return objMovimientoPacienteDA.ProduccionCierreDigitacion_Insert(objProduccionCierreDigitacion);
        }

        //CIERRE DE DIGITACION
        //ETIQUETAR FUAS DESPUES DEL CIERRE DIGITACION POR IPRESS
        public int MovimientoPaciente_RegistrarCierreId(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_RegistrarCierreId(objProduccionCierreDigitacion);
        }

        //CIERRE DE DIGITACION
        //VERIFICAR FUA CERRADA
        public DataTable MovimientoPaciente_VerificarCierreId(int Fua)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_VerificarCierreId(Fua);
        }

        //CIERRE DE DIGITACION
        //REPORTE FUAS CERRADOS
        public DataTable MovimientoPacienteCerrados_Listar(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPacienteCerrados_Listar(EstablecimientoId);
        }

        //CIERRE DE DIGITACION
        //VERIFICAR CIERRE DE DIGITACION
        public DataTable ProduccionCierreDigitacion_VerificarCierre(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            return objMovimientoPacienteDA.ProduccionCierreDigitacion_VerificarCierre(objProduccionCierreDigitacion);
        }

        //POSTCONSISTENCIA
        //OBTENER IPRESS PARA POSTCONSISTENCIA
        public DataTable MovimientoPaciente_IpressPostConsistencia()
        {
            return objMovimientoPacienteDA.MovimientoPaciente_IpressPostConsistencia();
        }

        //POSTCONSISTENCIA
        //REESTABLECER FUAS OBSERVADAS
        public int AtencionesObservadas_Reestablecer(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.AtencionesObservadas_Reestablecer(EstablecimientoId);
        }

        //POSTCONSISTENCIA
        //LISTAR FUAS OBSERVADAS
        public DataTable AtencionesObservadas_Listar(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.AtencionesObservadas_Listar(EstablecimientoId);
        }

        //POSTCONSISTENCIA
        //ETIQUETAR FUAS OBSERVADAS
        public int MovimientoPaciente_UpdateObservado(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_UpdateObservado(EstablecimientoId);
        }

        //POSTCONSISTENCIA
        //INSERTAR FUAS OBSERVADAS A TABLA AtencionObsConsistencia
        public int AtencionObsConsistencia_Insert(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.AtencionObsConsistencia_Insert(EstablecimientoId);
        }

        //POSTCONSISTENCIA
        //LISTAR DETALLE FUAS OBSERVADAS
        public DataTable AtencionesObservadas_Detalle()
        {
            return objMovimientoPacienteDA.AtencionesObservadas_Detalle();
        }

        //POSTCONSISTENCIA
        //REPORTE FUAS OBSERVADOS
        public DataTable MovimientoPacienteObservados_Listar(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPacienteObservados_Listar(EstablecimientoId);
        }

        //VALIDAR ENFERMEDAD PRINCIPAL
        public DataTable MovimientoPaciente_ValidarEnfermedadPrincipal(int Fua)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ValidarEnfermedadPrincipal(Fua);
        }

        //VALIDAR ENFERMEDAD PRINCIPAL
        public DataTable MovimientoPaciente_FechaConvenio(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_FechaConvenio(EstablecimientoId);
        }

        public DataTable MovimientoPaciente_PacienteWS(DataTable dt)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_PacienteWS(dt);
        }

        //OBTENER LISTADO CIERRE DIGITACION
        public DataTable MovimientoPaciente_ListarCierresDig(int EstablecimientoId)
        {
            return objMovimientoPacienteDA.MovimientoPaciente_ListarCierresDig(EstablecimientoId);
        }


    }
}
