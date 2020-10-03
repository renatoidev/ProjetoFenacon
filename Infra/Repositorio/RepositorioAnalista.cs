using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio
{
    public class RepositorioAnalista : RepositorioBase<Analista>, IAnalista
    {
        public RepositorioAnalista(Contexto contexto) : base(contexto)
        {
        }

        //public Analista GetByName(string nome)
        //{
        //    return DbSet.Where(x => x.Nome == nome)
        //        .FirstOrDefault();
        //}
    }
}
