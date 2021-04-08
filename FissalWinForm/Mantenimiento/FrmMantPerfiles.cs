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
using System.Threading;

namespace FissalWinForm
{
    public partial class FrmMantPerfiles : Form
    {

        // Instancio Objetos .-
        PerfilBL ObjPerfilBL = new PerfilBL();
        PermisoPerfilBL ObjPermisoPerfil = new PermisoPerfilBL();
        PerfilBL objPerfilBL = new PerfilBL();
        DataTable dtMenu = new DataTable();
        DataTable dtModulo = new DataTable();
        DataTable dtMenuValores = new DataTable();
        DataTable dtModuloValores = new DataTable();

        public FrmMantPerfiles()
        {
            InitializeComponent();
        }

        private void FrmMantPerfiles_Load(object sender, EventArgs e)
        {
            pnlEdicionMenu.Hide();
            pnlEdicionModulo.Hide();
            FuncionesBases.CargarComboModulos(cboModuloPerfil);
            CargarGrillaModulo();

            lblResultGrillaMod.Text = "Total: " + dgvModulos.RowCount + "   [ Modulo(s) Encontrado(s) ]";
        }

        #region Botones 

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            Close();
        }             

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboModuloPerfil.SelectedValue) > 0)
            {
                if (txtDescFormulario.TextLength > 0)
                {
                    if (txtNombFormulario.TextLength > 0)
                    {
                        GuardarItem();
                        CargarGrillaMenu();
                        Refresh();
                    }
                    else { MessageBox.Show("Ingrese el nombre del Formulario"); Efecto(txtNombFormulario); }
                }
                else { MessageBox.Show("Ingrese el nombre del Menu"); Efecto(txtDescFormulario); }
            }
            else { MessageBox.Show("Porfavor Seleccione un Modulo"); }
            

        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (txtBusqModulo.TextLength > 0)
            {
                GuardaModulo();
                CargarGrillaModulo();
                Refresh();
            }
            else { MessageBox.Show("Ingrese el nombre de Modulo"); Efecto(txtBusqModulo); }


        }

        private void btnTerminado2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            tbcPanelPrincipal.SelectedTab = tbpModulo;
        }

        #endregion

        #region Botones Panel Modulo

        private void btnMActualizar_Click(object sender, EventArgs e)
        {

            if (txtDecMenu_M.TextLength > 0)
            {
                ActualizaModulo(Convert.ToString(this.dgvModulos.CurrentRow.Cells[3].Value));                
                CargarGrillaModulo();
                pnlEdicionModulo.Hide();
            }
            else 
            {
                MessageBox.Show("Por favor ingrese un nombre:");
            }

        }

        private void btnMCerrar_Click(object sender, EventArgs e)
        {
            pnlEdicionModulo.Hide();
            CargarGrillaModulo();
        }

        #endregion
        
        #region Botones Panel Menu

        private void btnPActualizar_Click(object sender, EventArgs e)
        {
            ActualizaItem(Convert.ToString(this.dgvPerfMod.CurrentRow.Cells[2].Value));
            pnlEdicionMenu.Hide();
            CargarGrillaMenu();
        }

        private void btnPCerrar_Click(object sender, EventArgs e)
        {
            pnlEdicionMenu.Hide();
            CargarGrillaMenu();
        }

        #endregion

        #region Eventos

        private void cboModuloPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrillaMenu();
        }

        private void txtBusqModulo_TextChanged(object sender, EventArgs e)
        {
            dgvModulos.DataSource = ObjPermisoPerfil.Listar_Modulos(txtBusqModulo.Text.ToString());

            lblResultGrillaMod.Text = "Total: " + dgvModulos.RowCount + "   [ Modulo(s) Encontrado(s) ]";
        }

        private void dgvPerfMod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex == 1)     // Eliminar
            {
                if (MessageBox.Show("Esta seguro de Eliminar este Item?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminaItem(Convert.ToString(this.dgvPerfMod.CurrentRow.Cells[2].Value));
                    CargarGrillaMenu();
                    Refresh();
                }
            }
            else if (((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex == 0) //Editar
            {
                txtDecMenu_R.Text = Convert.ToString(this.dgvPerfMod.CurrentRow.Cells[2].Value);
                txtUrlMenu_R.Text = Convert.ToString(this.dgvPerfMod.CurrentRow.Cells[3].Value);
                pnlEdicionMenu.Show();
            }
        }

        private void dgvModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex == 1)     // Eliminar
            {
                if (MessageBox.Show("Esta seguro de Eliminar este Modulo?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminaModulo(Convert.ToString(this.dgvModulos.CurrentRow.Cells[3].Value));
                    CargarGrillaModulo();
                    FuncionesBases.CargarComboModulos(cboModuloPerfil);
                }
            }
            else if (((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex == 0) //Editar
            {
                txtDecMenu_M.Text = Convert.ToString(this.dgvModulos.CurrentRow.Cells[3].Value);
                pnlEdicionModulo.Show();
            }
        }

        #endregion

        #region Metodos

        private void GuardarItem()
        {
            // Obtengo todos los IdMenu y IdPerfil del Modulo Seleccionado 
            dtMenu = ObjPerfilBL.Listar_PerfilesxModulo(Convert.ToString(cboModuloPerfil.Text.Trim()));

            // Declaro Variables .-
            int Result = 0;

            //Probando....
            int PosMenu = 0;
            PosMenu = ObjPermisoPerfil.ObtenerPosicMenu(Convert.ToString(cboModuloPerfil.Text.Trim())) + 1;
            //....Fin Prueba

            //  Comienza el recorrido con el DataTable(dtPerfiles) Obtenido
            foreach (DataRow row in dtMenu.Rows)
            {

                PermisoPerfil PermisoPerfil = new PermisoPerfil();
                {
                    PermisoPerfil.Id_MenuPadre = Convert.ToInt32(row["Id_Menu"]);
                    PermisoPerfil.DescripcionMenu = txtDescFormulario.Text.Trim();
                    PermisoPerfil.PosicionMenu = PosMenu;// columna a eliminar, OBSOLETA  
                    PermisoPerfil.HabilitadoMenu = 1;     // Default - Activo
                    PermisoPerfil.UrlMenu = txtNombFormulario.Text.Trim();
                    PermisoPerfil.EtiquetaModulo = Convert.ToString(cboModuloPerfil.Text.Trim());// Default - 0 
                    PermisoPerfil.Id_Perfil = Convert.ToInt32(row["Id_Perfil"]);
                }

                Result = ObjPermisoPerfil.MenuxModulo_Agregar(PermisoPerfil);
            }

            if (Result == 1)
            {
                //MessageBox.Show("Se Creo nuevo menu");
                MessageBox.Show("Es necesario reiniciar el programa para que los cambios surjan efecto", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Este Nombre: " + txtDescFormulario.Text.Trim() + " ya existe en este modulo");
            }

        }

        private void ActualizaItem(string DescripcionMenu)
        {
            // Obtengo todos los IdMenu y IdPerfil del Modulo Seleccionado 
            dtMenuValores = ObjPermisoPerfil.ObtenerValoresMenu(DescripcionMenu);
            
            // Declaro Variables .-
            int Result = 0;

            //  Comienza el recorrido con el DataTable(dtPerfValores) Obtenido
            foreach (DataRow row in dtMenuValores.Rows)
            {
                PermisoPerfil PermisoPerfil = new PermisoPerfil();
                {
                    PermisoPerfil.Id_Menu = Convert.ToInt32(row["Id_Menu"]);
                    PermisoPerfil.DescripcionMenu = txtDecMenu_R.Text.Trim();
                    PermisoPerfil.UrlMenu = txtUrlMenu_R.Text.Trim();
                }

                Result = ObjPermisoPerfil.MenuxModulo_Actualizar(PermisoPerfil);
            }

            if (Result == 1)
            {
                //MessageBox.Show("Se Actualizo el Item: " + DescripcionMenu + " correctamente..");
                MessageBox.Show("Es necesario reiniciar el programa para que los cambios surjan efecto", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al actualizar este Menu: " + DescripcionMenu);
            }
        }

        private void EliminaItem(String DescripcionMenu)
        {
            // Obtengo todos los IdMenu y IdPerfil del Modulo Seleccionado 
            dtMenuValores = ObjPermisoPerfil.ObtenerValoresMenu(DescripcionMenu);

            // Declaro Variables .-
            int Result = 0;

            //  Comienza el recorrido con el DataTable(dtPerfValores) Obtenido
            foreach (DataRow row in dtMenuValores.Rows)
            {
                int Id_Menu = 0;
                {
                    Id_Menu = Convert.ToInt32(row["Id_Menu"]);
                }

                Result = ObjPermisoPerfil.MenuxModulo_Eliminar(Id_Menu);
            }

            if (Result == 1)
            {
                MessageBox.Show("Se Elimino el Item: " + DescripcionMenu + " correctamente..");
            }
            else
            {
                MessageBox.Show("Error al eliminar este Menu: " + DescripcionMenu);
            }
        }


        private void GuardaModulo() 
        {
            // Obtengo todos los IdMenu y IdPerfil del Modulo Seleccionado 
            dtModulo = ObjPerfilBL.Listar_PerfilesFull();
            
            //Probando....
            int PosModulo = 0;
            PosModulo = ObjPermisoPerfil.ObtenerPosicModulo() + 1;
            //....Fin Prueba

            // Declaro Variables .-
            int Result = 0;

            foreach (DataRow row in dtModulo.Rows)
            {

                PermisoPerfil PermisoPerfil = new PermisoPerfil();
                {
                    PermisoPerfil.Id_MenuPadre = 0;
                    PermisoPerfil.DescripcionMenu = txtBusqModulo.Text.Trim();
                    PermisoPerfil.PosicionMenu = PosModulo;// columna a eliminar, OBSOLETA  
                    PermisoPerfil.HabilitadoMenu = 1;     // Default - Activo
                    PermisoPerfil.UrlMenu = "NULL";
                    PermisoPerfil.EtiquetaModulo = "NULL";// 
                    PermisoPerfil.Id_Perfil = Convert.ToInt32(row["Id_Perfil"]);
                }

                Result = ObjPermisoPerfil.Modulo_Agregar(PermisoPerfil);
            }

            if (Result == 1)
            {
                //MessageBox.Show("Se Creo nuevo Modulo");
                FuncionesBases.CargarComboModulos(cboModuloPerfil);
                MessageBox.Show("Es necesario reiniciar el programa para que los cambios surjan efecto", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Este Nombre: " + txtDescFormulario.Text.Trim() + " ya existe!");
            }
        
        }

        private void ActualizaModulo(String DescripcionMenu) 
        {
            // Obtengo todos los IdMenu y IdPerfil del Modulo Seleccionado 
            dtModuloValores = ObjPermisoPerfil.ObtenerValoresMenu(DescripcionMenu);

            // Declaro Variables .-
            int Result = 0;

            //  Comienza el recorrido con el DataTable(dtPerfValores) Obtenido
            foreach (DataRow row in dtModuloValores.Rows)
            {
                PermisoPerfil PermisoPerfil = new PermisoPerfil();
                {
                    PermisoPerfil.Id_Menu = Convert.ToInt32(row["Id_Menu"]);
                    PermisoPerfil.DescripcionMenu = txtDecMenu_M.Text.Trim();
                    PermisoPerfil.UrlMenu = String.Empty;
                }

                Result = ObjPermisoPerfil.MenuxModulo_Actualizar(PermisoPerfil);
            }

            if (Result == 1)
            {
                //MessageBox.Show("Se Actualizo el Item: " + DescripcionMenu + " correctamente..");
                MessageBox.Show("Es necesario reiniciar el programa para que los cambios surjan efecto", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al actualizar este Menu: " + DescripcionMenu);
            }        
        }

        private void EliminaModulo(String DescripcionMenu) 
        {
            // Obtengo todos los IdMenu y IdPerfil del Modulo Seleccionado 
            dtModuloValores = ObjPermisoPerfil.ObtenerValoresModulo(DescripcionMenu);

            // Declaro Variables .-
            int Result = 0;

            //  Comienza el recorrido con el DataTable(dtPerfValores) Obtenido
            foreach (DataRow row in dtModuloValores.Rows)
            {
                int Id_Menu = 0;
                {
                    Id_Menu = Convert.ToInt32(row["Id_Menu"]);
                }

                Result = ObjPermisoPerfil.MenuxModulo_Eliminar(Id_Menu);
            }

            if (Result == 1)
            {
                MessageBox.Show("Se Elimino el Modulo: " + DescripcionMenu + " correctamente..");
            }
            else
            {
                MessageBox.Show("Error al eliminar este Modulo: " + DescripcionMenu);
            }        
        }



        private void CargarGrillaMenu()
        {
            dgvPerfMod.DataSource = ObjPerfilBL.Listar_MenusxModulos(Convert.ToString(cboModuloPerfil.Text.Trim()));
        }

        private void CargarGrillaModulo() 
        {
            dgvModulos.DataSource = ObjPermisoPerfil.Listar_Modulos(txtBusqModulo.Text.Trim());        
        }


        void Efecto(TextBox Box)
        {
            Box.BackColor = Color.Red;
            Application.DoEvents();
            Thread.Sleep(800);
            Box.BackColor = Color.White;
        }

        #endregion

    }
}
