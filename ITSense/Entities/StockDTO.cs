using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class StockDTO
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
