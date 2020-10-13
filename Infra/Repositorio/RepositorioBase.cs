using Domain.Entidades;
using Infra.Contextos;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositorio
{
    public class RepositorioBase<T> : IRepositorio<T>
        where T : Entity
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<T> DbSet;
        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<T>();
        }
        public void Add(T obj) => _contexto.Add(obj);
        public int SaveChanges() => _contexto.SaveChanges();
        public List<T> GetAll() => DbSet.ToList();
        public T GetById(Guid? id) => DbSet.Where(x => x.Id == id).FirstOrDefault();
        
        public void Remove(Guid id)
        {
            var funcionario = GetById(id);
            DbSet.Remove(funcionario);
        }

        public List<T> GetAllFunc() => DbSet.ToList();
        public List<T> GetAllEstagiarios() => DbSet.ToList();
        public List<T> GetAllFuncionarios() => DbSet.ToList();

        public List<T> GetAllSupervisores()
        {
            return DbSet.ToList();
        }
    }
}
