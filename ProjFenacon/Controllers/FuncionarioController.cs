using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Dominio.Modelos;
using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjFenacon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionario _funcionarioRepositorio;

        public FuncionarioController(IFuncionario funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        [HttpPost]
        [Route("cadastrarFuncionario")]
        public IActionResult CadastrarFuncionario(
            [FromServices] IFuncionario funcionarioRepositorio,
            [FromBody] CadastrarFuncionarioModel cadastrarFuncionarioModel)
        {

            var funcionario = new Funcionario
            {
                Nome = cadastrarFuncionarioModel.Nome,
                CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                Cargo = cadastrarFuncionarioModel.Cargo,
                Cpf = cadastrarFuncionarioModel.Cpf,
                DataAdmissao = cadastrarFuncionarioModel.DataAdmissao,
                Endereco = cadastrarFuncionarioModel.Endereco,
                Situacao = cadastrarFuncionarioModel.Situacao,
                IdSupervisor = cadastrarFuncionarioModel.IdSupervisor,
            };
            
            funcionarioRepositorio.Add(funcionario);
            funcionarioRepositorio.SaveChanges();
            return Ok(funcionario);
            
        }
    };



}
