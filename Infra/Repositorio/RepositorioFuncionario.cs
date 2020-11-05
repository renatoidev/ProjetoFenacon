using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositorio
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>, IFuncionario
    {
        public RepositorioFuncionario(Contexto contexto) : base(contexto) { }
        

        public List<Funcionario> GetSupervisorById(Guid id)
        {
            return DbSet.Where(x => x.Id == id).ToList();
        }
        
        public Funcionario GetById(Guid? id) => DbSet.Where(x => x.Id == id).FirstOrDefault();

        public Funcionario GetByName(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
