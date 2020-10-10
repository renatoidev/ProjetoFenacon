using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using System;
using System.Linq;

namespace Infra.Repositorio
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>, IFuncionario
    {


        public RepositorioFuncionario(Contexto contexto) : base(contexto)
        {
        }

        public Funcionario GetById(Guid id)
        {
            return DbSet.Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}
