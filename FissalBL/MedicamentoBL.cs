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
    public class MedicamentoBL
    {
         private MedicamentoDA objMedicamentoDA;
        
        // constructor
         public MedicamentoBL()
        {
            objMedicamentoDA = new MedicamentoDA();
        }

         //OBTIENE LISTA MEDICAMENTOS X DESCRIPCION O  MEDICAMENTO_ID
         public DataTable GetMedicamentosPorIdDescripcion(string medicamento)
        {
            return objMedicamentoDA.GetMedicamentosPorIdDescripcion(medicamento);
        }
        public DataTable Esquema_EsquemaCategoria(string CategoriaId, int EstadioId)
        {
            try
            {
                return objMedicamentoDA.Esquema_EsquemaCategoria(CategoriaId, EstadioId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Esquema_EsquemaCategoria2()
        {
            try
            {
                return objMedicamentoDA.Esquema_EsquemaCategoria2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Medicamento_CostoMedicamento(int MedicamentoId, int EstablecimientoId, int AutorizacionId, string FechaAtencion)
        {
            try
            {
                return objMedicamentoDA.Medicamento_CostoMedicamento(MedicamentoId, EstablecimientoId, AutorizacionId, FechaAtencion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //OBTIENE MEDICAMENTO - CODIGO | DESCRIPCION
        public DataTable Medicamento_Verificar(Medicamento objMedicamento)
        {
            try
            {
                return objMedicamentoDA.Medicamento_Verificar(objMedicamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //OBTIENE LISTA DE MEDICAMENTOS MedicamentoId | Descripcion | DigemidId
        public DataTable Medicamento_Filtrar(Medicamento objMedicamento)
        {
            try
            {
                return objMedicamentoDA.Medicamento_Filtrar(objMedicamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
