﻿using Fenacon.Dominio;
using System;

namespace Dominio.Modelos
{
    public class CadastrarGerenteModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public ECargo Cargo { get; set; }
        public decimal CargaHoraria { get; set; } 
        public DateTime DataAdmissao { get; set; } = DateTime.Now.ToLocalTime();
        public ESituacao Situacao { get; set; } = ESituacao.Ativo;

    }
}
