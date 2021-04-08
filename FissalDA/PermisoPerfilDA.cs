using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using FissalBE;

namespace FissalDA
{
    public class PermisoPerfilDA
    {
        static SqlConnection cn = AccesoBD.getConnnection();
        PermisoPerfil Perm = new PermisoPerfil();
        static SqlCommand cmd = new SqlCommand();

        // Seteo las variables y condiciono la carga del menu por el Id Perfil
        public DataTable MenusWindowsDelPerfil(Int32 id_Perfil)
        {
            Perm.HabilitadoMenu = 1;
            Perm.Id_Perfil = id_Perfil;
            Perm.DescripcionMenu = "";
            Perm.UrlMenu = "";
            Perm.CondicionAdicional = "";
            return BuscarPerfilesPermisos();
        }

        // Obtiene La estructura del Menu 
        public DataTable BuscarPerfilesPermisos()
        {

            DataTable dt = new DataTable();
            //Construyendo la condición
            string condicion = "";
            if (Perm.Id_Menu > 0) condicion += " AND T1.Id_Menu =" + Perm.Id_Menu;
            if (Perm.Id_MenuPadre > 0) condicion += " AND T1.Id_MenuPadre =" + Perm.Id_MenuPadre;
            if (Perm.DescripcionMenu.Length > 0) condicion += " AND T1.DescripcionMenu Like '%" + Perm.DescripcionMenu + "%'";
            if (Perm.PosicionMenu > 0) condicion += " AND T1.PosicionMenu =" + Perm.PosicionMenu;
            if (Perm.HabilitadoMenu > 0) condicion += " AND T1.HabilitadoMenu =" + Perm.HabilitadoMenu;
            if (Perm.UrlMenu.Length > 0) condicion += " AND T1.UrlMenu Like '%" + Perm.UrlMenu + "%'";
            //if (Perm.FormularioAsociado > 0) condicion += " AND T1.FormularioAsociado =" + Perm.FormularioAsociado;
            if (Perm.Id_Perfil > 0) condicion += " AND T1.Id_Perfil =" + Perm.Id_Perfil;
            if (Perm.CondicionAdicional.Length > 0) condicion += " AND " + Perm.CondicionAdicional;
            if (condicion != "") condicion = " WHERE " + condicion.Substring(5);
            string sql = @"SELECT T1.Id_Menu, T1.Id_MenuPadre, T1.DescripcionMenu,
					T1.HabilitadoMenu, T1.UrlMenu,  
                    T1.PosicionMenu,  				   
                    T1.Id_Perfil 
					FROM PermisoPerfil as T1" + condicion;
            try //  T1.FormularioAsociado, T1.Id_Perfil ,
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Actualiza Permisos x Perfil | Cambio los estados de habilitados a inhabilitados
        public int PermisosPerfil_Actualizar(int Id_Menu, Boolean HabilitaMenu)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_Perfiles_PermisosPerfil_Update]";
            cmd.Parameters.AddWithValue("@Id_Menu", Id_Menu);
            cmd.Parameters.AddWithValue("@HabilitadoMenu", HabilitaMenu);
            return Datos.Mantenimiento(cmd);
        }




        // Listar Modulos
        public DataTable Listar_Modulos(string DescripcionMenu)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Obtener_ModulosxDescripcion]";
            cmd.Parameters.AddWithValue("@DescripcionMenu", DescripcionMenu);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Obtiene los valores del Menu
        public DataTable ObtenerValoresModulo(string DescripcionMenu)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_ObtenerValores_Modulo]";
            cmd.Parameters.AddWithValue("@DescripcionMenu", DescripcionMenu);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Inserta Menus x Modulo 
        public int Modulo_Agregar(PermisoPerfil ObjPermisoPerfil)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Agregar_Modulo]";
            cmd.Parameters.AddWithValue("@Id_MenuPadre", ObjPermisoPerfil.Id_MenuPadre);
            cmd.Parameters.AddWithValue("@DescripcionMenu", ObjPermisoPerfil.DescripcionMenu);
            cmd.Parameters.AddWithValue("@PosicionMenu", ObjPermisoPerfil.PosicionMenu);
            cmd.Parameters.AddWithValue("@HabilitadoMenu", ObjPermisoPerfil.HabilitadoMenu);
            cmd.Parameters.AddWithValue("@UrlMenu", ObjPermisoPerfil.UrlMenu);
            cmd.Parameters.AddWithValue("@EtiquetaModulo", ObjPermisoPerfil.EtiquetaModulo);
            cmd.Parameters.AddWithValue("@Id_Perfil", ObjPermisoPerfil.Id_Perfil);
            return Datos.Mantenimiento(cmd);
        }


        
        // Obtiene los valores del Menu
        public DataTable ObtenerValoresMenu(string DescripcionMenu) 
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_ObtenerValores_MenusxModulo]";
            cmd.Parameters.AddWithValue("@DescripcionMenu", DescripcionMenu);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Inserta Menus x Modulo 
        public int MenuxModulo_Agregar(PermisoPerfil ObjPermisoPerfil)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Agregar_MenusxModulo]";
            cmd.Parameters.AddWithValue("@Id_MenuPadre", ObjPermisoPerfil.Id_MenuPadre);
            cmd.Parameters.AddWithValue("@DescripcionMenu", ObjPermisoPerfil.DescripcionMenu);
            cmd.Parameters.AddWithValue("@PosicionMenu", ObjPermisoPerfil.PosicionMenu);
            cmd.Parameters.AddWithValue("@HabilitadoMenu", ObjPermisoPerfil.HabilitadoMenu);
            cmd.Parameters.AddWithValue("@UrlMenu", ObjPermisoPerfil.UrlMenu);                        
            cmd.Parameters.AddWithValue("@EtiquetaModulo", ObjPermisoPerfil.EtiquetaModulo);
            cmd.Parameters.AddWithValue("@Id_Perfil", ObjPermisoPerfil.Id_Perfil);
            return Datos.Mantenimiento(cmd);
        }

        // Actualiza Menus x Modulo
        public int MenuxModulo_Actualizar(PermisoPerfil ObjPermisoPerfil)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Actualiza_MenusxModulo]";
            cmd.Parameters.AddWithValue("@Id_Menu", ObjPermisoPerfil.Id_Menu);
            cmd.Parameters.AddWithValue("@DescripcionMenu", ObjPermisoPerfil.DescripcionMenu);
            cmd.Parameters.AddWithValue("@UrlMenu", ObjPermisoPerfil.UrlMenu);   
            return Datos.Mantenimiento(cmd);
        }

        // Elimina Menus x Modulo
        public int MenuxModulo_Eliminar(int IdMenu)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Elimina_MenusxModulo]";
            cmd.Parameters.AddWithValue("@Id_Menu", IdMenu);
            return Datos.Mantenimiento(cmd);
        }




        //--------------- CONTADORES DE POSICIONES MODULO - MENU

        public int ObtenerPosicModulo() 
        {
            DataTable dt = new DataTable();
            int PosModulo = 0;
            string sql = @"Select count(*) PosicionMenu From( Select DescripcionMenu, Id_MenuPadre  
									                          From PermisoPerfil 
									                          Where Id_MenuPadre = 0 
									                          Group by DescripcionMenu,Id_MenuPadre) PermisoPerfil";
            try 
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);
                DataRow row = dt.Rows[0];
                PosModulo = Convert.ToInt32(row["PosicionMenu"].ToString());
                return PosModulo;

            }
            catch (Exception e)
            {
                throw e;
            }        
        }

        public int ObtenerPosicMenu(string DescMenu)
        {
            DataTable dt = new DataTable();
            int PosMenu = 0;
            string sql = @"Select count(*) PosicionMenu From( Select DescripcionMenu 
									                          From PermisoPerfil 
									                          Where Id_MenuPadre <> 0 and EtiquetaModulo = '" + DescMenu + 
									                          "' Group by DescripcionMenu) PermisoPerfil";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt); DataRow row = dt.Rows[0];
                PosMenu = Convert.ToInt32(row["PosicionMenu"].ToString());
                return PosMenu;
            }
            catch (Exception e)
            {
                throw e;
            }   
        }

        //--------------- FIN CONTADORES

    }
}
