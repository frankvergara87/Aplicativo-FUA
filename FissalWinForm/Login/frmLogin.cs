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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UsuarioBL objUsuarioBL = new UsuarioBL();

        private void frmLogin_Load(object sender, EventArgs e)
        { 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            DataTable dt = new DataTable();
            u.login = txtUsuario.Text;
            u.password = txtPassword.Text;
            dt = objUsuarioBL.usuarioLogin(u);

            if (txtUsuario.TextLength > 0)
            {
                if (txtPassword.TextLength > 0)
                {
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuario ó Contraseña no encontrado", VariablesGlobales.NomSw());
                    }
                    else
                    {
                        DataRow row = dt.Rows[0];
                        VariablesGlobales.UsuarioId = (int)row["id_usuario"];
                        VariablesGlobales.Login = row["login"].ToString();
                        VariablesGlobales.EstablecimientoDescripcion = row["Descripcion"].ToString();
                        VariablesGlobales.EstablecimientoId = (int)row["EstablecimientoId"];
                        VariablesGlobales.EstablecimientoNivel = row["nivel"].ToString();
                        VariablesGlobales.Login = row["login"].ToString();
                        VariablesGlobales.Id_Perfil = (int)row["Id_Perfil"];           /************** Nuevo */
                        VariablesGlobales.DescPerfil = row["DescPerfil"].ToString();   /************** Nuevo */
                        VariablesGlobales.CatPerfil = (int)row["CatPerfil"];           /************** Nuevo */


                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una Contraseña");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un Usuario");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar   == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            frmControlUsuario frm = new frmControlUsuario();
            frm.Show();            
         }
    }
}
