using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Gerente : Funcionario
    {
        public IEnumerable<Analista> Analistas { get; set; }

        public Gerente()
        {
            
        }
    }
}
