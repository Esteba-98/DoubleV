namespace Business
{
    using Entities;
    using Repository;
    using System.Collections.Generic;
    public class DefectuososBusiness : IDefectuosos
    {
        private IUnitOfWork _unit;
        public DefectuososBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }

        public void Insertar(Stock movimiento)
        {
            this._unit.GenericRepository<Stock>().Insert(movimiento);
            var producto = this._unit.GenericRepository<Stock>().FindSingleBy(x => x.IdProducto == movimiento.IdProducto);
            //producto.CantidadDisponible = producto.CantidadDisponible - movimiento.Cantidad;
            this._unit.GenericRepository<Stock>().Update(producto);
        }

        public IEnumerable<Stock> Obtener()
        {
            var lstMovimientos = this._unit.GenericRepository<Stock>().Get();
            return lstMovimientos;
        }
    }
}
