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
    public partial class FrmProfesional : Form
    {
        public FrmProfesional()
        {
            InitializeComponent();
        }


        Medico objMedico = new Medico();
        MedicoBL objMedicoBL = new MedicoBL();
        private void FrmProfesional_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarComboMedico_EspecialidadListar(cboEspecialidad);
            EstadoBotones(true);
            LimpiarControles();
            tsBtnActualizar.Enabled = false;
            tsBtnEliminar.Enabled = false;
        }

        public bool ValidarDatosMedico()
        {
            bool error;
            error = false;

            if (txtDNI.Text.Length == 0 || txtDNI.TextLength < 8)
            {
                MessageBox.Show("¡Ingrese correctamente el Numero DNI!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                txtDNI.SelectAll();
                error = true;
            }
            else
            {
                if (txtNombre.Text.Length == 0)
                {
                    MessageBox.Show("¡Debe Ingresar Nombre!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    txtNombre.SelectAll();
                    error = true;
                }
                else
                {
                    if (txtCMP.Text.Length == 0)
                    {
                        MessageBox.Show("¡Debe Ingresar CMP!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCMP.Focus();
                        txtCMP.SelectAll();
                        error = true;
                    }
                    else
                    {

                        if (cboEspecialidad.Text == "-Seleccione-")
                        {
                            MessageBox.Show("¡Seleccionar Especialidad!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboEspecialidad.Focus();
                            cboEspecialidad.SelectAll();
                            error = true;
                        }
                    }
                }
            }

            return error;
        }

        private void LimpiarControles()
        {            
            this.txtDNI.Clear();
            this.txtNombre.Clear();
            this.txtCMP.Clear();
            cboEspecialidad.Text = "-Seleccione-";
            txtDNI.Focus();
        }

        private void EstadoBotones(Boolean valor)
        {
            this.tsBtnGrabar.Enabled = valor;
            this.tsBtnActualizar.Enabled = valor;
            this.tsBtnEliminar.Enabled = valor;
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!((tecla >= 48 && tecla <= 57) || (tecla == 8)))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtCMP.Focus();
            }
        }

        private void txtCMP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                cboEspecialidad.Focus();
            }
        }

        private void cboEspecialidad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProfesional objFrmBP = new FrmBuscarProfesional();
            objFrmBP.ShowDialog();
            if (VariablesGlobales.NroX == 1)
            {
                EstadoBotones(false);
                txtDNI.Text = VariablesGlobales.DniDoctorX;
                txtNombre.Text = VariablesGlobales.NombreDoctorX;
                txtCMP.Text = VariablesGlobales.CmpX;
                cboEspecialidad.Text = VariablesGlobales.EspecialidadX;
                tsBtnActualizar.Enabled = true;
                tsBtnEliminar.Enabled = true;
            }
            else
            {
                LimpiarControles();
                EstadoBotones(true);
            }
        }

        private void tsBtnCancelar_Click(object sender, EventArgs e)
        {
            EstadoBotones(true);
            LimpiarControles();
            tsBtnActualizar.Enabled = false;
            tsBtnEliminar.Enabled = false;
        }

        private void tsBtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosMedico() == true) return;
            objMedico.DniDoctor = txtDNI.Text.Trim();
            objMedicoBL.Medico_Delete(objMedico);
            LimpiarControles();
            EstadoBotones(true);
            MessageBox.Show("Profesional Eliminado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosMedico() == true) return;
            objMedico.DniDoctor = txtDNI.Text.Trim();
            objMedico.NombreDoctor = txtNombre.Text;
            objMedico.Cmp = txtCMP.Text.Trim();
            objMedico.Especialidad = cboEspecialidad.Text;
            objMedicoBL.Medico_Update(objMedico);
            LimpiarControles();
            EstadoBotones(true);
            MessageBox.Show("Profesional Editado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (ValidarDatosMedico() == true) return;
            objMedico.DniDoctor = txtDNI.Text.Trim();
            objMedico.NombreDoctor = txtNombre.Text;
            objMedico.Cmp = txtCMP.Text.Trim();
            objMedico.Especialidad = cboEspecialidad.Text;
            objMedicoBL.Medico_Insert(objMedico);
            LimpiarControles();
            EstadoBotones(true);
            MessageBox.Show("Profesional Registrado", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

    }
}
