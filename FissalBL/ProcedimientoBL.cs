using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalDA;
using System.Data;

namespace FissalBL
{
    public class ProcedimientoBL
    {
        private ProcedimientoDA objProcedimientoAD;
        
        // constructor
        public ProcedimientoBL()
        {
            objProcedimientoAD = new ProcedimientoDA();
        }        
        
        //OBTIENE LISTA PROCEDIMIENTOS X DESCRIPCION O  PROCEDIMIENTO_ID
        public DataTable GetProcedimientosPorIdDescripcion(string procedimiento)
        {
            return objProcedimientoAD.GetProcedimientosPorIdDescripcion(procedimiento);
        }

        //public DataTable Procedimiento_CostoProcedimiento(string SisId, int EstablecimientoId, int AutorizacionId, string FechaAtencion)
        //{
        //    try
        //    {
        //        return objProcedimientoAD.Procedimiento_CostoProcedimiento(SisId, EstablecimientoId, AutorizacionId, FechaAtencion);                    
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public DataTable Procedimiento_CostoProcedimiento(int ProcedimientoId, int EstablecimientoId, int AutorizacionId, string FechaAtencion)
        {
            try
            {
                return objProcedimientoAD.Procedimiento_CostoProcedimiento(ProcedimientoId, EstablecimientoId, AutorizacionId, FechaAtencion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //OBTIENE PROCEDIMIENTO - CODIGO | DESCRIPCION
        public DataTable Procedimiento_Verificar(int EstablecimientoId, string SisId, DateTime FechaAtencion)
        {
            try
            {
                return objProcedimientoAD.Procedimiento_Verificar(EstablecimientoId, SisId, FechaAtencion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Procedimiento_VerificarSisId(int EstablecimientoId, string SisId, DateTime FechaAtencion)
        {
            try
            {
                return objProcedimientoAD.Procedimiento_VerificarSisId(EstablecimientoId, SisId, FechaAtencion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //OBTIENE LISTA DE PROCEDIMIENTOS ProcedimientoId | Descripcion | SisId
        public DataTable Procedimiento_Filtrar(int EstablecimientoId, DateTime FechaAtencion, string Descripcion)
        {
            try
            {
                return objProcedimientoAD.Procedimiento_Filtrar(EstablecimientoId, FechaAtencion, Descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
