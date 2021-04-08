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
    public class MovimientoPacienteDA
    {
        static SqlCommand cmd;

        public MovimientoPacienteDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE
        public DataTable MovimientoPaciente_Listar()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp_MovimientoPaciente_Listar";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR BUSCADOR
        public DataTable ListarMovimientoPacienteBuscadorCM(string consulta)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = consulta;
            return Datos.ObtenerDatosSql(cmd);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR FUA
        public DataTable MovimientoPaciente_ListarxFua(MovimientoPaciente objMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_ListarxFua";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoPaciente.Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR PARAMETROS
        public DataTable MovimientoPaciente_Filtrar(int NroOpc, string anno, string correlativo, int TipoDocumentoId, string DNI, string Nombre, DateTime FecIni, DateTime FecFin, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_Filtrar";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@correlativo", correlativo);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumentoId);
            cmd.Parameters.AddWithValue("@DNI", DNI);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA MOVIMIENTO PACIENTE POR PARAMETROS (ADMINISTRADOR)
        public DataTable MovimientoPaciente_FiltrarxAdministrador(int NroOpc, string anno, string correlativo, int TipoDocumentoId, string DNI, string Nombre, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_FiltrarxAdministrador";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@anno", anno);
            cmd.Parameters.AddWithValue("@correlativo", correlativo);
            cmd.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumentoId);
            cmd.Parameters.AddWithValue("@DNI", DNI);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA DE MOVIMIENTO PACIENTE POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoPaciente_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_MovimientoPaciente_Exportar";            
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA DE MOVIMIENTO PACIENTE DETALLE POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoPacienteDetalle_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_MovimientoPacienteDetalle_Exportar";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA DE MOVIMIENTO MEDICAMENTO POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoMedicamento_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_MovimientoMedicamento_Exportar";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE LISTA DE MOVIMIENTO PROCEDIMIENTO POR POR PARAMETROS (EstablecimientoId, FecIni, FecFin)
        public DataTable MovimientoProcedimiento_Exportar(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_MovimientoProcedimiento_Exportar";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE MEDICAMENTOS Y PROCEDIMIENTOS NO VALORIZADOS
        public DataTable MedicamentoProcedimiento_SinValorizacion(int NroOpc, string EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MedicamentoProcedimiento_SinValorizacion";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);            
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE MEDICAMENTOS Y PROCEDIMIENTOS NO VALORIZADOS X FECHA
        public DataTable MedicamentoProcedimiento_SinValorizacionxFecha(int NroOpc, string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MedicamentoProcedimiento_SinValorizacionxFecha";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS NO VALORIZADOS
        public DataTable MovimientoPaciente_SinValorizacion(int NroOpc, string EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_SinValorizacion";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS VALORIZADOS PARCIALMENTE
        public DataTable MovimientoPaciente_ValorizacionParcial(int NroOpc, string EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionParcial";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS VALORIZADOS AL 100%
        public DataTable MovimientoPaciente_ValorizacionTotal(int NroOpc, string EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionTotal";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE FUAS VALORIZADOS TOTALES (PARCIAL + AL 100%)
        public DataTable MovimientoPaciente_ValorizacionParcialTotal(int NroOpc, string EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionParcialTotal";
            cmd.Parameters.AddWithValue("@Nro", NroOpc);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE MEDICAMENTOS Y PROCEDIMIENTOS NO VALORIZADOS X MES
        public DataTable MedicamentoProcedimiento_SinValorizacionxMes()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MedicamentoProcedimiento_SinValorizacionxMes";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA DE CONSUMO VALORIZADO X ESTABLECIMIENTOS 
        public DataTable MovimientoPaciente_ValorizacionGlobal()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionGlobal";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA CONSUMO VALORIZADO DE PACIENTES X ESTABLECIMIENTOS 
        public DataTable MovimientoPaciente_ValorizacionxEstablecimiento(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionxEstablecimiento";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA CONSUMO VALORIZADO DE FUAS X PACIENTES
        public DataTable MovimientoPaciente_ValorizacionxPaciente(string PacienteId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionxPaciente";
            cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA CONSUMO MEDICAMENTO | PROCEDIMIENTO X FUA
        public DataTable MovimientoMedicamentoProcedimiento_ListarxFua(int Fua)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoMedicamentoProcedimiento_ListarxFua";
            cmd.Parameters.AddWithValue("@Fua", Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE FECHAS MAXIMAS DE TARIFARIO CONVENIO | SIS | DIGEMID
        public DataTable Tarifario_GetFechaMaxima()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_Tarifario_GetFechaMaxima";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA VALORIZADA DE MEDICAMENTOS
        public DataTable MovimientoMedicamento_Proceso_Valorizacion()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp_MovimientoMedicamento_Proceso_Valorizacion";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA VALORIZADA DE PROCEDIMIENTOS
        public DataTable MovimientoProcedimiento_Proceso_Valorizacion()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp_MovimientoProcedimiento_Proceso_Valorizacion";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //OBTIENE LISTA VALORIZADA DE FUAS
        public DataTable MovimientoPaciente_Proceso_TotalesValorizados()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp_MovimientoPaciente_Proceso_TotalesValorizados";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VALORIZACION
        //VALORIZACION PRELIMINAR
        public DataTable MovimientoPaciente_ValorizacionPreliminar(int? EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_val_MovimientoPaciente_ValorizacionPreliminar";            
            if (EstablecimientoId == null)
                cmd.Parameters.AddWithValue("@EstablecimientoId", DBNull.Value);                
            else
                cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);  
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GESTION DE CUENTA
        //OBTIENE LISTA DE ABONO x PacienteId | EstablecimientoId
        public DataTable GestionCta_AbonoxPacienteIdEstablecimientoId(string PacienteId, int EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_GestionCta_AbonoxPacienteIdEstablecimientoId";
            cmd.Parameters.AddWithValue("@PacienteId", PacienteId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //ESTADISTICAS
        //OBTIENE RESUMEN DE ATENDIDOS POR ESTADIO
        public DataTable Atencion_AtendidosxEstadio(DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Atencion_AtendidosxEstadio";
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE FECHA REGISTRO | FECHA SERVIDOR DE MOVIMIENTO PACIENTE POR FUA
        public DataTable MovimientoPaciente_GetFechaRegistroServidor(MovimientoPaciente objMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_GetFechaRegistroServidor";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoPaciente.Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //OBTIENE FECHA SERVIDOR
        public DataTable MovimientoPaciente_GetFechaServidor()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_GetFechaServidor";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //VERIFICAR NUMERO DUPLICADO DE FUA
        public DataTable MovimientoPaciente_Verificar(MovimientoPaciente objMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_Verificar";
            cmd.Parameters.AddWithValue("@lote", objMovimientoPaciente.anno);
            cmd.Parameters.AddWithValue("@correlativo", objMovimientoPaciente.correlativo);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        //VERIFICAR NUMERO DUPLICADO DE FUA PARA ACTUALIZAR
        public DataTable MovimientoPaciente_Verificar2(MovimientoPaciente objMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_VerificarV2";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoPaciente.Fua);
            cmd.Parameters.AddWithValue("@lote", objMovimientoPaciente.anno);
            cmd.Parameters.AddWithValue("@correlativo", objMovimientoPaciente.correlativo);
            return Datos.ObtenerDatosProcedure(cmd);
        }
        
        //GENERAR NUEVO NUMERO DE FUA
        public DataTable MovimientoPaciente_Nuevo()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_Nuevo";            
            return Datos.ObtenerDatosProcedure(cmd);

        }

        //INSERTAR MOVIMIENTO PACIENTE
        public int MovimientoPaciente_Insertar(MovimientoPaciente ObjMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoPaciente_Insert";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPaciente.Fua);
            cmd.Parameters.AddWithValue("@Anno", ObjMovimientoPaciente.anno);
            cmd.Parameters.AddWithValue("@correlativo", ObjMovimientoPaciente.correlativo);
            cmd.Parameters.AddWithValue("@EstablecimientoId", ObjMovimientoPaciente.EstablecimientoId);
            cmd.Parameters.AddWithValue("@TipoIngresoId", ObjMovimientoPaciente.TipoIngresoId);
            cmd.Parameters.AddWithValue("@FechaAtencion", ObjMovimientoPaciente.FechaAtencion);
            cmd.Parameters.AddWithValue("@LugarAtencionId", ObjMovimientoPaciente.LugarAtencionId);
            cmd.Parameters.AddWithValue("@NumeroHistoria", ObjMovimientoPaciente.NumeroHistoria);
            cmd.Parameters.AddWithValue("@TipoPrestacionId", ObjMovimientoPaciente.TipoPrestacionId);
            cmd.Parameters.AddWithValue("@PersonalAtiendeId", ObjMovimientoPaciente.PersonalAtiendeId);
            cmd.Parameters.AddWithValue("@NumeroHojaRefiere", ObjMovimientoPaciente.NumeroHojaRefiere);
            cmd.Parameters.AddWithValue("@EstablecimientoRefiereId", ObjMovimientoPaciente.EstablecimientoRefiereId);

            if (ObjMovimientoPaciente.DestinoAseguradoId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@DestinoAseguradoId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@DestinoAseguradoId", ObjMovimientoPaciente.DestinoAseguradoId);
            }
            
            cmd.Parameters.AddWithValue("@EstablecimientoContraRefiereId", ObjMovimientoPaciente.EstablecimientoContraRefiereId);
            cmd.Parameters.AddWithValue("@NumeroHojaContraRefiere", ObjMovimientoPaciente.NumeroHojaContraRefiere);

            if (ObjMovimientoPaciente.FechaIngreso.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@FechaIngreso", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@FechaIngreso", ObjMovimientoPaciente.FechaIngreso);
            }

            if (ObjMovimientoPaciente.FechaAlta.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@FechaAlta", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@FechaAlta", ObjMovimientoPaciente.FechaAlta);
            }            

            cmd.Parameters.AddWithValue("@DNIResponsable", ObjMovimientoPaciente.DNIResponsable);
            cmd.Parameters.AddWithValue("@Colegiatura", ObjMovimientoPaciente.Colegiatura);
            cmd.Parameters.AddWithValue("@NombresResponsable", ObjMovimientoPaciente.NombresResponsable);
            cmd.Parameters.AddWithValue("@Especialidad", ObjMovimientoPaciente.Especialidad);

            if (ObjMovimientoPaciente.InstitucionId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@InstitucionId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@InstitucionId", ObjMovimientoPaciente.InstitucionId);
            }

            cmd.Parameters.AddWithValue("@NumeroSeguro", ObjMovimientoPaciente.NumeroSeguro);
            cmd.Parameters.AddWithValue("@ResponsableAtencionId", ObjMovimientoPaciente.ResponsableAtencionId);            
            cmd.Parameters.AddWithValue("@PacienteId", ObjMovimientoPaciente.PacienteId);
            cmd.Parameters.AddWithValue("@login", ObjMovimientoPaciente.login);

            if (ObjMovimientoPaciente.TipoRegimenId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@TipoRegimenId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@TipoRegimenId", ObjMovimientoPaciente.TipoRegimenId);
            }

            cmd.Parameters.AddWithValue("@Afiliacion", ObjMovimientoPaciente.Afiliacion);

            //if (ObjMovimientoPaciente.TipoDocumentoId.ToString() == String.Empty)
            //{
            //    cmd.Parameters.AddWithValue("@TipoDocumentoId", DBNull.Value);
            //}
            //else
            //{
            //    cmd.Parameters.AddWithValue("@TipoDocumentoId", ObjMovimientoPaciente.TipoDocumentoId);
            //}
            
            return Datos.Mantenimiento(cmd);
        }

        //OBTIENE VISTA MOVIMIENTO PACIENTE FULL POR FUA
        public vw2_MovimientoPaciente_Listar GetVwMovimientoPacienteFullPorFua(Int64 fua)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                vw2_MovimientoPaciente_Listar objMovimientoPaciente = null;
                cmd.CommandText = "sp2_GetVwMovimientoPacienteFullPorFua";
                cmd.Parameters.AddWithValue("@Fua", fua);
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        objMovimientoPaciente = new vw2_MovimientoPaciente_Listar();
                        objMovimientoPaciente.Fua = Convert.ToInt64(dr["Fua"]);
                        objMovimientoPaciente.anno = dr["anno"].ToString();
                        objMovimientoPaciente.correlativo = dr["correlativo"].ToString();
                        objMovimientoPaciente.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
                        objMovimientoPaciente.Descripcion = dr["Descripcion"].ToString();
                        //objMovimientoPaciente.TipoIngresoId = Convert.ToByte(dr["TipoIngresoId"].ToString());
                        objMovimientoPaciente.TipoIngresoDescripcion = dr["TipoIngresoDescripcion"].ToString();
                        if (dr["FechaAtencion"] != DBNull.Value)
                            objMovimientoPaciente.FechaAtencion = Convert.ToDateTime(dr["FechaAtencion"]);
                        //objMovimientoPaciente.LugarAtencionId = Convert.ToByte(dr["LugarAtencionId"].ToString());
                        objMovimientoPaciente.LugarAtencionDescripcion = dr["LugarAtencionDescripcion"].ToString();
                        objMovimientoPaciente.NumeroHistoria = dr["NumeroHistoria"].ToString();
                        //objMovimientoPaciente.TipoPrestacionId = Convert.ToInt32(dr["TipoPrestacionId"].ToString());
                        objMovimientoPaciente.TipoPrestacionDescripcion = dr["TipoPrestacionDescripcion"].ToString();
                        //objMovimientoPaciente.PersonalAtiendeId = Convert.ToByte(dr["PersonalAtiendeId"].ToString());
                        objMovimientoPaciente.PersonalAtiendeDescripcion = dr["PersonalAtiendeDescripcion"].ToString();
                        objMovimientoPaciente.NumeroHojaRefiere = dr["NumeroHojaRefiere"].ToString();
                        //objMovimientoPaciente.EstablecimientoRefiereId = Convert.ToString(dr["EstablecimientoRefiereId"]);
                        objMovimientoPaciente.DescEstabRefiere = dr["DescEstabRefiere"].ToString();
                        //objMovimientoPaciente.DestinoAseguradoId = Convert.ToByte(dr["DestinoAseguradoId"].ToString());
                        objMovimientoPaciente.DestinoAseguradoDescripcion = dr["DestinoAseguradoDescripcion"].ToString();
                        //objMovimientoPaciente.EstablecimientoContraRefiereId = Convert.ToString(dr["EstablecimientoContraRefiereId"]);
                        objMovimientoPaciente.DescEstabContRefiere = dr["DescEstabContRefiere"].ToString();
                        objMovimientoPaciente.NumeroHojaContraRefiere = dr["NumeroHojaContraRefiere"].ToString();
                        if (dr["FechaIngreso"] != DBNull.Value)
                            objMovimientoPaciente.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                        if (dr["FechaAlta"] != DBNull.Value)
                            objMovimientoPaciente.FechaAlta = Convert.ToDateTime(dr["FechaAlta"]);
                        //objMovimientoPaciente.ResponsableAtencionId = Convert.ToByte(dr["ResponsableAtencionId"].ToString());
                        objMovimientoPaciente.DNIResponsable = dr["DNIResponsable"].ToString();
                        objMovimientoPaciente.DescResponsableAtencion = dr["DescResponsableAtencion"].ToString();
                        objMovimientoPaciente.Cmp = dr["Cmp"].ToString();
                        objMovimientoPaciente.NombreDoctor = dr["NombreDoctor"].ToString();
                        objMovimientoPaciente.Especialidad = dr["Especialidad"].ToString();
                        //objMovimientoPaciente.InstitucionId = Convert.ToByte(dr["InstitucionId"].ToString());
                        objMovimientoPaciente.InstitucionDescripcion = dr["InstitucionDescripcion"].ToString();
                        objMovimientoPaciente.NumeroSeguro = dr["NumeroSeguro"].ToString();
                        if (dr["FechaRegistro"] != DBNull.Value)
                            objMovimientoPaciente.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                        objMovimientoPaciente.DescripcionPaciente = dr["DescripcionPaciente"].ToString();
                        //objMovimientoPaciente.TipoDocumentoId = Convert.ToByte(dr["TipoDocumentoId"].ToString());
                        objMovimientoPaciente.DescripcionTipoDocumento = dr["DescripcionTipoDocumento"].ToString();
                        objMovimientoPaciente.PacienteId = dr["PacienteId"].ToString();
                        if (dr["Nacimiento"] != DBNull.Value)
                            objMovimientoPaciente.Nacimiento = Convert.ToDateTime(dr["Nacimiento"]);
                        //objMovimientoPaciente.SexoId = Convert.ToByte(dr["SexoId"].ToString());
                        objMovimientoPaciente.DescSexo = dr["DescSexo"].ToString();
                        objMovimientoPaciente.Historia = dr["Historia"].ToString();
                        objMovimientoPaciente.Estado = Convert.ToBoolean(dr["Estado"]);
                        if (dr["fecha_defuncion"] != DBNull.Value)
                            objMovimientoPaciente.fecha_defuncion = Convert.ToDateTime(dr["fecha_defuncion"]);
                        objMovimientoPaciente.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                        objMovimientoPaciente.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                        objMovimientoPaciente.Nombres = dr["Nombres"].ToString();
                        objMovimientoPaciente.OtrosNombres = dr["OtrosNombres"].ToString();
                        objMovimientoPaciente.TipoRegimenDesc = dr["TipoRegimenDesc"].ToString();
                        if (dr["CM"] != DBNull.Value)
                            objMovimientoPaciente.CM = Convert.ToBoolean(dr["CM"]);
                        if (dr["CMObs"] != DBNull.Value)
                            objMovimientoPaciente.CMObs = Convert.ToBoolean(dr["CMObs"]);
                        if (dr["CMPcpp"] != DBNull.Value)
                            objMovimientoPaciente.CMPcpp = Convert.ToBoolean(dr["CMPcpp"]);
                        if (dr["CMReconsiderado"] != DBNull.Value)
                            objMovimientoPaciente.CMReconsiderado = Convert.ToBoolean(dr["CMReconsiderado"]);
                        if (dr["CMFuaReferencia"] != DBNull.Value)
                            objMovimientoPaciente.CMFuaReferencia = Convert.ToInt64(dr["CMFuaReferencia"]);
                        if (dr["CMErrorFechaAtencion"] != DBNull.Value)
                            objMovimientoPaciente.CMErrorFechaAtencion = Convert.ToBoolean(dr["CMErrorFechaAtencion"]);
                        if (dr["CMErrorResponsableAtencion"] != DBNull.Value)
                            objMovimientoPaciente.CMErrorResponsableAtencion = Convert.ToBoolean(dr["CMErrorResponsableAtencion"]);
                        objMovimientoPaciente.CMObsDesc = dr["CMObsDesc"].ToString();
                        if (dr["MontoProcedimiento"] != DBNull.Value)
                            objMovimientoPaciente.MontoProcedimiento = Convert.ToDecimal(dr["MontoProcedimiento"]);
                        if (dr["MontoMedicamento"] != DBNull.Value)
                            objMovimientoPaciente.MontoMedicamento = Convert.ToDecimal(dr["MontoMedicamento"]);
                        if (dr["MontoFua"] != DBNull.Value)
                            objMovimientoPaciente.MontoFua = Convert.ToDecimal(dr["MontoFua"]);
                        //objMovimientoPaciente.login = Convert.ToString(dr["login"]);
                    }
                }
                return objMovimientoPaciente;
            }
        }
        
        //ACTUALIZAR MOVIMIENTO PACIENTE
        public int MovimientoPaciente_Actualizar(MovimientoPaciente ObjMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoPaciente_Update";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPaciente.Fua);
            cmd.Parameters.AddWithValue("@Anno", ObjMovimientoPaciente.anno);
            cmd.Parameters.AddWithValue("@correlativo", ObjMovimientoPaciente.correlativo);
            cmd.Parameters.AddWithValue("@EstablecimientoId", ObjMovimientoPaciente.EstablecimientoId);
            cmd.Parameters.AddWithValue("@TipoIngresoId", ObjMovimientoPaciente.TipoIngresoId);
            cmd.Parameters.AddWithValue("@FechaAtencion", ObjMovimientoPaciente.FechaAtencion);
            cmd.Parameters.AddWithValue("@LugarAtencionId", ObjMovimientoPaciente.LugarAtencionId);
            cmd.Parameters.AddWithValue("@NumeroHistoria", ObjMovimientoPaciente.NumeroHistoria);
            cmd.Parameters.AddWithValue("@TipoPrestacionId", ObjMovimientoPaciente.TipoPrestacionId);
            cmd.Parameters.AddWithValue("@PersonalAtiendeId", ObjMovimientoPaciente.PersonalAtiendeId);
            cmd.Parameters.AddWithValue("@NumeroHojaRefiere", ObjMovimientoPaciente.NumeroHojaRefiere);
            cmd.Parameters.AddWithValue("@EstablecimientoRefiereId", ObjMovimientoPaciente.EstablecimientoRefiereId);

            if (ObjMovimientoPaciente.DestinoAseguradoId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@DestinoAseguradoId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@DestinoAseguradoId", ObjMovimientoPaciente.DestinoAseguradoId);
            }

            cmd.Parameters.AddWithValue("@EstablecimientoContraRefiereId", ObjMovimientoPaciente.EstablecimientoContraRefiereId);
            cmd.Parameters.AddWithValue("@NumeroHojaContraRefiere", ObjMovimientoPaciente.NumeroHojaContraRefiere);

            if (ObjMovimientoPaciente.FechaIngreso.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@FechaIngreso", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@FechaIngreso", ObjMovimientoPaciente.FechaIngreso);
            }

            if (ObjMovimientoPaciente.FechaAlta.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@FechaAlta", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@FechaAlta", ObjMovimientoPaciente.FechaAlta);
            }

            cmd.Parameters.AddWithValue("@DNIResponsable", ObjMovimientoPaciente.DNIResponsable);
            cmd.Parameters.AddWithValue("@Colegiatura", ObjMovimientoPaciente.Colegiatura);
            cmd.Parameters.AddWithValue("@NombresResponsable", ObjMovimientoPaciente.NombresResponsable);
            cmd.Parameters.AddWithValue("@Especialidad", ObjMovimientoPaciente.Especialidad);

            if (ObjMovimientoPaciente.InstitucionId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@InstitucionId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@InstitucionId", ObjMovimientoPaciente.InstitucionId);
            }
            
            cmd.Parameters.AddWithValue("@NumeroSeguro", ObjMovimientoPaciente.NumeroSeguro);
            cmd.Parameters.AddWithValue("@ResponsableAtencionId", ObjMovimientoPaciente.ResponsableAtencionId);                        
            cmd.Parameters.AddWithValue("@PacienteId", ObjMovimientoPaciente.PacienteId);

            if (ObjMovimientoPaciente.TipoRegimenId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@TipoRegimenId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@TipoRegimenId", ObjMovimientoPaciente.TipoRegimenId);
            }

            cmd.Parameters.AddWithValue("@Afiliacion", ObjMovimientoPaciente.Afiliacion);

            //if (ObjMovimientoPaciente.TipoDocumentoId.ToString() == String.Empty)
            //{
            //    cmd.Parameters.AddWithValue("@TipoDocumentoId", DBNull.Value);
            //}
            //else
            //{
            //    cmd.Parameters.AddWithValue("@TipoDocumentoId", ObjMovimientoPaciente.TipoDocumentoId);
            //}

            return Datos.Mantenimiento(cmd);
        }

        //HABILITAR EDICION FUA
        public DataTable HabilitarEdicionFua()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_HabilitarEdicionFua";
            return Datos.ObtenerDatosProcedure(cmd);
        }
        
        //ACTUALIZAR MOVIMIENTO PACIENTE - CM
        public int GuardarControlMedicoAtencion(MovimientoPaciente ObjMovimientoPaciente)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GuardarControlMedicoAtencion";
                cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPaciente.Fua);
                cmd.Parameters.AddWithValue("@CM", ObjMovimientoPaciente.CM);
                if (ObjMovimientoPaciente.CMObs != null)
                    cmd.Parameters.AddWithValue("@CMObs", ObjMovimientoPaciente.CMObs);
                else
                    cmd.Parameters.AddWithValue("@CMObs", false);
                if (ObjMovimientoPaciente.CMErrorFechaAtencion != null)
                    cmd.Parameters.AddWithValue("@CMErrorFechaAtencion", ObjMovimientoPaciente.CMErrorFechaAtencion);
                else
                    cmd.Parameters.AddWithValue("@CMErrorFechaAtencion", false);
                if (ObjMovimientoPaciente.CMErrorResponsableAtencion != null)
                    cmd.Parameters.AddWithValue("@CMErrorResponsableAtencion", ObjMovimientoPaciente.CMErrorResponsableAtencion);
                else
                    cmd.Parameters.AddWithValue("@CMErrorResponsableAtencion", false);
                return Datos.Mantenimiento(cmd);
            }
        }

        //ACTUALIZAR MOVIMIENTO PACIENTE - CMPcpp
        public int SeleccionarAtencionParaPcpp(MovimientoPaciente ObjMovimientoPaciente)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_SeleccionarAtencionParaPcpp";
                cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPaciente.Fua);
                cmd.Parameters.AddWithValue("@CMPcpp", ObjMovimientoPaciente.CMPcpp);
                return Datos.Mantenimiento(cmd);
            }
        }
        
        //ELIMINAR MOVIMIENTO PACIENTE
        public int MovimientoPaciente_Eliminar(MovimientoPaciente ObjMovimientoPaciente)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoPaciente_Delete";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPaciente.Fua);
            return Datos.Mantenimiento(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN DIAGNOSTICO
        public DataTable MovimientoPaciente_SinDiagnostico(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_SinDiagnostico";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN CONSUMO
        public DataTable MovimientoPaciente_SinConsumo(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_SinConsumo";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS DUPLICADOS
        public DataTable MovimientoPaciente_Duplicado(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_Duplicado";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS CON FECHA DE ATENCION ERRONEA
        public DataTable MovimientoPaciente_FechaAtencionErronea(string EstablecimientoId, DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_FechaAtencionErronea";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN DIAGNOSTICO
        public DataTable MovimientoPaciente_SinDiagnosticoxAdm(DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_SinDiagnosticoxAdm";            
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS SIN CONSUMO
        public DataTable MovimientoPaciente_SinConsumoxAdm(DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_SinConsumoxAdm";            
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS DUPLICADOS
        public DataTable MovimientoPaciente_DuplicadoxAdm(DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_DuplicadoxAdm";            
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CONTROL DE CALIDAD
        //OBTIENE LISTA DE FUAS CON FECHA DE ATENCION ERRONEA
        public DataTable MovimientoPaciente_FechaAtencionErroneaxAdm(DateTime FecIni, DateTime FecFin)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_FechaAtencionErroneaxAdm";            
            cmd.Parameters.AddWithValue("@FecIni", FecIni);
            cmd.Parameters.AddWithValue("@FecFin", FecFin);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DateTime GetFechaMaximaValorizacion()
        {
            DateTime fechaMaximaValorizacion;
            using (SqlConnection conn = AccesoBD.getConnnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp2_GetFechaMaximaValorizacion";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    fechaMaximaValorizacion = Convert.ToDateTime(cmd.ExecuteScalar());
                }
            }
            return fechaMaximaValorizacion;
        }

        //CIERRE DE DIGITACION
        //LISTAR IPRESS PARA REGISTRAR FECHAS CIERRE 
        public DataTable MovimientoPaciente_IpressParaCierreId()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_IpressParaCierreId";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CIERRE DE DIGITACION
        //ACTUALIZAR FECHA REGISTRO CON FECHA ATENCION EN FUAS SIN FECHA REGISTRO
        public int MovimientoPaciente_UpdateFechaRegistro()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_UpdateFechaRegistro";            
            return Datos.Mantenimiento(cmd);
        }

        //CIERRE DE DIGITACION
        //LISTAR FECHAS CIERRE POR IPRESS
        public DataTable ProduccionCierreDigitacion_FechasCierre(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_ProduccionCierreDigitacion_FechasCierre";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionCierreDigitacion.EstablecimientoId);     
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CIERRE DE DIGITACION
        //LISTAR FECHAS CIERRE POR IPRESS V2
        public DataTable ProduccionCierreDigitacion_FechasCierreV2(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_ProduccionCierreDigitacion_FechasCierreV2";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionCierreDigitacion.EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CIERRE DE DIGITACION
        //GENERAR NUEVO NUMERO DE CIERRE DIGITACION POR IPRESS
        public DataTable ProduccionCierreDigitacion_Nuevo(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_ProduccionCierreDigitacion_Nuevo";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionCierreDigitacion.EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
            
        }

        //CIERRE DE DIGITACION
        //INSERTAR CIERRE DIGITACION POR IPRESS
        public int ProduccionCierreDigitacion_Insert(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_ProduccionCierreDigitacion_Insert";
            cmd.Parameters.AddWithValue("@CierreId", objProduccionCierreDigitacion.CierreId);
            cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionCierreDigitacion.EstablecimientoId);
            cmd.Parameters.AddWithValue("@FechaCierre", objProduccionCierreDigitacion.FechaCierre);
            cmd.Parameters.AddWithValue("@UsuarioCierre", objProduccionCierreDigitacion.UsuarioCierre);
            return Datos.Mantenimiento(cmd);
        }

        //CIERRE DE DIGITACION
        //ETIQUETAR FUAS DESPUES DEL CIERRE DIGITACION POR IPRESS
        public int MovimientoPaciente_RegistrarCierreId(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_RegistrarCierreId";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionCierreDigitacion.EstablecimientoId);
            cmd.Parameters.AddWithValue("@FechaCierre", objProduccionCierreDigitacion.FechaCierre);
            return Datos.Mantenimiento(cmd);
        }

        //CIERRE DE DIGITACION
        //VERIFICAR FUA CERRADA
        public DataTable MovimientoPaciente_VerificarCierreId(int Fua)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_VerificarCierreId";
            cmd.Parameters.AddWithValue("@Fua", Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CIERRE DE DIGITACION
        //REPORTE FUAS CERRADOS
        public DataTable MovimientoPacienteCerrados_Listar(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPacienteCerrados_Listar";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //CIERRE DE DIGITACION
        //VERIFICAR CIERRE DE DIGITACION
        public DataTable ProduccionCierreDigitacion_VerificarCierre(ProduccionCierreDigitacion objProduccionCierreDigitacion)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_ProduccionCierreDigitacion_VerificarCierre";
            cmd.Parameters.AddWithValue("@EstablecimientoId", objProduccionCierreDigitacion.EstablecimientoId);
            cmd.Parameters.AddWithValue("@FechaCierre", objProduccionCierreDigitacion.FechaCierre);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //POSTCONSISTENCIA
        //OBTENER IPRESS PARA POSTCONSISTENCIA
        public DataTable MovimientoPaciente_IpressPostConsistencia()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_IpressPostConsistencia";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //POSTCONSISTENCIA
        //REESTABLECER FUAS OBSERVADAS
        public int AtencionesObservadas_Reestablecer(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_AtencionesObservadas_Reestablecer";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.Mantenimiento(cmd);
        }

        //POSTCONSISTENCIA
        //LISTAR FUAS OBSERVADAS
        public DataTable AtencionesObservadas_Listar(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_AtencionesObservadas_Listar";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //POSTCONSISTENCIA
        //ETIQUETAR FUAS OBSERVADAS
        public int MovimientoPaciente_UpdateObservado(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_UpdateObservado";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.Mantenimiento(cmd);
        }

        //POSTCONSISTENCIA
        //INSERTAR FUAS OBSERVADAS A TABLA AtencionObsConsistencia
        public int AtencionObsConsistencia_Insert(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_AtencionObsConsistencia_Insert";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.Mantenimiento(cmd);
        }

        //POSTCONSISTENCIA
        //LISTAR DETALLE FUAS OBSERVADAS
        public DataTable AtencionesObservadas_Detalle()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_AtencionesObservadas_Detalle";            
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //POSTCONSISTENCIA
        //REPORTE FUAS OBSERVADOS
        public DataTable MovimientoPacienteObservados_Listar(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPacienteObservados_Listar";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        //VALIDAR ENFERMEDAD PRINCIPAL
        public DataTable MovimientoPaciente_ValidarEnfermedadPrincipal(int Fua)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_ValidarEnfermnedadPrincipal";
            cmd.Parameters.AddWithValue("@Fua", Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }



        //OBTENER FECHA CONVENIO
        public DataTable MovimientoPaciente_FechaConvenio(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_FechaConvenio";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable MovimientoPaciente_PacienteWS(DataTable dt)
        {
             SqlConnection cn = AccesoBD.getConnnection();
             cn.Open();
            using (var cmdws = new SqlCommand("CREATE TABLE TEMPPACIENTE " +
                                            "(" +
                                            "ApellidoMaterno	varchar(30)," +
                                            "ApellidoPaterno	varchar(30)," +
                                            "Estado	bit," +
                                            "Historia	varchar	(50)," +
                                            "Nacimiento	smalldatetime," +
                                            "Nombres	varchar(50)," +
                                            "NumeroDocumento	char(8)," +
                                            "OtrosNombres	varchar(50)," +
                                            "PacienteId	char(8)," +
                                            "SexoId	tinyint," +
                                            "TipoDocumentoId	tinyint," +
                                            "TipoRegimenId	tinyint" +
                                            ")",cn))
            {
                cmdws.ExecuteNonQuery();
            }


            using (var bcp = new SqlBulkCopy(cn, SqlBulkCopyOptions.TableLock, null))
            {
                bcp.DestinationTableName = "TEMPPACIENTE";
                bcp.WriteToServer(dt);

            }
            //cmd = new SqlCommand();
            //cmd.CommandText = "sp2_ate_MovimientoPaciente_ListarxFua";
            //cmd.Parameters.AddWithValue("@Fua", objMovimientoPaciente.Fua);
            //return Datos.ObtenerDatosProcedure(cmd);

            cmd = new SqlCommand();
            cmd.CommandText = "UspWSInsertarPacientes";
            //cmd.Parameters.AddWithValue("@Fua", Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }


        //OBTENER LISTADO CIERRE DIGITACION
        public DataTable MovimientoPaciente_ListarCierresDig(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPaciente_ListarCierresDig";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }


    }
}