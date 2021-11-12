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
    public class PagamentoClienteFormasPagamentoController : ControllerBase
    {
        PagamentoClienteFormasPagamentoRepositorio pagamentoClienteFormasPagamentoBD;

        public PagamentoClienteFormasPagamentoController()
        {
            pagamentoClienteFormasPagamentoBD = new PagamentoClienteFormasPagamentoRepositorio();
        }


        // GET: api/<PagamentoClienteFormasPagamentoController>
        [HttpGet]
        public IEnumerable<PagamentoClienteFormasPagamento> Get()
        {
            return pagamentoClienteFormasPagamentoBD.SelecionarTudo();
        }

        // GET api/<PagamentoClienteFormasPagamentoController>/5
        [HttpGet("{id}")]
        public PagamentoClienteFormasPagamento Get(int id)
        {
            return pagamentoClienteFormasPagamentoBD.Selecionar(id);
        }

        // POST api/<PagamentoClienteFormasPagamentoController>
        [HttpPost]
        public void Post(int pagamentoClienteID, int formasPagamentoID)
        {
            pagamentoClienteFormasPagamentoBD.Incluir(PagamentoClienteFormasPagamento.Criar(pagamentoClienteID, formasPagamentoID));
        }

        // PUT api/<PagamentoClienteFormasPagamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, int pagamentoClienteID, int formasPagamentoID)
        {
            PagamentoClienteFormasPagamento pcfp = pagamentoClienteFormasPagamentoBD.Selecionar(id); 
            if (pcfp != null)
            {
                pcfp.FormasPagamentoID = formasPagamentoID;
                pcfp.PagamentoClienteID = pagamentoClienteID;
                pagamentoClienteFormasPagamentoBD.Alterar(pcfp);
            }
        }

        // DELETE api/<PagamentoClienteFormasPagamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pagamentoClienteFormasPagamentoBD.Excluir(id);
        }
    }
}
