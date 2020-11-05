using Fenacon.Dominio;
using System;
using System.Collections.Generic;

namespace Dominio.Modelos
{
    public class ListarGerenteModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public decimal CargaHoraria { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ESituacao Situacao { get; set; }
        public List<ListarSubordinadoModel> Subordinados { get; set; } = new List<ListarSubordinadoModel>();
    }
}
