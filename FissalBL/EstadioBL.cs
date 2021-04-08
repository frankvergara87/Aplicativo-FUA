using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class EstadioBL
    {
        private EstadioDA objEstadioDA;
        
        // constructor
        public EstadioBL()
        {
            objEstadioDA = new EstadioDA();
        }

         //OBTIENE LISTA TOTAL ESTADIOS
        public DataTable GetAllEstadios()
        {
            return objEstadioDA.GetAllEstadios();
        }


        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        //OBTIENE LISTA ESTADIO - DROPDOWNLIST - WEB

        public DataTable Estadio_ListaCombo(string CategoriaId, string FechaActual, int EstablecimientoId)
        {
            return objEstadioDA.Estadio_ListaCombo(CategoriaId, FechaActual, EstablecimientoId);
        }

    }
}
