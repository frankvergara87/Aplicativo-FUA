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
    public class MovimientoMedicamentoBL
    {
        private MovimientoMedicamentoDA objMovimientoMedicamentoDA;
        public MovimientoMedicamentoBL()
        {
            objMovimientoMedicamentoDA = new MovimientoMedicamentoDA();
        }

        //OBTIENE LISTA MOVIMIENTO MEDICAMENTO POR FUA
        public List<vw_movimientoPacienteMedicamento> GetVwMovimientoPacienteMedicamentoPorFua(Int64 fua)
        {
            return objMovimientoMedicamentoDA.GetVwMovimientoPacienteMedicamentoPorFua(fua);
        }

        //OBTIENE LISTA MOVIMIENTO MEDICAMENTO POR FUA
        public DataTable MovimientoMedicamento_ListarxFua(MovimientoMedicamento objMovimientoMedicamento)
        {
            return objMovimientoMedicamentoDA.MovimientoMedicamento_ListarxFua(objMovimientoMedicamento);
        }

        // INSERTAR NUEVO MOVIMIENTO MEDICAMENTO
        public int MovimientoMedicamento_Insertar(MovimientoMedicamento ObjMovimientoMedicamento)
        {
            return objMovimientoMedicamentoDA.MovimientoMedicamento_Insertar(ObjMovimientoMedicamento);
        }

        // ACTUALIZA MOVIMIENTO MEDICAMENTO
        public int MovimientoMedicamento_Actualizar(MovimientoMedicamento ObjMovimientoMedicamento)
        {
            return objMovimientoMedicamentoDA.MovimientoMedicamento_Actualizar(ObjMovimientoMedicamento);
        }

        // ACTUALIZA MOVIMIENTO MEDICAMENTO - CM
        public int GuardarControlMedicoMedicamentoAtencion(vw_movimientoPacienteMedicamento ObjMovimientoMedicamento)
        {
            return objMovimientoMedicamentoDA.GuardarControlMedicoMedicamentoAtencion(ObjMovimientoMedicamento);
        }

        // ELIMINA MOVIMIENTO MEDICAMENTO
        public int MovimientoMedicamento_Eliminar(MovimientoMedicamento ObjMovimientoMedicamento)
        {
            return objMovimientoMedicamentoDA.MovimientoMedicamento_Eliminar(ObjMovimientoMedicamento);
        }
    }
}
