using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;
using FissalBE;

namespace FissalBL
{
    public class MovimientoProcedimientoBL
    {
        private MovimientoProcedimientoDA objMovimientoProcedimientoDA;
        public MovimientoProcedimientoBL()
        {
            objMovimientoProcedimientoDA = new MovimientoProcedimientoDA();
        }

        //OBTIENE LISTA VW MOVIMIENTO PROCEDIMIENTO POR FUA
        public List<vw_MovimientoPacienteProcedimiento> GetVwMovimientoPacienteProcedimientoPorFua(Int64 fua)
        {
            return objMovimientoProcedimientoDA.GetVwMovimientoPacienteProcedimientoPorFua(fua);
        }

        //OBTIENE LISTA MOVIMIENTO PROCEDIMIENTO POR FUA
        public DataTable MovimientoProcedimiento_ListarxFua(MovimientoProcedimiento objMovimientoProcedimiento)
        {
            return objMovimientoProcedimientoDA.MovimientoProcedimiento_ListarxFua(objMovimientoProcedimiento);
        }

        // INSERTAR UN NUEVO MOVIMIENTO PROCEDIMIENTO
        public int MovimientoProcedimiento_Insertar(MovimientoProcedimiento ObjMovimientoProcedimiento)
        {
            return objMovimientoProcedimientoDA.MovimientoProcedimiento_Insertar(ObjMovimientoProcedimiento);
        }

        // ACTUALIZAR MOVIMIENTO PROCEDIMIENTO
        public int MovimientoProcedimiento_Actualizar(MovimientoProcedimiento ObjMovimientoProcedimiento)
        {
            return objMovimientoProcedimientoDA.MovimientoProcedimiento_Actualizar(ObjMovimientoProcedimiento);
        }

        // ACTUALIZAR MOVIMIENTO PROCEDIMIENTO - CM
        public int GuardarControlMedicoProcedimientoAtencion(vw_MovimientoPacienteProcedimiento ObjMovimientoProcedimiento)
        {
            return objMovimientoProcedimientoDA.GuardarControlMedicoProcedimientoAtencion(ObjMovimientoProcedimiento);
        }

        // ELIMINAR MOVIMIENTO PROCEDIMIENTO
        public int MovimientoProcedimiento_Eliminar(MovimientoProcedimiento ObjMovimientoProcedimiento)
        {
            return objMovimientoProcedimientoDA.MovimientoProcedimiento_Eliminar(ObjMovimientoProcedimiento);
        }
    }
}
