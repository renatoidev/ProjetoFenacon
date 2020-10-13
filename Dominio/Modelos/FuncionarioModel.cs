using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class FuncionarioModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cargo { get; set; }
        public decimal CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Situacao { get; set; }
    }
}
