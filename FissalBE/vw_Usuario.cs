//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FissalBE
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Usuario
    {
        public int id_usuario { get; set; }
        public int id_perfil { get; set; }   // Agregado: 09.10.2014 - FVergara
        public string login { get; set; }
        public string nombre_completo { get; set; }
        public Nullable<byte> nivel { get; set; }
        public Nullable<int> EstablecimientoId { get; set; }
        public Nullable<bool> activo { get; set; }
        public string password { get; set; }
        public string Descripcion { get; set; }
    }
}
