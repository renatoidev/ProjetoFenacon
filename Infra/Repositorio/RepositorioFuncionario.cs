using Dominio.Entidades;
using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>, IFuncionario
    {
        

        public RepositorioFuncionario(Contexto contexto) : base(contexto)
        {
        }

        public Funcionario GetByName(string nome)
        {
            return DbSet.Where(x => x.Nome == nome)
                .Include(x => x.Gerente)
                .Include(x => x.Analista)
                .FirstOrDefault();
        }
    }
}
