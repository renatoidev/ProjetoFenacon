using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioGerente : IRepositorio<Gerente>, IGerente
    {
        

        public void Add(Gerente obj)
        {
            throw new NotImplementedException();
        }

        public List<Gerente> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Gerente> GetAllFerias()
        {
            throw new NotImplementedException();
        }

        public Gerente GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Gerente GetByName(string nome)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
