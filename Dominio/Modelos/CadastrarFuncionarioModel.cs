using Dominio.Entidades;
using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class CadastrarFuncionarioModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public TimeSpan CargaHoraria { get; set; } = new TimeSpan(40,0,0);
        public DateTime DataAdmissao { get; set; } = DateTime.Now;
        public ESituacao Situacao { get; set; } = ESituacao.Ativo;
        public Guid IdSupervisor { get; set; }

    }
}
