using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoWCF
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WSPaciente.CredencialServicio credencial = new WSPaciente.CredencialServicio();
            credencial.UserName = "fissal";
            credencial.Password = "fissal2015";

            WSPaciente.PacienteServiceClient wsCliente = new WSPaciente.PacienteServiceClient();
            WSPaciente.PacienteRespuesta objPacienteResp = wsCliente.ConsultarPaciente(credencial,int.Parse(txtTipodoc.Text), txtNroDoc.Text, int.Parse(txtIpress.Text));
            if (objPacienteResp.Codigo == 3)
            {              
                WSPaciente.Paciente objPaciente = objPacienteResp.Paciente;
                txtApe.Text = objPaciente.ApellidoPaterno + " " + objPaciente.ApellidoMaterno;
                txtNom.Text = objPaciente.Nombres;
                dgvAuto.DataSource = objPaciente.Autrizaciones;
            }
            wsCliente.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
