using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FissalDA;
using FissalBE;
using System.Data;

namespace FissalBL
{
    public class PaqueteBL
    {
        private PaqueteDA objPaqueteDA;
        
        // constructor
        public PaqueteBL()
        {
            objPaqueteDA = new PaqueteDA();
        }

        //OBTIENE VISTA PAQUETE POR ID
        public vw_paquete GetVWPaquetePorId(int tratamientoId)
        {
            return objPaqueteDA.GetVWPaquetePorId(tratamientoId);
        }

        public DataTable GetVWPaquetePorEstablecimientoId(int establecimientoId)
        {
            return objPaqueteDA.GetVWPaquetePorEstablecimientoId(establecimientoId);
        }

        public int GetIdDiagnosticoAsociado(int establecimientoId)
        {
            return objPaqueteDA.GetIdDiagnosticoAsociado(establecimientoId);
        }

        public bool ExisteIdDiagnosticoAsociado(int establecimientoId)
        {
            return objPaqueteDA.ExisteIdDiagnosticoAsociado(establecimientoId);
        }

        //MAESTRO PAQUETE

        //LISTA DE PAQUETES X ESTABLECIMIENTO
        public DataTable Paquete_ListarxEstablecimientoId(int EstablecimientoId)
        {
            return objPaqueteDA.Paquete_ListarxEstablecimientoId(EstablecimientoId);
        }

        //LISTA DE VERSIONES X TRATAMIENTO
        public DataTable Tratamiento_ListarxTratamientoId(int TratamientoId)
        {
            return objPaqueteDA.Tratamiento_ListarxTratamientoId(TratamientoId);
        }

        //LISTA DE PAQUETE MEDICAMENTO
        public DataTable Paquete_PaqueteMedicamentos(int TratamientoId, int Version)
        {
            return objPaqueteDA.Paquete_PaqueteMedicamentos(TratamientoId, Version);
        }

        //LISTA DE PAQUETE PROCEDIMIENTO
        public DataTable Paquete_PaqueteProcedimientos(int TratamientoId, int Version)
        {
            return objPaqueteDA.Paquete_PaqueteProcedimientos(TratamientoId, Version);
        }

        //LISTA DE PAQUETES X TRATAMIENTO
        public DataTable Paquete_ListarxTratamientoId(int TratamientoId)
        {
            return objPaqueteDA.Paquete_ListarxTratamientoId(TratamientoId);
        }

        //VERIFICAR PAQUETE DUPLICADO
        public DataTable Paquete_VerificarDuplicadoPaquete(Paquete objPaquete)
        {
            return objPaqueteDA.Paquete_VerificarDuplicadoPaquete(objPaquete);
        }

        //INSERTAR PAQUETE
        public int Paquete_Insert(Paquete objPaquete)
        {
            return objPaqueteDA.Paquete_Insert(objPaquete);
        }

        //UPDATE PAQUETE
        public int Paquete_Update(Paquete objPaquete)
        {
            return objPaqueteDA.Paquete_Update(objPaquete);
        }
    }
}
