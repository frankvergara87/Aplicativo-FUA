using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FissalBE;
using FissalBL;  

namespace FissalWebForm
{
    public partial class FrmLogin2 : System.Web.UI.Page
    {
        UsuarioBL objUsuarioBL = new UsuarioBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
                Session.Clear();
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                HttpContext.Current.Session["login"] = null;
                HttpContext.Current.Session["password"] = null;

                lblInformeLogin.Text = String.Empty;
                txtUsuario.Focus();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            DataTable dt = new DataTable();
            u.login = txtUsuario.Text;
            u.password = txtLogin.Text;
            dt = objUsuarioBL.usuarioLogin(u);

            if (txtUsuario.Text != String.Empty)
            {
                if (txtLogin.Text != String.Empty)
                {
                    if (dt.Rows.Count == 0)
                    {
                        lblInformeLogin.Text = "Usuario ó Contraseña no encontrado";
                    }
                    else
                    {   
                        lblInformeLogin.Text = String.Empty;

                        DataRow row = dt.Rows[0];
                        Session["UsuarioId"] = (int)row["id_usuario"];
                        Session["login"] = row["login"].ToString();
                        Session["password"] = row["password"].ToString();
                        Session["Descripcion"] = row["Descripcion"].ToString();
                        Session["EstablecimientoId"] = (int)row["EstablecimientoId"];
                        Session["nivel"] = row["nivel"].ToString();
                        Session["login"] = row["login"].ToString();
                        Session["Id_Perfil"] = (int)row["Id_Perfil"];
                        Session["DescPerfil"] = row["DescPerfil"].ToString();

                        #region variables globales winform
                        VariablesGlobales.UsuarioId = (int)row["id_usuario"];
                        VariablesGlobales.Login = row["login"].ToString();
                        VariablesGlobales.EstablecimientoDescripcion = row["Descripcion"].ToString();
                        VariablesGlobales.EstablecimientoId = (int)row["EstablecimientoId"];
                        VariablesGlobales.EstablecimientoNivel = row["nivel"].ToString();
                        VariablesGlobales.Id_Perfil = (int)row["Id_Perfil"];           /************** Nuevo */
                        VariablesGlobales.DescPerfil = row["DescPerfil"].ToString();   /************** Nuevo */
                        VariablesGlobales.CatPerfil = (int)row["CatPerfil"];           /************** Nuevo */
                        #endregion

                        Response.Redirect("~/Solicitudes/FrmMantSolicitud.aspx");
                        //Response.Redirect("..//Solicitudes/FrmMantSolicitud.aspx");
                    }
                }
                else
                {
                    lblInformeLogin.Text = "Ingrese una Contraseña";
                }
            }
            else
            {
                lblInformeLogin.Text = "Ingrese un Usuario";
            }
        }
    }
}