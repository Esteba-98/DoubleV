namespace Business
{
    using Entities;
    using Repository;
    using System.Collections.Generic;
    public class ProductoBusiness : IProducto
    {
        private IUnitOfWork _unit;
        public ProductoBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public void Actualizar(Productos producto)
        {
            this._unit.GenericRepository<Productos>().Update(producto);
        }

        public void Eliminar(int idProducto)
        {
            this._unit.GenericRepository<Productos>().Delete(idProducto);
        }

        public void Insertar(Productos producto)
        {
            this._unit.GenericRepository<Productos>().Insert(producto);
        }
        public IEnumerable<Productos> Obtener()
        {
            var lstProductos = this._unit.GenericRepository<Productos>().Get();
            return lstProductos;
        }
    }
}
