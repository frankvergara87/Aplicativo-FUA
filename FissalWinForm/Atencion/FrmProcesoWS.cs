using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FissalBE;
using FissalBL;


namespace FissalWinForm
{
    public partial class FrmProcesoWS : Form
    {
        public FrmProcesoWS()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    Fissal.WSExternos.CredencialServicio credencial = new Fissal.WSExternos.CredencialServicio();
        //    credencial.UserName = "fissal";
        //    credencial.Password = "fissal2015";

        //    Fissal.WSExternos.PacienteServiceClient ws = new Fissal.WSExternos.PacienteServiceClient();
        //    //List<Autorizacion> objAutorizaciones = new List<Autorizacion>(); 

        //    Fissal.WSExternos.PacienteRespuesta objResp = ws.ObtenerAutorizaciones(credencial, 5987);
        //    dgvAutorizacion.DataSource = objResp.Autorizacion;


        //    Fissal.WSExternos.PacienteRespuesta objResp2 = ws.ObtenerPacientes(credencial, 5987);
        //    dgvPaciente.DataSource = objResp2.Pacientes;

        //    DataTable pacientes = new DataTable();
        //    //pacientes= objResp2.Pacientes;

            
        //    //foreach (Fissal.WSExternos.Paciente p in objResp2.Pacientes)
        //    //{ 
        //        /*VALIDAR SI EXISTE*/
        //         //string var = p.PacienteId;

        //        /*SI EXISTE*/
        //            /*OMITIR*/
        //        /*CASO CONTRARIO*/
        //            /*INSERTAR - ENVIAR OBJETO PACIENTE*/
        //        /*FIN SI*/
        //    //}




        //    label1.Text = dgvAutorizacion.RowCount.ToString();
        //    label2.Text = dgvPaciente.RowCount.ToString();
        //}

        private void btnValidarPaciente_Click(object sender, EventArgs e)
        {
            btnValidarAuto.Enabled = false;

            FissalBL.MovimientoPacienteBL obj = new FissalBL.MovimientoPacienteBL();

            Fissal.WSExternos.PacienteServiceClient ws = new Fissal.WSExternos.PacienteServiceClient();
            Fissal.WSExternos.CredencialServicio credencial = new Fissal.WSExternos.CredencialServicio();
            credencial.UserName = "fissal";
            credencial.Password = "fissal2015";
            Fissal.WSExternos.PacienteRespuesta objResp2 = ws.ObtenerPacientes(credencial, VariablesGlobales.EstablecimientoId);


            if (objResp2.Pacientes != null)
            {

                DataTable dt = new DataTable();
                //dt = objResp2.Pacientes;
                ListtoDataTableConverter o = new ListtoDataTableConverter();
                dt = o.ToDataTable(objResp2.Pacientes);
                dt.Columns.RemoveAt(0);
                dgvPaciente.DataSource = obj.MovimientoPaciente_PacienteWS(dt);

                label2.Text = dgvPaciente.RowCount.ToString();

                btnAutorizacion.Enabled = true;
                btnValidarAuto.Enabled = true;

            }
            else {

                MessageBox.Show("No existen Pacientes y Autorizaciones nuevas","Actualización",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPaciente.DataSource = null;
                label2.Text = "0";
                dgvAutorizacion.DataSource = null;
                label1.Text = "0";
                btnValidarAuto.Enabled = true;

            }
        }

        private void btnAutorizacion_Click(object sender, EventArgs e)
        {
            btnAutorizacion.Enabled = false;
            FissalBL.AutorizacionBL obj = new FissalBL.AutorizacionBL();

            Fissal.WSExternos.PacienteServiceClient ws = new Fissal.WSExternos.PacienteServiceClient();
            Fissal.WSExternos.CredencialServicio credencial = new Fissal.WSExternos.CredencialServicio();
            credencial.UserName = "fissal";
            credencial.Password = "fissal2015";
            Fissal.WSExternos.PacienteRespuesta objResp = ws.ObtenerAutorizaciones(credencial, VariablesGlobales.EstablecimientoId);

            if (objResp.Autorizacion != null)
            {
                DataTable dt = new DataTable();

                ListtoDataTableConverter o = new ListtoDataTableConverter();
                dt = o.ToDataTable(objResp.Autorizacion);
                dt.Columns.RemoveAt(0);

                DataTable tablaWS = new DataTable();
                tablaWS = obj.MovimientoAutorizacion_AutorizacionWS(dt);

                List<int> autorizacionWS = tablaWS.AsEnumerable().Select(x => int.Parse(x[0].ToString())).ToList();

                ws.ActualizarAutorizaciones(credencial, autorizacionWS);
                dgvAutorizacion.DataSource = tablaWS;
                label1.Text = dgvAutorizacion.RowCount.ToString();
                btnAutorizacion.Enabled = false;
                
            }
            else {
                MessageBox.Show("No existen Autorizaciones nuevas", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAutorizacion.DataSource = null;
                label1.Text = "0";
                btnAutorizacion.Enabled = true;
            }
        }


    }
}
