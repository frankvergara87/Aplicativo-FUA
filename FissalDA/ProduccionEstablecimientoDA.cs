using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class ProduccionEstablecimientoDA
    {
        static SqlCommand cmd;

        public ProduccionEstablecimientoDA()
        {
            cmd = new SqlCommand();
        }

        //GESTION DE CUENTA
        //GENERAR NUEVO NUMERO DE FUA
        public DataTable ProduccionEstablecimiento_Nuevo()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_Nuevo";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }


        //GESTION DE CUENTA
        //INSERTAR PRODUCCION ESTABLECIMIENTO (INICIO)
        public int ProduccionEstablecimiento_Insert(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_Insert";
                cmd.Parameters.AddWithValue("@ProduccionEstablecimientoId", objProduccionEstablecimiento.ProduccionEstablecimientoId);
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA
        //UPDATE ATENCIONES DE PRODUCCION ESTABLECIMIENTO
        public int ProduccionEstablecimiento_UpdateAtencionesProduccion(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_UpdateAtencionesProduccion";
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)      
        //LISTAR PRODUCCION ESTABLECIMIENTO (CONTROL MEDICO)
        public DataTable ProduccionEstablecimientoCtrlMed_Listar(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoCtrlMed_Listar";
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //GENERAR (CODIGO CONTROL MEDICO)
        public DataTable ProduccionEstablecimientoCtrlMed_Nuevo()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoCtrlMed_Nuevo";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE PRODUCCION ESTABLECIMIENTO (CODIGO CONTROL MEDICO)
        public int ProduccionEstablecimientoCtrlMed_Update(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoCtrlMed_Update";
                cmd.Parameters.AddWithValue("@ProduccionEstablecimientoId", objProduccionEstablecimiento.ProduccionEstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoControlMedico", objProduccionEstablecimiento.CodigoControlMedico);
                cmd.Parameters.AddWithValue("@FechaFinControlMedico", objProduccionEstablecimiento.FechaFinControlMedico);
                cmd.Parameters.AddWithValue("@UsuarioIniciaControlMedico", objProduccionEstablecimiento.UsuarioIniciaControlMedico);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE MOVIMIENTO PACIENTE (CODIGO CONTROL MEDICO)
        public int MovimientoPaciente_UpdateCodigoControlMedico(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_MovimientoPaciente_UpdateCodigoControlMedico";
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoControlMedico", objProduccionEstablecimiento.CodigoControlMedico);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)      
        //LISTAR CONTROL MEDICO DE PRODUCCION ESTABLECIMIENTO (CONTROL MEDICO)
        public DataTable ProduccionEstablecimiento_CodigoCtrlMedListar()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_CodigoCtrlMedListar";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)      
        //LISTAR IPRESS DE CONTROL MEDICO DE PRODUCCION ESTABLECIMIENTO (CONTROL MEDICO)
        public DataTable ProduccionEstablecimiento_CtrlMedDetalle(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_CtrlMedDetalle";
                cmd.Parameters.AddWithValue("@CodigoControlMedico", objProduccionEstablecimiento.CodigoControlMedico);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetProduccionesControlPorControlMedico(int codigoControlMedico)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProduccionesControlPorControlMedico";
                cmd.Parameters.AddWithValue("@CodigoControlMedico", codigoControlMedico);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE CIERRE PRODUCCION ESTABLECIMIENTO
        public int ProduccionEstablecimientoCtrlMed_Cierre(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoCtrlMed_Cierre";
                cmd.Parameters.AddWithValue("@ProduccionEstablecimientoId", objProduccionEstablecimiento.ProduccionEstablecimientoId);
                cmd.Parameters.AddWithValue("@UsuarioCierraControlMedico", objProduccionEstablecimiento.UsuarioCierraControlMedico);
                cmd.Parameters.AddWithValue("@AtencionesSupervisadas", objProduccionEstablecimiento.AtencionesSupervisadas);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //UPDATE MOVIMIENTO PACIENTE MONTOS NETOS X (CODIGO CONTROL MEDICO)
        public int MovimientoPaciente_Proceso_TotalesValorizadosNetos(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp_MovimientoPaciente_Proceso_TotalesValorizadosNetos";
                cmd.Parameters.AddWithValue("@CodigoControlMedico", objProduccionEstablecimiento.CodigoControlMedico);
                return Datos.Mantenimiento(cmd);
            }
        }
        
        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR PRODUCCION ESTABLECIMIENTO (CONCILIACION)
        public DataTable ProduccionEstablecimientoConciliacion_Listar(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoConciliacion_Listar";
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);            
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //GENERAR (CODIGO CONCILIACION)
        public DataTable ProduccionEstablecimientoConciliacion_Nuevo()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoConciliacion_Nuevo";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE PRODUCCION ESTABLECIMIENTO (CODIGO CONCILIACION)
        public int ProduccionEstablecimientoConciliacion_Update(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoConciliacion_Update";
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                cmd.Parameters.AddWithValue("@UsuarioIniciaConciliacion", objProduccionEstablecimiento.UsuarioIniciaConciliacion);
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE MOVIMIENTO PACIENTE (CODIGO CONCILIACION)
        public int MovimientoPaciente_UpdateCodigoConciliacion(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_MovimientoPaciente_UpdateCodigoConciliacion";
                cmd.Parameters.AddWithValue("@ProduccionId", objProduccionEstablecimiento.ProduccionId);
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR PRODUCCION ESTABLECIMIENTO (CIERRE)
        public DataTable ProduccionEstablecimiento_CodigoConciliacionListar()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_CodigoConciliacionListar";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR PRODUCCION ESTABLECIMIENTO DETALLE (CIERRE)
        public DataTable ProduccionEstablecimiento_ConciliacionDetalle(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimiento_ConciliacionDetalle";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE CIERRE PRODUCCION ESTABLECIMIENTO
        public int ProduccionEstablecimientoConciliacion_Cierre(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoConciliacion_Cierre";
                cmd.Parameters.AddWithValue("@ProduccionEstablecimientoId", objProduccionEstablecimiento.ProduccionEstablecimientoId);
                cmd.Parameters.AddWithValue("@UsuarioCierraConciliacion", objProduccionEstablecimiento.UsuarioCierraConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT DEBITOS A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_InsertDebito(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_MovimientoCuentaConciliacion_InsertDebito";
                //cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //UPDATE ABONOS A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_UpdateAbono(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_MovimientoCuentaConciliacion_UpdateAbono";
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT CUENTAS A ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_Insert(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_Insert";
                //cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //VERIFICAR ESTADO CUENTA CONCILIACION
        public DataTable EstadoCuentaConciliacion_Verificar(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_Verificar";
                cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionEstablecimiento.EstablecimientoId);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT REASIGNACION (+/-) A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_InsertReasignacion(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_MovimientoCuentaConciliacion_InsertReasignacion";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
            
        }

        //GESTION DE CUENTA (CONCILIACION)
        //INSERT SALDO FINAL A MOVIMIENTO CUENTA CONCILIACION
        public int MovimientoCuentaConciliacion_InsertSaldoFinal(ProduccionEstablecimiento objProduccionEstablecimiento)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_MovimientoCuentaConciliacion_InsertSaldoFinal";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", objProduccionEstablecimiento.CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //VERIFICAR PRODUCCION ESTABLECIMIENTO CONCILIACION
        public DataTable ProduccionEstablecimientoConciliacion_Verificar()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_ProduccionEstablecimientoConciliacion_Verificar";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetAllProduccionEstablecimiento_CM()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAllProduccionEstablecimiento_CM";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }


        public DataTable GetProduccionEstablecimiento_ProduccionCM()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProduccionEstablecimiento_ProduccionCM";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetProduccionEstablecimiento_EstablecimientoCM()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProduccionEstablecimiento_EstablecimientoCM";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetProduccionEstablecimiento_ProduccionCN()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProduccionEstablecimiento_ProduccionCN";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetProduccionEstablecimiento_EstablecimientoCN()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProduccionEstablecimiento_EstablecimientoCN";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetAllProduccionEstablecimiento_CN()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetAllProduccionEstablecimiento_CN";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetProduccionesAnterioresSinConciliarPorProduccionIpress(string codigoProduccion, int establecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetProduccionesAnterioresSinConciliarPorProduccionIpress";
                cmd.Parameters.AddWithValue("@Codigo", codigoProduccion);
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        public DataTable GetCodigoProduccionControlPorControlMedico(string codigoControlMedico)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetCodigoProduccionControlPorControlMedico";
                if(string.IsNullOrEmpty(codigoControlMedico))
                    cmd.Parameters.AddWithValue("@CodigoControlMedico", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@CodigoControlMedico", Convert.ToInt32(codigoControlMedico));
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (SUPERVISION DE AVANCES)
        public DataTable SupervisionGestionCta()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_SupervisionGestionCta";
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (DETALLE DE PRODUCCIONES)
        public DataTable SupervisionGestionCta_Detalle(int CodigoControlMedico, int EstablecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_SupervisionGestionCta_Detalle";
                cmd.Parameters.AddWithValue("@CodigoControlMedico", CodigoControlMedico);
                cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }

        //GESTION DE CUENTA (FUAS X PRODUCCIONES)
        public DataTable SupervisionGestionCta_DetalleFuas(DateTime ProduccionFissal, int EstablecimientoId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_SupervisionGestionCta_DetalleFuas";
                cmd.Parameters.AddWithValue("@ProduccionFissal", ProduccionFissal);
                cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
                return Datos.ObtenerDatosProcedure(cmd);
            }
        }
    }
}
