//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaWEB.Ferretero.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProducto()
        {
            this.tbVentaDetalle = new HashSet<tbVentaDetalle>();
        }
    
        public int IdProducto { get; set; }
        public string NombreProd { get; set; }
        public decimal PrecioUnit { get; set; }
        public int Stock { get; set; }
        public int IdTipoProd { get; set; }
    
        public virtual tbTipoProducto tbTipoProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbVentaDetalle> tbVentaDetalle { get; set; }
    }
}