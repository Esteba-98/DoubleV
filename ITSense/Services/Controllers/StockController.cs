using Business;
using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StockDTO> Get()
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            StockBusiness stock = new StockBusiness(unitOfWork);
            return stock.Obtener();
        }
        [HttpPost]
        public void Insertar(Stock movimientoEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            StockBusiness stock = new StockBusiness(unitOfWork);
            stock.Insertar(movimientoEntity);
            unitOfWork.SaveTransaction();
        }
        [HttpPut]
        public void Actualizar(Stock movimientoEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            StockBusiness stock = new StockBusiness(unitOfWork);
            stock.Actualizar(movimientoEntity);
            unitOfWork.SaveTransaction();
        }
    }
}
