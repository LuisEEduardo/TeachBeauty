using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoColaboradorController : ControllerBase
    {

        ServicoColaboradorRepositorio servicoColaboradorBD;

        public ServicoColaboradorController()
        {
            servicoColaboradorBD = new ServicoColaboradorRepositorio();
        }

        // GET: api/<ServicoColaboradorController>
        [HttpGet]
        public IEnumerable<ServicoColaborador> Get()
        {
            return servicoColaboradorBD.SelecionarTudo();
        }

        // GET api/<ServicoColaboradorController>/5
        [HttpGet("{id}")]
        public ServicoColaborador Get(int id)
        {
            return servicoColaboradorBD.Selecionar(id);
        }

        // POST api/<ServicoColaboradorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServicoColaboradorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServicoColaboradorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            servicoColaboradorBD.Excluir(id);
        }
    }
}
