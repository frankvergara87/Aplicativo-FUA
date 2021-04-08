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
    public class SaldoCuentaConciliacionBL
    {
        SaldoCuentaConciliacionDA objSaldoCuentaConciliacionDA = new SaldoCuentaConciliacionDA();

        //GESTION DE CUENTA (CONCILIACION)
        //INSERTAR SALDO CUENTA CONCILIACION
        public int SaldoCuentaConciliacion_Insert(SaldoCuentaConciliacion objSaldoCuentaConciliacion)
        {
            return objSaldoCuentaConciliacionDA.SaldoCuentaConciliacion_Insert(objSaldoCuentaConciliacion);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR SALDO CUENTA CONCILIACION
        public DataTable SaldoCuentaConciliacion_Listar(int CodigoConciliacion, int EstablecimientoId, int Nro)
        {
            return objSaldoCuentaConciliacionDA.SaldoCuentaConciliacion_Listar(CodigoConciliacion, EstablecimientoId, Nro);
        }

        //GESTION DE CUENTA (CONCILIACION)      
        //LISTAR SALDO CUENTA CONCILIACION X PACIENTE
        public DataTable SaldoCuentaConciliacion_ListarxPaciente(int CodigoConciliacion, int? TipoDocumento, string NroDocumento, string Nombres)
        {
            return objSaldoCuentaConciliacionDA.SaldoCuentaConciliacion_ListarxPaciente(CodigoConciliacion, TipoDocumento, NroDocumento, Nombres);
        }
    }
}
