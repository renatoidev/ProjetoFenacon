using Domain.Entidades;
using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Supervisor : Entity
    {
        public Supervisor()
        {
        }

        public Supervisor(string nome, string cpf, string endereco, ECargo cargo, TimeSpan cargaHoraria, DateTime dataAdmissao, ESituacao situacao)
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
        public TimeSpan CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ESituacao Situacao { get; set; }
        public Guid IdFuncionario { get; set; }
        public IEnumerable<Funcionario> Funcionarios { get; set; }
    }
}
