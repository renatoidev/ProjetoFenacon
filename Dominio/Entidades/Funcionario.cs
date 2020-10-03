using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Fenacon.Dominio
{
    public class Funcionario
    {

        public Funcionario()
        {
        }

        public Funcionario(string nome, string cpf, string endereco, ECargo cargo, TimeSpan cargaHoraria, DateTime dataAdmissao, ESituacao situacao)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Cargo = Cargo;
            CargaHoraria = cargaHoraria;
            DataAdmissao = dataAdmissao;
            Situacao = situacao;
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public TimeSpan CargaHoraria { get; set; } 
        public DateTime DataAdmissao { get; set; } 
        public ESituacao Situacao { get; set; }
        public virtual Analista Analista { get; set; }
        public virtual Gerente Gerente { get; set; }
    }
}
