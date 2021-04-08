using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FissalDA;
using FissalBE;

namespace FissalBL
{
    public class MedicoBL
    {
        MedicoDA objMedicoDA = new MedicoDA();

        public DataTable Medico_BuscarxDNI(Medico objMedico)
        {
            try
            {
                return objMedicoDA.Medico_BuscarxDNI(objMedico);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        //OBTIENE LISTA DE MEDICOS DNI | NOMBRE | CMP | ESPECIALIDAD
        public DataTable Medico_Filtrar(Medico objMedico)
        {
            try
            {
                return objMedicoDA.Medico_Filtrar(objMedico);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        //INSERTAR PROFESIONAL
        public int Medico_Insert(Medico objMedico)
        {
            return objMedicoDA.Medico_Insert(objMedico);
        }

        //ACTUALIZAR PROFESIONAL
        public int Medico_Update(Medico objMedico)
        {
            return objMedicoDA.Medico_Update(objMedico);
        }

        //ELIMINAR PROFESIONAL
        public int Medico_Delete(Medico objMedico)
        {
            return objMedicoDA.Medico_Delete(objMedico);
        }

        //LISTAR ESPECIALIDAD DE PROFESIONAL
        public DataTable Medico_EspecialidadListar()
        {
            return objMedicoDA.Medico_EspecialidadListar();
        }

        //LISTAR PROFESIONAL X DNI
        public int Medico_ListarxDNI(Medico objMedico)
        {
            return objMedicoDA.Medico_ListarxDNI(objMedico);
        }
    }
}
