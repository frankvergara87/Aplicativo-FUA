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
    public class EstadoCuentaConciliacionBL
    {
        EstadoCuentaConciliacionDA objEstadoCuentaConciliacionDA = new EstadoCuentaConciliacionDA();

        //OBTIENE LISTA ESTADO CUENTA CONCILIACION
        public DataTable EstadoCuentaConciliacion_Listar(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_Listar(objEstadoCuentaConciliacion);
        }

        //VERIFICAR ESTADO PENDIENTE EN ESTADO CUENTA CONCILIACION
        public DataTable EstadoCuentaConciliacion_VerificarPendiente(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_VerificarPendiente(objEstadoCuentaConciliacion);
        }

        //UPDATE ACTIVO FISSAL EN ESTADO CUENTA CONCILIACION (CON CONSUMO)
        public int EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(objEstadoCuentaConciliacion);
        }

        //UPDATE ACTIVO FISSAL EN ESTADO CUENTA CONCILIACION (SIN CONSUMO)
        public int EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(objEstadoCuentaConciliacion);
        }

        //UPDATE ESTADO EN ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_UpdateEstado(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateEstado(objEstadoCuentaConciliacion);
        }


        //UPDATE ACTIVO SIS EN ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_UpdateActivoSIS(string Paciente, string ActivoSIS, int CodConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateActivoSIS(Paciente, ActivoSIS, CodConciliacion);
        }



        //OBTIENE LISTA PACIENTE
        public List<string> EstadoCuentaConciliacion_ListarPaciente(int codigoConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_ListarPaciente(codigoConciliacion);
        }


        public Paciente EstadoCuentaConciliacion_ListarPacientexDni(string PacienteId)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_ListarPacientexDni(PacienteId);
        }

        //UPDATE ESTADO RENIEC X N° DOCUMENTO
        public int EstadoCuentaConciliacion_UpdateReniec(int CodigoConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateReniec(CodigoConciliacion);
        }

        //ANULAR ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_Anular(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_Anular(objEstadoCuentaConciliacion);
        }

        //OBTIENE LISTADO DE PACIENTES RENIEC
        public DataTable EstadoCuentaConciliacion_ListadoReniec()
        {
            return objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_ListadoReniec();
        }

        //ANULAR AUTORIZACION X ESTADO CUENTA CONCILIACION
        public int Autorizacion_Anular(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            return objEstadoCuentaConciliacionDA.Autorizacion_Anular(objEstadoCuentaConciliacion);
        }

        public void EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(int codigoConciliacion, int establecimientoId)
        {
            objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(codigoConciliacion,establecimientoId);
        }

        public void EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(int codigoConciliacion, int establecimientoId)
        {
            objEstadoCuentaConciliacionDA.EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(codigoConciliacion,establecimientoId);
        }
    }
}
