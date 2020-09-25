using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioSupervisor : RepositorioBase <Supervisor>, ISupervisor
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<Supervisor> DbSet;

        public RepositorioSupervisor(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<Supervisor>();
        }
    }
}
