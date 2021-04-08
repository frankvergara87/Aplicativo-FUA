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
    public class ProduccionEstablecimientoBL
    {
        ProduccionEstablecimientoDA objProduccionEstablecimientoDA = new ProduccionEstablecimientoDA();

        //GESTION DE CUENTA
        //GENERAR NUEVO NUMERO DE FUA
        public DataTable ProduccionEstablecimiento_Nuevo()
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_Nuevo();
        }        

        //GESTION DE CUENTA
        //INSERTAR PRODUCCION ESTABLECIMIENTO (INICIO)
        public int ProduccionEstablecimiento_Insert(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_Insert(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA
        //UPDATE ATENCIONES DE PRODUCCION ESTABLECIMIENTO
        public int ProduccionEstablecimiento_UpdateAtencionesProduccion(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_UpdateAtencionesProduccion(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)      
        //LISTAR PRODUCCION ESTABLECIMIENTO (CONTROL MEDICO)
        public DataTable ProduccionEstablecimientoCtrlMed_Listar(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoCtrlMed_Listar(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //GENERAR (CODIGO CONTROL MEDICO)
        public DataTable ProduccionEstablecimientoCtrlMed_Nuevo()
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoCtrlMed_Nuevo();
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE PRODUCCION ESTABLECIMIENTO (CODIGO CONTROL MEDICO)
        public int ProduccionEstablecimientoCtrlMed_Update(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoCtrlMed_Update(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE MOVIMIENTO PACIENTE (CODIGO CONTROL MEDICO)
        public int MovimientoPaciente_UpdateCodigoControlMedico(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoPaciente_UpdateCodigoControlMedico(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)      
        //LISTAR CONTROL MEDICO DE PRODUCCION ESTABLECIMIENTO (CONTROL MEDICO)
        public DataTable ProduccionEstablecimiento_CodigoCtrlMedListar()
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_CodigoCtrlMedListar();
        }

        //GESTION DE CUENTA (CONTROL MEDICO)      
        //LISTAR IPRESS DE CONTROL MEDICO DE PRODUCCION ESTABLECIMIENTO (CONTROL MEDICO)
        public DataTable ProduccionEstablecimiento_CtrlMedDetalle(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_CtrlMedDetalle(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE CIERRE PRODUCCION ESTABLECIMIENTO
        public int ProduccionEstablecimientoCtrlMed_Cierre(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoCtrlMed_Cierre(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE MOVIMIENTO PACIENTE MONTOS NETOS X (CODIGO CONTROL MEDICO)
        public int MovimientoPaciente_Proceso_TotalesValorizadosNetos(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoPaciente_Proceso_TotalesValorizadosNetos(objProduccionEstablecimiento);
        }
        
        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR PRODUCCION ESTABLECIMIENTO (CONCILIACION)
        public DataTable ProduccionEstablecimientoConciliacion_Listar(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoConciliacion_Listar(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //GENERAR (CODIGO CONCILIACION)
        public DataTable ProduccionEstablecimientoConciliacion_Nuevo()
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoConciliacion_Nuevo();
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE PRODUCCION ESTABLECIMIENTO (CODIGO CONCILIACION)
        public int ProduccionEstablecimientoConciliacion_Update(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoConciliacion_Update(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE MOVIMIENTO PACIENTE (CODIGO CONCILIACION)
        public int MovimientoPaciente_UpdateCodigoConciliacion(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoPaciente_UpdateCodigoConciliacion(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR PRODUCCION ESTABLECIMIENTO (CIERRE)
        public DataTable ProduccionEstablecimiento_CodigoConciliacionListar()
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_CodigoConciliacionListar();
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR PRODUCCION ESTABLECIMIENTO DETALLE (CIERRE)
        public DataTable ProduccionEstablecimiento_ConciliacionDetalle(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimiento_ConciliacionDetalle(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE CIERRE PRODUCCION ESTABLECIMIENTO
        public int ProduccionEstablecimientoConciliacion_Cierre(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoConciliacion_Cierre(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT DEBITOS A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_InsertDebito(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoCuentaConciliacion_InsertDebito(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE ABONOS A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_UpdateAbono(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoCuentaConciliacion_UpdateAbono(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT CUENTAS A ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_Insert(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.EstadoCuentaConciliacion_Insert(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //VERIFICAR ESTADO CUENTA CONCILIACION
        public DataTable EstadoCuentaConciliacion_Verificar(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.EstadoCuentaConciliacion_Verificar(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT REASIGNACION (+/-) A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_InsertReasignacion(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoCuentaConciliacion_InsertReasignacion(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT SALDO FINAL A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_InsertSaldoFinal(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            return objProduccionEstablecimientoDA.MovimientoCuentaConciliacion_InsertSaldoFinal(objProduccionEstablecimiento);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //VERIFICAR PRODUCCION ESTABLECIMIENTO CONCILIACION
        public DataTable ProduccionEstablecimientoConciliacion_Verificar()
        {
            return objProduccionEstablecimientoDA.ProduccionEstablecimientoConciliacion_Verificar();
        }

        public DataTable GetAllProduccionEstablecimiento_CM()
        {
            return objProduccionEstablecimientoDA.GetAllProduccionEstablecimiento_CM();
        }

        public DataTable GetProduccionEstablecimiento_ProduccionCM()
        {
            return objProduccionEstablecimientoDA.GetProduccionEstablecimiento_ProduccionCM();
        }

        public DataTable GetProduccionEstablecimiento_EstablecimientoCM()
        {
            return objProduccionEstablecimientoDA.GetProduccionEstablecimiento_EstablecimientoCM();
        }

        public DataTable GetProduccionEstablecimiento_ProduccionCN()
        {
            return objProduccionEstablecimientoDA.GetProduccionEstablecimiento_ProduccionCN();
        }

        public DataTable GetProduccionEstablecimiento_EstablecimientoCN()
        {
            return objProduccionEstablecimientoDA.GetProduccionEstablecimiento_EstablecimientoCN();
        }

        public DataTable GetAllProduccionEstablecimiento_CN()
        {
            return objProduccionEstablecimientoDA.GetAllProduccionEstablecimiento_CN();
        }

        public DataTable GetProduccionesAnterioresSinConciliarPorProduccionIpress(string codigoProduccion, int establecimientoId)
        {
            return objProduccionEstablecimientoDA.GetProduccionesAnterioresSinConciliarPorProduccionIpress(codigoProduccion, establecimientoId);
        }

        public DataTable GetProduccionesControlPorControlMedico(int codigoControlMedico)
        {
            return objProduccionEstablecimientoDA.GetProduccionesControlPorControlMedico(codigoControlMedico);
        }

        public DataTable GetCodigoProduccionControlPorControlMedico(string codigoControlMedico)
        {
            return objProduccionEstablecimientoDA.GetCodigoProduccionControlPorControlMedico(codigoControlMedico);
        }

        //GESTION DE CUENTA (SUPERVISION DE AVANCES)
        public DataTable SupervisionGestionCta()
        {
            return objProduccionEstablecimientoDA.SupervisionGestionCta();
        }

        //GESTION DE CUENTA (DETALLE DE PRODUCCIONES)
        public DataTable SupervisionGestionCta_Detalle(int CodigoControlMedico, int EstablecimientoId)
        {
            return objProduccionEstablecimientoDA.SupervisionGestionCta_Detalle(CodigoControlMedico, EstablecimientoId);
        }

        //GESTION DE CUENTA (FUAS X PRODUCCIONES)
        public DataTable SupervisionGestionCta_DetalleFuas(DateTime ProduccionFissal, int EstablecimientoId)
        {
            return objProduccionEstablecimientoDA.SupervisionGestionCta_DetalleFuas(ProduccionFissal, EstablecimientoId);
        }
    }
}
