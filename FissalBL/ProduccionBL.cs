using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FissalDA;
using FissalBE;
using System.Transactions;

namespace FissalBL
{   
    public class ProduccionBL
    {
        ProduccionDA objProduccionDA = new ProduccionDA();

        //GESTION DE CUENTA
        //GENERAR NUEVO NUMERO DE FUA
        public DataTable Produccion_Nuevo()
        {
            return objProduccionDA.Produccion_Nuevo();
        }

        //GESTION DE CUENTA
        //LISTA DE PERIODOS DE PRODUCCION (AÑO)
        public DataTable MovimientoPaciente_ListarPeriodoAnio()
        {
            return objProduccionDA.MovimientoPaciente_ListarPeriodoAnio();
        }

        //GESTION DE CUENTA
        //LISTA DE PERIODOS DE PRODUCCION (MES)
        public DataTable MovimientoPaciente_ListarPeriodoMes(int Anio)
        {
            return objProduccionDA.MovimientoPaciente_ListarPeriodoMes(Anio);
        }

        //GESTION DE CUENTA
        //LISTA DE PRODUCCION
        public DataTable Produccion_Listar(string Codigo, bool Cerrada, string FechaInicio, string FechaFin, int Nro)
        {
            return objProduccionDA.Produccion_Listar(Codigo, Cerrada, FechaInicio, FechaFin, Nro);
        }

        //GESTION DE CUENTA
        //INSERTAR PRODUCCION (INICIO)
        public int Produccion_Insert(Produccion objProduccion)
        {
            return objProduccionDA.Produccion_Insert(objProduccion);
        }        

        //GESTION DE CUENTA
        //ACTUALIZAR PRODUCCION EN MOVIMIENTO PACIENTE
        public int MovimientoPaciente_UpdateProduccionId(int ProduccionId, string Periodo, string Mes)
        {
            return objProduccionDA.MovimientoPaciente_UpdateProduccionId(ProduccionId, Periodo, Mes);
        }

        //GESTION DE CUENTA
        //VERIFICAR PERIODO EXISTENTE
        public DataTable Produccion_Verificar(string Periodo, string Mes)
        {
            return objProduccionDA.Produccion_Verificar(Periodo, Mes);
        }

        //GESTION DE CUENTA
        //VERIFICAR FUAS EXISTENTES X IPRESS PARA INICIAR PROCESO
        public DataTable MovimientoPaciente_VerificarIpress(string Periodo, string Mes)
        {
            return objProduccionDA.MovimientoPaciente_VerificarIpress(Periodo, Mes);
        }

        //GESTION DE CUENTA
        //LISTA DE DETALLE X PRODUCCION
        public DataTable ProduccionEstablecimiento_Listar(Produccion objProduccion)
        {
            return objProduccionDA.ProduccionEstablecimiento_Listar(objProduccion);
        }

        //GESTION DE CUENTA
        //ACTUALIZAR FECHA CIERRE | ESTADO DE PRODUCCION
        public int Produccion_UpdateFechaCierre(Produccion objProduccion)
        {
            return objProduccionDA.Produccion_UpdateFechaCierre(objProduccion);
        }

        //GESTION DE CUENTA (CONTROL MEDICO)
        //LISTA DE PERIODOS DE PRODUCCION
        public DataTable Produccion_ListarPeriodo()
        {
            return objProduccionDA.Produccion_ListarPeriodo();
        }

        //GESTION DE CUENTA (CONCILIACION)
        //LISTA DE PERIODOS DE PRODUCCION
        public DataTable Produccion_ListarPeriodoConciliacion()
        {
            return objProduccionDA.Produccion_ListarPeriodoConciliacion();
        }

        //GESTION DE CUENTA (CONCILIACION)
        //ACTUALIZAR FECHA CIERRE | ESTADO DE PRODUCCION 
        public int ProduccionConciliacion_Cierre(Produccion objProduccion)
        {
            return objProduccionDA.ProduccionConciliacion_Cierre(objProduccion);
        }

        //GESTION DE CUENTA (CONCILIACION)
        //VERIFICAR PERIODOS DE PRODUCCION CONCILIADAS
        public bool FaltaConciliarProducciones(int produccionId)
        {
            return objProduccionDA.FaltaConciliarProducciones(produccionId);
        }
    }
}
