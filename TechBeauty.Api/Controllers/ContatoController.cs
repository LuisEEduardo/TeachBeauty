using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {

        ContatoRepositorio contatoBD;

        public ContatoController()
        {
            contatoBD = new ContatoRepositorio();
        }

        // GET: api/<ContatoController>
        [HttpGet]
        public IEnumerable<Contato> Get()
        {
            return contatoBD.SelecionarTudo();
        }

        // GET api/<ContatoController>/5
        [HttpGet("{id}")]
        public Contato Get(int id)
        {
            return contatoBD.Selecionar(id);
        }

        // POST api/<ContatoController>
        [HttpPost]
        public void Post(int tipoContatoId, string valor, int pessoaId)
        {
            contatoBD.Incluir(Contato.Criar(tipoContatoId, valor, pessoaId));
        }

        // PUT api/<ContatoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string valor)
        {
            Contato contato = contatoBD.Selecionar(id); 
            if (contato != null)
            {
                contato.AlterarValorContato(valor);
                contatoBD.Alterar(contato);
            }
        }

        // DELETE api/<ContatoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            contatoBD.Excluir(id);
        }
    }
}
