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
    
    public partial class tbVentaDetalle
    {
        public int IdVentaDet { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    
        public virtual tbProducto tbProducto { get; set; }
        public virtual tbVenta tbVenta { get; set; }
    }
}
