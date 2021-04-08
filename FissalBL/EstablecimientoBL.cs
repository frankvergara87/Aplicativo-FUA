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
    public class EstablecimientoBL
    {
        private EstablecimientoDA objEstablecimientoDA;
        
        // constructor
        public EstablecimientoBL()
        {
            objEstablecimientoDA = new EstablecimientoDA();
        }

        //OBTIENE LISTA TOTAL ESTABLECIMIENTOS
        public DataTable GetEstablecimientosPorIdDescripcionSisId(string establecimiento)
        {
            return objEstablecimientoDA.GetEstablecimientosPorIdDescripcionSisId(establecimiento);
        }

         //OBTIENE LISTA TOTAL ESTABLECIMIENTOS CON CONVENIO
        public DataTable GetEstablecimientosConvenio()
        {
            return objEstablecimientoDA.GetEstablecimientosConvenio();
        }

        public DataTable GetEstablecimientosCierreDig()
        {
            return objEstablecimientoDA.GetEstablecimientosCierreDig();
        }

        public DataTable Establecimiento_listar()
        {
            return objEstablecimientoDA.Establecimientos_listar();
        }


        public DataTable Establecimiento_Consulta()
        {
            return objEstablecimientoDA.Establecimiento_Consulta();
        }

        public DataTable Establecimiento_listarxconvenio()
        {
            return objEstablecimientoDA.Establecimientos_listarxconvenio();
        }

        public DataTable Establecimiento_BuscarxRenaesSIS(Establecimiento objEstablecimiento)
        {
            return objEstablecimientoDA.Establecimiento_BuscarxRenaesSIS(objEstablecimiento);
        }

        //OBTIENE LISTA ESTABLECIMIENTOS RENAES | DESCRIPCION | SIS
        public DataTable Establecimiento_Filtrar(string cadena)
        {
            return objEstablecimientoDA.Establecimiento_Filtrar(cadena);
        }

    }
}
