using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominio.Entidades
{
    public class Tecnico : Funcionario
    {
        public Guid IdSupervisor { get; set; }
        public Analista Supervisor { get; set; }

        public Tecnico()
        {
        }
        public Tecnico(Analista supervisor) : base ()
        {
            Supervisor = supervisor;
            IdSupervisor = supervisor.Id;
        }

    }
}
