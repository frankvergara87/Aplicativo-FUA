using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;
using FissalBE;
using System.Data;

namespace FissalBL
{
    public class PermisoPerfilBL
    {
        PermisoPerfilDA ObjPermisoPerfilDA = new PermisoPerfilDA();

        public DataTable PermisoPerfil(int Id_Perfil)
        {
            return ObjPermisoPerfilDA.MenusWindowsDelPerfil(Id_Perfil);
        }

        public int PermisosxPerfil_Actualizar(int Id_Menu,Boolean HabilitaMenu)
        {
            return ObjPermisoPerfilDA.PermisosPerfil_Actualizar(Id_Menu, HabilitaMenu);
        }
        

        #region Modulo

        public DataTable Listar_Modulos(string DescripcionMenu)
        {
            return ObjPermisoPerfilDA.Listar_Modulos(DescripcionMenu);
        }

        public DataTable ObtenerValoresModulo(string DescripcionMenu)
        {
            return ObjPermisoPerfilDA.ObtenerValoresModulo(DescripcionMenu);
        }

        public int Modulo_Agregar(PermisoPerfil ObjPermisoPerfil)
        {
            return ObjPermisoPerfilDA.Modulo_Agregar(ObjPermisoPerfil);
        }

        #endregion

        #region Menu

        public DataTable ObtenerValoresMenu(string DescripcionMenu) 
        {
            return ObjPermisoPerfilDA.ObtenerValoresMenu(DescripcionMenu);        
        }

        public int MenuxModulo_Agregar(PermisoPerfil ObjPermisoPerfil)
        {
            return ObjPermisoPerfilDA.MenuxModulo_Agregar(ObjPermisoPerfil);
        }

        public int MenuxModulo_Actualizar(PermisoPerfil ObjPermisoPerfil)
        {
            return ObjPermisoPerfilDA.MenuxModulo_Actualizar(ObjPermisoPerfil);
        }

        public int MenuxModulo_Eliminar(int IdMenu)
        {
            return ObjPermisoPerfilDA.MenuxModulo_Eliminar(IdMenu);
        }

        #endregion

        #region PosicionMenu

        public int ObtenerPosicModulo()
        {
            return ObjPermisoPerfilDA.ObtenerPosicModulo();
        }

        public int ObtenerPosicMenu(string DescMenu)
        {
            return ObjPermisoPerfilDA.ObtenerPosicMenu(DescMenu);
        }

        #endregion

    }
}
