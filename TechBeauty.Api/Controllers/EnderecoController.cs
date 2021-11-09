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
    public class EnderecoController : ControllerBase
    {

        EnderecoRepositorio enderecoDb;

        public EnderecoController()
        {
            enderecoDb = new EnderecoRepositorio();
        }

        // GET: api/<EnderecoController>
        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            return enderecoDb.SelecionarTudo();
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        public Endereco Get(int id)
        {
            return enderecoDb.Selecionar(id);
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public void Post(string logradouro, string cidade, string uf, string numero, string cep, string bairro, string complemento)
        {
            enderecoDb.Incluir(Endereco.Criar(logradouro, cidade, uf, numero, cep, bairro, complemento));
        }

        // PUT api/<EnderecoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string logradouro, string cidade, string uf, string numero, string cep, string bairro, string complemento)
        {
            Endereco endereco = enderecoDb.Selecionar(id); 
            if (endereco != null)
            {
                endereco.Alterar(logradouro, cidade, uf, numero, complemento);
                endereco.AlterarBairro(bairro);
                endereco.AlterarCEP(cep);
                enderecoDb.Alterar(endereco);
            }
        }

        // DELETE api/<EnderecoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            enderecoDb.Excluir(id);
        }
    }
}
