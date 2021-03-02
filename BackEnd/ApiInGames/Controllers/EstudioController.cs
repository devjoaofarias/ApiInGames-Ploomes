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
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        /// <summary>
        /// Listar todos os estúdios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estudioRepository.Listar());

        }

        /// <summary>
        /// Listar um estúdio específico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_estudioRepository.BuscarPorId(id));

        }

        /// <summary>
        /// Cadastrar um novo estúdio
        /// </summary>
        /// <param name="novoEstudio"></param>
        /// <returns></returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Estudio novoEstudio)
        {
            _estudioRepository.Cadastrar(novoEstudio);
            return StatusCode(200);
        }

        /// <summary>
        /// Deletar um estúdio
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _estudioRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Editar um estúdio
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estudio"></param>
        /// <returns></returns>
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Estudio estudio)
        {
            _estudioRepository.Atualizar(id, estudio);
            return StatusCode(200);
        }

        /// <summary>
        /// Listar os estúdios e seus respectivos jogos
        /// </summary>
        /// <returns></returns>
        [HttpGet("Jogo")]
        public IActionResult GetJogos()
        {
            return Ok(_estudioRepository.ListarJogos());
        }
    }
}