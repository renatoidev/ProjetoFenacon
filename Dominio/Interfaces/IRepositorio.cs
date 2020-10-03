using Dominio.Entidades;
using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IRepositorio<T>
         where T : Funcionario
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

