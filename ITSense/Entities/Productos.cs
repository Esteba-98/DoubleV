namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
    }
}
