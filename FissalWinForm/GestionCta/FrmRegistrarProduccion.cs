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
    public partial class FrmRegistrarCierreProduccion : Form
    {
        public FrmRegistrarCierreProduccion()
        {
            InitializeComponent();
        }

        Produccion objProduccion = new Produccion();        
        ProduccionBL objProduccionBL = new ProduccionBL();

        ProduccionEstablecimiento objProduccionEstablecimiento = new ProduccionEstablecimiento();
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

        string Mes;

        private void FormRegistrarCierreProduccion_Load(object sender, EventArgs e)
        {
            DataTable dt = objProduccionBL.MovimientoPaciente_ListarPeriodoAnio();
            cboPeriodo.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                cboPeriodo.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvProduccion.RowCount > 0)
            {
                if (objProduccionBL.Produccion_Verificar(cboPeriodo.Text, cboMes.Text).Rows.Count > 0)
                {
                    MessageBox.Show("¡Error..., Periodo Existe!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cboMes.Text == "Enero" || cboMes.Text == "January")
                    {
                        Mes = "1";
                    }
                    else
                    {
                        if (cboMes.Text == "Febrero" || cboMes.Text == "February")
                        {
                            Mes = "2";
                        }
                        else
                        {
                            if (cboMes.Text == "Marzo" || cboMes.Text == "March")
                            {
                                Mes = "3";
                            }
                            else
                            {
                                if (cboMes.Text == "Abril" || cboMes.Text == "April")
                                {
                                    Mes = "4";
                                }
                                else
                                {
                                    if (cboMes.Text == "Mayo" || cboMes.Text == "May")
                                    {
                                        Mes = "5";
                                    }
                                    else
                                    {
                                        if (cboMes.Text == "Junio" || cboMes.Text == "June")
                                        {
                                            Mes = "6";
                                        }
                                        else
                                        {
                                            if (cboMes.Text == "Julio" || cboMes.Text == "July")
                                            {
                                                Mes = "7";
                                            }
                                            else
                                            {
                                                if (cboMes.Text == "Agosto" || cboMes.Text == "August")
                                                {
                                                    Mes = "8";
                                                }
                                                else
                                                {
                                                    if (cboMes.Text == "Septiembre" || cboMes.Text == "September")
                                                    {
                                                        Mes = "9";
                                                    }
                                                    else
                                                    {
                                                        if (cboMes.Text == "Octubre" || cboMes.Text == "October")
                                                        {
                                                            Mes = "10";
                                                        }
                                                        else
                                                        {
                                                            if (cboMes.Text == "Noviembre" || cboMes.Text == "November")
                                                            {
                                                                Mes = "11";
                                                            }
                                                            else
                                                            {
                                                                if (cboMes.Text == "Diciembre" || cboMes.Text == "December")
                                                                {
                                                                    Mes = "12";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    string CadFechaProduccion = cboPeriodo.Text + "-" + Mes + "-01";
                    DateTime FechaProduccion = DateTime.Parse(CadFechaProduccion.ToString());

                    DataTable dt = objProduccionBL.MovimientoPaciente_VerificarIpress(cboPeriodo.Text, Mes);

                    if (dt.Rows.Count < 1)
                    {
                        MessageBox.Show("¡No Existen Ipress en Periodo, Produccion Denegada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int ProduccionId = int.Parse(objProduccionBL.Produccion_Nuevo().Rows[0][0].ToString());
                        objProduccion.ProduccionId = ProduccionId;
                        
                        if (Mes.Length > 1)
                        {
                            objProduccion.Codigo = cboPeriodo.Text + Mes;
                        }
                        else
                        {
                            objProduccion.Codigo = cboPeriodo.Text + "0" + Mes;
                        }
                        
                        objProduccion.FechaProduccion = FechaProduccion;
                        objProduccion.FechaInicio = DateTime.Parse(DateTime.Today.ToShortDateString());
                        objProduccionBL.Produccion_Insert(objProduccion);
                        objProduccionBL.MovimientoPaciente_UpdateProduccionId(ProduccionId, cboPeriodo.Text, Mes);

                        for (int n = 0; n < dt.Rows.Count; n++)
                        {
                            int ProduccionEstablecimientoId = int.Parse(objProduccionEstablecimientoBL.ProduccionEstablecimiento_Nuevo().Rows[0][0].ToString());
                            objProduccionEstablecimiento.ProduccionEstablecimientoId = ProduccionEstablecimientoId;
                            objProduccionEstablecimiento.ProduccionId = ProduccionId;
                            objProduccionEstablecimiento.EstablecimientoId = int.Parse(dt.Rows[n][0].ToString());
                            objProduccionEstablecimientoBL.ProduccionEstablecimiento_Insert(objProduccionEstablecimiento);
                            objProduccionEstablecimientoBL.ProduccionEstablecimiento_UpdateAtencionesProduccion(objProduccionEstablecimiento);
                        }

                        MessageBox.Show("Produccion " + ProduccionId + " Iniciado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VariablesGlobales.NroX = 1;
                        this.Close();
                    }
                }
            }                                    
        }       
        

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMes.Text == "Enero" || cboMes.Text == "January")
            {
                Mes = "1";
            }
            else
            {
                if (cboMes.Text == "Febrero" || cboMes.Text == "February")
                {
                    Mes = "2";
                }
                else
                {
                    if (cboMes.Text == "Marzo" || cboMes.Text == "March")
                    {
                        Mes = "3";
                    }
                    else
                    {
                        if (cboMes.Text == "Abril" || cboMes.Text == "April")
                        {
                            Mes = "4";
                        }
                        else
                        {
                            if (cboMes.Text == "Mayo" || cboMes.Text == "May")
                            {
                                Mes = "5";
                            }
                            else
                            {
                                if (cboMes.Text == "Junio" || cboMes.Text == "June")
                                {
                                    Mes = "6";
                                }
                                else
                                {
                                    if (cboMes.Text == "Julio" || cboMes.Text == "July")
                                    {
                                        Mes = "7";
                                    }
                                    else
                                    {
                                        if (cboMes.Text == "Agosto" || cboMes.Text == "August")
                                        {
                                            Mes = "8";
                                        }
                                        else
                                        {
                                            if (cboMes.Text == "Septiembre" || cboMes.Text == "September")
                                            {
                                                Mes = "9";
                                            }
                                            else
                                            {
                                                if (cboMes.Text == "Octubre" || cboMes.Text == "October")
                                                {
                                                    Mes = "10";
                                                }
                                                else
                                                {
                                                    if (cboMes.Text == "Noviembre" || cboMes.Text == "November")
                                                    {
                                                        Mes = "11";
                                                    }
                                                    else
                                                    {
                                                        if (cboMes.Text == "Diciembre" || cboMes.Text == "December")
                                                        {
                                                            Mes = "12";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string CadFechaProduccion = cboPeriodo.Text + "-" + Mes + "-01";
            DateTime FechaProduccion = DateTime.Parse(CadFechaProduccion.ToString());

            if (objProduccionBL.MovimientoPaciente_VerificarIpress(cboPeriodo.Text, Mes).Rows.Count < 1)
            {
                dgvProduccion.DataSource = null;
                MessageBox.Show("¡No Existen Ipress en Periodo, Produccion Denegada!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvProduccion.DataSource = objProduccionBL.MovimientoPaciente_VerificarIpress(cboPeriodo.Text, Mes);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProduccion.DataSource = null;
            DataTable dt2 = objProduccionBL.MovimientoPaciente_ListarPeriodoMes(int.Parse(cboPeriodo.Text));
            cboMes.Items.Clear();
            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                cboMes.Items.Add(dt2.Rows[j][0].ToString());
            }
        }
    }
}
