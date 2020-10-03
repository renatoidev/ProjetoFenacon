using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Tecnico : Funcionario
    {
        public Analista Supervisor { get; set; }

        public Tecnico()
        {
        }
        public Tecnico(Analista supervisor) : base ()
        {
            Supervisor = supervisor;
        }

    }
}
