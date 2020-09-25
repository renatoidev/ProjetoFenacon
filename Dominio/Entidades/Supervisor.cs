using System.Collections.Generic;

namespace Fenacon.Dominio
{
    public class Supervisor : Entity
    {
        public string Nome { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }


        public Supervisor()
        {
        }

    }
}