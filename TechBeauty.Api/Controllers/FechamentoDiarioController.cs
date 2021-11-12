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
    public class FechamentoDiarioController : ControllerBase
    {

        FechamentoDiarioRepositorio fechamentoDiarioDB;
        public FechamentoDiarioController()
        {
            fechamentoDiarioDB = new FechamentoDiarioRepositorio();
        }

        /// GET: api/<FechamentoDiarioController>
        [HttpGet]
        public IEnumerable<FechamentoDiario> Get()
        {
            return fechamentoDiarioDB.SelecionarTudo();
        }

        // GET api/<FechamentoDiarioController>/5
        [HttpGet("{id}")]
        public FechamentoDiario Get(int id)
        {
            return fechamentoDiarioDB.Selecionar(id);
        }

        // POST api/<FechamentoDiarioController>
        [HttpPost]
        public void Post(DateTime dataFechamento, decimal valorFechamento)
        {
            fechamentoDiarioDB.Incluir(FechamentoDiario.Criar(dataFechamento, valorFechamento));
        }

        // PUT api/<FechamentoDiarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, decimal valorFechamento)
        {
            FechamentoDiario fechamentoDiario = fechamentoDiarioDB.Selecionar(id);
            if (fechamentoDiario != null)
            {
                fechamentoDiario.MudarValorFechamento(valorFechamento);
                fechamentoDiarioDB.Alterar(fechamentoDiario);
            }
        }

        // DELETE api/<FechamentoDiarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            fechamentoDiarioDB.Excluir(id);
        }
    }
}
