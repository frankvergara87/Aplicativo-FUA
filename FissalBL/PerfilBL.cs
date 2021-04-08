using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using FissalDA;

namespace FissalBL
{
    public class PerfilBL
    {
        private PerfilDA objPerfilDA;

        // constructor
        public PerfilBL()
        {
            objPerfilDA = new PerfilDA();
        }

        public DataTable Listar_PerfilesFull()
        {
            return objPerfilDA.Listar_PerfilesFull();
        }

        public DataTable Listar_PerfilesFullxEstablecimiento(int EstablecimientoId)
        {
            return objPerfilDA.Listar_PerfilesFullxEstablecimiento(EstablecimientoId);
        }

        public DataTable Listar_Perfiles(int Id_Perfil)
        {
            return objPerfilDA.Listar_Perfiles(Id_Perfil);
        }


        public DataTable Listar_Perfiles_Padre(int Id_Perfil)
        {
            return objPerfilDA.Listar_Perfiles_Padre(Id_Perfil);
        }

        public DataTable Listar_Perfiles_Hijo(int Id_MenuPadre)
        {
            return objPerfilDA.Listar_Perfiles_Hijo(Id_MenuPadre);
        }


        public DataTable Listar_Modulos()
        {
            return objPerfilDA.Listar_Modulos();
        }

        public DataTable Listar_PerfilesxModulo(string DescripcionMenu)
        {
            return objPerfilDA.Listar_PerfilesxModulo(DescripcionMenu);
        }

        public DataTable Listar_MenusxModulos(string DescripcionMenu)
        {
            return objPerfilDA.Listar_MenusxModulos(DescripcionMenu);
        }

    }
}
