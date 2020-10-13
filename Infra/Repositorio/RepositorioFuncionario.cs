using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace Infra.Repositorio
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>, IFuncionario
    {
        public RepositorioFuncionario(Contexto contexto) : base(contexto) { }
        public List<Funcionario> GetAllEstagiarios()
        {
            var estagiarios = DbSet.Where(y => y.Cargo == ECargo.Estagiario).Include(x => x.Funcionarios).ThenInclude(x => x.Funcionarios).ToList();

            foreach (var item in estagiarios)
            {
                var supervisor = GetById(item.IdSupervisor);

                item.Funcionarios.Add(supervisor);
            }
            return estagiarios;
        }
        public List<Funcionario> GetAllFuncionarios() 
        {
            var teste = DbSet.ToList();

            return teste;
            
            
        }
        
        
        public List<Funcionario> GetAllSupervisores() => DbSet.Include(x => x.Funcionarios).Where(x => x.Funcionarios.Count > 0).ToList();
        public Funcionario GetById(Guid? id) => DbSet.Where(x => x.Id == id).FirstOrDefault();
    }
}
