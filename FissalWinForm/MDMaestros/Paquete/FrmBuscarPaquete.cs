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
    public partial class FrmBuscarPaquete : Form
    {
        public FrmBuscarPaquete()
        {
            InitializeComponent();
        }

        PaqueteBL objPaqueteBL = new PaqueteBL();

        private void FrmBuscarPaquete_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboEstablecimiento_Listar(cboEstablecimiento);
            cboEstablecimiento_SelectedIndexChanged(sender, e);
        }

        private void cboEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEstablecimiento.SelectedIndex != 0)
                {
                    dgvPaquete.DataSource = objPaqueteBL.Paquete_ListarxEstablecimientoId(int.Parse(cboEstablecimiento.SelectedValue.ToString()));
                    dgvPaquete_CellFormatting();
                }
                else
                {
                    dgvPaquete.DataSource = null;                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void dgvPaquete_CellFormatting()
        {
            dgvPaquete.Columns["Id"].Width = 50;
            dgvPaquete.Columns["CatId"].Width = 50;
            //dgvPaquete.Columns["Descripcion"].Width = 100;            
            dgvPaquete.Columns["EstadioId"].Width = 50;
            dgvPaquete.Columns["Estadio"].Width = 80;            
            dgvPaquete.Columns["FaseId"].Width = 50;
            dgvPaquete.Columns["Fase"].Width = 120;
            dgvPaquete.Columns["Autorizacion"].Width = 80;
            dgvPaquete.Columns["U.Version"].Width = 80;            
        }

        private void tsBtnVerDetalle_Click(object sender, EventArgs e)
        {
            VariablesGlobales.TratamientoIdX = int.Parse(dgvPaquete.CurrentRow.Cells[0].Value.ToString());
            VariablesGlobales.EstablecimientoDescripcion = dgvPaquete.CurrentRow.Cells[2].Value.ToString();
            VariablesGlobales.CategoriaIdX = dgvPaquete.CurrentRow.Cells[1].Value.ToString();
            VariablesGlobales.FaseX = dgvPaquete.CurrentRow.Cells[6].Value.ToString();
            VariablesGlobales.EstadioX = dgvPaquete.CurrentRow.Cells[4].Value.ToString();
            VariablesGlobales.AutorizacionX = dgvPaquete.CurrentRow.Cells[7].Value.ToString();
            VariablesGlobales.NroX = 1;            
            FrmPaqueteDetalle objFrmPD = new FrmPaqueteDetalle();
            objFrmPD.ShowDialog();            
        }

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            VariablesGlobales.NroX = 1;
            FrmRegistrarPaquete objFrmRP = new FrmRegistrarPaquete();
            objFrmRP.ShowDialog();

            //FrmRegistrarConciliacion frm = new FrmRegistrarConciliacion();
            //frm.ShowDialog();
            //if (VariablesGlobales.NroX == 1)
            //{
            //    cboEstablecimiento_SelectedIndexChanged(sender, e);
            //}
        }

        private void tsBtnEditar_Click(object sender, EventArgs e)
        {
            VariablesGlobales.NroX = 2;
            VariablesGlobales.TratamientoIdX = int.Parse(dgvPaquete.CurrentRow.Cells[0].Value.ToString());
            FrmRegistrarPaquete objFrmRP = new FrmRegistrarPaquete();
            objFrmRP.ShowDialog();
        }
    }
}
