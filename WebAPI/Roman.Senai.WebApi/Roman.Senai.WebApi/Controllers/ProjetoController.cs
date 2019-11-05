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
    public class ProjetoController : ControllerBase
    {
        ProjetoRepository projetoRepository = new ProjetoRepository();

        //listar
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(projetoRepository.Listar());
        }//fim listar

        //cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                projetoRepository.Cadastrar(projeto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "IIIIIII deu ruim" + ex.Message });
            }
        }//fim cadastrar

    }
}
