using Business;
using Data;
using Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Personas> Get()
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            PersonaBusiness persona = new PersonaBusiness(unitOfWork);
            return persona.Obtener();
        }
        [HttpPost]
        public void Insertar(Personas personaEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            PersonaBusiness persona = new PersonaBusiness(unitOfWork);
            persona.Insertar(personaEntity);
            unitOfWork.SaveTransaction(); 
        }
        [HttpGet("/GetById/{id}")]
        public Personas GetById(int id)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            PersonaBusiness persona = new PersonaBusiness(unitOfWork);
            return persona.ObtenerById(id);
        }
        [HttpPut]
        public void Actualizar(Personas personaEntity)
        {
            ContextDB context = new ContextDB();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            PersonaBusiness persona = new PersonaBusiness(unitOfWork);
            persona.Actualizar(personaEntity);
            unitOfWork.SaveTransaction();
        }
    }
}
