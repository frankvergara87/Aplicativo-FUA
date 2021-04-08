using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class MovimientoPacienteDetalleDA
    {
        static SqlCommand cmd;

        public MovimientoPacienteDetalleDA()
        {
            cmd = new SqlCommand();
        }

        //OBTIENE LISTA MOVIMIENTOPACIENTEDETALLE POR FUA
        public List<vw_MovimientoPacienteDetalle> GetVwMovimientoPacienteDetallePorFua(Int64 fua)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetVwMovimientoPacienteDetallePorFua";
                cmd.Parameters.AddWithValue("@Fua", fua);
                List<vw_MovimientoPacienteDetalle> listaDiagnosticos = new List<vw_MovimientoPacienteDetalle>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaDiagnosticos.Add(CargarDetalleAtencion(dr));
                    }
                }
                return listaDiagnosticos;
            }
        }
        
        public vw_MovimientoPacienteDetalle CargarDetalleAtencion(IDataReader dr)
        {
            vw_MovimientoPacienteDetalle objDetalleAtencion = new vw_MovimientoPacienteDetalle();
            if (dr["AutorizacionId"] != DBNull.Value)
                objDetalleAtencion.AutorizacionId = Convert.ToInt32(dr["AutorizacionId"]);
            objDetalleAtencion.CategoriaId = dr["CategoriaId"].ToString();
            if (dr["CMObs"] != DBNull.Value)
                objDetalleAtencion.CMObs = Convert.ToBoolean(dr["CMObs"]);
            objDetalleAtencion.CMObsDesc = dr["CMObsDesc"].ToString();
            if (dr["CMTipoObservacionId"] != DBNull.Value)
                objDetalleAtencion.CMTipoObservacionId = Convert.ToInt32(dr["CMTipoObservacionId"]);
            objDetalleAtencion.CodigoAutorizacion = dr["CodigoAutorizacion"].ToString();
            objDetalleAtencion.descripcionautorizacion = dr["descripcionautorizacion"].ToString();
            objDetalleAtencion.descripciondiagnostico = dr["descripciondiagnostico"].ToString();
            objDetalleAtencion.descripcionlarga = dr["descripcionlarga"].ToString();
            objDetalleAtencion.DetalleId = Convert.ToInt32(dr["DetalleId"]);
            objDetalleAtencion.DiagnosticoAsociado = Convert.ToBoolean(dr["DiagnosticoAsociado"]);
            objDetalleAtencion.EnfermedadEgresoId = dr["EnfermedadEgresoId"].ToString();
            objDetalleAtencion.EnfermedadIngresoId = dr["EnfermedadIngresoId"].ToString();
            objDetalleAtencion.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
            if (dr["EstadioId"] != DBNull.Value)
                objDetalleAtencion.EstadioId = Convert.ToInt16(dr["EstadioId"]);
            if (dr["FaseId"] != DBNull.Value)
                objDetalleAtencion.FaseId = Convert.ToInt32(dr["FaseId"]);
            objDetalleAtencion.Fua = Convert.ToInt64(dr["Fua"]);
            objDetalleAtencion.Lote = dr["Lote"].ToString();
            objDetalleAtencion.TipoDiagnosticoEgresoId = dr["TipoDiagnosticoEgresoId"].ToString();
            objDetalleAtencion.TipoDiagnosticoIngresoId = dr["TipoDiagnosticoIngresoId"].ToString();
            objDetalleAtencion.TratamiendoId = Convert.ToInt32(dr["TratamiendoId"]);
            objDetalleAtencion.Version = Convert.ToInt32(dr["Version"]);
            return objDetalleAtencion;
        }

        //OBTIENE LISTA MOVIMIENTOPACIENTEDETALLE POR FUA
        public DataTable MovimientoPacienteDetalle_ListarxFua(MovimientoPacienteDetalle objMovimientoPacienteDetalle)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPacienteDetalle_ListarxFua";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoPacienteDetalle.Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //GENERAR NUEVO NUMERO DE DETALLEID
        public DataTable MovimientoPacienteDetalle_NuevoDetalleId(MovimientoPacienteDetalle objMovimientoPacienteDetalle)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoPacienteDetalle_NuevoDetalleId";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoPacienteDetalle.Fua);
            return Datos.ObtenerDatosProcedure(cmd);

        }

        //INSERTAR MOVIMIENTO PACIENTE DETALLE
        public int MovimientoPacienteDetalle_Insertar(MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoPacienteDetalle_Insert";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPacienteDetalle.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoPacienteDetalle.DetalleId);
            cmd.Parameters.AddWithValue("@AutorizacionId", ObjMovimientoPacienteDetalle.AutorizacionId);
            cmd.Parameters.AddWithValue("@EnfermedadIngresoId", ObjMovimientoPacienteDetalle.EnfermedadIngresoId);
            cmd.Parameters.AddWithValue("@TipoDiagnosticoIngresoId", ObjMovimientoPacienteDetalle.TipoDiagnosticoIngresoId);
            cmd.Parameters.AddWithValue("@EstadioId", ObjMovimientoPacienteDetalle.EstadioId);
            cmd.Parameters.AddWithValue("@FaseId", ObjMovimientoPacienteDetalle.FaseId);

            if (ObjMovimientoPacienteDetalle.EnfermedadEgresoId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@EnfermedadEgresoId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@EnfermedadEgresoId", ObjMovimientoPacienteDetalle.EnfermedadEgresoId);
            }
            
            cmd.Parameters.AddWithValue("@TipoDiagnosticoEgresoId", ObjMovimientoPacienteDetalle.TipoDiagnosticoEgresoId);
            return Datos.Mantenimiento(cmd);
        }

        //ACTUALIZAR MOVIMIENTO PACIENTE DETALLE
        public int MovimientoPacienteDetalle_Actualizar(MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoPacienteDetalle_Update";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPacienteDetalle.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoPacienteDetalle.DetalleId);
            cmd.Parameters.AddWithValue("@AutorizacionId", ObjMovimientoPacienteDetalle.AutorizacionId);
            cmd.Parameters.AddWithValue("@EnfermedadIngresoId", ObjMovimientoPacienteDetalle.EnfermedadIngresoId);
            cmd.Parameters.AddWithValue("@TipoDiagnosticoIngresoId", ObjMovimientoPacienteDetalle.TipoDiagnosticoIngresoId);
            cmd.Parameters.AddWithValue("@EstadioId", ObjMovimientoPacienteDetalle.EstadioId);
            cmd.Parameters.AddWithValue("@FaseId", ObjMovimientoPacienteDetalle.FaseId);
            
            if (ObjMovimientoPacienteDetalle.EnfermedadEgresoId.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@EnfermedadEgresoId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@EnfermedadEgresoId", ObjMovimientoPacienteDetalle.EnfermedadEgresoId);
            }
            
            cmd.Parameters.AddWithValue("@TipoDiagnosticoEgresoId", ObjMovimientoPacienteDetalle.TipoDiagnosticoEgresoId);
            return Datos.Mantenimiento(cmd);
        }

        //ACTUALIZAR MOVIMIENTO PACIENTE DETALLE - CM
        public int GuardarControlMedicoDetalleAtencion(vw_MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GuardarControlMedicoDetalleAtencion";
                cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPacienteDetalle.Fua);
                cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoPacienteDetalle.DetalleId);
                if (ObjMovimientoPacienteDetalle.CMObs != null)
                    cmd.Parameters.AddWithValue("@CMObs", ObjMovimientoPacienteDetalle.CMObs);
                else
                    cmd.Parameters.AddWithValue("@CMObs", false);
                cmd.Parameters.AddWithValue("@CMTipoObservacionId", ObjMovimientoPacienteDetalle.CMTipoObservacionId);
                cmd.Parameters.AddWithValue("@CMObsDesc", ObjMovimientoPacienteDetalle.CMObsDesc);
                return Datos.Mantenimiento(cmd);
            }
        }
        
        //ELIMINAR MOVIMIENTO PACIENTE DETALLE
        public int MovimientoPacienteDetalle_Eliminar(MovimientoPacienteDetalle ObjMovimientoPacienteDetalle)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoPacienteDetalle_Delete";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoPacienteDetalle.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoPacienteDetalle.DetalleId);
            cmd.Parameters.AddWithValue("@AutorizacionId", ObjMovimientoPacienteDetalle.AutorizacionId);
            return Datos.Mantenimiento(cmd);
        } 


    }
}
