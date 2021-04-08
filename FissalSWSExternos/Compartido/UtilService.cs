using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FissalSWSExternos
{
    public class UtilService
    {
        public static bool ValidarCredencial(CredencialServicio credencial,out string mensaje)
        {
            bool validado = true;
            mensaje = "";
            if (credencial.UserName != "fissal" || credencial.Password != "fissal2015")
            {
                mensaje = "Usuario o Clave no son validos";             
                validado = false;
            }          
            return validado;
        }
    }
}