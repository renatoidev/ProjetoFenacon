using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IUsuario
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Usuario> DbSet;

        public RepositorioUsuario(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Usuario>();
        }
    }
}
