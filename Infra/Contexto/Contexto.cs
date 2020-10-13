using Fenacon.Dominio;
using Infra.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto(){}
        public Contexto(DbContextOptions<Contexto> options) : base (options){}
        public DbSet<Funcionario> Funcionarios{ get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) => base.OnConfiguring(optionsBuilder);
        
    }
}
