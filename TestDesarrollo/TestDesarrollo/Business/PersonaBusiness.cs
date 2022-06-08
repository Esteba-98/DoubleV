namespace Business
{
    using Entities;
    using Microsoft.Data.SqlClient;
    using Repository;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    public class PersonaBusiness : IPersona
    {
        private IUnitOfWork _unit;
        public PersonaBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }

        public void Insertar(Personas persona)
        {
            persona.NombreCompleto = persona.Nombres + " " + persona.Apellidos;
            persona.TipoNumeroIdentificacion = persona.TipoIdentificacion + " " + persona.NumeroIdentificacion;
            persona.FechaCreacion = DateTime.Now;
            this._unit.GenericRepository<Personas>().Insert(persona);
        }

        public IEnumerable<Personas> Obtener()
        {
            var lstPersonas = this._unit.GenericRepository<Personas>().Get();
            return lstPersonas;
        }

        public Personas ObtenerById(int id)
        {
            Personas persona = this._unit.GenericRepository<Personas>().GetByID(id);
            return persona;
        }
        public void Actualizar(Personas persona)
        {
            persona.NombreCompleto = persona.Nombres + " " + persona.Apellidos;
            persona.TipoNumeroIdentificacion = persona.TipoIdentificacion + " " + persona.NumeroIdentificacion;
            this._unit.GenericRepository<Personas>().Update(persona);
        }

    }
}
