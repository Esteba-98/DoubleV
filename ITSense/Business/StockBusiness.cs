namespace Business
{
    using Entities;
    using Repository;
    using System.Collections.Generic;
    using System.Linq;

    public class StockBusiness : IStock
    {
        private IUnitOfWork _unit;
        public StockBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public void Actualizar(Stock stock)
        {
            this._unit.GenericRepository<Stock>().Update(stock);
        }

        public void Insertar(Stock stock)
        {
            this._unit.GenericRepository<Stock>().Insert(stock);
        }

        public IEnumerable<StockDTO> Obtener()
        {
            //var lstStock = this._unit.GenericRepository<Stock>().Get();
            var StockProductos = from product in this._unit.GenericRepository<Productos>().Get().AsEnumerable()
                                 join stock in this._unit.GenericRepository<Stock>().Get().AsEnumerable() on
                                 product.IdProducto equals stock.IdProducto
                                 select new StockDTO()
                                 {
                                     IdProducto = product.IdProducto,
                                     Producto = product.Producto,
                                     Codigo = product.Codigo,
                                     Estado = product.Estado,
                                     CantidadDisponible = stock.CantidadDisponible
                                 };
            return StockProductos;
        }
    }
}
