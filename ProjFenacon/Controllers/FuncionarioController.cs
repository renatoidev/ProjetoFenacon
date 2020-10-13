using Dominio.Modelos;
using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ProjFenacon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionario _funcionarioRepositorio;
        public FuncionarioController(IFuncionario funcionarioRepositorio) => _funcionarioRepositorio = funcionarioRepositorio;

        [HttpPost]
        [Route("cadastrarGerente")]
        public IActionResult CadastrarGerente(
            [FromServices] IFuncionario funcionarioRepositorio,
            [FromBody] CadastrarGerenteModel cadastrarFuncionarioModel)
        {

            if(cadastrarFuncionarioModel.Cargo != ECargo.Gerente) return NotFound();
            
            var funcionario = new Funcionario()
            {
                Nome = cadastrarFuncionarioModel.Nome,
                CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                Cargo = cadastrarFuncionarioModel.Cargo,
                Cpf = cadastrarFuncionarioModel.Cpf,
                DataAdmissao = DateTime.Now.ToLocalTime(),
                Endereco = cadastrarFuncionarioModel.Endereco,
                Situacao = cadastrarFuncionarioModel.Situacao,
            };

            funcionarioRepositorio.Add(funcionario);
            funcionarioRepositorio.SaveChanges();
            return Ok(funcionario);
        }

        [HttpPost]
        [Route("cadastrarEstagiário")]
        public IActionResult CadastrarEstagiario(
            [FromServices] IFuncionario funcionarioRepositorio,
            [FromBody] CadastrarFuncionarioModel cadastrarFuncionarioModel)
        {
            if (cadastrarFuncionarioModel.Cargo != ECargo.Estagiario) return NotFound();

            var funcionario = new Funcionario()
            {
                Nome = cadastrarFuncionarioModel.Nome,
                CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                Cargo = cadastrarFuncionarioModel.Cargo,
                Cpf = cadastrarFuncionarioModel.Cpf,
                DataAdmissao = DateTime.Now.ToLocalTime(),
                Endereco = cadastrarFuncionarioModel.Endereco,
                Situacao = cadastrarFuncionarioModel.Situacao,
                IdSupervisor = cadastrarFuncionarioModel.IdSupervisor
            };

            funcionarioRepositorio.Add(funcionario);
            funcionarioRepositorio.SaveChanges();
            return Ok(funcionario);
        }

        [HttpPost]
        [Route("cadastrarAnalista")]
        public IActionResult CadastrarAnalista(
           [FromServices] IFuncionario funcionarioRepositorio,
           [FromBody] CadastrarFuncionarioModel cadastrarFuncionarioModel)
        {
            if (cadastrarFuncionarioModel.Cargo != ECargo.Analista)return NotFound();

            var funcionario = new Funcionario()
            {
                Nome = cadastrarFuncionarioModel.Nome,
                CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                Cargo = cadastrarFuncionarioModel.Cargo,
                Cpf = cadastrarFuncionarioModel.Cpf,
                DataAdmissao = DateTime.Now.ToLocalTime(),
                Endereco = cadastrarFuncionarioModel.Endereco,
                Situacao = cadastrarFuncionarioModel.Situacao,
                IdSupervisor = cadastrarFuncionarioModel.IdSupervisor
            };

            funcionarioRepositorio.Add(funcionario);
            funcionarioRepositorio.SaveChanges();
            return Ok(funcionario);
        }
        
        [HttpPost]
        [Route("cadastrarTecnico")]
        public IActionResult CadastrarTecnico(
           [FromServices] IFuncionario funcionarioRepositorio,
           [FromBody] CadastrarFuncionarioModel cadastrarFuncionarioModel)
        {
            if (cadastrarFuncionarioModel.Cargo != ECargo.Tecnico) return NotFound();

            var supervisor = funcionarioRepositorio.GetById(cadastrarFuncionarioModel.IdSupervisor);

            var funcionario = new Funcionario()
            {
                Nome = cadastrarFuncionarioModel.Nome,
                CargaHoraria = cadastrarFuncionarioModel.CargaHoraria,
                Cargo = cadastrarFuncionarioModel.Cargo,
                Cpf = cadastrarFuncionarioModel.Cpf,
                DataAdmissao = DateTime.Now.ToLocalTime(),
                Endereco = cadastrarFuncionarioModel.Endereco,
                Situacao = cadastrarFuncionarioModel.Situacao,
                IdSupervisor = cadastrarFuncionarioModel.IdSupervisor,
                
            };

            funcionarioRepositorio.Add(funcionario);
            funcionarioRepositorio.SaveChanges();
            return Ok(funcionario);
        }
        
        
        //Listar Funcionarios
        [HttpGet]
        [Route("listarEstagiarios")]
        public IActionResult GetEstagiariosLista([FromServices] IFuncionario repositorio)
        {
            var listaFuncionarios = repositorio.GetAllEstagiarios();

            if (listaFuncionarios == null)
                return default;

            var quantidade = listaFuncionarios.Count();

            var novaLista = listaFuncionarios.Select(x => new EstagiarioListModel
            {
                Nome = x.Nome,
                Cargo = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),
                Cpf = x.Cpf,
                Endereco = x.Endereco,
                Situacao = Enum.Parse(typeof(ESituacao), x.Situacao.ToString()).ToString(),
               Supervisor = new FuncionarioModel
               {
                 Nome = x.Funcionarios.FirstOrDefault().Nome,
                 CargaHoraria = x.Funcionarios.FirstOrDefault().CargaHoraria,
                 Cargo = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),
                 Cpf = x.Funcionarios.FirstOrDefault().Cpf,
                 DataAdmissao = x.Funcionarios.FirstOrDefault().DataAdmissao,
                 Endereco = x.Funcionarios.FirstOrDefault().Endereco,
                 Situacao = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),

               }   

            }).ToList();

            return Ok(new
            {
                quantidasde = quantidade,
                lista = novaLista
            });
        }


        [HttpGet]
        [Route("FuncionarioId")]
        public IActionResult GetFuncionarioPorId([FromServices] IFuncionario repositorio, Guid id)
        {
            var funcionario = repositorio.GetById(id);
            
            if (funcionario == null)
                return default;

            var novoFunc = new FuncionarioModel
            {
                Nome = funcionario.Nome,
                Cargo = Enum.Parse(typeof(ECargo), funcionario.Cargo.ToString()).ToString(),
                Cpf = funcionario.Cpf,
                DataAdmissao = funcionario.DataAdmissao,
                Endereco = funcionario.Endereco,
                CargaHoraria = funcionario.CargaHoraria,
                Situacao = Enum.Parse(typeof(ESituacao), funcionario.Situacao.ToString()).ToString()

            };

            return Ok(new
            {
                novoFunc
            });
           
        }



        [HttpGet]
        [Route("listarSupervisores")]
        public IActionResult GetSupervisores([FromServices] IFuncionario repositorio)
        {
            var listaFuncionarios = repositorio.GetAllFuncionarios();

            if (listaFuncionarios == null)
                return default;

            var quantidade = listaFuncionarios.Count();

            var novaLista = listaFuncionarios.Select(x => new FuncionarioListmodel
            {
                Nome = x.Nome,
                Cargo = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),
                Cpf = x.Cpf,
                Endereco = x.Endereco,
                Situacao = Enum.Parse(typeof(ESituacao), x.Situacao.ToString()).ToString(),
                CargaHoraria = x.CargaHoraria,
                DataAdmissao = DateTime.Now,
                Supervisor = new FuncModel
                {
                    Nome = x.Nome,
                    Cargo = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),
                }

            }).ToList();

            return Ok(new
            {
                quantidasde = quantidade,
                Funcionarios = novaLista
            });
        }






        [HttpGet]
        [Route("listarFuncionarios")]
        public IActionResult GetFuncionariosLista([FromServices] IFuncionario repositorio)
        {
            var listaFuncionarios = repositorio.GetAllFuncionarios();

            if (listaFuncionarios == null)
                return default;

            var quantidade = listaFuncionarios.Count();

            var novaLista = listaFuncionarios.Select(x => new FuncionarioListmodel
            {
                Nome = x.Nome,
                Cargo = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),
                Cpf = x.Cpf,
                Endereco = x.Endereco,
                Situacao = Enum.Parse(typeof(ESituacao), x.Situacao.ToString()).ToString(),
                CargaHoraria = x.CargaHoraria,
                DataAdmissao = DateTime.Now,
                Supervisor = new FuncModel
                {
                    Nome = x.Nome,
                    Cargo = Enum.Parse(typeof(ECargo), x.Cargo.ToString()).ToString(),
                }

            }).ToList();

            return Ok(new
            {
                quantidasde = quantidade,
                Funcionarios = novaLista
            });
        }

        //ExcluirFuncionarios
        [HttpDelete]
        [Route("excluirFuncionario")]
        public IActionResult ExcluirFuncionario([FromServices] IFuncionario funcionarioRepositorio, Guid id)
        {
            funcionarioRepositorio.Remove(id);
            funcionarioRepositorio.SaveChanges();
            return Ok();
        }

    }
}
