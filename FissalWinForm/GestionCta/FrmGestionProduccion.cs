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
    public partial class FrmGestionProduccion : Form
    {
        public FrmGestionProduccion()
        {
            InitializeComponent();
            tsPgsBarBuscador.Visible = false;
        }

        Produccion objProduccion = new Produccion();
        ProduccionBL objProduccionBL = new ProduccionBL();

        public void FormGestionCierreProduccion_Load(object sender, EventArgs e)
        {
            CargarData();          
        }

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCierreProduccion frm = new FrmRegistrarCierreProduccion();
            frm.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                CargarData();
            }            
        }

        public void CargarData()
        {
            if (txtCodigo.Text == "" && chkCerrada.Checked == false && txtFechaInicio.Text == "" && txtFechaFin.Text == "")
            {
                dgvCierreProduccion.DataSource = objProduccionBL.Produccion_Listar(txtCodigo.Text, chkCerrada.Checked, txtFechaInicio.Text, txtFechaFin.Text, 1);
            }
            else
            {
                if (txtCodigo.Text != "" && chkCerrada.Checked == false && txtFechaInicio.Text == "" && txtFechaFin.Text == "")
                {
                    dgvCierreProduccion.DataSource = objProduccionBL.Produccion_Listar(txtCodigo.Text, chkCerrada.Checked, txtFechaInicio.Text, txtFechaFin.Text, 2);
                }
                else
                {
                    if (txtCodigo.Text == "" && chkCerrada.Checked == true && txtFechaInicio.Text == "" && txtFechaFin.Text == "")
                    {
                        dgvCierreProduccion.DataSource = objProduccionBL.Produccion_Listar(txtCodigo.Text, chkCerrada.Checked, txtFechaInicio.Text, txtFechaFin.Text, 3);
                    }
                    else
                    {
                        if (txtCodigo.Text != "" && chkCerrada.Checked == true && txtFechaInicio.Text == "" && txtFechaFin.Text == "")
                        {
                            dgvCierreProduccion.DataSource = objProduccionBL.Produccion_Listar(txtCodigo.Text, chkCerrada.Checked, txtFechaInicio.Text, txtFechaFin.Text, 4);
                        }                        
                    }
                }
            }
            
        }        

        private void EnviarData()
        {
            VariablesGlobales.NroX = 1;
            VariablesGlobales.ProduccionIdX = int.Parse(dgvCierreProduccion.CurrentRow.Cells[0].Value.ToString());
            VariablesGlobales.CodigoProd = dgvCierreProduccion.CurrentRow.Cells[1].Value.ToString();
            VariablesGlobales.PeriodoProd = dgvCierreProduccion.CurrentRow.Cells[2].Value.ToString();
            VariablesGlobales.MesProd = dgvCierreProduccion.CurrentRow.Cells[3].Value.ToString();
            VariablesGlobales.FecIncioProd = dgvCierreProduccion.CurrentRow.Cells[4].Value.ToString();
            VariablesGlobales.FecCierreProd = dgvCierreProduccion.CurrentRow.Cells[5].Value.ToString(); 
            FrmCerrarProduccion frm = new FrmCerrarProduccion();
            frm.ShowDialog();            
            if (VariablesGlobales.NroX == 1)
            {
                CargarData();
            }
        }

        private void dgvCierreProduccion_DoubleClick(object sender, EventArgs e)
        {
            EnviarData();
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            CargarData();
        }

        private void dgvCierreProduccion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvCierreProduccion, tsslTotalRegistros);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            txtFechaInicio.Text = dtpFechaInicio.Value.ToShortDateString();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            txtFechaFin.Text = dtpFechaFin.Value.ToShortDateString();
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarTextBox(this);
            FuncionesBases.LimpiarCheckBox(this);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CargarData();
                    break;
            }
        }

    }
}
