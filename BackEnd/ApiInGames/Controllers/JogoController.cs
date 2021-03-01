using ApiInGames.Domains;
using ApiInGames.Interfaces;
using ApiInGames.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository;

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_jogoRepository.Listar());

        }

        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_jogoRepository.BuscarPorId(id));

        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Jogo novoJogo)
        {
            _jogoRepository.Cadastrar(novoJogo);
            return StatusCode(200);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _jogoRepository.Deletar(id);
            return StatusCode(200);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Jogo jogo)
        {
            _jogoRepository.Atualizar(id, jogo);
            return StatusCode(200);
        }

        [HttpGet("Estudio")]
        public IActionResult GetEstudios()
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_jogoRepository.ListarComEstudios());
        }
    }
}


