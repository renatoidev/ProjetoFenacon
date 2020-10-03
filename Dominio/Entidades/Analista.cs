using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Analista : Funcionario
    {
        public Gerente Supervisor { get; set; }
        public IEnumerable<Estagiario> Estagiarios { get; set; }
        public IEnumerable<Tecnico> Tecnicos { get; set; }

        public Analista()
        {
        }
        public Analista(Gerente supervisor) : base() {
            Supervisor = supervisor;
        }
    }
}
