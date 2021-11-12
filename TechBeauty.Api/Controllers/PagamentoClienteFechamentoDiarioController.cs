using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoClienteFechamentoDiarioController : ControllerBase
    {

        PagamentoClienteFechamentoDiarioRepositorio pagamentoClienteFechamentoDiarioBD;

        public PagamentoClienteFechamentoDiarioController()
        {
            pagamentoClienteFechamentoDiarioBD = new PagamentoClienteFechamentoDiarioRepositorio();
        }

        // GET: api/<PagamentoClienteFechamentoDiarioController>
        [HttpGet]
        public IEnumerable<PagamentoClienteFechamentoDiario> Get()
        {
            return pagamentoClienteFechamentoDiarioBD.SelecionarTudo();
        }

        // GET api/<PagamentoClienteFechamentoDiarioController>/5
        [HttpGet("{id}")]
        public PagamentoClienteFechamentoDiario Get(int id)
        {
            return pagamentoClienteFechamentoDiarioBD.Selecionar(id);
        }

        // POST api/<PagamentoClienteFechamentoDiarioController>
        [HttpPost]
        public void Post(int pagamentoClienteID,
            int fechamentoDiarioID)
        {
            pagamentoClienteFechamentoDiarioBD.Incluir(PagamentoClienteFechamentoDiario.Criar(pagamentoClienteID, fechamentoDiarioID));
        }

        // PUT api/<PagamentoClienteFechamentoDiarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, int pagamentoClienteID,
            int fechamentoDiarioID)
        {
            PagamentoClienteFechamentoDiario pagamentoClienteFechamentoDiario = pagamentoClienteFechamentoDiarioBD.Selecionar(id);
            if (pagamentoClienteFechamentoDiario != null)
            {
                pagamentoClienteFechamentoDiario.PagamentoClienteID = pagamentoClienteID;
                pagamentoClienteFechamentoDiario.FechamentoDiarioID = fechamentoDiarioID;
                pagamentoClienteFechamentoDiarioBD.Alterar(pagamentoClienteFechamentoDiario);
            }
        }

        // DELETE api/<PagamentoClienteFechamentoDiarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pagamentoClienteFechamentoDiarioBD.Excluir(id);
        }
    }
}
