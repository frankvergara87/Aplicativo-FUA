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
using FissalWinForm.ServiceReference1;


namespace FissalWinForm
{
    public partial class FrmValidacionSis : Form
    {
        public FrmValidacionSis()
        {
            InitializeComponent();
        }

        DataTable dtPacientesSis;
        private void FrmValidacionSis_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }


        #region Metodos
        void CargaGrilla()
        {
            EstadoCuentaConciliacionBL objEstadoCuentaConciliacionBL = new EstadoCuentaConciliacionBL();
            dtPacientesSis = new DataTable();

            dtPacientesSis = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ListarPacientesSis();
            dgvListadoPacientesSis.DataSource = dtPacientesSis;
        }

        void ValidarSis() 
        {
            int msgsis;
            EstadoCuentaConciliacionBL objEstadoCuentaConciliacionBL = new EstadoCuentaConciliacionBL();
            PacienteBL objPacienteBL = new PacienteBL();

            CredencialWS Clave = new CredencialWS();
            siswsSoapClient ws = new siswsSoapClient();
            string Trama = string.Empty;
            string[] Campos;
            string FechaVigencia;
            string Componente;
            /***********************CREDENCIALES WS.*/
            Clave.Usuario = "fissal";
            Clave.Clave = "uhy2c32zlk";
            /***********************/

            /*************CONSULTAMOS DATA SIS - WS**/

            int codigoConciliacion = VariablesGlobales.CodigoConciliacionX;
            List<string> listaPacientes = objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ListarPacienteIdSis();
            int filasPacientes = listaPacientes.Count;
            string pacienteId;

            for (int i = 0; i < filasPacientes; i++)
            {
                msgsis = 0;
                pacienteId = listaPacientes[i];
                Paciente ObjPaciente = objPacienteBL.GetPacientePorId(pacienteId);
                /****************************************************************/
                if (ObjPaciente.TipoDocumentoId == 1)
                {
                    try
                    {
                        Trama = ws.BuscarAseguradosDocIdent(Clave, "00006210", "1", ObjPaciente.NumeroDocumento);
                    }
                    catch //(Exception ex)
                    {
                        Trama = string.Empty;
                        msgsis = 1;
                    }


                }
                else if (ObjPaciente.TipoDocumentoId == 2)
                {
                    try
                    {
                        Trama = ws.BuscarAseguradosDocIdent(Clave, "00006210", "2", "0" + ObjPaciente.NumeroDocumento);
                    }
                    catch //(Exception ex)
                    {
                        Trama = string.Empty;
                        msgsis = 1;
                    }

                }

                if (msgsis != 1)
                {
                    if (!string.Equals(Trama, string.Empty))
                    {
                        Campos = Trama.Split('|');
                        FechaVigencia = Campos[16];
                        Componente = Campos[13];

                        /****** AGREGAR VALIDACION VIGENCIA *******************/

                        if (Componente == "1") // SUBSIDIADO = ACTIVO
                        {
                            objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ActualizaActivoSIS(pacienteId, "1");
                        }
                        else if (Componente == "2") // NRUSS
                        {
                            if (FechaVigencia != "")
                            {
                                string FVigencia = FechaVigencia.ToString();
                                string Eval = FVigencia.Substring(6, 2) + '/' + FVigencia.Substring(4, 2) + '/' + FVigencia.Substring(0, 4);

                                DateTime FEval = Convert.ToDateTime(Eval);
                                DateTime FHoy = DatosBL.GetDate();

                                if (FEval > FHoy)
                                {
                                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ActualizaActivoSIS(pacienteId, "1");
                                }
                                else
                                {
                                    objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ActualizaActivoSIS(pacienteId, "0");
                                }

                            }
                            else
                                objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ActualizaActivoSIS(pacienteId, "1");
                        }
                        /******************************************************/
                    }
                    else
                        objEstadoCuentaConciliacionBL.EstadoCuentaConciliacion_ActualizaActivoSIS(pacienteId, "0");

                    /****************************************************************/
                }
                else
                {
                    DialogResult result = MessageBox.Show("¡Problemas de conexion con el SIS..!", "FISSAL", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                    {
                        ValidarSis();
                    }
                }


            }
            CargaGrilla();
            MessageBox.Show("¡Proceso SIS Concluido!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        #endregion

        #region Eventos
        private void tsBtnValidar_Click(object sender, EventArgs e)
        {
            ValidarSis();
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
