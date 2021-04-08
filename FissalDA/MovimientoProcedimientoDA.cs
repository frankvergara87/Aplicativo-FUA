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
    public class MovimientoProcedimientoDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA VW MOVIMIENTO PROCEDIMIENTO POR FUA
        public List<vw_MovimientoPacienteProcedimiento> GetVwMovimientoPacienteProcedimientoPorFua(Int64 fua)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetVwMovimientoPacienteProcedimientoPorFua";
                cmd.Parameters.AddWithValue("@Fua", fua);
                List<vw_MovimientoPacienteProcedimiento> listaProcedimientos = new List<vw_MovimientoPacienteProcedimiento>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaProcedimientos.Add(CargarProcedimiento(dr));
                    }
                }
                return listaProcedimientos;
            }
        }

        public vw_MovimientoPacienteProcedimiento CargarProcedimiento(IDataReader dr)
        {
            vw_MovimientoPacienteProcedimiento objProcedimiento = new vw_MovimientoPacienteProcedimiento();
            objProcedimiento.Cantidad = Convert.ToInt32(dr["Cantidad"]);
            if (dr["CantidadPagadaSIS"] != DBNull.Value)
                objProcedimiento.CantidadPagadaSIS = Convert.ToInt32(dr["CantidadPagadaSIS"]);
            if (dr["CMCantidadObservada"] != DBNull.Value)
                objProcedimiento.CMCantidadObservada = Convert.ToInt32(dr["CMCantidadObservada"]);
            if (dr["CMObs"] != DBNull.Value)
                objProcedimiento.CMObs = Convert.ToBoolean(dr["CMObs"]);
            objProcedimiento.CMObsDesc = dr["CMObsDesc"].ToString();
            if (dr["CMTipoObservacionId"] != DBNull.Value)
                objProcedimiento.CMTipoObservacionId = Convert.ToInt32(dr["CMTipoObservacionId"]);
            objProcedimiento.Consumo = Convert.ToInt32(dr["Consumo"]);
            objProcedimiento.Convenio = Convert.ToInt32(dr["Convenio"]);
            objProcedimiento.Descripcion = dr["Descripcion"].ToString();
            objProcedimiento.DetalleId = Convert.ToInt32(dr["DetalleId"]);
            objProcedimiento.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
            objProcedimiento.Fua = Convert.ToInt64(dr["Fua"]);
            objProcedimiento.Lote = dr["Lote"].ToString();
            objProcedimiento.Monto = Convert.ToDecimal(dr["Monto"]);
            objProcedimiento.obs = dr["obs"].ToString();
            objProcedimiento.paquete = Convert.ToBoolean(dr["paquete"]);
            objProcedimiento.Prescrito = Convert.ToInt32(dr["Prescrito"]);
            objProcedimiento.ProcedimientoId = Convert.ToInt32(dr["ProcedimientoId"]);
            objProcedimiento.SisId = dr["SisId"].ToString();
            return objProcedimiento;
        }

        //OBTIENE LISTA MOVIMIENTO PROCEDIMIENTO POR FUA
        public DataTable MovimientoProcedimiento_ListarxFua(MovimientoProcedimiento objMovimientoProcedimiento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoProcedimiento_ListarxFua";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoProcedimiento.Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //INSERTAR MOVIMIENTO PROCEDIMIENTO
        public int MovimientoProcedimiento_Insertar(MovimientoProcedimiento ObjMovimientoProcedimiento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoProcedimiento_Insert";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoProcedimiento.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoProcedimiento.DetalleId);
            cmd.Parameters.AddWithValue("@ProcedimientoId", ObjMovimientoProcedimiento.ProcedimientoId);
            cmd.Parameters.AddWithValue("@Cantidad", ObjMovimientoProcedimiento.Cantidad);
            cmd.Parameters.AddWithValue("@Monto", ObjMovimientoProcedimiento.Monto);
            cmd.Parameters.AddWithValue("@Prescrito", ObjMovimientoProcedimiento.Prescrito);
            cmd.Parameters.AddWithValue("@Consumo", ObjMovimientoProcedimiento.Consumo);
            cmd.Parameters.AddWithValue("@Convenio", ObjMovimientoProcedimiento.Convenio);
            cmd.Parameters.AddWithValue("@obs", ObjMovimientoProcedimiento.obs);
            cmd.Parameters.AddWithValue("@paquete", ObjMovimientoProcedimiento.paquete);

            if (ObjMovimientoProcedimiento.ProveedorTercero.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@ProveedorTercero", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ProveedorTercero", ObjMovimientoProcedimiento.ProveedorTercero);
            }

            cmd.Parameters.AddWithValue("@ProveedorCodigo", ObjMovimientoProcedimiento.ProveedorCodigo);            
            return Datos.Mantenimiento(cmd);
        }

        //ACTUALIZAR MOVIMIENTO PROCEDIMIENTO
        public int MovimientoProcedimiento_Actualizar(MovimientoProcedimiento ObjMovimientoProcedimiento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoProcedimiento_Update";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoProcedimiento.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoProcedimiento.DetalleId);
            cmd.Parameters.AddWithValue("@ProcedimientoId", ObjMovimientoProcedimiento.ProcedimientoId);
            cmd.Parameters.AddWithValue("@ProcedimientoIdNuevo", ObjMovimientoProcedimiento.ProcedimientoIdNuevo);
            cmd.Parameters.AddWithValue("@Cantidad", ObjMovimientoProcedimiento.Cantidad);
            cmd.Parameters.AddWithValue("@Monto", ObjMovimientoProcedimiento.Monto);
            cmd.Parameters.AddWithValue("@Prescrito", ObjMovimientoProcedimiento.Prescrito);
            cmd.Parameters.AddWithValue("@Consumo", ObjMovimientoProcedimiento.Consumo);
            cmd.Parameters.AddWithValue("@Convenio", ObjMovimientoProcedimiento.Convenio);
            cmd.Parameters.AddWithValue("@obs", ObjMovimientoProcedimiento.obs);
            cmd.Parameters.AddWithValue("@paquete", ObjMovimientoProcedimiento.paquete);

            if (ObjMovimientoProcedimiento.ProveedorTercero.ToString() == String.Empty)
            {
                cmd.Parameters.AddWithValue("@ProveedorTercero", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ProveedorTercero", ObjMovimientoProcedimiento.ProveedorTercero);
            }

            cmd.Parameters.AddWithValue("@ProveedorCodigo", ObjMovimientoProcedimiento.ProveedorCodigo);            
            return Datos.Mantenimiento(cmd);
        }

        //ACTUALIZAR MOVIMIENTO PROCEDIMIENTO - CM
        public int GuardarControlMedicoProcedimientoAtencion(vw_MovimientoPacienteProcedimiento ObjMovimientoProcedimiento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GuardarControlMedicoProcedimientoAtencion";
                cmd.Parameters.AddWithValue("@Fua", ObjMovimientoProcedimiento.Fua);
                cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoProcedimiento.DetalleId);
                cmd.Parameters.AddWithValue("@ProcedimientoId", ObjMovimientoProcedimiento.ProcedimientoId);
                if (ObjMovimientoProcedimiento.CMObs != null)
                    cmd.Parameters.AddWithValue("@CMObs", ObjMovimientoProcedimiento.CMObs);
                else
                    cmd.Parameters.AddWithValue("@CMObs", false);
                cmd.Parameters.AddWithValue("@CMTipoObservacionId", ObjMovimientoProcedimiento.CMTipoObservacionId);
                cmd.Parameters.AddWithValue("@CMObsDesc", ObjMovimientoProcedimiento.CMObsDesc);
                if (ObjMovimientoProcedimiento.CMCantidadObservada != null)
                    cmd.Parameters.AddWithValue("@CMCantidadObservada", ObjMovimientoProcedimiento.CMCantidadObservada);
                else
                    cmd.Parameters.AddWithValue("@CMCantidadObservada", 0);
                return Datos.Mantenimiento(cmd);
            }
        }

        //ELIMINAR MOVIMIENTO PROCEDIMIENTO
        public int MovimientoProcedimiento_Eliminar(MovimientoProcedimiento ObjMovimientoProcedimiento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoProcedimiento_Delete";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoProcedimiento.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoProcedimiento.DetalleId);
            cmd.Parameters.AddWithValue("@ProcedimientoId", ObjMovimientoProcedimiento.ProcedimientoId);
            return Datos.Mantenimiento(cmd);
        } 

    }
}
