using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Estagiario : Funcionario
    {
        public Analista Supervisor { get; set; }

        public Estagiario()
        {
        }
        public Estagiario(Analista supervisor) : base ()
        {
            Supervisor = supervisor;
        }

    }
}
