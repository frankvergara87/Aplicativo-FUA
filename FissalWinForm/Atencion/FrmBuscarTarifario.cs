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
    public partial class FrmBuscarTarifario : Form
    {
        public FrmBuscarTarifario()
        {
            InitializeComponent();
        }

        Tarifario objTarifario = new Tarifario();
        TarifarioBL objTarifarioBL = new TarifarioBL();

        DataTable dt, dt2, dt3;

        private void FrmBuscarTarifario_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpProcedimiento;
            tabControl.SelectedTab = tbpMedicamento;
            FuncionesBases.CargarCboEstablecimiento_Listar(cboEstablecimiento);
        }

        void VerDataMedicamento()
        {
            dt2 = objTarifarioBL.TarifarioMedicamento_ListarxEstablecimientoId(int.Parse(cboEstablecimiento.SelectedValue.ToString()), int.Parse(dgvVersion.CurrentRow.Cells[0].Value.ToString()), txtDescripcion.Text);
            if (dt2.Rows.Count > 0)
            {
                dgvMedicamento.DataSource = dt2;
                dgvMedicamento_CellFormatting();
                lblMensaje.Text = "Resultado : " + dt2.Rows.Count + " Registros";
            }
            else
            {
                dgvMedicamento.DataSource = null;                
                lblMensaje.Text = "";                
            }
        }

        void VerDataProcedimiento()
        {
            dt3 = objTarifarioBL.TarifarioProcedimiento_ListarxEstablecimientoId(int.Parse(cboEstablecimiento.SelectedValue.ToString()), int.Parse(dgvVersion.CurrentRow.Cells[0].Value.ToString()), txtDescripcion.Text);
            if (dt3.Rows.Count > 0)
            {
                dgvProcedimiento.DataSource = dt3;
                dgvProcedimiento_CellFormatting();
                lblMensaje02.Text = "Resultado : " + dt3.Rows.Count + " Registros";
            }
            else
            {                
                dgvProcedimiento.DataSource = null;                
                lblMensaje02.Text = "";
            }
        }            

        private void cboEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEstablecimiento.SelectedIndex != 0)
                {                    
                    dt = objTarifarioBL.Tarifario_ListarxEstablecimientoId(int.Parse(cboEstablecimiento.SelectedValue.ToString()));
                    dgvVersion.DataSource = dt;
                    dgvMedicamento.DataSource = null;
                    dgvProcedimiento.DataSource = null;
                    lblMensaje.Text = "";
                    lblMensaje02.Text = "";
                }
                else
                {
                    dgvVersion.DataSource = null;
                    dgvMedicamento.DataSource = null;
                    dgvProcedimiento.DataSource = null;
                    lblMensaje.Text = "";
                    lblMensaje02.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvMedicamento.Rows.Count > 0)
            {
                FuncionesBases.DataTableToXls(dt2, progressBar);
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Exportando Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  

            if (dgvProcedimiento.Rows.Count > 0)
            {
                FuncionesBases.DataTableToXls(dt3, progressBar);
            }
            else
            {
                MessageBox.Show("¡No hay Data a Exportar!", "Exportando Procedimientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void dgvMedicamento_CellFormatting()
        {
            dgvMedicamento.Columns["MedicamentoId"].Width = 100;
            dgvMedicamento.Columns["DigemidId"].Width = 50;
            dgvMedicamento.Columns["Monto"].Width = 100;            
            dgvMedicamento.Columns["Monto"].DefaultCellStyle.Format = "###,##0.000";
            dgvMedicamento.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            
        }

        void dgvProcedimiento_CellFormatting()
        {
            dgvProcedimiento.Columns["ProcedimientoId"].Width = 100;
            dgvProcedimiento.Columns["SisId"].Width = 50;
            dgvProcedimiento.Columns["Monto"].Width = 100;         
            dgvProcedimiento.Columns["Monto"].DefaultCellStyle.Format = "###,##0.000";
            dgvProcedimiento.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            if (tabControl.Controls[0] == tabControl.SelectedTab)
            {
                VerDataMedicamento();
            }
            else
            {
                if (tabControl.Controls[1] == tabControl.SelectedTab)
                {
                    VerDataProcedimiento();
                }
            }
        }

        private void tsBtnExportar_Click(object sender, EventArgs e)
        {
            if (tabControl.Controls[0] == tabControl.SelectedTab)
            {
                if (dgvMedicamento.RowCount > 0)
                {
                    FuncionesBases.DataTableToXls(dt2, progressBar);
                }
                else
                {
                    MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tabControl.Controls[1] == tabControl.SelectedTab)
                {
                    if (dgvProcedimiento.RowCount > 0)
                    {
                        FuncionesBases.DataTableToXls(dt3, progressBar);
                    }
                    else
                    {
                        MessageBox.Show("¡No hay Data a Exportar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }               
    }
}
