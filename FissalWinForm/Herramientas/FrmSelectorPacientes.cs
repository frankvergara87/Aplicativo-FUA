using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FissalBL;
using FissalBE;

namespace FissalWinForm
{
    public partial class FrmSelectorPacientes : Form
    {
        PacienteBL objPacienteBL = new PacienteBL();
        DataTable dtPacientes;

        public FrmSelectorPacientes()
        {
            InitializeComponent();
            this.CenterToParent();
            this.KeyPreview = true;
            toolStrip1.TabStop = true;
            dgvPacientes.AutoGenerateColumns = false;
        }

        private void FrmSelectorPacientes_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarComboTipoDoc(cboTipoDocumento);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void Buscar()
        {
            Paciente objPaciente = new Paciente();
            if (!int.Equals(cboTipoDocumento.SelectedIndex, 0))
                objPaciente.TipoDocumentoId = Convert.ToByte(cboTipoDocumento.SelectedValue);
            objPaciente.NumeroDocumento = txtNumeroDocumento.Text.Trim();
            objPaciente.ApellidoPaterno = txtApellidoPaterno.Text.Trim();
            objPaciente.ApellidoMaterno = txtApellidoMaterno.Text.Trim();
            objPaciente.Nombres = txtNombres.Text.Trim();
            dtPacientes = objPacienteBL.GetPacientesBuscadorSelectorPacientes(objPaciente);
            dgvPacientes.DataSource = dtPacientes;
            if (dtPacientes.Rows.Count > 0)
                dgvPacientes.Visible = true;
            else
                dgvPacientes.Visible = false;
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            FuncionesBases.LimpiarControles(this);
            if (dtPacientes != null)
            {
                dtPacientes.Clear();
                dgvPacientes.DataSource = dtPacientes;
            }
            cboTipoDocumento.Focus();
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloLetras(e);
        }

        private void cboTipoDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtApellidoMaterno_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            Aceptar();
        }

        private void Aceptar()
        {
            if (!(dgvPacientes.RowCount > 0))
                return;
            string pacienteId = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            IFrmSelectorPacientes iFrmSelectorPacientes = this.Owner as IFrmSelectorPacientes;
            if (iFrmSelectorPacientes != null)
            {
                iFrmSelectorPacientes.ObtenerPacienteId(pacienteId);
                this.DialogResult = DialogResult.OK;
            }
            Salir();
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        private void dgvPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
            }
        }

        private void dgvPacientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvPacientes, tsslTotalRegistros);
        }

        private void FrmSelectorPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

    }
}
