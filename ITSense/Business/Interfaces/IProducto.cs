namespace Business
{
    using Entities;
    using System.Collections.Generic;
    public interface IProducto
    {
        void Insertar(Productos producto);
        void Eliminar(int idProducto);
        void Actualizar(Productos producto);
        IEnumerable<Productos> Obtener();
    }
}
