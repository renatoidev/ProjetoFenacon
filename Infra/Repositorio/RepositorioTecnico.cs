using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioTecnico : RepositorioBase<Tecnico>, ITecnico
    {
        public RepositorioTecnico(Contexto contexto) : base(contexto)
        {
        }
    }
}
