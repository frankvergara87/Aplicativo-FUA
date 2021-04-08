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
    public class ControlMedicoLogBL
    {
        private ControlMedicoLogDA objControlMedicoLogAD;

        public ControlMedicoLogBL()
        {
            objControlMedicoLogAD = new ControlMedicoLogDA();
        }

        //OBTIENE LISTA CONTROL MEDICO POR FUA
        public DataTable GetVwControlMedicoLogPorFua(Int64 fua)
        {
            return objControlMedicoLogAD.GetVwControlMedicoLogPorFua(fua);
        }

        // INSERTAR CONTROL MEDICO
        public int GuardarControlMedicoLog(ControlMedicoLog ObjControlMedicoLog)
        {
            return objControlMedicoLogAD.GuardarControlMedicoLog(ObjControlMedicoLog);
        }

        public DateTime GetDatePrimerControlFua(Int64 fua)
        {
            return objControlMedicoLogAD.GetDatePrimerControlFua(fua);
        }

        public bool SePuedeEditarControlMedico(Int64 fua)
        {
            return objControlMedicoLogAD.SePuedeEditarControlMedico(fua);
        }

        /** FUNCIONES CONTROL MEDICO [DUAS OBSERVADOS] 24-03-2015 *********/

        public DataTable Filtrar_ControlMedico()
        {
            return objControlMedicoLogAD.Filtrar_ControlMedico();
        }

        public DataTable Filtrar_Establecimiento()
        {
            return objControlMedicoLogAD.Filtrar_Establecimiento();
        }

        public DataTable Listado_Fuas(int ControlMedico, int EstablecimientoId)
        {
            return objControlMedicoLogAD.Listado_Fuas(ControlMedico, EstablecimientoId);
        }


        public int Contador_Fuas(int Valor, int EstablecimientoId, int CodigoCMedico)
        {
            return objControlMedicoLogAD.Contador_Fuas(Valor, EstablecimientoId, CodigoCMedico);
        }


        public DataTable Exportar_ListadoFuas(int EstablecimientoId, int CodigoCMedico)
        {
            return objControlMedicoLogAD.Exportar_ListadoFuas(EstablecimientoId, CodigoCMedico);
        }

        public DataTable Exportar_ListadoTotalFuas(int EstablecimientoId, int CodigoCMedico)
        {
            return objControlMedicoLogAD.Exportar_ListadoTotalFuas(EstablecimientoId, CodigoCMedico);
        }

        /******************************************/


    }
}
