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
    public class CaixaController : ControllerBase
    {

        CaixaRepositorio caixaDB;

        public CaixaController()
        {
            caixaDB = new CaixaRepositorio();
        }

        // GET: api/<CaixaController>
        [HttpGet]
        public IEnumerable<Caixa> Get()
        {
            return caixaDB.SelecionarTudo();
        }

        // GET api/<CaixaController>/5
        [HttpGet("{id}")]
        public Caixa Get(int id)
        {
            return caixaDB.Selecionar(id);
        }

        // POST api/<CaixaController>
        [HttpPost]
        public void Post(decimal valorEmCaixa, decimal valorMovimentado, string descricao,
            int colaboradorId)
        {
            caixaDB.Incluir(Caixa.Criar(valorEmCaixa, valorMovimentado, descricao, colaboradorId));
        }

        //// PUT api/<CaixaController>/5
        //[HttpPut("{id}")]
        //public void AddValor (int id, decimal addValor)
        //{
        //    Caixa caixa = caixaDB.Selecionar(id);
        //    caixa.AddValor(addValor);
        //    caixaDB.Alterar(caixa);

        //}

        // PUT api/<CaixaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CaixaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
