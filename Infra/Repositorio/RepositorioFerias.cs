using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioFerias : RepositorioBase<Ferias>, IFerias
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Ferias> DbSet;

        public RepositorioFerias(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Ferias>();
        }
    }
}
