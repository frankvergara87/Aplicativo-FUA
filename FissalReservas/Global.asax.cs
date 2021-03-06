using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FissalReservas
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

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["cv"] = cnt++;
            Session["us"] = UsuarioConectado++;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["us"] = UsuarioConectado--;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}