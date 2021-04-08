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
    public partial class FrmResumenConciliacion : Form
    {
        public FrmResumenConciliacion()
        {
            InitializeComponent();
        }

        SaldoCuentaConciliacion objSaldoCuentaConciliacion = new SaldoCuentaConciliacion();
        SaldoCuentaConciliacionBL objSaldoCuentaConciliacionBL = new SaldoCuentaConciliacionBL();

        DataTable dt, dt2;

        private void FrmResumenConciliacion_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpIpress;
            tabControl.SelectedTab = tbpPaciente;
            tabControl.SelectTab(0);
            FuncionesBases.CargarCboEstablecimiento_Listar(cboEstablecimiento);
            FuncionesBases.CargarComboTipoDoc(cboTipoDoc);
            cboEstablecimiento_SelectedIndexChanged(sender, e);
            CargarDataPaciente();
        }

        void CargarData()
        {
            if (cboEstablecimiento.SelectedIndex == 0)
            {
                dt = objSaldoCuentaConciliacionBL.SaldoCuentaConciliacion_Listar(VariablesGlobales.CodigoConciliacionX, 0, 1);
            }
            else
            {
                dt = objSaldoCuentaConciliacionBL.SaldoCuentaConciliacion_Listar(VariablesGlobales.CodigoConciliacionX, int.Parse(cboEstablecimiento.SelectedValue.ToString()), 2);                
            }

            dgvResumenConciliacion.DataSource = dt;
            dgvResumenConciliacion_CellFormatting();
        }

        void CargarDataPaciente()
        {
            int? tipoDocumentoId;
            if (cboTipoDoc.SelectedIndex == 0)
                tipoDocumentoId = null;
            else
                tipoDocumentoId = int.Parse(cboTipoDoc.SelectedValue.ToString());


            dt2 = objSaldoCuentaConciliacionBL.SaldoCuentaConciliacion_ListarxPaciente(VariablesGlobales.CodigoConciliacionX, tipoDocumentoId, txtDNI.Text, txtPaciente.Text);

            if (dt2.Rows.Count > 0)
            {
                dgvResumenConciliacionPaciente.DataSource = dt2;
                dgvResumenConciliacionPaciente_CellFormatting();
            }
            else
            {
                dgvResumenConciliacionPaciente.DataSource = null; 
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
                if (dgvResumenConciliacion.RowCount > 0)
                {
                    FuncionesBases.DataTableToXls(dt, progressBar);                    
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
                    if (dgvResumenConciliacionPaciente.RowCount > 0)
                    {                        
                        FuncionesBases.DataTableToXls(dt2, progressBar);
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

        void dgvResumenConciliacion_CellFormatting()
        {
            dgvResumenConciliacion.Columns["Ipress"].Width = 100;
            dgvResumenConciliacion.Columns["SaldoInicial"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["ReasignacionPositiva"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["ReasignacionNegativa"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["MontoPendienteReasignacion"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["SaldoFinal"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["SaldoInicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["ReasignacionPositiva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["ReasignacionNegativa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["MontoPendienteReasignacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["SaldoFinal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        void dgvResumenConciliacionPaciente_CellFormatting()
        {
            dgvResumenConciliacionPaciente.Columns["Ipress"].Width = 100;
            dgvResumenConciliacionPaciente.Columns["SaldoInicial"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["ReasignacionPositiva"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["ReasignacionNegativa"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacion.Columns["MontoPendienteReasignacion"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacionPaciente.Columns["SaldoFinal"].DefaultCellStyle.Format = "###,##0.000";
            dgvResumenConciliacionPaciente.Columns["SaldoInicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["ReasignacionPositiva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["ReasignacionNegativa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacion.Columns["MontoPendienteReasignacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenConciliacionPaciente.Columns["SaldoFinal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            if (tabControl.Controls[0] == tabControl.SelectedTab)
            {
                CargarData();
            }
            else
            {
                if (tabControl.Controls[1] == tabControl.SelectedTab)
                {
                    CargarDataPaciente();
                }
            }                
        }        
    }
}
