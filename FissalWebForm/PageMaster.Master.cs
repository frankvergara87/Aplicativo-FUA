using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace FissalWeb
{
    public partial class PageMaster : System.Web.UI.MasterPage
    {



        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["login"] == null & Session["password"] == null)
            {
                Response.Redirect("~/FrmLogin2.aspx");
            }
            else
            { 

                if (!IsPostBack)
                {
                    lblUsuarioLogueado.Text = "Usuario: " + Session["login"].ToString(); 
                                               //+ " - [" + Session["DescPerfil"].ToString() + "]";
                                               //|  Establecimiento: " +
                                               //Session["Descripcion"].ToString() + "  |  Nivel: " +
                                               //Session["nivel"].ToString();

                }

                lblContador.Text = Session["cv"].ToString();
            }
        }

        protected void lnkSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cache.SetCacheability( HttpCacheability.NoCache);
            HttpContext.Current.Session["login"] = null;
            HttpContext.Current.Session["password"] = null;
            Response.Redirect("~/FrmLogin.aspx");
        }

    }
}