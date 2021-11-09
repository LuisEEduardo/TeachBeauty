using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoContatoController : ControllerBase
    {

        TipoContatoRepositorio tipoContatoBD;

        public TipoContatoController()
        {
            tipoContatoBD = new TipoContatoRepositorio();
        }


        // GET: api/<TipoContatoController>
        [HttpGet]
        public IEnumerable<TipoContato> Get()
        {
            return tipoContatoBD.SelecionarTudo();
        }

        // GET api/<TipoContatoController>/5
        [HttpGet("{id}")]
        public TipoContato Get(int id)
        {
            return tipoContatoBD.Selecionar(id);
        }

        // POST api/<TipoContatoController>
        [HttpPost]
        public void Post(string valor)
        {
            tipoContatoBD.Incluir(TipoContato.Criar(valor));
        }

        // PUT api/<TipoContatoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string valor)
        {
            TipoContato tipoContato = tipoContatoBD.Selecionar(id); 
            if (tipoContato != null)
            {
                tipoContato.AlterarValor(valor);
                tipoContatoBD.Alterar(tipoContato);
            }
        }

        // DELETE api/<TipoContatoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tipoContatoBD.Excluir(id);
        }
    }
}
