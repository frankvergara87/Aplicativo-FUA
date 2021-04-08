using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalDA;

namespace FissalBL
{
    public class CategoriaCIEBL
    {
        private CategoriaCIEDA objCategoriaCIEDA;
        
        // constructor
        public CategoriaCIEBL()
        {
            objCategoriaCIEDA = new CategoriaCIEDA();
        }

        //OBTIENE LISTA DIAGNOSTICOS CON COBERTURA
        public DataTable GetCategoriasCobertura()
        {
            return objCategoriaCIEDA.GetCategoriasCobertura();
        }

         //OBTIENE LISTA DIAGNOSTICOS X DESCRIPCION O  CATEGORIA_ID
        public DataTable GetDiagnosticosCoberturaPorIdDescripcion(string diagnostico)
        {
            return objCategoriaCIEDA.GetDiagnosticosCoberturaPorIdDescripcion(diagnostico);
        }

        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        //OBTIENE LISTA CATEGORIAS - DROPDOWNLIST - WEB

        public DataTable Categoria_ListaCombo(string FechaActual, int EstablecimientoId)
        {
            return objCategoriaCIEDA.Categoria_ListaCombo(FechaActual, EstablecimientoId);
        }

    }
}
