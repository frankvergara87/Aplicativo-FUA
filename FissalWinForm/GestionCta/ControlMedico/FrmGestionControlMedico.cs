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
    public partial class FrmGestionControlMedico : Form
    {
        public FrmGestionControlMedico()
        {
            InitializeComponent();
        }

        Produccion objProduccion = new Produccion();
        ProduccionBL objProduccionBL = new ProduccionBL();
        ProduccionEstablecimiento objProduccionEstablecimiento = new ProduccionEstablecimiento();
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();

        DataTable dt;

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarControlMedico frm = new FrmRegistrarControlMedico();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarData();
            }            
        }        

        private void FrmGestionControlMedico_Load(object sender, EventArgs e)
        {
            CargarData();
        }

        private void dgvControlMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            objProduccionEstablecimiento.CodigoControlMedico = int.Parse(dgvControlMedico.CurrentRow.Cells[0].Value.ToString());
            dt = objProduccionEstablecimientoBL.ProduccionEstablecimiento_CtrlMedDetalle(objProduccionEstablecimiento);
            dgvControlMedicoDetalle.DataSource = dt;
        }                

        private void tsBtnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvControlMedicoDetalle.RowCount > 0) 
            {
                if (MessageBox.Show("¿Ejecutar Proceso de Control Medico Nro " + dgvControlMedico.CurrentRow.Cells[0].Value.ToString() + "?", "Fissal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        objProduccionEstablecimiento.ProduccionEstablecimientoId = int.Parse(dt.Rows[i]["ProduccionEstablecimientoId"].ToString());
                        objProduccionEstablecimiento.UsuarioCierraControlMedico = VariablesGlobales.Login;
                        objProduccionEstablecimiento.AtencionesSupervisadas = int.Parse(dt.Rows[i]["AtencionesSupervisadas"].ToString());
                        objProduccionEstablecimientoBL.ProduccionEstablecimientoCtrlMed_Cierre(objProduccionEstablecimiento);
                    }

                    //Obteniendo Montos Netos (Fua)
                    objProduccionEstablecimiento.CodigoControlMedico = int.Parse(dgvControlMedico.CurrentRow.Cells[0].Value.ToString());
                    objProduccionEstablecimientoBL.MovimientoPaciente_Proceso_TotalesValorizadosNetos(objProduccionEstablecimiento);

                    CargarData();
                    MessageBox.Show("¡Control Medico Cerrado!", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay controles medicos en ejecucion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void CargarData()
        {
            dgvControlMedico.DataSource = objProduccionEstablecimientoBL.ProduccionEstablecimiento_CodigoCtrlMedListar();
            if (dgvControlMedico.RowCount > 0)
            {
                objProduccionEstablecimiento.CodigoControlMedico = int.Parse(dgvControlMedico.CurrentRow.Cells[0].Value.ToString());
                dt = objProduccionEstablecimientoBL.ProduccionEstablecimiento_CtrlMedDetalle(objProduccionEstablecimiento);
                dgvControlMedicoDetalle.DataSource = dt;
            }
            else
            {
                dgvControlMedicoDetalle.DataSource = null; 
            }
        }
    }
}
