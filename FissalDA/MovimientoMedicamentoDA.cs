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
    public class MovimientoMedicamentoDA
    {
        static SqlCommand cmd = new SqlCommand();

        //OBTIENE LISTA MOVIMIENTO MEDICAMENTO POR FUA
        public List<vw_movimientoPacienteMedicamento> GetVwMovimientoPacienteMedicamentoPorFua(Int64 fua)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GetVwMovimientoPacienteMedicamentoPorFua";
                cmd.Parameters.AddWithValue("@Fua", fua);
                List<vw_movimientoPacienteMedicamento> listaMedicamentos = new List<vw_movimientoPacienteMedicamento>();
                using (DbDataReader dr = Datos.ObtenerDbDataReaderPorProcedure(cmd))
                {
                    while (dr.Read())
                    {
                        listaMedicamentos.Add(CargarMedicamento(dr));
                    }
                }
                return listaMedicamentos;
            }
        }
        
        public vw_movimientoPacienteMedicamento CargarMedicamento(IDataReader dr)
        {
            vw_movimientoPacienteMedicamento objMedicamento = new vw_movimientoPacienteMedicamento();
            objMedicamento.Cantidad = Convert.ToInt32(dr["Cantidad"]);
            if (dr["CantidadPagadaSIS"] != DBNull.Value)
                objMedicamento.CantidadPagadaSIS = Convert.ToInt32(dr["CantidadPagadaSIS"]);
            if (dr["CMCantidadObservada"] != DBNull.Value)
                objMedicamento.CMCantidadObservada = Convert.ToInt32(dr["CMCantidadObservada"]);
            if (dr["CMObs"] != DBNull.Value)
                objMedicamento.CMObs = Convert.ToBoolean(dr["CMObs"]);
            objMedicamento.CMObsDesc = dr["CMObsDesc"].ToString();
            if (dr["CMTipoObservacionId"] != DBNull.Value)
                objMedicamento.CMTipoObservacionId = Convert.ToInt32(dr["CMTipoObservacionId"]);
            objMedicamento.Consumo = Convert.ToInt32(dr["Consumo"]);
            objMedicamento.Convenio = Convert.ToInt32(dr["Convenio"]);
            objMedicamento.DescripcionSiga = dr["DescripcionSiga"].ToString();
            objMedicamento.DetalleId = Convert.ToInt32(dr["DetalleId"]);
            objMedicamento.esquemadescripcion = dr["esquemadescripcion"].ToString();
            objMedicamento.EsquemaId = Convert.ToInt16(dr["EsquemaId"]);
            objMedicamento.EstablecimientoId = Convert.ToInt32(dr["EstablecimientoId"]);
            objMedicamento.Fua = Convert.ToInt64(dr["Fua"]);
            objMedicamento.Lote = dr["Lote"].ToString();
            objMedicamento.MedicamentoId = Convert.ToInt32(dr["MedicamentoId"]);
            objMedicamento.Monto = Convert.ToDecimal(dr["Monto"]);
            objMedicamento.obs = dr["obs"].ToString();
            objMedicamento.paquete = Convert.ToBoolean(dr["paquete"]);
            objMedicamento.Prescrito = Convert.ToInt32(dr["Prescrito"]);
            objMedicamento.DigemidId = dr["DigemidId"].ToString();
            return objMedicamento;
        }

        //OBTIENE LISTA MOVIMIENTO MEDICAMENTO POR FUA
        public DataTable MovimientoMedicamento_ListarxFua(MovimientoMedicamento objMovimientoMedicamento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ate_MovimientoMedicamento_ListarxFua";
            cmd.Parameters.AddWithValue("@Fua", objMovimientoMedicamento.Fua);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        //INSERTAR MOVIMIENTO MEDICAMENTO
        public int MovimientoMedicamento_Insertar(MovimientoMedicamento ObjMovimientoMedicamento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoMedicamento_Insert";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoMedicamento.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoMedicamento.DetalleId);
            cmd.Parameters.AddWithValue("@MedicamentoId", ObjMovimientoMedicamento.MedicamentoId);
            cmd.Parameters.AddWithValue("@EsquemaId", ObjMovimientoMedicamento.EsquemaId);
            cmd.Parameters.AddWithValue("@Cantidad", ObjMovimientoMedicamento.Cantidad);
            cmd.Parameters.AddWithValue("@Monto", ObjMovimientoMedicamento.Monto);
            cmd.Parameters.AddWithValue("@Prescrito", ObjMovimientoMedicamento.Prescrito);
            cmd.Parameters.AddWithValue("@Consumo", ObjMovimientoMedicamento.Consumo);
            cmd.Parameters.AddWithValue("@Convenio", ObjMovimientoMedicamento.Convenio);
            cmd.Parameters.AddWithValue("@obs", ObjMovimientoMedicamento.obs);
            cmd.Parameters.AddWithValue("@paquete", ObjMovimientoMedicamento.paquete);
            return Datos.Mantenimiento(cmd);
        }


        //ACTUALIZA MOVIMIENTO MEDICAMENTO
        public int MovimientoMedicamento_Actualizar(MovimientoMedicamento ObjMovimientoMedicamento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoMedicamento_Update";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoMedicamento.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoMedicamento.DetalleId);
            cmd.Parameters.AddWithValue("@MedicamentoId", ObjMovimientoMedicamento.MedicamentoId);
            cmd.Parameters.AddWithValue("@MedicamentoIdNuevo", ObjMovimientoMedicamento.MedicamentoIdNuevo);
            cmd.Parameters.AddWithValue("@EsquemaId", ObjMovimientoMedicamento.EsquemaId);
            cmd.Parameters.AddWithValue("@Cantidad", ObjMovimientoMedicamento.Cantidad);
            cmd.Parameters.AddWithValue("@Monto", ObjMovimientoMedicamento.Monto);
            cmd.Parameters.AddWithValue("@Prescrito", ObjMovimientoMedicamento.Prescrito);
            cmd.Parameters.AddWithValue("@Consumo", ObjMovimientoMedicamento.Consumo);
            cmd.Parameters.AddWithValue("@Convenio", ObjMovimientoMedicamento.Convenio);
            cmd.Parameters.AddWithValue("@obs", ObjMovimientoMedicamento.obs);
            cmd.Parameters.AddWithValue("@paquete", ObjMovimientoMedicamento.paquete);
            return Datos.Mantenimiento(cmd);
        }

        //ACTUALIZA MOVIMIENTO MEDICAMENTO - CM
        public int GuardarControlMedicoMedicamentoAtencion(vw_movimientoPacienteMedicamento ObjMovimientoMedicamento)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "sp2_GuardarControlMedicoMedicamentoAtencion";
                cmd.Parameters.AddWithValue("@Fua", ObjMovimientoMedicamento.Fua);
                cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoMedicamento.DetalleId);
                cmd.Parameters.AddWithValue("@MedicamentoId", ObjMovimientoMedicamento.MedicamentoId);
                cmd.Parameters.AddWithValue("@EsquemaId", ObjMovimientoMedicamento.EsquemaId);
                if (ObjMovimientoMedicamento.CMObs != null)
                    cmd.Parameters.AddWithValue("@CMObs", ObjMovimientoMedicamento.CMObs);
                else
                    cmd.Parameters.AddWithValue("@CMObs", false);
                cmd.Parameters.AddWithValue("@CMTipoObservacionId", ObjMovimientoMedicamento.CMTipoObservacionId);
                cmd.Parameters.AddWithValue("@CMObsDesc", ObjMovimientoMedicamento.CMObsDesc);
                if (ObjMovimientoMedicamento.CMCantidadObservada != null)
                    cmd.Parameters.AddWithValue("@CMCantidadObservada", ObjMovimientoMedicamento.CMCantidadObservada);
                else
                    cmd.Parameters.AddWithValue("@CMCantidadObservada", 0);
                return Datos.Mantenimiento(cmd);
            }
        }


        //ELIMINA MOVIMIENTO MEDICAMENTO
        public int MovimientoMedicamento_Eliminar(MovimientoMedicamento ObjMovimientoMedicamento)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_ATE_MovimientoMedicamento_Delete";
            cmd.Parameters.AddWithValue("@Fua", ObjMovimientoMedicamento.Fua);
            cmd.Parameters.AddWithValue("@DetalleId", ObjMovimientoMedicamento.DetalleId);
            cmd.Parameters.AddWithValue("@MedicamentoId", ObjMovimientoMedicamento.MedicamentoId);
            return Datos.Mantenimiento(cmd);
        } 



    }
}
