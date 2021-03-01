using ApiInGames.Domains;
using ApiInGames.Interfaces;
using ApiInGames.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuariosController : ControllerBase
    {
        private IUsuariosRepository _usuariosRepository;

        public UsuariosController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuariosRepository.Listar());

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_usuariosRepository.BuscarPorId(id));

        }

        [HttpPost]
        public IActionResult Post(Usuarios novoUsuario)
        {
            _usuariosRepository.Cadastrar(novoUsuario);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuariosRepository.Deletar(id);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuarios usuarios)
        {
            _usuariosRepository.Atualizar(id, usuarios);
            return StatusCode(200);
        }
    }
}
