using Domain.Entidades;
using Fenacon.Dominio;
using System;

namespace Dominio.Entidades
{
    public class Ferias: Entity
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime PeriodoAquisitivo { get; set; }
    }
}
