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
    public partial class FrmValorizacionPreliminar : Form
    {
        public FrmValorizacionPreliminar()
        {
            InitializeComponent();
        }

        MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
        DataTable dt;

        private void FrmValorizacionPreliminar_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpIpress;            
            tabControl.SelectTab(0);
            FuncionesBases.CargarCboEstablecimiento_Listar(cboEstablecimiento);            
            cboEstablecimiento_SelectedIndexChanged(sender, e);            
        }

        void CargarData()
        {
            int? EstablecimientoId;
            if (cboEstablecimiento.SelectedIndex == 0)
                EstablecimientoId = null;
            else
                EstablecimientoId = int.Parse(cboEstablecimiento.SelectedValue.ToString());

            dt = objMovimientoPacienteBL.MovimientoPaciente_ValorizacionPreliminar(EstablecimientoId);

            if (dt.Rows.Count > 0)
            {
                dgvValorizacion.DataSource = dt;
                dgvValorizacion_CellFormatting();
            }
            else
            {
                dgvValorizacion.DataSource = null;
            }
        }

        private void cboEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tsBtnExportar_Click(object sender, EventArgs e)
        {
            if (tabControl.Controls[0] == tabControl.SelectedTab)
            {
                if (dgvValorizacion.RowCount > 0)
                {
                    FuncionesBases.DataTableToXls(dt, progressBar);
                }
                else
                {
                    MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        void dgvValorizacion_CellFormatting()
        {
            dgvValorizacion.Columns["Ipress"].Width = 100;
            dgvValorizacion.Columns["CadenaId"].Width = 100;
            dgvValorizacion.Columns["Descripcion"].Width = 300;
            dgvValorizacion.Columns["ValorizacionReal"].Width = 150;
            dgvValorizacion.Columns["ValorizacionPreliminar"].Width = 150;
            dgvValorizacion.Columns["ValorizacionTotal"].Width = 150;
            dgvValorizacion.Columns["ValorizacionReal"].DefaultCellStyle.Format = "###,##0.000";
            dgvValorizacion.Columns["ValorizacionPreliminar"].DefaultCellStyle.Format = "###,##0.000";
            dgvValorizacion.Columns["ValorizacionTotal"].DefaultCellStyle.Format = "###,##0.000";
            dgvValorizacion.Columns["ValorizacionReal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvValorizacion.Columns["ValorizacionPreliminar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvValorizacion.Columns["ValorizacionTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            
        }

        private void tsBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
