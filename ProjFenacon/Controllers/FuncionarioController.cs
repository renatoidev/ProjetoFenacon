using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Modelos;
using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Interfaces;
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
            [FromServices] IRepositorio<Funcionario> funcionarioRepositorio,
            [FromBody] CadastrarFuncionarioModel cadastrarFuncionarioModel)
        {

            switch (cadastrarFuncionarioModel.Cargo)
            {
                case ECargo.Estagiario:
                    {
                        var supervisor = funcionarioRepositorio.GetByName(cadastrarFuncionarioModel.Nome);
                        var funcionario = new Estagiario(supervisor.Analista)
                        {
                            Nome = cadastrarFuncionarioModel.Nome,
                            CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                            Cargo = cadastrarFuncionarioModel.Cargo,
                            Cpf = cadastrarFuncionarioModel.Cpf,
                            DataAdmissao = cadastrarFuncionarioModel.DataAdmissao,
                            Endereco = cadastrarFuncionarioModel.Endereco,
                            Situacao = cadastrarFuncionarioModel.Situacao,
                            Supervisor = new Analista
                            {
                                Id = supervisor.Id
                            }
                            
                        };

                        funcionarioRepositorio.Add(funcionario);
                        funcionarioRepositorio.SaveChanges();
                        return Ok(funcionario);
                    }

                case ECargo.Tecnico:
                    {
                        var supervisor = funcionarioRepositorio.GetByName(cadastrarFuncionarioModel.Nome);
                        var funcionario = new Tecnico(supervisor.Analista)
                        {
                            Nome = cadastrarFuncionarioModel.Nome,
                            CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                            Cargo = cadastrarFuncionarioModel.Cargo,
                            Cpf = cadastrarFuncionarioModel.Cpf,
                            DataAdmissao = cadastrarFuncionarioModel.DataAdmissao,
                            Endereco = cadastrarFuncionarioModel.Endereco,
                            Situacao = cadastrarFuncionarioModel.Situacao,
                            Supervisor = new Analista
                            {
                                Id = supervisor.Id
                            }
                        };
                        funcionarioRepositorio.Add(funcionario);
                        funcionarioRepositorio.SaveChanges();
                        return Ok(funcionario);
                    }
                case ECargo.Analista:
                    {
                        var supervisor = funcionarioRepositorio.GetByName(cadastrarFuncionarioModel.Nome);
                        var funcionario = new Analista(supervisor.Gerente)
                        {
                            Nome = cadastrarFuncionarioModel.Nome,
                            CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                            Cargo = cadastrarFuncionarioModel.Cargo,
                            Cpf = cadastrarFuncionarioModel.Cpf,
                            DataAdmissao = cadastrarFuncionarioModel.DataAdmissao,
                            Endereco = cadastrarFuncionarioModel.Endereco,
                            Situacao = cadastrarFuncionarioModel.Situacao,
                            Supervisor = new Gerente
                            {
                                Id = supervisor.Id
                            }
                        };
                        funcionarioRepositorio.Add(funcionario);
                        funcionarioRepositorio.SaveChanges();
                        return Ok(funcionario);
                    }
                case ECargo.Gerente:
                    {
                        var funcionario = new Gerente()
                        {
                            Nome = cadastrarFuncionarioModel.Nome,
                            CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                            Cargo = cadastrarFuncionarioModel.Cargo,
                            Cpf = cadastrarFuncionarioModel.Cpf,
                            DataAdmissao = cadastrarFuncionarioModel.DataAdmissao,
                            Endereco = cadastrarFuncionarioModel.Endereco,
                            Situacao = cadastrarFuncionarioModel.Situacao,
                        };

                        funcionarioRepositorio.Add(funcionario);
                        funcionarioRepositorio.SaveChanges();
                        return Ok(funcionario);
                    }
                default:
                    return BadRequest(new { message = "Erro ao cadastrar funcionário" });
            }
        }
    };



}
