namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Defectuosos
    {
        [Key]
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
