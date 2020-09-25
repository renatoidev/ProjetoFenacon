using System;
using System.Collections.Generic;
using System.Text;

namespace Fenacon.Dominio
{
    public class Ferias : Entity
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime PeriodoAquisitivo { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }


        public Ferias()
        {
        }
    }
}
