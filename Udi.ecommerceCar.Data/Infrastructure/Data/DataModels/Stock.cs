//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Udi.ecommerceCar.Data.Infrastructure.Data.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int LoteProductoID { get; set; }
        public Nullable<int> Stock1 { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> ProductoID { get; set; }
        public Nullable<int> CantidadIngreso { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}