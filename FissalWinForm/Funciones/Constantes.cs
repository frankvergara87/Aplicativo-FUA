using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Provider;
using FissalBE;
using FissalBL;

namespace FissalWinForm
{
    public class Constantes
    {
        //-----------------------------------------------------------------------------------
        //Variables

        public static string TITULO
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["Titulo"]); }
        }


        //-----------------------------------------------------------------------------------
        //Mensaje y/o Alertas

        public static string MSJ_OK
        {
            get { return Convert.ToString(ConfigurationManager.AppSettings["Msj_OK"]); }
        }

    }
}
