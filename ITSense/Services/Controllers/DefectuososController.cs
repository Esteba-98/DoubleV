namespace Services.Controllers
{
    using Business;
    using Data;
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    using Repository;
    using System.Collections.Generic;
    [ApiController]
    [Route("[controller]")]
    public class DefectuososController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            DefectuososBusiness movimiento = new DefectuososBusiness(unitOfWork);
            return movimiento.Obtener();
        }
        [HttpPost]
        public void Insertar(Stock movimientoEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            DefectuososBusiness movimiento = new DefectuososBusiness(unitOfWork);
            movimiento.Insertar(movimientoEntity);
            unitOfWork.SaveTransaction();
        }
    }
}
