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
    public partial class FrmPerfiles : Form
    {
        PerfilBL objPerfilBL = new PerfilBL();
        PermisoPerfilBL objPermisoPerfilBL = new PermisoPerfilBL();

        public FrmPerfiles()
        {
            InitializeComponent();
        }

        private void FrmPerfiles_Load(object sender, System.EventArgs e)
        {
            comboBox1.DataSource = null;
            FuncionesBases.CargarComboPerfiles(comboBox1, VariablesGlobales.Id_Perfil);
            
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            CargaTreeview(Convert.ToInt32(comboBox1.SelectedValue));
            //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            

            treeView1.AfterCheck += treeView1_AfterCheck; 
        }

        #region Botones

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarPerfil();

            if (MessageBox.Show("Es necesario el programa reiniciar para que los cambios surjan efecto", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        #endregion

        #region Eventos Treeview

        private void CargaTreeview(int IdPerfil)
        {
            treeView1.Nodes.Clear();

            DataTable dt = objPerfilBL.Listar_Perfiles_Padre(IdPerfil);

            foreach (DataRow drPadre in dt.Rows)
            {

                ////////////////////////////////////////////
                if ((Convert.ToBoolean(drPadre["HabilitadoMenu"])) == true | VariablesGlobales.Id_Perfil != 2)
                {
                    ///////////////////////////////////////////

                    TreeNode parentNode = new TreeNode();
                    parentNode.Tag = drPadre["Id_Menu"].ToString();
                    parentNode.Text = drPadre["DescripcionMenu"].ToString();

                    if (Convert.ToBoolean(drPadre["HabilitadoMenu"]))
                    {
                        parentNode.Checked = Convert.ToBoolean(bool.TrueString);
                    }

                    DataTable dtchildc = objPerfilBL.Listar_Perfiles_Hijo(Convert.ToInt32(drPadre["Id_Menu"]));

                    foreach (DataRow drHijo in dtchildc.Rows)
                    {
                        ////////////////////////////////////////

                        if ((Convert.ToBoolean(drHijo["HabilitadoMenu"])) == true | VariablesGlobales.Id_Perfil != 2)
                        {
                            ////////////////////////////////////////////

                            TreeNode childNode = new TreeNode();
                            childNode.Tag = drHijo["Id_Menu"].ToString();
                            childNode.Text = drHijo["DescripcionMenu"].ToString();

                            if (Convert.ToBoolean(drHijo["HabilitadoMenu"]))
                            {
                                childNode.Checked = Convert.ToBoolean(bool.TrueString);
                            }

                            parentNode.Nodes.Add(childNode);

                            /////////////////////////////////////////////
                        }

                        ////////////////////////////////////////////
                    }

                    treeView1.Nodes.Add(parentNode);

                    ////////////////////////////////////////////
                }

                ////////////////////////////////////////////

            }

            treeView1.ExpandAll();
        }

        private void ActualizarPerfil()
        {
            foreach (TreeNode parentNode in treeView1.Nodes)
            {

                ActualizaPermisosPerfil(Convert.ToInt32(parentNode.Tag), Convert.ToBoolean(parentNode.Checked));

                if (parentNode.Nodes.Count > 0)
                {
                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        ActualizaPermisosPerfil(Convert.ToInt32(childNode.Tag), Convert.ToBoolean(childNode.Checked));
                    }
                }

            }

        }

        private void ActualizaPermisosPerfil(int Id_Menu, Boolean HabilitaMenu)
        {

            objPermisoPerfilBL.PermisosxPerfil_Actualizar(Id_Menu, HabilitaMenu);

        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //
            // Se remueve el evento para evitar que se ejecute nuevamente por accion de cambio de estado 
            // en esta operacion
            //
            treeView1.AfterCheck -= treeView1_AfterCheck;

            //
            // Se valida si el nodo marcado tiene presedente
            // en caso de tenerlo se debe evaluar los nodos al mismo nivel para determinar si todos estan marcados, 
            // si lo estan se marca tambien el nodo padre
            //
            if (e.Node.Parent != null)
            {
                bool result = true;
                foreach (TreeNode node in e.Node.Parent.Nodes)
                {
                    if (node.Checked)
                    {
                        result = true;
                        break;
                    }
                }

                e.Node.Parent.Checked = result;

            }

            //
            // Se valida si el nodo tiene hijos
            // si los tiene se recorren y asignan el estado del nodo que se esta evaluando
            //
            if (e.Node.Nodes.Count > 0)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = e.Node.Checked;
                }
            }


            treeView1.AfterCheck += treeView1_AfterCheck;

        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedValue) != 0)
            { CargaTreeview(Convert.ToInt32(comboBox1.SelectedValue)); btnGuardar.Enabled = true; }
            else
            { btnGuardar.Enabled = false; treeView1.Nodes.Clear(); }
        }

        #region Eventos ComboBox



        #endregion




    }
}
