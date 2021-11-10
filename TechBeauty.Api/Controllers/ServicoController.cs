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
    public class ServicoController : ControllerBase
    {
        ServicoRepositorio servicoBD;

        public ServicoController()
        {
            servicoBD = new ServicoRepositorio();
        }

        // GET: api/<ServicoController>
        [HttpGet]
        public IEnumerable<Servico> Get()
        {
            return servicoBD.SelecionarTudo();
        }

        // GET api/<ServicoController>/5
        [HttpGet("{id}")]
        public Servico Get(int id)
        {
            return servicoBD.Selecionar(id);
        }

        // POST api/<ServicoController>
        [HttpPost]
        public void Post(string nome, decimal preco, string descricao, int duracaoEmMin)
        {
            servicoBD.Incluir(Servico.Criar(nome, preco, descricao, duracaoEmMin));
        }

        // PUT api/<ServicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string descricao)
        {
            Servico servico = servicoBD.Selecionar(id); 
            if (servico != null)
            {
                servico.AlterarDescricao(descricao);
                servicoBD.Alterar(servico);
            }
        }

        // DELETE api/<ServicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            servicoBD.Excluir(id);
        }
    }
}
