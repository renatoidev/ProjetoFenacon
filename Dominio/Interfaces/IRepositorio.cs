using Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepositorio<T> 
         where T : Entity
    {
        void Add(T obj);
        int SaveChanges();
        List<T> GetAll();
        List<T> GetAllFerias();
        T GetById(Guid id);
        T GetByName(string nome);
        void Remove(Guid id);

    }
}

