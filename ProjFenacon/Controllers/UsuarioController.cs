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
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarUsuario")]
        public IActionResult CadastrarUsuario(
            [FromServices] IUsuario usuarioRepositorio,
            [FromBody] CadastrarUsuarioModel cadastrarUsuarioModel)
        {

            var usuario = new Usuario
            {
                Nome = cadastrarUsuarioModel.Nome,
                Email = cadastrarUsuarioModel.Email,
                Senha = cadastrarUsuarioModel.Senha,
                ConfirmaSenha = cadastrarUsuarioModel.ConfirmaSenha,
            };


            usuarioRepositorio.Add(usuario);
            usuarioRepositorio.SaveChanges();
            return Ok(usuario);
        }
    }
}
