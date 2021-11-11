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
    public class CargoContratoTrabalhoController : ControllerBase
    {

        CargoContratoTrabalhoRepositorio cargoContratoTrabalhoBD;

        public CargoContratoTrabalhoController()
        {
            cargoContratoTrabalhoBD = new CargoContratoTrabalhoRepositorio();
        }


        // GET: api/<CargoContratoTrabalhoController>
        [HttpGet]
        public IEnumerable<CargoContratoTrabalho> Get()
        {
            return cargoContratoTrabalhoBD.SelecionarTudo();
        }

        // GET api/<CargoContratoTrabalhoController>/5
        [HttpGet("{id}")]
        public CargoContratoTrabalho Get(int id)
        {
            return cargoContratoTrabalhoBD.Selecionar(id);
        }

        // POST api/<CargoContratoTrabalhoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CargoContratoTrabalhoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CargoContratoTrabalhoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
