using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class EstagiarioListModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cargo { get; set; }
        public DateTime CargaHoraria { get; set; } 
        public DateTime DataAdmissao { get; set; }
        public string Situacao { get; set; }
        public Guid? IdSupervisor { get; set; }
        public FuncionarioModel Supervisor { get; set; }

    }
}
