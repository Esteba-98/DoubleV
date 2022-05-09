namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Stock
    {
        [Key]
        public int IdProducto { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
