using Dominio.Entidades;
using Fenacon.Dominio;
using Infra.Mapeamento;
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

        public DbSet<Analista> Analistas { get; set; }
        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GerenteMapping());
            modelBuilder.ApplyConfiguration(new AnalistaMapping());
            modelBuilder.ApplyConfiguration(new TecnicoMapping());
            modelBuilder.ApplyConfiguration(new EstagiarioMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        
    }
}
