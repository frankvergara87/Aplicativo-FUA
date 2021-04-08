using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FissalReservas
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null & Session["password"] == null)
            {
                Response.Redirect("~/FrmLogin.aspx");
            }
            else
            {

                if (!IsPostBack)
                {
                    //lblUsuarioLogueado.Text = "Usuario: " + Session["login"].ToString();
                }

                lblContador.Text = Session["cv"].ToString();
            }
        }

        protected void lnkSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Session["login"] = null;
            HttpContext.Current.Session["password"] = null;
            Response.Redirect("~/FrmLogin.aspx");
        }
    }
}