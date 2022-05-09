namespace Business
{
    using Entities;
    using System.Collections.Generic;
    public interface IDefectuosos
    {
        void Insertar(Stock movimiento);
        IEnumerable<Stock> Obtener();
    }
}
