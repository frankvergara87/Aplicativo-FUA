using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FissalWinForm
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmGestionarAutorizaciones());
            //Abrimos frmLogin
            
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }


            //Atencion.FrmProcesoWS f = new Atencion.FrmProcesoWS();
            //f.ShowDialog();


        }
    }
}
