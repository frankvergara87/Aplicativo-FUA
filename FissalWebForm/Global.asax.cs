using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FissalWeb
{
    public class Global : System.Web.HttpApplication
    {
        private int cnt;
        private int UsuarioConectado;


        protected void Application_Start(object sender, EventArgs e)
        {
            cnt = 0;
            UsuarioConectado = 0;
        }        
        
        void Session_Start(object sender, EventArgs e) 
        {   
            Session["cv"] = cnt++;
            Session["us"] = UsuarioConectado++;
        }

        void Session_End(object sender, EventArgs e)
        {
            Session["us"] = UsuarioConectado--;
        }    
       



    }
}