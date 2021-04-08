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

    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = "C:\\FissalV2DEV\\FissalWinForm\\Ayuda\\Fissal.chm";
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
