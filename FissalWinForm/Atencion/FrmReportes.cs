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
    public partial class FrmReportes : Form
    {
        MovimientoPacienteBL ObjMovimientoPaciente = new MovimientoPacienteBL();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            ListarCierresDig(Convert.ToInt32(cboEstablecimiento.SelectedValue.ToString()));
        }

        void ListarCierresDig(int EstablecimientoId) 
        {
            dgvListadoCierresDig.DataSource = ObjMovimientoPaciente.MovimientoPaciente_ListarCierresDig(EstablecimientoId);
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboEstablecimientoCierreDig(cboEstablecimiento);
        }
    }
}
