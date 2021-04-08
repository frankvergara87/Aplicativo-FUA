using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FissalWebForm.Solicitudes
{
    public partial class FrmMantUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FrmLogin.aspx");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}