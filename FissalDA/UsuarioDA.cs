using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalBE;
using System.Data.Common;

namespace FissalDA
{
    public class UsuarioDA
    {

        static SqlCommand cmd = new SqlCommand();


        public DataTable usuarioLogin(Usuario u)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "sp2_usuario_login";
            cmd.Parameters.AddWithValue("@login", u.login);
            cmd.Parameters.AddWithValue("@password", u.password);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public DataTable Listar_Usuarios(string Usuario, int EstablecimientoId)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_usuarios_Obtener_Usuarios]";
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@EstablecimientoId", EstablecimientoId);
            return Datos.ObtenerDatosProcedure(cmd);
        }

        public int Registrar_Usuarios(vw_Usuario Usuario)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_usuarios_Registrar_Usuarios]";
            //cmd.Parameters.AddWithValue("@id_usuario", Usuario.id_usuario);
            cmd.Parameters.AddWithValue("@login", Usuario.login);
            cmd.Parameters.AddWithValue("@nombre_completo", Usuario.nombre_completo);
            cmd.Parameters.AddWithValue("@password", Usuario.password);
            cmd.Parameters.AddWithValue("@id_perfil", Usuario.id_perfil);
            cmd.Parameters.AddWithValue("@EstablecimientoId", Usuario.EstablecimientoId);
            return Datos.Mantenimiento(cmd);
        }

        public int Actualizar_Usuarios(vw_Usuario Usuario)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_usuarios_Actualizar_Usuarios]";
            cmd.Parameters.AddWithValue("@id_usuario", Usuario.id_usuario);
            cmd.Parameters.AddWithValue("@login", Usuario.login);
            cmd.Parameters.AddWithValue("@nombre_completo", Usuario.nombre_completo);
            cmd.Parameters.AddWithValue("@password", Usuario.password);
            cmd.Parameters.AddWithValue("@id_perfil", Usuario.id_perfil);
            cmd.Parameters.AddWithValue("@EstablecimientoId", Usuario.EstablecimientoId);
            return Datos.Mantenimiento(cmd);
        }

        public int Eliminar_Usuarios(int Id_Usuario)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "[sp2_usuarios_Eliminar_Usuarios]";
            cmd.Parameters.AddWithValue("@id_usuario", Id_Usuario);
            return Datos.Mantenimiento(cmd);
        }

    
    }


}
