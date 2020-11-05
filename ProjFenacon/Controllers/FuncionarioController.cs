using System.Linq;
using Dominio.Modelos;
using Fenacon.Dominio;
using Fenacon.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjFenacon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarGerente")]
        public ActionResult CadastrarGerente(
            [FromServices] IFuncionario repositorio,
            [FromBody] CadastrarGerenteModel model)
        {
            var gerente = new Funcionario()
            {
                Nome = model.Nome,
                Cpf = model.Cpf,
                Endereco = model.Endereco,
                Cargo = model.Cargo,
                CargaHoraria = model.CargaHoraria,
                DataAdmissao = model.DataAdmissao,
                Situacao = model.Situacao
            };

            repositorio.Add(gerente);
            repositorio.SaveChanges();
            return Ok(gerente);
        }

        [HttpGet]
        [Route("listarGerentes")]
        public ActionResult ListarGerentes(
            [FromServices] IFuncionario repositorio)
        {
            var funcionarios = repositorio.GetAll().Where(g => g.Cargo == ECargo.Gerente);
            var subordinados = repositorio.GetAll().Where(a => a.Cargo == ECargo.Analista);

            var gerentes = funcionarios.Select(g => new ListarGerenteModel
            {
                Nome = g.Nome,
                Cpf = g.Cpf,
                Endereco = g.Endereco,
                Cargo = g.Cargo,
                CargaHoraria = g.CargaHoraria,
                DataAdmissao = g.DataAdmissao,
                Situacao = g.Situacao,
                Subordinados = subordinados.Select(s => new ListarSubordinadoModel
                {
                    Nome = s.Nome,
                    SupervisorId = s.SupervisorId
                }).Where(s => s.SupervisorId == g.Id).ToList()
            }).ToList();

            return Ok(gerentes);
        }

        [HttpPost]
        [Route("cadastrarAnalista")]
        public ActionResult CadastrarAnalista(
            [FromServices] IFuncionario repositorio,
            [FromBody] CadastrarAnalistaModel model)
        {
            var supervisor = repositorio.GetById(model.SupervisorId);

            var analista = new Funcionario()
            {
                Nome = model.Nome,
                Cpf = model.Cpf,
                Endereco = model.Endereco,
                Cargo = model.Cargo,
                CargaHoraria = model.CargaHoraria,
                DataAdmissao = model.DataAdmissao,
                Situacao = model.Situacao,
                Supervisor = supervisor,                
            };

            repositorio.Add(analista);
            repositorio.SaveChanges();
            return Ok("Analista adicionado com sucesso");
        }

        [HttpGet]
        [Route("listarAnalistas")]
        public ActionResult ListarAnalistas(
            [FromServices] IFuncionario repositorio)
        {
            var funcionarios = repositorio.GetAll().Where(a => a.Cargo == ECargo.Analista);
            var subordinados = repositorio.GetAll().Where(t => t.Cargo == ECargo.Tecnico || t.Cargo == ECargo.Estagiario);


            var analistas = funcionarios.Select(a => new ListarAnalistaModel
            {
                Nome = a.Nome,
                Cpf = a.Cpf,
                Endereco = a.Endereco,
                Cargo = a.Cargo,
                CargaHoraria = a.CargaHoraria,
                DataAdmissao = a.DataAdmissao,
                Situacao = a.Situacao,
                Subordinados = subordinados.Select(s => new ListarSubordinadoModel
                {
                    Nome = s.Nome,
                    SupervisorId = s.SupervisorId
                }).Where(s => s.SupervisorId == a.Id).ToList(),
                SupervisorId = a.SupervisorId
            }).ToList();

            return Ok(analistas);
        }

        [HttpPost]
        [Route("cadastrarFuncionarioComum")]
        public ActionResult CadastrarFuncionarioComum(
            [FromServices] IFuncionario repositorio,
            [FromBody] CadastrarFuncionarioModel model)
        {
            var supervisor = repositorio.GetById(model.SupervisorId);

            var funcionario = new Funcionario()
            {
                Nome = model.Nome,
                Cpf = model.Cpf,
                Endereco = model.Endereco,
                Cargo = model.Cargo,
                CargaHoraria = model.CargaHoraria,
                DataAdmissao = model.DataAdmissao,
                Situacao = model.Situacao,
                Supervisor = supervisor,
            };

            repositorio.Add(funcionario);
            repositorio.SaveChanges();
            return Ok("Funcionário adicionado com sucesso");
        }

        [HttpGet]
        [Route("listarFuncionariosComuns")]
        public ActionResult ListarFuncionariosComuns(
            [FromServices] IFuncionario repositorio)
        {
            var funcionarios = repositorio.GetAll().Where(f => f.Cargo == ECargo.Tecnico || f.Cargo == ECargo.Estagiario);
            
            var estagiariosETecnicos = funcionarios.Select(a => new ListarFuncionarioModel
            {
                Nome = a.Nome,
                Cpf = a.Cpf,
                Endereco = a.Endereco,
                Cargo = a.Cargo,
                CargaHoraria = a.CargaHoraria,
                DataAdmissao = a.DataAdmissao,
                Situacao = a.Situacao,
                SupervisorId = a.SupervisorId
            }).ToList();

            return Ok(estagiariosETecnicos);
        }

        [HttpGet]
        [Route("listarTodosFuncionarios")]
        public IActionResult ListarTodosFuncionarios([FromServices] IFuncionario repositorio)
        {
            var funcionarios = repositorio.GetAll();
            var resultado = funcionarios.Select(f => new ListarFuncionarioModel
            {
                Nome = f.Nome,
                Cpf = f.Cpf,
                Endereco = f.Endereco,
                Cargo = f.Cargo,
                CargaHoraria = f.CargaHoraria,
                DataAdmissao = f.DataAdmissao,
                Situacao = f.Situacao,
                SupervisorId = f.SupervisorId
            }).ToList();

            return Ok(resultado);
        }
    }
}
