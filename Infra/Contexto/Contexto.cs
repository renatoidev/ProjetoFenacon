using Fenacon.Dominio;
using Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options) : base (options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<Supervisor> Supervisores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            modelBuilder.ApplyConfiguration(new FeriasMapping());
            modelBuilder.ApplyConfiguration(new SupervisorMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        
    }
}
