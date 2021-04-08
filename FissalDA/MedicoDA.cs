using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;

namespace FissalDA
{
    public class MedicoDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE NOMBRE | CMP | ESPECIALIDAD
        public DataTable Medico_BuscarxDNI(Medico objMedico)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_BuscarxDNI";
            cmd.Parameters.AddWithValue("@DniDoctor", objMedico.DniDoctor);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA DE MEDICOS DNI | NOMBRE | CMP | ESPECIALIDAD
        public DataTable Medico_Filtrar(Medico objMedico)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_Filtrar";
            cmd.Parameters.AddWithValue("@cadena", objMedico.NombreDoctor);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //INSERTAR PROFESIONAL
        public int Medico_Insert(Medico objMedico)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_Insert";
            cmd.Parameters.AddWithValue("@DniDoctor", objMedico.DniDoctor);
            cmd.Parameters.AddWithValue("@NombreDoctor", objMedico.NombreDoctor);
            cmd.Parameters.AddWithValue("@Cmp", objMedico.Cmp);
            cmd.Parameters.AddWithValue("@Especialidad", objMedico.Especialidad);
            return Datos.Mantenimiento(cmd);
        }

        //ACTUALIZAR PROFESIONAL
        public int Medico_Update(Medico objMedico)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_Update";
            cmd.Parameters.AddWithValue("@DniDoctor", objMedico.DniDoctor);
            cmd.Parameters.AddWithValue("@NombreDoctor", objMedico.NombreDoctor);
            cmd.Parameters.AddWithValue("@Cmp", objMedico.Cmp);
            cmd.Parameters.AddWithValue("@Especialidad", objMedico.Especialidad);
            return Datos.Mantenimiento(cmd);
        }

        //ELIMINAR PROFESIONAL
        public int Medico_Delete(Medico objMedico)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_Delete";
            cmd.Parameters.AddWithValue("@DniDoctor", objMedico.DniDoctor);            
            return Datos.Mantenimiento(cmd);
        }

        //LISTAR ESPECIALIDAD DE PROFESIONAL
        public DataTable Medico_EspecialidadListar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_EspecialidadListar";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //LISTAR PROFESIONAL X DNI
        public int Medico_ListarxDNI(Medico objMedico)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_Medico_ListarxDNI";
            cmd.Parameters.AddWithValue("@DniDoctor", objMedico.DniDoctor);
            return Datos.Mantenimiento(cmd);
        }
    }
}
