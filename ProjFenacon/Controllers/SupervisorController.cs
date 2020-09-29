using System;
using System.Collections.Generic;
using System.Linq;
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
    public class SupervisorController : ControllerBase
    {
        private readonly ISupervisor _supervisorRepositorio;

        public SupervisorController(ISupervisor supervisorRepositorio)
        {
            _supervisorRepositorio = supervisorRepositorio;
        }

        [HttpPost]
        [Route("cadastrarSupervisor")]
        public IActionResult CadastrarSupervisor([FromServices] ISupervisor supervisorRepositorio,
            [FromBody] CadastrarSupervisorModel cadastrarSupervisorModel)
        {

            var supervisor = new Supervisor
            {
                Nome = cadastrarSupervisorModel.Nome,
            };


            supervisorRepositorio.Add(supervisor);
            supervisorRepositorio.SaveChanges();
            return Ok(supervisor);
        }
    }
}
