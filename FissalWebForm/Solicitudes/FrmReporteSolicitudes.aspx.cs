using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FissalBE;
using FissalBL;
using FissalWeb;
using FissalWebForm;

namespace FissalWebForm.Solicitudes
{
    public partial class FrmReporteSolicitudes : System.Web.UI.Page
    {
        SolicitudAutorizacionBL objSolicitudAutorizacionBL = new SolicitudAutorizacionBL();
        bool Procesado;
        string Usuario, script;
        int EstablecimientoId; 

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Codigo"] = null;
            Session["Est"] = null;
            Session["Val"] = null;

            Usuario = Session["login"].ToString();
            EstablecimientoId = Convert.ToInt32(Session["EstablecimientoId"]); 

        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            string FechaD,FechaH;
            DataTable dt = new DataTable();

            if (txtFechaDesde.Text.Length > 0)
            {
                if (txtFechaHasta.Text.Length > 0)
                {
                    if (Convert.ToDateTime(txtFechaDesde.Text) < Convert.ToDateTime(txtFechaHasta.Text) || Convert.ToDateTime(txtFechaDesde.Text) == Convert.ToDateTime(txtFechaHasta.Text))
                    {
                        /*********************************************/
                        FechaD = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime((txtFechaDesde.Text.Substring(6, 4) + "/" + txtFechaDesde.Text.Substring(3, 2) + "/" + txtFechaDesde.Text.Substring(0, 2))));
                        FechaH = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime((txtFechaHasta.Text.Substring(6, 4) + "/" + txtFechaHasta.Text.Substring(3, 2) + "/" + txtFechaHasta.Text.Substring(0, 2))));

                        dt = objSolicitudAutorizacionBL.SolicitudAutorizacion_Reportes(Convert.ToInt32(EstablecimientoId), FechaD, FechaH);

                        if (dt.Rows.Count > 0)
                        {
                            FuncionesBasesWeb.ExportarExcel3(dt);
                        }
                        else
                        {
                            script = "No existen Solicitudes para [Exportar]";
                            ScriptManager.RegisterStartupScript(this.ScriptManager1, GetType(), "Mostrar Mensaje", "Dialog('" + script + "');", true);
                        }
                        /*********************************************/
                    }
                    else 
                    {
                        script = "La [Fecha Desde] debe ser menor que la [Fecha Hasta]";
                        ScriptManager.RegisterStartupScript(this.ScriptManager1, GetType(), "Mostrar Mensaje", "Dialog('" + script + "');", true);
                        txtFechaDesde.Text = String.Empty;
                        txtFechaDesde.Focus();                    
                    }
                }
                else 
                {
                    script = "Ingrese una Fecha [Hasta]";
                    ScriptManager.RegisterStartupScript(this.ScriptManager1, GetType(), "Mostrar Mensaje", "Dialog('" + script + "');", true);
                }
            }
            else 
            {
                script = "Ingrese una Fecha [Desde]";
                ScriptManager.RegisterStartupScript(this.ScriptManager1, GetType(), "Mostrar Mensaje", "Dialog('" + script + "');", true);            
            }
        }

        protected void ddlReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}