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
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Productos> Get()
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            ProductoBusiness producto = new ProductoBusiness(unitOfWork);
            return producto.Obtener();
        }
        [HttpPost]
        public void Insertar(Productos movimientoEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            ProductoBusiness producto = new ProductoBusiness(unitOfWork);
            producto.Insertar(movimientoEntity);
            unitOfWork.SaveTransaction();
        }
        [HttpPut]
        public void Actualizar(Productos movimientoEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            ProductoBusiness producto = new ProductoBusiness(unitOfWork);
            producto.Actualizar(movimientoEntity);
            unitOfWork.SaveTransaction();
        }
        [HttpDelete]
        public void Eliminar(Productos movimientoEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            ProductoBusiness producto = new ProductoBusiness(unitOfWork);
            var idProducto =  producto.Obtener().FirstOrDefault().IdProducto;
            producto.Eliminar(idProducto);
            unitOfWork.SaveTransaction();
        }
    }
}
