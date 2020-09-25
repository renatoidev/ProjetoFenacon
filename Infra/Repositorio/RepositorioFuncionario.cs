using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>, IFuncionario
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Funcionario> DbSet;

        public RepositorioFuncionario(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Funcionario>();
        }
    }
}
