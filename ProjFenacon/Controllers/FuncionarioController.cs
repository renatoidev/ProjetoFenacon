using Dominio.Entidades;
using Dominio.Modelos;
using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Interfaces;
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

            if(cadastrarFuncionarioModel.Cargo != ECargo.Gerente)
            {

                var funcionario = new Funcionario()
                {
                    Nome = cadastrarFuncionarioModel.Nome,
                    CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                    Cargo = cadastrarFuncionarioModel.Cargo,
                    Cpf = cadastrarFuncionarioModel.Cpf,
                    DataAdmissao = cadastrarFuncionarioModel.DataAdmissao,
                    Endereco = cadastrarFuncionarioModel.Endereco,
                    Situacao = cadastrarFuncionarioModel.Situacao,
                    Supervisor = new Supervisor
                    {
                        Nome = cadastrarFuncionarioModel.Supervisor.Nome,
                        CargaHoraria = cadastrarFuncionarioModel.Supervisor.CargaHoraria,
                        Cargo = cadastrarFuncionarioModel.Supervisor.Cargo,
                        Cpf = cadastrarFuncionarioModel.Supervisor.Cpf,
                        DataAdmissao = cadastrarFuncionarioModel.Supervisor.DataAdmissao,
                        Endereco = cadastrarFuncionarioModel.Supervisor.Endereco,
                        Situacao = cadastrarFuncionarioModel.Supervisor.Situacao
                    }
                };

                funcionarioRepositorio.Add(funcionario);
                funcionarioRepositorio.SaveChanges();
                return Ok(funcionario);
            }

            else
            {
                var funcionario = new Funcionario()
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
        }
    }
}
