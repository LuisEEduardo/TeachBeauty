using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoColaboradorController : ControllerBase
    {
        PagamentoColaboradorRepositorio pagamentoColaboradorBD;

        public PagamentoColaboradorController()
        {
            pagamentoColaboradorBD = new PagamentoColaboradorRepositorio();
        }

        // GET: api/<PagamentoColaboradorController>
        [HttpGet]
        public IEnumerable<PagamentoColaborador> Get()
        {
            return pagamentoColaboradorBD.SelecionarTudo();
        }

        // GET api/<PagamentoColaboradorController>/5
        [HttpGet("{id}")]
        public PagamentoColaborador Get(int id)
        {
            return pagamentoColaboradorBD.Selecionar(id);
        }

        // POST api/<PagamentoColaboradorController>
        [HttpPost]
        public void Post(StatusPagamento statusPagamento, DateTime dataPagamento,
            decimal valor, Tipo tipo)
        {
            pagamentoColaboradorBD.Incluir(PagamentoColaborador.Criar(statusPagamento, dataPagamento, valor, tipo));
        }

        // PUT api/<PagamentoColaboradorController>/5
        [HttpPut("{id}")]
        public void Put(int id, StatusPagamento statusPagamento, DateTime dataPagamento,
            decimal valor)
        {
            PagamentoColaborador pagamentoColaborador = pagamentoColaboradorBD.Selecionar(id);
            if (pagamentoColaborador != null)
            {
                pagamentoColaborador.StatusPagamento = statusPagamento;
                pagamentoColaborador.DataPagamento = dataPagamento;
                pagamentoColaborador.Valor = valor;
                pagamentoColaboradorBD.Alterar(pagamentoColaborador);
            }
        }

        // DELETE api/<PagamentoColaboradorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pagamentoColaboradorBD.Excluir(id);
        }
    }
}
