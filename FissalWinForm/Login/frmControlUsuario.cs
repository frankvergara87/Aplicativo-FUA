using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FissalWinForm
{
    public partial class frmControlUsuario : Form
    {
        public frmControlUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength == 0)
            {
                errorProvider1.SetError(txtUsuario, "PorFavor Ingrese Usuario");
            }
            else { errorProvider1.Clear(); }
        }
    }
}
