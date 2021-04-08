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
    public partial class Valorizacion : Form
    {
        public Valorizacion()
        {
            InitializeComponent();
        }

        private void Valorizacion_Load(object sender, EventArgs e)
        {
            CargaGrilla();
            this.KeyPreview = true;
        }

        #region "Botones"

            private void btnSalir_Click(object sender, EventArgs e)
            {
                Close();
            }

        #endregion

        #region "Metodos"

            private void CargaGrilla()
            {
                MovimientoPacienteBL objMovimientoPacienteBL = new MovimientoPacienteBL();
                dataGridView1.DataSource = objMovimientoPacienteBL.MovimientoPaciente_Listar();
            }
            
            private void Valorizacion_KeyDown(object sender, KeyEventArgs e)
            {

                #region "Estilo Tecla Independiente"

                    //if (e.KeyCode == Keys.F1)
                    //{
                    //    tabControl1.SelectedIndex = 0;
                    //}

                    //else if (e.KeyCode == Keys.F2)
                    //{
                    //    tabControl1.SelectedIndex = 1;
                    //}

                    //else if (e.KeyCode == Keys.F3)
                    //{
                    //    tabControl1.SelectedIndex = 2;
                    //}

                #endregion

                #region "Estilo Unica Tecla"

                    if (e.KeyCode == Keys.F2)
                    {
                        if (tabControl1.SelectedIndex == 0)
                        {
                            tabControl1.SelectedIndex = 1;
                        }

                        else if (tabControl1.SelectedIndex == 1)
                        {
                            tabControl1.SelectedIndex = 2;
                        }

                        else if (tabControl1.SelectedIndex == 2)
                        {
                            tabControl1.SelectedIndex = 0;
                        }

                    }

                #endregion

            }

        #endregion

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(Constantes.MSJ_OK + textBox1.Text);
            }
        }

    }



}

