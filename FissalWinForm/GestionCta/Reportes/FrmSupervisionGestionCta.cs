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
    public partial class FrmSupervisionGestionCta : Form
    {
        public FrmSupervisionGestionCta()
        {
            InitializeComponent();            
        }

        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();
        DataTable dt;

        private void FrmSupervisionGestionCta_Load(object sender, EventArgs e)
        {
            dgvProduccionEstablecimiento.DataSource = objProduccionEstablecimientoBL.SupervisionGestionCta();
            dgvProduccionEstablecimiento_CurrentCellChanged(sender, e);
            //dgvEstablecimientoDetalle_CurrentCellChanged(sender, e);
        }

        private void dgvProduccionEstablecimiento_CurrentCellChanged(object sender, EventArgs e)
        {
            ProduccionesxIpress();            
        }        

        void ProduccionesxIpress()
        {
            int EstablecimientoId, CodigoControlMedico;
            EstablecimientoId = int.Parse(dgvProduccionEstablecimiento.CurrentRow.Cells[0].Value.ToString());
            CodigoControlMedico = int.Parse(dgvProduccionEstablecimiento.CurrentRow.Cells[4].Value.ToString());
            dt = objProduccionEstablecimientoBL.SupervisionGestionCta_Detalle(CodigoControlMedico, EstablecimientoId);
            if (dt.Rows.Count > 0)
            {
                dgvEstablecimientoDetalle.DataSource = dt;                
                FuasxIpress();
            }            
        }

        void FuasxIpress()
        {
            if (dgvEstablecimientoDetalle.RowCount != 0)
            {
                int EstablecimientoId;
                DateTime ProduccionFissal;
                ProduccionFissal = DateTime.Parse(dgvEstablecimientoDetalle.CurrentRow.Cells[2].Value.ToString());
                EstablecimientoId = int.Parse(dgvEstablecimientoDetalle.CurrentRow.Cells[0].Value.ToString());
                dt = objProduccionEstablecimientoBL.SupervisionGestionCta_DetalleFuas(ProduccionFissal, EstablecimientoId);
                if (dt.Rows.Count > 0)
                {
                    dgvEstablecimientoDetalleFuas.DataSource = dt;                    
                }  
            }                      
        }

        private void dgvProduccionEstablecimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            ProduccionesxIpress();            
        }

        private void dgvEstablecimientoDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            FuasxIpress();            
        }

        private void dgvEstablecimientoDetalle_CurrentCellChanged(object sender, EventArgs e)
        {
            //FuasxIpress(); 
        }              
    }
}
