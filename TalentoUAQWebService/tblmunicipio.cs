//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TalentoUAQWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmunicipio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblmunicipio()
        {
            this.tblofertas = new HashSet<tbloferta>();
        }
    
        public int cveMunicipio { get; set; }
        public string descMunicipio { get; set; }
        public Nullable<int> cveEstado { get; set; }
        public string activo { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public Nullable<System.DateTime> fechaActualizacion { get; set; }
    
        public virtual tblestado tblestado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbloferta> tblofertas { get; set; }
    }
}
