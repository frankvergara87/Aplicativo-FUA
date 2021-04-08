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
    public class PacienteBL
    {
        PacienteDA objPacienteDA;
        
        // constructor
        public PacienteBL()
        {
            objPacienteDA = new PacienteDA();
        }

        public DataTable Paciente_PacienteXDocumentoId(Paciente ObjPaciente)
        {
            try
            {
                return objPacienteDA.Paciente_PacienteXDocumentoId(ObjPaciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //OBTIENE PACIENTE POR ID
        public Paciente GetPacientePorId(string pacienteId)
        {
            return objPacienteDA.GetPacientePorId(pacienteId);
        }

        //OBTIENE PACIENTE POR TIPO Y NUMERO DE DOCUMENTO
        public Paciente GetPacientePorTipoNumeroDocumento(byte tipoDocumentoId, string numeroDocumento)
        {
            return objPacienteDA.GetPacientePorTipoNumeroDocumento(tipoDocumentoId, numeroDocumento);
        }

        public Paciente GetPacientePorNumeroDocumento(string numeroDocumento)
        {
            return objPacienteDA.GetPacientePorNumeroDocumento(numeroDocumento);
        }

        public Paciente Paciente_PacientexId(string pacienteId, int TipoDocumento ,int EstablecimientoId)
        {
            return objPacienteDA.Paciente_PacientexId(pacienteId, TipoDocumento, EstablecimientoId);
        }

        public Paciente Paciente_PacientexHistoria(string Historia, int TipoDocumento, int EstablecimientoId)
        {
            return objPacienteDA.Paciente_PacientexHistoria(Historia, TipoDocumento, EstablecimientoId);
        }

        public Paciente Guardar(Paciente objPaciente)
        {
            if (objPacienteDA.ExistePaciente(objPaciente.PacienteId))
                return objPacienteDA.ActualizarPaciente(objPaciente);
            else
                return objPacienteDA.RegistrarPaciente(objPaciente);
        }

        public Paciente GuardarPaciente(Paciente objPaciente)
        {
            if (objPacienteDA.ExisteDocumentoPaciente(objPaciente))
                return objPacienteDA.ActualizarPacienteWeb(objPaciente);
            else
                return objPacienteDA.RegistrarPacienteWeb(objPaciente);
        }

        public DataTable Paciente_ValidadoOff()
        {
            return objPacienteDA.Paciente_ValidadoOff();
        }


        public DataTable GetPacientesBuscadorSelectorPacientes(Paciente objPaciente)
        {
            return objPacienteDA.GetPacientesBuscadorSelectorPacientes(objPaciente);
        }

        public List<int> RegistrarPacienteDesdeWS(Paciente bePaciente) 
        {
            return objPacienteDA.RegistrarDesdeWS(bePaciente);          
        }
    }
}
