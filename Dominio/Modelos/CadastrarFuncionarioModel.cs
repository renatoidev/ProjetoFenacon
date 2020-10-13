﻿using Fenacon.Dominio;
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
        public decimal CargaHoraria { get; set; } 
        public DateTime DataAdmissao { get; set; } 
        public ESituacao Situacao { get; set; } 
        public Guid IdSupervisor { get; set; }
    }
}
