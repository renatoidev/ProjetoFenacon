using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioEstagiario: RepositorioBase<Estagiario>, IEstagiario
    {
        public RepositorioEstagiario(Contexto contexto) : base(contexto)
        {
        }
    }
}
