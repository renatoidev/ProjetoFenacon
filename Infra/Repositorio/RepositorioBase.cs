using Dominio.Entidades;
using Fenacon.Dominio;
using Infra.Contextos;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioBase<T> : IRepositorio<T>
        where T : Funcionario
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<T> DbSet;

        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<T>();
        }

        public void Add(T obj)
        {
            _contexto.Add(obj);
        }

        public int SaveChanges()
        {
            return _contexto.SaveChanges();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllFerias()
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public T GetByName(string nome)
        {
            return DbSet.Where(x => x.Nome == nome)
                .FirstOrDefault();
        }
    }
}
