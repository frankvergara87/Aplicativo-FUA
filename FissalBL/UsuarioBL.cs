using FissalBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FissalDA;

namespace FissalBL
{
    public class UsuarioBL
    {

        UsuarioDA objUsuarioDA = new UsuarioDA();
       
        public DataTable usuarioLogin(Usuario u)
        {
            return objUsuarioDA.usuarioLogin(u);
        }

        public DataTable Listar_Usuarios(string Usuario, int EstablecimientoId)
        {
            return objUsuarioDA.Listar_Usuarios(Usuario, EstablecimientoId);
        }

        public int Registrar_Usuarios(vw_Usuario Usuario)
        {
            return objUsuarioDA.Registrar_Usuarios(Usuario);
        }

        public int Actualizar_Usuarios(vw_Usuario Usuario)
        {
            return objUsuarioDA.Actualizar_Usuarios(Usuario);
        }

        public int Eliminar_Usuarios(int Id_Usuario)
        {
            return objUsuarioDA.Eliminar_Usuarios(Id_Usuario);
        }

    }
}
