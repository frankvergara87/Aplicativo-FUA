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
    public partial class FrmUsuarios : Form
    {
        UsuarioBL ObjUsuarioBL = new UsuarioBL();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarComboPerfFullXEstab(cboPerfil, VariablesGlobales.EstablecimientoId);
            
            if (VariablesGlobales.EstablecimientoId == 0)
            {
                cboEstablecimiento.Visible = true;
                cboEstablecimiento.Enabled = true;
                lblEstablecimiento.Visible = false;
            }
            else 
            {
                cboEstablecimiento.Visible=false;
                lblIdUsuario.Visible = true;
                lblEstablecimiento.Text = VariablesGlobales.EstablecimientoId + " - " + VariablesGlobales.EstablecimientoDescripcion;
            }

            FuncionesBases.CargarCboEstablecimientoUsuario(cboEstablecimiento);

            CargaGrillaUsuarios(txtBusqUsuario.Text.Trim(), VariablesGlobales.EstablecimientoId);
        }

        #region Botones

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboPerfil.SelectedValue) != 0)
            {
                GuardarUsuario();
                MessageBox.Show("Se Registraron los datos correctamente..");

                CargaGrillaUsuarios(txtBusqUsuario.Text.Trim(), VariablesGlobales.EstablecimientoId);
                LimpiaDatos();
                btnGuardar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Perfil..");
                cboPerfil.Focus();
            }
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiaDatos();
            lblIdUsuario.Text = "*";
            btnGuardar.Enabled = true;
        }


        #endregion

        #region Evento Grilla

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[1].Value);
            txtUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[2].Value);
            txtContraseña.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[5].Value);
            txtNombUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[3].Value);
            cboPerfil.SelectedValue = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[6].Value);
            cboEstablecimiento.SelectedValue = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[7].Value);


            btnGuardar.Enabled = true;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                if (MessageBox.Show("Esta seguro de Eliminar el Usuario: " 
                                     + Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[1].Value)
                                     + " - " + Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[2].Value) 
                                     + " ?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminarUsuario(Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[1].Value));
                    MessageBox.Show("Se Elimino el Usuario correctamente..");
                    CargaGrillaUsuarios(txtBusqUsuario.Text.Trim(),VariablesGlobales.EstablecimientoId);
                }
            }
        }

        #endregion

        #region Evento TextBox

        private void txtBusqUsuario_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ObjUsuarioBL.Listar_Usuarios(txtBusqUsuario.Text.Trim(),VariablesGlobales.EstablecimientoId);
            dgvUsuarios.DataSource = dt;
        }

        private void txtBusqUsuario_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            LimpiaDatos();
        }
        
        #endregion

        #region Metodos 

        private void CargaGrillaUsuarios(string Usuario, int EstablecimientoId)
        {
            DataTable dt = ObjUsuarioBL.Listar_Usuarios(Usuario, EstablecimientoId);
            dgvUsuarios.DataSource = dt;
        }

        private void GuardarUsuario()
        {
            int Result = 0;

            if (lblIdUsuario.Text.Trim() != "*")
            {
                vw_Usuario Usuario = new vw_Usuario();
                Usuario.id_usuario = Convert.ToInt32(lblIdUsuario.Text.Trim());
                Usuario.login = txtUsuario.Text.Trim();
                Usuario.nombre_completo = txtNombUsuario.Text.Trim();
                Usuario.password = txtContraseña.Text.Trim();
                Usuario.id_perfil = Convert.ToInt32(cboPerfil.SelectedValue.ToString());

                if (VariablesGlobales.EstablecimientoId == 0) 
                { 
                    Usuario.EstablecimientoId = Convert.ToInt32(cboEstablecimiento.SelectedValue);
                }
                else { Usuario.EstablecimientoId = VariablesGlobales.EstablecimientoId; }


                Result = ObjUsuarioBL.Actualizar_Usuarios(Usuario);
            }
            else 
            {
                vw_Usuario Usuario = new vw_Usuario();
                //Usuario.id_usuario = Convert.ToInt32(lblIdUsuario.Text.Trim());
                Usuario.login = txtUsuario.Text.Trim();
                Usuario.nombre_completo = txtNombUsuario.Text.Trim();
                Usuario.password = txtContraseña.Text.Trim();
                Usuario.id_perfil = Convert.ToInt32(cboPerfil.SelectedValue.ToString());

                if (VariablesGlobales.EstablecimientoId == 0)
                {
                    Usuario.EstablecimientoId = Convert.ToInt32(cboEstablecimiento.SelectedValue);
                }
                else { Usuario.EstablecimientoId = VariablesGlobales.EstablecimientoId; }

                Result = ObjUsuarioBL.Registrar_Usuarios(Usuario);
            }
        }

        private void EliminarUsuario(int Id_Usuario)
        {
            ObjUsuarioBL.Eliminar_Usuarios(Id_Usuario);

            LimpiaDatos();
        }

        void LimpiaDatos() 
        {

            // Recorro TextBOx - LaBels - ComboBOx [GroUpBOx 2]

            lblIdUsuario.Text = "*";

            #region TextBoX
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
            #endregion

            FuncionesBases.CargarComboPerfFullXEstab(cboPerfil, VariablesGlobales.EstablecimientoId);
            FuncionesBases.CargarCboEstablecimientoUsuario(cboEstablecimiento);
        } 

        #endregion



        

    }
}
