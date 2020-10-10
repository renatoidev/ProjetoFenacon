using Fenacon.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class CadastrarSupervisorModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public TimeSpan CargaHoraria { get; set; } = new TimeSpan(40, 0, 0);
        public DateTime DataAdmissao { get; set; } = DateTime.Now;
        public ESituacao Situacao { get; set; } = ESituacao.Ativo;
    }
}
