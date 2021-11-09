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
    public class PessoaController : ControllerBase
    {
        PessoaRepositorio pessoaBD;

        public PessoaController()
        {
            pessoaBD = new PessoaRepositorio();
        }


        // GET: api/<PessoaController>
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return pessoaBD.SelecionarTudo();
        }

        // GET api/<PessoaController>/5
        [HttpGet("{id}")]
        public Pessoa Get(int id)
        {
            return pessoaBD.Selecionar(id);
        }

        // POST api/<PessoaController>
        [HttpPost]
        public void Post(string value)
        {            
        }

        // PUT api/<PessoaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PessoaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
