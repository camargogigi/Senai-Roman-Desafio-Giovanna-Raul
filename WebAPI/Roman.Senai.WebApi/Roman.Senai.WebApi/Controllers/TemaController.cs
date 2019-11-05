using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Roman.Senai.WebApi.Domains;
using Roman.Senai.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Senai.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TemaController : ControllerBase
    {
        TemaRepository temaRepository = new TemaRepository();

        //listar
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(temaRepository.Listar());
        }//fim listar

        //cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Tema tema)
        {
            try
            {
                temaRepository.Cadastrar(tema);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "IIIIIII deu ruim" + ex.Message });
            }
        }//fim cadastrar

        [Authorize(Roles = "AUTORIZADO")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tema tema)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                temaRepository.Atualizar(id, tema);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "IIIIIII deu ruim" + ex.Message });
            }
        }//fim atualizar
    }
