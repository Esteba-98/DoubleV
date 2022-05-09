namespace Business
{
    using Entities;
    using System.Collections.Generic;
    public interface IStock
    {
        void Insertar(Stock stock);
        void Actualizar(Stock stock);
        IEnumerable<StockDTO> Obtener();
    }
}
