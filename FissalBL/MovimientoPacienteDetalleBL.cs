using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalDA;

namespace FissalBL
{
    public class MovimientoPacienteDetalleBL
    {
        MovimientoPacienteDetalleDA objMovimientoPacienteDetalleDA = new MovimientoPacienteDetalleDA();
        public MovimientoPacienteDetalleBL()
        {
            objMovimientoPacienteDetalleDA = new MovimientoPacienteDetalleDA();
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE DETALLE POR FUA
        public List<vw_MovimientoPacienteDetalle> GetVwMovimientoPacienteDetallePorFua(Int64 fua)
        {
            return objMovimientoPacienteDetalleDA.GetVwMovimientoPacienteDetallePorFua(fua);
        }

        //GENERAR NUEVO NUMERO DE DETALLEID
        public DataTable MovimientoPacienteDetalle_NuevoDetalleId(MovimientoPacienteDetalle objMovimientoPacienteDetalle)
        {
            return objMovimientoPacienteDetalleDA.MovimientoPacienteDetalle_NuevoDetalleId(objMovimientoPacienteDetalle);
        }

        //OBTIENE LISTA MOVIMIENTOPACIENTEDETALLE POR FUA
        public DataTable MovimientoPacienteDetalle_ListarxFua(MovimientoPacienteDetalle objMovimientoPacienteDetalle)
        {
            return objMovimientoPacienteDetalleDA.MovimientoPacienteDetalle_ListarxFua(objMovimientoPacienteDetalle);
        }

        // INSERTAR NUEVO MOVIMIENTO PACIENTE DETALLE
        public int MovimientoPacienteDetalle_Insertar(MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            return objMovimientoPacienteDetalleDA.MovimientoPacienteDetalle_Insertar(ObjMovimientoPacienteDetalle);
        }

        // ACTUALIZAR MOVIMIENTO PACIENTE DETALLE
        public int MovimientoPacienteDetalle_Actualizar(MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            return objMovimientoPacienteDetalleDA.MovimientoPacienteDetalle_Actualizar(ObjMovimientoPacienteDetalle);
        }

        // ACTUALIZAR MOVIMIENTO PACIENTE DETALLE - CM
        public int GuardarControlMedicoDetalleAtencion(vw_MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            return objMovimientoPacienteDetalleDA.GuardarControlMedicoDetalleAtencion(ObjMovimientoPacienteDetalle);
        }

        // ELIMINAR MOVIMIENTO PACIENTE DETALLE
        public int MovimientoPacienteDetalle_Eliminar(MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            return objMovimientoPacienteDetalleDA.MovimientoPacienteDetalle_Eliminar(ObjMovimientoPacienteDetalle);
        }
    }
}
