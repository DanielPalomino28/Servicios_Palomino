//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios_Palomino.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTura()
        {
            this.DEtalleFActuras = new HashSet<DEtalleFActura>();
        }
    
        public int Numero { get; set; }
        public string Documento { get; set; }
        public System.DateTime Fecha { get; set; }
        public int CodigoEmpleado { get; set; }
    
        public virtual CLIEnte CLIEnte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEtalleFActura> DEtalleFActuras { get; set; }
        public virtual EMpleadoCArgo EMpleadoCArgo { get; set; }
    }
}