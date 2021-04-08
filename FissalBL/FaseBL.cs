using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class FaseBL
    {
        private FaseDA objFaseDA;
        
        // constructor
        public FaseBL()
        {
            objFaseDA = new FaseDA();
        }

         //OBTIENE LISTA TOTAL FASES
        public DataTable GetAllFases()
        {
            return objFaseDA.GetAllFases();
        }


        /* \************************************************ WEB *******/
        /*  \**********************************************************/

        //OBTIENE LISTA FASE - DROPDOWNLIST - WEB

        public DataTable Fase_ListaCombo(string CategoriaId, int Estadio, string FechaActual, int EstablecimientoId)
        {
            return objFaseDA.Fase_ListaCombo(CategoriaId, Estadio, FechaActual, EstablecimientoId);
        }
    }
}
