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
        

        public RepositorioFuncionario(Contexto contexto) : base(contexto)
        {
        }
    }
}
