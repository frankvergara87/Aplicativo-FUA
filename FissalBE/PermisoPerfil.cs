using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissalBE
{
    public class PermisoPerfil
    {

        #region "Declaracion de Variables"

        public int id_menu;
        public int id_menupadre;
        public string descripcionmenu;
        public int posicionmenu;
        public int habilitadomenu;
        public string urlmenu;
        public string etiquetamodulo;
        public int id_perfil;
        public string condicionadicional;

        #endregion

        #region "Condiciones para los miembros de la clase"

        public bool bid_menu;
        public bool bid_menupadre;
        public bool bdescripcionmenu;
        public bool bposicionmenu;
        public bool bhabilitadomenu;
        public bool burlmenu;
        public bool bEtiquetaModulo;
        public bool bid_perfil;

        #endregion

        #region "Propiedades de la clase"

        /// <summary>
        /// Propiedad para el campo Id_Menu
        /// </summary>
        public int Id_Menu
        {
            get
            {
                return id_menu;
            }
            set
            {
                id_menu = value;
                bid_menu = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo Id_MenuPadre
        /// </summary>
        public int Id_MenuPadre
        {
            get
            {
                return id_menupadre;
            }
            set
            {
                id_menupadre = value;
                bid_menupadre = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo DescripcionMenu
        /// </summary>
        public string DescripcionMenu
        {
            get
            {
                return descripcionmenu;
            }
            set
            {
                descripcionmenu = value;
                bdescripcionmenu = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo PosicionMenu
        /// </summary>
        public int PosicionMenu
        {
            get
            {
                return posicionmenu;
            }
            set
            {
                posicionmenu = value;
                bposicionmenu = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo HabilitadoMenu
        /// </summary>
        public int HabilitadoMenu
        {
            get
            {
                return habilitadomenu;
            }
            set
            {
                habilitadomenu = value;
                bhabilitadomenu = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo UrlMenu
        /// </summary>
        public string UrlMenu
        {
            get
            {
                return urlmenu;
            }
            set
            {
                urlmenu = value;
                burlmenu = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo FormularioAsociado
        /// </summary>
        public string EtiquetaModulo
        {
            get
            {
                return etiquetamodulo;
            }
            set
            {
                etiquetamodulo = value;
                bEtiquetaModulo = true;
            }
        }

        /// <summary>
        /// Propiedad para el campo id_Perfil
        /// </summary>
        public int Id_Perfil
        {
            get
            {
                return id_perfil;
            }
            set
            {
                id_perfil = value;
                bid_perfil = true;
            }
        }

        /// <summary>
        /// Propiedad para estalecer condicion adicional de busqueda
        /// </summary>
        public string CondicionAdicional
        {
            get
            {
                return condicionadicional;
            }
            set
            {
                condicionadicional = value;
            }
        }

        #endregion

    }
}
