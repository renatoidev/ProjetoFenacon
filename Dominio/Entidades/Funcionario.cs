using System;

namespace Fenacon.Dominio
{
    public class Funcionario : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public TimeSpan CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ESituacao Situacao { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public Guid IdSupervisor { get; set; }
        public virtual Ferias Ferias { get; set; }
        public Guid IdFerias { get; set; }
        public Funcionario()
        {
        }

        public Funcionario(string nome, string cpf, string endereco, ECargo cargo, TimeSpan cargaHoraria, DateTime dataAdmissao, ESituacao situacao)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Cargo = cargo;
            CargaHoraria = cargaHoraria;
            DataAdmissao = dataAdmissao;
            Situacao = situacao;
        }
    }
}
