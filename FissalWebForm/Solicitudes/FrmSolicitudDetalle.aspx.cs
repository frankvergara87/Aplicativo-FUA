using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FissalBE;
using FissalBL;
using FissalWebForm;
using FissalWebForm.ServiceReference1;

namespace FissalWebForm.Solicitudes
{
    public partial class FrmSolicitudDetalle : System.Web.UI.Page
    {
        SolicitudAutorizacionBL objSolicitudAutorizacionBL = new SolicitudAutorizacionBL();

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
                    string Proceso = this.PreviousPage.Est ;
                    string NroSolicitud = this.PreviousPage.Codigo;

                    if (Proceso == "Ver")
                    {
                        SolicitudAutorizacion ListaSolicitudes = new SolicitudAutorizacion();
                        ListaSolicitudes = objSolicitudAutorizacionBL.SolicitudAutorizacion_Obtener_Completo(NroSolicitud);

                        txtNumSolicitud.Text = NroSolicitud; // Request.QueryString["NroSolicitud"];
                        txtPaciente.Text = ListaSolicitudes.PacienteId;
                        txtNomPaciente.Text = ListaSolicitudes.Nombres;
                        txtApePatPaciente.Text = ListaSolicitudes.ApellidoPaterno;
                        txtApeMatPaciente.Text = ListaSolicitudes.ApellidoMaterno;
                        txtFechaSolicitud.Text = Convert.ToString(ListaSolicitudes.fechaSolicitud).Substring(0,10);
                        lblEstablecimiento.Text = ListaSolicitudes.Descripcion;

                        CargarDetalles(NroSolicitud);
                        HideColumns(gvListaDetalleSolicitudes);  
                    }
                
                }            
            }
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Session["Val"] = null;
            Session["Val"] = 1;
            Response.Redirect("~/Solicitudes/FrmMantSolicitud.aspx");
        }

        void CargarDetalles(string NroSolicitud) 
        {
            gvListaDetalleSolicitudes.DataSource = objSolicitudAutorizacionBL.SolicitudAutorizacion_Detalle_Completo(NroSolicitud);
            gvListaDetalleSolicitudes.DataBind();
        }

        protected void gvListaDetalleSolicitudes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvListaDetalleSolicitudes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[5].Text == "False")
                {
                    ImageButton imgBtn1 = new ImageButton();
                    imgBtn1.ImageUrl = "~/Images/Mantenimiento/NoProcesado.ico";
                    imgBtn1.Width = 23;
                    imgBtn1.Height = 23;

                    e.Row.Cells[6].Enabled = false;
                    e.Row.Cells[6].Controls.Clear();
                    e.Row.Cells[6].Controls.Add(imgBtn1);
                }
                else if (e.Row.Cells[5].Text == "True")
                {
                    if (e.Row.Cells[4].Text == "True") 
                    {
                        ImageButton imgBtn2 = new ImageButton();
                        imgBtn2.ImageUrl = "~/Images/Mantenimiento/aproved.ico";
                        imgBtn2.Width = 23;
                        imgBtn2.Height = 23;

                        e.Row.Cells[6].Enabled = false;
                        e.Row.Cells[6].Controls.Clear();
                        e.Row.Cells[6].Controls.Add(imgBtn2);                    
                    }
                    else if (e.Row.Cells[4].Text == "False") 
                    {
                        ImageButton imgBtn2 = new ImageButton();
                        imgBtn2.ImageUrl = "~/Images/Mantenimiento/denied.ico";
                        imgBtn2.Width = 23;
                        imgBtn2.Height = 23;

                        e.Row.Cells[6].Enabled = false;
                        e.Row.Cells[6].Controls.Clear();
                        e.Row.Cells[6].Controls.Add(imgBtn2); 
                    }

                }
                else { e.Row.Cells[6].Enabled = false; }
            }
        }

        private void HideColumns(GridView gv)
        {
            if (gv.Rows.Count != 0)
            {
                gv.HeaderRow.Cells[4].Visible = false;
                gv.HeaderRow.Cells[5].Visible = false;

                foreach (GridViewRow row in gv.Rows)
                {
                    row.Cells[4].Visible = false;
                    row.Cells[5].Visible = false;
                }
            
            
            }
        
        }
    }
}