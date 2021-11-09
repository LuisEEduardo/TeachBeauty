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
    public class ClienteController : ControllerBase
    {

        ClienteRepositorio clienteBD;

        public ClienteController()
        {
            clienteBD = new ClienteRepositorio();
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return clienteBD.SelecionarTudo();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return clienteBD.Selecionar(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post()
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clienteBD.Excluir(id);
        }
    }
}
