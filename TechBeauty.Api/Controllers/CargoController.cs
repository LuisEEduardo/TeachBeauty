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
    public class CargoController : ControllerBase
    {
        
        CargoRepositorio cargoBD;

        public CargoController()
        {
            cargoBD = new CargoRepositorio();
        }

        // GET: api/<CargoController>
        [HttpGet]
        public IEnumerable<Cargo> Get()
        {
            return cargoBD.SelecionarTudo();
        }

        // GET api/<CargoController>/5
        [HttpGet("{id}")]
        public Cargo Get(int id)
        {
            return cargoBD.Selecionar(id);
        }

        // POST api/<CargoController>
        [HttpPost]
        public void Post(string nome, string descricao)
        {
            cargoBD.Incluir(Cargo.Criar(nome, descricao));
        }

        // PUT api/<CargoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string nome, string descricao)
        {
            Cargo cargo = cargoBD.Selecionar(id);
            if (cargo != null)
            {
                cargo.MudarNome(nome);
                cargo.MudarDescricao(descricao);
                cargoBD.Alterar(cargo);
            }
        }

        // DELETE api/<CargoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            cargoBD.Excluir(id);
        }
    }
}
