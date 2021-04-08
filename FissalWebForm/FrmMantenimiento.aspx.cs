using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FissalWebForm
{
    public partial class FrmMantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //lblUsuariosConectados.Text = "Usuario conectados: " + Session["us"].ToString();
                Session.Abandon();
                Session.Clear();
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                HttpContext.Current.Session["login"] = null;
                HttpContext.Current.Session["password"] = null;

                
           }
        }
    }
}