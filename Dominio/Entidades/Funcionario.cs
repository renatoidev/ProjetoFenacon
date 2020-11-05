using Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Fenacon.Dominio
{
    public class Funcionario : Entity
    {
        public Funcionario(){}
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public int CargaHoraria { get; set; } 
        public DateTime DataAdmissao { get; set; } 
        public ESituacao Situacao { get; set; }
        public Guid? SupervisorId { get; set; }
        public Funcionario Supervisor { get; set; }
        public List<Funcionario> Subordinados { get; set; }
    }
}
