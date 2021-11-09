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
    public class RegimeContratualController : ControllerBase
    {

        RegimeContratualRepositorio regimeContratualBD;

        public RegimeContratualController()
        {
            regimeContratualBD = new RegimeContratualRepositorio(); 
        }

        // GET: api/<RegimeContratualController>
        [HttpGet]
        public IEnumerable<RegimeContratual> Get()
        {
            return regimeContratualBD.SelecionarTudo();
        }

        // GET api/<RegimeContratualController>/5
        [HttpGet("{id}")]
        public RegimeContratual Get(int id)
        {
            return regimeContratualBD.Selecionar(id);
        }

        // POST api/<RegimeContratualController>
        [HttpPost]
        public void Post(string valor)
        {
            regimeContratualBD.Incluir(RegimeContratual.Criar(valor));
        }

        // PUT api/<RegimeContratualController>/5
        [HttpPut("{id}")]
        public void Put(int id, string valor)
        {
            RegimeContratual regimeContratual = regimeContratualBD.Selecionar(id); 
            if (regimeContratual != null)
            {
                regimeContratual.AlterarValor(valor);
                regimeContratualBD.Alterar(regimeContratual);
            }
        }

        // DELETE api/<RegimeContratualController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            regimeContratualBD.Excluir(id);
        }
    }
}
