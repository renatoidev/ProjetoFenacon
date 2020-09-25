using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

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
        void Remove(Guid id);

    }
}

