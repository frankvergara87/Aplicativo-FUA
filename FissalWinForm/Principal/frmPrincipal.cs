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
using System.Configuration;
using System.Resources;

namespace FissalWinForm
{
    public partial class frmPrincipal : Form
    {
        /* Declaramos Variables privadas a utilizar..*/
        private DataTable dtMenus;
        private System.Reflection.Assembly Ensamblado;
        PermisoPerfilBL objPermisoPerfilBL = new PermisoPerfilBL();
        /*********************************************/

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            
            /*********************************************** Cambio de Color de fondo **/
            
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.White;
                    break;
                }
                
            }
            /*********************************************** Fin Cambio de Color de fondo **/
            
            /*********************************************** Obtenemos las variables del Usuario Logueado **/

            tssUsuarioLogueado.Text = "Usuario: " + VariablesGlobales.Login.Trim() 
                                       + " - [" + VariablesGlobales.DescPerfil.Trim() 
                                       + "] | Establecimiento: " + VariablesGlobales.EstablecimientoDescripcion.Trim() 
                                       + " - " + VariablesGlobales.EstablecimientoId.ToString() 
                                       + " |  Nivel: " + VariablesGlobales.EstablecimientoNivel.Trim();
            
            int IdPerfil = VariablesGlobales.Id_Perfil;

            Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            this.MenuPpal.Items.Clear();

            /************ Inicio la creacion del menu con el Perfil obtenido******/
            this.CargarMenus(IdPerfil);
            /**************************/


        
        }

        #region Evento Crea Menus


        private void Prueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciono", "Aviso", MessageBoxButtons.YesNo);
        }

        private void CargarMenus(int id_Perfil)
        {
            dtMenus = objPermisoPerfilBL.PermisoPerfil(id_Perfil);

            foreach (DataRow MenuPadre in dtMenus.Select("Id_MenuPadre=0", "PosicionMenu ASC")) 
            {

                ToolStripItem[] Menu = new ToolStripItem[1];
                Menu[0] = new ToolStripMenuItem();
                Menu[0].Name = MenuPadre["Id_Menu"].ToString();
                Menu[0].Text = MenuPadre["DescripcionMenu"].ToString();
                Menu[0].Tag = MenuPadre["UrlMenu"].ToString();
                //Menu[0].Image = Properties.Resources.Icon; 
                //Averiguando si tiene Hijos o no
                if (dtMenus.Select("Id_MenuPadre=" + MenuPadre["Id_Menu"]).Length == 0)
                {
                    //Sino tiene hijos lo agrego a la barra de menu principal
                    //mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"], null, new EventHandler(MenuItemClicked));
                    Menu[0].Click += new EventHandler(MenuItemClicked);
                    MenuPpal.Items.Add(Menu[0]);
                }
                else
                {
                    //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                    //AgregarMenuHijo(mnu_Principal.Items.Add((String)MenuPadre["DescripcionMenu"]));
                    MenuPpal.Items.Add(Menu[0]);
                    AgregarMenuHijo(Menu[0]);
                }
            }
        }

        private void AgregarMenuHijo(ToolStripItem MenuItemPadre)
        {
            ToolStripMenuItem MenuPadre = (ToolStripMenuItem)MenuItemPadre;

            //Obtengo el ID del menu Enviado para saber si tiene hijos o no
            //int Id = (int)(dtMenus.Select("DescripcionMenu='" +MenuPadre.Text+"'")[0]["Id_Menu"]);
            string Id = MenuPadre.Name;

            //Averiguando si tiene Hijos o no
            if (dtMenus.Select("Id_MenuPadre=" + Id).Length == 0)
            {
                //Si No tiene Hijos Solo Agrego el Evento
                MenuPadre.Click += new EventHandler(MenuItemClicked);
            }
            else
            {
                //Si Aun tiene Hijos
                foreach (DataRow Menu in dtMenus.Select("Id_MenuPadre=" + Id, "PosicionMenu ASC"))
                {
                    ToolStripItem[] NuevoMenu = new ToolStripItem[1];
                    NuevoMenu[0] = new ToolStripMenuItem();
                    NuevoMenu[0].Name = Menu["Id_Menu"].ToString();
                    NuevoMenu[0].Text = Menu["DescripcionMenu"].ToString();
                    NuevoMenu[0].Tag = Menu["UrlMenu"].ToString();
                    //Averiguo se es un separador
                    if (Menu["DescripcionMenu"].ToString() == "-")
                    {
                        //MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"]);
                        MenuPadre.DropDownItems.Add(NuevoMenu[0].Text);
                    }
                    else
                    {
                        //Obtengo el ID del Menu del foreach
                        //int IdMenu = (int)dtMenus.Select("DescripcionMenu='" + Menu["DescripcionMenu"]+"'")[0]["Id_Menu"];
                        //int IdMenu = (int)Menu["Id_Menu"];
                        //Averiguando si tiene Hijos o no
                        if (dtMenus.Select("Id_MenuPadre=" + Menu["Id_Menu"]).Length == 0)
                        {
                            //Sino tiene hijos lo agrego al Menu Padre
                            //MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"], null, new EventHandler(MenuItemClicked));
                            NuevoMenu[0].Click += new EventHandler(MenuItemClicked);
                            MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                        }
                        else
                        {
                            //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                            //AgregarMenuHijo(MenuPadre.DropDownItems.Add((String)Menu["DescripcionMenu"]));
                            MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                            AgregarMenuHijo(NuevoMenu[0]);
                        }
                    }
                }
            }
        }

        private void MenuItemClicked(object sender, EventArgs e)
        {
            // if the sender is a ToolStripMenuItem
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {

                string NombreFormulario = ((ToolStripItem)sender).Tag.ToString();
                Object ObjFrm;
                //Type tipo = default(Type);
                Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + NombreFormulario);

                string val = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

                if (tipo == null)
                {
                    MessageBox.Show("Formulario en Mantenimiento..!!", "Desarrollo: Fissal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        ObjFrm = Activator.CreateInstance(tipo);
                        Form Formulario = (Form)ObjFrm;
                        Formulario.MdiParent = this;
                        Formulario.Show();
                    }
                }
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {

            if (this.MdiChildren.Length > 0)
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    //MessageBox.Show(NombreDelFrm.Substring(NombreDelFrm.IndexOf("Frm_"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm_")));
                    if (this.MdiChildren[i].Name == NombreDelFrm.Substring(NombreDelFrm.IndexOf("Frm"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm")))
                    {                        
                        this.MdiChildren[i].BringToFront();
                        //MessageBox.Show("El formulario solicitado ya se encuentra abierto");
                        return true;
                    }
                }

                return false;
            }
            else
                return false;
        }

        #endregion   

        #region Panel Botones Apagar | Reiniciar

         //if (MessageBox.Show("Esta seguro de reiniciar la aplicacion?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
         //   {
         //       Application.Restart();
         //   }

        private void tsbReiniciar_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
        
    }
}
