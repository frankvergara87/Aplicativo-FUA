using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data;
using System.Data.SqlClient;

namespace FissalDA
{
    public class PerfilDA
    {
        static SqlCommand cmd = new SqlCommand();

        // Cargo Elementos para el combo Perfiles
        public DataTable Listar_PerfilesFull()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Obtener_PerfilesFull]";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Cargo Elementos para el combo Perfiles x Establecimiento
        public DataTable Listar_PerfilesFullxEstablecimiento(int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Obtener_PerfFullxEstab]";
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Cargo Elementos para el combo Perfiles x Id.Perfil
        public DataTable Listar_Perfiles(int Id_Perfil)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_perfiles_Obtener_Perfiles";
            cmd.Parameters.AddWithValue("@Id_Perfil", Id_Perfil);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Cargo Elementos TreeView Perfiles - Padre
        public DataTable Listar_Perfiles_Padre(int IdPerfil)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Perfiles_PermisosPerfil_Padre";
            cmd.Parameters.AddWithValue("@Id_Perfil", IdPerfil);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Cargo Elementos TreeView Perfiles - Hijo
        public DataTable Listar_Perfiles_Hijo(int Id_MenuPadre)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_Perfiles_PermisosPerfil_Hijo";
            cmd.Parameters.AddWithValue("@Id_MenuPadre", Id_MenuPadre);
            return Datos.ObtenerDatosProcedure(cmd);
        }




        // Cargo Elementos para el combo Modulos
        public DataTable Listar_Modulos()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Obtener_Modulos]";
            return Datos.ObtenerDatosProcedure(cmd);
        }

        // Cargo Elementos Perfiles x Modulo
        public DataTable Listar_PerfilesxModulo(string DescripcionMenu)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Obtener_PerfilesxModulo]";
            cmd.Parameters.AddWithValue("@DescripcionMenu", DescripcionMenu);
            return Datos.ObtenerDatosProcedure(cmd);
        }
 
        // Cargo Elementos Modulos
        public DataTable Listar_MenusxModulos(string DescripcionMenu)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_perfiles_Obtener_MenusxModulo]";
            cmd.Parameters.AddWithValue("@DescripcionMenu", DescripcionMenu);
            return Datos.ObtenerDatosProcedure(cmd);
        }

    }
}
