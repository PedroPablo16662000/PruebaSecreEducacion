//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiRest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TiposIdentificacion
    {
        public TiposIdentificacion()
        {
            this.Contactos = new HashSet<Contactos>();
        }
    
        public int idTipoIdentificacion { get; set; }
        public string nombreTipoIdentificacion { get; set; }
    
        public virtual ICollection<Contactos> Contactos { get; set; }
    }
}
