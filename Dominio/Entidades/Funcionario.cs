using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Fenacon.Dominio
{
    public class Funcionario : Entity
    {
        public Funcionario(){}
        public Funcionario(string nome, string cpf, string endereco, ECargo cargo, decimal cargaHoraria, DateTime dataAdmissao, ESituacao situacao)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Cargo = cargo;
            CargaHoraria = cargaHoraria;
            DataAdmissao = dataAdmissao;
            Situacao = situacao;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public decimal CargaHoraria { get; set; } 
        public DateTime DataAdmissao { get; set; } 
        public ESituacao Situacao { get; set; }
        public Guid? IdSupervisor { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
