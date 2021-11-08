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
    public class GeneroController : ControllerBase
    {

        GeneroRepositorio generoBD;

        public GeneroController()
        {
            generoBD = new GeneroRepositorio(); 
        }

        // GET: api/<GeneroController>
        [HttpGet]
        public IEnumerable<Genero> Get()
        {
            return generoBD.SelecionarTudo();
        }

        // GET api/<GeneroController>/5
        [HttpGet("{id}")]
        public Genero Get(int id)
        {
            return generoBD.Selecionar(id);
        }

        // POST api/<GeneroController>
        [HttpPost]
        public void Post(string valor)
        {
            generoBD.Incluir(Genero.Criar(valor));
        }

        // PUT api/<GeneroController>/5
        [HttpPut("{id}")]
        public void Put(int id, string valor)
        {
            Genero genero = generoBD.Selecionar(id);
            if (genero != null)
            {
                genero.AlterarValor(valor);
                generoBD.Alterar(genero);
            }
        }

        // DELETE api/<GeneroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            generoBD.Excluir(id);
        }
    }
}
