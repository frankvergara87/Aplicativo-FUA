using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class EstadoCuentaConciliacionDA
    {
        static SqlCommand cmd;

        public EstadoCuentaConciliacionDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA ESTADO CUENTA CONCILIACION
        public DataTable EstadoCuentaConciliacion_Listar(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_Listar";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", objEstadoCuentaConciliacion.CodigoConciliacion);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VERIFICAR ESTADO PENDIENTE EN ESTADO CUENTA CONCILIACION
        public DataTable EstadoCuentaConciliacion_VerificarPendiente(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_VerificarPendiente";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", objEstadoCuentaConciliacion.CodigoConciliacion);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //UPDATE ACTIVO FISSAL EN ESTADO CUENTA CONCILIACION (CON CONSUMO)
        public int EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateActivoFissalConConsumo";            
            cmd.Parameters.AddWithValue("@CodigoConciliacion", objEstadoCuentaConciliacion.CodigoConciliacion);
            return Datos.Mantenimiento(cmd);
        }

        //UPDATE ACTIVO FISSAL EN ESTADO CUENTA CONCILIACION (SIN CONSUMO)
        public int EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", objEstadoCuentaConciliacion.CodigoConciliacion);
            return Datos.Mantenimiento(cmd);
        }

        //UPDATE ESTADO EN ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_UpdateEstado(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateEstado";
            cmd.Parameters.AddWithValue("@CodigoConciliacion", objEstadoCuentaConciliacion.CodigoConciliacion);
            return Datos.Mantenimiento(cmd);
        }

        //UPDATE ACTIVO SIS EN ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_UpdateActivoSIS(string Paciente, string ActivoSIS, int CodConciliacion)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateActivoSIS";
                cmd.Parameters.AddWithValue("@Paciente", Paciente);
                cmd.Parameters.AddWithValue("@ActivoSis", ActivoSIS);
                cmd.Parameters.AddWithValue("@CodigoConciliacion", CodConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }


        //OBTIENE LISTA PACIENTE
        public List<string> EstadoCuentaConciliacion_ListarPaciente(int codigoConciliacion)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_ListarPaciente";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", codigoConciliacion);
                List<string> listaPacientes = new List<string>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaPacientes.Add(dr["PacienteId"].ToString());
                    }
                }
                return listaPacientes;
            }
        }

        //OBTIENE LISTA ESTADO CUENTA CONCILIACION
        public Paciente EstadoCuentaConciliacion_ListarPacientexDni(string PacienteId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                Paciente objPaciente = null;
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_ListaPacientexDni";
                cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        objPaciente = new Paciente();
                        objPaciente.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        objPaciente.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                        objPaciente.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                        objPaciente.Nombres = dr["Nombres"].ToString();

                        if (dr["Nacimiento"].ToString() == DBNull.Value.ToString())
                        {
                            objPaciente.Nacimiento = null;
                        }
                        else
                        {
                            DateTime val = Convert.ToDateTime(dr["Nacimiento"]);
                            objPaciente.OtrosNombres = val.ToString("dd/MM/yyyy"); 
                        }
                        objPaciente.SexoId = Convert.ToByte(dr["SexoId"].ToString());
                        objPaciente.PacienteId = dr["PacienteId"].ToString();
                        objPaciente.Historia = dr["Entidad"].ToString();  // usado para traer valor [CORREGIR]                   
                    }
                }

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                return objPaciente;
            }
        }



        //UPDATE RENIEC X N° DOCUMENTO
        public int EstadoCuentaConciliacion_UpdateReniec(int CodigoConciliacion)
        {
            using (SqlCommand cmd = new SqlCommand())
            { 
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateReniec";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", CodigoConciliacion);
                return Datos.Mantenimiento(cmd);
            }
        }

        //ANULAR ESTADO CUENTA CONCILIACION
        public int EstadoCuentaConciliacion_Anular(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_Anular";
            cmd.Parameters.AddWithValue("@EstadoCuentaConciliacionId", objEstadoCuentaConciliacion.EstadoCuentaConciliacionId);
            return Datos.Mantenimiento(cmd);
        }

        //OBTENER LISTADO DE PACIENTES
        public DataTable EstadoCuentaConciliacion_ListadoReniec()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_ListadoReniec";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //ANULAR AUTORIZACION X ESTADO CUENTA CONCILIACION
        public int Autorizacion_Anular(EstadoCuentaConciliacion objEstadoCuentaConciliacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_cta_Autorizacion_Anular";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objEstadoCuentaConciliacion.EstablecimientoId);
            cmd.Parameters.AddWithValue("@PacienteId", objEstadoCuentaConciliacion.PacienteId);
            cmd.Parameters.AddWithValue("@CadenaId", objEstadoCuentaConciliacion.CadenaId);
            return Datos.Mantenimiento(cmd);
        }

        public void EstadoCuentaConciliacion_UpdateActivoFissalConConsumo(int codigoConciliacion, int establecimientoId)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateActivoFissalConConsumo";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", codigoConciliacion);
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                Datos.Mantenimiento(cmd);
            }
        }

        public void EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo(int codigoConciliacion, int establecimientoId)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_cta_EstadoCuentaConciliacion_UpdateActivoFissalSinConsumo";
                cmd.Parameters.AddWithValue("@CodigoConciliacion", codigoConciliacion);
                cmd.Parameters.AddWithValue("@EstablecimientoId", establecimientoId);
                Datos.Mantenimiento(cmd);
            }
        }
    }
}
